// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_bid_modifier_service.proto
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

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage ad group bid modifiers.
  /// </summary>
  public static partial class AdGroupBidModifierService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.AdGroupBidModifierService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest> __Marshaller_google_ads_googleads_v3_services_GetAdGroupBidModifierRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier> __Marshaller_google_ads_googleads_v3_resources_AdGroupBidModifier = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupBidModifiersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupBidModifiersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier> __Method_GetAdGroupBidModifier = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupBidModifier",
        __Marshaller_google_ads_googleads_v3_services_GetAdGroupBidModifierRequest,
        __Marshaller_google_ads_googleads_v3_resources_AdGroupBidModifier);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse> __Method_MutateAdGroupBidModifiers = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupBidModifiers",
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupBidModifiersRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupBidModifiersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupBidModifierServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupBidModifierService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupBidModifierService), "BindService")]
    public abstract partial class AdGroupBidModifierServiceBase
    {
      /// <summary>
      /// Returns the requested ad group bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier> GetAdGroupBidModifier(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ad group bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiers(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupBidModifierService</summary>
    public partial class AdGroupBidModifierServiceClient : grpc::ClientBase<AdGroupBidModifierServiceClient>
    {
      /// <summary>Creates a new client for AdGroupBidModifierService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupBidModifierServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupBidModifierService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupBidModifierServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupBidModifierServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupBidModifierServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier GetAdGroupBidModifier(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupBidModifier(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier GetAdGroupBidModifier(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupBidModifier, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier> GetAdGroupBidModifierAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupBidModifierAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier> GetAdGroupBidModifierAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupBidModifier, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupBidModifiers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupBidModifiers, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad group bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupBidModifiersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad group bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupBidModifiers, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupBidModifierServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupBidModifierServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupBidModifierServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupBidModifier, serviceImpl.GetAdGroupBidModifier)
          .AddMethod(__Method_MutateAdGroupBidModifiers, serviceImpl.MutateAdGroupBidModifiers).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupBidModifierServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupBidModifier, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupBidModifierRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupBidModifier>(serviceImpl.GetAdGroupBidModifier));
      serviceBinder.AddMethod(__Method_MutateAdGroupBidModifiers, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupBidModifiersResponse>(serviceImpl.MutateAdGroupBidModifiers));
    }

  }
}
#endregion
