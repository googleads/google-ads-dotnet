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

# This script can be run either from the root of the google-ads-dotnet
# repo or from Kokoro to make a client library release. If running
# locally, make sure you set GOOGLE_ADS_DOTNET_GITHUB_KEY and
# GOOGLE_ADS_DOTNET_NUGET_KEY as environment variables before running
# this script. For Kokoro jobs, these keys come from the keystore.

scriptdir="$( dirname -- "$BASH_SOURCE"; )";
source "${scriptdir}/common.sh"

# Fail on any error.
set -e

#dotnet_library::release_main
echo "Now in parent..."

echo "Installing tree..."
sudo apt-get install tree

echo "Listing the contents of ${KOKORO_GFILE_DIR}"
tree ${KOKORO_GFILE_DIR} 
