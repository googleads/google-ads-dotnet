// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/campaign_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/campaign_error.proto</summary>
  public static partial class CampaignErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/campaign_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvY2FtcGFpZ25fZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9ycyLyCwoR",
            "Q2FtcGFpZ25FcnJvckVudW0i3AsKDUNhbXBhaWduRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESIQodQ0FOTk9UX1RBUkdFVF9DT05URU5U",
            "X05FVFdPUksQAxIgChxDQU5OT1RfVEFSR0VUX1NFQVJDSF9ORVRXT1JLEAQS",
            "NgoyQ0FOTk9UX1RBUkdFVF9TRUFSQ0hfTkVUV09SS19XSVRIT1VUX0dPT0dM",
            "RV9TRUFSQ0gQBRIwCixDQU5OT1RfVEFSR0VUX0dPT0dMRV9TRUFSQ0hfRk9S",
            "X0NQTV9DQU1QQUlHThAGEi0KKUNBTVBBSUdOX01VU1RfVEFSR0VUX0FUX0xF",
            "QVNUX09ORV9ORVRXT1JLEAcSKAokQ0FOTk9UX1RBUkdFVF9QQVJUTkVSX1NF",
            "QVJDSF9ORVRXT1JLEAgSSwpHQ0FOTk9UX1RBUkdFVF9DT05URU5UX05FVFdP",
            "UktfT05MWV9XSVRIX0NSSVRFUklBX0xFVkVMX0JJRERJTkdfU1RSQVRFR1kQ",
            "CRI2CjJDQU1QQUlHTl9EVVJBVElPTl9NVVNUX0NPTlRBSU5fQUxMX1JVTk5B",
            "QkxFX1RSSUFMUxAKEiQKIENBTk5PVF9NT0RJRllfRk9SX1RSSUFMX0NBTVBB",
            "SUdOEAsSGwoXRFVQTElDQVRFX0NBTVBBSUdOX05BTUUQDBIfChtJTkNPTVBB",
            "VElCTEVfQ0FNUEFJR05fRklFTEQQDRIZChVJTlZBTElEX0NBTVBBSUdOX05B",
            "TUUQDhIqCiZJTlZBTElEX0FEX1NFUlZJTkdfT1BUSU1JWkFUSU9OX1NUQVRV",
            "UxAPEhgKFElOVkFMSURfVFJBQ0tJTkdfVVJMEBASPgo6Q0FOTk9UX1NFVF9C",
            "T1RIX1RSQUNLSU5HX1VSTF9URU1QTEFURV9BTkRfVFJBQ0tJTkdfU0VUVElO",
            "RxAREiAKHE1BWF9JTVBSRVNTSU9OU19OT1RfSU5fUkFOR0UQEhIbChdUSU1F",
            "X1VOSVRfTk9UX1NVUFBPUlRFRBATEjEKLUlOVkFMSURfT1BFUkFUSU9OX0lG",
            "X1NFUlZJTkdfU1RBVFVTX0hBU19FTkRFRBAUEhsKF0JVREdFVF9DQU5OT1Rf",
            "QkVfU0hBUkVEEBUSJQohQ0FNUEFJR05fQ0FOTk9UX1VTRV9TSEFSRURfQlVE",
            "R0VUEBYSMAosQ0FOTk9UX0NIQU5HRV9CVURHRVRfT05fQ0FNUEFJR05fV0lU",
            "SF9UUklBTFMQFxIhCh1DQU1QQUlHTl9MQUJFTF9ET0VTX05PVF9FWElTVBAY",
            "EiEKHUNBTVBBSUdOX0xBQkVMX0FMUkVBRFlfRVhJU1RTEBkSHAoYTUlTU0lO",
            "R19TSE9QUElOR19TRVRUSU5HEBoSIgoeSU5WQUxJRF9TSE9QUElOR19TQUxF",
            "U19DT1VOVFJZEBsSOQo1U0hPUFBJTkdfTUVSQ0hBTlRfTk9UX0FMTE9XRURf",
            "Rk9SX1BVUkNIQVNFU19PTl9HT09HTEUQHBJACjxQVVJDSEFTRVNfT05fR09P",
            "R0xFX05PVF9TVVBQT1JURURfRk9SX1NIT1BQSU5HX1NBTEVTX0NPVU5UUlkQ",
            "HRIqCiZNSVNTSU5HX1VOSVZFUlNBTF9BUFBfQ0FNUEFJR05fU0VUVElORxAe",
            "EjsKN0FEVkVSVElTSU5HX0NIQU5ORUxfVFlQRV9OT1RfQVZBSUxBQkxFX0ZP",
            "Ul9BQ0NPVU5UX1RZUEUQHxIoCiRJTlZBTElEX0FEVkVSVElTSU5HX0NIQU5O",
            "RUxfU1VCX1RZUEUQIBIsCihBVF9MRUFTVF9PTkVfQ09OVkVSU0lPTl9NVVNU",
            "X0JFX1NFTEVDVEVEECESHwobQ0FOTk9UX1NFVF9BRF9ST1RBVElPTl9NT0RF",
            "ECISLworQ0FOTk9UX01PRElGWV9TVEFSVF9EQVRFX0lGX0FMUkVBRFlfU1RB",
            "UlRFRBAjEhsKF0NBTk5PVF9TRVRfREFURV9UT19QQVNUECRCyAEKImNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MC5lcnJvcnNCEkNhbXBhaWduRXJyb3JQ",
            "cm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYwXEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.CampaignErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.CampaignErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.CampaignErrorEnum.Types.CampaignError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign errors.
  /// </summary>
  public sealed partial class CampaignErrorEnum : pb::IMessage<CampaignErrorEnum> {
    private static readonly pb::MessageParser<CampaignErrorEnum> _parser = new pb::MessageParser<CampaignErrorEnum>(() => new CampaignErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.CampaignErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignErrorEnum(CampaignErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignErrorEnum Clone() {
      return new CampaignErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CampaignErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign errors.
      /// </summary>
      public enum CampaignError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot target content network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK")] CannotTargetContentNetwork = 3,
        /// <summary>
        /// Cannot target search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK")] CannotTargetSearchNetwork = 4,
        /// <summary>
        /// Cannot cover search network without google search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_SEARCH_NETWORK_WITHOUT_GOOGLE_SEARCH")] CannotTargetSearchNetworkWithoutGoogleSearch = 5,
        /// <summary>
        /// Cannot target Google Search network for a CPM campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_GOOGLE_SEARCH_FOR_CPM_CAMPAIGN")] CannotTargetGoogleSearchForCpmCampaign = 6,
        /// <summary>
        /// Must target at least one network.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_MUST_TARGET_AT_LEAST_ONE_NETWORK")] CampaignMustTargetAtLeastOneNetwork = 7,
        /// <summary>
        /// Only some Google partners are allowed to target partner search network.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_PARTNER_SEARCH_NETWORK")] CannotTargetPartnerSearchNetwork = 8,
        /// <summary>
        /// Cannot target content network only as campaign has criteria-level bidding
        /// strategy.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CRITERIA_LEVEL_BIDDING_STRATEGY")] CannotTargetContentNetworkOnlyWithCriteriaLevelBiddingStrategy = 9,
        /// <summary>
        /// Cannot modify the start or end date such that the campaign duration would
        /// not contain the durations of all runnable trials.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_DURATION_MUST_CONTAIN_ALL_RUNNABLE_TRIALS")] CampaignDurationMustContainAllRunnableTrials = 10,
        /// <summary>
        /// Cannot modify dates, budget or campaign name of a trial campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FOR_TRIAL_CAMPAIGN")] CannotModifyForTrialCampaign = 11,
        /// <summary>
        /// Trying to modify the name of an active or paused campaign, where the name
        /// is already assigned to another active or paused campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CAMPAIGN_NAME")] DuplicateCampaignName = 12,
        /// <summary>
        /// Two fields are in conflicting modes.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_CAMPAIGN_FIELD")] IncompatibleCampaignField = 13,
        /// <summary>
        /// Campaign name cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_CAMPAIGN_NAME")] InvalidCampaignName = 14,
        /// <summary>
        /// Given status is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_AD_SERVING_OPTIMIZATION_STATUS")] InvalidAdServingOptimizationStatus = 15,
        /// <summary>
        /// Error in the campaign level tracking url.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL")] InvalidTrackingUrl = 16,
        /// <summary>
        /// Cannot set both tracking url template and tracking setting. An user has
        /// to clear legacy tracking setting in order to add tracking url template.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BOTH_TRACKING_URL_TEMPLATE_AND_TRACKING_SETTING")] CannotSetBothTrackingUrlTemplateAndTrackingSetting = 17,
        /// <summary>
        /// The maximum number of impressions for Frequency Cap should be an integer
        /// greater than 0.
        /// </summary>
        [pbr::OriginalName("MAX_IMPRESSIONS_NOT_IN_RANGE")] MaxImpressionsNotInRange = 18,
        /// <summary>
        /// Only the Day, Week and Month time units are supported.
        /// </summary>
        [pbr::OriginalName("TIME_UNIT_NOT_SUPPORTED")] TimeUnitNotSupported = 19,
        /// <summary>
        /// Operation not allowed on a campaign whose serving status has ended
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATION_IF_SERVING_STATUS_HAS_ENDED")] InvalidOperationIfServingStatusHasEnded = 20,
        /// <summary>
        /// This budget is exclusively linked to a Campaign that is using experiments
        /// so it cannot be shared.
        /// </summary>
        [pbr::OriginalName("BUDGET_CANNOT_BE_SHARED")] BudgetCannotBeShared = 21,
        /// <summary>
        /// Campaigns using experiments cannot use a shared budget.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_USE_SHARED_BUDGET")] CampaignCannotUseSharedBudget = 22,
        /// <summary>
        /// A different budget cannot be assigned to a campaign when there are
        /// running or scheduled trials.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_BUDGET_ON_CAMPAIGN_WITH_TRIALS")] CannotChangeBudgetOnCampaignWithTrials = 23,
        /// <summary>
        /// No link found between the campaign and the label.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_DOES_NOT_EXIST")] CampaignLabelDoesNotExist = 24,
        /// <summary>
        /// The label has already been attached to the campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_LABEL_ALREADY_EXISTS")] CampaignLabelAlreadyExists = 25,
        /// <summary>
        /// A ShoppingSetting was not found when creating a shopping campaign.
        /// </summary>
        [pbr::OriginalName("MISSING_SHOPPING_SETTING")] MissingShoppingSetting = 26,
        /// <summary>
        /// The country in shopping setting is not an allowed country.
        /// </summary>
        [pbr::OriginalName("INVALID_SHOPPING_SALES_COUNTRY")] InvalidShoppingSalesCountry = 27,
        /// <summary>
        /// Shopping merchant is not enabled for Purchases on Google.
        /// </summary>
        [pbr::OriginalName("SHOPPING_MERCHANT_NOT_ALLOWED_FOR_PURCHASES_ON_GOOGLE")] ShoppingMerchantNotAllowedForPurchasesOnGoogle = 28,
        /// <summary>
        /// Purchases on Google not enabled for the shopping campaign's sales
        /// country.
        /// </summary>
        [pbr::OriginalName("PURCHASES_ON_GOOGLE_NOT_SUPPORTED_FOR_SHOPPING_SALES_COUNTRY")] PurchasesOnGoogleNotSupportedForShoppingSalesCountry = 29,
        /// <summary>
        /// A Campaign with channel sub type UNIVERSAL_APP_CAMPAIGN must have a
        /// UniversalAppCampaignSetting specified.
        /// </summary>
        [pbr::OriginalName("MISSING_UNIVERSAL_APP_CAMPAIGN_SETTING")] MissingUniversalAppCampaignSetting = 30,
        /// <summary>
        /// The requested channel type is not available according to the customer's
        /// account setting.
        /// </summary>
        [pbr::OriginalName("ADVERTISING_CHANNEL_TYPE_NOT_AVAILABLE_FOR_ACCOUNT_TYPE")] AdvertisingChannelTypeNotAvailableForAccountType = 31,
        /// <summary>
        /// The AdvertisingChannelSubType is not a valid subtype of the primary
        /// channel type.
        /// </summary>
        [pbr::OriginalName("INVALID_ADVERTISING_CHANNEL_SUB_TYPE")] InvalidAdvertisingChannelSubType = 32,
        /// <summary>
        /// At least one conversion must be selected.
        /// </summary>
        [pbr::OriginalName("AT_LEAST_ONE_CONVERSION_MUST_BE_SELECTED")] AtLeastOneConversionMustBeSelected = 33,
        /// <summary>
        /// Setting ad rotation mode for a campaign is not allowed. Ad rotation mode
        /// at campaign is deprecated.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_AD_ROTATION_MODE")] CannotSetAdRotationMode = 34,
        /// <summary>
        /// Trying to change start date on a campaign that has started.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED")] CannotModifyStartDateIfAlreadyStarted = 35,
        /// <summary>
        /// Trying to modify a date into the past.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_DATE_TO_PAST")] CannotSetDateToPast = 36,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
