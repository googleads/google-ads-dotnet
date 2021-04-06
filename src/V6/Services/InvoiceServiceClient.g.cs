// Copyright 2021 Google LLC
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

using gagve = Google.Ads.GoogleAds.V6.Enums;
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
    /// <summary>Settings for <see cref="InvoiceServiceClient"/> instances.</summary>
    public sealed partial class InvoiceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="InvoiceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="InvoiceServiceSettings"/>.</returns>
        public static InvoiceServiceSettings GetDefault() => new InvoiceServiceSettings();

        /// <summary>Constructs a new <see cref="InvoiceServiceSettings"/> object with default settings.</summary>
        public InvoiceServiceSettings()
        {
        }

        private InvoiceServiceSettings(InvoiceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInvoicesSettings = existing.ListInvoicesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InvoiceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InvoiceServiceClient.ListInvoices</c> and <c>InvoiceServiceClient.ListInvoicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInvoicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="InvoiceServiceSettings"/> object.</returns>
        public InvoiceServiceSettings Clone() => new InvoiceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InvoiceServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class InvoiceServiceClientBuilder : gaxgrpc::ClientBuilderBase<InvoiceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public InvoiceServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref InvoiceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<InvoiceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override InvoiceServiceClient Build()
        {
            InvoiceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<InvoiceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<InvoiceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private InvoiceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InvoiceServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<InvoiceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InvoiceServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => InvoiceServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => InvoiceServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => InvoiceServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>InvoiceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service to fetch invoices issued for a billing setup during a given month.
    /// </remarks>
    public abstract partial class InvoiceServiceClient
    {
        /// <summary>
        /// The default endpoint for the InvoiceService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default InvoiceService scopes.</summary>
        /// <remarks>
        /// The default InvoiceService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="InvoiceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InvoiceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="InvoiceServiceClient"/>.</returns>
        public static stt::Task<InvoiceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new InvoiceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="InvoiceServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="InvoiceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="InvoiceServiceClient"/>.</returns>
        public static InvoiceServiceClient Create() => new InvoiceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="InvoiceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="InvoiceServiceSettings"/>.</param>
        /// <returns>The created <see cref="InvoiceServiceClient"/>.</returns>
        internal static InvoiceServiceClient Create(grpccore::CallInvoker callInvoker, InvoiceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InvoiceService.InvoiceServiceClient grpcClient = new InvoiceService.InvoiceServiceClient(callInvoker);
            return new InvoiceServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC InvoiceService client</summary>
        public virtual InvoiceService.InvoiceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInvoicesResponse ListInvoices(ListInvoicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest request, st::CancellationToken cancellationToken) =>
            ListInvoicesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInvoicesResponse ListInvoices(string customerId, string billingSetup, string issueYear, gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth, gaxgrpc::CallSettings callSettings = null) =>
            ListInvoices(new ListInvoicesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BillingSetup = gax::GaxPreconditions.CheckNotNullOrEmpty(billingSetup, nameof(billingSetup)),
                IssueYear = gax::GaxPreconditions.CheckNotNullOrEmpty(issueYear, nameof(issueYear)),
                IssueMonth = issueMonth,
            }, callSettings);

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(string customerId, string billingSetup, string issueYear, gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth, gaxgrpc::CallSettings callSettings = null) =>
            ListInvoicesAsync(new ListInvoicesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BillingSetup = gax::GaxPreconditions.CheckNotNullOrEmpty(billingSetup, nameof(billingSetup)),
                IssueYear = gax::GaxPreconditions.CheckNotNullOrEmpty(issueYear, nameof(issueYear)),
                IssueMonth = issueMonth,
            }, callSettings);

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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInvoicesResponse> ListInvoicesAsync(string customerId, string billingSetup, string issueYear, gagve::MonthOfYearEnum.Types.MonthOfYear issueMonth, st::CancellationToken cancellationToken) =>
            ListInvoicesAsync(customerId, billingSetup, issueYear, issueMonth, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>InvoiceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service to fetch invoices issued for a billing setup during a given month.
    /// </remarks>
    public sealed partial class InvoiceServiceClientImpl : InvoiceServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListInvoicesRequest, ListInvoicesResponse> _callListInvoices;

        /// <summary>
        /// Constructs a client wrapper for the InvoiceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InvoiceServiceSettings"/> used within this client.</param>
        public InvoiceServiceClientImpl(InvoiceService.InvoiceServiceClient grpcClient, InvoiceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            InvoiceServiceSettings effectiveSettings = settings ?? InvoiceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListInvoices = clientHelper.BuildApiCall<ListInvoicesRequest, ListInvoicesResponse>(grpcClient.ListInvoicesAsync, grpcClient.ListInvoices, effectiveSettings.ListInvoicesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callListInvoices);
            Modify_ListInvoicesApiCall(ref _callListInvoices);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListInvoicesApiCall(ref gaxgrpc::ApiCall<ListInvoicesRequest, ListInvoicesResponse> call);

        partial void OnConstruction(InvoiceService.InvoiceServiceClient grpcClient, InvoiceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC InvoiceService client</summary>
        public override InvoiceService.InvoiceServiceClient GrpcClient { get; }

        partial void Modify_ListInvoicesRequest(ref ListInvoicesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListInvoicesResponse ListInvoices(ListInvoicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInvoicesRequest(ref request, ref callSettings);
            return _callListInvoices.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all invoices associated with a billing setup, for a given month.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListInvoicesResponse> ListInvoicesAsync(ListInvoicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInvoicesRequest(ref request, ref callSettings);
            return _callListInvoices.Async(request, callSettings);
        }
    }
}
