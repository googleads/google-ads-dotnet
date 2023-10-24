// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/enums/ad_serving_optimization_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/enums/ad_serving_optimization_status.proto</summary>
  public static partial class AdServingOptimizationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/enums/ad_serving_optimization_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdServingOptimizationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvYWRfc2VydmluZ19v",
            "cHRpbWl6YXRpb25fc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTUuZW51bXMivAEKH0FkU2VydmluZ09wdGltaXphdGlvblN0YXR1c0Vu",
            "dW0imAEKG0FkU2VydmluZ09wdGltaXphdGlvblN0YXR1cxIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIMCghPUFRJTUlaRRACEhcKE0NPTlZFUlNJ",
            "T05fT1BUSU1JWkUQAxIKCgZST1RBVEUQBBIXChNST1RBVEVfSU5ERUZJTklU",
            "RUxZEAUSDwoLVU5BVkFJTEFCTEUQBkL6AQoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNS5lbnVtc0IgQWRTZXJ2aW5nT3B0aW1pemF0aW9uU3RhdHVz",
            "UHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxNS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYxNS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xl",
            "QWRzXFYxNVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNTo6",
            "RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Enums.AdServingOptimizationStatusEnum), global::Google.Ads.GoogleAds.V15.Enums.AdServingOptimizationStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Enums.AdServingOptimizationStatusEnum.Types.AdServingOptimizationStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Possible ad serving statuses of a campaign.
  /// </summary>
  public sealed partial class AdServingOptimizationStatusEnum : pb::IMessage<AdServingOptimizationStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdServingOptimizationStatusEnum> _parser = new pb::MessageParser<AdServingOptimizationStatusEnum>(() => new AdServingOptimizationStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdServingOptimizationStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Enums.AdServingOptimizationStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum(AdServingOptimizationStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdServingOptimizationStatusEnum Clone() {
      return new AdServingOptimizationStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdServingOptimizationStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdServingOptimizationStatusEnum other) {
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
    public void MergeFrom(AdServingOptimizationStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AdServingOptimizationStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible serving statuses.
      /// </summary>
      public enum AdServingOptimizationStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Ad serving is optimized based on CTR for the campaign.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE")] Optimize = 2,
        /// <summary>
        /// Ad serving is optimized based on CTR * Conversion for the campaign. If
        /// the campaign is not in the conversion optimizer bidding strategy, it will
        /// default to OPTIMIZED.
        /// </summary>
        [pbr::OriginalName("CONVERSION_OPTIMIZE")] ConversionOptimize = 3,
        /// <summary>
        /// Ads are rotated evenly for 90 days, then optimized for clicks.
        /// </summary>
        [pbr::OriginalName("ROTATE")] Rotate = 4,
        /// <summary>
        /// Show lower performing ads more evenly with higher performing ads, and do
        /// not optimize.
        /// </summary>
        [pbr::OriginalName("ROTATE_INDEFINITELY")] RotateIndefinitely = 5,
        /// <summary>
        /// Ad serving optimization status is not available.
        /// </summary>
        [pbr::OriginalName("UNAVAILABLE")] Unavailable = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
