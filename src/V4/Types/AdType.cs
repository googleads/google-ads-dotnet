// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/ad_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/ad_type.proto</summary>
  public static partial class AdTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/ad_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9hZF90eXBlLnByb3Rv",
            "Eh1nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtcxocZ29vZ2xlL2FwaS9h",
            "bm5vdGF0aW9ucy5wcm90byKSBQoKQWRUeXBlRW51bSKDBQoGQWRUeXBlEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB1RFWFRfQUQQAhIUChBF",
            "WFBBTkRFRF9URVhUX0FEEAMSEAoMQ0FMTF9PTkxZX0FEEAYSHgoaRVhQQU5E",
            "RURfRFlOQU1JQ19TRUFSQ0hfQUQQBxIMCghIT1RFTF9BRBAIEhUKEVNIT1BQ",
            "SU5HX1NNQVJUX0FEEAkSFwoTU0hPUFBJTkdfUFJPRFVDVF9BRBAKEgwKCFZJ",
            "REVPX0FEEAwSDAoIR01BSUxfQUQQDRIMCghJTUFHRV9BRBAOEhgKFFJFU1BP",
            "TlNJVkVfU0VBUkNIX0FEEA8SIAocTEVHQUNZX1JFU1BPTlNJVkVfRElTUExB",
            "WV9BRBAQEgoKBkFQUF9BRBAREhkKFUxFR0FDWV9BUFBfSU5TVEFMTF9BRBAS",
            "EhkKFVJFU1BPTlNJVkVfRElTUExBWV9BRBATEgwKCExPQ0FMX0FEEBQSEwoP",
            "SFRNTDVfVVBMT0FEX0FEEBUSFAoQRFlOQU1JQ19IVE1MNV9BRBAWEhUKEUFQ",
            "UF9FTkdBR0VNRU5UX0FEEBcSIgoeU0hPUFBJTkdfQ09NUEFSSVNPTl9MSVNU",
            "SU5HX0FEEBgSEwoPVklERU9fQlVNUEVSX0FEEBkSJAogVklERU9fTk9OX1NL",
            "SVBQQUJMRV9JTl9TVFJFQU1fQUQQGhIWChJWSURFT19PVVRTVFJFQU1fQUQQ",
            "GxIfChtWSURFT19UUlVFVklFV19ESVNDT1ZFUllfQUQQHBIfChtWSURFT19U",
            "UlVFVklFV19JTl9TVFJFQU1fQUQQHRIXChNWSURFT19SRVNQT05TSVZFX0FE",
            "EB5C4AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtc0ILQWRU",
            "eXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2VudW1zO2VudW1zogIDR0FBqgIdR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjQuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWNFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpF",
            "bnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.AdTypeEnum), global::Google.Ads.GoogleAds.V4.Enums.AdTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.AdTypeEnum.Types.AdType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible types of an ad.
  /// </summary>
  public sealed partial class AdTypeEnum : pb::IMessage<AdTypeEnum> {
    private static readonly pb::MessageParser<AdTypeEnum> _parser = new pb::MessageParser<AdTypeEnum>(() => new AdTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.AdTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTypeEnum(AdTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdTypeEnum Clone() {
      return new AdTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdTypeEnum other) {
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
    public void MergeFrom(AdTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible types of an ad.
      /// </summary>
      public enum AdType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The ad is a text ad.
        /// </summary>
        [pbr::OriginalName("TEXT_AD")] TextAd = 2,
        /// <summary>
        /// The ad is an expanded text ad.
        /// </summary>
        [pbr::OriginalName("EXPANDED_TEXT_AD")] ExpandedTextAd = 3,
        /// <summary>
        /// The ad is a call only ad.
        /// </summary>
        [pbr::OriginalName("CALL_ONLY_AD")] CallOnlyAd = 6,
        /// <summary>
        /// The ad is an expanded dynamic search ad.
        /// </summary>
        [pbr::OriginalName("EXPANDED_DYNAMIC_SEARCH_AD")] ExpandedDynamicSearchAd = 7,
        /// <summary>
        /// The ad is a hotel ad.
        /// </summary>
        [pbr::OriginalName("HOTEL_AD")] HotelAd = 8,
        /// <summary>
        /// The ad is a Smart Shopping ad.
        /// </summary>
        [pbr::OriginalName("SHOPPING_SMART_AD")] ShoppingSmartAd = 9,
        /// <summary>
        /// The ad is a standard Shopping ad.
        /// </summary>
        [pbr::OriginalName("SHOPPING_PRODUCT_AD")] ShoppingProductAd = 10,
        /// <summary>
        /// The ad is a video ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_AD")] VideoAd = 12,
        /// <summary>
        /// This ad is a Gmail ad.
        /// </summary>
        [pbr::OriginalName("GMAIL_AD")] GmailAd = 13,
        /// <summary>
        /// This ad is an Image ad.
        /// </summary>
        [pbr::OriginalName("IMAGE_AD")] ImageAd = 14,
        /// <summary>
        /// The ad is a responsive search ad.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_SEARCH_AD")] ResponsiveSearchAd = 15,
        /// <summary>
        /// The ad is a legacy responsive display ad.
        /// </summary>
        [pbr::OriginalName("LEGACY_RESPONSIVE_DISPLAY_AD")] LegacyResponsiveDisplayAd = 16,
        /// <summary>
        /// The ad is an app ad.
        /// </summary>
        [pbr::OriginalName("APP_AD")] AppAd = 17,
        /// <summary>
        /// The ad is a legacy app install ad.
        /// </summary>
        [pbr::OriginalName("LEGACY_APP_INSTALL_AD")] LegacyAppInstallAd = 18,
        /// <summary>
        /// The ad is a responsive display ad.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_DISPLAY_AD")] ResponsiveDisplayAd = 19,
        /// <summary>
        /// The ad is a local ad.
        /// </summary>
        [pbr::OriginalName("LOCAL_AD")] LocalAd = 20,
        /// <summary>
        /// The ad is a display upload ad with the HTML5_UPLOAD_AD product type.
        /// </summary>
        [pbr::OriginalName("HTML5_UPLOAD_AD")] Html5UploadAd = 21,
        /// <summary>
        /// The ad is a display upload ad with one of the DYNAMIC_HTML5_* product
        /// types.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_HTML5_AD")] DynamicHtml5Ad = 22,
        /// <summary>
        /// The ad is an app engagement ad.
        /// </summary>
        [pbr::OriginalName("APP_ENGAGEMENT_AD")] AppEngagementAd = 23,
        /// <summary>
        /// The ad is a Shopping Comparison Listing ad.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING_AD")] ShoppingComparisonListingAd = 24,
        /// <summary>
        /// Video bumper ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_BUMPER_AD")] VideoBumperAd = 25,
        /// <summary>
        /// Video non-skippable in-stream ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_NON_SKIPPABLE_IN_STREAM_AD")] VideoNonSkippableInStreamAd = 26,
        /// <summary>
        /// Video outstream ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_OUTSTREAM_AD")] VideoOutstreamAd = 27,
        /// <summary>
        /// Video TrueView in-display ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUEVIEW_DISCOVERY_AD")] VideoTrueviewDiscoveryAd = 28,
        /// <summary>
        /// Video TrueView in-stream ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUEVIEW_IN_STREAM_AD")] VideoTrueviewInStreamAd = 29,
        /// <summary>
        /// Video responsive ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_RESPONSIVE_AD")] VideoResponsiveAd = 30,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
