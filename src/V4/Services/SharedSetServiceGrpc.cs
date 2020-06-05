// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/shared_set_service.proto
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
  /// Service to manage shared sets.
  /// </summary>
  public static partial class SharedSetService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.SharedSetService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest> __Marshaller_google_ads_googleads_v4_services_GetSharedSetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.SharedSet> __Marshaller_google_ads_googleads_v4_resources_SharedSet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.SharedSet.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest> __Marshaller_google_ads_googleads_v4_services_MutateSharedSetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse> __Marshaller_google_ads_googleads_v4_services_MutateSharedSetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.SharedSet> __Method_GetSharedSet = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.SharedSet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetSharedSet",
        __Marshaller_google_ads_googleads_v4_services_GetSharedSetRequest,
        __Marshaller_google_ads_googleads_v4_resources_SharedSet);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse> __Method_MutateSharedSets = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateSharedSets",
        __Marshaller_google_ads_googleads_v4_services_MutateSharedSetsRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateSharedSetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.SharedSetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SharedSetService</summary>
    [grpc::BindServiceMethod(typeof(SharedSetService), "BindService")]
    public abstract partial class SharedSetServiceBase
    {
      /// <summary>
      /// Returns the requested shared set in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.SharedSet> GetSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse> MutateSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SharedSetService</summary>
    public partial class SharedSetServiceClient : grpc::ClientBase<SharedSetServiceClient>
    {
      /// <summary>Creates a new client for SharedSetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SharedSetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SharedSetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SharedSetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SharedSetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SharedSetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.SharedSet GetSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSharedSet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.SharedSet GetSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetSharedSet, null, options, request);
      }
      /// <summary>
      /// Returns the requested shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.SharedSet> GetSharedSetAsync(global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetSharedSetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.SharedSet> GetSharedSetAsync(global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetSharedSet, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse MutateSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateSharedSets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse MutateSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateSharedSets, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse> MutateSharedSetsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateSharedSetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse> MutateSharedSetsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateSharedSets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SharedSetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SharedSetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SharedSetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetSharedSet, serviceImpl.GetSharedSet)
          .AddMethod(__Method_MutateSharedSets, serviceImpl.MutateSharedSets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SharedSetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetSharedSet, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.SharedSet>(serviceImpl.GetSharedSet));
      serviceBinder.AddMethod(__Method_MutateSharedSets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateSharedSetsResponse>(serviceImpl.MutateSharedSets));
    }

  }
}
#endregion
