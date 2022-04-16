FROM jdelemar/jupyterlab

RUN apk add --update icu

# From runtime-deps
ENV \
    # Enable detection of running in a container
    DOTNET_RUNNING_IN_CONTAINER=true \
    # Set the invariant mode since icu-libs isn't included (see https://github.com/dotnet/announcements/issues/20)
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=true

ENV DOTNET_ROOT=/usr/share/dotnet \
    PATH="$PATH:/usr/share/dotnet:/root/.dotnet/tools"

# Install .NET Core Runtime
RUN dotnet_version=5.0.16 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Runtime/$dotnet_version/dotnet-runtime-$dotnet_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='49310a377cb112375519477fe9a668fd45dabf560ed55659b56e557afc3e33e030ec683bc046314d86424f699c0987c55630a5155874351feffa91deefdf53f2' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

# Install ASP.NET Core
RUN aspnetcore_version=5.0.16 \
    && wget -O aspnetcore.tar.gz https://dotnetcli.azureedge.net/dotnet/aspnetcore/Runtime/$aspnetcore_version/aspnetcore-runtime-$aspnetcore_version-linux-musl-x64.tar.gz \
    && aspnetcore_sha512='d7aa3a3753505448cc3ba38bc17bf767503e328fade8e8bbc6ac5da8e12ec29737159ec75d327ee71e7f628282a272df0fb4b20e296edbb5f282d2db859a1457' \
    && echo "$aspnetcore_sha512  aspnetcore.tar.gz" | sha512sum -c - \
    && tar -oxzf aspnetcore.tar.gz -C /usr/share/dotnet ./shared/Microsoft.AspNetCore.App \
    && rm aspnetcore.tar.gz

# Install .NET Core SDK
RUN sdk_version=5.0.407 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Sdk/$sdk_version/dotnet-sdk-$sdk_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='0eab1963bf9a670ea51224d9c56c56bd3cccd32666130e41c70fe84087321d3d0ac9f7fb3eea4019a386af7544740e92ba85076a56408dff652f81dc8607be4f' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet ./packs ./sdk ./templates ./LICENSE.txt ./ThirdPartyNotices.txt \
    && rm dotnet.tar.gz \
    # Trigger first run experience by running arbitrary cmd
    && dotnet help

# Install Microsoft.dotnet-interactive
RUN dotnet tool install -g Microsoft.dotnet-interactive --version 1.0.255902 --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json" \
    && dotnet interactive jupyter install

# Expose Jupyter port & cmd
EXPOSE 8888
CMD jupyter lab --ip=* --port=8888 --no-browser --notebook-dir=/opt/app/data --allow-root
