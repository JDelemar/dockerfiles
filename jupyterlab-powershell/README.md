# Jupyterlab PowerShell

![Docker Cloud Automated build](https://img.shields.io/docker/cloud/automated/jdelemar/jupyterlab-powershell)
![Docker Cloud Build Status](https://img.shields.io/docker/cloud/build/jdelemar/jupyterlab-powershell)
![Docker Image Size (latest by date)](https://img.shields.io/docker/image-size/jdelemar/jupyterlab-powershell?sort=date)
![MicroBadger Layers](https://img.shields.io/microbadger/layers/jdelemar/jupyterlab-powershell)

![Alpine 3.12.1](https://img.shields.io/badge/Alpine-3.12.1-blue.svg?style=flat-square)
![Juypterlab 2.2.9](https://img.shields.io/badge/Jupyterlab-2.2.9-blue.svg?style=flat-square)
![Python 3.9.0](https://img.shields.io/badge/Python-3.9.0-blue.svg?style=flat-square)
![TypeScript 3.9.5](https://img.shields.io/badge/TypeScript-3.9.5-blue.svg?style=flat-square)
![.NET Core SDK 3.1.403](https://img.shields.io/badge/.NET%20Core%20SDK-3.1.403-blue.svg?style=flat-square)
![PowerShell 7.0.3](https://img.shields.io/badge/PowerShell-7.0.3-blue.svg?style=flat-square)

Jupyterlab Docker image based on [mikebirdgeneau/jupyterlab-docker](https://github.com/mikebirdgeneau/jupyterlab-docker)

This image adds PowerShell to `jdelemar/jupyterlab-dotnet` notebook  

**Screen shots**  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab-powershell/images/JupyterLauncher.png" alt="launcher" width="800" />  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab-powershell/images/JupyterPowerShell.png" alt="TypeScript" width="800" />  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab-powershell/images/VSCodeJupyter.png" alt="VSCode" width="800" />  

## How to use this image

### Quick start

```s
  docker run -p 8888:8888 jdelemar/jupyterlab-powershell
```

### Other Configurations

#### Persist notebook data

```s
  docker run -p 8888:8888 -v jupyter-data:/opt/app/data jdelemar/jupyterlab-powershell
```

#### Container info

🐧 Alpine 3.12.1  
📏 1.6GB  
🛳 8888  
🌐 Jupyterlab 2.2.9  
🌐 Python 3.9.0  
🌐 TypeScript 3.9.5  
🌐 .NET Core SDK 3.1.403  
🌐 PowerShell 7.0.3  

#### Versions

- Versions
  - Latest
    - jdelemar/jupyterlab-powershell:latest
    - jdelemar/jupyterlab-powershell:2.2.9
    - jdelemar/jupyterlab-powershell:2.2.9-python-3.9.0-alpine-3.12.1

## Sources

- Sources
  - [GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/jupyterlab-powershell)  
  - [Docker repository](https://hub.docker.com/repository/docker/jdelemar/jupyterlab-powershell)  
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
      - [Public Preview of PowerShell Support in Jupyter Notebooks](https://devblogs.microsoft.com/powershell/public-preview-of-powershell-support-in-jupyter-notebooks/)
      - [Working with Jupyter Notebooks in Visual Studio Code](https://code.visualstudio.com/docs/python/jupyter-support)
