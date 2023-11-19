namespace RebusDemo
{
  using Bootstrapper;
  using Contexts;
  using Services;

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Program Started");

      _ = Bootstrapper
        .Init()
        .Db()
        .SimpleInjector()
        .RegisterPackages()
        .RegisterRebus("rebus.Input"); // For some reason this can't be run before the database is created?

      var container = Bootstrapper.Container;

      if (container == null)
      {
        Console.WriteLine("Could not retrieve SimpleInjector.Container");
        return;
      }

      container.Register<Greeter>();

      container.Verify();

      try
      {
        using (var context = new ApplicationContext())
        {
          Console.WriteLine($"Total Products: {context.Products?.Count()}");
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
    public string Name { get; set; } = string.Empty;
  }
}

#endregion

#region Contexts

namespace Contexts
{
  using System.Data.Entity;
  using Constants;
  using Entities;

  public class ApplicationContext : DbContext
  {
    public ApplicationContext() : base(Constant.ConnectionString.ApplicationContext) { }

    public DbSet<Product>? Products { get; set; }
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
  using Contexts;
  using Migrations;
  using Rebus.Activation;
  using Rebus.Bus;
  using Rebus.Config;
  using SimpleInjector;
  using System.Data.Entity;

  public interface IBoostrapper
  {
    IBoostrapper Db();
    IBoostrapper SimpleInjector();
    IBoostrapper RegisterPackages();
    IBoostrapper RegisterRebus(string inputQueueName, int maxWorkers = 1, int maxParallelism = 5);
  }

  public sealed class Bootstrapper : IBoostrapper
  {
    private Bootstrapper() { }

    public static Container? Container { get; private set; }

    public static IBoostrapper Init() => new Bootstrapper();

    public IBoostrapper Db()
    {
      Console.WriteLine("Validating migrations");

      using (var context = new ApplicationContext())
      {
        Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationContext, Configuration>());

        context.Database.Initialize(force: false);
      }

      return this;
    }

    public IBoostrapper SimpleInjector()
    {
      Container = new Container();

      return this;
    }

    public IBoostrapper RegisterPackages()
    {
      Container?.Register<IGreetingService, ConsoleGreetingService>();

      return this;
    }

    public IBoostrapper RegisterRebus(string inputQueueName, int maxWorkers = 1, int maxParallelism = 5)
    {
      Container?.Register<IBus>(
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
                t.UseSqlServer(new SqlServerTransportOptions(Constant.ConnectionString.ApplicationContext), inputQueueName);
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
