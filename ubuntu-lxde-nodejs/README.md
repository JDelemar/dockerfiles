## Ubuntu LXDE desktop environment
Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The destop environment is composed of the following:
- Ubuntu LXDE desktop base and vscode environment [jdelemar/ubuntu-lxde-vscode](https://hub.docker.com/r/jdelemar/ubuntu-lxde-vscode/)
- node 8.9.4
- npm 5.6.0

## How to use
### Run the image in a container and allow VNC connections
Run the image ONLY allowing VNC connections with password
```console
docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-nodejs
```  

### Run the image with an encrypted connection
After running the container with the below command connect to it in your browser using https://localhost:6801/vnc.html
```console
docker run -it --rm -p 6081:6081 -e VNC_PASSWORD=mypassword --security-opt seccomp:seccomp/chrome.json --name lxde jdelemar/ubuntu-lxde-nodejs
```  



## Additional Information
See Ubuntu LXDE desktop base environment [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)  
The `--security-opt seccomp:seccomp/chrome.json` option is for allowing a normal user to run the Google Chrome browser (google-chrome-stable). The folder/file for this option is in [ubuntu-lxde-base](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-base/seccomp) or you can get it from the original source, [jessfraz's dotfiles](https://github.com/jessfraz/dotfiles/tree/master/etc/docker/seccomp)  
  
## Container size
1.52GB  

## Sources
Source repository [jdelemar/ubuntu-lxde-nodejs](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-nodejs)  
Docker repository [jdelemar/ubuntu-lxde-nodejs](https://hub.docker.com/r/jdelemar/ubuntu-lxde-nodejs/)  
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
