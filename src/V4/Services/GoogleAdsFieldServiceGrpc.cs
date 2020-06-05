// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/google_ads_field_service.proto
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
  /// Service to fetch Google Ads API fields.
  /// </summary>
  public static partial class GoogleAdsFieldService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.GoogleAdsFieldService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest> __Marshaller_google_ads_googleads_v4_services_GetGoogleAdsFieldRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField> __Marshaller_google_ads_googleads_v4_resources_GoogleAdsField = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest> __Marshaller_google_ads_googleads_v4_services_SearchGoogleAdsFieldsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse> __Marshaller_google_ads_googleads_v4_services_SearchGoogleAdsFieldsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest, global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField> __Method_GetGoogleAdsField = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest, global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetGoogleAdsField",
        __Marshaller_google_ads_googleads_v4_services_GetGoogleAdsFieldRequest,
        __Marshaller_google_ads_googleads_v4_resources_GoogleAdsField);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest, global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse> __Method_SearchGoogleAdsFields = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest, global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SearchGoogleAdsFields",
        __Marshaller_google_ads_googleads_v4_services_SearchGoogleAdsFieldsRequest,
        __Marshaller_google_ads_googleads_v4_services_SearchGoogleAdsFieldsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.GoogleAdsFieldServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of GoogleAdsFieldService</summary>
    [grpc::BindServiceMethod(typeof(GoogleAdsFieldService), "BindService")]
    public abstract partial class GoogleAdsFieldServiceBase
    {
      /// <summary>
      /// Returns just the requested field.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField> GetGoogleAdsField(global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns all fields that match the search query.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse> SearchGoogleAdsFields(global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for GoogleAdsFieldService</summary>
    public partial class GoogleAdsFieldServiceClient : grpc::ClientBase<GoogleAdsFieldServiceClient>
    {
      /// <summary>Creates a new client for GoogleAdsFieldService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GoogleAdsFieldServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for GoogleAdsFieldService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GoogleAdsFieldServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GoogleAdsFieldServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GoogleAdsFieldServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns just the requested field.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField GetGoogleAdsField(global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGoogleAdsField(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns just the requested field.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField GetGoogleAdsField(global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGoogleAdsField, null, options, request);
      }
      /// <summary>
      /// Returns just the requested field.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField> GetGoogleAdsFieldAsync(global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetGoogleAdsFieldAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns just the requested field.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField> GetGoogleAdsFieldAsync(global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGoogleAdsField, null, options, request);
      }
      /// <summary>
      /// Returns all fields that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse SearchGoogleAdsFields(global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchGoogleAdsFields(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all fields that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse SearchGoogleAdsFields(global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SearchGoogleAdsFields, null, options, request);
      }
      /// <summary>
      /// Returns all fields that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse> SearchGoogleAdsFieldsAsync(global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchGoogleAdsFieldsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns all fields that match the search query.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse> SearchGoogleAdsFieldsAsync(global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SearchGoogleAdsFields, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GoogleAdsFieldServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GoogleAdsFieldServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GoogleAdsFieldServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGoogleAdsField, serviceImpl.GetGoogleAdsField)
          .AddMethod(__Method_SearchGoogleAdsFields, serviceImpl.SearchGoogleAdsFields).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GoogleAdsFieldServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetGoogleAdsField, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetGoogleAdsFieldRequest, global::Google.Ads.GoogleAds.V4.Resources.GoogleAdsField>(serviceImpl.GetGoogleAdsField));
      serviceBinder.AddMethod(__Method_SearchGoogleAdsFields, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsRequest, global::Google.Ads.GoogleAds.V4.Services.SearchGoogleAdsFieldsResponse>(serviceImpl.SearchGoogleAdsFields));
    }

  }
}
#endregion
