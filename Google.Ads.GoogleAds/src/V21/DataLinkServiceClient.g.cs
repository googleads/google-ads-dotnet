// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gagve = Google.Ads.GoogleAds.V21.Enums;
using gagvr = Google.Ads.GoogleAds.V21.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V21.Services
{
    /// <summary>Settings for <see cref="DataLinkServiceClient"/> instances.</summary>
    public sealed partial class DataLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataLinkServiceSettings"/>.</returns>
        public static DataLinkServiceSettings GetDefault() => new DataLinkServiceSettings();

        /// <summary>Constructs a new <see cref="DataLinkServiceSettings"/> object with default settings.</summary>
        public DataLinkServiceSettings()
        {
        }

        private DataLinkServiceSettings(DataLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDataLinkSettings = existing.CreateDataLinkSettings;
            RemoveDataLinkSettings = existing.RemoveDataLinkSettings;
            UpdateDataLinkSettings = existing.UpdateDataLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLinkServiceClient.CreateDataLink</c> and <c>DataLinkServiceClient.CreateDataLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDataLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLinkServiceClient.RemoveDataLink</c> and <c>DataLinkServiceClient.RemoveDataLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RemoveDataLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLinkServiceClient.UpdateDataLink</c> and <c>DataLinkServiceClient.UpdateDataLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDataLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataLinkServiceSettings"/> object.</returns>
        public DataLinkServiceSettings Clone() => new DataLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataLinkServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class DataLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataLinkServiceClientBuilder() : base(DataLinkServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataLinkServiceClient Build()
        {
            DataLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DataLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataLinkServiceClient.ChannelPool;
    }

    /// <summary>DataLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of data links between  a Google
    /// Ads customer and another data entity.
    /// </remarks>
    public abstract partial class DataLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataLinkService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DataLinkService scopes.</summary>
        /// <remarks>
        /// The default DataLinkService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataLinkService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataLinkServiceClient"/>.</returns>
        public static stt::Task<DataLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DataLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataLinkServiceClient"/>.</returns>
        public static DataLinkServiceClient Create() => new DataLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataLinkServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataLinkServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataLinkServiceClient"/>.</returns>
        internal static DataLinkServiceClient Create(grpccore::CallInvoker callInvoker, DataLinkServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataLinkService.DataLinkServiceClient grpcClient = new DataLinkService.DataLinkServiceClient(callInvoker);
            return new DataLinkServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC DataLinkService client</summary>
        public virtual DataLinkService.DataLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateDataLinkResponse CreateDataLink(CreateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateDataLinkResponse> CreateDataLinkAsync(CreateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateDataLinkResponse> CreateDataLinkAsync(CreateDataLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateDataLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLink">
        /// Required. The data link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateDataLinkResponse CreateDataLink(string customerId, gagvr::DataLink dataLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLink(new CreateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLink = gax::GaxPreconditions.CheckNotNull(dataLink, nameof(dataLink)),
            }, callSettings);

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLink">
        /// Required. The data link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateDataLinkResponse> CreateDataLinkAsync(string customerId, gagvr::DataLink dataLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataLinkAsync(new CreateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLink = gax::GaxPreconditions.CheckNotNull(dataLink, nameof(dataLink)),
            }, callSettings);

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLink">
        /// Required. The data link to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateDataLinkResponse> CreateDataLinkAsync(string customerId, gagvr::DataLink dataLink, st::CancellationToken cancellationToken) =>
            CreateDataLinkAsync(customerId, dataLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveDataLinkResponse RemoveDataLink(RemoveDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(RemoveDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(RemoveDataLinkRequest request, st::CancellationToken cancellationToken) =>
            RemoveDataLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveDataLinkResponse RemoveDataLink(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDataLink(new RemoveDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDataLinkAsync(new RemoveDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(string customerId, string resourceName, st::CancellationToken cancellationToken) =>
            RemoveDataLinkAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveDataLinkResponse RemoveDataLink(string customerId, gagvr::DataLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDataLink(new RemoveDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsDataLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(string customerId, gagvr::DataLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveDataLinkAsync(new RemoveDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsDataLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is updated.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(string customerId, gagvr::DataLinkName resourceName, st::CancellationToken cancellationToken) =>
            RemoveDataLinkAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateDataLinkResponse UpdateDataLink(UpdateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(UpdateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(UpdateDataLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateDataLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateDataLinkResponse UpdateDataLink(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataLink(new UpdateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLinkStatus = dataLinkStatus,
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataLinkAsync(new UpdateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLinkStatus = dataLinkStatus,
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, string resourceName, st::CancellationToken cancellationToken) =>
            UpdateDataLinkAsync(customerId, dataLinkStatus, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateDataLinkResponse UpdateDataLink(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, gagvr::DataLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataLink(new UpdateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLinkStatus = dataLinkStatus,
                ResourceNameAsDataLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, gagvr::DataLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataLinkAsync(new UpdateDataLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                DataLinkStatus = dataLinkStatus,
                ResourceNameAsDataLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the data link is created.
        /// </param>
        /// <param name="dataLinkStatus">
        /// Required. The data link status to be updated to.
        /// </param>
        /// <param name="resourceName">
        /// Required. The data link is expected to have a valid resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(string customerId, gagve::DataLinkStatusEnum.Types.DataLinkStatus dataLinkStatus, gagvr::DataLinkName resourceName, st::CancellationToken cancellationToken) =>
            UpdateDataLinkAsync(customerId, dataLinkStatus, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DataLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of data links between  a Google
    /// Ads customer and another data entity.
    /// </remarks>
    public sealed partial class DataLinkServiceClientImpl : DataLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDataLinkRequest, CreateDataLinkResponse> _callCreateDataLink;

        private readonly gaxgrpc::ApiCall<RemoveDataLinkRequest, RemoveDataLinkResponse> _callRemoveDataLink;

        private readonly gaxgrpc::ApiCall<UpdateDataLinkRequest, UpdateDataLinkResponse> _callUpdateDataLink;

        /// <summary>
        /// Constructs a client wrapper for the DataLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataLinkServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataLinkServiceClientImpl(DataLinkService.DataLinkServiceClient grpcClient, DataLinkServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataLinkServiceSettings effectiveSettings = settings ?? DataLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateDataLink = clientHelper.BuildApiCall<CreateDataLinkRequest, CreateDataLinkResponse>("CreateDataLink", grpcClient.CreateDataLinkAsync, grpcClient.CreateDataLink, effectiveSettings.CreateDataLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateDataLink);
            Modify_CreateDataLinkApiCall(ref _callCreateDataLink);
            _callRemoveDataLink = clientHelper.BuildApiCall<RemoveDataLinkRequest, RemoveDataLinkResponse>("RemoveDataLink", grpcClient.RemoveDataLinkAsync, grpcClient.RemoveDataLink, effectiveSettings.RemoveDataLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callRemoveDataLink);
            Modify_RemoveDataLinkApiCall(ref _callRemoveDataLink);
            _callUpdateDataLink = clientHelper.BuildApiCall<UpdateDataLinkRequest, UpdateDataLinkResponse>("UpdateDataLink", grpcClient.UpdateDataLinkAsync, grpcClient.UpdateDataLink, effectiveSettings.UpdateDataLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUpdateDataLink);
            Modify_UpdateDataLinkApiCall(ref _callUpdateDataLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDataLinkApiCall(ref gaxgrpc::ApiCall<CreateDataLinkRequest, CreateDataLinkResponse> call);

        partial void Modify_RemoveDataLinkApiCall(ref gaxgrpc::ApiCall<RemoveDataLinkRequest, RemoveDataLinkResponse> call);

        partial void Modify_UpdateDataLinkApiCall(ref gaxgrpc::ApiCall<UpdateDataLinkRequest, UpdateDataLinkResponse> call);

        partial void OnConstruction(DataLinkService.DataLinkServiceClient grpcClient, DataLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataLinkService client</summary>
        public override DataLinkService.DataLinkServiceClient GrpcClient { get; }

        partial void Modify_CreateDataLinkRequest(ref CreateDataLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveDataLinkRequest(ref RemoveDataLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDataLinkRequest(ref UpdateDataLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateDataLinkResponse CreateDataLink(CreateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataLinkRequest(ref request, ref callSettings);
            return _callCreateDataLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a data link. The requesting Google Ads account name and account ID
        /// will be shared with the third party (such as YouTube creators for video
        /// links) to whom you are creating the link with. Only customers on the
        /// allow-list can create data links.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateDataLinkResponse> CreateDataLinkAsync(CreateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDataLinkRequest(ref request, ref callSettings);
            return _callCreateDataLink.Async(request, callSettings);
        }

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveDataLinkResponse RemoveDataLink(RemoveDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDataLinkRequest(ref request, ref callSettings);
            return _callRemoveDataLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveDataLinkResponse> RemoveDataLinkAsync(RemoveDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveDataLinkRequest(ref request, ref callSettings);
            return _callRemoveDataLink.Async(request, callSettings);
        }

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateDataLinkResponse UpdateDataLink(UpdateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataLinkRequest(ref request, ref callSettings);
            return _callUpdateDataLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a data link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DataLinkError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateDataLinkResponse> UpdateDataLinkAsync(UpdateDataLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDataLinkRequest(ref request, ref callSettings);
            return _callUpdateDataLink.Async(request, callSettings);
        }
    }
}
