// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/enums/custom_conversion_goal_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/enums/custom_conversion_goal_status.proto</summary>
  public static partial class CustomConversionGoalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/enums/custom_conversion_goal_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomConversionGoalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZW51bXMvY3VzdG9tX2NvbnZl",
            "cnNpb25fZ29hbF9zdGF0dXMucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxOC5lbnVtcyJ2Ch5DdXN0b21Db252ZXJzaW9uR29hbFN0YXR1c0VudW0i",
            "VAoaQ3VzdG9tQ29udmVyc2lvbkdvYWxTdGF0dXMSDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESCwoHRU5BQkxFRBACEgsKB1JFTU9WRUQQA0L5AQoi",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOC5lbnVtc0IfQ3VzdG9tQ29u",
            "dmVyc2lvbkdvYWxTdGF0dXNQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE4L2VudW1zO2Vu",
            "dW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE4LkVudW1zygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjE4XEVudW1z6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjE4OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Enums.CustomConversionGoalStatusEnum), global::Google.Ads.GoogleAds.V18.Enums.CustomConversionGoalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Enums.CustomConversionGoalStatusEnum.Types.CustomConversionGoalStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of a custom conversion goal.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CustomConversionGoalStatusEnum : pb::IMessage<CustomConversionGoalStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomConversionGoalStatusEnum> _parser = new pb::MessageParser<CustomConversionGoalStatusEnum>(() => new CustomConversionGoalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomConversionGoalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Enums.CustomConversionGoalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomConversionGoalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomConversionGoalStatusEnum(CustomConversionGoalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomConversionGoalStatusEnum Clone() {
      return new CustomConversionGoalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomConversionGoalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomConversionGoalStatusEnum other) {
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
    public void MergeFrom(CustomConversionGoalStatusEnum other) {
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
    /// <summary>Container for nested types declared in the CustomConversionGoalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible statuses of a custom conversion goal.
      /// </summary>
      public enum CustomConversionGoalStatus {
        /// <summary>
        /// The status has not been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The custom conversion goal is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// The custom conversion goal is removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
