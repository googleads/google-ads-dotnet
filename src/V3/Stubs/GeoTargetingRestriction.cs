// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/geo_targeting_restriction.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/geo_targeting_restriction.proto</summary>
  public static partial class GeoTargetingRestrictionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/geo_targeting_restriction.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeoTargetingRestrictionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9nZW9fdGFyZ2V0aW5n",
            "X3Jlc3RyaWN0aW9uLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52My5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJwChtHZW9UYXJn",
            "ZXRpbmdSZXN0cmljdGlvbkVudW0iUQoXR2VvVGFyZ2V0aW5nUmVzdHJpY3Rp",
            "b24SDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESGAoUTE9DQVRJT05f",
            "T0ZfUFJFU0VOQ0UQAkLxAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LmVudW1zQhxHZW9UYXJnZXRpbmdSZXN0cmljdGlvblByb3RvUAFaQmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92My9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYzLkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcRW51bXPqAiFH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.GeoTargetingRestrictionEnum), global::Google.Ads.GoogleAds.V3.Enums.GeoTargetingRestrictionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.GeoTargetingRestrictionEnum.Types.GeoTargetingRestriction) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing feed item geo targeting restriction.
  /// </summary>
  public sealed partial class GeoTargetingRestrictionEnum : pb::IMessage<GeoTargetingRestrictionEnum> {
    private static readonly pb::MessageParser<GeoTargetingRestrictionEnum> _parser = new pb::MessageParser<GeoTargetingRestrictionEnum>(() => new GeoTargetingRestrictionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GeoTargetingRestrictionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.GeoTargetingRestrictionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingRestrictionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingRestrictionEnum(GeoTargetingRestrictionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetingRestrictionEnum Clone() {
      return new GeoTargetingRestrictionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GeoTargetingRestrictionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GeoTargetingRestrictionEnum other) {
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
    public void MergeFrom(GeoTargetingRestrictionEnum other) {
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
    /// <summary>Container for nested types declared in the GeoTargetingRestrictionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// A restriction used to determine if the request context's
      /// geo should be matched.
      /// </summary>
      public enum GeoTargetingRestriction {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Indicates that request context should match the physical location of
        /// the user.
        /// </summary>
        [pbr::OriginalName("LOCATION_OF_PRESENCE")] LocationOfPresence = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
