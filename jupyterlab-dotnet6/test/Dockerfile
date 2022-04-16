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
RUN dotnet_version=3.1.24 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Runtime/$dotnet_version/dotnet-runtime-$dotnet_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='fb5328fb29e71c5f35c5c5e08a57db6d27b9fe66ee2a01f72ecc7fa097da1d9e1939c20a75ac0fad4937a19eed28f299a99d1c94fcbbe040f55ac53ee3eea00a' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

# Install ASP.NET Core
RUN aspnetcore_version=3.1.24 \
    && wget -O aspnetcore.tar.gz https://dotnetcli.azureedge.net/dotnet/aspnetcore/Runtime/$aspnetcore_version/aspnetcore-runtime-$aspnetcore_version-linux-musl-x64.tar.gz \
    && aspnetcore_sha512='1341b6e0a9903b253a69fdf1a60cd9e6be8a5c7ea3c4a52cd1a8159461f6ba37bef7c2ae0d6df5e1ebd38cd373cf384dc55c6ef876aace75def0ac77427d3bb0' \
    && echo "$aspnetcore_sha512  aspnetcore.tar.gz" | sha512sum -c - \
    && tar -oxzf aspnetcore.tar.gz -C /usr/share/dotnet ./shared/Microsoft.AspNetCore.App \
    && rm aspnetcore.tar.gz

# Install .NET Core SDK
RUN sdk_version=3.1.418 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Sdk/$sdk_version/dotnet-sdk-$sdk_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='c79f2f1de4da11c2c87e98ff894a4959685071fd2f3c74210caee276208bc18647b30d5641e15b342300d30c6d4f949b6c3a8d60cdf7d5a81ad63f5319f0be70' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet ./packs ./sdk ./templates ./LICENSE.txt ./ThirdPartyNotices.txt \
    && rm dotnet.tar.gz \
    # Trigger first run experience by running arbitrary cmd
    && dotnet help

# 6 (latest)
# 5 1.0.255902
# 3 1.0.155302
# # Install Microsoft.dotnet-interactive
# RUN dotnet tool install -g Microsoft.dotnet-interactive --version 1.0.155302 --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json"

# Install .NET Core Runtime
RUN dotnet_version=5.0.16 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Runtime/$dotnet_version/dotnet-runtime-$dotnet_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='49310a377cb112375519477fe9a668fd45dabf560ed55659b56e557afc3e33e030ec683bc046314d86424f699c0987c55630a5155874351feffa91deefdf53f2' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz 
    # && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

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

# # Install Microsoft.dotnet-interactive
# RUN dotnet tool install -g Microsoft.dotnet-interactive --version 1.0.255902 --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json"

# Install .NET Core Runtime
RUN dotnet_version=6.0.4 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Runtime/$dotnet_version/dotnet-runtime-$dotnet_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='e5b538482f10a667bee3b7482db0ac0cac27b5bddab9f3ab68bd5c5d7c18c5bec2bdcb8cd288052c3f3e186291ee02190ff01896c2835ce32b87e18cd817759e' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz
    # && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

ENV \
    # Set the default console formatter to JSON
    Logging__Console__FormatterName=Json

# Install ASP.NET Core
RUN aspnetcore_version=6.0.3 \
    && wget -O aspnetcore.tar.gz https://dotnetcli.azureedge.net/dotnet/aspnetcore/Runtime/$aspnetcore_version/aspnetcore-runtime-$aspnetcore_version-linux-musl-x64.tar.gz \
    && aspnetcore_sha512='9d334a62e8f591f4cac70b970b20a45d7557a75aa1bccc34891ee4ea9a0ae9d7b046b3dd8ba4a922398198eb7275f9f50177fe8287f2dac7e99a883a448b63d1' \
    && echo "$aspnetcore_sha512  aspnetcore.tar.gz" | sha512sum -c - \
    && tar -oxzf aspnetcore.tar.gz -C /usr/share/dotnet ./shared/Microsoft.AspNetCore.App \
    && rm aspnetcore.tar.gz

# Install .NET Core SDK
RUN sdk_version=6.0.202 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Sdk/$sdk_version/dotnet-sdk-$sdk_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='ccf4f6145d3ea10ce56cd89775f607ac57115f63e3ad7f9804b4a0bceb86e579aeddf5b81636bbf3fcb79dd9b1c082a10b7582e6c8c490df55ad287d58c63870' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet ./packs ./sdk ./templates ./LICENSE.txt ./ThirdPartyNotices.txt ./sdk-manifests \
    && rm dotnet.tar.gz \
    # Trigger first run experience by running arbitrary cmd
    && dotnet help

# # Install Microsoft.dotnet-interactive
RUN dotnet tool install -g Microsoft.dotnet-interactive --version 1.0.317502 --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json"

RUN dotnet interactive jupyter install

# # Install lastest build of Microsoft.DotNet.Interactive - net6.0
# RUN dotnet tool install -g Microsoft.dotnet-interactive --version --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-experimental/nuget/v3/index.json" \
#     && dotnet interactive jupyter install

# Expose Jupyter port & cmd
EXPOSE 8888
CMD jupyter lab --ip=* --port=8888 --no-browser --notebook-dir=/opt/app/data --allow-root
