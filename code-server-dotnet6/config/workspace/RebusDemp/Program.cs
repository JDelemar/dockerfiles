namespace RebusDemo {
  using Bootstrapper;
  using Contexts;
  using Infrastructure;
  using Services;

  class Program
  {
    static void Main(string[] args)      {
      Console.WriteLine("Program Started");
      
      CheckMigrations.Core();

      _ = Bootstrapper
        .Init()
        .SimpleInjector()
        .RegisterPackages();
        //.RegisterRebus("rebus.Input"); // For some reason this can't be run before the database is created

      var container = Bootstrapper.Container;

      container.Register<Greeter>();

      container.Verify();

      try
      {
        using (var context = new ApplicationContext())
        {
          Console.WriteLine($"Total Products: {context.Products.Count()}");
        }        
      }
      catch (System.Exception ex)
      {
        Console.WriteLine(ex.Message);
        throw;
      }

      var greeter = container.GetInstance<Greeter>();
      greeter.SayHello("world");

      Console.WriteLine("Program Ended");
    }
  }
}

#region Constants

namespace Constants
{
    public static class Constant
    {
        public static class ConnectionString
        {
            public static string ApplicationContext => @"Server=db;Database=RebusDemo;User=SA;Password=Str0ngP@ssw0rd;TrustServerCertificate=True;";
        }
    }
}

#endregion

#region Entities

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

#endregion

#region Contexts

namespace Contexts
{
    using System.Data.Entity;
    using Constants;
    using Entities;
    using Migrations;

    public class ApplicationContext : DbContext
    {
        public static Configuration GetConfiguration
        {
            get
            {
                var config = new Configuration();
                return config;
            }
        }
        
        public ApplicationContext() : base(Constant.ConnectionString.ApplicationContext) {}

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, Configuration>());
        }
    }
}

#endregion

#region Migrations

namespace Migrations
{
  using Contexts;
  using System.Data.Entity.Migrations;

  public sealed class Configuration : DbMigrationsConfiguration<ApplicationContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = true;
      AutomaticMigrationDataLossAllowed = false;
    }

    protected override void Seed(ApplicationContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data.
      //base.Seed(context);
    }
  }
}

#endregion

#region Infrastructure

namespace Infrastructure
{
  using Contexts;
  using System.Data.Entity.Migrations;

  public static class CheckMigrations
  {
    public static void Core() {
      Console.WriteLine("Checking migrations....");

      var migrator = new DbMigrator(ApplicationContext.GetConfiguration);

      var pendingMigrations = migrator.GetPendingMigrations();

      if (pendingMigrations.Any())
      {
          migrator.Update();
          Console.WriteLine("...Migrations applied successfully.");
      }
      else
      {
          Console.WriteLine("...No pending migrations.");
      }
    }
  }
}

#endregion

#region Services

namespace Services
{
    public interface IGreetingService
    {
        void Greet(string name);
    }

    public class ConsoleGreetingService : IGreetingService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }

    public class Greeter
    {
        private readonly IGreetingService greetingService;

        public Greeter(IGreetingService greetingService)
        {
            this.greetingService = greetingService;
        }

        public void SayHello(string name)
        {
            this.greetingService.Greet(name);
        }
    }
}

#endregion

#region Bootstrapper

namespace Bootstrapper
{
    using Services;
    using Constants;
    using Rebus.Activation;
    using Rebus.Bus;
    using Rebus.Config;
    using SimpleInjector;

    public interface IBoostrapper
    {
        IBoostrapper SimpleInjector();
        IBoostrapper RegisterPackages();
        IBoostrapper RegisterRebus(string inputQueueName, int maxWorkers = 1, int maxParallelism = 5);
    }

    public sealed class Bootstrapper : IBoostrapper
    {
        private Bootstrapper() { }

        public static Container Container { get; private set; }

        public static IBoostrapper Init() => new Bootstrapper();
        
        public IBoostrapper SimpleInjector()
        {
            Container = new Container();

            return this;
        }

        public IBoostrapper RegisterPackages()
        {
            Container.Register<IGreetingService, ConsoleGreetingService>();

            return this;
        }
    
        public IBoostrapper RegisterRebus(string inputQueueName, int maxWorkers = 1, int maxParallelism = 5)
        {
            Container.Register<IBus>(
                () =>
                {
                    using var activator = new BuiltinHandlerActivator();
                    var bus = Configure.With(activator)
                        .Logging(l =>
                        {
                            l.None();
                        })
                        .Transport(t =>
                        {
                            t.UseSqlServer(Constant.ConnectionString.ApplicationContext, inputQueueName);
                        })
                        .Subscriptions(s =>
                        {
                            s.StoreInSqlServer(Constant.ConnectionString.ApplicationContext, "rebus.Subscriptions", true);
                        })
                        .Options(o =>
                        {
                            o.SetNumberOfWorkers(maxWorkers);
                            o.SetMaxParallelism(maxParallelism);
                        })
                        .Start();

                    return bus;
                }, Lifestyle.Singleton);

            return this;
        }
    }
}

#endregion
