// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/language_constant_service.proto
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
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {
  /// <summary>
  /// Service to fetch language constants.
  /// </summary>
  public static partial class LanguageConstantService
  {
    static readonly string __ServiceName = "google.ads.googleads.v0.services.LanguageConstantService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest> __Marshaller_GetLanguageConstantRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant> __Marshaller_LanguageConstant = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest, global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant> __Method_GetLanguageConstant = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest, global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetLanguageConstant",
        __Marshaller_GetLanguageConstantRequest,
        __Marshaller_LanguageConstant);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V0.Services.LanguageConstantServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LanguageConstantService</summary>
    public abstract partial class LanguageConstantServiceBase
    {
      /// <summary>
      /// Returns the requested language constant.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant> GetLanguageConstant(global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LanguageConstantService</summary>
    public partial class LanguageConstantServiceClient : grpc::ClientBase<LanguageConstantServiceClient>
    {
      /// <summary>Creates a new client for LanguageConstantService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LanguageConstantServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LanguageConstantService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LanguageConstantServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LanguageConstantServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LanguageConstantServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested language constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant GetLanguageConstant(global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLanguageConstant(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested language constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant GetLanguageConstant(global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetLanguageConstant, null, options, request);
      }
      /// <summary>
      /// Returns the requested language constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant> GetLanguageConstantAsync(global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetLanguageConstantAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested language constant.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.LanguageConstant> GetLanguageConstantAsync(global::Google.Ads.GoogleAds.V0.Services.GetLanguageConstantRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetLanguageConstant, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LanguageConstantServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LanguageConstantServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LanguageConstantServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetLanguageConstant, serviceImpl.GetLanguageConstant).Build();
    }

  }
}
#endregion
