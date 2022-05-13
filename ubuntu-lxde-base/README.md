# Ubuntu LXDE desktop environment

Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
![lxde-desktop](https://github.com/JDelemar/dockerfiles/blob/master/ubuntu-lxde-base/screenshots/lxde.png)

## How to use this image

### Quick start

```s
  docker run -p 8080:80 -v /dev/shm:/dev/shm jdelemar/ubuntu-lxde-base
```

Ubuntu will be available in your browser at `http://localhost:8080`

### Other configurations

#### VNC Viewer

Forward VNC service port 5900 to host by  

```s
  docker run -p 8080:80 -p 5900:5900 VNC_PASSWORD=mypassword -v /dev/shm:/dev/shm jdelemar/ubuntu-lxde-base
```

Now, open the vnc viewer, connect to port 5900, and use the password that you have set

#### Default Desktop User

The default user is root. You may change the user and password respectively by USER and PASSWORD environment variable, for example,  

```s
  docker run -p 6080:80 -e USER=doro -e PASSWORD=password -v /dev/shm:/dev/shm jdelemar/ubuntu-lxde-base
```

For more configurations see the project on [dorowu/ubuntu-desktop-lxde-vnc Docker](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc) or [docker-ubuntu-vnc-desktop GitHub](https://github.com/fcwu/docker-ubuntu-vnc-desktop)

## Container info

🐧Ubuntu 20.04  
📏1.6GB  
🛳80 - no VNC web server  
🛳5900 - VNC server  
🌐Firefox 87.0  
🌐Google Chrome 101.0.4951.41  

## Sources

[GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-base)  
[Docker repository](https://hub.docker.com/repository/docker/jdelemar/ubuntu-lxde-base)  
[Docker Ubuntu LXDE desktop on Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/),[Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
