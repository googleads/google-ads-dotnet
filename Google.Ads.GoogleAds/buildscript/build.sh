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
  DOTNET_GAX_LIBRARY_PATH="${KOKORO_ROOT}"/src/github/google-ads-dotnet
  if [[ ! -d "${DOTNET_CLIENT_LIBRARY_PATH}" ]]; then
    DOTNET_CLIENT_LIBRARY_PATH="${KOKORO_ROOT}"/src/git/google-ads-dotnet/Google.Ads.GoogleAds
    DOTNET_GAX_LIBRARY_PATH="${KOKORO_ROOT}"/src/git/google-ads-dotnet/Google.Ads.Gax
  fi

  DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH="${DOTNET_CLIENT_LIBRARY_PATH}/custom_nupkg"

  dotnet_library::install_dotnet
  dotnet_library::build_library
}

function dotnet_library::install_dotnet() {
  # "Distro Check"
  uname -r

  # Note:
  # * dotnet-sdk-6.0 is capable of compiling the code to all the 4 frameworks - net6.0, net5.0,
  #   net472 and netcoreapp3.1. Hence we install dotnet-sdk-6.0.
  # * On Linux, dotnet-sdk-6.0 forwards the compilation of .net472 to Mono. Hence we install
  #   mono-complete.
  # * To actually run the tests, we need the corresponding runtimes to be installed.
  #   *  dotnet-runtime-5.0 is installed to run tests for net5.0.
  #   *  The library actually supports netstandard2.0, but Microsoft expects test assemblies to be
  #      compiled against executable targets even though the test itself is written as a library.
  #      So we target netcoreapp3.1 instead of netstandard2.0 in the Google.Ads.GoogleAds.Tests.dll
  #      and install dotnet-runtime-3.1 to run the tests.
  #   *  .NET 472 runtime is included in mono-complete, so we don't install mono-runtime package.
  #   *  .NET 6.0 runtime is included in dotnet-sdk-6.0, so we don't install dotnet-runtime-6.0.

  # "Install dotnet 3.1, 5.0, 6.0"
  wget -q https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
  sudo dpkg -i packages-microsoft-prod.deb
  sudo add-apt-repository universe
  sudo apt-get update
  sudo apt-get install apt-transport-https -y
  sudo apt-get install dotnet-sdk-6.0 -y
  sudo apt-get install dotnet-runtime-5.0 -y
  sudo apt-get install dotnet-runtime-3.1 -y

  # "Verify dotnet install"
  dotnet --info

  # "Install mono."
  #sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
  #sudo apt install apt-transport-https ca-certificates
  #echo "deb https://download.mono-project.com/repo/ubuntu stable-xenial main" | sudo tee /etc/apt/sources.list.d/mono-official-stable.list
  #sudo apt update
  #sudo apt-get install mono-complete -y

  # "Verify mono install"
  #mono --version
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
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/GenerateUserCredentials/GenerateUserCredentials.csproj"

  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/AuthenticateInAspNetCoreApplication/AuthenticateInAspNetCoreApplication.csproj"

  echo "Build the tests."
  echo "=============="
  dotnet build --configuration Release  \
      --source "https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Tests.csproj"

  echo "Run the smoke tests."
  echo "===================="
  dotnet test --configuration Release --no-build  \
      "${DOTNET_CLIENT_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Tests.csproj" \
      -s "${DOTNET_CLIENT_LIBRARY_PATH}/tests/presubmit.runsettings"

  dotnet test --configuration Release --no-build  \
      "${DOTNET_GAX_LIBRARY_PATH}/tests/Google.Ads.Gax.Tests.csproj"
}

dotnet_library::main
