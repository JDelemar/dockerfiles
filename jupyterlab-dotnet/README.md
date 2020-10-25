# Jupyterlab

Jupyterlab Docker image based on [mikebirdgeneau/jupyterlab-docker](https://github.com/mikebirdgeneau/jupyterlab-docker)

This image adds .NET Core to `jdelemar/jupyter` notebook  

**Screen shots**  
![launcher](https://github.com/JDelemar/dockerfiles/blob/master/jupyterlab-dotnet/images/JupyterLauncher.png)  
![TypeScript](https://github.com/JDelemar/dockerfiles/blob/master/jupyterlab-dotnet/images/JupyterCSharp.png)  

## How to use this image

### Quick start

```s
  docker run -p 8888:8888 jdelemar/jupyterlab-dotnet
```

### Other Configurations

#### Persist notebook data

```s
  docker run -p 8888:8888 -v jupyter-data:/opt/app/data jdelemar/jupyterlab-dotnet
```

#### Container info

🐧 Alpine 3.12.1  
📏 1.5GB  
🛳 8888  
🌐 Jupyterlab 2.2.9  
🌐 Python 3.9.0  
🌐 .NET Core SDK 3.1.403

#### Versions

- Versions
  - Latest
    - jdelemar/jupyterlab-dotnet:latest
    - jdelemar/jupyterlab-dotnet:2.2.9
    - jdelemar/jupyterlab-dotnet:2.2.9-python-3.9.0-alpine-3.12.1

## Sources

- Sources
  - [GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/jupyterlab-dotnet)  
  - [Docker repository](https://hub.docker.com/repository/docker/jdelemar/jupyterlab-dotnet)  
  - [Docker mikebirdgeneau/jupyterlab on Docker hub](https://hub.docker.com/r/mikebirdgeneau/jupyterlab), [Github](https://github.com/mikebirdgeneau/jupyterlab-docker)
  - TypeScript
    - [Jupyter Notebooks with ES6 and TypeScript slides](https://slides.com/yearofmoo/jupyter-notebooks-with-es6-and-typescript/fullscreen)

      ```bash
        RUN apk add --update npm

        # Install TS & ES6 support
        RUN npm install -g tslab && \
          tslab install
      ```

  - Csharp
    - [Run C# Machine Learning Code Directly In A Jupyter Notebook](https://medium.com/machinelearningadvantage/run-c-machine-learning-code-directly-in-a-jupyter-notebook-a32e13e40b9c)
    - Microsoft
      - .NET Core SDK
        - Docker
          - [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-core-sdk)
            - [GitHub Dockerfile source for .NET Core SDK: 3.1.403 Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/63b8443439ec2ad494d704ced088e4657ea8f255/src/sdk/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for ASP.NET Core 2.1/3.1 Runtime: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/63b8443439ec2ad494d704ced088e4657ea8f255/src/aspnet/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for .NET Core Runtime: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/63b8443439ec2ad494d704ced088e4657ea8f255/src/runtime/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for .NET Core Runtime Dependencies: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/c0e8be8a44b47b1dcc2a5b4b2ebd92022087ac0b/src/runtime-deps/3.1/alpine3.12/amd64/Dockerfile)
        - [Install .NET Core SDK or .NET Core Runtime on Alpine](https://docs.microsoft.com/en-us/dotnet/core/install/linux-alpine)
          - Manual install
