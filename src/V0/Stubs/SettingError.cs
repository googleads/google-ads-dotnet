// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/setting_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/setting_error.proto</summary>
  public static partial class SettingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/setting_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SettingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvc2V0dGluZ19lcnJv",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJyb3JzIr4IChBT",
            "ZXR0aW5nRXJyb3JFbnVtIqkICgxTZXR0aW5nRXJyb3ISDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESIQodU0VUVElOR19UWVBFX0lTX05PVF9BVkFJ",
            "TEFCTEUQAxIwCixTRVRUSU5HX1RZUEVfSVNfTk9UX0NPTVBBVElCTEVfV0lU",
            "SF9DQU1QQUlHThAEEjsKN1RBUkdFVElOR19TRVRUSU5HX0NPTlRBSU5TX0lO",
            "VkFMSURfQ1JJVEVSSU9OX1RZUEVfR1JPVVAQBRJRCk1UQVJHRVRJTkdfU0VU",
            "VElOR19ERU1PR1JBUEhJQ19DUklURVJJT05fVFlQRV9HUk9VUFNfTVVTVF9C",
            "RV9TRVRfVE9fVEFSR0VUX0FMTBAGElwKWFRBUkdFVElOR19TRVRUSU5HX0NB",
            "Tk5PVF9DSEFOR0VfVEFSR0VUX0FMTF9UT19GQUxTRV9GT1JfREVNT0dSQVBI",
            "SUNfQ1JJVEVSSU9OX1RZUEVfR1JPVVAQBxJDCj9EWU5BTUlDX1NFQVJDSF9B",
            "RFNfU0VUVElOR19BVF9MRUFTVF9PTkVfRkVFRF9JRF9NVVNUX0JFX1BSRVNF",
            "TlQQCBI7CjdEWU5BTUlDX1NFQVJDSF9BRFNfU0VUVElOR19DT05UQUlOU19J",
            "TlZBTElEX0RPTUFJTl9OQU1FEAkSNgoyRFlOQU1JQ19TRUFSQ0hfQURTX1NF",
            "VFRJTkdfQ09OVEFJTlNfU1VCRE9NQUlOX05BTUUQChI9CjlEWU5BTUlDX1NF",
            "QVJDSF9BRFNfU0VUVElOR19DT05UQUlOU19JTlZBTElEX0xBTkdVQUdFX0NP",
            "REUQCxI+CjpUQVJHRVRfQUxMX0lTX05PVF9BTExPV0VEX0ZPUl9QTEFDRU1F",
            "TlRfSU5fU0VBUkNIX0NBTVBBSUdOEAwSOAo0VU5JVkVSU0FMX0FQUF9DQU1Q",
            "QUlHTl9TRVRUSU5HX0RVUExJQ0FURV9ERVNDUklQVElPThANEkIKPlVOSVZF",
            "UlNBTF9BUFBfQ0FNUEFJR05fU0VUVElOR19ERVNDUklQVElPTl9MSU5FX1dJ",
            "RFRIX1RPT19MT05HEA4SPAo4VU5JVkVSU0FMX0FQUF9DQU1QQUlHTl9TRVRU",
            "SU5HX0FQUF9JRF9DQU5OT1RfQkVfTU9ESUZJRUQQDxI4CjRUT09fTUFOWV9Z",
            "T1VUVUJFX01FRElBX0lEU19JTl9VTklWRVJTQUxfQVBQX0NBTVBBSUdOEBAS",
            "NgoyVE9PX01BTllfSU1BR0VfTUVESUFfSURTX0lOX1VOSVZFUlNBTF9BUFBf",
            "Q0FNUEFJR04QERIxCi1NRURJQV9JTkNPTVBBVElCTEVfRk9SX1VOSVZFUlNB",
            "TF9BUFBfQ0FNUEFJR04QEhIeChpUT09fTUFOWV9FWENMQU1BVElPTl9NQVJL",
            "UxATQuwBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJyb3JzQhFT",
            "ZXR0aW5nRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6IC",
            "A0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYwXEVycm9yc+oCIkdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYwOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.SettingErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.SettingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.SettingErrorEnum.Types.SettingError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible setting errors.
  /// </summary>
  public sealed partial class SettingErrorEnum : pb::IMessage<SettingErrorEnum> {
    private static readonly pb::MessageParser<SettingErrorEnum> _parser = new pb::MessageParser<SettingErrorEnum>(() => new SettingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SettingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.SettingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SettingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SettingErrorEnum(SettingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SettingErrorEnum Clone() {
      return new SettingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SettingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SettingErrorEnum other) {
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
    public void MergeFrom(SettingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the SettingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible setting errors.
      /// </summary>
      public enum SettingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign setting is not available for this Google Ads account.
        /// </summary>
        [pbr::OriginalName("SETTING_TYPE_IS_NOT_AVAILABLE")] SettingTypeIsNotAvailable = 3,
        /// <summary>
        /// The setting is not compatible with the campaign.
        /// </summary>
        [pbr::OriginalName("SETTING_TYPE_IS_NOT_COMPATIBLE_WITH_CAMPAIGN")] SettingTypeIsNotCompatibleWithCampaign = 4,
        /// <summary>
        /// The supplied TargetingSetting contains an invalid CriterionTypeGroup. See
        /// CriterionTypeGroup documentation for CriterionTypeGroups allowed
        /// in Campaign or AdGroup TargetingSettings.
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_CONTAINS_INVALID_CRITERION_TYPE_GROUP")] TargetingSettingContainsInvalidCriterionTypeGroup = 5,
        /// <summary>
        /// TargetingSetting must not explicitly
        /// set any of the Demographic CriterionTypeGroups (AGE_RANGE, GENDER,
        /// PARENT, INCOME_RANGE) to false (it's okay to not set them at all, in
        /// which case the system will set them to true automatically).
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_DEMOGRAPHIC_CRITERION_TYPE_GROUPS_MUST_BE_SET_TO_TARGET_ALL")] TargetingSettingDemographicCriterionTypeGroupsMustBeSetToTargetAll = 6,
        /// <summary>
        /// TargetingSetting cannot change any of
        /// the Demographic CriterionTypeGroups (AGE_RANGE, GENDER, PARENT,
        /// INCOME_RANGE) from true to false.
        /// </summary>
        [pbr::OriginalName("TARGETING_SETTING_CANNOT_CHANGE_TARGET_ALL_TO_FALSE_FOR_DEMOGRAPHIC_CRITERION_TYPE_GROUP")] TargetingSettingCannotChangeTargetAllToFalseForDemographicCriterionTypeGroup = 7,
        /// <summary>
        /// At least one feed id should be present.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_AT_LEAST_ONE_FEED_ID_MUST_BE_PRESENT")] DynamicSearchAdsSettingAtLeastOneFeedIdMustBePresent = 8,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains an invalid domain name.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_DOMAIN_NAME")] DynamicSearchAdsSettingContainsInvalidDomainName = 9,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains a subdomain name.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_SUBDOMAIN_NAME")] DynamicSearchAdsSettingContainsSubdomainName = 10,
        /// <summary>
        /// The supplied DynamicSearchAdsSetting contains an invalid language code.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_ADS_SETTING_CONTAINS_INVALID_LANGUAGE_CODE")] DynamicSearchAdsSettingContainsInvalidLanguageCode = 11,
        /// <summary>
        /// TargetingSettings in search campaigns should not have
        /// CriterionTypeGroup.PLACEMENT set to targetAll.
        /// </summary>
        [pbr::OriginalName("TARGET_ALL_IS_NOT_ALLOWED_FOR_PLACEMENT_IN_SEARCH_CAMPAIGN")] TargetAllIsNotAllowedForPlacementInSearchCampaign = 12,
        /// <summary>
        /// Duplicate description in universal app setting description field.
        /// </summary>
        [pbr::OriginalName("UNIVERSAL_APP_CAMPAIGN_SETTING_DUPLICATE_DESCRIPTION")] UniversalAppCampaignSettingDuplicateDescription = 13,
        /// <summary>
        /// Description line width is too long in universal app setting description
        /// field.
        /// </summary>
        [pbr::OriginalName("UNIVERSAL_APP_CAMPAIGN_SETTING_DESCRIPTION_LINE_WIDTH_TOO_LONG")] UniversalAppCampaignSettingDescriptionLineWidthTooLong = 14,
        /// <summary>
        /// Universal app setting appId field cannot be modified for COMPLETE
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("UNIVERSAL_APP_CAMPAIGN_SETTING_APP_ID_CANNOT_BE_MODIFIED")] UniversalAppCampaignSettingAppIdCannotBeModified = 15,
        /// <summary>
        /// YoutubeVideoMediaIds in universal app setting cannot exceed size limit.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_YOUTUBE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN")] TooManyYoutubeMediaIdsInUniversalAppCampaign = 16,
        /// <summary>
        /// ImageMediaIds in universal app setting cannot exceed size limit.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_IMAGE_MEDIA_IDS_IN_UNIVERSAL_APP_CAMPAIGN")] TooManyImageMediaIdsInUniversalAppCampaign = 17,
        /// <summary>
        /// Media is incompatible for universal app campaign.
        /// </summary>
        [pbr::OriginalName("MEDIA_INCOMPATIBLE_FOR_UNIVERSAL_APP_CAMPAIGN")] MediaIncompatibleForUniversalAppCampaign = 18,
        /// <summary>
        /// Too many exclamation marks in universal app campaign ad text ideas.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_EXCLAMATION_MARKS")] TooManyExclamationMarks = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
