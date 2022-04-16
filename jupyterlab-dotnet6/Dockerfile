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
RUN dotnet_version=6.0.4 \
    && wget -O dotnet.tar.gz https://dotnetcli.azureedge.net/dotnet/Runtime/$dotnet_version/dotnet-runtime-$dotnet_version-linux-musl-x64.tar.gz \
    && dotnet_sha512='e5b538482f10a667bee3b7482db0ac0cac27b5bddab9f3ab68bd5c5d7c18c5bec2bdcb8cd288052c3f3e186291ee02190ff01896c2835ce32b87e18cd817759e' \
    && echo "$dotnet_sha512  dotnet.tar.gz" | sha512sum -c - \
    && mkdir -p /usr/share/dotnet \
    && tar -oxzf dotnet.tar.gz -C /usr/share/dotnet \
    && rm dotnet.tar.gz \
    && ln -s /usr/share/dotnet/dotnet /usr/bin/dotnet

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
RUN dotnet tool install -g Microsoft.dotnet-interactive --version 1.0.317502 --add-source "https://pkgs.dev.azure.com/dnceng/public/_packaging/dotnet-tools/nuget/v3/index.json" \
    && dotnet interactive jupyter install

# Expose Jupyter port & cmd
EXPOSE 8888
CMD jupyter lab --ip=* --port=8888 --no-browser --notebook-dir=/opt/app/data --allow-root
