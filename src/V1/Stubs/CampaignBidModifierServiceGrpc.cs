// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/campaign_bid_modifier_service.proto
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
  /// Service to manage campaign bid modifiers.
  /// </summary>
  public static partial class CampaignBidModifierService
  {
    static readonly string __ServiceName = "google.ads.googleads.v1.services.CampaignBidModifierService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest> __Marshaller_google_ads_googleads_v1_services_GetCampaignBidModifierRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier> __Marshaller_google_ads_googleads_v1_resources_CampaignBidModifier = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest> __Marshaller_google_ads_googleads_v1_services_MutateCampaignBidModifiersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse> __Marshaller_google_ads_googleads_v1_services_MutateCampaignBidModifiersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest, global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier> __Method_GetCampaignBidModifier = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest, global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCampaignBidModifier",
        __Marshaller_google_ads_googleads_v1_services_GetCampaignBidModifierRequest,
        __Marshaller_google_ads_googleads_v1_resources_CampaignBidModifier);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest, global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse> __Method_MutateCampaignBidModifiers = new grpc::Method<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest, global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignBidModifiers",
        __Marshaller_google_ads_googleads_v1_services_MutateCampaignBidModifiersRequest,
        __Marshaller_google_ads_googleads_v1_services_MutateCampaignBidModifiersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V1.Services.CampaignBidModifierServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CampaignBidModifierService</summary>
    public abstract partial class CampaignBidModifierServiceBase
    {
      /// <summary>
      /// Returns the requested campaign bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier> GetCampaignBidModifier(global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes campaign bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse> MutateCampaignBidModifiers(global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CampaignBidModifierService</summary>
    public partial class CampaignBidModifierServiceClient : grpc::ClientBase<CampaignBidModifierServiceClient>
    {
      /// <summary>Creates a new client for CampaignBidModifierService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CampaignBidModifierServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CampaignBidModifierService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CampaignBidModifierServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CampaignBidModifierServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CampaignBidModifierServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested campaign bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier GetCampaignBidModifier(global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignBidModifier(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier GetCampaignBidModifier(global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCampaignBidModifier, null, options, request);
      }
      /// <summary>
      /// Returns the requested campaign bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier> GetCampaignBidModifierAsync(global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignBidModifierAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign bid modifier in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Resources.CampaignBidModifier> GetCampaignBidModifierAsync(global::Google.Ads.GoogleAds.V1.Services.GetCampaignBidModifierRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCampaignBidModifier, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes campaign bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignBidModifiers(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes campaign bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignBidModifiers, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes campaign bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignBidModifiersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes campaign bid modifiers.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(global::Google.Ads.GoogleAds.V1.Services.MutateCampaignBidModifiersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignBidModifiers, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CampaignBidModifierServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CampaignBidModifierServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CampaignBidModifierServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCampaignBidModifier, serviceImpl.GetCampaignBidModifier)
          .AddMethod(__Method_MutateCampaignBidModifiers, serviceImpl.MutateCampaignBidModifiers).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CampaignBidModifierServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCampaignBidModifier, serviceImpl.GetCampaignBidModifier);
      serviceBinder.AddMethod(__Method_MutateCampaignBidModifiers, serviceImpl.MutateCampaignBidModifiers);
    }

  }
}
#endregion
