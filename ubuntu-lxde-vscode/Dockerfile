# vscode
FROM jdelemar/ubuntu-lxde-base:0.2.1
# source: jessfraz's vscode/Dockerfile https://github.com/jessfraz/dockerfiles/tree/master/vscode

RUN curl -sSL https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor | apt-key add -
RUN echo "deb [arch=amd64] https://packages.microsoft.com/repos/vscode stable main" > /etc/apt/sources.list.d/vscode.list

RUN apt-get update && apt-get -y install \
		code \
		libasound2 \
		libatk1.0-0 \
		libcairo2 \
		libcups2 \
		libexpat1 \
		libfontconfig1 \
		libfreetype6 \
		libgtk2.0-0 \
		libpango-1.0-0 \
		libx11-xcb1 \
		libxcomposite1 \
		libxcursor1 \
		libxdamage1 \
		libxext6 \
		libxfixes3 \
		libxi6 \
		libxrandr2 \
		libxrender1 \
		libxss1 \
		libxtst6 \
		--no-install-recommends \
    && rm -rf /var/lib/apt/lists/*

ENV HOME /home/user

COPY start.sh /usr/local/bin/start.sh

WORKDIR $HOME

CMD [ "start.sh" ]