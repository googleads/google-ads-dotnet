// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/mutate_job_service.proto
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

namespace Google.Ads.GoogleAds.V2.Services {
  /// <summary>
  /// Service to manage mutate jobs.
  /// </summary>
  public static partial class MutateJobService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.MutateJobService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest> __Marshaller_google_ads_googleads_v2_services_CreateMutateJobRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse> __Marshaller_google_ads_googleads_v2_services_CreateMutateJobResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest> __Marshaller_google_ads_googleads_v2_services_GetMutateJobRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.MutateJob> __Marshaller_google_ads_googleads_v2_resources_MutateJob = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.MutateJob.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest> __Marshaller_google_ads_googleads_v2_services_ListMutateJobResultsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse> __Marshaller_google_ads_googleads_v2_services_ListMutateJobResultsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest> __Marshaller_google_ads_googleads_v2_services_RunMutateJobRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.LongRunning.Operation.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest> __Marshaller_google_ads_googleads_v2_services_AddMutateJobOperationsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse> __Marshaller_google_ads_googleads_v2_services_AddMutateJobOperationsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest, global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse> __Method_CreateMutateJob = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest, global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateMutateJob",
        __Marshaller_google_ads_googleads_v2_services_CreateMutateJobRequest,
        __Marshaller_google_ads_googleads_v2_services_CreateMutateJobResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest, global::Google.Ads.GoogleAds.V2.Resources.MutateJob> __Method_GetMutateJob = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest, global::Google.Ads.GoogleAds.V2.Resources.MutateJob>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetMutateJob",
        __Marshaller_google_ads_googleads_v2_services_GetMutateJobRequest,
        __Marshaller_google_ads_googleads_v2_resources_MutateJob);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest, global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse> __Method_ListMutateJobResults = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest, global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListMutateJobResults",
        __Marshaller_google_ads_googleads_v2_services_ListMutateJobResultsRequest,
        __Marshaller_google_ads_googleads_v2_services_ListMutateJobResultsResponse);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest, global::Google.LongRunning.Operation> __Method_RunMutateJob = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RunMutateJob",
        __Marshaller_google_ads_googleads_v2_services_RunMutateJobRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest, global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse> __Method_AddMutateJobOperations = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest, global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddMutateJobOperations",
        __Marshaller_google_ads_googleads_v2_services_AddMutateJobOperationsRequest,
        __Marshaller_google_ads_googleads_v2_services_AddMutateJobOperationsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.MutateJobServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of MutateJobService</summary>
    public abstract partial class MutateJobServiceBase
    {
      /// <summary>
      /// Creates a mutate job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse> CreateMutateJob(global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the mutate job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.MutateJob> GetMutateJob(global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Returns the results of the mutate job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse> ListMutateJobResults(global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Runs the mutate job.
      ///
      /// The Operation.metadata field type is MutateJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListMutateJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> RunMutateJob(global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Add operations to the mutate job.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse> AddMutateJobOperations(global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for MutateJobService</summary>
    public partial class MutateJobServiceClient : grpc::ClientBase<MutateJobServiceClient>
    {
      /// <summary>Creates a new client for MutateJobService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public MutateJobServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for MutateJobService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public MutateJobServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected MutateJobServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected MutateJobServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Creates a mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse CreateMutateJob(global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateMutateJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse CreateMutateJob(global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateMutateJob, null, options, request);
      }
      /// <summary>
      /// Creates a mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse> CreateMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateMutateJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobResponse> CreateMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.CreateMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateMutateJob, null, options, request);
      }
      /// <summary>
      /// Returns the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.MutateJob GetMutateJob(global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMutateJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.MutateJob GetMutateJob(global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetMutateJob, null, options, request);
      }
      /// <summary>
      /// Returns the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.MutateJob> GetMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetMutateJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.MutateJob> GetMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.GetMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetMutateJob, null, options, request);
      }
      /// <summary>
      /// Returns the results of the mutate job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse ListMutateJobResults(global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMutateJobResults(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the results of the mutate job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse ListMutateJobResults(global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListMutateJobResults, null, options, request);
      }
      /// <summary>
      /// Returns the results of the mutate job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse> ListMutateJobResultsAsync(global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListMutateJobResultsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the results of the mutate job. The job must be done.
      /// Supports standard list paging.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsResponse> ListMutateJobResultsAsync(global::Google.Ads.GoogleAds.V2.Services.ListMutateJobResultsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListMutateJobResults, null, options, request);
      }
      /// <summary>
      /// Runs the mutate job.
      ///
      /// The Operation.metadata field type is MutateJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListMutateJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RunMutateJob(global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunMutateJob(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the mutate job.
      ///
      /// The Operation.metadata field type is MutateJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListMutateJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation RunMutateJob(global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RunMutateJob, null, options, request);
      }
      /// <summary>
      /// Runs the mutate job.
      ///
      /// The Operation.metadata field type is MutateJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListMutateJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RunMutateJobAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Runs the mutate job.
      ///
      /// The Operation.metadata field type is MutateJobMetadata. When finished, the
      /// long running operation will not contain errors or a response. Instead, use
      /// ListMutateJobResults to get the results of the job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> RunMutateJobAsync(global::Google.Ads.GoogleAds.V2.Services.RunMutateJobRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RunMutateJob, null, options, request);
      }
      /// <summary>
      /// Add operations to the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse AddMutateJobOperations(global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMutateJobOperations(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add operations to the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse AddMutateJobOperations(global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_AddMutateJobOperations, null, options, request);
      }
      /// <summary>
      /// Add operations to the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddMutateJobOperationsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Add operations to the mutate job.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(global::Google.Ads.GoogleAds.V2.Services.AddMutateJobOperationsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_AddMutateJobOperations, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override MutateJobServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new MutateJobServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(MutateJobServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateMutateJob, serviceImpl.CreateMutateJob)
          .AddMethod(__Method_GetMutateJob, serviceImpl.GetMutateJob)
          .AddMethod(__Method_ListMutateJobResults, serviceImpl.ListMutateJobResults)
          .AddMethod(__Method_RunMutateJob, serviceImpl.RunMutateJob)
          .AddMethod(__Method_AddMutateJobOperations, serviceImpl.AddMutateJobOperations).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, MutateJobServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateMutateJob, serviceImpl.CreateMutateJob);
      serviceBinder.AddMethod(__Method_GetMutateJob, serviceImpl.GetMutateJob);
      serviceBinder.AddMethod(__Method_ListMutateJobResults, serviceImpl.ListMutateJobResults);
      serviceBinder.AddMethod(__Method_RunMutateJob, serviceImpl.RunMutateJob);
      serviceBinder.AddMethod(__Method_AddMutateJobOperations, serviceImpl.AddMutateJobOperations);
    }

  }
}
#endregion
