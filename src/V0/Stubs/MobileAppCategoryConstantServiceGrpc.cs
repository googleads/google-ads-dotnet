// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/mobile_app_category_constant_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC.
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
  /// Service to fetch mobile app category constants.
  /// </summary>
  public static partial class MobileAppCategoryConstantService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.MobileAppCategoryConstantService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest> __Marshaller_google_ads_googleads_v0_services_GetMobileAppCategoryConstantRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant> __Marshaller_google_ads_googleads_v0_resources_MobileAppCategoryConstant = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest, global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant> __Method_GetMobileAppCategoryConstant = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest, global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMobileAppCategoryConstant",
        __Marshaller_google_ads_googleads_v0_services_GetMobileAppCategoryConstantRequest,
        __Marshaller_google_ads_googleads_v0_resources_MobileAppCategoryConstant);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.MobileAppCategoryConstantServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MobileAppCategoryConstantService</summary>
    public abstract partial class MobileAppCategoryConstantServiceBase
    {
      /// <summary>
      /// Returns the requested mobile app category constant.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant> GetMobileAppCategoryConstant(global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MobileAppCategoryConstantService</summary>
    public partial class MobileAppCategoryConstantServiceClient : grpc::ClientBase<MobileAppCategoryConstantServiceClient>
    {
      /// <summary>Creates a new client for MobileAppCategoryConstantService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MobileAppCategoryConstantServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MobileAppCategoryConstantService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MobileAppCategoryConstantServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MobileAppCategoryConstantServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MobileAppCategoryConstantServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested mobile app category constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant GetMobileAppCategoryConstant(global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMobileAppCategoryConstant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested mobile app category constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant GetMobileAppCategoryConstant(global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMobileAppCategoryConstant, null, options, request);
      }
      /// <summary>
      /// Returns the requested mobile app category constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMobileAppCategoryConstantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested mobile app category constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.MobileAppCategoryConstant> GetMobileAppCategoryConstantAsync(global::Google.Ads.GoogleAds.V0.Services.GetMobileAppCategoryConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMobileAppCategoryConstant, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MobileAppCategoryConstantServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MobileAppCategoryConstantServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MobileAppCategoryConstantServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetMobileAppCategoryConstant, serviceImpl.GetMobileAppCategoryConstant).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MobileAppCategoryConstantServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetMobileAppCategoryConstant, serviceImpl.GetMobileAppCategoryConstant);
    }

  }
}
#endregion
