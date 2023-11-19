#!/usr/bin/env bash

#region Setup

set_vars() {
  DOTNET_FILE=dotnet-sdk-6.0.417-linux-x64.tar.gz
  DOTNET_ROOT=/config/.dotnet
}

install() {
  echo Installing $DOTNET_FILE...
  echo

  cd /config/workspace

  #TODO: Try: curl -L -O https://download.visualstudio.microsoft.com/download/pr/1cac4d08-3025-4c00-972d-5c7ea446d1d7/a83bc5cbedf8b90495802ccfedaeb2e6/$DOTNET_FILE
  curl https://download.visualstudio.microsoft.com/download/pr/1cac4d08-3025-4c00-972d-5c7ea446d1d7/a83bc5cbedf8b90495802ccfedaeb2e6/$DOTNET_FILE --output $DOTNET_FILE

  mkdir -p "$DOTNET_ROOT" && tar zxf "$DOTNET_FILE" -C "$DOTNET_ROOT"

  PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools

  echo Installation complete
  echo "Update path with: export PATH=$PATH"
  echo Check with: dotnet --info
  echo If you recieve the error \"Couldn\'t find a valid ICU package\" run install-icu
}

#endregion

set_vars
install
