#!/bin/bash

scriptdir="$( dirname -- "$BASH_SOURCE"; )";
source "${scriptdir}/common.sh"

# This script can be run either from the root of the google-ads-dotnet
# repo or from Kokoro to build the client library.

# Fail on any error.
set -e

dotnet_library::build_main
