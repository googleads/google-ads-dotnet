// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/ad_group_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/ad_group_type.proto</summary>
  public static partial class AdGroupTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/ad_group_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvYWRfZ3JvdXBfdHlw",
            "ZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVudW1zItIDCg9B",
            "ZEdyb3VwVHlwZUVudW0ivgMKC0FkR3JvdXBUeXBlEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEhMKD1NFQVJDSF9TVEFOREFSRBACEhQKEERJU1BM",
            "QVlfU1RBTkRBUkQQAxIYChRTSE9QUElOR19QUk9EVUNUX0FEUxAEEg0KCUhP",
            "VEVMX0FEUxAGEhYKElNIT1BQSU5HX1NNQVJUX0FEUxAHEhAKDFZJREVPX0JV",
            "TVBFUhAIEh0KGVZJREVPX1RSVUVfVklFV19JTl9TVFJFQU0QCRIeChpWSURF",
            "T19UUlVFX1ZJRVdfSU5fRElTUExBWRAKEiEKHVZJREVPX05PTl9TS0lQUEFC",
            "TEVfSU5fU1RSRUFNEAsSEwoPVklERU9fT1VUU1RSRUFNEAwSFgoSU0VBUkNI",
            "X0RZTkFNSUNfQURTEA0SIwofU0hPUFBJTkdfQ09NUEFSSVNPTl9MSVNUSU5H",
            "X0FEUxAOEhYKElBST01PVEVEX0hPVEVMX0FEUxAPEhQKEFZJREVPX1JFU1BP",
            "TlNJVkUQEBIZChVWSURFT19FRkZJQ0lFTlRfUkVBQ0gQERIWChJTTUFSVF9D",
            "QU1QQUlHTl9BRFMQEkLqAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MS5lbnVtc0IQQWRHcm91cFR5cGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjExL2VudW1z",
            "O2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjExLkVudW1z",
            "ygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjExXEVudW1z6gIiR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjExOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.AdGroupTypeEnum), global::Google.Ads.GoogleAds.V11.Enums.AdGroupTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.AdGroupTypeEnum.Types.AdGroupType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Defines types of an ad group, specific to a particular campaign channel
  /// type. This type drives validations that restrict which entities can be
  /// added to the ad group.
  /// </summary>
  public sealed partial class AdGroupTypeEnum : pb::IMessage<AdGroupTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupTypeEnum> _parser = new pb::MessageParser<AdGroupTypeEnum>(() => new AdGroupTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.AdGroupTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupTypeEnum(AdGroupTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupTypeEnum Clone() {
      return new AdGroupTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupTypeEnum other) {
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
    public void MergeFrom(AdGroupTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum listing the possible types of an ad group.
      /// </summary>
      public enum AdGroupType {
        /// <summary>
        /// The type has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The default ad group type for Search campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH_STANDARD")] SearchStandard = 2,
        /// <summary>
        /// The default ad group type for Display campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_STANDARD")] DisplayStandard = 3,
        /// <summary>
        /// The ad group type for Shopping campaigns serving standard product ads.
        /// </summary>
        [pbr::OriginalName("SHOPPING_PRODUCT_ADS")] ShoppingProductAds = 4,
        /// <summary>
        /// The default ad group type for Hotel campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL_ADS")] HotelAds = 6,
        /// <summary>
        /// The type for ad groups in Smart Shopping campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_SMART_ADS")] ShoppingSmartAds = 7,
        /// <summary>
        /// Short unskippable in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_BUMPER")] VideoBumper = 8,
        /// <summary>
        /// TrueView (skippable) in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUE_VIEW_IN_STREAM")] VideoTrueViewInStream = 9,
        /// <summary>
        /// TrueView in-display video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_TRUE_VIEW_IN_DISPLAY")] VideoTrueViewInDisplay = 10,
        /// <summary>
        /// Unskippable in-stream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_NON_SKIPPABLE_IN_STREAM")] VideoNonSkippableInStream = 11,
        /// <summary>
        /// Outstream video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_OUTSTREAM")] VideoOutstream = 12,
        /// <summary>
        /// Ad group type for Dynamic Search Ads ad groups.
        /// </summary>
        [pbr::OriginalName("SEARCH_DYNAMIC_ADS")] SearchDynamicAds = 13,
        /// <summary>
        /// The type for ad groups in Shopping Comparison Listing campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING_ADS")] ShoppingComparisonListingAds = 14,
        /// <summary>
        /// The ad group type for Promoted Hotel ad groups.
        /// </summary>
        [pbr::OriginalName("PROMOTED_HOTEL_ADS")] PromotedHotelAds = 15,
        /// <summary>
        /// Video responsive ad groups.
        /// </summary>
        [pbr::OriginalName("VIDEO_RESPONSIVE")] VideoResponsive = 16,
        /// <summary>
        /// Video efficient reach ad groups.
        /// </summary>
        [pbr::OriginalName("VIDEO_EFFICIENT_REACH")] VideoEfficientReach = 17,
        /// <summary>
        /// Ad group type for Smart campaigns.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_ADS")] SmartCampaignAds = 18,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code