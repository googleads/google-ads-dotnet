#!/bin/bash

# This script can be run either from the root of the google-ads-dotnet
# repo or from Kokoro to make a client library release. If running
# locally, make sure you set GOOGLE_ADS_DOTNET_GITHUB_KEY and
# GOOGLE_ADS_DOTNET_NUGET_KEY as environment variables before running
# this script. For Kokoro jobs, these keys come from the keystore.

scriptdir="$( dirname -- "$BASH_SOURCE"; )";
source "${scriptdir}/common.sh"

# Fail on any error.
set -e

dotnet_library::release_main
