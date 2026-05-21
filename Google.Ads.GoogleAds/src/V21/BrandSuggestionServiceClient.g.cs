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
    /// <summary>Settings for <see cref="BrandSuggestionServiceClient"/> instances.</summary>
    public sealed partial class BrandSuggestionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BrandSuggestionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BrandSuggestionServiceSettings"/>.</returns>
        public static BrandSuggestionServiceSettings GetDefault() => new BrandSuggestionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BrandSuggestionServiceSettings"/> object with default settings.
        /// </summary>
        public BrandSuggestionServiceSettings()
        {
        }

        private BrandSuggestionServiceSettings(BrandSuggestionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SuggestBrandsSettings = existing.SuggestBrandsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BrandSuggestionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BrandSuggestionServiceClient.SuggestBrands</c> and <c>BrandSuggestionServiceClient.SuggestBrandsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings SuggestBrandsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BrandSuggestionServiceSettings"/> object.</returns>
        public BrandSuggestionServiceSettings Clone() => new BrandSuggestionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BrandSuggestionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class BrandSuggestionServiceClientBuilder : gaxgrpc::ClientBuilderBase<BrandSuggestionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BrandSuggestionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BrandSuggestionServiceClientBuilder() : base(BrandSuggestionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BrandSuggestionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BrandSuggestionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BrandSuggestionServiceClient Build()
        {
            BrandSuggestionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BrandSuggestionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BrandSuggestionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BrandSuggestionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BrandSuggestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BrandSuggestionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BrandSuggestionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BrandSuggestionServiceClient.ChannelPool;
    }

    /// <summary>BrandSuggestionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service will suggest brands based on a prefix.
    /// </remarks>
    public abstract partial class BrandSuggestionServiceClient
    {
        /// <summary>
        /// The default endpoint for the BrandSuggestionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BrandSuggestionService scopes.</summary>
        /// <remarks>
        /// The default BrandSuggestionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BrandSuggestionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BrandSuggestionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BrandSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BrandSuggestionServiceClient"/>.</returns>
        public static stt::Task<BrandSuggestionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BrandSuggestionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BrandSuggestionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BrandSuggestionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BrandSuggestionServiceClient"/>.</returns>
        public static BrandSuggestionServiceClient Create() => new BrandSuggestionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BrandSuggestionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BrandSuggestionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BrandSuggestionServiceClient"/>.</returns>
        internal static BrandSuggestionServiceClient Create(grpccore::CallInvoker callInvoker, BrandSuggestionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BrandSuggestionService.BrandSuggestionServiceClient grpcClient = new BrandSuggestionService.BrandSuggestionServiceClient(callInvoker);
            return new BrandSuggestionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BrandSuggestionService client</summary>
        public virtual BrandSuggestionService.BrandSuggestionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestBrandsResponse SuggestBrands(SuggestBrandsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestBrandsResponse> SuggestBrandsAsync(SuggestBrandsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestBrandsResponse> SuggestBrandsAsync(SuggestBrandsRequest request, st::CancellationToken cancellationToken) =>
            SuggestBrandsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer onto which to apply the brand suggestion
        /// operation.
        /// </param>
        /// <param name="brandPrefix">
        /// Required. The prefix of a brand name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestBrandsResponse SuggestBrands(string customerId, string brandPrefix, gaxgrpc::CallSettings callSettings = null) =>
            SuggestBrands(new SuggestBrandsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BrandPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(brandPrefix, nameof(brandPrefix)),
            }, callSettings);

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer onto which to apply the brand suggestion
        /// operation.
        /// </param>
        /// <param name="brandPrefix">
        /// Required. The prefix of a brand name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestBrandsResponse> SuggestBrandsAsync(string customerId, string brandPrefix, gaxgrpc::CallSettings callSettings = null) =>
            SuggestBrandsAsync(new SuggestBrandsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BrandPrefix = gax::GaxPreconditions.CheckNotNullOrEmpty(brandPrefix, nameof(brandPrefix)),
            }, callSettings);

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer onto which to apply the brand suggestion
        /// operation.
        /// </param>
        /// <param name="brandPrefix">
        /// Required. The prefix of a brand name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestBrandsResponse> SuggestBrandsAsync(string customerId, string brandPrefix, st::CancellationToken cancellationToken) =>
            SuggestBrandsAsync(customerId, brandPrefix, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BrandSuggestionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service will suggest brands based on a prefix.
    /// </remarks>
    public sealed partial class BrandSuggestionServiceClientImpl : BrandSuggestionServiceClient
    {
        private readonly gaxgrpc::ApiCall<SuggestBrandsRequest, SuggestBrandsResponse> _callSuggestBrands;

        /// <summary>
        /// Constructs a client wrapper for the BrandSuggestionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BrandSuggestionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BrandSuggestionServiceClientImpl(BrandSuggestionService.BrandSuggestionServiceClient grpcClient, BrandSuggestionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BrandSuggestionServiceSettings effectiveSettings = settings ?? BrandSuggestionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSuggestBrands = clientHelper.BuildApiCall<SuggestBrandsRequest, SuggestBrandsResponse>("SuggestBrands", grpcClient.SuggestBrandsAsync, grpcClient.SuggestBrands, effectiveSettings.SuggestBrandsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSuggestBrands);
            Modify_SuggestBrandsApiCall(ref _callSuggestBrands);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SuggestBrandsApiCall(ref gaxgrpc::ApiCall<SuggestBrandsRequest, SuggestBrandsResponse> call);

        partial void OnConstruction(BrandSuggestionService.BrandSuggestionServiceClient grpcClient, BrandSuggestionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BrandSuggestionService client</summary>
        public override BrandSuggestionService.BrandSuggestionServiceClient GrpcClient { get; }

        partial void Modify_SuggestBrandsRequest(ref SuggestBrandsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestBrandsResponse SuggestBrands(SuggestBrandsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestBrandsRequest(ref request, ref callSettings);
            return _callSuggestBrands.Sync(request, callSettings);
        }

        /// <summary>
        /// Rpc to return a list of matching brands based on a prefix for this
        /// customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestBrandsResponse> SuggestBrandsAsync(SuggestBrandsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestBrandsRequest(ref request, ref callSettings);
            return _callSuggestBrands.Async(request, callSettings);
        }
    }
}
