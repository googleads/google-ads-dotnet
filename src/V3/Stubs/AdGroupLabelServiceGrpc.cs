// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_label_service.proto
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
  /// Service to manage labels on ad groups.
  /// </summary>
  public static partial class AdGroupLabelService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.AdGroupLabelService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest> __Marshaller_google_ads_googleads_v3_services_GetAdGroupLabelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel> __Marshaller_google_ads_googleads_v3_resources_AdGroupLabel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupLabelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupLabelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel> __Method_GetAdGroupLabel = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupLabel",
        __Marshaller_google_ads_googleads_v3_services_GetAdGroupLabelRequest,
        __Marshaller_google_ads_googleads_v3_resources_AdGroupLabel);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse> __Method_MutateAdGroupLabels = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupLabels",
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupLabelsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupLabelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupLabelService</summary>
    public abstract partial class AdGroupLabelServiceBase
    {
      /// <summary>
      /// Returns the requested ad group label in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel> GetAdGroupLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and removes ad group labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse> MutateAdGroupLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupLabelService</summary>
    public partial class AdGroupLabelServiceClient : grpc::ClientBase<AdGroupLabelServiceClient>
    {
      /// <summary>Creates a new client for AdGroupLabelService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupLabelServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupLabelService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupLabelServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupLabelServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupLabelServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel GetAdGroupLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupLabel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel GetAdGroupLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupLabel, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel> GetAdGroupLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupLabelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel> GetAdGroupLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupLabel, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse MutateAdGroupLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupLabels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse MutateAdGroupLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupLabels, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupLabelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupLabels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupLabelServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupLabelServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupLabelServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupLabel, serviceImpl.GetAdGroupLabel)
          .AddMethod(__Method_MutateAdGroupLabels, serviceImpl.MutateAdGroupLabels).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupLabelServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupLabel, serviceImpl.GetAdGroupLabel);
      serviceBinder.AddMethod(__Method_MutateAdGroupLabels, serviceImpl.MutateAdGroupLabels);
    }

  }
}
#endregion
