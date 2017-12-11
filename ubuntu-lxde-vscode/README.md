## Ubuntu LXDE desktop environment
Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The destop environment is composed of the following:
- Ubuntu LXDE desktop base environment [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)
- Visual Studio Code 1.18.1  

## How to use
### Run the image in a container
Run the image on port 8080
```console
docker run -it --rm -p 8080:80 jdelemar/ubuntu-lxde-vscode
```
To see the desktop, browse [http://localhost:8080](http://localhost:8080)

### Run the image and allow VNC connections
Run the image allowing VNC connections without password
```console
docker run -it --rm -p 8080:80 -p 5900:5900 jdelemar/ubuntu-lxde-vscode
```  
Run the image allowing VNC connections with password (http still alowed)
```console
docker run -it --rm -p 8080:80 -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-vscode
```  
Run the image ONLY allowing VNC connections with password
```console
docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-vscode
```  

## Additional Information
See Ubuntu LXDE desktop base environment [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)

## Container size
1.37GB  

## Sources
Source repository [jdelemar/ubuntu-lxde-vscode](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-vscode)  
Docker repository [jdelemar/ubuntu-lxde-vscode](https://hub.docker.com/r/jdelemar/ubuntu-lxde-vscode/)  
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)  
jessfraz's [VSCode docker file](https://github.com/jessfraz/dockerfiles/blob/master/vscode/Dockerfile)  
