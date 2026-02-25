25.1.0
======
- Added support for version 23.1 of the Google Ads API
- Updated the `AddPerformanceMaxCampaign` example to demonstrate usage of
  text guidelines.

25.0.0
======
- Added support for version 23.0 of the Google Ads API.
- Removed support for version 17 of the Google Ads API.
- Changed the code examples to use `campaign.start_date_time` and
  `campaign.end_date_time` instead of `campaign.start_date` and
  `campaign.end_date`.
- Removed the `AddCallAd` example as call-only ads can no longer be created.

24.1.1
======
- Removed setting the `pb` header in requests, as it is already set by GAX;
  fixes issue #623.
- Upgraded Microsoft dependencies to version 9.
- Removed an unused parameter from ResourceNames.AssetSet.

24.1.0
======
- Added support for version 22.0 of the Google Ads API.
- Added support for Application Default Credentials via the 
  `UseApplicationDefaultCredentials` configuration flag.
- Added an overload for `SearchStreamAsync` accepting a `Func` (fixes #622)
- Updated the `AddPerformanceMaxCampaign` and `AddPerformanceMaxRetailCampaign`
  examples to support configuring asset automation settings.

24.0.1
======
- Removed explicit support for net6.0 as it's already covered by netstandard2.1

24.0.0
======
- Added support for version 21.0 of the Google Ads API.
- Removed support for version 18 of the Google Ads API.
- Upgraded the System.Text.Json dependency to the latest version.
- Updated examples that create campaigns to include setting the
  `ContainsEuPoliticalAdvertising` field.

23.0.0
======
- Added support for version 20.0 of the Google Ads API.
- Removed support for version 17 of the Google Ads API.
- Upgraded the Google.Ads.Gax.Grpc dependency to version 4.10.0 and the Google.Protobuf dependency
  to version 3.8.2.

22.2.0
======
- Added support for version 19.1 of the Google Ads API.
- Updated the `UploadEnhancedConversionsForLeads` example to demonstrate usage
  of the new `sessionAttributes` oneof.

22.1.0
======
- Added support for version 19.0 of the Google Ads API.
- Updated the `AddPerformanceMaxCampaign` and `AddPerformanceMaxRetailCampaign` examples to support
  using brand guidelines.
- Removed all feed-related examples.
- Replaced usage of the `GrpcPagedEnumerable` and `GrpcPagedAsyncEnumerable` classes with the
  `AdsPagedEnumerable` and `AdsPagedAsyncEnumerable` classes to prevent errors when using the
  `ReadPage` method: fixes [#589](https://github.com/googleads/google-ads-dotnet/issues/589).

22.0.0
======
- Removed support for version 16 of the Google Ads API.
- Added support for setting more configuration properties via dependency injection (fixes #592).

21.1.1
======
- Added support for configuring service account credentials from a JSON stream.
- Upgraded the System.Text.Json dependency in the `AuthenticateInAspNetWebApplication` subproject to
  address a security finding.

21.1.0
======
- Added support for version 18.0 of the Google Ads API.
- Updated the `GetAllDisapprovedAds` example to use the `SearchSettings` object.
- Added support for adding a `GoogleAdsClient` to a DI container, see [#573](https://github.com/googleads/google-ads-dotnet/pull/573)

21.0.0
======
- Added support for version 17.1 of the Google Ads API.
- Removed support for version 15 of the Google Ads API.

20.1.0
======
- Added support for version 17.0 of the Google Ads API.
- Updated code examples to remove usage of the `PageSize` parameter for `GoogleAdsService.Search`:
  * GetAccountHierarchy
  * GetChangeSummary
  * GetAdGroupBidModifiers
  * AuthenticateInAspNetWebApplication
  * GetResponsiveSearchAd
  * GetAllDisapprovedAds
  * UpdateAudienceTargetRestriction
  * AddPerformanceMaxProductListingGroupTree
  * AddPerformanceMaxRetailCampaign
  * AddShoppingProductListingGroupTree
- Removed the NavigateSearchResultPagesCachingTokens example as it is now obsolete.


20.0.0
======
- Added support for version 16.1 of the Google Ads API.
- Updated code examples:
  * VerifyAdvertiserIdentity
  * UploadConversionAdjustment
- Removed obsolete code examples:
  * AddFlightsFeed
  * AddRealEstateFeed
  * ApproveMerchantCenterLink
  * RejectMerchantCenterLink
  * RemoveFlightsFeedItemAttributeValue
  * UpdateFlightsFeedItemStringAttributeValue
- Bumped the Google.Api.Gax.Grpc dependency to 4.8.0 and changed the Grpc.Core dependency to depend
  directly on it
- Removed support for version 14 of the Google Ads API.

19.0.1
======
- Added support for .NET 8.0 in the Google.Ads.GoogleAds project: it was left out in the previous
  release.

19.0.0
======
- Removed support for .NET 5.0.
- Added support for .NET 8.0.
- Added support for user-defined gRPC interceptors.

18.1.0
======
- Added support for version 16.0 of the Google Ads API.
- Upgraded the Google.Api.Gax.Grpc dependency to 4.5.0 and the Google.Protobuf dependency to 3.25.0.
- Updated code examples:
  * DetectAndApplyRecommendations
  * AddResponsiveSearchAdFull
  * AddCall
  * AddHotelCallout
  * AddLeadFormAsset
  * AddPrices
  * AddSitelinks
- Added the VerifyAdvertiserIdentity example.

18.0.0
======
- Removed support for version 13.0 of the Google Ads API.
- Removed setting the MembershipLifeSpan field in the AddFlexibleRuleUserList example.

17.1.0
======
- Added support for version 15.0 of the Google Ads API. The following code examples still use
  version 14 because the services in the examples were removed in version 15:
    * ApproveMerchantCenterLink
    * RejectMerchantCenterLink
    * UploadImage
    * UploadMediaBundle
- Added support for the net6.0 target framework.
- Updated [`LogFormatter`](https://github.com/googleads/google-ads-dotnet/blob/main/Google.Ads.GoogleAds.Core/src/Logging/LogFormatter.cs)
  to redact fields of Local Services Lead and Local Services Lead Conversation.
- Added support for the `useCloudOrgForApiAccess` configuration flag. This is in preparation for a
  pilot project that uses Google Cloud orgs for API Access levels.
- Updated code examples:
    * AddBillingSetup
    * AddPerformanceMaxProductListingGroupTree
    * AddCustomerMatchUserList
    * UploadCallConversion
    * UploadOfflineConversion
    * UploadStoreSalesTransactions
- Renamed and updated code examples:
    * UploadConversionWithIdentifiers to UploadEnhancedConversionsForLeads
    * UploadConversionEnhancement to UploadEnhancedConversionsForWeb
- Fixed the following Shopping examples after the `ShoppingSetting::sales_country` field was
    removed:
    * AddMerchantCenterDynamicRemarketingCampaign
    * AddPerformanceMaxRetailCampaign
    * AddShoppingProductAd

17.0.1
======
- Fixed a bug with navigating nested properties in field masks (#533): return null when an
  intermediate property is null.

17.0.0
======
- Added support for version v14.1 of the Google Ads API.
- Removed support for v12 of the Google Ads API.
- Moved the ResourceNames utility to the Google.Ads.GoogleAds.V14.Resources namespace.

16.1.0
======
- Added support for version 14.0 of the Google Ads API.
- Renamed the HotelAds examples directory to "Travel".

16.0.0
======
- Added support for version v13.1 of the Google Ads API.
- Removed support for v11 of the Google Ads API.
- Moved configuration loading from App.config, settings.json and environment variables to a
  separate assembly.
- Disallowed Grpc.Net.Client on .NET framework.
- Bumped the version for Google.Ads.Gax to 3.0.0
- Bumped the version for Google.Ads.GoogleAds.Core to 3.0.0

15.0.3
======
- Bumped the version for Google.Ads.Gax to 2.2.0
- Bumped the version for Google.Ads.GoogleAds.Core to 2.2.0
- Bumped the version requirement of Google.Ads.GoogleAds to Google.Ads.GoogleAds.Core >= 2.2.0. This
  ensures that the fix for #488 is picked up by the latest library.

15.0.2
======
- Use ContinueWith for exception handling in Unary calls: this should provide a more general fix for
  #488

15.0.1
======
- Fixed #488 by marking all async calls as ConfigureAwait(false)

15.0.0
======
- Added support for version v13.0 of the Google Ads API.
- Removed support for v10 of the Google Ads API.
- Fixed some code examples.
  - Updated AddCustomerMatchUserList to clarify UserIdentifier usage.

14.2.0
======
- Update the dependencies on Google.Ads.GoogleAds.Core and Google.Ads.Gax

14.1.0
======
- Added support for version v12.0 of the Google Ads API.
- Fixed #381 by adding support for ILogger-based logging.
- Fixed some code examples.
  - Fixed AddPerformanceMaxRetailCampaign by creating the mutate operations in the correct order.
  - Removed the AddLocalCampaign example - local campaigns have been migrated to PMax.
  - Removed the AddSmartDisplayAd example - smart display ads are no longer supported.

14.0.0
======

- Added support for version v11.1 of Google Ads API.
- Added missing copyright headers to build scripts.
- Added new code examples.
  - Reworked HandleResponsiveSearchAdPolicyViolations.cs to show policy violation handling using
    RSAs rather than ETAs.
- Fixed some code examples.
  - Fixed ValidateAd.cs to change the rethrowing to prevent error CA2200 and fix a bug with error
    counting. Also clarified some comments to clarify how to use validateOnly setting.
  - Updated AddAdCustomizer.cs to remove unused code.
- Moved CachedChannelFactory.cs to Google.Ads.Gax.
- Initialize OAuth2Scope with an empty value. Useful for avoiding NPE in some tests when refactoring.
- Removed unused GoogleAdsConfig in a couple of internal classes.
- Upgrade to Cloud SDK v4.0. Fixes https://github.com/googleads/google-ads-dotnet/issues/445. This
  upgrade has several implications.
  - We increased the runtime requirements from `netstandard2.0` to `netstandard2.1`. This is required
    since `Google.Api.Gax.Grpc` bumped its runtime requirements to `netstandard2.1`. Since this is
    a backwards incompatible change, we are doing a major version bump of `Google.Ads.Gax`,
    `Google.Ads.GoogleAds.Core` and `Google.Ads.GoogleAds`. There are no other code changes required
    to your application.
  - The library has the ability to switch between `Grpc.Net.Client` and `Grpc.Core` for wire transport.
    Grpc.Net.Client is the default implementation used by the client library. This is a fully managed
    .NET implementation of the gRPC protocol, but doesn't work on some older platforms like
    `.NET472`. On platforms where `Grpc.Net.Client` doesn't work, the client library falls back to
    `Grpc.Core`, the library used for implementing wire transport until `v13.0.2` of the client
    library. You can refer to
    https://docs.microsoft.com/en-us/aspnet/core/grpc/supported-platforms?view=aspnetcore-6.0#net-grpc-client-requirements
    for an upto date list of platforms that are supported by `Grpc.Net.Client` library.
  - `Grpc.Core` is scheduled to go away in the future, see https://grpc.io/blog/grpc-csharp-future/.
  - You can use a new setting named `GoogleAdsConfig::UseGrpcCore` to force the client library to
    use the `Grpc.Core` library for wire transport. This setting defaults to `false`.
- Removed the dependency on `System.Configuration.ConfigurationManager` and replaced it with a
  simple implementation tha reads from App.config.
- Added `App.config` and `Web.config` to .gitignore to prevent accidental leak of credentials from
  the development environment.
- Added a utility method to reverse-parse a proto enum from the protobuf enum value.
- Use callback instead of Task chaining to perform logging. Fixes https://github.com/googleads/google-ads-dotnet/issues/386
- Version for Google.Ads.Gax was bumped to 2.0.0.
- Version for Google.Ads.GoogleAds.Core was bumped to 2.0.0.

13.0.2
======
- Removed the PublicSign clause from all csproj files. Fixes https://github.com/googleads/google-ads-dotnet/issues/437.
- Version for Google.Ads.Gax was bumped to 1.0.3.
- Version for Google.Ads.GoogleAds.Core was bumped to 1.0.1.

13.0.1
======
- Updated some code examples.
  - Reworked UploadCallConversion.cs to support a missing parameter and support partial failure.
  - Removed some redundant code from HandlePartialFailure.cs.
  - Modified ValidateAd.cs to fail on unhandled errors.
  - Improved the instructions for LoginCustomerId in GenerateUserCredentials example.
- Fixed the release script to load secrets from Keystore.

13.0.0
======
- Continued with the Gax library refactoring. Google.Ads.GoogleAds is now split into
  Google.Ads.GoogleAds (which contains the stubs), and Google.Ads.GoogleAds.Core (which
  contains the library logic).
- Fixed an issue with DetectAndApplyRecommendations.cs to handle an empty list of
  recommendations.
- Google.Ads.Gax version was bumped to v1.0.2.
- Google.Ads.GoogleAds.Core version was set to 1.0.0 for its first release.
- Rewrote the release script to work on Linux instead of Windows.
- Updated some code examples.
  - Reworked AddAdCustomizer.cs to use CustomizerAttributes and ResponsiveSearchAds instead of feeds and ExpandedTextAds.
  - Rename the ValidateTextAd.cs to ValidateAd.cs.
  - Rename the campaignId parameter to baseCampaignId in CreateExperiment.cs
  - Rename UpdatedExpandedTextAd.cs to UpdateResponsiveSearchAd.cs to illustrate how to update RSAs.
  - Update AddBusinessProfileLocationExtensions.cs to mark businessProfileAccessToken as an
    optional parameter.
- Removed some code examples since ExpandedTextAds are now sunset.
  - AddExpandedTextAdWithUpgradedUrls.cs
  - AddExpandedTextAds.cs
- Removed support for v9 of the Google Ads API.
- Updated GenerateUserCredentials example to force an OAuth2 Consent screen every time. Fixes https://github.com/googleads/google-ads-dotnet/issues/418


12.1.0
======

- Added support for version v11 of the Google Ads API.
- Added new code examples:
  - CampaignManagement\CreateExperiment.cs
  - Recommendations\DetectAndApplyRecommendations.cs
- Removed some code examples:
  - CampaignManagement\CreateCampaignExperiment.cs
  - CampaignManagement\GraduateCampaignExperiment.cs
- Updated some code examples
  - Fixed the AddSmartCampaign.cs example to use BusinessProfileLocation instead of BusinessProfileId
- Fixed the protobuf key name in the user agent header.
- Updated all code examples to remove INSERT_XXX_ placeholders from the Main() method.
- Added an additional test case to ensure that FieldMask handles empty messages correctly.
- Made more changes related to the Google.Ads.Gax refactoring.
  - Deleted an orphaned file.
  - Fixed some incorrect namespaces.
  - Fixed the internal visibility of Google.Ads.Gax assembly to a bunch of additional assemblies.
  - Extract some common test utilities into a separate assembly.
- Added a THIRD-PARTY-LICENSE.txt that captures the licenses of all the third_party transitive
  dependencies into a single file. This file will also be embedded into the nupkg distribution.
- Fixed an NPE when initalizing GoogleAdsException without metadata. Fixes https://github.com/googleads/google-ads-dotnet/issues/402

12.0.0
======
- The project was split into two assemblies -- Google.Ads.Gax and Google.Ads.GoogleAds. This was
  done to extract common functionality so that we can use it for other Ads APIs. The main difference
  from a usage perspective is that several utility classes like `FieldMasks`, `MediaUtilities`,
  etc. moved from the `Google.Ads.GoogleAds` namespace to `Google.Ads.Gax` namespace. As a result,
  you need to fix the namespaces in your `using` statements. Other than that, the library remains
  unchanged (e.g. there were no additional changes to any of the code examples as a result of this
  refactoring).
  - If you use the Nuget package, you will continue to add reference to `Google.Ads.GoogleAds`.
    There is no need to add dependency to `Google.Ads.Gax` package; it will be downloaded as a
    transitive dependency.
  - If you work with the repo code directly, then the code has been split into two top-level
    folders, namely `Google.Ads.Gax` and `Google.Ads.GoogleAds`. The `Google.Ads.GoogleAds.sln`
    has moved to the `Google.Ads.GoogleAds` folder as a result. `Google.Ads.GoogleAds.sln` still
    remains the main Visual Studio solution file for working with the entire repo.
- Updated some code examples.
  - Made polling consistent across libs in Remarketing/AddCustomerMatchUserList.cs
  - Updated AccountManagement/GetChangeDetails.cs to add newly supported ChangeEventResourceType.
  - Renamed AuthenticateInDesktopApplication example to GenerateUserCredentials.
  - Renamed AuthenticateInWebApplication to AuthenticateInAspNetCoreApplication.
- Regenerated stubs for versions v9 and v10 of the Google Ads API library. The library now supports
  higher timeout changes that were rolled out to some methods in the Google Ads API.
- Added support for version v10_1 of the Google Ads API.
- Removed support for version v8 of the Google Ads API. See
  https://developers.google.com/google-ads/api/docs/sunset-dates for migration guides for newer
  versions.
- Added support for tracking protobuf library version in request headers.
- Made the services disposable. Fixes https://github.com/googleads/google-ads-dotnet/issues/355. The
  underlying issue and workaround was suggested by
  Claude Beauchemin(https://github.com/cbeauchemin).

11.0.1
======

- Fixed some issues with code examples.
  - Remarketing/AddDynamicRemarketingAsset.cs
  - AdvancedOperations/AddResponsiveSearchAdWithAdCustomizer.cs
  - AdvancedOperations/AddCallAd.cs
  - Extensions/AddCall.cs
  - AdvancedOperations/AddPerformanceMaxCampaign.cs
  - ShoppingAds/AddPerformanceMaxRetailCampaign.cs
- Fixed an issue with how enums are used when constructing resource names.
- Updated code examples.
  - Remarketing/UploadOfflineConversion.cs by adding support for GBRAID and WBRAID.
  - BasicOperations/AddCampaigns.cs example to show Display Expansion for Search Campaigns.
- Add new code examples.
  - Misc/NavigateSearchResultPagesCachingToken.cs
- Fixed issues related to logging.
  -  Do not skip logging if an empty response is returned by the server for a streaming call.
  Fixes https://github.com/googleads/google-ads-dotnet/issues/359
- Added a null check to make logging more robust.
- Fix customerId and requestId in summary logs. Fixes https://github.com/googleads/google-ads-dotnet/issues/364
- Do not set a default value of CancellationToken in GoogleAdsService.SearchStreamAsync call so
 users can use their own CancellationToken. See
 https://developers.google.com/google-ads/api/docs/client-libs/dotnet/getting-started#canceling_async_methods
 for a usage example. Fixes https://github.com/googleads/google-ads-dotnet/issues/360

11.0.0
======
- Added support for v10 of the Google Ads API.
- Removed support for v7 of the Google Ads API.
- Renamed Google My Business (GMB) to Business Profile everywhere.
- Fix https://github.com/googleads/google-ads-dotnet/issues/331. Always get a refresh token in the
web application example. Fix was contributed by Jhon Samamé
(https://github.com/johnpisg)
- Fixed https://github.com/googleads/google-ads-dotnet/issues/283. Read requestId from the
 response object instead of response headers for streaming calls.
- Added new code examples
  - AdvancedOperations/AddCallAd
  - AdvancedOperations/AddDynamicPageFeedAsset
  - AdvancedOperations/AddPerformanceMaxCampaign
  - AdvancedOperations/AddResponsiveSearchAdWithAdCustomizer
  - Extensions/AddCall
  - Remarketing/AddDynamicRemarketingAsset
  - Remarketing/UploadConversionEnhancement
  - Remarketing/UploadConversionWithIdentifiers
  - ShoppingAds/AddPerformanceMaxProductListingGroupTree
  - ShoppingAds/AddPerformanceMaxRetailCampaign
- Updated code examples
  - AccountManagement/GetAccountInformation
  - AdvancedOperations/AddDisplayUploadAd
  - AdvancedOperations/AddDynamicPageFeed
  - AdvancedOperations/AddLocalCampaign
  - AdvancedOperations/AddSmartCampaign
  - AdvancedOperations/AddSmartDisplayAd
  - BasicOperations/GetKeywords
  - Extensions/AddAffiliateLocationExtensions
  - Extensions/AddHotelCallout
  - Misc/UploadImageAsset
  - Remarketing/SetUpAdvancedRemarketing
  - Remarketing/SetUpRemarketing
- Renamed code examples
  - Extensions/AddGoogleMyBusinessLocationExtensions => Extensions/AddGoogleMyBusinessLocationExtensions
- Marked multiple issues as fixed.
  - https://github.com/googleads/google-ads-dotnet/issues/351
  - https://github.com/googleads/google-ads-dotnet/issues/350
  - https://github.com/googleads/google-ads-dotnet/issues/349
  - https://github.com/googleads/google-ads-dotnet/issues/347
  - https://github.com/googleads/google-ads-dotnet/issues/346
  - https://github.com/googleads/google-ads-dotnet/issues/344
  - https://github.com/googleads/google-ads-dotnet/issues/343
  - https://github.com/googleads/google-ads-dotnet/issues/342
  - https://github.com/googleads/google-ads-dotnet/issues/341
  - https://github.com/googleads/google-ads-dotnet/issues/340
  - https://github.com/googleads/google-ads-dotnet/issues/339
  - https://github.com/googleads/google-ads-dotnet/issues/337
  - https://github.com/googleads/google-ads-dotnet/issues/336
  - https://github.com/googleads/google-ads-dotnet/issues/335
  - https://github.com/googleads/google-ads-dotnet/issues/334
  - https://github.com/googleads/google-ads-dotnet/issues/333
  - https://github.com/googleads/google-ads-dotnet/issues/331
  - https://github.com/googleads/google-ads-dotnet/issues/327
  - https://github.com/googleads/google-ads-dotnet/issues/283
- Refactored the logging code to introduce an interface that handles API-specific logging logic.
- Regenerated stubs for v8 and v9 of the Google Ads API to pick up the correct copyright year.
- Fixed some build warnings for .NET472.
- Excluded autogenerated stub tests from presubmit script. Started running tests for netcoreapp3.1,
  net5.0 on presubmit.

10.2.0
======
- Added support for v9 of the Google Ads API.
- Migrated some code examples to use Assets.
  - Updated Extensions\AddHotelCallout.cs
  - Updated Extensions\AddPrices.cs
  - Updated Extensions\AddSitelinks.cs
  - Added Extensions\AddSitelinksUsingAssets.cs
  - Deleted Extensions\AddSitelinksUsingFeeds.cs
- Fix https://github.com/googleads/google-ads-dotnet/issues/320. Use channel settings instead of environment variable to set proxy.
- Updated AdvancedOperations/AddSmartCampaign.cs to use GetKeywordThemeSuggestions.
- Separated the Summary and Detailed Log String Creation. Fix was contributed by Kevin
(https://github.com/aukevin)
- Added tests for async MediaUtilities. Fix was contributed by Jarrod Mosen
(https://github.com/wub)
- Regenerated all stubs to work with the latest code generator.
- Added support for warnings. Updated Remarketing\UploadStoreSalesTransactions.cs example.
- Upgraded all dependencies where possible.


10.1.0
======

- Introduced an async version of GetAssetDataFromUrl. Feature contributed by Jarrod Mosen
(https://github.com/wub)
- Fixed the short url in code examples.
- Updated various issue templates.
- Simplified the ExampleRunner::PrintAvailableExamples method to print just class names.
- Added new code examples.
  - AdvancedOperations\AddBiddingDataExclusion.cs
  - AdvancedOperations\AddBiddingSeasonalityAdjustment.cs
- Add gccl version header for logging purposes.

10.0.0
======

- Added support for version v8_1 of the Google Ads API.
- Removed support for version v6 of the Google Ads API.
- Added new code examples.
  - Migration\CampaignReportToCsv.cs.
- Fixed a few code examples.
  - Fix the video ID in AddLocalCampaign.cs.
  - Added SmartCampaignSuggestionService to AddSmartCampaign example.
  - Updated AccountManagement/GetChangeDetails.cs to add support for more asset types.
- Removed some code examples.
  - Removed AddGmailAd.cs.
- Downgrade a few dependencies to make the library work on Azure. Fixes https://github.com/googleads/google-ads-dotnet/issues/302.
- Fixed the example runner.
  - Update example runner to disambiguate error conditions.
  - Fix bug where exceptions were swallowed by incorrect condition.
  - Refactor example type extraction into GetCodeExampleType.

9.0.0
=====
- Removed support for version v5 of the Google Ads API.
- Added support for version v8 of the Google Ads API.
- Updated all code examples to use CommandLineParser library. Fixes https://github.com/googleads/google-ads-dotnet/issues/241.
- Convert the grpc channel settings from constants to configurable settings. Fixes https://github.com/googleads/google-ads-dotnet/issues/285.
- Add support for enums in FieldMasks.AllSetFieldsOf. Fixes https://github.com/googleads/google-ads-dotnet/issues/289.
- Added new code examples
  - UseCrossAccountBiddingStrategy.cs
  - AddSmartCampaign.cs
- Updated UploadStoreSalesTransactions.cs code example.
- Converted AuthenticateInDesktopApplication into a nuget tool. Fixes https://github.com/googleads/google-ads-dotnet/issues/164.
- Marked a couple of tests as non-parallelizable to fix flakiness.

8.0.0
=====
- Removed support for v4 of the API. See https://ads-developers.googleblog.com/2021/04/google-ads-api-v4-and-v5-sunset-reminder.html for details.
- Added support for v7 of the API. See https://developers.google.com/google-ads/api/docs/release-notes#v7_0 for details
- Updated the GetAdGroupBidModifiers example to include hotel_check_in_date_range field.
- Updated the parameter names in some code examples to match examples in other languages.
- Fixed a couple of broken tests cases.
- Added new code examples.
  -- Billing\GetInvoices.cs
  -- Extensions\MigratePromotionFeedToAsset.cs
  -- Remarketing\AddCustomAudience.cs
- Made the tests parallelizable.
- Updated the includecode regions in various code examples to make it consistent with other libraries.
- Simplified the logic of Fieldmasks::AllSetFieldsOf() method. Also, fix the logic when
 non-optional singular fields are parsed.
- Fixed a minor bug in HandlePartialFailure.

7.1.0
=====
- Regenerated all stubs. This adds default timeouts for RPC calls in service stub classes.
- Limited the scope of channel cache from global to client level. Provided a flag in GoogleAdsConfig class to control the channel cache
- Added a code example for setting custom timeout.
- Added a new overloaded signature for SearchStream() method that accepts a CallSettings object.
- Fixed all outdated documentation links that pointed to AdWords API documenation.
- Bumped all library dependencies.
  - Google.Protobuf: 3.15.6
  - Grpc.Core: 2.36.4
- Removed the use of HasPartnersBadge property in CreateCustomer.cs.
- Remove the use for LanguageCode and DomainName properties in AddDynamicPageFeed.cs.
- Added support for .NET 5.0 and make it the default version for tests.
- Refine the region tag in various code examples.
- Fixed a comment in ValidateTextAd code example.
- Fixed an issue with AddDynamicPageFeed code example.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/277.

7.0.0
=====

- Added support for v6_1 of Google Ads API. See https://developers.google.com/google-ads/api/docs/release-notes#v6_1 for details.
- Removed support for v3 of Google Ads API. See https://ads-developers.googleblog.com/2021/01/google-ads-api-v3-sunset-reminder.html
for details.
- Fixed a few code examples
  - AddCampaignBidModifier.cs
  - GetChangeDetails.cs
  - AddDisplayUploadAd.cs
- Added new code examples for CustomerUserAccessInvitation.
  - AccountManagement\GetPendingInvitations.cs
  - AccountManagement\InviteUserWithAccessRole.cs
- Fixed the logging to mask email addresses in CustomerUserAccessInvitation.
- Added a new code example for Image extensions.
  - Extensions\AddImageExtension.cs
- Added a new ASP.NET Core example for OAuth2 web flow -- AuthenticateInWebApplication. The
existing ASP.NET + Webforms example was renamed to AuthenticateInAspNetWebApplication.
- Bumped the grpc dependencies.
  - Grpc.Core: 2.35.0
- Regenerated the stub code for all versions. Added a change to hide the autogenerated service
builder classes, since they don't initialize the services correctly.
- Updated the GoogleAdsConfig::OAuth2Scope field to accept a comma separated list of multiple
OAuth2 scopes.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/263


6.1.0
=====

- Fixed a few code examples
  - SetupRemarketing.cs
  - GetAccountHierarchy.cs
  - AddShoppingProductListingGroupTree.cs
  - UpdateSitelink.cs
  - GetAdGroupBidModifiers.cs
- Fixed the build badge URL in the README.md file.
- Added region tags in all code examples. This makes it easier to embed the code examples
  in the developer guides.
- Fixed a broken urls to guide references in some code examples.
- Added new code examples for FeedItemSets.
  - Feeds\CreateFeedItemSet.cs
  - Feeds\GetFeedItemsOfFeedItemSet.cs
  - Feeds\LinkFeedItemSet.cs
- Added a profiler for the client library to capture client time breakdown by serialization, deserialization and over-the-wire times.
- Bumped the protobuf and grpc dependencies. This is required due to https://github.com/protocolbuffers/protobuf/issues/8027. The full version bump lists are:
  - Google.Protobuf: 3.14.0
  - Grpc.Core: 2.34.0
  - Microsoft.Extensions.Configuration: 5.0.0.
  - System.Configuration.ConfigurationManager: 5.0.0

6.0.0
=====
- Added support for v6 of Google Ads API. See
  https://developers.google.com/google-ads/api/docs/release-notes#v6 for release notes.
- Removed support for v2 of the Google Ads API. See
 https://developers.google.com/google-ads/api/docs/sunset-dates and
 https://ads-developers.googleblog.com/2020/08/google-ads-api-v2-sunset-reminder.html
 for more details.
- The library dependencies were bumped as listed below:
  - Google.Api.Gax and related assemblies: 3.2.0
  - Grpc.Core and related assemblies: 2.33.1
  - Microsoft.Extensions and related assemblies: 3.1.9
- Fixed the README.md file to make it minimal. See
 https://developers.google.com/google-ads/api/docs/client-libs/dotnet for detailed
 documentation.
- Fixed the conditional compilation for net472.
- Added a utility method in FieldMasks.cs to fetch field values given a fieldmask.
- Added additional masking for PII in logs.
- Fixed the broken documentation links in multiple source files.
- Fixed broken examples.
  - Billing\AddBillingSetup.cs
  - Fixed issue 246 - Reporting\ParallelReportDownload.cs.
- Updated some examples.
  - Updated the query in Billing\AddBillingSetup.cs.
  - Fix a comment in Remarketing\UploadStoreSalesTransactions.cs.
  - Simplified the paged search iteration in Billing\GetBillingSetup.cs.
  - Renamed Authentication\AuthenticateInStandaloneApplication => Authentication\AuthenticateInDesktopApplication.
  - Minor grammar fix in Remarketing\UploadCallConversion.cs.
  - Renamed AccountManagement\GetAccountChanges.cs => AccountManagement\GetChangeSummary.cs.
- Fixed the resource name for DomainCategory.
- Fixed the PartialFailureError condition logic.
- Migrated all code examples to use proto3 presence instead of wrapper types. This improves
 the API performance and makes the API easier to work with native C# types.
- Added support for reading the settings.json file from an environment variable named
 GOOGLE_ADS_CONFIGURATION_FILE_PATH. The client library will try to load settings from this file
 if App.config is missing, and this environment variable is provided.
- Added support for reading individual settings from an environment variable. Supported settings
  are:
  - GOOGLE_ADS_OAUTH2_MODE
  - GOOGLE_ADS_CLIENT_ID
  - GOOGLE_ADS_CLIENT_SECRET
  - GOOGLE_ADS_REFRESH_TOKEN
  - GOOGLE_ADS_JSON_KEY_FILE_PATH
  - GOOGLE_ADS_IMPERSONATED_EMAIL
  - GOOGLE_ADS_DEVELOPER_TOKEN
  - GOOGLE_ADS_LOGIN_CUSTOMER_ID
  - GOOGLE_ADS_LINKED_CUSTOMER_ID
- Add new code examples.
  - Remarketing\SetupRemarketing.cs.
  - Remarketing\SetupAdvancedRemarketing.cs
  - Remarketing\UpdateAudienceTargetRestriction.cs.
  - AdvancedOperations\AddLocalCampaign.cs.
  - HotelAds\AddHotelListingGroupTree.cs.
  - AccountManagement\UpdateUserAccess.cs.
  - AdvancedOperations\GetChangeDetails.cs.
  - Extensions\UpdateSitelinkCampaignExtensionSetting.cs.
  - Extensions\UpdateSitelink.cs.
  - Extensions\RemoveEntireSitelinkCampaignExtensionSetting.cs.
  - Extensions\AddLeadFormExtension.cs.
  - Extensions\AddHotelCallout.cs.
- Fixed the PackageIconUrl property in Google.Ads.GoogleAds.csproj with PackageIcon as required
 by the latest .NET library.
- Downgrade the tests to use .netcoreapp3.0.

5.0.0
=====
- Added support for v5 of Google Ads API. See
  https://developers.google.com/google-ads/api/docs/release-notes#500_beta_2020-08-26 for release notes.
- The library dependencies were bumped as listed below:
  - Google.Api.CommonProtos: 2.1.0
  - Google.Apis and related assemblies: 1.49.0.0
  - Google.Api.Gax and related assemblies: 3.1.0
  - Google.Protobuf: 3.13.0.0
  - Grpc.Core and related assemblies: 2.31.0
  - Microsoft.Extensions and related assemblies: 3.1.7
  - DotNetCompilerPlatform: 3.6.0
- Added new code examples:
  - Extensions/AddGeoTarget.cs
  - Remarketing/AddLogicalUserList.cs
  - Remarketing/AddCombinedRuleUserList.cs
  - Remarketing/AddExpressionRuleUserList.cs
  - Remarketing/AddConversionBasedUserList.cs
  - Feeds/RemoveFeedItems.cs
  - Feeds/RemoveFlightsFeedItemAttributeValue.cs
- Various minor changes to code examples for consistency with other client libraries.
- Renamed code examples:
  - ShoppingAds/RejectMerchantCenterLink.cs => AccountManagement/RejectMerchantCenterLink.cs
  - Extensions/UpdateFlightsFeedItemStringAttributeValue.cs => Feeds/UpdateFlightsFeedItemStringAttributeValue.cs
  - Targeting/SearchForTargetableLanguagesAndCarriers.cs => Targeting/SearchForLanguageAndCarrierConstants.cs
- Fixed https://github.com/googleads/google-ads-dotnet/issues/211
- Fixed https://github.com/googleads/google-ads-dotnet/issues/231

4.0.0
=====
- Added support for v4 of Google Ads API. See https://developers.google.com/google-ads/api/docs/release-notes#400_beta_2020-07-08
  for release notes.
- Removed support for v1 of Google Ads API. See sunset reminder for v1 at
  https://ads-developers.googleblog.com/2020/06/google-ads-api-beta-v1-sunset-reminder.html. We are
  doing a major version bump for the library, since removing support for an API version is backward
  incompatible change.
- Added new code examples:
  - Reporting/ParallelReportDownload.cs
  - Reporting/UploadStoreSalesTransactions.cs
  - Planning/GetAdGroupCriterionCpcBidSimulations.cs
  - Extensions/AddSitelinksUsingFeeds.cs
  - ErrorHandling/HandleKeywordPolicyViolations.cs
  - ErrorHandling/HandleExpandedTextAdPolicyViolations.cs
  - AdvancedOperations/AddDisplayUploadAd.cs
  - Billing/AddBillingSetup.cs
- Renamed code examples:
  - AddCompleteCampaignsUsingMutateJob.cs => AddCompleteCampaignsUsingBatchJob.cs
- Fixed https://github.com/googleads/google-ads-dotnet/issues/185
- Fixed https://github.com/googleads/google-ads-dotnet/issues/197
- Fixed https://github.com/googleads/google-ads-dotnet/issues/201
- Fixed https://github.com/googleads/google-ads-dotnet/issues/192
- Fixed https://github.com/googleads/google-ads-dotnet/issues/203

3.0.0
=====
- Bumped gRPC dependency to 2.29.0. Since this is a breaking change as per the gRPC team, we
  have made a corresponding bump in the major version of this library. See
  https://github.com/grpc/proposal/blob/master/L57-csharp-new-major-version.md to learn more about
  the gRPC changes.
- The library dependencies were bumped as listed below:
  - Google.Protobuf: 3.12.2.
  - Grpc.Core and related assemblies: 2.29.0
  - Google.Api.Gax.Grpc and related assemblies: 3.0.0
  - Google.LongRunning: 2.0.0
  - .NET: netstandard2.0;net472 for libraries, and netcoreapp3.0;net472 for executables.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/163
- Fixed https://github.com/googleads/google-ads-dotnet/issues/120
- Removed several method flattenings that involved validateOnly and partialFailure parameters. The
  library provides method flattenings as convenience methods for the most common API use cases. Since
  validateOnly and partialFailure parameters are optional for most of the API use cases (and default
  to false), these overloaded methods provide limited value to developers and tend to confuse them.
  We recommend using the method that uses the Request object as parameter as a replacement. You can
  compare Remarketing\UploadOfflineConversion.cs as an example on how this affects the method usage.
  The other updated code examples are:
  - ErrorHandling\HandleRateExceededError.cs
  - ErrorHandling\HandlePartialFailure.cs
  - Remarketing\UploadOfflineConversion.cs
  - Remarketing\UploadConversionAdjustment.cs
  - Remarketing\UploadCallConversion.cs
  - Remarketing\AddCustomerMatchUserList.cs
  - CampaignManagement\ValidateTextAd.cs

2.9.0
=====
- Changed the buildstatus image to be .svg format. Updated the path in the README.md file.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/157
- Fixed https://github.com/googleads/google-ads-dotnet/issues/158
- Fixed https://github.com/googleads/google-ads-dotnet/issues/159
- Fixed https://github.com/googleads/google-ads-dotnet/issues/160
- Fixed https://github.com/googleads/google-ads-dotnet/issues/168
- Added support for v3_1 of Google Ads API.
- Added new code examples.
  - BasicOperations/UpdateExpandedTextAd.cs
  - CampaignManagement/AddCompleteCampaignsUsingMutateJob.cs
  - BasicOperations/GetResponsiveSearchAds.cs
  - Extensions/AddAffiliateLocationExtensions.cs
  - AccountManagement/GetAccountHierarchy.cs
  - AccountManagement/AcceptServiceLinks.cs
  - CampaignManagement/GraduateCampaignExperiment.cs
  - Remarketing/UploadCallConversion.cs
  - Targeting/SearchForTargetableLanguagesAndCarriers.cs
  - Remarketing/AddCustomerMatchUserList.cs
  - ShoppingAds/ApproveMerchantCenterLink.cs
- Renamed some code examples to make the names consistent with other library examples.
  - ErrorHandling/HandlePartialFailures.cs  => ErrorHandling/HandlePartialFailure.cs
  - Extensions/UpdateFeedItemAttributeValue.cs => Extensions/UpdateFlightsFeedItemStringAttributeValue.cs
  - Targeting/GetGeoTargetConstantsByName.cs => Targeting/GetGeoTargetConstantsByNames.cs
- Fixed broken code examples.
  - BasicOperations/AddResponsiveSearchAd.cs
  - BasicOperations/GetExpandedTextAds.cs
- Updated Billing/GetAccountBudgets.cs example to retrieve adjusted spending limit, and to use
  streaming instead of paged retrieval.
- Fixed the logging handler to handle situations where customer ID is not part of the request body.
- Add throw statement to all code examples. Add exception handling where missing.
- Standardized the INSERT_ADGROUP_ID placeholder name for parameters in various code examples.
- Renamed ResourceNames.CampaignExperiments method to ResourceNames.CampaignExperiment for consistency.

2.8.0
=====

- Added support for v3 of Google Ads API.
- Upgraded all code examples and tests to use v3.
- Fixed AddShoppingProductListingGroupTree example to work with v3.
- Made changes to logging and exception handling framework to support streaming methods.
- The generated stubs no longer use the ExceptionCustomization feature of gax libraries, since the
exception handling logic have moved to grpc interceptors. These stub classes have been removed from
the distribution.
- Convert GetCampaigns and GetKeywordStats examples to use server streaming.
 See https://developers.google.com/google-ads/api/docs/reporting/streaming to learn more about
 server streaming.
- Add an empty `custom_nupkg` folder in the repo to help with testing dependent packages that are
 custom-built from GitHub sources.
- Fixed the visibility of several test classes and methods.
- Added new code examples:
  - AddPrices
  - AddGoogleMyBusinessLocationExtensions
  - AddAppCampaign
  - UpdateCampaignCriterionBidModifier
- Refactored all the grpc metadata keynames into a standalone class.

2.7.0
=====

- Added new code examples.
  - AdvancedOperations\AddAdCustomerizer.cs
  - AdvancedOperations\AddSmartDisplayAd.cs
  - BasicOperations\AddResponsiveSearchAd.cs
  - BasicOperations\AddAdGroup.cs renamed to BasicOperations\AddAdGroups.cs
  - CampaignManagement\AddCampaignLabels.cs
  - CampaignManagement\GetCampaignsByLabel.cs
  - CampaignManagement\SetAdParameters.cs
  - CampaignManagement\ValidateTextAd.cs
  - ErrorHandling\HandleRateExceededError.cs
  - Extensions\AddSitelinks.cs
  - Extensions\UpdateFeedItemAttributeValue.cs
  - Misc\GetAllImageAssets.cs
  - Misc\GetAllVideosAndImages.cs.cs
  - Misc\UploadImage.cs
  - Misc\UploadImageAsset.cs
  - Misc\UploadMediaBundle.cs
  - Remarketing\AddFlightsFeed.cs
  - Remarketing\AddRealEstateFeed.cs
  - Remarketing\AddRemarketingAction.cs
  - Remarketing\UploadConversionAdjustment.cs
  - ShoppingAds\AddShoppingSmartAd.cs
  - ShoppingAds\GetProductBiddingCategoryConstant.cs
  - Targeting\AddCustomerNegativeCriteria.cs
  - Targeting\AddDemographicTargetingCriteria.cs
- Added tests for some code examples. All new code examples will have tests, tests for previous code
 examples will be backfilled in upcoming releases.
- Signing was added to Google.Ads.GoogleAds.Examples.csproj to facilitate tests for code examples.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/118. You can now extend GoogleAdsConfig
 class, override CreateCredentials() method to provide your own logic for caching credentials.
- Removed JsonBodyFormatter and TraceFormatter classes. Since the library works with proto objects,
 it is cleaner to do the formatting directly with the objects instead of converting it into a Json
 object and processing it. Part of the relevant functionality was pulled into LogEntry class.
- Additional null checks were added into LoggingInterceptor::GetPartialFailures() method. This provides
 a less noisy debugging experience as well as better performance.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/117
- https://github.com/googleads/google-ads-dotnet/issues/116
- Fixed broken tests in GoogleAdsClientTests suite and GoogleAdsServiceClientFactoryTests suite. Also
  fixed StubIntegrityTestHelper.cs to work with the fixed suites.
- Google.Ads.GoogleAds.Tests.csproj currently runs only for net452 target. This is a temporary workaround
 until https://github.com/nunit/nunit3-vs-adapter/issues/17 is fixed for netcore and makes its way
 into a stable release.
- Remove reference to Google.Ads.GoogleAds nuget package in Google.Ads.GoogleAds.Tests.csproj. Tests
should build and run against the csproj instead.
- Added nuget package references to the new nuget packages for .NET SDK. This allows you to build
 .NET SDK projects using dotnet command only.
- Refactored the tests suite.
  - Move ExampleTestsBase.cs to v2 folder.
  - Add an ExamplesTestSetup.cs file for single-place initialization for the whole test suite.
  - Add an ExampleTestsUtils.cs file with several methods for Setup for tests.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/99

2.6.0
=====
- Optimize for a check on section name if it is empty in the GoogleAdsConfig class.
- Add a specialized ConfigSetting class named StringConfigSetting for string
 settings, so its parsing can be bypassed. Switch all string-based setting parsing to this type in
 the GoogleAdsConfig class.
- Expose the Dictionary constructor in the base class at GoogleAdsConfig level.
- Improve how DEFAULT_TIMEOUT is represented in GoogleAdsConfig class.
- Eliminate the provision to use user CallSettings.
- Eliminate reflection in creating service, instead use specific autogenerated methods to create
 the service settings.
- Add an explicit dependency on Google.Protobuf so we can use a newer version than what Gax.Grpc uses.
- Bump all nuget dependencies to the latest versions.
- Remove deprecated PackageLicenseUrl setting from Google.Ads.GoogleAds.csproj, and replace it with
 PackageLicenseExpression setting instead.
- Update AddHotelAd.cs example to change the AdGroupAd status to be Enabled.

2.5.0
=====
- Added support for Google Ads API v2.2. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#220_beta_2019-09-25
- Fix the namespace for OAuth2Flow enum.
- Fix the CachedChannelFactory so that various grpc settings work as intended.
- Add a fix to check for null values of LoginCustomerId.
- Minor code refactor to improve how the GoogleAdsServiceClientFactory class handles LoginCustomerId
 setting.
- Fix a bug in ExampleRunner around running code examples multiple times.
- Fix a broken web.config for the AuthenticateInWebApplication example.
- Bump all the external library dependencies to their latest versions. Grpc.Core is still on 1.22.1
 since its 2.x version is breaking in nature. See
 https://github.com/grpc/proposal/blob/master/L57-csharp-new-major-version.md for additional context.
- Added a few internal properties and methods for better testing of the client library.


2.4.0
=====
- Added support for Google Ads API v2.1. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#210_beta_2019-08-08
- Added Channel Caching
- Fixed Partial failure support for Google.Ads.GoogleAds.Logging.LoggingInterceptor
- Updated Timeouts to align with server-side configuration
- Added ability to override call settings
- Increase grpc.max_metadata_size to 16MB and grpc.max_receive_message_length to 64MB
- LRO Credential bug fixed

2.3.0
=====
- Added support for Google Ads API v2.0. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#200_2019-06-26

2.2.0
=====
- Fixed https://github.com/googleads/google-ads-dotnet/issues/98
- Fixed https://github.com/googleads/google-ads-dotnet/issues/97
- Fixed https://github.com/googleads/google-ads-dotnet/issues/96
- Fixed https://github.com/googleads/google-ads-dotnet/issues/95
- Fixed https://github.com/googleads/google-ads-dotnet/issues/94
- Fixed https://github.com/googleads/google-ads-dotnet/issues/93
- Fixed https://github.com/googleads/google-ads-dotnet/issues/86
- Fixed https://github.com/googleads/google-ads-dotnet/issues/82
- Added new examples
  -- CampaignManagement/AddCampaignDraft.cs
  -- CampaignManagement/CreateCampaignExperiment.cs
  -- AdvancedOperations/AddGmailAd.cs
  -- AccountManagement/LinkManagerToClient.cs
  -- AdvancedOperations/AddDynamicPageFeed.cs
  -- AdvancedOperations/AddDynamicSearchAds.cs
- Updated the API to allow users to specify their own custom callsettings when creating a service.
- Ported HttpUtilities and MediaUtilities from the AdWords API library. These utilities simplify
 code when working with Media assets.


2.1.0
=====
- Added support for Google Ads API v1.3. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#130_2019-05-22
- Increased the default timeout for services to 120 seconds.
- Made a change to generate logs only if appropriate logging levels are set.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/59.

2.0.0
=====
- Added support for Google Ads API v1.2 See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#120_2019-04-29
- Removed support for Google Ads API v0. See sunset announcement:
 https://ads-developers.googleblog.com/2019/03/upgrade-to-new-google-ads-api-to-get.html
- Made a major version bump due to removal of support for v0.
- Updated all nuget dependencies to the latest stable versions.

1.1.0
=====
- Added support for Google Ads API v1.1 See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#110_2019-03-27

1.0.0
=====
- Added support for Google Ads API v1.0 See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#100_2019-02-27

0.8.1
=====
- Fixed an issue with login-customer-id header not being sent correctly to the server.

0.8.0
=====

Added support for Google Ads API v0.7. See release notes:
https://developers.google.com/google-ads/api/docs/release-notes#070_2019-01-30
- Added new code examples.
    -- HotelAds/GetHotelAdsPerformance.cs
- Removed code example.
    --  CampaignManagement/AddCampaignGroup.cs
- Updated code examples.
    -- Reporting/GetKeywordStats.cs now uses segments.date field instead of fields date.
- Added new overloaded methods for all services that use validateOnly and partialFailure headers as
 optional parameters.

0.7.1
=====

- Added support for running code examples from command line.
- Fixed minor errors with the README.md file.
- Made minor fixes to LogEntry tests.
- Fixed https://github.com/googleads/google-ads-dotnet/issues/40
- Fixed https://github.com/googleads/google-ads-dotnet/issues/39
- Fixed https://github.com/googleads/google-ads-dotnet/issues/31
- Fixed https://github.com/googleads/google-ads-dotnet/issues/30
- Fixed https://github.com/googleads/google-ads-dotnet/issues/28
- Fixed https://github.com/googleads/google-ads-dotnet/issues/27
- Fixed https://github.com/googleads/google-ads-dotnet/issues/26
- Added new code examples.
    -- AccountManagement/GetAccessibleCustomers.cs
    -- Recommendations/DismissRecommendation.cs
    -- AccountManagement/CreateCustomer.cs
    -- Planning/GenerateKeywordIdeas.cs
    -- Planning/AddKeywordPlan.cs
    -- Planning/GenerateForecastMetrics.cs
- Fixed a file encoding issue with Targeting/AddCampaignTargetingCriteria.cs example.

0.7.0
=====

- Added support for Google Ads API v0.6. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#060_2018-11-29

0.6.0
=====

- Added support for Google Ads API v0.5. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#050_2018-10-31

0.5.1
=====

- Testing an new release process.

0.5.0
=====

- Added support for Google Ads API v0.4. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#040_2018-09-21.
- New code examples were added to illustrate shopping campaigns, billing and retrieving account
 changes.
- Updated nuget package references for Grpc.Core, Google.Apis.Auth and Moq to the latest version.

0.4.0
=====

- Added support for Google Ads API v0.3. See release notes:
 https://developers.google.com/google-ads/api/docs/release-notes#030_2018-08-29.
- New code examples were added to illustrate shared keyword sets, campaign groups and campaign
 bid modifiers.
- Added support for logging of API requests and responses.
- Reformatted the code to match Microsoft's C# coding conventions:
 https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions
- Updated nuget package references for Grpc.Core and Google.Api.Gax.Grpc to the latest version.
- Refactored service creation logic.

0.3.0
=====

- Added support for PercentCpc bidding strategy.
- Updated the Hotel Ads example to use PercentCpc bidding strategy.
- Added an explicit dependency on Grpc.Core as a workaround to
 https://github.com/grpc/grpc/issues/11279.

0.2.0
=====

- Added support for Hotel Ads and Recommendations.
- Cleaned up and enabled authentication examples.
- Updated Google.Api.Gax.Grpc dependency to 2.4.0.
- Updated System.Configuration.ConfigurationManager dependency to 4.5.0.

0.1.0
=====

- Added support for V0 of Google Ads API.
