// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/conversion_value_rule_primary_dimension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/conversion_value_rule_primary_dimension.proto</summary>
  public static partial class ConversionValueRulePrimaryDimensionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/conversion_value_rule_primary_dimension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionValueRulePrimaryDimensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvY29udmVyc2lvbl92",
            "YWx1ZV9ydWxlX3ByaW1hcnlfZGltZW5zaW9uLnByb3RvEh5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MjAuZW51bXMi9gEKJ0NvbnZlcnNpb25WYWx1ZVJ1bGVQ",
            "cmltYXJ5RGltZW5zaW9uRW51bSLKAQojQ29udmVyc2lvblZhbHVlUnVsZVBy",
            "aW1hcnlEaW1lbnNpb24SDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "EwoPTk9fUlVMRV9BUFBMSUVEEAISDAoIT1JJR0lOQUwQAxIZChVORVdfVlNf",
            "UkVUVVJOSU5HX1VTRVIQBBIQCgxHRU9fTE9DQVRJT04QBRIKCgZERVZJQ0UQ",
            "BhIMCghBVURJRU5DRRAHEgwKCE1VTFRJUExFEAgSDQoJSVRJTkVSQVJZEAlC",
            "ggIKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXNCKENvbnZl",
            "cnNpb25WYWx1ZVJ1bGVQcmltYXJ5RGltZW5zaW9uUHJvdG9QAVpDZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YyMC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYyMC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxFbnVtc+oC",
            "Ikdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.ConversionValueRulePrimaryDimensionEnum), global::Google.Ads.GoogleAds.V20.Enums.ConversionValueRulePrimaryDimensionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.ConversionValueRulePrimaryDimensionEnum.Types.ConversionValueRulePrimaryDimension) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing value rule primary dimension for stats.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ConversionValueRulePrimaryDimensionEnum : pb::IMessage<ConversionValueRulePrimaryDimensionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionValueRulePrimaryDimensionEnum> _parser = new pb::MessageParser<ConversionValueRulePrimaryDimensionEnum>(() => new ConversionValueRulePrimaryDimensionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionValueRulePrimaryDimensionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.ConversionValueRulePrimaryDimensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRulePrimaryDimensionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRulePrimaryDimensionEnum(ConversionValueRulePrimaryDimensionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRulePrimaryDimensionEnum Clone() {
      return new ConversionValueRulePrimaryDimensionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionValueRulePrimaryDimensionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionValueRulePrimaryDimensionEnum other) {
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
    public void MergeFrom(ConversionValueRulePrimaryDimensionEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionValueRulePrimaryDimensionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Identifies the primary dimension for conversion value rule stats.
      /// </summary>
      public enum ConversionValueRulePrimaryDimension {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// For no-value-rule-applied conversions after value rule is enabled.
        /// </summary>
        [pbr::OriginalName("NO_RULE_APPLIED")] NoRuleApplied = 2,
        /// <summary>
        /// Below are for value-rule-applied conversions:
        /// The original stats.
        /// </summary>
        [pbr::OriginalName("ORIGINAL")] Original = 3,
        /// <summary>
        /// When a new or returning customer condition is satisfied.
        /// </summary>
        [pbr::OriginalName("NEW_VS_RETURNING_USER")] NewVsReturningUser = 4,
        /// <summary>
        /// When a query-time Geo location condition is satisfied.
        /// </summary>
        [pbr::OriginalName("GEO_LOCATION")] GeoLocation = 5,
        /// <summary>
        /// When a query-time browsing device condition is satisfied.
        /// </summary>
        [pbr::OriginalName("DEVICE")] Device = 6,
        /// <summary>
        /// When a query-time audience condition is satisfied.
        /// </summary>
        [pbr::OriginalName("AUDIENCE")] Audience = 7,
        /// <summary>
        /// When multiple rules are applied.
        /// </summary>
        [pbr::OriginalName("MULTIPLE")] Multiple = 8,
        /// <summary>
        /// When a query-time itinerary condition is satisfied.
        /// </summary>
        [pbr::OriginalName("ITINERARY")] Itinerary = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
