## Ubuntu LXDE desktop environment
Ubuntu lightweight desktop environment with VNC interface based on [dorowu/ubuntu-desktop-lxde-vnc](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/)  
  
The base environment is composed of the following:
- Unbuntu 16.04
- Firefox 57.0.4
- Google Chrome 63.0.3239.132

## How to use
### Run the image in a container and allow VNC connections
Run the image ONLY allowing VNC connections with password
```console
docker run -it --rm -p 5900:5900 -e VNC_PASSWORD=mypassword jdelemar/ubuntu-lxde-base
```  

### Run the image with an encrypted connection
After running the container with the below command connect to it in your browser using https://localhost:6801/vnc.html
```console
docker run -it --rm -p 6081:6081 -e VNC_PASSWORD=mypassword --security-opt seccomp:seccomp/chrome.json --name lxde jdelemar/ubuntu-lxde-base
```  

### Run the container in detached mode
To run the container in detached mode so it won't remove itself after exiting replace the `-it --rm` options with `-d`
```console
docker run -d -p 6081:6081 -e VNC_PASSWORD=mypassword --security-opt seccomp:seccomp/chrome.json --name lxde jdelemar/ubuntu-lxde-base
```

### Mount present (current) directory with container
```console
docker run -it --rm -p 6081:6081 -e VNC_PASSWORD=mypassword --security-opt seccomp:seccomp/chrome.json -v $PWD:/root/Desktop --name lxde jdelemar/ubuntu-lxde-base
```  

### Copy files to and from container
```bash
# connect to container giving the container a name
docker run -it --rm -p 6081:6081 -e VNC_PASSWORD=mypassword --security-opt seccomp:seccomp/chrome.json --name ubuntu-base jdelemar/ubuntu-lxde-base
# copy file to container
# example: docker cp <filename> <container name>:</path/to/file/filename>
docker cp mypicture.jpg ubuntu-base:/root/Desktop/mypicture.jpg
# copy file from container
# example: docker cp <container name>:</path/to/source/filename> <destination filename> 
docker cp ubuntu-base:/etc/hosts ./hosts
```  

## Container size
1.21GB  

## Additional notes
The `--security-opt seccomp:seccomp/chrome.json` option is for allowing a normal user to run the Google Chrome browser (google-chrome-stable). The original source folder/file for this option is in [jessfraz's dotfiles](https://github.com/jessfraz/dotfiles/tree/master/etc/docker/seccomp)  
Without the above option Chrome would have to be started from the terminal with `google-chrome-stable --no-sandbox`. You will receive a warning that says `You are using an unsupported command-line flag: --no-sandbox. Stability and security will suffer.`  
  
## Issues/Comments
Current user is root with no password  
There is non-root user called `user`, to switch to the user type `su user` in the console

## Sources
Source repository [jdelemar/ubuntu-lxde-base](https://github.com/JDelemar/dockerfiles/tree/master/ubuntu-lxde-base)  
Docker repository [jdelemar/ubuntu-lxde-base](https://hub.docker.com/r/jdelemar/ubuntu-lxde-base/)  
Original Docker Ubuntu LXDE desktop [Docker hub](https://hub.docker.com/r/dorowu/ubuntu-desktop-lxde-vnc/), [Github](https://github.com/fcwu/docker-ubuntu-vnc-desktop)
