// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="LocalServicesLeadServiceClient"/> instances.</summary>
    public sealed partial class LocalServicesLeadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LocalServicesLeadServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LocalServicesLeadServiceSettings"/>.</returns>
        public static LocalServicesLeadServiceSettings GetDefault() => new LocalServicesLeadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LocalServicesLeadServiceSettings"/> object with default settings.
        /// </summary>
        public LocalServicesLeadServiceSettings()
        {
        }

        private LocalServicesLeadServiceSettings(LocalServicesLeadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AppendLeadConversationSettings = existing.AppendLeadConversationSettings;
            ProvideLeadFeedbackSettings = existing.ProvideLeadFeedbackSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LocalServicesLeadServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalServicesLeadServiceClient.AppendLeadConversation</c> and
        /// <c>LocalServicesLeadServiceClient.AppendLeadConversationAsync</c>.
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
        public gaxgrpc::CallSettings AppendLeadConversationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalServicesLeadServiceClient.ProvideLeadFeedback</c> and
        /// <c>LocalServicesLeadServiceClient.ProvideLeadFeedbackAsync</c>.
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
        public gaxgrpc::CallSettings ProvideLeadFeedbackSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LocalServicesLeadServiceSettings"/> object.</returns>
        public LocalServicesLeadServiceSettings Clone() => new LocalServicesLeadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LocalServicesLeadServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class LocalServicesLeadServiceClientBuilder : gaxgrpc::ClientBuilderBase<LocalServicesLeadServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LocalServicesLeadServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LocalServicesLeadServiceClientBuilder() : base(LocalServicesLeadServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LocalServicesLeadServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LocalServicesLeadServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LocalServicesLeadServiceClient Build()
        {
            LocalServicesLeadServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LocalServicesLeadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LocalServicesLeadServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LocalServicesLeadServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LocalServicesLeadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LocalServicesLeadServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LocalServicesLeadServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LocalServicesLeadServiceClient.ChannelPool;
    }

    /// <summary>LocalServicesLeadService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of LocalServicesLead resources.
    /// </remarks>
    public abstract partial class LocalServicesLeadServiceClient
    {
        /// <summary>
        /// The default endpoint for the LocalServicesLeadService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LocalServicesLeadService scopes.</summary>
        /// <remarks>
        /// The default LocalServicesLeadService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LocalServicesLeadService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LocalServicesLeadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalServicesLeadServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LocalServicesLeadServiceClient"/>.</returns>
        public static stt::Task<LocalServicesLeadServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LocalServicesLeadServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LocalServicesLeadServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalServicesLeadServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LocalServicesLeadServiceClient"/>.</returns>
        public static LocalServicesLeadServiceClient Create() => new LocalServicesLeadServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LocalServicesLeadServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LocalServicesLeadServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LocalServicesLeadServiceClient"/>.</returns>
        internal static LocalServicesLeadServiceClient Create(grpccore::CallInvoker callInvoker, LocalServicesLeadServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LocalServicesLeadService.LocalServicesLeadServiceClient grpcClient = new LocalServicesLeadService.LocalServicesLeadServiceClient(callInvoker);
            return new LocalServicesLeadServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LocalServicesLeadService client</summary>
        public virtual LocalServicesLeadService.LocalServicesLeadServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppendLeadConversationResponse AppendLeadConversation(AppendLeadConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendLeadConversationResponse> AppendLeadConversationAsync(AppendLeadConversationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendLeadConversationResponse> AppendLeadConversationAsync(AppendLeadConversationRequest request, st::CancellationToken cancellationToken) =>
            AppendLeadConversationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer which owns the leads onto which the
        /// conversations will be appended.
        /// </param>
        /// <param name="conversations">
        /// Required. Conversations that are being appended.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AppendLeadConversationResponse AppendLeadConversation(string customerId, scg::IEnumerable<Conversation> conversations, gaxgrpc::CallSettings callSettings = null) =>
            AppendLeadConversation(new AppendLeadConversationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversations =
                {
                    gax::GaxPreconditions.CheckNotNull(conversations, nameof(conversations)),
                },
            }, callSettings);

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer which owns the leads onto which the
        /// conversations will be appended.
        /// </param>
        /// <param name="conversations">
        /// Required. Conversations that are being appended.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendLeadConversationResponse> AppendLeadConversationAsync(string customerId, scg::IEnumerable<Conversation> conversations, gaxgrpc::CallSettings callSettings = null) =>
            AppendLeadConversationAsync(new AppendLeadConversationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversations =
                {
                    gax::GaxPreconditions.CheckNotNull(conversations, nameof(conversations)),
                },
            }, callSettings);

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer which owns the leads onto which the
        /// conversations will be appended.
        /// </param>
        /// <param name="conversations">
        /// Required. Conversations that are being appended.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AppendLeadConversationResponse> AppendLeadConversationAsync(string customerId, scg::IEnumerable<Conversation> conversations, st::CancellationToken cancellationToken) =>
            AppendLeadConversationAsync(customerId, conversations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// RPC to provide feedback on Local Services Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProvideLeadFeedbackResponse ProvideLeadFeedback(ProvideLeadFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC to provide feedback on Local Services Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvideLeadFeedbackResponse> ProvideLeadFeedbackAsync(ProvideLeadFeedbackRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// RPC to provide feedback on Local Services Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProvideLeadFeedbackResponse> ProvideLeadFeedbackAsync(ProvideLeadFeedbackRequest request, st::CancellationToken cancellationToken) =>
            ProvideLeadFeedbackAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LocalServicesLeadService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of LocalServicesLead resources.
    /// </remarks>
    public sealed partial class LocalServicesLeadServiceClientImpl : LocalServicesLeadServiceClient
    {
        private readonly gaxgrpc::ApiCall<AppendLeadConversationRequest, AppendLeadConversationResponse> _callAppendLeadConversation;

        private readonly gaxgrpc::ApiCall<ProvideLeadFeedbackRequest, ProvideLeadFeedbackResponse> _callProvideLeadFeedback;

        /// <summary>
        /// Constructs a client wrapper for the LocalServicesLeadService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LocalServicesLeadServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LocalServicesLeadServiceClientImpl(LocalServicesLeadService.LocalServicesLeadServiceClient grpcClient, LocalServicesLeadServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LocalServicesLeadServiceSettings effectiveSettings = settings ?? LocalServicesLeadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callAppendLeadConversation = clientHelper.BuildApiCall<AppendLeadConversationRequest, AppendLeadConversationResponse>("AppendLeadConversation", grpcClient.AppendLeadConversationAsync, grpcClient.AppendLeadConversation, effectiveSettings.AppendLeadConversationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callAppendLeadConversation);
            Modify_AppendLeadConversationApiCall(ref _callAppendLeadConversation);
            _callProvideLeadFeedback = clientHelper.BuildApiCall<ProvideLeadFeedbackRequest, ProvideLeadFeedbackResponse>("ProvideLeadFeedback", grpcClient.ProvideLeadFeedbackAsync, grpcClient.ProvideLeadFeedback, effectiveSettings.ProvideLeadFeedbackSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callProvideLeadFeedback);
            Modify_ProvideLeadFeedbackApiCall(ref _callProvideLeadFeedback);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AppendLeadConversationApiCall(ref gaxgrpc::ApiCall<AppendLeadConversationRequest, AppendLeadConversationResponse> call);

        partial void Modify_ProvideLeadFeedbackApiCall(ref gaxgrpc::ApiCall<ProvideLeadFeedbackRequest, ProvideLeadFeedbackResponse> call);

        partial void OnConstruction(LocalServicesLeadService.LocalServicesLeadServiceClient grpcClient, LocalServicesLeadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LocalServicesLeadService client</summary>
        public override LocalServicesLeadService.LocalServicesLeadServiceClient GrpcClient { get; }

        partial void Modify_AppendLeadConversationRequest(ref AppendLeadConversationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvideLeadFeedbackRequest(ref ProvideLeadFeedbackRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AppendLeadConversationResponse AppendLeadConversation(AppendLeadConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AppendLeadConversationRequest(ref request, ref callSettings);
            return _callAppendLeadConversation.Sync(request, callSettings);
        }

        /// <summary>
        /// RPC to append Local Services Lead Conversation resources to Local Services
        /// Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AppendLeadConversationResponse> AppendLeadConversationAsync(AppendLeadConversationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AppendLeadConversationRequest(ref request, ref callSettings);
            return _callAppendLeadConversation.Async(request, callSettings);
        }

        /// <summary>
        /// RPC to provide feedback on Local Services Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProvideLeadFeedbackResponse ProvideLeadFeedback(ProvideLeadFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvideLeadFeedbackRequest(ref request, ref callSettings);
            return _callProvideLeadFeedback.Sync(request, callSettings);
        }

        /// <summary>
        /// RPC to provide feedback on Local Services Lead resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProvideLeadFeedbackResponse> ProvideLeadFeedbackAsync(ProvideLeadFeedbackRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvideLeadFeedbackRequest(ref request, ref callSettings);
            return _callProvideLeadFeedback.Async(request, callSettings);
        }
    }
}
