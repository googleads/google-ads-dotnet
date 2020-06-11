// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/negative_geo_target_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/negative_geo_target_type.proto</summary>
  public static partial class NegativeGeoTargetTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/negative_geo_target_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NegativeGeoTargetTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9uZWdhdGl2ZV9nZW9f",
            "dGFyZ2V0X3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvInoKGU5lZ2F0aXZl",
            "R2VvVGFyZ2V0VHlwZUVudW0iXQoVTmVnYXRpdmVHZW9UYXJnZXRUeXBlEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhgKFFBSRVNFTkNFX09SX0lO",
            "VEVSRVNUEAQSDAoIUFJFU0VOQ0UQBULvAQohY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYyLmVudW1zQhpOZWdhdGl2ZUdlb1RhcmdldFR5cGVQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.NegativeGeoTargetTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.NegativeGeoTargetTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.NegativeGeoTargetTypeEnum.Types.NegativeGeoTargetType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible negative geo target types.
  /// </summary>
  public sealed partial class NegativeGeoTargetTypeEnum : pb::IMessage<NegativeGeoTargetTypeEnum> {
    private static readonly pb::MessageParser<NegativeGeoTargetTypeEnum> _parser = new pb::MessageParser<NegativeGeoTargetTypeEnum>(() => new NegativeGeoTargetTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NegativeGeoTargetTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.NegativeGeoTargetTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NegativeGeoTargetTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NegativeGeoTargetTypeEnum(NegativeGeoTargetTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NegativeGeoTargetTypeEnum Clone() {
      return new NegativeGeoTargetTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NegativeGeoTargetTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NegativeGeoTargetTypeEnum other) {
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
    public void MergeFrom(NegativeGeoTargetTypeEnum other) {
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
    /// <summary>Container for nested types declared in the NegativeGeoTargetTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible negative geo target types.
      /// </summary>
      public enum NegativeGeoTargetType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Specifies that a user is excluded from seeing the ad if they
        /// are in, or show interest in, advertiser's excluded locations.
        /// </summary>
        [pbr::OriginalName("PRESENCE_OR_INTEREST")] PresenceOrInterest = 4,
        /// <summary>
        /// Specifies that a user is excluded from seeing the ad if they
        /// are in advertiser's excluded locations.
        /// </summary>
        [pbr::OriginalName("PRESENCE")] Presence = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
