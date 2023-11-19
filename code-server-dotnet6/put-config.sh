#!/usr/bin/env bash

echo Setting VSCode configuration...
echo

docker cp config/. code:/config

echo Done
