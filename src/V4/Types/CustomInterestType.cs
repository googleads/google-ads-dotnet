// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/custom_interest_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/custom_interest_type.proto</summary>
  public static partial class CustomInterestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/custom_interest_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomInterestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9jdXN0b21faW50ZXJl",
            "c3RfdHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8idAoWQ3VzdG9tSW50ZXJl",
            "c3RUeXBlRW51bSJaChJDdXN0b21JbnRlcmVzdFR5cGUSDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESEwoPQ1VTVE9NX0FGRklOSVRZEAISEQoNQ1VT",
            "VE9NX0lOVEVOVBADQuwBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQu",
            "ZW51bXNCF0N1c3RvbUludGVyZXN0VHlwZVByb3RvUAFaQmdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9l",
            "bnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY0LkVu",
            "dW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjRcRW51bXPqAiFHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWNDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.CustomInterestTypeEnum), global::Google.Ads.GoogleAds.V4.Enums.CustomInterestTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.CustomInterestTypeEnum.Types.CustomInterestType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The types of custom interest.
  /// </summary>
  public sealed partial class CustomInterestTypeEnum : pb::IMessage<CustomInterestTypeEnum> {
    private static readonly pb::MessageParser<CustomInterestTypeEnum> _parser = new pb::MessageParser<CustomInterestTypeEnum>(() => new CustomInterestTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomInterestTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.CustomInterestTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestTypeEnum(CustomInterestTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestTypeEnum Clone() {
      return new CustomInterestTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomInterestTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomInterestTypeEnum other) {
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
    public void MergeFrom(CustomInterestTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CustomInterestTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum containing possible custom interest types.
      /// </summary>
      public enum CustomInterestType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Allows brand advertisers to define custom affinity audience lists.
        /// </summary>
        [pbr::OriginalName("CUSTOM_AFFINITY")] CustomAffinity = 2,
        /// <summary>
        /// Allows advertisers to define custom intent audience lists.
        /// </summary>
        [pbr::OriginalName("CUSTOM_INTENT")] CustomIntent = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
