#!/bin/bash

# make unsecure, secure by default
if [ "${SECURE,,}" = "no" ] || [ "${SECURE,,}" = "false" ]; then
    sed -i "s/--cert/# --cert/" /etc/supervisor/conf.d/supervisord.conf
fi

if [ -n "$VNC_PASSWORD" ]; then
    echo -n "$VNC_PASSWORD" > /.password1
    x11vnc -storepasswd $(cat /.password1) /.password2
    chmod 400 /.password*
    sed -i 's/^command=x11vnc.*/& -rfbauth \/.password2/' /etc/supervisor/conf.d/supervisord.conf
    export VNC_PASSWORD=
fi

if [ -n "$RESOLUTION" ]; then
    sed -i "s/1024x768/$RESOLUTION/" /etc/supervisor/conf.d/supervisord.conf
fi

USER=${USER:-root}
HOME=/root
if [ "$USER" != "root" ]; then
    useradd --create-home --shell /bin/bash --user-group --groups adm,sudo $USER
    if [ -z "$PASSWORD" ]; then
        echo set default password to \"ubuntu\"
        PASSWORD=ubuntu
    fi
    HOME=/home/$USER
    echo "$USER:$PASSWORD" | chpasswd
    cp -r /root/.gtkrc-2.0 ${HOME}
fi
sed -i "s|%USER%|$USER|" /etc/supervisor/conf.d/supervisord.conf
sed -i "s|%HOME%|$HOME|" /etc/supervisor/conf.d/supervisord.conf

# home folder
mkdir -p $HOME/.config/pcmanfm/LXDE/
ln -sf /usr/share/doro-lxde-wallpapers/desktop-items-0.conf $HOME/.config/pcmanfm/LXDE/
chown -R $USER:$USER $HOME

# clearup
PASSWORD=

cd /usr/lib/web && ./run.py 2>&1 &
nginx -c /etc/nginx/nginx.conf
exec /bin/tini -- /usr/bin/supervisord -n
