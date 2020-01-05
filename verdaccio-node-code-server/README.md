# Vercaccio, Visual Studio Code, and nodejs

Verdaccio, Visual Studio Code, and nodejs walk into a bar

This image contains [Verdaccio](https://github.com/verdaccio/verdaccio), [Visual Studio Code](https://code.visualstudio.com/) via [Coder](https://coder.com/), and [nodejs](https://nodejs.org/)  

The main purpose of this project is to be able grab npm packages using a browser as an interface

[![code-server](https://github.com/JDelemar/dockerfiles/blob/master/verdaccio-node-code-server/image/ide.gif)](https://coder.com)

# Try
(TODO: place `Try in PWD` button here)  

# How to use this image
## Quick start
```s
    docker run -it -p 8443:8443 jdelemar/verdaccio-node-code-server /bin/bash
```

Visual Studio Code will be available in your browser at http://localhost:8443

## Other configurations
```s
    # Open everything
    docker run -it --rm -p 8443:8443 -p 4873:4873 -p 8080:8080 -p 4200:4200 verdaccio-node-code-server /bin/bash

    # Some additional settings from Code-Server - see Code-Server via LinuxServer.io link for more
    docker create \
        --name=code-server \
        -e PUID=1000 \
        -e PGID=1000 \
        -e TZ=America/New_York \
        -e PASSWORD=password `#optional` \
        -e SUDO_PASSWORD=password `#optional` \
        -p 8443:8443 \
        -v /path/to/appdata/config:/config \
        --restart unless-stopped \
        verdaccio-node-code-server
```
- Code-Server: http://localhost:8443
- Verdaccio  
    - Start `verdaccio --listen http://0.0.0.0:4873`
    - http://localhost:4873
- http-server
    - Start `http-server` or `hs` in the directory you want to serve/share
    - http://localhost:8080

### Container info
📂verdaccio - `/config/.config/verdaccio`, ⭐️`/config/.config/verdaccio/storage`  
📂workspace - `/config/workspace`  
📏765MB  
🛳4873 - Verdaccio  
🛳8443 - Code-Server  
🛳8080 - http-server  
🛳4200 - Misc  

# Sources
[GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/verdaccio-node-code-server)  
[Docker repository](https://hub.docker.com/r/jdelemar/verdaccio-node-code-server)  
[Verdaccio source code](https://github.com/verdaccio/verdaccio)  
[Visual Studio Code](https://code.visualstudio.com/)  
[Code-Server (via LinuxServer.io) source code](https://github.com/linuxserver/docker-code-server)  
[Coder](https://coder.com/)  
[Nodejs](https://nodejs.org/)  

# License
View [license information](https://github.com/JDelemar/dockerfiles/blob/master/LICENSE) for this Docker project.

As with all Docker images, these likely also contain other software which may be under other licenses (such as Bash, etc from the base distribution, along with any direct or indirect dependencies of the primary software being contained).

As for any pre-built image usage, it is the image user's responsibility to ensure that any use of this image complies with any relevant licenses for all software contained within.
