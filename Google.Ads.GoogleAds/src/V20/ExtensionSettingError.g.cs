// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/errors/extension_setting_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/errors/extension_setting_error.proto</summary>
  public static partial class ExtensionSettingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/errors/extension_setting_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExtensionSettingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZXJyb3JzL2V4dGVuc2lvbl9z",
            "ZXR0aW5nX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAu",
            "ZXJyb3JzIq4UChlFeHRlbnNpb25TZXR0aW5nRXJyb3JFbnVtIpAUChVFeHRl",
            "bnNpb25TZXR0aW5nRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESFwoTRVhURU5TSU9OU19SRVFVSVJFRBACEiUKIUZFRURfVFlQRV9FWFRF",
            "TlNJT05fVFlQRV9NSVNNQVRDSBADEhUKEUlOVkFMSURfRkVFRF9UWVBFEAQS",
            "NAowSU5WQUxJRF9GRUVEX1RZUEVfRk9SX0NVU1RPTUVSX0VYVEVOU0lPTl9T",
            "RVRUSU5HEAUSJQohQ0FOTk9UX0NIQU5HRV9GRUVEX0lURU1fT05fQ1JFQVRF",
            "EAYSKQolQ0FOTk9UX1VQREFURV9ORVdMWV9DUkVBVEVEX0VYVEVOU0lPThAH",
            "EjMKL05PX0VYSVNUSU5HX0FEX0dST1VQX0VYVEVOU0lPTl9TRVRUSU5HX0ZP",
            "Ul9UWVBFEAgSMwovTk9fRVhJU1RJTkdfQ0FNUEFJR05fRVhURU5TSU9OX1NF",
            "VFRJTkdfRk9SX1RZUEUQCRIzCi9OT19FWElTVElOR19DVVNUT01FUl9FWFRF",
            "TlNJT05fU0VUVElOR19GT1JfVFlQRRAKEi0KKUFEX0dST1VQX0VYVEVOU0lP",
            "Tl9TRVRUSU5HX0FMUkVBRFlfRVhJU1RTEAsSLQopQ0FNUEFJR05fRVhURU5T",
            "SU9OX1NFVFRJTkdfQUxSRUFEWV9FWElTVFMQDBItCilDVVNUT01FUl9FWFRF",
            "TlNJT05fU0VUVElOR19BTFJFQURZX0VYSVNUUxANEjUKMUFEX0dST1VQX0ZF",
            "RURfQUxSRUFEWV9FWElTVFNfRk9SX1BMQUNFSE9MREVSX1RZUEUQDhI1CjFD",
            "QU1QQUlHTl9GRUVEX0FMUkVBRFlfRVhJU1RTX0ZPUl9QTEFDRUhPTERFUl9U",
            "WVBFEA8SNQoxQ1VTVE9NRVJfRkVFRF9BTFJFQURZX0VYSVNUU19GT1JfUExB",
            "Q0VIT0xERVJfVFlQRRAQEhYKElZBTFVFX09VVF9PRl9SQU5HRRAREiQKIENB",
            "Tk5PVF9TRVRfRklFTERfV0lUSF9GSU5BTF9VUkxTEBISFgoSRklOQUxfVVJM",
            "U19OT1RfU0VUEBMSGAoUSU5WQUxJRF9QSE9ORV9OVU1CRVIQFBIqCiZQSE9O",
            "RV9OVU1CRVJfTk9UX1NVUFBPUlRFRF9GT1JfQ09VTlRSWRAVEi0KKUNBUlJJ",
            "RVJfU1BFQ0lGSUNfU0hPUlRfTlVNQkVSX05PVF9BTExPV0VEEBYSIwofUFJF",
            "TUlVTV9SQVRFX05VTUJFUl9OT1RfQUxMT1dFRBAXEhoKFkRJU0FMTE9XRURf",
            "TlVNQkVSX1RZUEUQGBIoCiRJTlZBTElEX0RPTUVTVElDX1BIT05FX05VTUJF",
            "Ul9GT1JNQVQQGRIjCh9WQU5JVFlfUEhPTkVfTlVNQkVSX05PVF9BTExPV0VE",
            "EBoSGAoUSU5WQUxJRF9DT1VOVFJZX0NPREUQGxIjCh9JTlZBTElEX0NBTExf",
            "Q09OVkVSU0lPTl9UWVBFX0lEEBwSLgoqQ1VTVE9NRVJfTk9UX0lOX0FMTE9X",
            "TElTVF9GT1JfQ0FMTFRSQUNLSU5HEEUSKgomQ0FMTFRSQUNLSU5HX05PVF9T",
            "VVBQT1JURURfRk9SX0NPVU5UUlkQHhISCg5JTlZBTElEX0FQUF9JRBAfEiYK",
            "IlFVT1RFU19JTl9SRVZJRVdfRVhURU5TSU9OX1NOSVBQRVQQIBInCiNIWVBI",
            "RU5TX0lOX1JFVklFV19FWFRFTlNJT05fU05JUFBFVBAhEigKJFJFVklFV19F",
            "WFRFTlNJT05fU09VUkNFX05PVF9FTElHSUJMRRAiEigKJFNPVVJDRV9OQU1F",
            "X0lOX1JFVklFV19FWFRFTlNJT05fVEVYVBAjEhEKDU1JU1NJTkdfRklFTEQQ",
            "JBIfChtJTkNPTlNJU1RFTlRfQ1VSUkVOQ1lfQ09ERVMQJRIqCiZQUklDRV9F",
            "WFRFTlNJT05fSEFTX0RVUExJQ0FURURfSEVBREVSUxAmEjQKMFBSSUNFX0lU",
            "RU1fSEFTX0RVUExJQ0FURURfSEVBREVSX0FORF9ERVNDUklQVElPThAnEiUK",
            "IVBSSUNFX0VYVEVOU0lPTl9IQVNfVE9PX0ZFV19JVEVNUxAoEiYKIlBSSUNF",
            "X0VYVEVOU0lPTl9IQVNfVE9PX01BTllfSVRFTVMQKRIVChFVTlNVUFBPUlRF",
            "RF9WQUxVRRAqEh0KGUlOVkFMSURfREVWSUNFX1BSRUZFUkVOQ0UQKxIYChRJ",
            "TlZBTElEX1NDSEVEVUxFX0VORBAtEioKJkRBVEVfVElNRV9NVVNUX0JFX0lO",
            "X0FDQ09VTlRfVElNRV9aT05FEC8SJQohT1ZFUkxBUFBJTkdfU0NIRURVTEVT",
            "X05PVF9BTExPV0VEEDASIAocU0NIRURVTEVfRU5EX05PVF9BRlRFUl9TVEFS",
            "VBAxEh4KGlRPT19NQU5ZX1NDSEVEVUxFU19QRVJfREFZEDISJgoiRFVQTElD",
            "QVRFX0VYVEVOU0lPTl9GRUVEX0lURU1fRURJVBAzEhsKF0lOVkFMSURfU05J",
            "UFBFVFNfSEVBREVSEDQSPAo4UEhPTkVfTlVNQkVSX05PVF9TVVBQT1JURURf",
            "V0lUSF9DQUxMVFJBQ0tJTkdfRk9SX0NPVU5UUlkQNRIfChtDQU1QQUlHTl9U",
            "QVJHRVRJTkdfTUlTTUFUQ0gQNhIiCh5DQU5OT1RfT1BFUkFURV9PTl9SRU1P",
            "VkVEX0ZFRUQQNxIbChdFWFRFTlNJT05fVFlQRV9SRVFVSVJFRBA4Ei0KKUlO",
            "Q09NUEFUSUJMRV9VTkRFUkxZSU5HX01BVENISU5HX0ZVTkNUSU9OEDkSHQoZ",
            "U1RBUlRfREFURV9BRlRFUl9FTkRfREFURRA6EhgKFElOVkFMSURfUFJJQ0Vf",
            "Rk9STUFUEDsSGgoWUFJPTU9USU9OX0lOVkFMSURfVElNRRA8EjwKOFBST01P",
            "VElPTl9DQU5OT1RfU0VUX1BFUkNFTlRfRElTQ09VTlRfQU5EX01PTkVZX0RJ",
            "U0NPVU5UED0SPgo6UFJPTU9USU9OX0NBTk5PVF9TRVRfUFJPTU9USU9OX0NP",
            "REVfQU5EX09SREVSU19PVkVSX0FNT1VOVBA+EiUKIVRPT19NQU5ZX0RFQ0lN",
            "QUxfUExBQ0VTX1NQRUNJRklFRBA/EhkKFUlOVkFMSURfTEFOR1VBR0VfQ09E",
            "RRBAEhgKFFVOU1VQUE9SVEVEX0xBTkdVQUdFEEESMAosQ1VTVE9NRVJfQ09O",
            "U0VOVF9GT1JfQ0FMTF9SRUNPUkRJTkdfUkVRVUlSRUQQQhImCiJFWFRFTlNJ",
            "T05fU0VUVElOR19VUERBVEVfSVNfQV9OT09QEEMSEwoPRElTQUxMT1dFRF9U",
            "RVhUEERC+gEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZXJyb3Jz",
            "QhpFeHRlbnNpb25TZXR0aW5nRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIwL2Vy",
            "cm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMjAu",
            "RXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjIwXEVycm9yc+oCI0dv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Errors.ExtensionSettingErrorEnum), global::Google.Ads.GoogleAds.V20.Errors.ExtensionSettingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Errors.ExtensionSettingErrorEnum.Types.ExtensionSettingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing validation errors of extension settings.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExtensionSettingErrorEnum : pb::IMessage<ExtensionSettingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExtensionSettingErrorEnum> _parser = new pb::MessageParser<ExtensionSettingErrorEnum>(() => new ExtensionSettingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExtensionSettingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Errors.ExtensionSettingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum(ExtensionSettingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExtensionSettingErrorEnum Clone() {
      return new ExtensionSettingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExtensionSettingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExtensionSettingErrorEnum other) {
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
    public void MergeFrom(ExtensionSettingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ExtensionSettingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible extension setting errors.
      /// </summary>
      public enum ExtensionSettingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A platform restriction was provided without input extensions or existing
        /// extensions.
        /// </summary>
        [pbr::OriginalName("EXTENSIONS_REQUIRED")] ExtensionsRequired = 2,
        /// <summary>
        /// The provided feed type does not correspond to the provided extensions.
        /// </summary>
        [pbr::OriginalName("FEED_TYPE_EXTENSION_TYPE_MISMATCH")] FeedTypeExtensionTypeMismatch = 3,
        /// <summary>
        /// The provided feed type cannot be used.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE")] InvalidFeedType = 4,
        /// <summary>
        /// The provided feed type cannot be used at the customer level.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_TYPE_FOR_CUSTOMER_EXTENSION_SETTING")] InvalidFeedTypeForCustomerExtensionSetting = 5,
        /// <summary>
        /// Cannot change a feed item field on a CREATE operation.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_FEED_ITEM_ON_CREATE")] CannotChangeFeedItemOnCreate = 6,
        /// <summary>
        /// Cannot update an extension that is not already in this setting.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_NEWLY_CREATED_EXTENSION")] CannotUpdateNewlyCreatedExtension = 7,
        /// <summary>
        /// There is no existing AdGroupExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_AD_GROUP_EXTENSION_SETTING_FOR_TYPE")] NoExistingAdGroupExtensionSettingForType = 8,
        /// <summary>
        /// There is no existing CampaignExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CAMPAIGN_EXTENSION_SETTING_FOR_TYPE")] NoExistingCampaignExtensionSettingForType = 9,
        /// <summary>
        /// There is no existing CustomerExtensionSetting for this type.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_CUSTOMER_EXTENSION_SETTING_FOR_TYPE")] NoExistingCustomerExtensionSettingForType = 10,
        /// <summary>
        /// The AdGroupExtensionSetting already exists. UPDATE should be used to
        /// modify the existing AdGroupExtensionSetting.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_EXTENSION_SETTING_ALREADY_EXISTS")] AdGroupExtensionSettingAlreadyExists = 11,
        /// <summary>
        /// The CampaignExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CampaignExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_EXTENSION_SETTING_ALREADY_EXISTS")] CampaignExtensionSettingAlreadyExists = 12,
        /// <summary>
        /// The CustomerExtensionSetting already exists. UPDATE should be used to
        /// modify the existing CustomerExtensionSetting.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_EXTENSION_SETTING_ALREADY_EXISTS")] CustomerExtensionSettingAlreadyExists = 13,
        /// <summary>
        /// An active ad group feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] AdGroupFeedAlreadyExistsForPlaceholderType = 14,
        /// <summary>
        /// An active campaign feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CampaignFeedAlreadyExistsForPlaceholderType = 15,
        /// <summary>
        /// An active customer feed already exists for this place holder type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] CustomerFeedAlreadyExistsForPlaceholderType = 16,
        /// <summary>
        /// Value is not within the accepted range.
        /// </summary>
        [pbr::OriginalName("VALUE_OUT_OF_RANGE")] ValueOutOfRange = 17,
        /// <summary>
        /// Cannot simultaneously set specified field with final urls.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD_WITH_FINAL_URLS")] CannotSetFieldWithFinalUrls = 18,
        /// <summary>
        /// Must set field with final urls.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS_NOT_SET")] FinalUrlsNotSet = 19,
        /// <summary>
        /// Phone number for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER")] InvalidPhoneNumber = 20,
        /// <summary>
        /// Phone number for a call extension is not supported for the given country
        /// code.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 21,
        /// <summary>
        /// A carrier specific number in short format is not allowed for call
        /// extensions.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 22,
        /// <summary>
        /// Premium rate numbers are not allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 23,
        /// <summary>
        /// Phone number type for a call extension is not allowed.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 24,
        /// <summary>
        /// Phone number for a call extension does not meet domestic format
        /// requirements.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] InvalidDomesticPhoneNumberFormat = 25,
        /// <summary>
        /// Vanity phone numbers (for example, those including letters) are not
        /// allowed for call extensions.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 26,
        /// <summary>
        /// Country code provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 27,
        /// <summary>
        /// Call conversion type id provided for a call extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_TYPE_ID")] InvalidCallConversionTypeId = 28,
        /// <summary>
        /// For a call extension, the customer is not on the allow-list for call
        /// tracking.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_IN_ALLOWLIST_FOR_CALLTRACKING")] CustomerNotInAllowlistForCalltracking = 69,
        /// <summary>
        /// Call tracking is not supported for the given country for a call
        /// extension.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 30,
        /// <summary>
        /// App id provided for an app extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 31,
        /// <summary>
        /// Quotation marks present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] QuotesInReviewExtensionSnippet = 32,
        /// <summary>
        /// Hyphen character present in the review text for a review extension.
        /// </summary>
        [pbr::OriginalName("HYPHENS_IN_REVIEW_EXTENSION_SNIPPET")] HyphensInReviewExtensionSnippet = 33,
        /// <summary>
        /// A blocked review source name or url was provided for a review
        /// extension.
        /// </summary>
        [pbr::OriginalName("REVIEW_EXTENSION_SOURCE_NOT_ELIGIBLE")] ReviewExtensionSourceNotEligible = 34,
        /// <summary>
        /// Review source name should not be found in the review text.
        /// </summary>
        [pbr::OriginalName("SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT")] SourceNameInReviewExtensionText = 35,
        /// <summary>
        /// Field must be set.
        /// </summary>
        [pbr::OriginalName("MISSING_FIELD")] MissingField = 36,
        /// <summary>
        /// Inconsistent currency codes.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_CURRENCY_CODES")] InconsistentCurrencyCodes = 37,
        /// <summary>
        /// Price extension cannot have duplicated headers.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_DUPLICATED_HEADERS")] PriceExtensionHasDuplicatedHeaders = 38,
        /// <summary>
        /// Price item cannot have duplicated header and description.
        /// </summary>
        [pbr::OriginalName("PRICE_ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION")] PriceItemHasDuplicatedHeaderAndDescription = 39,
        /// <summary>
        /// Price extension has too few items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_FEW_ITEMS")] PriceExtensionHasTooFewItems = 40,
        /// <summary>
        /// Price extension has too many items
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_MANY_ITEMS")] PriceExtensionHasTooManyItems = 41,
        /// <summary>
        /// The input value is not currently supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE")] UnsupportedValue = 42,
        /// <summary>
        /// Unknown or unsupported device preference.
        /// </summary>
        [pbr::OriginalName("INVALID_DEVICE_PREFERENCE")] InvalidDevicePreference = 43,
        /// <summary>
        /// Invalid feed item schedule end time (for example, endHour = 24 and
        /// endMinute != 0).
        /// </summary>
        [pbr::OriginalName("INVALID_SCHEDULE_END")] InvalidScheduleEnd = 45,
        /// <summary>
        /// Date time zone does not match the account's time zone.
        /// </summary>
        [pbr::OriginalName("DATE_TIME_MUST_BE_IN_ACCOUNT_TIME_ZONE")] DateTimeMustBeInAccountTimeZone = 47,
        /// <summary>
        /// Overlapping feed item schedule times (for example, 7-10AM and 8-11AM) are
        /// not allowed.
        /// </summary>
        [pbr::OriginalName("OVERLAPPING_SCHEDULES_NOT_ALLOWED")] OverlappingSchedulesNotAllowed = 48,
        /// <summary>
        /// Feed item schedule end time must be after start time.
        /// </summary>
        [pbr::OriginalName("SCHEDULE_END_NOT_AFTER_START")] ScheduleEndNotAfterStart = 49,
        /// <summary>
        /// There are too many feed item schedules per day.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SCHEDULES_PER_DAY")] TooManySchedulesPerDay = 50,
        /// <summary>
        /// Cannot edit the same extension feed item more than once in the same
        /// request.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_EXTENSION_FEED_ITEM_EDIT")] DuplicateExtensionFeedItemEdit = 51,
        /// <summary>
        /// Invalid structured snippet header.
        /// </summary>
        [pbr::OriginalName("INVALID_SNIPPETS_HEADER")] InvalidSnippetsHeader = 52,
        /// <summary>
        /// Phone number with call tracking enabled is not supported for the
        /// specified country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY")] PhoneNumberNotSupportedWithCalltrackingForCountry = 53,
        /// <summary>
        /// The targeted adgroup must belong to the targeted campaign.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_TARGETING_MISMATCH")] CampaignTargetingMismatch = 54,
        /// <summary>
        /// The feed used by the ExtensionSetting is removed and cannot be operated
        /// on. Remove the ExtensionSetting to allow a new one to be created using
        /// an active feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_FEED")] CannotOperateOnRemovedFeed = 55,
        /// <summary>
        /// The ExtensionFeedItem type is required for this operation.
        /// </summary>
        [pbr::OriginalName("EXTENSION_TYPE_REQUIRED")] ExtensionTypeRequired = 56,
        /// <summary>
        /// The matching function that links the extension feed to the customer,
        /// campaign, or ad group is not compatible with the ExtensionSetting
        /// services.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_UNDERLYING_MATCHING_FUNCTION")] IncompatibleUnderlyingMatchingFunction = 57,
        /// <summary>
        /// Start date must be before end date.
        /// </summary>
        [pbr::OriginalName("START_DATE_AFTER_END_DATE")] StartDateAfterEndDate = 58,
        /// <summary>
        /// Input price is not in a valid format.
        /// </summary>
        [pbr::OriginalName("INVALID_PRICE_FORMAT")] InvalidPriceFormat = 59,
        /// <summary>
        /// The promotion time is invalid.
        /// </summary>
        [pbr::OriginalName("PROMOTION_INVALID_TIME")] PromotionInvalidTime = 60,
        /// <summary>
        /// Cannot set both percent discount and money discount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PERCENT_DISCOUNT_AND_MONEY_DISCOUNT")] PromotionCannotSetPercentDiscountAndMoneyDiscount = 61,
        /// <summary>
        /// Cannot set both promotion code and orders over amount fields.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PROMOTION_CODE_AND_ORDERS_OVER_AMOUNT")] PromotionCannotSetPromotionCodeAndOrdersOverAmount = 62,
        /// <summary>
        /// This field has too many decimal places specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 63,
        /// <summary>
        /// The language code is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LANGUAGE_CODE")] InvalidLanguageCode = 64,
        /// <summary>
        /// The language is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_LANGUAGE")] UnsupportedLanguage = 65,
        /// <summary>
        /// Customer hasn't consented for call recording, which is required for
        /// adding/updating call extensions. See
        /// https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 66,
        /// <summary>
        /// The UPDATE operation does not specify any fields other than the resource
        /// name in the update mask.
        /// </summary>
        [pbr::OriginalName("EXTENSION_SETTING_UPDATE_IS_A_NOOP")] ExtensionSettingUpdateIsANoop = 67,
        /// <summary>
        /// The extension contains text which has been prohibited on policy grounds.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_TEXT")] DisallowedText = 68,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
