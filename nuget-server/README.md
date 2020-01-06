# Nuget with http-server

Nuget, Nuget, Nuget what I want  
Nuget command with http-server in a browser  

# Try
[![Try in PWD](https://github.com/play-with-docker/stacks/raw/cff22438cb4195ace27f9b15784bbb497047afa7/assets/images/button.png)](http://play-with-docker.com/?stack=https://gist.githubusercontent.com/JDelemar/4c6ef899c98f3f52921881c646e9f0aa/raw/faf3c5d2ff6df7772864018fb42dc918eacd442d/nuget-server.yml)  

# How to use this image
## Quick start
```s
    docker run -it -p 8080:8080 jdelemar/nuget-server /bin/sh
    # at the command prompt type:
    cd ~
    # to get a NuGet package and all it's dependencies
    # nuget install packageId|pathToPackagesConfig
    # ex:
    nuget install Specflow -Version 3.0.225
```

`docker.compose.yml`
```yml
    version: "3.1"

    services:
    nuget-server:
        image: jdelemar/nuget-server
        command: tail -f /dev/null
        ports:
        - 8080:8080
```  

Type `http-server` or `hs` to browse/download files from the container at http://localhost:8080  

### Container info
📂nuget - `~/nuget`  
📏396MB  
🛳8080 - http-server  

# Sources
[GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/nuget-server)  
[Docker repository](https://hub.docker.com/r/jdelemar/nuget-server)  
[CenterEdge Docker.NuGetClient source code](https://github.com/CenterEdge/Docker.NuGetClient)  
[CERTIFICATE_VERIFY_FAILED using Microsoft.SharePoint.Client package](https://github.com/Docker-Hub-frolvlad/docker-alpine-mono/issues/7)  
[Mono Docker image](https://github.com/mono/docker)

# License
View [license information](https://github.com/JDelemar/dockerfiles/blob/master/LICENSE) for this Docker project.  

As with all Docker images, these likely also contain other software which may be under other licenses (such as Bash, etc from the base distribution, along with any direct or indirect dependencies of the primary software being contained).  

As for any pre-built image usage, it is the image user's responsibility to ensure that any use of this image complies with any relevant licenses for all software contained within.  
