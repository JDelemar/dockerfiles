# Works 618MB
FROM mono:6.6.0.161-slim

RUN apt-get update \
  && apt-get install -y mono-runtime ca-certificates-mono nuget

RUN apt-get install -y curl sudo

RUN curl -sL https://deb.nodesource.com/setup_12.x | sudo -E bash - \
    && curl -sS https://dl.yarnpkg.com/debian/pubkey.gpg | sudo apt-key add - \
    && echo "deb https://dl.yarnpkg.com/debian/ stable main" | sudo tee /etc/apt/sources.list.d/yarn.list \
RUN apt-get update && apt-get install -y nodejs \
        build-essential \
        yarn \
    && rm -rf /var/lib/apt/lists/* /tmp/* \
    && apt-get autoclean \
    && apt-get autoremove
