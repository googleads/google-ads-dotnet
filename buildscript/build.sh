#!/bin/bash

function dotnet_library::main() {
  # Run tests for the google-ads-dotnet repo which is retrieved via GitHub or
  # Git-On-Borg.

  # Fail on any error.
  set -e

  # Variables related to client library.

  # This block is made to work with both GitHub and Git-On-Borg (GOB).
  # Source code is available at src/github/* in case of GitHub, whereas it's
  # available at src/git/* in case of GOB.
  DOTNET_CLIENT_LIBRARY_PATH="${KOKORO_ROOT}"/src/github/google-ads-dotnet
  if [[ ! -d "${DOTNET_CLIENT_LIBRARY_PATH}" ]]; then
    DOTNET_CLIENT_LIBRARY_PATH="${KOKORO_ROOT}"/src/git/google-ads-dotnet
  fi

  DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH="${DOTNET_CLIENT_LIBRARY_PATH}/custom_nupkg"

  dotnet_library::set_vars_for_dotnet_env
  dotnet_library::install_dotnet
  dotnet_library::build_library
}

function dotnet_library::set_vars_for_dotnet_env() {
  #Set an environment varlable to workaround https://github.com/dotnet/corefx/issues/38467
  export CLR_OPENSSL_VERSION_OVERRIDE=1.1
}

function dotnet_library::install_dotnet() {
  # "Distro Check"
  uname -r

 # Remove broken apt-get dependency (temporary)
  sudo rm /etc/apt/sources.list.d/cuda.list*
  # "Install dotnet 5.0"
  wget -q https://packages.microsoft.com/config/ubuntu/20.10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
  sudo dpkg -i packages-microsoft-prod.deb
  sudo add-apt-repository universe
  sudo apt-get update
  sudo apt-get install apt-transport-https -y
  sudo apt-get install dotnet-sdk-5.0 -y

  # "Verify dotnet install"
  dotnet --info
}

function dotnet_library::build_library() {
  cd "${DOTNET_CLIENT_LIBRARY_PATH}"

  echo "Build the library."
  echo "=================="

  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/src/Google.Ads.GoogleAds.csproj"

  echo "Build the examples."
  echo "==================="
  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Google.Ads.GoogleAds.Examples.csproj"

  echo "Build the authentication projects."
  echo "=================================="
  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/AuthenticateInDesktopApplication/AuthenticateInDesktopApplication.csproj"

  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/AuthenticateInWebApplication/AuthenticateInWebApplication.csproj"

  echo "Build the tests."
  echo "=============="
  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Tests.csproj"

  echo "Run the smoke tests."
  echo "==================="
  dotnet test "${DOTNET_CLIENT_LIBRARY_PATH}/tests/bin/Release/net5.0/Google.Ads.GoogleAds.Tests.dll" \
      -v d --filter TestCategory=Smoke
}

dotnet_library::main
