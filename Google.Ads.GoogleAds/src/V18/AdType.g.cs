// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/ad_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/ad_type.proto</summary>
  public static partial class AdTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/ad_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvYWRfdHlwZS5wcm90",
            "bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4LmVudW1zIrEGCgpBZFR5cGVF",
            "bnVtIqIGCgZBZFR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "CwoHVEVYVF9BRBACEhQKEEVYUEFOREVEX1RFWFRfQUQQAxIeChpFWFBBTkRF",
            "RF9EWU5BTUlDX1NFQVJDSF9BRBAHEgwKCEhPVEVMX0FEEAgSFQoRU0hPUFBJ",
            "TkdfU01BUlRfQUQQCRIXChNTSE9QUElOR19QUk9EVUNUX0FEEAoSDAoIVklE",
            "RU9fQUQQDBIMCghJTUFHRV9BRBAOEhgKFFJFU1BPTlNJVkVfU0VBUkNIX0FE",
            "EA8SIAocTEVHQUNZX1JFU1BPTlNJVkVfRElTUExBWV9BRBAQEgoKBkFQUF9B",
            "RBAREhkKFUxFR0FDWV9BUFBfSU5TVEFMTF9BRBASEhkKFVJFU1BPTlNJVkVf",
            "RElTUExBWV9BRBATEgwKCExPQ0FMX0FEEBQSEwoPSFRNTDVfVVBMT0FEX0FE",
            "EBUSFAoQRFlOQU1JQ19IVE1MNV9BRBAWEhUKEUFQUF9FTkdBR0VNRU5UX0FE",
            "EBcSIgoeU0hPUFBJTkdfQ09NUEFSSVNPTl9MSVNUSU5HX0FEEBgSEwoPVklE",
            "RU9fQlVNUEVSX0FEEBkSJAogVklERU9fTk9OX1NLSVBQQUJMRV9JTl9TVFJF",
            "QU1fQUQQGhIWChJWSURFT19PVVRTVFJFQU1fQUQQGxIfChtWSURFT19UUlVF",
            "VklFV19JTl9TVFJFQU1fQUQQHRIXChNWSURFT19SRVNQT05TSVZFX0FEEB4S",
            "FQoRU01BUlRfQ0FNUEFJR05fQUQQHxILCgdDQUxMX0FEECASGwoXQVBQX1BS",
            "RV9SRUdJU1RSQVRJT05fQUQQIRIUChBJTl9GRUVEX1ZJREVPX0FEECISHQoZ",
            "REVNQU5EX0dFTl9NVUxUSV9BU1NFVF9BRBAoEhoKFkRFTUFORF9HRU5fQ0FS",
            "T1VTRUxfQUQQKRINCglUUkFWRUxfQUQQJRIiCh5ERU1BTkRfR0VOX1ZJREVP",
            "X1JFU1BPTlNJVkVfQUQQKhIZChVERU1BTkRfR0VOX1BST0RVQ1RfQUQQJ0Ll",
            "AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lbnVtc0ILQWRUeXBl",
            "UHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxOC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxOC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYxOFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxODo6",
            "RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.AdTypeEnum), global::Google.Ads.GoogleAds.V18.Enums.AdTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.AdTypeEnum.Types.AdType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible types of an ad.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdTypeEnum : pb::IMessage<AdTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdTypeEnum> _parser = new pb::MessageParser<AdTypeEnum>(() => new AdTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.AdTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTypeEnum(AdTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdTypeEnum Clone() {
      return new AdTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    public void MergeFrom(AdTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        /// Video TrueView in-stream ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUEVIEW_IN_STREAM_AD")] VideoTrueviewInStreamAd = 29,
        /// <summary>
        /// Video responsive ad.
        /// </summary>
        [pbr::OriginalName("VIDEO_RESPONSIVE_AD")] VideoResponsiveAd = 30,
        /// <summary>
        /// Smart campaign ad.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_AD")] SmartCampaignAd = 31,
        /// <summary>
        /// Call ad.
        /// </summary>
        [pbr::OriginalName("CALL_AD")] CallAd = 32,
        /// <summary>
        /// Universal app pre-registration ad.
        /// </summary>
        [pbr::OriginalName("APP_PRE_REGISTRATION_AD")] AppPreRegistrationAd = 33,
        /// <summary>
        /// In-feed video ad.
        /// </summary>
        [pbr::OriginalName("IN_FEED_VIDEO_AD")] InFeedVideoAd = 34,
        /// <summary>
        /// Demand Gen multi asset ad.
        /// </summary>
        [pbr::OriginalName("DEMAND_GEN_MULTI_ASSET_AD")] DemandGenMultiAssetAd = 40,
        /// <summary>
        /// Demand Gen carousel ad.
        /// </summary>
        [pbr::OriginalName("DEMAND_GEN_CAROUSEL_AD")] DemandGenCarouselAd = 41,
        /// <summary>
        /// Travel ad.
        /// </summary>
        [pbr::OriginalName("TRAVEL_AD")] TravelAd = 37,
        /// <summary>
        /// Demand Gen video responsive ad.
        /// </summary>
        [pbr::OriginalName("DEMAND_GEN_VIDEO_RESPONSIVE_AD")] DemandGenVideoResponsiveAd = 42,
        /// <summary>
        /// Demand Gen product ad.
        /// </summary>
        [pbr::OriginalName("DEMAND_GEN_PRODUCT_AD")] DemandGenProductAd = 39,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
