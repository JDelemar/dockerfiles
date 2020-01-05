# Registry with http-server

🎉🐥Disco - distro duck - distro node - 🐳Docker registry with node http-server

# Try
(TODO: place `Try in PWD` button here) 

# How to use this image
## Quick start
```s
    docker run -it -p 5000:5000 -p 8080:8080 jdelemar/registry-server /bin/sh
    # to start the Docker registry server and send it to the background
    # at the prompt type:
    registry serve /etc/docker/registry/config.yml & 
    # TODO: fix that - automate the things
```

The Docker registry will be available for connections at localhost:5000  
*Note: No browser response on port 5000*

Type `http-server` or `hs` to browse/download files from the container at http://localhost:8080

### Container info
📂registry  
- `/etc/docker/registry/config.yml`  
- ⭐️`/var/lib/registry`  

📏110MB  
🛳5000 - Docker registry/distribution  
🛳8080 - http-server  

# Sources  
[GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/registry-server)  
[Docker repository](https://hub.docker.com/r/jdelemar/registry-server)  
[Docker registry](https://hub.docker.com/_/registry)  
[Node.js Dockerfile source](https://github.com/nodejs/docker-node)

# License
View [license information](https://github.com/JDelemar/dockerfiles/blob/master/LICENSE) for this Docker project.

As with all Docker images, these likely also contain other software which may be under other licenses (such as Bash, etc from the base distribution, along with any direct or indirect dependencies of the primary software being contained).

As for any pre-built image usage, it is the image user's responsibility to ensure that any use of this image complies with any relevant licenses for all software contained within.
