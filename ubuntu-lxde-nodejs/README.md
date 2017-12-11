## Ubuntu LXDE desktop environment
Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The destop environment is composed of the following:
- Ubuntu LXDE desktop base and vscode environment [jdelemar/ubuntu-lxde-vscode](https://hub.docker.com/r/jdelemar/ubuntu-lxde-vscode/)
- node 8.9.1
- npm 5.5.1

## How to use
### Run the image in a container
Run the image on port 8080
```console
docker run -it --rm -p 8080:80 jdelemar/ubuntu-lxde-nodejs
```
To see the desktop, browse [http://localhost:8080](http://localhost:8080)

### Run the image and allow VNC connections
Run the image allowing VNC connections without password
```console
docker run -it --rm -p 8080:80 -p 5900:5900 jdelemar/ubuntu-lxde-nodejs
```  
Run the image allowing VNC connections with password (http still alowed)
```console
docker run -it --rm -p 8080:80 -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-nodejs
```  
Run the image ONLY allowing VNC connections with password
```console
docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-nodejs
```  

## Additional Information
See Ubuntu LXDE desktop base environment [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)

## Container size
1.47GB  

## Sources
Source repository [jdelemar/ubuntu-lxde-nodejs](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-nodejs)  
Docker repository [jdelemar/ubuntu-lxde-nodejs](https://hub.docker.com/r/jdelemar/ubuntu-lxde-nodejs/)  
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
