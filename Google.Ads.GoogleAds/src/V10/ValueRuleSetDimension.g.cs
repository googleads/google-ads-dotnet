// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/value_rule_set_dimension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/value_rule_set_dimension.proto</summary>
  public static partial class ValueRuleSetDimensionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/value_rule_set_dimension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValueRuleSetDimensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvdmFsdWVfcnVsZV9z",
            "ZXRfZGltZW5zaW9uLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAu",
            "ZW51bXMikAEKGVZhbHVlUnVsZVNldERpbWVuc2lvbkVudW0icwoVVmFsdWVS",
            "dWxlU2V0RGltZW5zaW9uEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EhAKDEdFT19MT0NBVElPThACEgoKBkRFVklDRRADEgwKCEFVRElFTkNFEAQS",
            "EAoMTk9fQ09ORElUSU9OEAVC9AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTAuZW51bXNCGlZhbHVlUnVsZVNldERpbWVuc2lvblByb3RvUAFaQ2dv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTAvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMTAuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcRW51",
            "bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.ValueRuleSetDimensionEnum), global::Google.Ads.GoogleAds.V10.Enums.ValueRuleSetDimensionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible dimensions of a conversion value rule
  /// set.
  /// </summary>
  public sealed partial class ValueRuleSetDimensionEnum : pb::IMessage<ValueRuleSetDimensionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ValueRuleSetDimensionEnum> _parser = new pb::MessageParser<ValueRuleSetDimensionEnum>(() => new ValueRuleSetDimensionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ValueRuleSetDimensionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.ValueRuleSetDimensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueRuleSetDimensionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueRuleSetDimensionEnum(ValueRuleSetDimensionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ValueRuleSetDimensionEnum Clone() {
      return new ValueRuleSetDimensionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ValueRuleSetDimensionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ValueRuleSetDimensionEnum other) {
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
    public void MergeFrom(ValueRuleSetDimensionEnum other) {
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
    /// <summary>Container for nested types declared in the ValueRuleSetDimensionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible dimensions of a conversion value rule set.
      /// </summary>
      public enum ValueRuleSetDimension {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Dimension for geo location.
        /// </summary>
        [pbr::OriginalName("GEO_LOCATION")] GeoLocation = 2,
        /// <summary>
        /// Dimension for device type.
        /// </summary>
        [pbr::OriginalName("DEVICE")] Device = 3,
        /// <summary>
        /// Dimension for audience.
        /// </summary>
        [pbr::OriginalName("AUDIENCE")] Audience = 4,
        /// <summary>
        /// This dimension implies the rule will always apply.
        /// </summary>
        [pbr::OriginalName("NO_CONDITION")] NoCondition = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
