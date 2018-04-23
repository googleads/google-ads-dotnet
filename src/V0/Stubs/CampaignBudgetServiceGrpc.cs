// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/ads/googleads/v0/services/campaign_budget_service.proto
// Original file comments:
// Copyright 2018 Google Inc.
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

#region Designer generated code

using System;
using System.Threading;
using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>
  /// Service to manage campaign budgets.
  /// </summary>
  public static partial class CampaignBudgetService {
    private static readonly string __ServiceName = "google.ads.googleads.v0.services.CampaignBudgetService";

    private static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest> __Marshaller_GetCampaignBudgetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest.Parser.ParseFrom);
    private static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget> __Marshaller_CampaignBudget = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget.Parser.ParseFrom);
    private static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest> __Marshaller_MutateCampaignBudgetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest.Parser.ParseFrom);
    private static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse> __Marshaller_MutateCampaignBudgetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse.Parser.ParseFrom);

    private static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest, global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget> __Method_GetCampaignBudget = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest, global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCampaignBudget",
        __Marshaller_GetCampaignBudgetRequest,
        __Marshaller_CampaignBudget);

    private static readonly grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse> __Method_MutateCampaignBudgets = new grpc::Method<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest, global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignBudgets",
        __Marshaller_MutateCampaignBudgetsRequest,
        __Marshaller_MutateCampaignBudgetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor {
      get {
        return global::Google.Ads.GoogleAds.V0.Services.CampaignBudgetServiceReflection.Descriptor.Services[0];
      }
    }

    /// <summary>Base class for server-side implementations of CampaignBudgetService</summary>
    public abstract partial class CampaignBudgetServiceBase {

      /// <summary>
      /// Returns the requested Campaign Budget in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget> GetCampaignBudget(global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest request, grpc::ServerCallContext context) {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes campaign budgets. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse> MutateCampaignBudgets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest request, grpc::ServerCallContext context) {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }
    }

    /// <summary>Client for CampaignBudgetService</summary>
    public partial class CampaignBudgetServiceClient : grpc::ClientBase<CampaignBudgetServiceClient> {

      /// <summary>Creates a new client for CampaignBudgetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CampaignBudgetServiceClient(grpc::Channel channel) : base(channel) {
      }

      /// <summary>Creates a new client for CampaignBudgetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CampaignBudgetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker) {
      }

      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CampaignBudgetServiceClient() : base() {
      }

      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CampaignBudgetServiceClient(ClientBaseConfiguration configuration) : base(configuration) {
      }

      /// <summary>
      /// Returns the requested Campaign Budget in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget GetCampaignBudget(global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken)) {
        return GetCampaignBudget(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }

      /// <summary>
      /// Returns the requested Campaign Budget in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget GetCampaignBudget(global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest request, grpc::CallOptions options) {
        return CallInvoker.BlockingUnaryCall(__Method_GetCampaignBudget, null, options, request);
      }

      /// <summary>
      /// Returns the requested Campaign Budget in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget> GetCampaignBudgetAsync(global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken)) {
        return GetCampaignBudgetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }

      /// <summary>
      /// Returns the requested Campaign Budget in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Resources.CampaignBudget> GetCampaignBudgetAsync(global::Google.Ads.GoogleAds.V0.Services.GetCampaignBudgetRequest request, grpc::CallOptions options) {
        return CallInvoker.AsyncUnaryCall(__Method_GetCampaignBudget, null, options, request);
      }

      /// <summary>
      /// Creates, updates, or removes campaign budgets. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse MutateCampaignBudgets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken)) {
        return MutateCampaignBudgets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }

      /// <summary>
      /// Creates, updates, or removes campaign budgets. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse MutateCampaignBudgets(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest request, grpc::CallOptions options) {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignBudgets, null, options, request);
      }

      /// <summary>
      /// Creates, updates, or removes campaign budgets. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken)) {
        return MutateCampaignBudgetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }

      /// <summary>
      /// Creates, updates, or removes campaign budgets. Operation statuses are
      /// returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(global::Google.Ads.GoogleAds.V0.Services.MutateCampaignBudgetsRequest request, grpc::CallOptions options) {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignBudgets, null, options, request);
      }

      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CampaignBudgetServiceClient NewInstance(ClientBaseConfiguration configuration) {
        return new CampaignBudgetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CampaignBudgetServiceBase serviceImpl) {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCampaignBudget, serviceImpl.GetCampaignBudget)
          .AddMethod(__Method_MutateCampaignBudgets, serviceImpl.MutateCampaignBudgets).Build();
    }
  }
}

#endregion Designer generated code