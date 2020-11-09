# Jupyterlab

![Docker Cloud Automated build](https://img.shields.io/docker/cloud/automated/jdelemar/jupyterlab)
![Docker Cloud Build Status](https://img.shields.io/docker/cloud/build/jdelemar/jupyterlab)
![Docker Image Size (latest by date)](https://img.shields.io/docker/image-size/jdelemar/jupyterlab?sort=date)

![Alpine 3.12.1](https://img.shields.io/badge/Alpine-3.12.1-blue.svg?style=flat-square)
![Juypterlab 2.2.9](https://img.shields.io/badge/Jupyterlab-2.2.9-blue.svg?style=flat-square)
![Python 3.9.0](https://img.shields.io/badge/Python-3.9.0-blue.svg?style=flat-square)
![TypeScript 3.9.5](https://img.shields.io/badge/TypeScript-3.9.5-blue.svg?style=flat-square)

Jupyterlab Docker image based on [mikebirdgeneau/jupyterlab-docker](https://github.com/mikebirdgeneau/jupyterlab-docker)

This image adds ES6 and Typescript capabilities to the Jupyter Notebook  

**Screen shots**  
![launcher](https://github.com/JDelemar/dockerfiles/blob/master/jupyterlab/images/JupyterLauncher.png)  
![TypeScript](https://github.com/JDelemar/dockerfiles/blob/master/jupyterlab/images/JupyterTypeScript.png)  

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

🐧 Alpine 3.12.1  
📏 921MB  
🛳 8888  
🌐 Jupyterlab 2.2.9  
🌐 Python 3.9.0  
🌐 TypeScript 3.9.5  

#### Versions

- Versions
  - Latest
    - jdelemar/jupyterlab:latest
    - jdelemar/jupyterlab:2.2.9
    - jdelemar/jupyterlab:2.2.9-python-3.9.0-alpine-3.12.1

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
