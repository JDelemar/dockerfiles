#!/usr/bin/env bash

echo Getting VSCode configuration...
echo

DATE_STAMP=$(date '+%y%m%d')

docker cp code:/config/vscode-config-$DATE_STAMP.tgz .

echo Done
