// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/ad_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/ad_type.proto</summary>
  public static partial class AdTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/ad_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZF90eXBlLnByb3Rv",
            "Eh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtcyK8AQoKQWRUeXBlRW51",
            "bSKtAQoGQWRUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsK",
            "B1RFWFRfQUQQAhIUChBFWFBBTkRFRF9URVhUX0FEEAMSFQoRRFlOQU1JQ19T",
            "RUFSQ0hfQUQQBBIZChVSRVNQT05TSVZFX0RJU1BMQVlfQUQQBRIQCgxDQUxM",
            "X09OTFlfQUQQBhIeChpFWFBBTkRFRF9EWU5BTUlDX1NFQVJDSF9BRBAHQrwB",
            "CiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXNCC0FkVHlwZVBy",
            "b3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYwLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AdTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.AdTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AdTypeEnum.Types.AdType) }, null)
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
      get { return global::Google.Ads.GoogleAds.V0.Enums.AdTypeReflection.Descriptor.MessageTypes[0]; }
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
        /// The ad is a dynamic search ad.
        /// </summary>
        [pbr::OriginalName("DYNAMIC_SEARCH_AD")] DynamicSearchAd = 4,
        /// <summary>
        /// The ad is a responsive display ad.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_DISPLAY_AD")] ResponsiveDisplayAd = 5,
        /// <summary>
        /// The ad is a call only ad.
        /// </summary>
        [pbr::OriginalName("CALL_ONLY_AD")] CallOnlyAd = 6,
        /// <summary>
        /// The ad is an expanded dynamic search ad.
        /// </summary>
        [pbr::OriginalName("EXPANDED_DYNAMIC_SEARCH_AD")] ExpandedDynamicSearchAd = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
