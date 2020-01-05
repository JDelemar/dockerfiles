FROM node:12.14.0-alpine

ENV NUGET_VERSION=5.2.0

RUN echo "http://dl-4.alpinelinux.org/alpine/edge/testing" >> /etc/apk/repositories \
    && apk add --no-cache ca-certificates mono \
    && cert-sync /etc/ssl/certs/ca-certificates.crt \
    && wget -P /usr/lib/mono https://dist.nuget.org/win-x86-commandline/v${NUGET_VERSION}/nuget.exe \
    && echo -e '#!/bin/sh\nexec /usr/bin/mono $MONO_OPTIONS /usr/lib/mono/nuget.exe "$@"' > /usr/bin/nuget \
    && chmod a+x /usr/bin/nuget \
    && npm install -g http-server
