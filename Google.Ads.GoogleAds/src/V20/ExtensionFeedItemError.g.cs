// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/errors/extension_feed_item_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/errors/extension_feed_item_error.proto</summary>
  public static partial class ExtensionFeedItemErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/errors/extension_feed_item_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionFeedItemErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZXJyb3JzL2V4dGVuc2lvbl9m",
            "ZWVkX2l0ZW1fZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "MC5lcnJvcnMi9g0KGkV4dGVuc2lvbkZlZWRJdGVtRXJyb3JFbnVtItcNChZF",
            "eHRlbnNpb25GZWVkSXRlbUVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5L",
            "Tk9XThABEhYKElZBTFVFX09VVF9PRl9SQU5HRRACEhUKEVVSTF9MSVNUX1RP",
            "T19MT05HEAMSMgouQ0FOTk9UX0hBVkVfUkVTVFJJQ1RJT05fT05fRU1QVFlf",
            "R0VPX1RBUkdFVElORxAEEh4KGkNBTk5PVF9TRVRfV0lUSF9GSU5BTF9VUkxT",
            "EAUSIQodQ0FOTk9UX1NFVF9XSVRIT1VUX0ZJTkFMX1VSTFMQBhIYChRJTlZB",
            "TElEX1BIT05FX05VTUJFUhAHEioKJlBIT05FX05VTUJFUl9OT1RfU1VQUE9S",
            "VEVEX0ZPUl9DT1VOVFJZEAgSLQopQ0FSUklFUl9TUEVDSUZJQ19TSE9SVF9O",
            "VU1CRVJfTk9UX0FMTE9XRUQQCRIjCh9QUkVNSVVNX1JBVEVfTlVNQkVSX05P",
            "VF9BTExPV0VEEAoSGgoWRElTQUxMT1dFRF9OVU1CRVJfVFlQRRALEigKJElO",
            "VkFMSURfRE9NRVNUSUNfUEhPTkVfTlVNQkVSX0ZPUk1BVBAMEiMKH1ZBTklU",
            "WV9QSE9ORV9OVU1CRVJfTk9UX0FMTE9XRUQQDRIiCh5JTlZBTElEX0NBTExf",
            "Q09OVkVSU0lPTl9BQ1RJT04QDhIuCipDVVNUT01FUl9OT1RfT05fQUxMT1dM",
            "SVNUX0ZPUl9DQUxMVFJBQ0tJTkcQLxIqCiZDQUxMVFJBQ0tJTkdfTk9UX1NV",
            "UFBPUlRFRF9GT1JfQ09VTlRSWRAQEjAKLENVU1RPTUVSX0NPTlNFTlRfRk9S",
            "X0NBTExfUkVDT1JESU5HX1JFUVVJUkVEEBESEgoOSU5WQUxJRF9BUFBfSUQQ",
            "EhImCiJRVU9URVNfSU5fUkVWSUVXX0VYVEVOU0lPTl9TTklQUEVUEBMSJwoj",
            "SFlQSEVOU19JTl9SRVZJRVdfRVhURU5TSU9OX1NOSVBQRVQQFBImCiJSRVZJ",
            "RVdfRVhURU5TSU9OX1NPVVJDRV9JTkVMSUdJQkxFEBUSKAokU09VUkNFX05B",
            "TUVfSU5fUkVWSUVXX0VYVEVOU0lPTl9URVhUEBYSHwobSU5DT05TSVNURU5U",
            "X0NVUlJFTkNZX0NPREVTEBcSKgomUFJJQ0VfRVhURU5TSU9OX0hBU19EVVBM",
            "SUNBVEVEX0hFQURFUlMQGBI0CjBQUklDRV9JVEVNX0hBU19EVVBMSUNBVEVE",
            "X0hFQURFUl9BTkRfREVTQ1JJUFRJT04QGRIlCiFQUklDRV9FWFRFTlNJT05f",
            "SEFTX1RPT19GRVdfSVRFTVMQGhImCiJQUklDRV9FWFRFTlNJT05fSEFTX1RP",
            "T19NQU5ZX0lURU1TEBsSFQoRVU5TVVBQT1JURURfVkFMVUUQHBIqCiZVTlNV",
            "UFBPUlRFRF9WQUxVRV9JTl9TRUxFQ1RFRF9MQU5HVUFHRRAdEh0KGUlOVkFM",
            "SURfREVWSUNFX1BSRUZFUkVOQ0UQHhIYChRJTlZBTElEX1NDSEVEVUxFX0VO",
            "RBAfEioKJkRBVEVfVElNRV9NVVNUX0JFX0lOX0FDQ09VTlRfVElNRV9aT05F",
            "ECASGwoXSU5WQUxJRF9TTklQUEVUU19IRUFERVIQIRInCiNDQU5OT1RfT1BF",
            "UkFURV9PTl9SRU1PVkVEX0ZFRURfSVRFTRAiEjwKOFBIT05FX05VTUJFUl9O",
            "T1RfU1VQUE9SVEVEX1dJVEhfQ0FMTFRSQUNLSU5HX0ZPUl9DT1VOVFJZECMS",
            "KAokQ09ORkxJQ1RJTkdfQ0FMTF9DT05WRVJTSU9OX1NFVFRJTkdTECQSGwoX",
            "RVhURU5TSU9OX1RZUEVfTUlTTUFUQ0gQJRIeChpFWFRFTlNJT05fU1VCVFlQ",
            "RV9SRVFVSVJFRBAmEh4KGkVYVEVOU0lPTl9UWVBFX1VOU1VQUE9SVEVEECcS",
            "MQotQ0FOTk9UX09QRVJBVEVfT05fRkVFRF9XSVRIX01VTFRJUExFX01BUFBJ",
            "TkdTECgSLgoqQ0FOTk9UX09QRVJBVEVfT05fRkVFRF9XSVRIX0tFWV9BVFRS",
            "SUJVVEVTECkSGAoUSU5WQUxJRF9QUklDRV9GT1JNQVQQKhIaChZQUk9NT1RJ",
            "T05fSU5WQUxJRF9USU1FECsSJQohVE9PX01BTllfREVDSU1BTF9QTEFDRVNf",
            "U1BFQ0lGSUVEECwSJAogQ09OQ1JFVEVfRVhURU5TSU9OX1RZUEVfUkVRVUlS",
            "RUQQLRIgChxTQ0hFRFVMRV9FTkRfTk9UX0FGVEVSX1NUQVJUEC5C+wEKI2Nv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZXJyb3JzQhtFeHRlbnNpb25G",
            "ZWVkSXRlbUVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9lcnJvcnM7ZXJyb3Jz",
            "ogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIwLkVycm9yc8oCH0dv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxFcnJvcnPqAiNHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMjA6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Errors.ExtensionFeedItemErrorEnum), global::Google.Ads.GoogleAds.V20.Errors.ExtensionFeedItemErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Errors.ExtensionFeedItemErrorEnum.Types.ExtensionFeedItemError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible extension feed item error.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExtensionFeedItemErrorEnum : pb::IMessage<ExtensionFeedItemErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExtensionFeedItemErrorEnum> _parser = new pb::MessageParser<ExtensionFeedItemErrorEnum>(() => new ExtensionFeedItemErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtensionFeedItemErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Errors.ExtensionFeedItemErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionFeedItemErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionFeedItemErrorEnum(ExtensionFeedItemErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionFeedItemErrorEnum Clone() {
      return new ExtensionFeedItemErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExtensionFeedItemErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtensionFeedItemErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExtensionFeedItemErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ExtensionFeedItemErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible extension feed item errors.
      /// </summary>
      public enum ExtensionFeedItemError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Value is not within the accepted range.
        /// </summary>
        [pbr::OriginalName("VALUE_OUT_OF_RANGE")] ValueOutOfRange = 2,
        /// <summary>
        /// Url list is too long.
        /// </summary>
        [pbr::OriginalName("URL_LIST_TOO_LONG")] UrlListTooLong = 3,
        /// <summary>
        /// Cannot have a geo targeting restriction without having geo targeting.
        /// </summary>
        [pbr::OriginalName("CANNOT_HAVE_RESTRICTION_ON_EMPTY_GEO_TARGETING")] CannotHaveRestrictionOnEmptyGeoTargeting = 4,
        /// <summary>
        /// Cannot simultaneously set sitelink field with final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITH_FINAL_URLS")] CannotSetWithFinalUrls = 5,
        /// <summary>
        /// Must set field with final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITHOUT_FINAL_URLS")] CannotSetWithoutFinalUrls = 6,
        /// <summary>
        /// Phone number for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER")] InvalidPhoneNumber = 7,
        /// <summary>
        /// Phone number for a call extension is not supported for the given country
        /// code.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 8,
        /// <summary>
        /// A carrier specific number in short format is not allowed for call
        /// extensions.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 9,
        /// <summary>
        /// Premium rate numbers are not allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 10,
        /// <summary>
        /// Phone number type for a call extension is not allowed.
        /// For example, personal number is not allowed for a call extension in
        /// most regions.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 11,
        /// <summary>
        /// Phone number for a call extension does not meet domestic format
        /// requirements.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] InvalidDomesticPhoneNumberFormat = 12,
        /// <summary>
        /// Vanity phone numbers (for example, those including letters) are not
        /// allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 13,
        /// <summary>
        /// Call conversion action provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_ACTION")] InvalidCallConversionAction = 14,
        /// <summary>
        /// For a call extension, the customer is not on the allow-list for call
        /// tracking.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ON_ALLOWLIST_FOR_CALLTRACKING")] CustomerNotOnAllowlistForCalltracking = 47,
        /// <summary>
        /// Call tracking is not supported for the given country for a call
        /// extension.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 16,
        /// <summary>
        /// Customer hasn't consented for call recording, which is required for
        /// creating/updating call feed items. See
        /// https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 17,
        /// <summary>
        /// App id provided for an app extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 18,
        /// <summary>
        /// Quotation marks present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] QuotesInReviewExtensionSnippet = 19,
        /// <summary>
        /// Hyphen character present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("HYPHENS_IN_REVIEW_EXTENSION_SNIPPET")] HyphensInReviewExtensionSnippet = 20,
        /// <summary>
        /// A denylisted review source name or url was provided for a review
        /// extension.
        /// </summary>
        [pbr::OriginalName("REVIEW_EXTENSION_SOURCE_INELIGIBLE")] ReviewExtensionSourceIneligible = 21,
        /// <summary>
        /// Review source name should not be found in the review text.
        /// </summary>
        [pbr::OriginalName("SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT")] SourceNameInReviewExtensionText = 22,
        /// <summary>
        /// Inconsistent currency codes.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_CURRENCY_CODES")] InconsistentCurrencyCodes = 23,
        /// <summary>
        /// Price extension cannot have duplicated headers.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_DUPLICATED_HEADERS")] PriceExtensionHasDuplicatedHeaders = 24,
        /// <summary>
        /// Price item cannot have duplicated header and description.
        /// </summary>
        [pbr::OriginalName("PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION")] PriceItemHasDuplicatedHeaderAndDescription = 25,
        /// <summary>
        /// Price extension has too few items.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_FEW_ITEMS")] PriceExtensionHasTooFewItems = 26,
        /// <summary>
        /// Price extension has too many items.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_MANY_ITEMS")] PriceExtensionHasTooManyItems = 27,
        /// <summary>
        /// The input value is not currently supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE")] UnsupportedValue = 28,
        /// <summary>
        /// The input value is not currently supported in the selected language of an
        /// extension.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE_IN_SELECTED_LANGUAGE")] UnsupportedValueInSelectedLanguage = 29,
        /// <summary>
        /// Unknown or unsupported device preference.
        /// </summary>
        [pbr::OriginalName("INVALID_DEVICE_PREFERENCE")] InvalidDevicePreference = 30,
        /// <summary>
        /// Invalid feed item schedule end time (for example, endHour = 24 and
        /// endMinute != 0).
        /// </summary>
        [pbr::OriginalName("INVALID_SCHEDULE_END")] InvalidScheduleEnd = 31,
        /// <summary>
        /// Date time zone does not match the account's time zone.
        /// </summary>
        [pbr::OriginalName("DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE")] DateTimeMustBeInAccountTimeZone = 32,
        /// <summary>
        /// Invalid structured snippet header.
        /// </summary>
        [pbr::OriginalName("INVALID_SNIPPETS_HEADER")] InvalidSnippetsHeader = 33,
        /// <summary>
        /// Cannot operate on removed feed item.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_FEED_ITEM")] CannotOperateOnRemovedFeedItem = 34,
        /// <summary>
        /// Phone number not supported when call tracking enabled for country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY")] PhoneNumberNotSupportedWithCalltrackingForCountry = 35,
        /// <summary>
        /// Cannot set call_conversion_action while call_conversion_tracking_enabled
        /// is set to true.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_CALL_CONVERSION_SETTINGS")] ConflictingCallConversionSettings = 36,
        /// <summary>
        /// The type of the input extension feed item doesn't match the existing
        /// extension feed item.
        /// </summary>
        [pbr::OriginalName("EXTENSION_TYPE_MISMATCH")] ExtensionTypeMismatch = 37,
        /// <summary>
        /// The oneof field extension for example, subtype of extension feed item is
        /// required.
        /// </summary>
        [pbr::OriginalName("EXTENSION_SUBTYPE_REQUIRED")] ExtensionSubtypeRequired = 38,
        /// <summary>
        /// The referenced feed item is not mapped to a supported extension type.
        /// </summary>
        [pbr::OriginalName("EXTENSION_TYPE_UNSUPPORTED")] ExtensionTypeUnsupported = 39,
        /// <summary>
        /// Cannot operate on a Feed with more than one active FeedMapping.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_FEED_WITH_MULTIPLE_MAPPINGS")] CannotOperateOnFeedWithMultipleMappings = 40,
        /// <summary>
        /// Cannot operate on a Feed that has key attributes.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_FEED_WITH_KEY_ATTRIBUTES")] CannotOperateOnFeedWithKeyAttributes = 41,
        /// <summary>
        /// Input price is not in a valid format.
        /// </summary>
        [pbr::OriginalName("INVALID_PRICE_FORMAT")] InvalidPriceFormat = 42,
        /// <summary>
        /// The promotion time is invalid.
        /// </summary>
        [pbr::OriginalName("PROMOTION_INVALID_TIME")] PromotionInvalidTime = 43,
        /// <summary>
        /// This field has too many decimal places specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 44,
        /// <summary>
        /// Concrete sub type of ExtensionFeedItem is required for this operation.
        /// </summary>
        [pbr::OriginalName("CONCRETE_EXTENSION_TYPE_REQUIRED")] ConcreteExtensionTypeRequired = 45,
        /// <summary>
        /// Feed item schedule end time must be after start time.
        /// </summary>
        [pbr::OriginalName("SCHEDULE_END_NOT_AFTER_START")] ScheduleEndNotAfterStart = 46,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
