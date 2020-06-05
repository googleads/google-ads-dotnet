// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/ad_parameter_service.proto
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
  /// Service to manage ad parameters.
  /// </summary>
  public static partial class AdParameterService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.AdParameterService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest> __Marshaller_google_ads_googleads_v4_services_GetAdParameterRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.AdParameter> __Marshaller_google_ads_googleads_v4_resources_AdParameter = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.AdParameter.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest> __Marshaller_google_ads_googleads_v4_services_MutateAdParametersRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse> __Marshaller_google_ads_googleads_v4_services_MutateAdParametersResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest, global::Google.Ads.GoogleAds.V4.Resources.AdParameter> __Method_GetAdParameter = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest, global::Google.Ads.GoogleAds.V4.Resources.AdParameter>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdParameter",
        __Marshaller_google_ads_googleads_v4_services_GetAdParameterRequest,
        __Marshaller_google_ads_googleads_v4_resources_AdParameter);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse> __Method_MutateAdParameters = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdParameters",
        __Marshaller_google_ads_googleads_v4_services_MutateAdParametersRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateAdParametersResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.AdParameterServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdParameterService</summary>
    [grpc::BindServiceMethod(typeof(AdParameterService), "BindService")]
    public abstract partial class AdParameterServiceBase
    {
      /// <summary>
      /// Returns the requested ad parameter in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.AdParameter> GetAdParameter(global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ad parameters. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse> MutateAdParameters(global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdParameterService</summary>
    public partial class AdParameterServiceClient : grpc::ClientBase<AdParameterServiceClient>
    {
      /// <summary>Creates a new client for AdParameterService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdParameterServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdParameterService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdParameterServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdParameterServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdParameterServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad parameter in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AdParameter GetAdParameter(global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdParameter(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad parameter in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.AdParameter GetAdParameter(global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdParameter, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad parameter in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AdParameter> GetAdParameterAsync(global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdParameterAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad parameter in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.AdParameter> GetAdParameterAsync(global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdParameter, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad parameters. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse MutateAdParameters(global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdParameters(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad parameters. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse MutateAdParameters(global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdParameters, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad parameters. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse> MutateAdParametersAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdParametersAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad parameters. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse> MutateAdParametersAsync(global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdParameters, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdParameterServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdParameterServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdParameterServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdParameter, serviceImpl.GetAdParameter)
          .AddMethod(__Method_MutateAdParameters, serviceImpl.MutateAdParameters).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdParameterServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdParameter, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetAdParameterRequest, global::Google.Ads.GoogleAds.V4.Resources.AdParameter>(serviceImpl.GetAdParameter));
      serviceBinder.AddMethod(__Method_MutateAdParameters, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersRequest, global::Google.Ads.GoogleAds.V4.Services.MutateAdParametersResponse>(serviceImpl.MutateAdParameters));
    }

  }
}
#endregion
