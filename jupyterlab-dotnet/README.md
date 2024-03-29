# Jupyterlab .NET

![Docker Cloud Automated build](https://img.shields.io/docker/cloud/automated/jdelemar/jupyterlab-dotnet)
![Docker Cloud Build Status](https://img.shields.io/docker/cloud/build/jdelemar/jupyterlab-dotnet)
![Docker Image Size (latest by date)](https://img.shields.io/docker/image-size/jdelemar/jupyterlab-dotnet?sort=date)
![MicroBadger Layers](https://img.shields.io/microbadger/layers/jdelemar/jupyterlab-dotnet)

![Alpine 3.15.4](https://img.shields.io/badge/Alpine-3.15.4-blue.svg?style=flat-square)
![Juypterlab 3.3.4](https://img.shields.io/badge/Jupyterlab-3.3.4-blue.svg?style=flat-square)
![Python 3.9.12](https://img.shields.io/badge/Python-3.9.12-blue.svg?style=flat-square)
![TypeScript 4.1.2](https://img.shields.io/badge/TypeScript-4.1.2-blue.svg?style=flat-square)
![.NET Core SDK 6.0.202](https://img.shields.io/badge/.NET%20Core%20SDK-6.0.202-blue.svg?style=flat-square)
![.NET Core SDK 5.0.407](https://img.shields.io/badge/.NET%20Core%20SDK-5.0.407-blue.svg?style=flat-square)
![.NET Core SDK 3.1.418](https://img.shields.io/badge/.NET%20Core%20SDK-3.1.418-blue.svg?style=flat-square)

Jupyterlab Docker image based on [mikebirdgeneau/jupyterlab-docker](https://github.com/mikebirdgeneau/jupyterlab-docker)

This image adds .NET Core 3 to `jdelemar/jupyter` notebook  

**Screen shots**  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab-dotnet/images/JupyterDotNetLauncher.png" alt="launcher" width="800" />  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab-dotnet/images/JupyterDotNet3.png" alt="TypeScript" width="800" />  

## Try

[![Try in PWD](https://github.com/play-with-docker/stacks/raw/cff22438cb4195ace27f9b15784bbb497047afa7/assets/images/button.png)](http://play-with-docker.com/?stack=https://gist.githubusercontent.com/JDelemar/93f2c88e3fdb00ba7671ea5f68952647/raw/31d14019aa8aca0177894055bcd390f48c83961c/jupyterlab-dotnet.yml)

Note: Check the logs/output for password/token (`docker logs {container_name}`). Also code is currently not executing in PWD  

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

🐧 Alpine 3.15.4  
📏 1.64GB  
🛳 8888  
🌐 Jupyterlab 3.3.4  
🌐 Python 3.9.12  
🌐 TypeScript 4.1.2  
🌐 .NET Core SDK 6.0.202/5.0.407/3.1.418

#### Versions

- Versions
  - Latest
    - jdelemar/jupyterlab-dotnet:latest
    - jdelemar/jupyterlab-dotnet:6.0.202
    - jdelemar/jupyterlab-dotnet:6
    - jdelemar/jupyterlab-dotnet:5.0.407
    - jdelemar/jupyterlab-dotnet:5
    - jdelemar/jupyterlab-dotnet:3.1.418
    - jdelemar/jupyterlab-dotnet:3

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
      - dotnet
        - [dotnet-docker on GitHub](https://github.com/dotnet/dotnet-docker)
      - .NET Core SDK
        - Docker
          - [.NET Core SDK](https://hub.docker.com/_/microsoft-dotnet-core-sdk)
            - [GitHub Dockerfile source for .NET Core SDK: 3.1.404 Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/master/src/sdk/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for ASP.NET Core 2.1/3.1 Runtime: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/63b8443439ec2ad494d704ced088e4657ea8f255/src/aspnet/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for .NET Core Runtime: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/63b8443439ec2ad494d704ced088e4657ea8f255/src/runtime/3.1/alpine3.12/amd64/Dockerfile)
            - [GitHub Dockerfile source for .NET Core Runtime Dependencies: Alpine 3.12](https://github.com/dotnet/dotnet-docker/blob/c0e8be8a44b47b1dcc2a5b4b2ebd92022087ac0b/src/runtime-deps/3.1/alpine3.12/amd64/Dockerfile)
        - [Install .NET Core SDK or .NET Core Runtime on Alpine](https://docs.microsoft.com/en-us/dotnet/core/install/linux-alpine)
          - Manual install
