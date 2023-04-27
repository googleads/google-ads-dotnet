#!/bin/bash
# Copyright 2022 Google LLC
#
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
#
#     http:#www.apache.org/licenses/LICENSE-2.0
#
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.

########################################################################
# Sets up the global variable for REPO_ROOT relative to KOKORO_ROOT. The
# calculated value depends on whether we are building from GitHub or
# GOB.
# Globals:
#   KOKORO_ROOT the location that Kokoro sets up as the root directory
#     of the build-related inputs.
#   REPO_ROOT the root directory of the google-ads-dotnet repo. This
#     variable is set by this function.
# Arguments:
#   None
########################################################################
function dotnet_library::set_repo_root() {
  # start with GitHub, fallback to GoB and then pwd.
  REPO_ROOT="${KOKORO_ROOT}"/src/github/google-ads-dotnet
  if [[ ! -d "${REPO_ROOT}" ]]; then
    REPO_ROOT="${KOKORO_ROOT}"/src/git/google-ads-dotnet
  fi
  if [[ ! -d "${REPO_ROOT}" ]]; then
    # This script is running locally, from the root of the repo.
    REPO_ROOT=`pwd`
    KOKORO_ARTIFACTS_DIR="${REPO_ROOT}"/output
    # There should be a folder named keystore at the root of the
    # repo, and it should contain two files:
    # - 74347_google_ads_dotnet_github_key: This file contains the GitHub key.
    # - 74347_google_ads_dotnet_nuget_key: This file contains the NuGet key.
    KOKORO_KEYSTORE_DIR="${REPO_ROOT}/keystore"
  fi
  echo "Repo root is '${REPO_ROOT}'"
}

########################################################################
# Sets up additional convenience global variables relative to the repo
# root.
# Globals:
#   REPO_ROOT the root directory of the google-ads-dotnet repo.
#   DOTNET_GAX_LIBRARY_PATH root of the Google.Ads.Gax package
#     source code.
#   DOTNET_CORE_LIBRARY_PATH root of the Google.Ads.GoogleAds.Core
#     package source code.
#   DOTNET_CLIENT_LIBRARY_PATH root of the Google.Ads.GoogleAds package
#     source code.
#   DOTNET_EXTENSIONS_LIBRARY_PATH root of the
#     Google.Ads.GoogleAds.Extensions package source code.
#   DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH: The list of paths / URIs where
#     the dotnet command looks for resolving nuget packages.
#   GITHUB_RELEASE_URL: The URL for making GitHub release.
# Arguments:
#   None
########################################################################
function dotnet_library::set_path_variables() {
  DOTNET_GAX_LIBRARY_PATH="${REPO_ROOT}"/Google.Ads.Gax
  DOTNET_CORE_LIBRARY_PATH="${REPO_ROOT}"/Google.Ads.GoogleAds.Core
  DOTNET_CLIENT_LIBRARY_PATH="${REPO_ROOT}"/Google.Ads.GoogleAds
  DOTNET_EXTENSIONS_LIBRARY_PATH="${REPO_ROOT}"/Google.Ads.GoogleAds.Extensions
  DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH="${DOTNET_CLIENT_LIBRARY_PATH}/custom_nupkg"
  NUGET_PACKAGE_PATH="https://api.nuget.org/v3/index.json;${DOTNET_CLIENT_LIBRARY_CUSTOM_NUGET_PATH}"
  GITHUB_RELEASE_URL="https://api.github.com/repos/googleads/google-ads-dotnet/releases"
}

########################################################################
# Extracts the secrets from Keystore.
# Globals:
#   KOKORO_KEYSTORE_DIR the root directory where Kokoro saves the
#     keystore secrets.
#   GOOGLE_ADS_DOTNET_GITHUB_KEY The GitHub key for making the release.
#   GOOGLE_ADS_DOTNET_NUGET_KEY The NuGet key for making the release.
# Arguments:
#   None
########################################################################
function dotnet_library::extract_keystore_secrets() {
  GOOGLE_ADS_DOTNET_GITHUB_KEY="$(cat "${KOKORO_KEYSTORE_DIR}/74347_google_ads_dotnet_github_key")"
  GOOGLE_ADS_DOTNET_NUGET_KEY="$(cat "${KOKORO_KEYSTORE_DIR}/74347_google_ads_dotnet_nuget_key")"
}

########################################################################
# Installs the necessary .NET SDK and runtime versions. The installation
# is done at a local directory instead of as a global package.
# Globals:
#   REPO_ROOT the root directory of the google-ads-dotnet repo.
#   DOTNET_BINARY the path to the dotnet compiler binary. This global
#     variable is set by this method upon successful installation of the
#     .NET SDK.
# Arguments:
#   None
########################################################################
function dotnet_library::install_dotnet() {
  # Note:
  # * dotnet-sdk-6.0 is capable of compiling the code to all the 4
  #  frameworks - net6.0, net5.0, net472 and netcoreapp3.1. Hence we
  #  install dotnet-sdk-6.0.
  # * To run the tests, we need the corresponding runtimes to be installed.
  #   *  dotnet-runtime-5.0 is installed to run tests for net5.0.
  #   *  The library supports netstandard2.0, but Microsoft expects test
  #      assemblies to be compiled against executable targets even though
  #      the test itself is written as a library. So we target
  #      netcoreapp3.1 instead of netstandard2.0 in the
  #      various test assemblies and install dotnet-runtime-3.1 to run
  #      the tests.
  #   *  .NET 6.0 runtime is included in dotnet-sdk-6.0, so we don't
  #      install dotnet-runtime-6.0.
  #   *  We don't install mono (or run tests for .NET 472). Pretty much
  #      no one uses mono, and mono itself is known to have multiple
  #      deviations from the .NET Framework 472, so testing for .NET 472
  #      using Mono isn't a reliable approach. Instead, we run tests
  #      locally for .NET 472.
  # * We use Microsoft's dotnet-install.sh and let it deal with resolving
  #   download locations and platform-specific builds.

  # Install dotnet 3.1, 5.0, 6.0.
  echo "Installing .NET"
  echo "==============="

  mkdir -p "${REPO_ROOT}/dotnet_setup"
  cp "${REPO_ROOT}/third_party/dotnet/dotnet-install.sh" \
    "${REPO_ROOT}/dotnet_setup/dotnet-install.sh"
  pushd "${REPO_ROOT}/dotnet_setup"
  chmod 755 ./dotnet-install.sh
  ./dotnet-install.sh --install-dir . --version 6.0.300
  ./dotnet-install.sh --install-dir . --runtime dotnet --version 5.0.13
  ./dotnet-install.sh --install-dir . --runtime dotnet --version 3.1.22
  DOTNET_BINARY="${REPO_ROOT}/dotnet_setup/dotnet"
  popd

  # Verify dotnet install
  "${DOTNET_BINARY}" --info
}

########################################################################
# Installs additional tools required to complete the build and release.
# Globals:
#   None
# Arguments:
#   None
########################################################################
function dotnet_library::install_additional_tools() {
  sudo apt-get update -y
  sudo apt-get install jq -y
}

########################################################################
# Builds the library source code and runs the tests.
# Globals:
#   REPO_ROOT the root directory of the google-ads-dotnet repo.
#   DOTNET_BINARY the path to the dotnet compiler binary.
#   NUGET_PACKAGE_PATH the path to the local folder where additional
#     nuget packages may be stored. This path is usually empty, and is
#     primarily used to test the library against an experimental or
#     yet-unreleased library dependency like the Protobuf library. The
#     package dependencies are downloaded from nuget.org except in
#     situations where a package present in this directory overrides it.
#   DOTNET_GAX_LIBRARY_PATH root of the Google.Ads.Gax package
#     source code.
#   DOTNET_CORE_LIBRARY_PATH root of the Google.Ads.GoogleAds.Core
#     package source code.
#   DOTNET_CLIENT_LIBRARY_PATH root of the Google.Ads.GoogleAds package
#     source code.
# Arguments:
#   None
########################################################################
function dotnet_library::build_library() {
  mkdir -p "${REPO_ROOT}/artifacts"
  pushd "${DOTNET_CLIENT_LIBRARY_PATH}"

  echo "Build the library."
  echo "=================="

  # This step will build Google.Ads.GoogleAds.Core and Google.Ads.Gax
  # as dependencies, so we don't separately build them.
  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/src/Google.Ads.GoogleAds.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_EXTENSIONS_LIBRARY_PATH}/src/Google.Ads.GoogleAds.Extensions.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_GAX_LIBRARY_PATH}/tests/TestUtilities/Google.Ads.Gax.TestUtilities.csproj"

  echo "Build the examples."
  echo "==================="
  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Google.Ads.GoogleAds.Examples.csproj"

  echo "Build the authentication example projects."
  echo "=========================================="
  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/GenerateUserCredentials/GenerateUserCredentials.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/examples/Authentication/AuthenticateInAspNetCoreApplication/AuthenticateInAspNetCoreApplication.csproj"

  echo "Build the tests."
  echo "================"
  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Tests.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_CORE_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Core.Tests.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_GAX_LIBRARY_PATH}/tests/Google.Ads.Gax.Tests.csproj"

  "${DOTNET_BINARY}" build --configuration Release --source "${NUGET_PACKAGE_PATH}" \
      "${DOTNET_EXTENSIONS_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Extensions.Tests.csproj"

  echo "Run the smoke tests."
  echo "===================="

  "${DOTNET_BINARY}" test --configuration Release --no-build  \
      "${DOTNET_CLIENT_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Tests.csproj" \
      -s "${DOTNET_CLIENT_LIBRARY_PATH}/tests/presubmit.runsettings"

 "${DOTNET_BINARY}" test --configuration Release --no-build  \
      "${DOTNET_CORE_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Core.Tests.csproj" \
      -s "${DOTNET_CORE_LIBRARY_PATH}/tests/presubmit.runsettings"

  "${DOTNET_BINARY}" test --configuration Release --no-build  \
      "${DOTNET_GAX_LIBRARY_PATH}/tests/Google.Ads.Gax.Tests.csproj"

  "${DOTNET_BINARY}" test --configuration Release --no-build  \
      "${DOTNET_EXTENSIONS_LIBRARY_PATH}/tests/Google.Ads.GoogleAds.Extensions.Tests.csproj"

  popd
}

########################################################################
# Builds the library artifacts such as nuget packages.
# Globals:
#   REPO_ROOT the root directory of the google-ads-dotnet repo.
#   DOTNET_BINARY the path to the dotnet compiler binary.
#   DOTNET_GAX_LIBRARY_PATH root of the Google.Ads.Gax package
#     source code.
#   DOTNET_CORE_LIBRARY_PATH root of the Google.Ads.GoogleAds.Core
#     package source code.
#   DOTNET_CLIENT_LIBRARY_PATH root of the Google.Ads.GoogleAds package
#     source code.
# Arguments:
#   None
########################################################################
function dotnet_library::build_library_artifacts() {
  mkdir -p "${REPO_ROOT}/artifacts"

  echo "Package the library"
  echo "==================="

  "${DOTNET_BINARY}" pack --configuration Release --no-build \
      --output "${REPO_ROOT}/artifacts" \
      "${DOTNET_GAX_LIBRARY_PATH}/tests/TestUtilities/Google.Ads.Gax.TestUtilities.csproj"

  "${DOTNET_BINARY}" pack --configuration Release --no-build \
      --output "${REPO_ROOT}/artifacts" \
      "${DOTNET_GAX_LIBRARY_PATH}/src/Google.Ads.Gax.csproj"
  "${DOTNET_BINARY}" pack --configuration Release --no-build \
      --output "${REPO_ROOT}/artifacts" \
      "${DOTNET_CORE_LIBRARY_PATH}/src/Google.Ads.GoogleAds.Core.csproj"
  "${DOTNET_BINARY}" pack --configuration Release --no-build \
      --output "${REPO_ROOT}/artifacts" \
      "${DOTNET_CLIENT_LIBRARY_PATH}/src/Google.Ads.GoogleAds.csproj"
  "${DOTNET_BINARY}" pack --configuration Release --no-build \
      --output "${REPO_ROOT}/artifacts" \
      "${DOTNET_EXTENSIONS_LIBRARY_PATH}/src/Google.Ads.GoogleAds.Extensions.csproj"

  echo "Library packages created successfully"
}

########################################################################
# Saves the build artifacts by copying them to Kokoro artifacts
# directory.
# Globals:
#   REPO_ROOT the root directory of the google-ads-dotnet repo.
#   KOKORO_ARTIFACTS_DIR the root directory for artifacts. Kokoro will
#     save any files and folders under this root to a storage location
#     as specified in the build configuration.
# Arguments:
#   None
########################################################################
function dotnet_library::save_build_artifacts() {
  echo "Saving build artifacts"
  echo "======================"

  # Make sure the directory exists.
  mkdir -p "${KOKORO_ARTIFACTS_DIR}"
  cp -r "${REPO_ROOT}/artifacts" "${KOKORO_ARTIFACTS_DIR}/artifacts"

  echo "Build packages saved successfully"
}

########################################################################
# Uploads the nuget packages to nuget.org.
# Globals:
#   DOTNET_BINARY the path to the dotnet compiler binary.
#   GOOGLE_ADS_DOTNET_NUGET_KEY the nuget key for publishing the package.
#   KOKORO_GFILE_DIR root of the Kokoro GFile directory. Kokoro downloads
#     the output from the build job into this directory.
# Arguments:
#   None
########################################################################
function dotnet_library::upload_nuget_packages() {
  echo "Uploading the packages to nuget.org"
  echo "==================================="

  # Note: this command will skip any conflicting packages and versions,
  # so there is no need to detect if a package was formally published.
  # So it is safe to run this command multiple times.
  # Note: We do not publish debug symbols today, hence we skip it.

  rm ${KOKORO_GFILE_DIR}/*.symbols.nupkg
  "${DOTNET_BINARY}" nuget push --api-key ${GOOGLE_ADS_DOTNET_NUGET_KEY} \
      --skip-duplicate --no-symbols \
      --source https://api.nuget.org/v3/index.json \
      "${KOKORO_GFILE_DIR}/*.nupkg"

  echo "Packages uploaded to nuget.org successfully"
}

########################################################################
# Check if a release exists on GitHub.
# Globals:
#   KOKORO_GFILE_DIR root of the Kokoro GFile directory. Kokoro downloads
#     the output from the build job into this directory.
#   LIBRARY_VERSION_TO_RELEASE: This is the new library version to
#     release.
#   LIBRARY_VERSION_EXISTS This flag is set to true if the release
#     exists, false otherwise.
#   GITHUB_RELEASE_URL: The URL for making GitHub release.
# Arguments:
#   None
########################################################################
function dotnet_library::check_library_release_version_exists() {
  pushd "${KOKORO_GFILE_DIR}"
  while read i
  do
    version_match=`echo "${i}" | sed -rn "s/Google\.Ads\.GoogleAds\.(([0-9]*\.?){3})\.nupkg/\1/p"`
    if [[ -n "${version_match}" ]]
    then
      LIBRARY_VERSION_TO_RELEASE="${version_match}"
      break
    fi
  done < <(ls Google.Ads.GoogleAds.*.nupkg)
  echo "Library version to release is '${LIBRARY_VERSION_TO_RELEASE}'."
  if [[ -z "${LIBRARY_VERSION_TO_RELEASE}" ]]; then
    LIBRARY_VERSION_EXISTS=0
  else
    jq_query=".[] | select(.tag_name==\""v${LIBRARY_VERSION_TO_RELEASE}\"") | .tag_name"

    version_tag=`curl "${GITHUB_RELEASE_URL}" | jq "${jq_query}"`
    echo "Version tag is ${version_tag}"
    if [[ -z "${version_tag}" ]]; then
      LIBRARY_VERSION_EXISTS=0
    else
      LIBRARY_VERSION_EXISTS=1
    fi
  fi
  echo "Library version exists: ${LIBRARY_VERSION_EXISTS}"
  popd
}

########################################################################
# Makes a release on the GitHub repo.
# Globals:
#   LIBRARY_VERSION_TO_RELEASE: This is the new library version to
#     release.
#   DOTNET_CLIENT_LIBRARY_PATH root of the Google.Ads.GoogleAds package
#     source code.
#   GOOGLE_ADS_DOTNET_GITHUB_KEY the GitHub key for making the release.
# Arguments:
#   None
########################################################################
function dotnet_library::make_github_release() {
  echo "Making a GitHub release"
  echo "======================="

  payload=$(cat <<-END
{
    "tag_name" : "v${LIBRARY_VERSION_TO_RELEASE}",
    "target_commitish" : "main",
    "name" : "Google Ads Client Library for .NET - v${LIBRARY_VERSION_TO_RELEASE}",
    "body" : "Release of version ${LIBRARY_VERSION_TO_RELEASE}",
    "draft" : false,
    "prerelease" : false,
    "generate_release_notes" : false
}
END
)

  full_output=$(curl -X POST -H "Accept: application/vnd.github.v3+json" \
    -H "Authorization: token ${GOOGLE_ADS_DOTNET_GITHUB_KEY}" \
    "${GITHUB_RELEASE_URL}" -d "${payload}")

  release_id=$(echo ${full_output} | jq ".id")
  if (( $release_id )); then
    echo "GitHub release was successful!"
  else
    echo "GitHub release failed. Full response: ${full_output}"
  fi
}

########################################################################
# Builds the client library.
# Globals:
#   None
# Arguments:
#   None
########################################################################
function dotnet_library::build_main() {
  echo "Starting a build"
  echo "================"

  dotnet_library::set_repo_root
  dotnet_library::set_path_variables
  dotnet_library::install_dotnet
  dotnet_library::install_additional_tools
  dotnet_library::build_library
  dotnet_library::build_library_artifacts
  dotnet_library::save_build_artifacts

  echo "Build completed successfully. Build artifacts are available on placer."
}

########################################################################
# Releases the client library.
# Globals:
#   LIBRARY_VERSION_EXISTS: This flag is set to true if the release
#     exists, false otherwise.
# Arguments:
#   None
########################################################################
function dotnet_library::release_main() {
  dotnet_library::set_repo_root
  dotnet_library::set_path_variables
  dotnet_library::install_dotnet
  dotnet_library::install_additional_tools
  dotnet_library::extract_keystore_secrets
  dotnet_library::check_library_release_version_exists
  if (( ${LIBRARY_VERSION_EXISTS} )); then
    echo "Library version ${LIBRARY_VERSION_TO_RELEASE} exists. "
    echo "Aborting release. Build artifacts are available on placer."
    exit 1
  fi
  dotnet_library::make_github_release
  dotnet_library::upload_nuget_packages
}
