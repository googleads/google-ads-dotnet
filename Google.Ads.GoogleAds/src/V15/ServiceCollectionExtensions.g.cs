// Copyright 2023 Google LLC
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
using gagvs = Google.Ads.GoogleAds.V15.Services;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using sys = System;
using scg = System.Collections.Generic;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>Static class to provide extension methods to configure API clients.</summary>
    public static partial class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds a singleton <see cref="gagvs::AccountBudgetProposalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAccountBudgetProposalServiceClient(this IServiceCollection services, sys::Action<gagvs::AccountBudgetProposalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AccountBudgetProposalServiceClientBuilder builder = new gagvs::AccountBudgetProposalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AccountLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAccountLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::AccountLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AccountLinkServiceClientBuilder builder = new gagvs::AccountLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupAdLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupAdLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupAdLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupAdLabelServiceClientBuilder builder = new gagvs::AdGroupAdLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupAdServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupAdServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupAdServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupAdServiceClientBuilder builder = new gagvs::AdGroupAdServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupAssetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupAssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupAssetServiceClientBuilder builder = new gagvs::AdGroupAssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupAssetSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupAssetSetServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupAssetSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupAssetSetServiceClientBuilder builder = new gagvs::AdGroupAssetSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupBidModifierServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupBidModifierServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupBidModifierServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupBidModifierServiceClientBuilder builder = new gagvs::AdGroupBidModifierServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupCriterionCustomizerServiceClient"/> to <paramref name="services"/>
        /// .
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupCriterionCustomizerServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupCriterionCustomizerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupCriterionCustomizerServiceClientBuilder builder = new gagvs::AdGroupCriterionCustomizerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupCriterionLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupCriterionLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupCriterionLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupCriterionLabelServiceClientBuilder builder = new gagvs::AdGroupCriterionLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupCriterionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupCriterionServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupCriterionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupCriterionServiceClientBuilder builder = new gagvs::AdGroupCriterionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupCustomizerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupCustomizerServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupCustomizerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupCustomizerServiceClientBuilder builder = new gagvs::AdGroupCustomizerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupExtensionSettingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupExtensionSettingServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupExtensionSettingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupExtensionSettingServiceClientBuilder builder = new gagvs::AdGroupExtensionSettingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupFeedServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupFeedServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupFeedServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupFeedServiceClientBuilder builder = new gagvs::AdGroupFeedServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupLabelServiceClientBuilder builder = new gagvs::AdGroupLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdGroupServiceClient(this IServiceCollection services, sys::Action<gagvs::AdGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdGroupServiceClientBuilder builder = new gagvs::AdGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AdParameterServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdParameterServiceClient(this IServiceCollection services, sys::Action<gagvs::AdParameterServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdParameterServiceClientBuilder builder = new gagvs::AdParameterServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gagvs::AdServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAdServiceClient(this IServiceCollection services, sys::Action<gagvs::AdServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AdServiceClientBuilder builder = new gagvs::AdServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetGroupAssetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetGroupAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetGroupAssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetGroupAssetServiceClientBuilder builder = new gagvs::AssetGroupAssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetGroupListingGroupFilterServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetGroupListingGroupFilterServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetGroupListingGroupFilterServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetGroupListingGroupFilterServiceClientBuilder builder = new gagvs::AssetGroupListingGroupFilterServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetGroupServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetGroupServiceClientBuilder builder = new gagvs::AssetGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetGroupSignalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetGroupSignalServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetGroupSignalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetGroupSignalServiceClientBuilder builder = new gagvs::AssetGroupSignalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gagvs::AssetServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetServiceClientBuilder builder = new gagvs::AssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetSetAssetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetSetAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetSetAssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetSetAssetServiceClientBuilder builder = new gagvs::AssetSetAssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AssetSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAssetSetServiceClient(this IServiceCollection services, sys::Action<gagvs::AssetSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AssetSetServiceClientBuilder builder = new gagvs::AssetSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AudienceInsightsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAudienceInsightsServiceClient(this IServiceCollection services, sys::Action<gagvs::AudienceInsightsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AudienceInsightsServiceClientBuilder builder = new gagvs::AudienceInsightsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::AudienceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddAudienceServiceClient(this IServiceCollection services, sys::Action<gagvs::AudienceServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::AudienceServiceClientBuilder builder = new gagvs::AudienceServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BatchJobServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBatchJobServiceClient(this IServiceCollection services, sys::Action<gagvs::BatchJobServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BatchJobServiceClientBuilder builder = new gagvs::BatchJobServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BiddingDataExclusionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBiddingDataExclusionServiceClient(this IServiceCollection services, sys::Action<gagvs::BiddingDataExclusionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BiddingDataExclusionServiceClientBuilder builder = new gagvs::BiddingDataExclusionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BiddingSeasonalityAdjustmentServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBiddingSeasonalityAdjustmentServiceClient(this IServiceCollection services, sys::Action<gagvs::BiddingSeasonalityAdjustmentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BiddingSeasonalityAdjustmentServiceClientBuilder builder = new gagvs::BiddingSeasonalityAdjustmentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BiddingStrategyServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBiddingStrategyServiceClient(this IServiceCollection services, sys::Action<gagvs::BiddingStrategyServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BiddingStrategyServiceClientBuilder builder = new gagvs::BiddingStrategyServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BillingSetupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBillingSetupServiceClient(this IServiceCollection services, sys::Action<gagvs::BillingSetupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BillingSetupServiceClientBuilder builder = new gagvs::BillingSetupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::BrandSuggestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddBrandSuggestionServiceClient(this IServiceCollection services, sys::Action<gagvs::BrandSuggestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::BrandSuggestionServiceClientBuilder builder = new gagvs::BrandSuggestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignAssetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignAssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignAssetServiceClientBuilder builder = new gagvs::CampaignAssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignAssetSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignAssetSetServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignAssetSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignAssetSetServiceClientBuilder builder = new gagvs::CampaignAssetSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignBidModifierServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignBidModifierServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignBidModifierServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignBidModifierServiceClientBuilder builder = new gagvs::CampaignBidModifierServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignBudgetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignBudgetServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignBudgetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignBudgetServiceClientBuilder builder = new gagvs::CampaignBudgetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignConversionGoalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignConversionGoalServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignConversionGoalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignConversionGoalServiceClientBuilder builder = new gagvs::CampaignConversionGoalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignCriterionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignCriterionServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignCriterionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignCriterionServiceClientBuilder builder = new gagvs::CampaignCriterionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignCustomizerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignCustomizerServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignCustomizerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignCustomizerServiceClientBuilder builder = new gagvs::CampaignCustomizerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignDraftServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignDraftServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignDraftServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignDraftServiceClientBuilder builder = new gagvs::CampaignDraftServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignExtensionSettingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignExtensionSettingServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignExtensionSettingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignExtensionSettingServiceClientBuilder builder = new gagvs::CampaignExtensionSettingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignFeedServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignFeedServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignFeedServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignFeedServiceClientBuilder builder = new gagvs::CampaignFeedServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignGroupServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignGroupServiceClientBuilder builder = new gagvs::CampaignGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignLabelServiceClientBuilder builder = new gagvs::CampaignLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignLifecycleGoalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignLifecycleGoalServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignLifecycleGoalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignLifecycleGoalServiceClientBuilder builder = new gagvs::CampaignLifecycleGoalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignServiceClientBuilder builder = new gagvs::CampaignServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CampaignSharedSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCampaignSharedSetServiceClient(this IServiceCollection services, sys::Action<gagvs::CampaignSharedSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CampaignSharedSetServiceClientBuilder builder = new gagvs::CampaignSharedSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionActionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionActionServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionActionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionActionServiceClientBuilder builder = new gagvs::ConversionActionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionAdjustmentUploadServiceClient"/> to <paramref name="services"/>
        /// .
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionAdjustmentUploadServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionAdjustmentUploadServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionAdjustmentUploadServiceClientBuilder builder = new gagvs::ConversionAdjustmentUploadServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionCustomVariableServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionCustomVariableServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionCustomVariableServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionCustomVariableServiceClientBuilder builder = new gagvs::ConversionCustomVariableServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionGoalCampaignConfigServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionGoalCampaignConfigServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionGoalCampaignConfigServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionGoalCampaignConfigServiceClientBuilder builder = new gagvs::ConversionGoalCampaignConfigServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionUploadServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionUploadServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionUploadServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionUploadServiceClientBuilder builder = new gagvs::ConversionUploadServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionValueRuleServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionValueRuleServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionValueRuleServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionValueRuleServiceClientBuilder builder = new gagvs::ConversionValueRuleServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ConversionValueRuleSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddConversionValueRuleSetServiceClient(this IServiceCollection services, sys::Action<gagvs::ConversionValueRuleSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ConversionValueRuleSetServiceClientBuilder builder = new gagvs::ConversionValueRuleSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomAudienceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomAudienceServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomAudienceServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomAudienceServiceClientBuilder builder = new gagvs::CustomAudienceServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomConversionGoalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomConversionGoalServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomConversionGoalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomConversionGoalServiceClientBuilder builder = new gagvs::CustomConversionGoalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomInterestServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomInterestServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomInterestServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomInterestServiceClientBuilder builder = new gagvs::CustomInterestServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerAssetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerAssetServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerAssetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerAssetServiceClientBuilder builder = new gagvs::CustomerAssetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerAssetSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerAssetSetServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerAssetSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerAssetSetServiceClientBuilder builder = new gagvs::CustomerAssetSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerClientLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerClientLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerClientLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerClientLinkServiceClientBuilder builder = new gagvs::CustomerClientLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerConversionGoalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerConversionGoalServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerConversionGoalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerConversionGoalServiceClientBuilder builder = new gagvs::CustomerConversionGoalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerCustomizerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerCustomizerServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerCustomizerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerCustomizerServiceClientBuilder builder = new gagvs::CustomerCustomizerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerExtensionSettingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerExtensionSettingServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerExtensionSettingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerExtensionSettingServiceClientBuilder builder = new gagvs::CustomerExtensionSettingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerFeedServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerFeedServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerFeedServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerFeedServiceClientBuilder builder = new gagvs::CustomerFeedServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerLabelServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerLabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerLabelServiceClientBuilder builder = new gagvs::CustomerLabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerLifecycleGoalServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerLifecycleGoalServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerLifecycleGoalServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerLifecycleGoalServiceClientBuilder builder = new gagvs::CustomerLifecycleGoalServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerManagerLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerManagerLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerManagerLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerManagerLinkServiceClientBuilder builder = new gagvs::CustomerManagerLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerNegativeCriterionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerNegativeCriterionServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerNegativeCriterionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerNegativeCriterionServiceClientBuilder builder = new gagvs::CustomerNegativeCriterionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerServiceClientBuilder builder = new gagvs::CustomerServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerSkAdNetworkConversionValueSchemaServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerSkAdNetworkConversionValueSchemaServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder builder = new gagvs::CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerUserAccessInvitationServiceClient"/> to
        /// <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerUserAccessInvitationServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerUserAccessInvitationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerUserAccessInvitationServiceClientBuilder builder = new gagvs::CustomerUserAccessInvitationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomerUserAccessServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomerUserAccessServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomerUserAccessServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomerUserAccessServiceClientBuilder builder = new gagvs::CustomerUserAccessServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::CustomizerAttributeServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddCustomizerAttributeServiceClient(this IServiceCollection services, sys::Action<gagvs::CustomizerAttributeServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::CustomizerAttributeServiceClientBuilder builder = new gagvs::CustomizerAttributeServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ExperimentArmServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddExperimentArmServiceClient(this IServiceCollection services, sys::Action<gagvs::ExperimentArmServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ExperimentArmServiceClientBuilder builder = new gagvs::ExperimentArmServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ExperimentServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddExperimentServiceClient(this IServiceCollection services, sys::Action<gagvs::ExperimentServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ExperimentServiceClientBuilder builder = new gagvs::ExperimentServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ExtensionFeedItemServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddExtensionFeedItemServiceClient(this IServiceCollection services, sys::Action<gagvs::ExtensionFeedItemServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ExtensionFeedItemServiceClientBuilder builder = new gagvs::ExtensionFeedItemServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::FeedItemServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedItemServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedItemServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedItemServiceClientBuilder builder = new gagvs::FeedItemServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::FeedItemSetLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedItemSetLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedItemSetLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedItemSetLinkServiceClientBuilder builder = new gagvs::FeedItemSetLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::FeedItemSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedItemSetServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedItemSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedItemSetServiceClientBuilder builder = new gagvs::FeedItemSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::FeedItemTargetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedItemTargetServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedItemTargetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedItemTargetServiceClientBuilder builder = new gagvs::FeedItemTargetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::FeedMappingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedMappingServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedMappingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedMappingServiceClientBuilder builder = new gagvs::FeedMappingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gagvs::FeedServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddFeedServiceClient(this IServiceCollection services, sys::Action<gagvs::FeedServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::FeedServiceClientBuilder builder = new gagvs::FeedServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::GeoTargetConstantServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddGeoTargetConstantServiceClient(this IServiceCollection services, sys::Action<gagvs::GeoTargetConstantServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::GeoTargetConstantServiceClientBuilder builder = new gagvs::GeoTargetConstantServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::GoogleAdsFieldServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddGoogleAdsFieldServiceClient(this IServiceCollection services, sys::Action<gagvs::GoogleAdsFieldServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::GoogleAdsFieldServiceClientBuilder builder = new gagvs::GoogleAdsFieldServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::GoogleAdsServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddGoogleAdsServiceClient(this IServiceCollection services, sys::Action<gagvs::GoogleAdsServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::GoogleAdsServiceClientBuilder builder = new gagvs::GoogleAdsServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::InvoiceServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddInvoiceServiceClient(this IServiceCollection services, sys::Action<gagvs::InvoiceServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::InvoiceServiceClientBuilder builder = new gagvs::InvoiceServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanAdGroupKeywordServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanAdGroupKeywordServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanAdGroupKeywordServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanAdGroupKeywordServiceClientBuilder builder = new gagvs::KeywordPlanAdGroupKeywordServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanAdGroupServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanAdGroupServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanAdGroupServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanAdGroupServiceClientBuilder builder = new gagvs::KeywordPlanAdGroupServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanCampaignKeywordServiceClient"/> to <paramref name="services"/>
        /// .
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanCampaignKeywordServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanCampaignKeywordServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanCampaignKeywordServiceClientBuilder builder = new gagvs::KeywordPlanCampaignKeywordServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanCampaignServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanCampaignServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanCampaignServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanCampaignServiceClientBuilder builder = new gagvs::KeywordPlanCampaignServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanIdeaServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanIdeaServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanIdeaServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanIdeaServiceClientBuilder builder = new gagvs::KeywordPlanIdeaServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordPlanServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordPlanServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordPlanServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordPlanServiceClientBuilder builder = new gagvs::KeywordPlanServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::KeywordThemeConstantServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddKeywordThemeConstantServiceClient(this IServiceCollection services, sys::Action<gagvs::KeywordThemeConstantServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::KeywordThemeConstantServiceClientBuilder builder = new gagvs::KeywordThemeConstantServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>Adds a singleton <see cref="gagvs::LabelServiceClient"/> to <paramref name="services"/>.</summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddLabelServiceClient(this IServiceCollection services, sys::Action<gagvs::LabelServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::LabelServiceClientBuilder builder = new gagvs::LabelServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::OfflineUserDataJobServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddOfflineUserDataJobServiceClient(this IServiceCollection services, sys::Action<gagvs::OfflineUserDataJobServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::OfflineUserDataJobServiceClientBuilder builder = new gagvs::OfflineUserDataJobServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::PaymentsAccountServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddPaymentsAccountServiceClient(this IServiceCollection services, sys::Action<gagvs::PaymentsAccountServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::PaymentsAccountServiceClientBuilder builder = new gagvs::PaymentsAccountServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ProductLinkInvitationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddProductLinkInvitationServiceClient(this IServiceCollection services, sys::Action<gagvs::ProductLinkInvitationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ProductLinkInvitationServiceClientBuilder builder = new gagvs::ProductLinkInvitationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ProductLinkServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddProductLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::ProductLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ProductLinkServiceClientBuilder builder = new gagvs::ProductLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ReachPlanServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddReachPlanServiceClient(this IServiceCollection services, sys::Action<gagvs::ReachPlanServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ReachPlanServiceClientBuilder builder = new gagvs::ReachPlanServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::RecommendationServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddRecommendationServiceClient(this IServiceCollection services, sys::Action<gagvs::RecommendationServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::RecommendationServiceClientBuilder builder = new gagvs::RecommendationServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::RecommendationSubscriptionServiceClient"/> to <paramref name="services"/>
        /// .
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddRecommendationSubscriptionServiceClient(this IServiceCollection services, sys::Action<gagvs::RecommendationSubscriptionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::RecommendationSubscriptionServiceClientBuilder builder = new gagvs::RecommendationSubscriptionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::RemarketingActionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddRemarketingActionServiceClient(this IServiceCollection services, sys::Action<gagvs::RemarketingActionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::RemarketingActionServiceClientBuilder builder = new gagvs::RemarketingActionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::SharedCriterionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddSharedCriterionServiceClient(this IServiceCollection services, sys::Action<gagvs::SharedCriterionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::SharedCriterionServiceClientBuilder builder = new gagvs::SharedCriterionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::SharedSetServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddSharedSetServiceClient(this IServiceCollection services, sys::Action<gagvs::SharedSetServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::SharedSetServiceClientBuilder builder = new gagvs::SharedSetServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::SmartCampaignSettingServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddSmartCampaignSettingServiceClient(this IServiceCollection services, sys::Action<gagvs::SmartCampaignSettingServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::SmartCampaignSettingServiceClientBuilder builder = new gagvs::SmartCampaignSettingServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::SmartCampaignSuggestServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddSmartCampaignSuggestServiceClient(this IServiceCollection services, sys::Action<gagvs::SmartCampaignSuggestServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::SmartCampaignSuggestServiceClientBuilder builder = new gagvs::SmartCampaignSuggestServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::ThirdPartyAppAnalyticsLinkServiceClient"/> to <paramref name="services"/>
        /// .
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddThirdPartyAppAnalyticsLinkServiceClient(this IServiceCollection services, sys::Action<gagvs::ThirdPartyAppAnalyticsLinkServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::ThirdPartyAppAnalyticsLinkServiceClientBuilder builder = new gagvs::ThirdPartyAppAnalyticsLinkServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::TravelAssetSuggestionServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddTravelAssetSuggestionServiceClient(this IServiceCollection services, sys::Action<gagvs::TravelAssetSuggestionServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::TravelAssetSuggestionServiceClientBuilder builder = new gagvs::TravelAssetSuggestionServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::UserDataServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddUserDataServiceClient(this IServiceCollection services, sys::Action<gagvs::UserDataServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::UserDataServiceClientBuilder builder = new gagvs::UserDataServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });

        /// <summary>
        /// Adds a singleton <see cref="gagvs::UserListServiceClient"/> to <paramref name="services"/>.
        /// </summary>
        /// <param name="services">
        /// The service collection to add the client to. The services are used to configure the client when requested.
        /// </param>
        /// <param name="action">
        /// An optional action to invoke on the client builder. This is invoked before services from
        /// <paramref name="services"/> are used.
        /// </param>
        internal static IServiceCollection AddUserListServiceClient(this IServiceCollection services, sys::Action<gagvs::UserListServiceClientBuilder> action = null) =>
            services.AddSingleton(provider =>
            {
                gagvs::UserListServiceClientBuilder builder = new gagvs::UserListServiceClientBuilder();
                action?.Invoke(builder);
                return builder.Build(provider);
            });
    }
}
