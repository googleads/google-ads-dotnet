// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V6.Services
{
    /// <summary>Settings for <see cref="ReachPlanServiceClient"/> instances.</summary>
    public sealed partial class ReachPlanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReachPlanServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReachPlanServiceSettings"/>.</returns>
        public static ReachPlanServiceSettings GetDefault() => new ReachPlanServiceSettings();

        /// <summary>Constructs a new <see cref="ReachPlanServiceSettings"/> object with default settings.</summary>
        public ReachPlanServiceSettings()
        {
        }

        private ReachPlanServiceSettings(ReachPlanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPlannableLocationsSettings = existing.ListPlannableLocationsSettings;
            ListPlannableProductsSettings = existing.ListPlannableProductsSettings;
            GenerateProductMixIdeasSettings = existing.GenerateProductMixIdeasSettings;
            GenerateReachForecastSettings = existing.GenerateReachForecastSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReachPlanServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableLocations</c> and
        /// <c>ReachPlanServiceClient.ListPlannableLocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPlannableLocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableProducts</c> and <c>ReachPlanServiceClient.ListPlannableProductsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPlannableProductsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateProductMixIdeas</c> and
        /// <c>ReachPlanServiceClient.GenerateProductMixIdeasAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateProductMixIdeasSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateReachForecast</c> and <c>ReachPlanServiceClient.GenerateReachForecastAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateReachForecastSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReachPlanServiceSettings"/> object.</returns>
        public ReachPlanServiceSettings Clone() => new ReachPlanServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReachPlanServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ReachPlanServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReachPlanServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReachPlanServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ReachPlanServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReachPlanServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReachPlanServiceClient Build()
        {
            ReachPlanServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReachPlanServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReachPlanServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReachPlanServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReachPlanServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ReachPlanServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReachPlanServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ReachPlanServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ReachPlanServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReachPlanServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ReachPlanService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Reach Plan Service gives users information about audience size that can
    /// be reached through advertisement on YouTube. In particular,
    /// GenerateReachForecast provides estimated number of people of specified
    /// demographics that can be reached by an ad in a given market by a campaign of
    /// certain duration with a defined budget.
    /// </remarks>
    public abstract partial class ReachPlanServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReachPlanService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ReachPlanService scopes.</summary>
        /// <remarks>The default ReachPlanService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ReachPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReachPlanServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReachPlanServiceClient"/>.</returns>
        public static stt::Task<ReachPlanServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReachPlanServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReachPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReachPlanServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        public static ReachPlanServiceClient Create() => new ReachPlanServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReachPlanServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        internal static ReachPlanServiceClient Create(grpccore::CallInvoker callInvoker, ReachPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReachPlanService.ReachPlanServiceClient grpcClient = new ReachPlanService.ReachPlanServiceClient(callInvoker);
            return new ReachPlanServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ReachPlanService client</summary>
        public virtual ReachPlanService.ReachPlanServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp;amp; DMAs).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableLocationsResponse ListPlannableLocations(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp;amp; DMAs).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp;amp; DMAs).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, st::CancellationToken cancellationToken) =>
            ListPlannableLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableProductsResponse ListPlannableProducts(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, st::CancellationToken cancellationToken) =>
            ListPlannableProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableProductsResponse ListPlannableProducts(string plannableLocationId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableProducts(new ListPlannableProductsRequest
            {
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(string plannableLocationId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableProductsAsync(new ListPlannableProductsRequest
            {
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the available
        /// plannable location ids use ListPlannableLocations.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(string plannableLocationId, st::CancellationToken cancellationToken) =>
            ListPlannableProductsAsync(plannableLocationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateProductMixIdeasResponse GenerateProductMixIdeas(GenerateProductMixIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(GenerateProductMixIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(GenerateProductMixIdeasRequest request, st::CancellationToken cancellationToken) =>
            GenerateProductMixIdeasAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="plannableLocationId">
        /// Required. The ID of the location, this is one of the ids returned by
        /// ListPlannableLocations.
        /// </param>
        /// <param name="currencyCode">
        /// Required. Currency code.
        /// Three-character ISO 4217 currency code.
        /// </param>
        /// <param name="budgetMicros">
        /// Required. Total budget.
        /// Amount in micros. One million is equivalent to one unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateProductMixIdeasResponse GenerateProductMixIdeas(string customerId, string plannableLocationId, string currencyCode, long budgetMicros, gaxgrpc::CallSettings callSettings = null) =>
            GenerateProductMixIdeas(new GenerateProductMixIdeasRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
                CurrencyCode = gax::GaxPreconditions.CheckNotNullOrEmpty(currencyCode, nameof(currencyCode)),
                BudgetMicros = budgetMicros,
            }, callSettings);

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="plannableLocationId">
        /// Required. The ID of the location, this is one of the ids returned by
        /// ListPlannableLocations.
        /// </param>
        /// <param name="currencyCode">
        /// Required. Currency code.
        /// Three-character ISO 4217 currency code.
        /// </param>
        /// <param name="budgetMicros">
        /// Required. Total budget.
        /// Amount in micros. One million is equivalent to one unit.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(string customerId, string plannableLocationId, string currencyCode, long budgetMicros, gaxgrpc::CallSettings callSettings = null) =>
            GenerateProductMixIdeasAsync(new GenerateProductMixIdeasRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
                CurrencyCode = gax::GaxPreconditions.CheckNotNullOrEmpty(currencyCode, nameof(currencyCode)),
                BudgetMicros = budgetMicros,
            }, callSettings);

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="plannableLocationId">
        /// Required. The ID of the location, this is one of the ids returned by
        /// ListPlannableLocations.
        /// </param>
        /// <param name="currencyCode">
        /// Required. Currency code.
        /// Three-character ISO 4217 currency code.
        /// </param>
        /// <param name="budgetMicros">
        /// Required. Total budget.
        /// Amount in micros. One million is equivalent to one unit.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(string customerId, string plannableLocationId, string currencyCode, long budgetMicros, st::CancellationToken cancellationToken) =>
            GenerateProductMixIdeasAsync(customerId, plannableLocationId, currencyCode, budgetMicros, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateReachForecastResponse GenerateReachForecast(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, st::CancellationToken cancellationToken) =>
            GenerateReachForecastAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateReachForecastResponse GenerateReachForecast(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, gaxgrpc::CallSettings callSettings = null) =>
            GenerateReachForecast(new GenerateReachForecastRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignDuration = gax::GaxPreconditions.CheckNotNull(campaignDuration, nameof(campaignDuration)),
                PlannedProducts =
                {
                    gax::GaxPreconditions.CheckNotNull(plannedProducts, nameof(plannedProducts)),
                },
            }, callSettings);

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, gaxgrpc::CallSettings callSettings = null) =>
            GenerateReachForecastAsync(new GenerateReachForecastRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignDuration = gax::GaxPreconditions.CheckNotNull(campaignDuration, nameof(campaignDuration)),
                PlannedProducts =
                {
                    gax::GaxPreconditions.CheckNotNull(plannedProducts, nameof(plannedProducts)),
                },
            }, callSettings);

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, st::CancellationToken cancellationToken) =>
            GenerateReachForecastAsync(customerId, campaignDuration, plannedProducts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReachPlanService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Reach Plan Service gives users information about audience size that can
    /// be reached through advertisement on YouTube. In particular,
    /// GenerateReachForecast provides estimated number of people of specified
    /// demographics that can be reached by an ad in a given market by a campaign of
    /// certain duration with a defined budget.
    /// </remarks>
    public sealed partial class ReachPlanServiceClientImpl : ReachPlanServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> _callListPlannableLocations;

        private readonly gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> _callListPlannableProducts;

        private readonly gaxgrpc::ApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse> _callGenerateProductMixIdeas;

        private readonly gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> _callGenerateReachForecast;

        /// <summary>
        /// Constructs a client wrapper for the ReachPlanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReachPlanServiceSettings"/> used within this client.</param>
        public ReachPlanServiceClientImpl(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ReachPlanServiceSettings effectiveSettings = settings ?? ReachPlanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListPlannableLocations = clientHelper.BuildApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse>(grpcClient.ListPlannableLocationsAsync, grpcClient.ListPlannableLocations, effectiveSettings.ListPlannableLocationsSettings);
            Modify_ApiCall(ref _callListPlannableLocations);
            Modify_ListPlannableLocationsApiCall(ref _callListPlannableLocations);
            _callListPlannableProducts = clientHelper.BuildApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse>(grpcClient.ListPlannableProductsAsync, grpcClient.ListPlannableProducts, effectiveSettings.ListPlannableProductsSettings);
            Modify_ApiCall(ref _callListPlannableProducts);
            Modify_ListPlannableProductsApiCall(ref _callListPlannableProducts);
            _callGenerateProductMixIdeas = clientHelper.BuildApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse>(grpcClient.GenerateProductMixIdeasAsync, grpcClient.GenerateProductMixIdeas, effectiveSettings.GenerateProductMixIdeasSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateProductMixIdeas);
            Modify_GenerateProductMixIdeasApiCall(ref _callGenerateProductMixIdeas);
            _callGenerateReachForecast = clientHelper.BuildApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse>(grpcClient.GenerateReachForecastAsync, grpcClient.GenerateReachForecast, effectiveSettings.GenerateReachForecastSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateReachForecast);
            Modify_GenerateReachForecastApiCall(ref _callGenerateReachForecast);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPlannableLocationsApiCall(ref gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> call);

        partial void Modify_ListPlannableProductsApiCall(ref gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> call);

        partial void Modify_GenerateProductMixIdeasApiCall(ref gaxgrpc::ApiCall<GenerateProductMixIdeasRequest, GenerateProductMixIdeasResponse> call);

        partial void Modify_GenerateReachForecastApiCall(ref gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> call);

        partial void OnConstruction(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReachPlanService client</summary>
        public override ReachPlanService.ReachPlanServiceClient GrpcClient { get; }

        partial void Modify_ListPlannableLocationsRequest(ref ListPlannableLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlannableProductsRequest(ref ListPlannableProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateProductMixIdeasRequest(ref GenerateProductMixIdeasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateReachForecastRequest(ref GenerateReachForecastRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp;amp; DMAs).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPlannableLocationsResponse ListPlannableLocations(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries &amp;amp; DMAs).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPlannableProductsResponse ListPlannableProducts(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateProductMixIdeasResponse GenerateProductMixIdeas(GenerateProductMixIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateProductMixIdeasRequest(ref request, ref callSettings);
            return _callGenerateProductMixIdeas.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a product mix ideas given a set of preferences. This method
        /// helps the advertiser to obtain a good mix of ad formats and budget
        /// allocations based on its preferences.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateProductMixIdeasResponse> GenerateProductMixIdeasAsync(GenerateProductMixIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateProductMixIdeasRequest(ref request, ref callSettings);
            return _callGenerateProductMixIdeas.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateReachForecastResponse GenerateReachForecast(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Async(request, callSettings);
        }
    }
}
