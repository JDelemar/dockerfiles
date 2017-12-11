# ubuntu-lxde-base
FROM ubuntu:16.04
MAINTAINER James Delemar <me@jdelemar.com>

ENV DEBIAN_FRONTEND noninteractive

RUN sed -i 's#http://archive.ubuntu.com/#http://tw.archive.ubuntu.com/#' /etc/apt/sources.list

# built-in packages
RUN apt-get update \
    && apt-get install -y --no-install-recommends software-properties-common curl \
    # expired keys see https://github.com/horst3180/arc-theme/issues/793
    # && sh -c "echo 'deb http://download.opensuse.org/repositories/home:/Horst3180/xUbuntu_16.04/ /' >> /etc/apt/sources.list.d/arc-theme.list" \
    # && curl -SL http://download.opensuse.org/repositories/home:Horst3180/xUbuntu_16.04/Release.key | apt-key add - \
    # && add-apt-repository ppa:fcwu-tw/ppa \
    && apt-get update \
    # try remove --allow-unauthenticated  up here
    && apt-get install -y --no-install-recommends --allow-unauthenticated \
        # add for chrome
        apt-transport-https \
        ca-certificates \
        gnupg \
        hicolor-icon-theme \
        libgl1-mesa-dri \
        libgl1-mesa-glx \
        libpango1.0-0 \
        libpulse0 \
        libv4l-0 \
        fonts-symbola \
        --no-install-recommends \   
        && apt-get update && apt-get install -y --no-install-recommends --allow-unauthenticated \     
        # end add
        supervisor \
        openssh-server pwgen sudo vim-tiny \
        net-tools \
        lxde x11vnc xvfb \
        gtk2-engines-murrine ttf-ubuntu-font-family \
        # remove libre office
        # libreoffice firefox \
        firefox \
        # fonts-wqy-microhei \
        # language-pack-zh-hant language-pack-gnome-zh-hant firefox-locale-zh-hant libreoffice-l10n-zh-tw \
        nginx \
        python-pip python-dev build-essential \
        # mesa-utils libgl1-mesa-dri \
        mesa-utils \
        # gnome-themes-standard gtk2-engines-pixbuf gtk2-engines-murrine pinta arc-theme \
        gnome-themes-standard gtk2-engines-pixbuf gtk2-engines-murrine pinta \
        dbus-x11 x11-utils \
    # chrome start
    && curl -sSL https://dl.google.com/linux/linux_signing_key.pub | apt-key add - \
	&& echo "deb [arch=amd64] https://dl.google.com/linux/chrome/deb/ stable main" > /etc/apt/sources.list.d/google.list \
    && apt-get update && apt-get install -y \
        google-chrome-stable \
        --no-install-recommends
    # chrome end
RUN apt-get update && apt-get -y install \    
    && apt-get autoclean \
    && apt-get autoremove \
    && rm -rf /var/lib/apt/lists/*

# tini for subreap                                   
ENV TINI_VERSION v0.9.0
ADD https://github.com/krallin/tini/releases/download/${TINI_VERSION}/tini /bin/tini
RUN chmod +x /bin/tini

ADD docker-ubuntu-vnc-desktop/image /
RUN pip install setuptools wheel && pip install -r /usr/lib/web/requirements.txt

EXPOSE 80
WORKDIR /root
ENV HOME=/home/ubuntu \
    SHELL=/bin/bash
ENTRYPOINT ["/startup.sh"]
