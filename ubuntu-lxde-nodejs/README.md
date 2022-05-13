# Ubuntu LXDE desktop environment

Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The destop environment is composed of the following:

- Ubuntu LXDE desktop base and vscode environment [jdelemar/ubuntu-lxde-vscode](https://hub.docker.com/r/jdelemar/ubuntu-lxde-vscode/)
- node 16.15.0
- npm 8.5.5
- yarn 1.22.18

## How to use

### Run the image in a container without https

After running the container with the below command connect to it in your browser using http://localhost:8080

```bash
  docker run -it --rm -p 8080:80 -e SECURE=false jdelemar/ubuntu-lxde-nodejs
```

### Run the image in a container and allow VNC connections

Run the image ONLY allowing VNC connections with password

```bash
  docker run -it --rm -p 5900:5900 -e SECURE=false -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-nodejs
  # OR
  docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-nodejs
```  

### Run the image with an encrypted connection

After running the container with the below command connect to it in your browser using `https://localhost:4430/vnc.html`

```console
  docker run -it --rm -p 4430:6081 -e VNC_PASSWORD=mypassword --name lxde jdelemar/ubuntu-lxde-vscode
```  

## Additional Information

See Ubuntu LXDE desktop base environment [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)  
  
## Container size

2.3GB  

## Sources

Source repository [jdelemar/ubuntu-lxde-nodejs](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-nodejs)  
Docker repository [jdelemar/ubuntu-lxde-nodejs](https://hub.docker.com/r/jdelemar/ubuntu-lxde-nodejs/)  
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
