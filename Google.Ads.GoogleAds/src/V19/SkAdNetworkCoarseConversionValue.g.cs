// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/sk_ad_network_coarse_conversion_value.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/sk_ad_network_coarse_conversion_value.proto</summary>
  public static partial class SkAdNetworkCoarseConversionValueReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/sk_ad_network_coarse_conversion_value.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SkAdNetworkCoarseConversionValueReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvc2tfYWRfbmV0d29y",
            "a19jb2Fyc2VfY29udmVyc2lvbl92YWx1ZS5wcm90bxIeZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE5LmVudW1zIqIBCiRTa0FkTmV0d29ya0NvYXJzZUNvbnZl",
            "cnNpb25WYWx1ZUVudW0iegogU2tBZE5ldHdvcmtDb2Fyc2VDb252ZXJzaW9u",
            "VmFsdWUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDwoLVU5BVkFJ",
            "TEFCTEUQAhIHCgNMT1cQAxIKCgZNRURJVU0QBBIICgRISUdIEAUSCAoETk9O",
            "RRAGQv8BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5LmVudW1zQiVT",
            "a0FkTmV0d29ya0NvYXJzZUNvbnZlcnNpb25WYWx1ZVByb3RvUAFaQ2dvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MTkvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFk",
            "cy5WMTkuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTlcRW51bXPq",
            "AiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTk6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.SkAdNetworkCoarseConversionValueEnum), global::Google.Ads.GoogleAds.V19.Enums.SkAdNetworkCoarseConversionValueEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.SkAdNetworkCoarseConversionValueEnum.Types.SkAdNetworkCoarseConversionValue) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of SkAdNetwork coarse conversion values.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SkAdNetworkCoarseConversionValueEnum : pb::IMessage<SkAdNetworkCoarseConversionValueEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SkAdNetworkCoarseConversionValueEnum> _parser = new pb::MessageParser<SkAdNetworkCoarseConversionValueEnum>(() => new SkAdNetworkCoarseConversionValueEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SkAdNetworkCoarseConversionValueEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.SkAdNetworkCoarseConversionValueReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkCoarseConversionValueEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkCoarseConversionValueEnum(SkAdNetworkCoarseConversionValueEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SkAdNetworkCoarseConversionValueEnum Clone() {
      return new SkAdNetworkCoarseConversionValueEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SkAdNetworkCoarseConversionValueEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SkAdNetworkCoarseConversionValueEnum other) {
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
    public void MergeFrom(SkAdNetworkCoarseConversionValueEnum other) {
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
    /// <summary>Container for nested types declared in the SkAdNetworkCoarseConversionValueEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates SkAdNetwork coarse conversion values
      /// </summary>
      public enum SkAdNetworkCoarseConversionValue {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The value was not present in the postback or we do not have this data for
        /// other reasons.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 2,
        /// <summary>
        /// A low coarse conversion value.
        /// </summary>
        [pbr::OriginalName("LOW")] Low = 3,
        /// <summary>
        /// A medium coarse conversion value.
        /// </summary>
        [pbr::OriginalName("MEDIUM")] Medium = 4,
        /// <summary>
        /// A high coarse conversion value.
        /// </summary>
        [pbr::OriginalName("HIGH")] High = 5,
        /// <summary>
        /// A coarse conversion value was not configured.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
