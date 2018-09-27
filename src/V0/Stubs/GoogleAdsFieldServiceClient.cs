// Copyright 2018 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V0.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Settings for a <see cref="GoogleAdsFieldServiceClient"/>.
    /// </summary>
    public sealed partial class GoogleAdsFieldServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.
        /// </returns>
        public static GoogleAdsFieldServiceSettings GetDefault() => new GoogleAdsFieldServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GoogleAdsFieldServiceSettings"/> object with default settings.
        /// </summary>
        public GoogleAdsFieldServiceSettings() { }

        private GoogleAdsFieldServiceSettings(GoogleAdsFieldServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGoogleAdsFieldSettings = existing.GetGoogleAdsFieldSettings;
            SearchGoogleAdsFieldsSettings = existing.SearchGoogleAdsFieldsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GoogleAdsFieldServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="GoogleAdsFieldServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsField</c> and <c>GoogleAdsFieldServiceClient.GetGoogleAdsFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GoogleAdsFieldServiceClient.GetGoogleAdsField</c> and
        /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsFieldAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetGoogleAdsFieldSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFields</c> and <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFields</c> and
        /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFieldsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings SearchGoogleAdsFieldsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="GoogleAdsFieldServiceSettings"/> object.</returns>
        public GoogleAdsFieldServiceSettings Clone() => new GoogleAdsFieldServiceSettings(this);
    }

    /// <summary>
    /// GoogleAdsFieldService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class GoogleAdsFieldServiceClient
    {
        /// <summary>
        /// The default endpoint for the GoogleAdsFieldService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default GoogleAdsFieldService scopes.
        /// </summary>
        /// <remarks>
        /// The default GoogleAdsFieldService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GoogleAdsFieldServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GoogleAdsFieldServiceClient client = await GoogleAdsFieldServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GoogleAdsFieldServiceClient.DefaultEndpoint.Host, GoogleAdsFieldServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GoogleAdsFieldServiceClient client = GoogleAdsFieldServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static async stt::Task<GoogleAdsFieldServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsFieldServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="GoogleAdsFieldServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// GoogleAdsFieldServiceClient client = GoogleAdsFieldServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     GoogleAdsFieldServiceClient.DefaultEndpoint.Host, GoogleAdsFieldServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// GoogleAdsFieldServiceClient client = GoogleAdsFieldServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static GoogleAdsFieldServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, GoogleAdsFieldServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsFieldServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static GoogleAdsFieldServiceClient Create(grpccore::Channel channel, GoogleAdsFieldServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsFieldServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static GoogleAdsFieldServiceClient Create(grpccore::CallInvoker callInvoker, GoogleAdsFieldServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient = new GoogleAdsFieldService.GoogleAdsFieldServiceClient(callInvoker);
            return new GoogleAdsFieldServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, GoogleAdsFieldServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, GoogleAdsFieldServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC GoogleAdsFieldService client.
        /// </summary>
        public virtual GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGoogleAdsFieldAsync(
                new GetGoogleAdsFieldRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the field to get.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetGoogleAdsFieldAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::GoogleAdsField GetGoogleAdsField(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetGoogleAdsField(
                new GetGoogleAdsFieldRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(
            GetGoogleAdsFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(
            GetGoogleAdsFieldRequest request,
            st::CancellationToken cancellationToken) => GetGoogleAdsFieldAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::GoogleAdsField GetGoogleAdsField(
            GetGoogleAdsFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="query">
        /// The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(
            string query,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchGoogleAdsFieldsAsync(
                new SearchGoogleAdsFieldsRequest
                {
                    Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="query">
        /// The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(
            string query,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => SearchGoogleAdsFields(
                new SearchGoogleAdsFieldsRequest
                {
                    Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(
            SearchGoogleAdsFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(
            SearchGoogleAdsFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// GoogleAdsFieldService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class GoogleAdsFieldServiceClientImpl : GoogleAdsFieldServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField> _callGetGoogleAdsField;
        private readonly gaxgrpc::ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> _callSearchGoogleAdsFields;

        /// <summary>
        /// Constructs a client wrapper for the GoogleAdsFieldService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GoogleAdsFieldServiceSettings"/> used within this client </param>
        public GoogleAdsFieldServiceClientImpl(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GoogleAdsFieldServiceSettings effectiveSettings = settings ?? GoogleAdsFieldServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGoogleAdsField = clientHelper.BuildApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField>(
                GrpcClient.GetGoogleAdsFieldAsync, GrpcClient.GetGoogleAdsField, effectiveSettings.GetGoogleAdsFieldSettings);
            _callSearchGoogleAdsFields = clientHelper.BuildApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse>(
                GrpcClient.SearchGoogleAdsFieldsAsync, GrpcClient.SearchGoogleAdsFields, effectiveSettings.SearchGoogleAdsFieldsSettings);
            Modify_ApiCall(ref _callGetGoogleAdsField);
            Modify_GetGoogleAdsFieldApiCall(ref _callGetGoogleAdsField);
            Modify_ApiCall(ref _callSearchGoogleAdsFields);
            Modify_SearchGoogleAdsFieldsApiCall(ref _callSearchGoogleAdsFields);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetGoogleAdsFieldApiCall(ref gaxgrpc::ApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField> call);
        partial void Modify_SearchGoogleAdsFieldsApiCall(ref gaxgrpc::ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> call);
        partial void OnConstruction(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC GoogleAdsFieldService client.
        /// </summary>
        public override GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetGoogleAdsFieldRequest(ref GetGoogleAdsFieldRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SearchGoogleAdsFieldsRequest(ref SearchGoogleAdsFieldsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(
            GetGoogleAdsFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
            return _callGetGoogleAdsField.Async(request, callSettings);
        }

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::GoogleAdsField GetGoogleAdsField(
            GetGoogleAdsFieldRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
            return _callGetGoogleAdsField.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(
            SearchGoogleAdsFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(
            SearchGoogleAdsFieldsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class SearchGoogleAdsFieldsRequest : gaxgrpc::IPageRequest { }
    public partial class SearchGoogleAdsFieldsResponse : gaxgrpc::IPageResponse<gagvr::GoogleAdsField>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<gagvr::GoogleAdsField> GetEnumerator() => Results.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
