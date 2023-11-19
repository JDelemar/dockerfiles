#!/usr/bin/env bash

echo Getting VSCode configuration...
echo

DATE_STAMP=$(date '+%y%m%d')

tar -czvf /config/vscode-config-$DATE_STAMP.tgz /config/data/User/settings.json /config/workspace/.vscode/extensions.json /config/.bashrc --exclude '**/bin/*' --exclude '**/obj/*' /config/workspace

echo Done
