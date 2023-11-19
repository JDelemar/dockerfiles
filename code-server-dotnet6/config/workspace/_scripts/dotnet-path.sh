#!/usr/bin/env bash

DOTNET_ROOT=/config/.dotnet

PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools

echo "Update path with: export PATH=$PATH"
