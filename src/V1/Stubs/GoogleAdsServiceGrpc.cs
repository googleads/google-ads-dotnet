// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/google_ads_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2019 Google LLC.
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
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V1.Services {
  /// <summary>
  /// Service to fetch data and metrics across resources.
  /// </summary>
  public static partial class GoogleAdsService
  {
    static readonly string __ServiceName = "google.ads.googleads.v1.services.GoogleAdsService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest> __Marshaller_google_ads_googleads_v1_services_SearchGoogleAdsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse> __Marshaller_google_ads_googleads_v1_services_SearchGoogleAdsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest> __Marshaller_google_ads_googleads_v1_services_MutateGoogleAdsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse> __Marshaller_google_ads_googleads_v1_services_MutateGoogleAdsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest, global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse> __Method_Search = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest, global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_google_ads_googleads_v1_services_SearchGoogleAdsRequest,
        __Marshaller_google_ads_googleads_v1_services_SearchGoogleAdsResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest, global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse> __Method_Mutate = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest, global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Mutate",
        __Marshaller_google_ads_googleads_v1_services_MutateGoogleAdsRequest,
        __Marshaller_google_ads_googleads_v1_services_MutateGoogleAdsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V1.Services.GoogleAdsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GoogleAdsService</summary>
    public abstract partial class GoogleAdsServiceBase
    {
      /// <summary>
      /// Returns all rows that match the search query.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse> Search(global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes resources. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse> Mutate(global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GoogleAdsService</summary>
    public partial class GoogleAdsServiceClient : grpc::ClientBase<GoogleAdsServiceClient>
    {
      /// <summary>Creates a new client for GoogleAdsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GoogleAdsServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GoogleAdsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GoogleAdsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GoogleAdsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GoogleAdsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns all rows that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse Search(global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Search(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all rows that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse Search(global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>
      /// Returns all rows that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse> SearchAsync(global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all rows that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsResponse> SearchAsync(global::Google.Ads.GoogleAds.V1.Services.SearchGoogleAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes resources. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse Mutate(global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Mutate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes resources. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse Mutate(global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Mutate, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes resources. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse> MutateAsync(global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes resources. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsResponse> MutateAsync(global::Google.Ads.GoogleAds.V1.Services.MutateGoogleAdsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Mutate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GoogleAdsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GoogleAdsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GoogleAdsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Search, serviceImpl.Search)
          .AddMethod(__Method_Mutate, serviceImpl.Mutate).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GoogleAdsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Search, serviceImpl.Search);
      serviceBinder.AddMethod(__Method_Mutate, serviceImpl.Mutate);
    }

  }
}
#endregion
