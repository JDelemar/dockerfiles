# node and yarn
FROM jdelemar/ubuntu-lxde-vscode:0.4.0

RUN curl -sL https://deb.nodesource.com/setup_16.x | sudo -E bash -
RUN apt-get update && apt-get install -y nodejs \
      build-essential

# yarn
RUN curl -sS https://dl.yarnpkg.com/debian/pubkey.gpg | sudo apt-key add - \
    && echo "deb https://dl.yarnpkg.com/debian/ stable main" | sudo tee /etc/apt/sources.list.d/yarn.list \
    && apt-get update && apt-get install -y yarn

RUN apt-get autoclean \
    && apt-get autoremove

CMD [ "node" ]
