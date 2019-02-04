// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/advertising_channel_sub_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/advertising_channel_sub_type.proto</summary>
  public static partial class AdvertisingChannelSubTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/advertising_channel_sub_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelSubTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3N1Yl90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MC5lbnVtcyKkAgodQWR2ZXJ0aXNpbmdDaGFubmVsU3ViVHlwZUVudW0iggIK",
            "GUFkdmVydGlzaW5nQ2hhbm5lbFN1YlR5cGUSDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESFQoRU0VBUkNIX01PQklMRV9BUFAQAhIWChJESVNQTEFZ",
            "X01PQklMRV9BUFAQAxISCg5TRUFSQ0hfRVhQUkVTUxAEEhMKD0RJU1BMQVlf",
            "RVhQUkVTUxAFEhYKElNIT1BQSU5HX1NNQVJUX0FEUxAGEhQKEERJU1BMQVlf",
            "R01BSUxfQUQQBxIaChZESVNQTEFZX1NNQVJUX0NBTVBBSUdOEAgSEwoPVklE",
            "RU9fT1VUU1RSRUFNEAkSEAoMVklERU9fQUNUSU9OEApC8wEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IeQWR2ZXJ0aXNpbmdDaGFubmVs",
            "U3ViVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVtcztlbnVtc6ICA0dBQaoC",
            "HUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1zygIdR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjBcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "MDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An immutable specialization of an Advertising Channel.
  /// </summary>
  public sealed partial class AdvertisingChannelSubTypeEnum : pb::IMessage<AdvertisingChannelSubTypeEnum> {
    private static readonly pb::MessageParser<AdvertisingChannelSubTypeEnum> _parser = new pb::MessageParser<AdvertisingChannelSubTypeEnum>(() => new AdvertisingChannelSubTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdvertisingChannelSubTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.AdvertisingChannelSubTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelSubTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelSubTypeEnum(AdvertisingChannelSubTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdvertisingChannelSubTypeEnum Clone() {
      return new AdvertisingChannelSubTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdvertisingChannelSubTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdvertisingChannelSubTypeEnum other) {
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
    public void MergeFrom(AdvertisingChannelSubTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdvertisingChannelSubTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the different channel subtypes.
      /// </summary>
      public enum AdvertisingChannelSubType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used as a return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Mobile app campaigns for Search.
        /// </summary>
        [pbr::OriginalName("SEARCH_MOBILE_APP")] SearchMobileApp = 2,
        /// <summary>
        /// Mobile app campaigns for Display.
        /// </summary>
        [pbr::OriginalName("DISPLAY_MOBILE_APP")] DisplayMobileApp = 3,
        /// <summary>
        /// AdWords express campaigns for search.
        /// </summary>
        [pbr::OriginalName("SEARCH_EXPRESS")] SearchExpress = 4,
        /// <summary>
        /// AdWords Express campaigns for display.
        /// </summary>
        [pbr::OriginalName("DISPLAY_EXPRESS")] DisplayExpress = 5,
        /// <summary>
        /// Smart Shopping campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_SMART_ADS")] ShoppingSmartAds = 6,
        /// <summary>
        /// Gmail Ad campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_GMAIL_AD")] DisplayGmailAd = 7,
        /// <summary>
        /// Smart display campaigns.
        /// </summary>
        [pbr::OriginalName("DISPLAY_SMART_CAMPAIGN")] DisplaySmartCampaign = 8,
        /// <summary>
        /// Video Outstream campaigns.
        /// </summary>
        [pbr::OriginalName("VIDEO_OUTSTREAM")] VideoOutstream = 9,
        /// <summary>
        /// Video TrueView for Action campaigns.
        /// </summary>
        [pbr::OriginalName("VIDEO_ACTION")] VideoAction = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
