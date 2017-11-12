## Ubuntu LXDE development environment
Ubuntu lightweight desktop development environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The development environment is composed of the following:
- Unbuntu 16.04
- Firefox 56.0
- Google Chrome 62.0.3202.89
- Visual Studio Code 1.18.0
- node 8.9.1
- npm 5.5.1
- yarn 1.3.2

## How to use
### Run the image in a container
Run the image on port 8080
```console
docker run -it --rm -p 8080:80 jdelemar/ubuntu-lxde-dev
```
To see the desktop, browse [http://localhost:8080](http://localhost:8080)  

### Run the image and allow VNC connections
Run the image allowing VNC connections without password
```console
docker run -it --rm -p 8080:80 -p 5900:5900 jdelemar/ubuntu-lxde-dev
```
Run the image allowing VNC connections with password
```console
docker run -it --rm -p 8080:80 -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-dev
```  

## Issues/Comments
Google Chrome does not run unless you type the following from terminal `google-chrome-stable --no-sandbox`  
Current user is root with no password  
Communication to container is in plain text over http  

## Sources
Source repository [jdelemar/ubuntu-lxde-dev](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-dev)  
Docker repository [jdelemar/ubuntu-lxde-dev](https://hub.docker.com/r/jdelemar/ubuntu-lxde-dev/)  
docker-ubuntu-vnc-desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)  
jessfraz's [VSCode docker file](https://github.com/jessfraz/dockerfiles/blob/master/vscode/Dockerfile)  
Nodejs [Dockerfile](https://github.com/nodejs/docker-node)