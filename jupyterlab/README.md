# Jupyterlab

![Docker Cloud Automated build](https://img.shields.io/docker/cloud/automated/jdelemar/jupyterlab)
![Docker Cloud Build Status](https://img.shields.io/docker/cloud/build/jdelemar/jupyterlab)
![Docker Image Size (latest by date)](https://img.shields.io/docker/image-size/jdelemar/jupyterlab?sort=date)
![MicroBadger Layers](https://img.shields.io/microbadger/layers/jdelemar/jupyterlab)

![Alpine 3.15.4](https://img.shields.io/badge/Alpine-3.15.4-blue.svg?style=flat-square)
![Juypterlab 3.3.4](https://img.shields.io/badge/Jupyterlab-3.3.4-blue.svg?style=flat-square)
![Python 3.9.12](https://img.shields.io/badge/Python-3.9.12-blue.svg?style=flat-square)
![TypeScript 4.1.2](https://img.shields.io/badge/TypeScript-4.1.2-blue.svg?style=flat-square)

Jupyterlab Docker image based on [mikebirdgeneau/jupyterlab-docker](https://github.com/mikebirdgeneau/jupyterlab-docker)

This image adds ES6 and Typescript capabilities to the Jupyter Notebook  

**Screen shots**  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab/images/JupyterLauncher.png" alt="launcher" width="800" />  
<img src="https://github.com/JDelemar/dockerfiles/raw/master/jupyterlab/images/JupyterTypeScript.png" alt="TypeScript" width="800" />  

## How to use this image

### Quick start

```s
  docker run -p 8888:8888 jdelemar/jupyterlab
```

### Other Configurations

#### Persist notebook data

```s
  docker run -p 8888:8888 -v jupyter-data:/opt/app/data jdelemar/jupyterlab
```

#### Container info

🐧 Alpine 3.15.4  
📏 1.05GB  
🛳 8888  
🌐 Jupyterlab 3.3.4  
🌐 Python 3.9.12  
🌐 TypeScript 4.1.2  

#### Versions

- Versions
  - Latest
    - jdelemar/jupyterlab:latest
    - jdelemar/jupyterlab:3.3.4
    - jdelemar/jupyterlab:3.3.4-python-3.9.12-alpine-3.15.4

## Sources

- Sources
  - [GitHub source code](https://github.com/JDelemar/dockerfiles/tree/master/jupyterlab)  
  - [Docker repository](https://hub.docker.com/repository/docker/jdelemar/jupyterlab)  
  - [Docker mikebirdgeneau/jupyterlab on Docker hub](https://hub.docker.com/r/mikebirdgeneau/jupyterlab), [Github](https://github.com/mikebirdgeneau/jupyterlab-docker)
  - TypeScript
    - [Jupyter Notebooks with ES6 and TypeScript slides](https://slides.com/yearofmoo/jupyter-notebooks-with-es6-and-typescript/fullscreen)

      ```bash
        RUN apk add --update npm

        # Install TS & ES6 support
        RUN npm install -g tslab && \
          tslab install
      ```
