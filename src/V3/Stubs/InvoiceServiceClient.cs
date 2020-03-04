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

using gagve = Google.Ads.GoogleAds.V3.Enums;
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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>
    /// Settings for a <see cref="InvoiceServiceClient"/>.
    /// </summary>
    public sealed partial class InvoiceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="InvoiceServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="InvoiceServiceSettings"/>.
        /// </returns>
        public static InvoiceServiceSettings GetDefault() => new InvoiceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="InvoiceServiceSettings"/> object with default settings.
        /// </summary>
        public InvoiceServiceSettings() { }

        private InvoiceServiceSettings(InvoiceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInvoicesSettings = existing.ListInvoicesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InvoiceServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="InvoiceServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="InvoiceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="InvoiceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="InvoiceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="InvoiceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="InvoiceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="InvoiceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="InvoiceServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InvoiceServiceClient.ListInvoices</c> and <c>InvoiceServiceClient.ListInvoicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InvoiceServiceClient.ListInvoices</c> and
        /// <c>InvoiceServiceClient.ListInvoicesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListInvoicesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="InvoiceServiceSettings"/> object.</returns>
        public InvoiceServiceSettings Clone() => new InvoiceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InvoiceServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class InvoiceServiceClientBuilder : gaxgrpc::ClientBuilderBase<InvoiceServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public InvoiceServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override InvoiceServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InvoiceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<InvoiceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InvoiceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => InvoiceServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => InvoiceServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => InvoiceServiceClient.ChannelPool;
    }

    /// <summary>
    /// InvoiceService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class InvoiceServiceClient
    {
        /// <summary>
        /// The default endpoint for the InvoiceService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default InvoiceService scopes.
        /// </summary>
        /// <remarks>
        /// The default InvoiceService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="InvoiceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// InvoiceServiceClient client = await InvoiceServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     InvoiceServiceClient.DefaultEndpoint.Host, InvoiceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// InvoiceServiceClient client = InvoiceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InvoiceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="InvoiceServiceClient"/>.</returns>
        public static async stt::Task<InvoiceServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, InvoiceServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="InvoiceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// InvoiceServiceClient client = InvoiceServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     InvoiceServiceClient.DefaultEndpoint.Host, InvoiceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// InvoiceServiceClient client = InvoiceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InvoiceServiceSettings"/>.</param>
        /// <returns>The created <see cref="InvoiceServiceClient"/>.</returns>
        public static InvoiceServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, InvoiceServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="InvoiceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="InvoiceServiceSettings"/>.</param>
        /// <returns>The created <see cref="InvoiceServiceClient"/>.</returns>
        public static InvoiceServiceClient Create(grpccore::Channel channel, InvoiceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="InvoiceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="InvoiceServiceSettings"/>.</param>
        /// <returns>The created <see cref="InvoiceServiceClient"/>.</returns>
        public static InvoiceServiceClient Create(grpccore::CallInvoker callInvoker, InvoiceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InvoiceService.InvoiceServiceClient grpcClient = new InvoiceService.InvoiceServiceClient(callInvoker);
            return new InvoiceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, InvoiceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, InvoiceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, InvoiceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, InvoiceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC InvoiceService client.
        /// </summary>
        public virtual InvoiceService.InvoiceServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to fetch invoices for.
        /// </param>
        /// <param name="billingSetup">
        /// Required. The billing setup resource name of the requested invoices.
        ///
        /// `customers/{customer_id}/billingSetups/{billing_setup_id}`
        /// </param>
        /// <param name="issueYear">
        /// Required. The issue year to retrieve invoices, in yyyy format. Only
        /// invoices issued in 2019 or later can be retrieved.
        /// </param>
        /// <param name="issueMonth">
        /// Required. The issue month to retrieve invoices.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(
            string customerId,
            string billingSetup,
            string issueYear,
            gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth,
            gaxgrpc::CallSettings callSettings = null) => ListInvoicesAsync(
                new ListInvoicesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    BillingSetup = gax::GaxPreconditions.CheckNotNullOrEmpty(billingSetup, nameof(billingSetup)),
                    IssueYear = gax::GaxPreconditions.CheckNotNullOrEmpty(issueYear, nameof(issueYear)),
                    IssueMonth = issueMonth,
                },
                callSettings);

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to fetch invoices for.
        /// </param>
        /// <param name="billingSetup">
        /// Required. The billing setup resource name of the requested invoices.
        ///
        /// `customers/{customer_id}/billingSetups/{billing_setup_id}`
        /// </param>
        /// <param name="issueYear">
        /// Required. The issue year to retrieve invoices, in yyyy format. Only
        /// invoices issued in 2019 or later can be retrieved.
        /// </param>
        /// <param name="issueMonth">
        /// Required. The issue month to retrieve invoices.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(
            string customerId,
            string billingSetup,
            string issueYear,
            gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth,
            st::CancellationToken cancellationToken) => ListInvoicesAsync(
                customerId,
                billingSetup,
                issueYear,
                issueMonth,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to fetch invoices for.
        /// </param>
        /// <param name="billingSetup">
        /// Required. The billing setup resource name of the requested invoices.
        ///
        /// `customers/{customer_id}/billingSetups/{billing_setup_id}`
        /// </param>
        /// <param name="issueYear">
        /// Required. The issue year to retrieve invoices, in yyyy format. Only
        /// invoices issued in 2019 or later can be retrieved.
        /// </param>
        /// <param name="issueMonth">
        /// Required. The issue month to retrieve invoices.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ListInvoicesResponse ListInvoices(
            string customerId,
            string billingSetup,
            string issueYear,
            gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth,
            gaxgrpc::CallSettings callSettings = null) => ListInvoices(
                new ListInvoicesRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    BillingSetup = gax::GaxPreconditions.CheckNotNullOrEmpty(billingSetup, nameof(billingSetup)),
                    IssueYear = gax::GaxPreconditions.CheckNotNullOrEmpty(issueYear, nameof(issueYear)),
                    IssueMonth = issueMonth,
                },
                callSettings);

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
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
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(
            ListInvoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
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
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(
            ListInvoicesRequest request,
            st::CancellationToken cancellationToken) => ListInvoicesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
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
        public virtual ListInvoicesResponse ListInvoices(
            ListInvoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// InvoiceService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class InvoiceServiceClientImpl : InvoiceServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListInvoicesRequest, ListInvoicesResponse> _callListInvoices;

        /// <summary>
        /// Constructs a client wrapper for the InvoiceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InvoiceServiceSettings"/> used within this client </param>
        public InvoiceServiceClientImpl(InvoiceService.InvoiceServiceClient grpcClient, InvoiceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            InvoiceServiceSettings effectiveSettings = settings ?? InvoiceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListInvoices = clientHelper.BuildApiCall<ListInvoicesRequest, ListInvoicesResponse>(
                GrpcClient.ListInvoicesAsync, GrpcClient.ListInvoices, effectiveSettings.ListInvoicesSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callListInvoices);
            Modify_ListInvoicesApiCall(ref _callListInvoices);
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
        partial void Modify_ListInvoicesApiCall(ref gaxgrpc::ApiCall<ListInvoicesRequest, ListInvoicesResponse> call);
        partial void OnConstruction(InvoiceService.InvoiceServiceClient grpcClient, InvoiceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC InvoiceService client.
        /// </summary>
        public override InvoiceService.InvoiceServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListInvoicesRequest(ref ListInvoicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
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
        public override stt::Task<ListInvoicesResponse> ListInvoicesAsync(
            ListInvoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInvoicesRequest(ref request, ref callSettings);
            return _callListInvoices.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
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
        public override ListInvoicesResponse ListInvoices(
            ListInvoicesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInvoicesRequest(ref request, ref callSettings);
            return _callListInvoices.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
