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

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="IncentiveServiceClient"/> instances.</summary>
    public sealed partial class IncentiveServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IncentiveServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IncentiveServiceSettings"/>.</returns>
        public static IncentiveServiceSettings GetDefault() => new IncentiveServiceSettings();

        /// <summary>Constructs a new <see cref="IncentiveServiceSettings"/> object with default settings.</summary>
        public IncentiveServiceSettings()
        {
        }

        private IncentiveServiceSettings(IncentiveServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            FetchIncentiveSettings = existing.FetchIncentiveSettings;
            ApplyIncentiveSettings = existing.ApplyIncentiveSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IncentiveServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncentiveServiceClient.FetchIncentive</c> and <c>IncentiveServiceClient.FetchIncentiveAsync</c>.
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
        public gaxgrpc::CallSettings FetchIncentiveSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IncentiveServiceClient.ApplyIncentive</c> and <c>IncentiveServiceClient.ApplyIncentiveAsync</c>.
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
        public gaxgrpc::CallSettings ApplyIncentiveSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IncentiveServiceSettings"/> object.</returns>
        public IncentiveServiceSettings Clone() => new IncentiveServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IncentiveServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class IncentiveServiceClientBuilder : gaxgrpc::ClientBuilderBase<IncentiveServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IncentiveServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IncentiveServiceClientBuilder() : base(IncentiveServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IncentiveServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IncentiveServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IncentiveServiceClient Build()
        {
            IncentiveServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IncentiveServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IncentiveServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IncentiveServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IncentiveServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IncentiveServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IncentiveServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IncentiveServiceClient.ChannelPool;
    }

    /// <summary>IncentiveService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to support incentive related operations.
    /// </remarks>
    public abstract partial class IncentiveServiceClient
    {
        /// <summary>
        /// The default endpoint for the IncentiveService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default IncentiveService scopes.</summary>
        /// <remarks>
        /// The default IncentiveService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IncentiveService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IncentiveServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IncentiveServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IncentiveServiceClient"/>.</returns>
        public static stt::Task<IncentiveServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IncentiveServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IncentiveServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="IncentiveServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IncentiveServiceClient"/>.</returns>
        public static IncentiveServiceClient Create() => new IncentiveServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IncentiveServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IncentiveServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IncentiveServiceClient"/>.</returns>
        internal static IncentiveServiceClient Create(grpccore::CallInvoker callInvoker, IncentiveServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IncentiveService.IncentiveServiceClient grpcClient = new IncentiveService.IncentiveServiceClient(callInvoker);
            return new IncentiveServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IncentiveService client</summary>
        public virtual IncentiveService.IncentiveServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns incentives for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchIncentiveResponse FetchIncentive(FetchIncentiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns incentives for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchIncentiveResponse> FetchIncentiveAsync(FetchIncentiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns incentives for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchIncentiveResponse> FetchIncentiveAsync(FetchIncentiveRequest request, st::CancellationToken cancellationToken) =>
            FetchIncentiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplyIncentiveResponse ApplyIncentive(ApplyIncentiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyIncentiveResponse> ApplyIncentiveAsync(ApplyIncentiveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyIncentiveResponse> ApplyIncentiveAsync(ApplyIncentiveRequest request, st::CancellationToken cancellationToken) =>
            ApplyIncentiveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="countryCode">
        /// Required. User's country code.
        /// Required. This field must be equal to the Google Ads account's billing
        /// country. Incentive eligibility, terms of service, and reward values are
        /// often country-specific. This country code is used to ensure the selected
        /// incentive is applicable to the user.
        /// Possible country codes:
        /// https://developers.google.com/google-ads/api/data/codes-formats#country_codes
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplyIncentiveResponse ApplyIncentive(string countryCode, gaxgrpc::CallSettings callSettings = null) =>
            ApplyIncentive(new ApplyIncentiveRequest
            {
                CountryCode = gax::GaxPreconditions.CheckNotNullOrEmpty(countryCode, nameof(countryCode)),
            }, callSettings);

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="countryCode">
        /// Required. User's country code.
        /// Required. This field must be equal to the Google Ads account's billing
        /// country. Incentive eligibility, terms of service, and reward values are
        /// often country-specific. This country code is used to ensure the selected
        /// incentive is applicable to the user.
        /// Possible country codes:
        /// https://developers.google.com/google-ads/api/data/codes-formats#country_codes
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyIncentiveResponse> ApplyIncentiveAsync(string countryCode, gaxgrpc::CallSettings callSettings = null) =>
            ApplyIncentiveAsync(new ApplyIncentiveRequest
            {
                CountryCode = gax::GaxPreconditions.CheckNotNullOrEmpty(countryCode, nameof(countryCode)),
            }, callSettings);

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="countryCode">
        /// Required. User's country code.
        /// Required. This field must be equal to the Google Ads account's billing
        /// country. Incentive eligibility, terms of service, and reward values are
        /// often country-specific. This country code is used to ensure the selected
        /// incentive is applicable to the user.
        /// Possible country codes:
        /// https://developers.google.com/google-ads/api/data/codes-formats#country_codes
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplyIncentiveResponse> ApplyIncentiveAsync(string countryCode, st::CancellationToken cancellationToken) =>
            ApplyIncentiveAsync(countryCode, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IncentiveService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to support incentive related operations.
    /// </remarks>
    public sealed partial class IncentiveServiceClientImpl : IncentiveServiceClient
    {
        private readonly gaxgrpc::ApiCall<FetchIncentiveRequest, FetchIncentiveResponse> _callFetchIncentive;

        private readonly gaxgrpc::ApiCall<ApplyIncentiveRequest, ApplyIncentiveResponse> _callApplyIncentive;

        /// <summary>
        /// Constructs a client wrapper for the IncentiveService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IncentiveServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IncentiveServiceClientImpl(IncentiveService.IncentiveServiceClient grpcClient, IncentiveServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IncentiveServiceSettings effectiveSettings = settings ?? IncentiveServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callFetchIncentive = clientHelper.BuildApiCall<FetchIncentiveRequest, FetchIncentiveResponse>("FetchIncentive", grpcClient.FetchIncentiveAsync, grpcClient.FetchIncentive, effectiveSettings.FetchIncentiveSettings);
            Modify_ApiCall(ref _callFetchIncentive);
            Modify_FetchIncentiveApiCall(ref _callFetchIncentive);
            _callApplyIncentive = clientHelper.BuildApiCall<ApplyIncentiveRequest, ApplyIncentiveResponse>("ApplyIncentive", grpcClient.ApplyIncentiveAsync, grpcClient.ApplyIncentive, effectiveSettings.ApplyIncentiveSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId).WithGoogleRequestParam("selected_incentive_id", request => gaxgrpc::RoutingHeaderExtractor<ApplyIncentiveRequest>.FormatRoutingHeaderValue(request.SelectedIncentiveId));
            Modify_ApiCall(ref _callApplyIncentive);
            Modify_ApplyIncentiveApiCall(ref _callApplyIncentive);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_FetchIncentiveApiCall(ref gaxgrpc::ApiCall<FetchIncentiveRequest, FetchIncentiveResponse> call);

        partial void Modify_ApplyIncentiveApiCall(ref gaxgrpc::ApiCall<ApplyIncentiveRequest, ApplyIncentiveResponse> call);

        partial void OnConstruction(IncentiveService.IncentiveServiceClient grpcClient, IncentiveServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IncentiveService client</summary>
        public override IncentiveService.IncentiveServiceClient GrpcClient { get; }

        partial void Modify_FetchIncentiveRequest(ref FetchIncentiveRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApplyIncentiveRequest(ref ApplyIncentiveRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns incentives for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchIncentiveResponse FetchIncentive(FetchIncentiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchIncentiveRequest(ref request, ref callSettings);
            return _callFetchIncentive.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns incentives for a given user.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchIncentiveResponse> FetchIncentiveAsync(FetchIncentiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchIncentiveRequest(ref request, ref callSettings);
            return _callFetchIncentive.Async(request, callSettings);
        }

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplyIncentiveResponse ApplyIncentive(ApplyIncentiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyIncentiveRequest(ref request, ref callSettings);
            return _callApplyIncentive.Sync(request, callSettings);
        }

        /// <summary>
        /// Applies the incentive for the ads customer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplyIncentiveResponse> ApplyIncentiveAsync(ApplyIncentiveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApplyIncentiveRequest(ref request, ref callSettings);
            return _callApplyIncentive.Async(request, callSettings);
        }
    }
}
