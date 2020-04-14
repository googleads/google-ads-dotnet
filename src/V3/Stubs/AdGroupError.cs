// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/ad_group_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/ad_group_error.proto</summary>
  public static partial class AdGroupErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/ad_group_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvYWRfZ3JvdXBfZXJy",
            "b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVycm9ycxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLZBAoQQWRHcm91cEVycm9yRW51",
            "bSLEBAoMQWRHcm91cEVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEhoKFkRVUExJQ0FURV9BREdST1VQX05BTUUQAhIYChRJTlZBTElEX0FE",
            "R1JPVVBfTkFNRRADEiUKIUFEVkVSVElTRVJfTk9UX09OX0NPTlRFTlRfTkVU",
            "V09SSxAFEg8KC0JJRF9UT09fQklHEAYSKgomQklEX1RZUEVfQU5EX0JJRERJ",
            "TkdfU1RSQVRFR1lfTUlTTUFUQ0gQBxIYChRNSVNTSU5HX0FER1JPVVBfTkFN",
            "RRAIEiAKHEFER1JPVVBfTEFCRUxfRE9FU19OT1RfRVhJU1QQCRIgChxBREdS",
            "T1VQX0xBQkVMX0FMUkVBRFlfRVhJU1RTEAoSLAooSU5WQUxJRF9DT05URU5U",
            "X0JJRF9DUklURVJJT05fVFlQRV9HUk9VUBALEjgKNEFEX0dST1VQX1RZUEVf",
            "Tk9UX1ZBTElEX0ZPUl9BRFZFUlRJU0lOR19DSEFOTkVMX1RZUEUQDBI5CjVB",
            "REdST1VQX1RZUEVfTk9UX1NVUFBPUlRFRF9GT1JfQ0FNUEFJR05fU0FMRVNf",
            "Q09VTlRSWRANEkIKPkNBTk5PVF9BRERfQURHUk9VUF9PRl9UWVBFX0RTQV9U",
            "T19DQU1QQUlHTl9XSVRIT1VUX0RTQV9TRVRUSU5HEA4SNwozUFJPTU9URURf",
            "SE9URUxfQURfR1JPVVBTX05PVF9BVkFJTEFCTEVfRk9SX0NVU1RPTUVSEA9C",
            "7AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lcnJvcnNCEUFkR3Jv",
            "dXBFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9lcnJvcnM7ZXJyb3JzogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuRXJyb3JzygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjNcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjM6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.AdGroupErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.AdGroupErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.AdGroupErrorEnum.Types.AdGroupError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group errors.
  /// </summary>
  public sealed partial class AdGroupErrorEnum : pb::IMessage<AdGroupErrorEnum> {
    private static readonly pb::MessageParser<AdGroupErrorEnum> _parser = new pb::MessageParser<AdGroupErrorEnum>(() => new AdGroupErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.AdGroupErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupErrorEnum(AdGroupErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupErrorEnum Clone() {
      return new AdGroupErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupErrorEnum other) {
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
    public void MergeFrom(AdGroupErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group errors.
      /// </summary>
      public enum AdGroupError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// AdGroup with the same name already exists for the campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ADGROUP_NAME")] DuplicateAdgroupName = 2,
        /// <summary>
        /// AdGroup name is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_ADGROUP_NAME")] InvalidAdgroupName = 3,
        /// <summary>
        /// Advertiser is not allowed to target sites or set site bids that are not
        /// on the Google Search Network.
        /// </summary>
        [pbr::OriginalName("ADVERTISER_NOT_ON_CONTENT_NETWORK")] AdvertiserNotOnContentNetwork = 5,
        /// <summary>
        /// Bid amount is too big.
        /// </summary>
        [pbr::OriginalName("BID_TOO_BIG")] BidTooBig = 6,
        /// <summary>
        /// AdGroup bid does not match the campaign's bidding strategy.
        /// </summary>
        [pbr::OriginalName("BID_TYPE_AND_BIDDING_STRATEGY_MISMATCH")] BidTypeAndBiddingStrategyMismatch = 7,
        /// <summary>
        /// AdGroup name is required for Add.
        /// </summary>
        [pbr::OriginalName("MISSING_ADGROUP_NAME")] MissingAdgroupName = 8,
        /// <summary>
        /// No link found between the ad group and the label.
        /// </summary>
        [pbr::OriginalName("ADGROUP_LABEL_DOES_NOT_EXIST")] AdgroupLabelDoesNotExist = 9,
        /// <summary>
        /// The label has already been attached to the ad group.
        /// </summary>
        [pbr::OriginalName("ADGROUP_LABEL_ALREADY_EXISTS")] AdgroupLabelAlreadyExists = 10,
        /// <summary>
        /// The CriterionTypeGroup is not supported for the content bid dimension.
        /// </summary>
        [pbr::OriginalName("INVALID_CONTENT_BID_CRITERION_TYPE_GROUP")] InvalidContentBidCriterionTypeGroup = 11,
        /// <summary>
        /// The ad group type is not compatible with the campaign channel type.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_TYPE_NOT_VALID_FOR_ADVERTISING_CHANNEL_TYPE")] AdGroupTypeNotValidForAdvertisingChannelType = 12,
        /// <summary>
        /// The ad group type is not supported in the country of sale of the
        /// campaign.
        /// </summary>
        [pbr::OriginalName("ADGROUP_TYPE_NOT_SUPPORTED_FOR_CAMPAIGN_SALES_COUNTRY")] AdgroupTypeNotSupportedForCampaignSalesCountry = 13,
        /// <summary>
        /// Ad groups of AdGroupType.SEARCH_DYNAMIC_ADS can only be added to
        /// campaigns that have DynamicSearchAdsSetting attached.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_ADGROUP_OF_TYPE_DSA_TO_CAMPAIGN_WITHOUT_DSA_SETTING")] CannotAddAdgroupOfTypeDsaToCampaignWithoutDsaSetting = 14,
        /// <summary>
        /// Promoted hotels ad groups are only available to whitelisted customers.
        /// </summary>
        [pbr::OriginalName("PROMOTED_HOTEL_AD_GROUPS_NOT_AVAILABLE_FOR_CUSTOMER")] PromotedHotelAdGroupsNotAvailableForCustomer = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
