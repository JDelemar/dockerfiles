# node and yarn
FROM jdelemar/ubuntu-lxde-vscode:0.1.0
MAINTAINER James Delemar <me@jdelemar.com>

RUN curl -sL https://deb.nodesource.com/setup_8.x | sudo -E bash -
RUN apt-get update && apt-get install -y nodejs \
        build-essential \
    && apt-get autoclean \
    && apt-get autoremove

CMD [ "node" ]