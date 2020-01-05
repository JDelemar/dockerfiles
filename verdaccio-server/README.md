# Verdaccio with http-server

This image allows you to use http-server to quickly browse [Verdaccio's](https://github.com/verdaccio/verdaccio) files in a browser

# Try
(TODO: place `Try in PWD` button here) 

# How to use this image
## Quick start
```s
    docker run -it -p 4873:4873 -p 8080:8080 jdelemar/verdaccio-server /bin/sh
    # at the command prompt type:
    $VERDACCIO_APPDIR/bin/verdaccio --config /verdaccio/conf/config.yaml --listen $VERDACCIO_PROTOCOL://0.0.0.0:$VERDACCIO_PORT
    # TODO: will fix that later
```

Verdaccio will be available in your browser at http://localhost:4873  

Type `http-server` or `hs` to browse/download files from the container at http://localhost:8080

### Container info
📂verdaccio - `/verdaccio`, ⭐️`/verdaccio/storage`  
📏137MB  
🛳4873 - Verdaccio  
🛳8080 - http-server  

# Sources
[GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/verdaccio-server)  
[Docker repository](https://hub.docker.com/r/jdelemar/verdaccio-server)  
[Verdaccio source code](https://github.com/verdaccio/verdaccio)  

# License
View [license information](https://github.com/JDelemar/dockerfiles/blob/master/LICENSE) for this Docker project.

As with all Docker images, these likely also contain other software which may be under other licenses (such as Bash, etc from the base distribution, along with any direct or indirect dependencies of the primary software being contained).

As for any pre-built image usage, it is the image user's responsibility to ensure that any use of this image complies with any relevant licenses for all software contained within.
