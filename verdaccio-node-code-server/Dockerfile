FROM linuxserver/code-server:2.1637-vsc1.39.2-ls12

RUN groupadd --gid 1001 node \
    && useradd --uid 1001 --gid node --shell /bin/bash --create-home node

# node & yarn
RUN curl -sL https://deb.nodesource.com/setup_12.x | sudo -E bash - \
    && curl -sS https://dl.yarnpkg.com/debian/pubkey.gpg | sudo apt-key add - \
    && echo "deb https://dl.yarnpkg.com/debian/ stable main" | sudo tee /etc/apt/sources.list.d/yarn.list \
    && apt-get update \
    && apt-get install -y nodejs \
        build-essential \
    && apt-get install -y yarn

# maybe I might clean up, maybe I won't

RUN npm install -g http-server verdaccio

CMD [ "node" ]
