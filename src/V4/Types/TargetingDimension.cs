// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/targeting_dimension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/targeting_dimension.proto</summary>
  public static partial class TargetingDimensionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/targeting_dimension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetingDimensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy90YXJnZXRpbmdfZGlt",
            "ZW5zaW9uLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtcxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLEAQoWVGFyZ2V0aW5nRGlt",
            "ZW5zaW9uRW51bSKpAQoSVGFyZ2V0aW5nRGltZW5zaW9uEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEgsKB0tFWVdPUkQQAhIMCghBVURJRU5DRRAD",
            "EgkKBVRPUElDEAQSCgoGR0VOREVSEAUSDQoJQUdFX1JBTkdFEAYSDQoJUExB",
            "Q0VNRU5UEAcSEwoPUEFSRU5UQUxfU1RBVFVTEAgSEAoMSU5DT01FX1JBTkdF",
            "EAlC7AEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtc0IXVGFy",
            "Z2V0aW5nRGltZW5zaW9uUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2VudW1zO2VudW1z",
            "ogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuRW51bXPKAh1Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWNFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlY0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.TargetingDimensionEnum), global::Google.Ads.GoogleAds.V4.Enums.TargetingDimensionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.TargetingDimensionEnum.Types.TargetingDimension) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The dimensions that can be targeted.
  /// </summary>
  public sealed partial class TargetingDimensionEnum : pb::IMessage<TargetingDimensionEnum> {
    private static readonly pb::MessageParser<TargetingDimensionEnum> _parser = new pb::MessageParser<TargetingDimensionEnum>(() => new TargetingDimensionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TargetingDimensionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.TargetingDimensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingDimensionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingDimensionEnum(TargetingDimensionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingDimensionEnum Clone() {
      return new TargetingDimensionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TargetingDimensionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TargetingDimensionEnum other) {
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
    public void MergeFrom(TargetingDimensionEnum other) {
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
    /// <summary>Container for nested types declared in the TargetingDimensionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible targeting dimensions.
      /// </summary>
      public enum TargetingDimension {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword criteria, e.g. 'mars cruise'. KEYWORD may be used as a custom bid
        /// dimension. Keywords are always a targeting dimension, so may not be set
        /// as a target "ALL" dimension with TargetRestriction.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 2,
        /// <summary>
        /// Audience criteria, which include user list, user interest, custom
        /// affinity,  and custom in market.
        /// </summary>
        [pbr::OriginalName("AUDIENCE")] Audience = 3,
        /// <summary>
        /// Topic criteria for targeting categories of content, e.g.
        /// 'category::Animals>Pets' Used for Display and Video targeting.
        /// </summary>
        [pbr::OriginalName("TOPIC")] Topic = 4,
        /// <summary>
        /// Criteria for targeting gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 5,
        /// <summary>
        /// Criteria for targeting age ranges.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 6,
        /// <summary>
        /// Placement criteria, which include websites like 'www.flowers4sale.com',
        /// as well as mobile applications, mobile app categories, YouTube videos,
        /// and YouTube channels.
        /// </summary>
        [pbr::OriginalName("PLACEMENT")] Placement = 7,
        /// <summary>
        /// Criteria for parental status targeting.
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 8,
        /// <summary>
        /// Criteria for income range targeting.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
