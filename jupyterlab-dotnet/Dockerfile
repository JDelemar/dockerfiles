FROM jdelemar/jupyterlab

RUN apk add --update icu

ENV DOTNET_ROOT=/root/dotnet \
    PATH="$PATH:/root/dotnet:/root/.dotnet/tools"

# Install .NET Core SDK
RUN dotnet_sdk_version=3.1.403 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Sdk/$dotnet_sdk_version/dotnet-sdk-$dotnet_sdk_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='3f3d9e96553718f1c8dd8774afb9a892ece64be4f4ec98a50fb4c0f18d358ee739032189ebc38809464ae69aa435e529c65b4f907a59d603e042f649b055a2ae' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p "/root/dotnet" \
    && tar zxf dotnet.tar.gz -C "/root/dotnet" \
    && rm dotnet.tar.gz \
    # Trigger first run experience by running arbitrary cmd
    && dotnet help

# Install dotnet try - interactive version of NET runtime
RUN dotnet tool install -g dotnet-try \
  && dotnet try jupyter install

# Expose Jupyter port & cmd
EXPOSE 8888
CMD jupyter lab --ip=* --port=8888 --no-browser --notebook-dir=/opt/app/data --allow-root
