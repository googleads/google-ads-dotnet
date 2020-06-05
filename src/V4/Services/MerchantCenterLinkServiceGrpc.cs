// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/merchant_center_link_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
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
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// This service allows management of links between Google Ads and Google
  /// Merchant Center.
  /// </summary>
  public static partial class MerchantCenterLinkService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.MerchantCenterLinkService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest> __Marshaller_google_ads_googleads_v4_services_ListMerchantCenterLinksRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse> __Marshaller_google_ads_googleads_v4_services_ListMerchantCenterLinksResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest> __Marshaller_google_ads_googleads_v4_services_GetMerchantCenterLinkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink> __Marshaller_google_ads_googleads_v4_resources_MerchantCenterLink = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest> __Marshaller_google_ads_googleads_v4_services_MutateMerchantCenterLinkRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse> __Marshaller_google_ads_googleads_v4_services_MutateMerchantCenterLinkResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest, global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse> __Method_ListMerchantCenterLinks = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest, global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListMerchantCenterLinks",
        __Marshaller_google_ads_googleads_v4_services_ListMerchantCenterLinksRequest,
        __Marshaller_google_ads_googleads_v4_services_ListMerchantCenterLinksResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink> __Method_GetMerchantCenterLink = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMerchantCenterLink",
        __Marshaller_google_ads_googleads_v4_services_GetMerchantCenterLinkRequest,
        __Marshaller_google_ads_googleads_v4_resources_MerchantCenterLink);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse> __Method_MutateMerchantCenterLink = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateMerchantCenterLink",
        __Marshaller_google_ads_googleads_v4_services_MutateMerchantCenterLinkRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateMerchantCenterLinkResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.MerchantCenterLinkServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MerchantCenterLinkService</summary>
    [grpc::BindServiceMethod(typeof(MerchantCenterLinkService), "BindService")]
    public abstract partial class MerchantCenterLinkServiceBase
    {
      /// <summary>
      /// Returns Merchant Center links available for this customer.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse> ListMerchantCenterLinks(global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the Merchant Center link in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink> GetMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates status or removes a Merchant Center link.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse> MutateMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MerchantCenterLinkService</summary>
    public partial class MerchantCenterLinkServiceClient : grpc::ClientBase<MerchantCenterLinkServiceClient>
    {
      /// <summary>Creates a new client for MerchantCenterLinkService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MerchantCenterLinkServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MerchantCenterLinkService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MerchantCenterLinkServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MerchantCenterLinkServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MerchantCenterLinkServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns Merchant Center links available for this customer.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse ListMerchantCenterLinks(global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMerchantCenterLinks(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns Merchant Center links available for this customer.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse ListMerchantCenterLinks(global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListMerchantCenterLinks, null, options, request);
      }
      /// <summary>
      /// Returns Merchant Center links available for this customer.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMerchantCenterLinksAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns Merchant Center links available for this customer.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListMerchantCenterLinks, null, options, request);
      }
      /// <summary>
      /// Returns the Merchant Center link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink GetMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMerchantCenterLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the Merchant Center link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink GetMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMerchantCenterLink, null, options, request);
      }
      /// <summary>
      /// Returns the Merchant Center link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink> GetMerchantCenterLinkAsync(global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMerchantCenterLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the Merchant Center link in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink> GetMerchantCenterLinkAsync(global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMerchantCenterLink, null, options, request);
      }
      /// <summary>
      /// Updates status or removes a Merchant Center link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse MutateMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateMerchantCenterLink(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates status or removes a Merchant Center link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse MutateMerchantCenterLink(global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateMerchantCenterLink, null, options, request);
      }
      /// <summary>
      /// Updates status or removes a Merchant Center link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateMerchantCenterLinkAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates status or removes a Merchant Center link.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateMerchantCenterLink, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MerchantCenterLinkServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MerchantCenterLinkServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MerchantCenterLinkServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListMerchantCenterLinks, serviceImpl.ListMerchantCenterLinks)
          .AddMethod(__Method_GetMerchantCenterLink, serviceImpl.GetMerchantCenterLink)
          .AddMethod(__Method_MutateMerchantCenterLink, serviceImpl.MutateMerchantCenterLink).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MerchantCenterLinkServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListMerchantCenterLinks, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksRequest, global::Google.Ads.GoogleAds.V4.Services.ListMerchantCenterLinksResponse>(serviceImpl.ListMerchantCenterLinks));
      serviceBinder.AddMethod(__Method_GetMerchantCenterLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Resources.MerchantCenterLink>(serviceImpl.GetMerchantCenterLink));
      serviceBinder.AddMethod(__Method_MutateMerchantCenterLink, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkRequest, global::Google.Ads.GoogleAds.V4.Services.MutateMerchantCenterLinkResponse>(serviceImpl.MutateMerchantCenterLink));
    }

  }
}
#endregion
