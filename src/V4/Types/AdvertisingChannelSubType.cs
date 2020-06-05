// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/advertising_channel_sub_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/advertising_channel_sub_type.proto</summary>
  public static partial class AdvertisingChannelSubTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/advertising_channel_sub_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelSubTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3N1Yl90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "NC5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKpAwodQWR2",
            "ZXJ0aXNpbmdDaGFubmVsU3ViVHlwZUVudW0ihwMKGUFkdmVydGlzaW5nQ2hh",
            "bm5lbFN1YlR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESFQoR",
            "U0VBUkNIX01PQklMRV9BUFAQAhIWChJESVNQTEFZX01PQklMRV9BUFAQAxIS",
            "Cg5TRUFSQ0hfRVhQUkVTUxAEEhMKD0RJU1BMQVlfRVhQUkVTUxAFEhYKElNI",
            "T1BQSU5HX1NNQVJUX0FEUxAGEhQKEERJU1BMQVlfR01BSUxfQUQQBxIaChZE",
            "SVNQTEFZX1NNQVJUX0NBTVBBSUdOEAgSEwoPVklERU9fT1VUU1RSRUFNEAkS",
            "EAoMVklERU9fQUNUSU9OEAoSFwoTVklERU9fTk9OX1NLSVBQQUJMRRALEhAK",
            "DEFQUF9DQU1QQUlHThAMEh8KG0FQUF9DQU1QQUlHTl9GT1JfRU5HQUdFTUVO",
            "VBANEhIKDkxPQ0FMX0NBTVBBSUdOEA4SIwofU0hPUFBJTkdfQ09NUEFSSVNP",
            "Tl9MSVNUSU5HX0FEUxAPQvMBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djQuZW51bXNCHkFkdmVydGlzaW5nQ2hhbm5lbFN1YlR5cGVQcm90b1ABWkJn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjQvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WNC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XEVudW1z",
            "6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjQ6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelSubTypeEnum), global::Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelSubTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelSubTypeEnum.Types.AdvertisingChannelSubType) }, null, null)
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
      get { return global::Google.Ads.GoogleAds.V4.Enums.AdvertisingChannelSubTypeReflection.Descriptor.MessageTypes[0]; }
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
        /// <summary>
        /// Video campaigns with non-skippable video ads.
        /// </summary>
        [pbr::OriginalName("VIDEO_NON_SKIPPABLE")] VideoNonSkippable = 11,
        /// <summary>
        /// App Campaign that allows you to easily promote your Android or iOS app
        /// across Google's top properties including Search, Play, YouTube, and the
        /// Google Display Network.
        /// </summary>
        [pbr::OriginalName("APP_CAMPAIGN")] AppCampaign = 12,
        /// <summary>
        /// App Campaign for engagement, focused on driving re-engagement with the
        /// app across several of Google’s top properties including Search, YouTube,
        /// and the Google Display Network.
        /// </summary>
        [pbr::OriginalName("APP_CAMPAIGN_FOR_ENGAGEMENT")] AppCampaignForEngagement = 13,
        /// <summary>
        /// Campaigns specialized for local advertising.
        /// </summary>
        [pbr::OriginalName("LOCAL_CAMPAIGN")] LocalCampaign = 14,
        /// <summary>
        /// Shopping Comparison Listing campaigns.
        /// </summary>
        [pbr::OriginalName("SHOPPING_COMPARISON_LISTING_ADS")] ShoppingComparisonListingAds = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
