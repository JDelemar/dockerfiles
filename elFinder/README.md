# Unofficial elFinder Docker image
This images contains [elFinder](https://github.com/Studio-42/elFinder)

From the author
> elFinder is an open-source file manager for web, written in JavaScript using jQuery UI. Creation is inspired by simplicity and convenience of Finder program used in Mac OS X operating system.

See [elFinder](https://github.com/Studio-42/elFinder) for more details

# Try
[![Try in PWD](https://github.com/play-with-docker/stacks/raw/cff22438cb4195ace27f9b15784bbb497047afa7/assets/images/button.png)](http://play-with-docker.com/?stack=https://gist.githubusercontent.com/JDelemar/adf2a754765eda936a1749cbcad36057/raw/ded811b4d3d8d80447633ca51811c181b4d17cbd/elfinder.yml)

# How to use this image
## Quick start
```bash
    docker run -p 8080:80 jdelemar/elfinder
``` 

The file manager like application will be available in your browser at http://localhost:8080  

Files are located in the container at `/var/www/html/files` and by default have `www-data:www-data` permissions  

# Sources
GitHub source repository [JDelemar/elFinder](https://github.com/JDelemar/dockerfiles/tree/master/elFinder)  
Docker repository [jdelemar/elFinder](https://hub.docker.com/r/jdelemar/elFinder/)  
Original elFinder source [on GitHub](https://github.com/Studio-42/elFinder)  

# License
View [license information](https://github.com/JDelemar/dockerfiles/blob/master/elFinder/LISCENSE.md) for this elFinder Docker project.

As with all Docker images, these likely also contain other software which may be under other licenses (such as Bash, etc from the base distribution, along with any direct or indirect dependencies of the primary software being contained).

As for any pre-built image usage, it is the image user's responsibility to ensure that any use of this image complies with any relevant licenses for all software contained within.
