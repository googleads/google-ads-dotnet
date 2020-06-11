// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/ad_group_ad_rotation_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/ad_group_ad_rotation_mode.proto</summary>
  public static partial class AdGroupAdRotationModeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/ad_group_ad_rotation_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdRotationModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9hZF9ncm91cF9hZF9y",
            "b3RhdGlvbl9tb2RlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ0ChlBZEdyb3Vw",
            "QWRSb3RhdGlvbk1vZGVFbnVtIlcKFUFkR3JvdXBBZFJvdGF0aW9uTW9kZRIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIMCghPUFRJTUlaRRACEhIK",
            "DlJPVEFURV9GT1JFVkVSEANC7wEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MS5lbnVtc0IaQWRHcm91cEFkUm90YXRpb25Nb2RlUHJvdG9QAVpCZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YxL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjEuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFbnVtc+oC",
            "IUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.AdGroupAdRotationModeEnum), global::Google.Ads.GoogleAds.V1.Enums.AdGroupAdRotationModeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.AdGroupAdRotationModeEnum.Types.AdGroupAdRotationMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad rotation modes of ads within an
  /// ad group.
  /// </summary>
  public sealed partial class AdGroupAdRotationModeEnum : pb::IMessage<AdGroupAdRotationModeEnum> {
    private static readonly pb::MessageParser<AdGroupAdRotationModeEnum> _parser = new pb::MessageParser<AdGroupAdRotationModeEnum>(() => new AdGroupAdRotationModeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAdRotationModeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.AdGroupAdRotationModeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdRotationModeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdRotationModeEnum(AdGroupAdRotationModeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdRotationModeEnum Clone() {
      return new AdGroupAdRotationModeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdRotationModeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAdRotationModeEnum other) {
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
    public void MergeFrom(AdGroupAdRotationModeEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupAdRotationModeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible ad rotation modes of an ad group.
      /// </summary>
      public enum AdGroupAdRotationMode {
        /// <summary>
        /// The ad rotation mode has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Optimize ad group ads based on clicks or conversions.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE")] Optimize = 2,
        /// <summary>
        /// Rotate evenly forever.
        /// </summary>
        [pbr::OriginalName("ROTATE_FOREVER")] RotateForever = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
