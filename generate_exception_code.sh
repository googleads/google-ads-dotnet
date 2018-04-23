#!/bin/bash

for client_file in $(find src/V0 -name '*Client.cs')
do
  output_file=$(echo $client_file | sed 's/\.cs/ExceptionCustomization\.cs/')
  client=$(echo $client_file | sed -r 's/.*\/([A-Za-z]+Client)\.cs/\1/')
  ns=$(grep namespace $client_file | cut -d\  -f 2)
  year=$(date +%Y)
  cat > $output_file <<END_OF_FILE
// Copyright $year Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code - do not edit

using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Ads.GoogleAds.Lib;

namespace ${ns}
{
    public partial class ${client}Impl
    {
        // Modify every API call on construction to use GoogleAdsException
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse> =>
            call = call.WithExceptionCustomizer(GoogleAdsException.Create);
    }
}
END_OF_FILE
echo "Generated $output_file"
done
