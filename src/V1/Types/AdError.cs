// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/ad_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/ad_error.proto</summary>
  public static partial class AdErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/ad_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvYWRfZXJyb3IucHJv",
            "dG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9ycxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byLwIAoLQWRFcnJvckVudW0i4CAKB0FkRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESLAooQURfQ1VTVE9N",
            "SVpFUlNfTk9UX1NVUFBPUlRFRF9GT1JfQURfVFlQRRACEhoKFkFQUFJPWElN",
            "QVRFTFlfVE9PX0xPTkcQAxIbChdBUFBST1hJTUFURUxZX1RPT19TSE9SVBAE",
            "Eg8KC0JBRF9TTklQUEVUEAUSFAoQQ0FOTk9UX01PRElGWV9BRBAGEicKI0NB",
            "Tk5PVF9TRVRfQlVTSU5FU1NfTkFNRV9JRl9VUkxfU0VUEAcSFAoQQ0FOTk9U",
            "X1NFVF9GSUVMRBAIEioKJkNBTk5PVF9TRVRfRklFTERfV0lUSF9PUklHSU5f",
            "QURfSURfU0VUEAkSLworQ0FOTk9UX1NFVF9GSUVMRF9XSVRIX0FEX0lEX1NF",
            "VF9GT1JfU0hBUklORxAKEikKJUNBTk5PVF9TRVRfQUxMT1dfRkxFWElCTEVf",
            "Q09MT1JfRkFMU0UQCxI3CjNDQU5OT1RfU0VUX0NPTE9SX0NPTlRST0xfV0hF",
            "Tl9OQVRJVkVfRk9STUFUX1NFVFRJTkcQDBISCg5DQU5OT1RfU0VUX1VSTBAN",
            "EiEKHUNBTk5PVF9TRVRfV0lUSE9VVF9GSU5BTF9VUkxTEA4SHgoaQ0FOTk9U",
            "X1NFVF9XSVRIX0ZJTkFMX1VSTFMQDxIcChhDQU5OT1RfU0VUX1dJVEhfVVJM",
            "X0RBVEEQERInCiNDQU5OT1RfVVNFX0FEX1NVQkNMQVNTX0ZPUl9PUEVSQVRP",
            "UhASEiMKH0NVU1RPTUVSX05PVF9BUFBST1ZFRF9NT0JJTEVBRFMQExIoCiRD",
            "VVNUT01FUl9OT1RfQVBQUk9WRURfVEhJUkRQQVJUWV9BRFMQFBIxCi1DVVNU",
            "T01FUl9OT1RfQVBQUk9WRURfVEhJUkRQQVJUWV9SRURJUkVDVF9BRFMQFRIZ",
            "ChVDVVNUT01FUl9OT1RfRUxJR0lCTEUQFhIxCi1DVVNUT01FUl9OT1RfRUxJ",
            "R0lCTEVfRk9SX1VQREFUSU5HX0JFQUNPTl9VUkwQFxIeChpESU1FTlNJT05f",
            "QUxSRUFEWV9JTl9VTklPThAYEhkKFURJTUVOU0lPTl9NVVNUX0JFX1NFVBAZ",
            "EhoKFkRJTUVOU0lPTl9OT1RfSU5fVU5JT04QGhIjCh9ESVNQTEFZX1VSTF9D",
            "QU5OT1RfQkVfU1BFQ0lGSUVEEBsSIAocRE9NRVNUSUNfUEhPTkVfTlVNQkVS",
            "X0ZPUk1BVBAcEhoKFkVNRVJHRU5DWV9QSE9ORV9OVU1CRVIQHRIPCgtFTVBU",
            "WV9GSUVMRBAeEjAKLEZFRURfQVRUUklCVVRFX01VU1RfSEFWRV9NQVBQSU5H",
            "X0ZPUl9UWVBFX0lEEB8SKAokRkVFRF9BVFRSSUJVVEVfTUFQUElOR19UWVBF",
            "X01JU01BVENIECASIQodSUxMRUdBTF9BRF9DVVNUT01JWkVSX1RBR19VU0UQ",
            "IRITCg9JTExFR0FMX1RBR19VU0UQIhIbChdJTkNPTlNJU1RFTlRfRElNRU5T",
            "SU9OUxAjEikKJUlOQ09OU0lTVEVOVF9TVEFUVVNfSU5fVEVNUExBVEVfVU5J",
            "T04QJBIUChBJTkNPUlJFQ1RfTEVOR1RIECUSGgoWSU5FTElHSUJMRV9GT1Jf",
            "VVBHUkFERRAmEiYKIklOVkFMSURfQURfQUREUkVTU19DQU1QQUlHTl9UQVJH",
            "RVQQJxITCg9JTlZBTElEX0FEX1RZUEUQKBInCiNJTlZBTElEX0FUVFJJQlVU",
            "RVNfRk9SX01PQklMRV9JTUFHRRApEiYKIklOVkFMSURfQVRUUklCVVRFU19G",
            "T1JfTU9CSUxFX1RFWFQQKhIfChtJTlZBTElEX0NBTExfVE9fQUNUSU9OX1RF",
            "WFQQKxIdChlJTlZBTElEX0NIQVJBQ1RFUl9GT1JfVVJMECwSGAoUSU5WQUxJ",
            "RF9DT1VOVFJZX0NPREUQLRIqCiZJTlZBTElEX0VYUEFOREVEX0RZTkFNSUNf",
            "U0VBUkNIX0FEX1RBRxAvEhEKDUlOVkFMSURfSU5QVVQQMBIbChdJTlZBTElE",
            "X01BUktVUF9MQU5HVUFHRRAxEhoKFklOVkFMSURfTU9CSUxFX0NBUlJJRVIQ",
            "MhIhCh1JTlZBTElEX01PQklMRV9DQVJSSUVSX1RBUkdFVBAzEh4KGklOVkFM",
            "SURfTlVNQkVSX09GX0VMRU1FTlRTEDQSHwobSU5WQUxJRF9QSE9ORV9OVU1C",
            "RVJfRk9STUFUEDUSMQotSU5WQUxJRF9SSUNIX01FRElBX0NFUlRJRklFRF9W",
            "RU5ET1JfRk9STUFUX0lEEDYSGQoVSU5WQUxJRF9URU1QTEFURV9EQVRBEDcS",
            "JwojSU5WQUxJRF9URU1QTEFURV9FTEVNRU5UX0ZJRUxEX1RZUEUQOBIXChNJ",
            "TlZBTElEX1RFTVBMQVRFX0lEEDkSEQoNTElORV9UT09fV0lERRA6EiEKHU1J",
            "U1NJTkdfQURfQ1VTVE9NSVpFUl9NQVBQSU5HEDsSHQoZTUlTU0lOR19BRERS",
            "RVNTX0NPTVBPTkVOVBA8Eh4KGk1JU1NJTkdfQURWRVJUSVNFTUVOVF9OQU1F",
            "ED0SGQoVTUlTU0lOR19CVVNJTkVTU19OQU1FED4SGAoUTUlTU0lOR19ERVND",
            "UklQVElPTjEQPxIYChRNSVNTSU5HX0RFU0NSSVBUSU9OMhBAEh8KG01JU1NJ",
            "TkdfREVTVElOQVRJT05fVVJMX1RBRxBBEiAKHE1JU1NJTkdfTEFORElOR19Q",
            "QUdFX1VSTF9UQUcQQhIVChFNSVNTSU5HX0RJTUVOU0lPThBDEhcKE01JU1NJ",
            "TkdfRElTUExBWV9VUkwQRBIUChBNSVNTSU5HX0hFQURMSU5FEEUSEgoOTUlT",
            "U0lOR19IRUlHSFQQRhIRCg1NSVNTSU5HX0lNQUdFEEcSLQopTUlTU0lOR19N",
            "QVJLRVRJTkdfSU1BR0VfT1JfUFJPRFVDVF9WSURFT1MQSBIcChhNSVNTSU5H",
            "X01BUktVUF9MQU5HVUFHRVMQSRIaChZNSVNTSU5HX01PQklMRV9DQVJSSUVS",
            "EEoSEQoNTUlTU0lOR19QSE9ORRBLEiQKIE1JU1NJTkdfUkVRVUlSRURfVEVN",
            "UExBVEVfRklFTERTEEwSIAocTUlTU0lOR19URU1QTEFURV9GSUVMRF9WQUxV",
            "RRBNEhAKDE1JU1NJTkdfVEVYVBBOEhcKE01JU1NJTkdfVklTSUJMRV9VUkwQ",
            "TxIRCg1NSVNTSU5HX1dJRFRIEFASJwojTVVMVElQTEVfRElTVElOQ1RfRkVF",
            "RFNfVU5TVVBQT1JURUQQURIkCiBNVVNUX1VTRV9URU1QX0FEX1VOSU9OX0lE",
            "X09OX0FERBBSEgwKCFRPT19MT05HEFMSDQoJVE9PX1NIT1JUEFQSIgoeVU5J",
            "T05fRElNRU5TSU9OU19DQU5OT1RfQ0hBTkdFEFUSHQoZVU5LTk9XTl9BRERS",
            "RVNTX0NPTVBPTkVOVBBWEhYKElVOS05PV05fRklFTERfTkFNRRBXEhcKE1VO",
            "S05PV05fVU5JUVVFX05BTUUQWBIaChZVTlNVUFBPUlRFRF9ESU1FTlNJT05T",
            "EFkSFgoSVVJMX0lOVkFMSURfU0NIRU1FEFoSIAocVVJMX0lOVkFMSURfVE9Q",
            "X0xFVkVMX0RPTUFJThBbEhEKDVVSTF9NQUxGT1JNRUQQXBIPCgtVUkxfTk9f",
            "SE9TVBBdEhYKElVSTF9OT1RfRVFVSVZBTEVOVBBeEhoKFlVSTF9IT1NUX05B",
            "TUVfVE9PX0xPTkcQXxIRCg1VUkxfTk9fU0NIRU1FEGASGwoXVVJMX05PX1RP",
            "UF9MRVZFTF9ET01BSU4QYRIYChRVUkxfUEFUSF9OT1RfQUxMT1dFRBBiEhgK",
            "FFVSTF9QT1JUX05PVF9BTExPV0VEEGMSGQoVVVJMX1FVRVJZX05PVF9BTExP",
            "V0VEEGQSNAowVVJMX1NDSEVNRV9CRUZPUkVfRVhQQU5ERURfRFlOQU1JQ19T",
            "RUFSQ0hfQURfVEFHEGYSKQolVVNFUl9ET0VTX05PVF9IQVZFX0FDQ0VTU19U",
            "T19URU1QTEFURRBnEiQKIElOQ09OU0lTVEVOVF9FWFBBTkRBQkxFX1NFVFRJ",
            "TkdTEGgSEgoOSU5WQUxJRF9GT1JNQVQQaRIWChJJTlZBTElEX0ZJRUxEX1RF",
            "WFQQahIXChNFTEVNRU5UX05PVF9QUkVTRU5UEGsSDwoLSU1BR0VfRVJST1IQ",
            "bBIWChJWQUxVRV9OT1RfSU5fUkFOR0UQbRIVChFGSUVMRF9OT1RfUFJFU0VO",
            "VBBuEhgKFEFERFJFU1NfTk9UX0NPTVBMRVRFEG8SEwoPQUREUkVTU19JTlZB",
            "TElEEHASGQoVVklERU9fUkVUUklFVkFMX0VSUk9SEHESDwoLQVVESU9fRVJS",
            "T1IQchIfChtJTlZBTElEX1lPVVRVQkVfRElTUExBWV9VUkwQcxIbChdUT09f",
            "TUFOWV9QUk9EVUNUX0lNQUdFUxB0EhsKF1RPT19NQU5ZX1BST0RVQ1RfVklE",
            "RU9TEHUSLgoqSU5DT01QQVRJQkxFX0FEX1RZUEVfQU5EX0RFVklDRV9QUkVG",
            "RVJFTkNFEHYSKgomQ0FMTFRSQUNLSU5HX05PVF9TVVBQT1JURURfRk9SX0NP",
            "VU5UUlkQdxItCilDQVJSSUVSX1NQRUNJRklDX1NIT1JUX05VTUJFUl9OT1Rf",
            "QUxMT1dFRBB4EhoKFkRJU0FMTE9XRURfTlVNQkVSX1RZUEUQeRIqCiZQSE9O",
            "RV9OVU1CRVJfTk9UX1NVUFBPUlRFRF9GT1JfQ09VTlRSWRB6EjwKOFBIT05F",
            "X05VTUJFUl9OT1RfU1VQUE9SVEVEX1dJVEhfQ0FMTFRSQUNLSU5HX0ZPUl9D",
            "T1VOVFJZEHsSIwofUFJFTUlVTV9SQVRFX05VTUJFUl9OT1RfQUxMT1dFRBB8",
            "EiMKH1ZBTklUWV9QSE9ORV9OVU1CRVJfTk9UX0FMTE9XRUQQfRIjCh9JTlZB",
            "TElEX0NBTExfQ09OVkVSU0lPTl9UWVBFX0lEEH4SPQo5Q0FOTk9UX0RJU0FC",
            "TEVfQ0FMTF9DT05WRVJTSU9OX0FORF9TRVRfQ09OVkVSU0lPTl9UWVBFX0lE",
            "EH8SIwoeQ0FOTk9UX1NFVF9QQVRIMl9XSVRIT1VUX1BBVEgxEIABEjMKLk1J",
            "U1NJTkdfRFlOQU1JQ19TRUFSQ0hfQURTX1NFVFRJTkdfRE9NQUlOX05BTUUQ",
            "gQESJwoiSU5DT01QQVRJQkxFX1dJVEhfUkVTVFJJQ1RJT05fVFlQRRCCARIx",
            "CixDVVNUT01FUl9DT05TRU5UX0ZPUl9DQUxMX1JFQ09SRElOR19SRVFVSVJF",
            "RBCDARIiCh1NSVNTSU5HX0lNQUdFX09SX01FRElBX0JVTkRMRRCEARIwCitQ",
            "Uk9EVUNUX1RZUEVfTk9UX1NVUFBPUlRFRF9JTl9USElTX0NBTVBBSUdOEIUB",
            "QucBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZXJyb3JzQgxBZEVy",
            "cm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5H",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMS5FcnJvcnPKAh5Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMVxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.AdErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.AdErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.AdErrorEnum.Types.AdError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad errors.
  /// </summary>
  public sealed partial class AdErrorEnum : pb::IMessage<AdErrorEnum> {
    private static readonly pb::MessageParser<AdErrorEnum> _parser = new pb::MessageParser<AdErrorEnum>(() => new AdErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.AdErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdErrorEnum(AdErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdErrorEnum Clone() {
      return new AdErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdErrorEnum other) {
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
    public void MergeFrom(AdErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad errors.
      /// </summary>
      public enum AdError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Ad customizers are not supported for ad type.
        /// </summary>
        [pbr::OriginalName("AD_CUSTOMIZERS_NOT_SUPPORTED_FOR_AD_TYPE")] AdCustomizersNotSupportedForAdType = 2,
        /// <summary>
        /// Estimating character sizes the string is too long.
        /// </summary>
        [pbr::OriginalName("APPROXIMATELY_TOO_LONG")] ApproximatelyTooLong = 3,
        /// <summary>
        /// Estimating character sizes the string is too short.
        /// </summary>
        [pbr::OriginalName("APPROXIMATELY_TOO_SHORT")] ApproximatelyTooShort = 4,
        /// <summary>
        /// There is a problem with the snippet.
        /// </summary>
        [pbr::OriginalName("BAD_SNIPPET")] BadSnippet = 5,
        /// <summary>
        /// Cannot modify an ad.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_AD")] CannotModifyAd = 6,
        /// <summary>
        /// business name and url cannot be set at the same time
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_BUSINESS_NAME_IF_URL_SET")] CannotSetBusinessNameIfUrlSet = 7,
        /// <summary>
        /// The specified field is incompatible with this ad's type or settings.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD")] CannotSetField = 8,
        /// <summary>
        /// Cannot set field when originAdId is set.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD_WITH_ORIGIN_AD_ID_SET")] CannotSetFieldWithOriginAdIdSet = 9,
        /// <summary>
        /// Cannot set field when an existing ad id is set for sharing.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_FIELD_WITH_AD_ID_SET_FOR_SHARING")] CannotSetFieldWithAdIdSetForSharing = 10,
        /// <summary>
        /// Cannot set allowFlexibleColor false if no color is provided by user.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_ALLOW_FLEXIBLE_COLOR_FALSE")] CannotSetAllowFlexibleColorFalse = 11,
        /// <summary>
        /// When user select native, no color control is allowed because we will
        /// always respect publisher color for native format serving.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_COLOR_CONTROL_WHEN_NATIVE_FORMAT_SETTING")] CannotSetColorControlWhenNativeFormatSetting = 12,
        /// <summary>
        /// Cannot specify a url for the ad type
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_URL")] CannotSetUrl = 13,
        /// <summary>
        /// Cannot specify a tracking or mobile url without also setting final urls
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITHOUT_FINAL_URLS")] CannotSetWithoutFinalUrls = 14,
        /// <summary>
        /// Cannot specify a legacy url and a final url simultaneously
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITH_FINAL_URLS")] CannotSetWithFinalUrls = 15,
        /// <summary>
        /// Cannot specify a urls in UrlData and in template fields simultaneously.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITH_URL_DATA")] CannotSetWithUrlData = 17,
        /// <summary>
        /// This operator cannot be used with a subclass of Ad.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_AD_SUBCLASS_FOR_OPERATOR")] CannotUseAdSubclassForOperator = 18,
        /// <summary>
        /// Customer is not approved for mobile ads.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_APPROVED_MOBILEADS")] CustomerNotApprovedMobileads = 19,
        /// <summary>
        /// Customer is not approved for 3PAS richmedia ads.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_APPROVED_THIRDPARTY_ADS")] CustomerNotApprovedThirdpartyAds = 20,
        /// <summary>
        /// Customer is not approved for 3PAS redirect richmedia (Ad Exchange) ads.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_APPROVED_THIRDPARTY_REDIRECT_ADS")] CustomerNotApprovedThirdpartyRedirectAds = 21,
        /// <summary>
        /// Not an eligible customer
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ELIGIBLE")] CustomerNotEligible = 22,
        /// <summary>
        /// Customer is not eligible for updating beacon url
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_ELIGIBLE_FOR_UPDATING_BEACON_URL")] CustomerNotEligibleForUpdatingBeaconUrl = 23,
        /// <summary>
        /// There already exists an ad with the same dimensions in the union.
        /// </summary>
        [pbr::OriginalName("DIMENSION_ALREADY_IN_UNION")] DimensionAlreadyInUnion = 24,
        /// <summary>
        /// Ad's dimension must be set before setting union dimension.
        /// </summary>
        [pbr::OriginalName("DIMENSION_MUST_BE_SET")] DimensionMustBeSet = 25,
        /// <summary>
        /// Ad's dimension must be included in the union dimensions.
        /// </summary>
        [pbr::OriginalName("DIMENSION_NOT_IN_UNION")] DimensionNotInUnion = 26,
        /// <summary>
        /// Display Url cannot be specified (applies to Ad Exchange Ads)
        /// </summary>
        [pbr::OriginalName("DISPLAY_URL_CANNOT_BE_SPECIFIED")] DisplayUrlCannotBeSpecified = 27,
        /// <summary>
        /// Telephone number contains invalid characters or invalid format. Please
        /// re-enter your number using digits (0-9), dashes (-), and parentheses
        /// only.
        /// </summary>
        [pbr::OriginalName("DOMESTIC_PHONE_NUMBER_FORMAT")] DomesticPhoneNumberFormat = 28,
        /// <summary>
        /// Emergency telephone numbers are not allowed. Please enter a valid
        /// domestic phone number to connect customers to your business.
        /// </summary>
        [pbr::OriginalName("EMERGENCY_PHONE_NUMBER")] EmergencyPhoneNumber = 29,
        /// <summary>
        /// A required field was not specified or is an empty string.
        /// </summary>
        [pbr::OriginalName("EMPTY_FIELD")] EmptyField = 30,
        /// <summary>
        /// A feed attribute referenced in an ad customizer tag is not in the ad
        /// customizer mapping for the feed.
        /// </summary>
        [pbr::OriginalName("FEED_ATTRIBUTE_MUST_HAVE_MAPPING_FOR_TYPE_ID")] FeedAttributeMustHaveMappingForTypeId = 31,
        /// <summary>
        /// The ad customizer field mapping for the feed attribute does not match the
        /// expected field type.
        /// </summary>
        [pbr::OriginalName("FEED_ATTRIBUTE_MAPPING_TYPE_MISMATCH")] FeedAttributeMappingTypeMismatch = 32,
        /// <summary>
        /// The use of ad customizer tags in the ad text is disallowed. Details in
        /// trigger.
        /// </summary>
        [pbr::OriginalName("ILLEGAL_AD_CUSTOMIZER_TAG_USE")] IllegalAdCustomizerTagUse = 33,
        /// <summary>
        /// Tags of the form {PH_x}, where x is a number, are disallowed in ad text.
        /// </summary>
        [pbr::OriginalName("ILLEGAL_TAG_USE")] IllegalTagUse = 34,
        /// <summary>
        /// The dimensions of the ad are specified or derived in multiple ways and
        /// are not consistent.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_DIMENSIONS")] InconsistentDimensions = 35,
        /// <summary>
        /// The status cannot differ among template ads of the same union.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_STATUS_IN_TEMPLATE_UNION")] InconsistentStatusInTemplateUnion = 36,
        /// <summary>
        /// The length of the string is not valid.
        /// </summary>
        [pbr::OriginalName("INCORRECT_LENGTH")] IncorrectLength = 37,
        /// <summary>
        /// The ad is ineligible for upgrade.
        /// </summary>
        [pbr::OriginalName("INELIGIBLE_FOR_UPGRADE")] IneligibleForUpgrade = 38,
        /// <summary>
        /// User cannot create mobile ad for countries targeted in specified
        /// campaign.
        /// </summary>
        [pbr::OriginalName("INVALID_AD_ADDRESS_CAMPAIGN_TARGET")] InvalidAdAddressCampaignTarget = 39,
        /// <summary>
        /// Invalid Ad type. A specific type of Ad is required.
        /// </summary>
        [pbr::OriginalName("INVALID_AD_TYPE")] InvalidAdType = 40,
        /// <summary>
        /// Headline, description or phone cannot be present when creating mobile
        /// image ad.
        /// </summary>
        [pbr::OriginalName("INVALID_ATTRIBUTES_FOR_MOBILE_IMAGE")] InvalidAttributesForMobileImage = 41,
        /// <summary>
        /// Image cannot be present when creating mobile text ad.
        /// </summary>
        [pbr::OriginalName("INVALID_ATTRIBUTES_FOR_MOBILE_TEXT")] InvalidAttributesForMobileText = 42,
        /// <summary>
        /// Invalid call to action text.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_TO_ACTION_TEXT")] InvalidCallToActionText = 43,
        /// <summary>
        /// Invalid character in URL.
        /// </summary>
        [pbr::OriginalName("INVALID_CHARACTER_FOR_URL")] InvalidCharacterForUrl = 44,
        /// <summary>
        /// Creative's country code is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 45,
        /// <summary>
        /// Invalid use of Expanded Dynamic Search Ads tags ({lpurl} etc.)
        /// </summary>
        [pbr::OriginalName("INVALID_EXPANDED_DYNAMIC_SEARCH_AD_TAG")] InvalidExpandedDynamicSearchAdTag = 47,
        /// <summary>
        /// An input error whose real reason was not properly mapped (should not
        /// happen).
        /// </summary>
        [pbr::OriginalName("INVALID_INPUT")] InvalidInput = 48,
        /// <summary>
        /// An invalid markup language was entered.
        /// </summary>
        [pbr::OriginalName("INVALID_MARKUP_LANGUAGE")] InvalidMarkupLanguage = 49,
        /// <summary>
        /// An invalid mobile carrier was entered.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_CARRIER")] InvalidMobileCarrier = 50,
        /// <summary>
        /// Specified mobile carriers target a country not targeted by the campaign.
        /// </summary>
        [pbr::OriginalName("INVALID_MOBILE_CARRIER_TARGET")] InvalidMobileCarrierTarget = 51,
        /// <summary>
        /// Wrong number of elements for given element type
        /// </summary>
        [pbr::OriginalName("INVALID_NUMBER_OF_ELEMENTS")] InvalidNumberOfElements = 52,
        /// <summary>
        /// The format of the telephone number is incorrect. Please re-enter the
        /// number using the correct format.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER_FORMAT")] InvalidPhoneNumberFormat = 53,
        /// <summary>
        /// The certified vendor format id is incorrect.
        /// </summary>
        [pbr::OriginalName("INVALID_RICH_MEDIA_CERTIFIED_VENDOR_FORMAT_ID")] InvalidRichMediaCertifiedVendorFormatId = 54,
        /// <summary>
        /// The template ad data contains validation errors.
        /// </summary>
        [pbr::OriginalName("INVALID_TEMPLATE_DATA")] InvalidTemplateData = 55,
        /// <summary>
        /// The template field doesn't have have the correct type.
        /// </summary>
        [pbr::OriginalName("INVALID_TEMPLATE_ELEMENT_FIELD_TYPE")] InvalidTemplateElementFieldType = 56,
        /// <summary>
        /// Invalid template id.
        /// </summary>
        [pbr::OriginalName("INVALID_TEMPLATE_ID")] InvalidTemplateId = 57,
        /// <summary>
        /// After substituting replacement strings, the line is too wide.
        /// </summary>
        [pbr::OriginalName("LINE_TOO_WIDE")] LineTooWide = 58,
        /// <summary>
        /// The feed referenced must have ad customizer mapping to be used in a
        /// customizer tag.
        /// </summary>
        [pbr::OriginalName("MISSING_AD_CUSTOMIZER_MAPPING")] MissingAdCustomizerMapping = 59,
        /// <summary>
        /// Missing address component in template element address field.
        /// </summary>
        [pbr::OriginalName("MISSING_ADDRESS_COMPONENT")] MissingAddressComponent = 60,
        /// <summary>
        /// An ad name must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_ADVERTISEMENT_NAME")] MissingAdvertisementName = 61,
        /// <summary>
        /// Business name must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_BUSINESS_NAME")] MissingBusinessName = 62,
        /// <summary>
        /// Description (line 2) must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_DESCRIPTION1")] MissingDescription1 = 63,
        /// <summary>
        /// Description (line 3) must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_DESCRIPTION2")] MissingDescription2 = 64,
        /// <summary>
        /// The destination url must contain at least one tag (e.g. {lpurl})
        /// </summary>
        [pbr::OriginalName("MISSING_DESTINATION_URL_TAG")] MissingDestinationUrlTag = 65,
        /// <summary>
        /// The tracking url template of ExpandedDynamicSearchAd must contain at
        /// least one tag. (e.g. {lpurl})
        /// </summary>
        [pbr::OriginalName("MISSING_LANDING_PAGE_URL_TAG")] MissingLandingPageUrlTag = 66,
        /// <summary>
        /// A valid dimension must be specified for this ad.
        /// </summary>
        [pbr::OriginalName("MISSING_DIMENSION")] MissingDimension = 67,
        /// <summary>
        /// A display URL must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_DISPLAY_URL")] MissingDisplayUrl = 68,
        /// <summary>
        /// Headline must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_HEADLINE")] MissingHeadline = 69,
        /// <summary>
        /// A height must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_HEIGHT")] MissingHeight = 70,
        /// <summary>
        /// An image must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_IMAGE")] MissingImage = 71,
        /// <summary>
        /// Marketing image or product videos are required.
        /// </summary>
        [pbr::OriginalName("MISSING_MARKETING_IMAGE_OR_PRODUCT_VIDEOS")] MissingMarketingImageOrProductVideos = 72,
        /// <summary>
        /// The markup language in which your site is written must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_MARKUP_LANGUAGES")] MissingMarkupLanguages = 73,
        /// <summary>
        /// A mobile carrier must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_MOBILE_CARRIER")] MissingMobileCarrier = 74,
        /// <summary>
        /// Phone number must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_PHONE")] MissingPhone = 75,
        /// <summary>
        /// Missing required template fields
        /// </summary>
        [pbr::OriginalName("MISSING_REQUIRED_TEMPLATE_FIELDS")] MissingRequiredTemplateFields = 76,
        /// <summary>
        /// Missing a required field value
        /// </summary>
        [pbr::OriginalName("MISSING_TEMPLATE_FIELD_VALUE")] MissingTemplateFieldValue = 77,
        /// <summary>
        /// The ad must have text.
        /// </summary>
        [pbr::OriginalName("MISSING_TEXT")] MissingText = 78,
        /// <summary>
        /// A visible URL must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_VISIBLE_URL")] MissingVisibleUrl = 79,
        /// <summary>
        /// A width must be entered.
        /// </summary>
        [pbr::OriginalName("MISSING_WIDTH")] MissingWidth = 80,
        /// <summary>
        /// Only 1 feed can be used as the source of ad customizer substitutions in a
        /// single ad.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_DISTINCT_FEEDS_UNSUPPORTED")] MultipleDistinctFeedsUnsupported = 81,
        /// <summary>
        /// TempAdUnionId must be use when adding template ads.
        /// </summary>
        [pbr::OriginalName("MUST_USE_TEMP_AD_UNION_ID_ON_ADD")] MustUseTempAdUnionIdOnAdd = 82,
        /// <summary>
        /// The string has too many characters.
        /// </summary>
        [pbr::OriginalName("TOO_LONG")] TooLong = 83,
        /// <summary>
        /// The string has too few characters.
        /// </summary>
        [pbr::OriginalName("TOO_SHORT")] TooShort = 84,
        /// <summary>
        /// Ad union dimensions cannot change for saved ads.
        /// </summary>
        [pbr::OriginalName("UNION_DIMENSIONS_CANNOT_CHANGE")] UnionDimensionsCannotChange = 85,
        /// <summary>
        /// Address component is not {country, lat, lng}.
        /// </summary>
        [pbr::OriginalName("UNKNOWN_ADDRESS_COMPONENT")] UnknownAddressComponent = 86,
        /// <summary>
        /// Unknown unique field name
        /// </summary>
        [pbr::OriginalName("UNKNOWN_FIELD_NAME")] UnknownFieldName = 87,
        /// <summary>
        /// Unknown unique name (template element type specifier)
        /// </summary>
        [pbr::OriginalName("UNKNOWN_UNIQUE_NAME")] UnknownUniqueName = 88,
        /// <summary>
        /// Unsupported ad dimension
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_DIMENSIONS")] UnsupportedDimensions = 89,
        /// <summary>
        /// URL starts with an invalid scheme.
        /// </summary>
        [pbr::OriginalName("URL_INVALID_SCHEME")] UrlInvalidScheme = 90,
        /// <summary>
        /// URL ends with an invalid top-level domain name.
        /// </summary>
        [pbr::OriginalName("URL_INVALID_TOP_LEVEL_DOMAIN")] UrlInvalidTopLevelDomain = 91,
        /// <summary>
        /// URL contains illegal characters.
        /// </summary>
        [pbr::OriginalName("URL_MALFORMED")] UrlMalformed = 92,
        /// <summary>
        /// URL must contain a host name.
        /// </summary>
        [pbr::OriginalName("URL_NO_HOST")] UrlNoHost = 93,
        /// <summary>
        /// URL not equivalent during upgrade.
        /// </summary>
        [pbr::OriginalName("URL_NOT_EQUIVALENT")] UrlNotEquivalent = 94,
        /// <summary>
        /// URL host name too long to be stored as visible URL (applies to Ad
        /// Exchange ads)
        /// </summary>
        [pbr::OriginalName("URL_HOST_NAME_TOO_LONG")] UrlHostNameTooLong = 95,
        /// <summary>
        /// URL must start with a scheme.
        /// </summary>
        [pbr::OriginalName("URL_NO_SCHEME")] UrlNoScheme = 96,
        /// <summary>
        /// URL should end in a valid domain extension, such as .com or .net.
        /// </summary>
        [pbr::OriginalName("URL_NO_TOP_LEVEL_DOMAIN")] UrlNoTopLevelDomain = 97,
        /// <summary>
        /// URL must not end with a path.
        /// </summary>
        [pbr::OriginalName("URL_PATH_NOT_ALLOWED")] UrlPathNotAllowed = 98,
        /// <summary>
        /// URL must not specify a port.
        /// </summary>
        [pbr::OriginalName("URL_PORT_NOT_ALLOWED")] UrlPortNotAllowed = 99,
        /// <summary>
        /// URL must not contain a query.
        /// </summary>
        [pbr::OriginalName("URL_QUERY_NOT_ALLOWED")] UrlQueryNotAllowed = 100,
        /// <summary>
        /// A url scheme is not allowed in front of tag in tracking url template
        /// (e.g. http://{lpurl})
        /// </summary>
        [pbr::OriginalName("URL_SCHEME_BEFORE_EXPANDED_DYNAMIC_SEARCH_AD_TAG")] UrlSchemeBeforeExpandedDynamicSearchAdTag = 102,
        /// <summary>
        /// The user does not have permissions to create a template ad for the given
        /// template.
        /// </summary>
        [pbr::OriginalName("USER_DOES_NOT_HAVE_ACCESS_TO_TEMPLATE")] UserDoesNotHaveAccessToTemplate = 103,
        /// <summary>
        /// Expandable setting is inconsistent/wrong. For example, an AdX ad is
        /// invalid if it has a expandable vendor format but no expanding directions
        /// specified, or expanding directions is specified, but the vendor format is
        /// not expandable.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_EXPANDABLE_SETTINGS")] InconsistentExpandableSettings = 104,
        /// <summary>
        /// Format is invalid
        /// </summary>
        [pbr::OriginalName("INVALID_FORMAT")] InvalidFormat = 105,
        /// <summary>
        /// The text of this field did not match a pattern of allowed values.
        /// </summary>
        [pbr::OriginalName("INVALID_FIELD_TEXT")] InvalidFieldText = 106,
        /// <summary>
        /// Template element is mising
        /// </summary>
        [pbr::OriginalName("ELEMENT_NOT_PRESENT")] ElementNotPresent = 107,
        /// <summary>
        /// Error occurred during image processing
        /// </summary>
        [pbr::OriginalName("IMAGE_ERROR")] ImageError = 108,
        /// <summary>
        /// The value is not within the valid range
        /// </summary>
        [pbr::OriginalName("VALUE_NOT_IN_RANGE")] ValueNotInRange = 109,
        /// <summary>
        /// Template element field is not present
        /// </summary>
        [pbr::OriginalName("FIELD_NOT_PRESENT")] FieldNotPresent = 110,
        /// <summary>
        /// Address is incomplete
        /// </summary>
        [pbr::OriginalName("ADDRESS_NOT_COMPLETE")] AddressNotComplete = 111,
        /// <summary>
        /// Invalid address
        /// </summary>
        [pbr::OriginalName("ADDRESS_INVALID")] AddressInvalid = 112,
        /// <summary>
        /// Error retrieving specified video
        /// </summary>
        [pbr::OriginalName("VIDEO_RETRIEVAL_ERROR")] VideoRetrievalError = 113,
        /// <summary>
        /// Error processing audio
        /// </summary>
        [pbr::OriginalName("AUDIO_ERROR")] AudioError = 114,
        /// <summary>
        /// Display URL is incorrect for YouTube PYV ads
        /// </summary>
        [pbr::OriginalName("INVALID_YOUTUBE_DISPLAY_URL")] InvalidYoutubeDisplayUrl = 115,
        /// <summary>
        /// Too many product Images in GmailAd
        /// </summary>
        [pbr::OriginalName("TOO_MANY_PRODUCT_IMAGES")] TooManyProductImages = 116,
        /// <summary>
        /// Too many product Videos in GmailAd
        /// </summary>
        [pbr::OriginalName("TOO_MANY_PRODUCT_VIDEOS")] TooManyProductVideos = 117,
        /// <summary>
        /// The device preference is not compatible with the ad type
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_AD_TYPE_AND_DEVICE_PREFERENCE")] IncompatibleAdTypeAndDevicePreference = 118,
        /// <summary>
        /// Call tracking is not supported for specified country.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 119,
        /// <summary>
        /// Carrier specific short number is not allowed.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 120,
        /// <summary>
        /// Specified phone number type is disallowed.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 121,
        /// <summary>
        /// Phone number not supported for country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 122,
        /// <summary>
        /// Phone number not supported with call tracking enabled for country.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_WITH_CALLTRACKING_FOR_COUNTRY")] PhoneNumberNotSupportedWithCalltrackingForCountry = 123,
        /// <summary>
        /// Premium rate phone number is not allowed.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 124,
        /// <summary>
        /// Vanity phone number is not allowed.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 125,
        /// <summary>
        /// Invalid call conversion type id.
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_TYPE_ID")] InvalidCallConversionTypeId = 126,
        /// <summary>
        /// Cannot disable call conversion and set conversion type id.
        /// </summary>
        [pbr::OriginalName("CANNOT_DISABLE_CALL_CONVERSION_AND_SET_CONVERSION_TYPE_ID")] CannotDisableCallConversionAndSetConversionTypeId = 127,
        /// <summary>
        /// Cannot set path2 without path1.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_PATH2_WITHOUT_PATH1")] CannotSetPath2WithoutPath1 = 128,
        /// <summary>
        /// Missing domain name in campaign setting when adding expanded dynamic
        /// search ad.
        /// </summary>
        [pbr::OriginalName("MISSING_DYNAMIC_SEARCH_ADS_SETTING_DOMAIN_NAME")] MissingDynamicSearchAdsSettingDomainName = 129,
        /// <summary>
        /// The associated ad is not compatible with restriction type.
        /// </summary>
        [pbr::OriginalName("INCOMPATIBLE_WITH_RESTRICTION_TYPE")] IncompatibleWithRestrictionType = 130,
        /// <summary>
        /// Consent for call recording is required for creating/updating call only
        /// ads. Please see https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 131,
        /// <summary>
        /// Either an image or a media bundle is required in a display upload ad.
        /// </summary>
        [pbr::OriginalName("MISSING_IMAGE_OR_MEDIA_BUNDLE")] MissingImageOrMediaBundle = 132,
        /// <summary>
        /// The display upload product type is not supported in this campaign.
        /// </summary>
        [pbr::OriginalName("PRODUCT_TYPE_NOT_SUPPORTED_IN_THIS_CAMPAIGN")] ProductTypeNotSupportedInThisCampaign = 133,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
