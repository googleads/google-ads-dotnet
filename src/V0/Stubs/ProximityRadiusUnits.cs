// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/proximity_radius_units.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/proximity_radius_units.proto</summary>
  public static partial class ProximityRadiusUnitsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/proximity_radius_units.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProximityRadiusUnitsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wcm94aW1pdHlfcmFk",
            "aXVzX3VuaXRzLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVt",
            "cyJrChhQcm94aW1pdHlSYWRpdXNVbml0c0VudW0iTwoUUHJveGltaXR5UmFk",
            "aXVzVW5pdHMSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESCQoFTUlM",
            "RVMQAhIOCgpLSUxPTUVURVJTEANC7gEKIWNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MC5lbnVtc0IZUHJveGltaXR5UmFkaXVzVW5pdHNQcm90b1ABWkJn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjAvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1z",
            "6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ProximityRadiusUnitsEnum), global::Google.Ads.GoogleAds.V0.Enums.ProximityRadiusUnitsEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ProximityRadiusUnitsEnum.Types.ProximityRadiusUnits) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing unit of radius in proximity.
  /// </summary>
  public sealed partial class ProximityRadiusUnitsEnum : pb::IMessage<ProximityRadiusUnitsEnum> {
    private static readonly pb::MessageParser<ProximityRadiusUnitsEnum> _parser = new pb::MessageParser<ProximityRadiusUnitsEnum>(() => new ProximityRadiusUnitsEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProximityRadiusUnitsEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ProximityRadiusUnitsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProximityRadiusUnitsEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProximityRadiusUnitsEnum(ProximityRadiusUnitsEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProximityRadiusUnitsEnum Clone() {
      return new ProximityRadiusUnitsEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProximityRadiusUnitsEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProximityRadiusUnitsEnum other) {
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
    public void MergeFrom(ProximityRadiusUnitsEnum other) {
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
    /// <summary>Container for nested types declared in the ProximityRadiusUnitsEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The unit of radius distance in proximity (e.g. MILES)
      /// </summary>
      public enum ProximityRadiusUnits {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Miles
        /// </summary>
        [pbr::OriginalName("MILES")] Miles = 2,
        /// <summary>
        /// Kilometers
        /// </summary>
        [pbr::OriginalName("KILOMETERS")] Kilometers = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
