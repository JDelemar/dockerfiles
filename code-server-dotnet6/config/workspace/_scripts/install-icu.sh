#!/usr/bin/env bash

echo Installing libicu-dev...
echo

# TODO: annotate requires admin
apt-get update \
  && apt-get install -y \
    libicu-dev \
  && apt-get autoremove -y \
  && apt-get clean -y \
  && rm -rf /var/lib/apt/lists/*

echo Done
