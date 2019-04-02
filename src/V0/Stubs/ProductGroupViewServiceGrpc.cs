// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/product_group_view_service.proto
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

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to manage product group views.
  /// </summary>
  public static partial class ProductGroupViewService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.ProductGroupViewService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest> __Marshaller_google_ads_googleads_v0_services_GetProductGroupViewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView> __Marshaller_google_ads_googleads_v0_resources_ProductGroupView = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest, global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView> __Method_GetProductGroupView = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest, global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductGroupView",
        __Marshaller_google_ads_googleads_v0_services_GetProductGroupViewRequest,
        __Marshaller_google_ads_googleads_v0_resources_ProductGroupView);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.ProductGroupViewServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductGroupViewService</summary>
    public abstract partial class ProductGroupViewServiceBase
    {
      /// <summary>
      /// Returns the requested product group view in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView> GetProductGroupView(global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ProductGroupViewService</summary>
    public partial class ProductGroupViewServiceClient : grpc::ClientBase<ProductGroupViewServiceClient>
    {
      /// <summary>Creates a new client for ProductGroupViewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ProductGroupViewServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductGroupViewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ProductGroupViewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ProductGroupViewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ProductGroupViewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested product group view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView GetProductGroupView(global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductGroupView(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested product group view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView GetProductGroupView(global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductGroupView, null, options, request);
      }
      /// <summary>
      /// Returns the requested product group view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView> GetProductGroupViewAsync(global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductGroupViewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested product group view in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.ProductGroupView> GetProductGroupViewAsync(global::Google.Ads.GoogleAds.V0.Services.GetProductGroupViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductGroupView, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ProductGroupViewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductGroupViewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProductGroupViewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProductGroupView, serviceImpl.GetProductGroupView).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductGroupViewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProductGroupView, serviceImpl.GetProductGroupView);
    }

  }
}
#endregion
