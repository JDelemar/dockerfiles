## Ubuntu LXDE desktop environment
Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The base environment is composed of the following:
- Unbuntu 16.04
- Firefox 56.0
- Google Chrome 62.0.3202.89

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
Run the image allowing VNC connections with password (http still alowed)
```console
docker run -it --rm -p 8080:80 -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-dev
```  
Run the image ONLY allowing VNC connections with password
```console
docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-dev
```  

### Mount present (current) directory with container
```console
docker run -it --rm -p 8080:80 -v $PWD:/root/Desktop jdelemar/ubuntu-lxde-dev
```  

### Copy files to and from container
```bash
# connect to container giving the container a name
docker run -it --rm -p 8080:80 --name ubuntu-dev jdelemar/ubuntu-lxde-dev
# copy file to container
# example: docker cp <filename> <container name>:</path/to/file/filename>
docker cp mypicture.jpg ubuntu-dev:/root/Desktop/mypicture.jpg
# copy file from container
# example: docker cp <container name>:</path/to/source/filename> <destination filename> 
docker cp ubuntu-dev:/etc/hosts ./hosts
```  

## Container size
1.42GB  

## Issues/Comments
Google Chrome does not run unless you type the following from terminal `google-chrome-stable --no-sandbox`
Current user is root with no password
Communication to container is in plain text over http

## Sources
Source repository [jdelemar/ubuntu-lxde-base](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-base)
Docker repository [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
