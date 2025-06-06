// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/asset_link_primary_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/asset_link_primary_status.proto</summary>
  public static partial class AssetLinkPrimaryStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/asset_link_primary_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetLinkPrimaryStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvYXNzZXRfbGlua19w",
            "cmltYXJ5X3N0YXR1cy5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIw",
            "LmVudW1zIqgBChpBc3NldExpbmtQcmltYXJ5U3RhdHVzRW51bSKJAQoWQXNz",
            "ZXRMaW5rUHJpbWFyeVN0YXR1cxIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIMCghFTElHSUJMRRACEgoKBlBBVVNFRBADEgsKB1JFTU9WRUQQBBIL",
            "CgdQRU5ESU5HEAUSCwoHTElNSVRFRBAGEhAKDE5PVF9FTElHSUJMRRAHQvUB",
            "CiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zQhtBc3NldExp",
            "bmtQcmltYXJ5U3RhdHVzUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyMC5FbnVtc8oCHkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYyMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.AssetLinkPrimaryStatusEnum), global::Google.Ads.GoogleAds.V20.Enums.AssetLinkPrimaryStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.AssetLinkPrimaryStatusEnum.Types.AssetLinkPrimaryStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Provides the primary status of an asset link.
  /// For example: a sitelink may be paused for a particular campaign.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetLinkPrimaryStatusEnum : pb::IMessage<AssetLinkPrimaryStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetLinkPrimaryStatusEnum> _parser = new pb::MessageParser<AssetLinkPrimaryStatusEnum>(() => new AssetLinkPrimaryStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetLinkPrimaryStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.AssetLinkPrimaryStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetLinkPrimaryStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetLinkPrimaryStatusEnum(AssetLinkPrimaryStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetLinkPrimaryStatusEnum Clone() {
      return new AssetLinkPrimaryStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetLinkPrimaryStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetLinkPrimaryStatusEnum other) {
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
    public void MergeFrom(AssetLinkPrimaryStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AssetLinkPrimaryStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum Provides insight into why an asset is not serving or not serving
      /// at full capacity for a particular link level. There could be one status
      /// with multiple reasons. For example, a sitelink might be paused by the user,
      /// but also limited in serving due to violation of an alcohol policy. In
      /// this case, the PrimaryStatus will be returned as PAUSED, since the asset's
      /// effective status is determined by its paused state.
      /// </summary>
      public enum AssetLinkPrimaryStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The asset is eligible to serve.
        /// </summary>
        [pbr::OriginalName("ELIGIBLE")] Eligible = 2,
        /// <summary>
        /// The user-specified asset link status is paused.
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 3,
        /// <summary>
        /// The user-specified asset link status is removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 4,
        /// <summary>
        /// The asset may serve in the future.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 5,
        /// <summary>
        /// The asset is serving in a partial capacity.
        /// </summary>
        [pbr::OriginalName("LIMITED")] Limited = 6,
        /// <summary>
        /// The asset is not eligible to serve.
        /// </summary>
        [pbr::OriginalName("NOT_ELIGIBLE")] NotEligible = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
