// Copyright 2018 Google LLC
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

using Google.Ads.GoogleAds.V0.Errors;

using Grpc.Core;

namespace Google.Ads.GoogleAds.Lib {

  /// <summary>
  /// Exception thrown in response to an API error from the GoogleAds servers.
  /// </summary>
  public sealed class GoogleAdsException : RpcException {

    /// <summary>
    /// The gRPC metadata key name for the serialized failure object.
    /// </summary>
    private const string FailureKey = "google.ads.googleads.v0.errors.googleadsfailure-bin";

    /// <summary>
    /// The gRPC metadata key name for request ID.
    /// </summary>
    private const string RequestIdKey = "request-id";

    /// <summary>
    /// Gets the Google Ads failure details.
    /// </summary>
    public GoogleAdsFailure Failure {
      get;
    }

    /// <summary>
    /// Gets the request ID.
    /// </summary>
    public string RequestId {
      get;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleAdsException"/> class.
    /// </summary>
    /// <param name="status">Resulting status of a call.</param>
    /// <param name="trailers">Response trailing metadata.</param>
    private GoogleAdsException(Status status, Metadata trailers) : base(status, trailers) {
      foreach (Metadata.Entry entry in trailers) {
        switch (entry.Key) {
          case FailureKey:
            Failure = GoogleAdsFailure.Parser.ParseFrom(entry.ValueBytes);
            break;

          case RequestIdKey:
            RequestId = entry.Value;
            break;
        }
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleAdsException"/> class.
    /// </summary>
    /// <param name="status">Resulting status of a call.</param>
    /// <param name="message">The exception message.</param>
    private GoogleAdsException(Status status, string message) : base(status, message) {
    }

    /// <summary>
    /// Creates a new instance of the <see cref="GoogleAdsException"/> class from an
    /// <see cref="RpcException"/>.
    /// </summary>
    /// <param name="rpcException">The original gRPC exception.</param>
    /// <returns></returns>
    internal static GoogleAdsException Create(RpcException rpcException) {
      return (rpcException.Trailers != null)
          ? new GoogleAdsException(rpcException.Status, rpcException.Trailers)
          : new GoogleAdsException(rpcException.Status, rpcException.Message);
    }
  }
}
