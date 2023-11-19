# Build
# docker build -t jdelemar/linuxserver/code-server:amd64-4.19.0-ls182-icu-dotnet6 .
FROM lscr.io/linuxserver/code-server:amd64-4.19.0-ls182

ENV DOTNET_ROOT=/config/.dotnet
ENV DOTNET_FILE=dotnet-sdk-6.0.417-linux-x64.tar.gz
ENV PATH=$PATH:$DOTNET_ROOT:$DOTNET_ROOT/tools

#============================================
# dotnet 6
#============================================
RUN curl -L -O https://download.visualstudio.microsoft.com/download/pr/1cac4d08-3025-4c00-972d-5c7ea446d1d7/a83bc5cbedf8b90495802ccfedaeb2e6/${DOTNET_FILE} \
  && mkdir -p ${DOTNET_ROOT} \
  && tar zxf ${DOTNET_FILE} -C ${DOTNET_ROOT} \
  && rm ${DOTNET_FILE}

#============================================
# ICU
#============================================
RUN apt-get update \
  && apt-get install -y \
    libicu-dev \
  # Clean up
  && apt-get autoremove -y \
  && apt-get clean -y \
  && rm -rf /var/lib/apt/lists/*

#============================================
# dotnet-ef
#============================================
RUN dotnet tool install --version 6.0.25 --global dotnet-ef
