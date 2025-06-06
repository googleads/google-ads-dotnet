// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/advertising_channel_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/advertising_channel_type.proto</summary>
  public static partial class AdvertisingChannelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/advertising_channel_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvYWR2ZXJ0aXNpbmdf",
            "Y2hhbm5lbF90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAu",
            "ZW51bXMigAIKGkFkdmVydGlzaW5nQ2hhbm5lbFR5cGVFbnVtIuEBChZBZHZl",
            "cnRpc2luZ0NoYW5uZWxUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEgoKBlNFQVJDSBACEgsKB0RJU1BMQVkQAxIMCghTSE9QUElORxAEEgkK",
            "BUhPVEVMEAUSCQoFVklERU8QBhIRCg1NVUxUSV9DSEFOTkVMEAcSCQoFTE9D",
            "QUwQCBIJCgVTTUFSVBAJEhMKD1BFUkZPUk1BTkNFX01BWBAKEhIKDkxPQ0FM",
            "X1NFUlZJQ0VTEAsSCgoGVFJBVkVMEA0SDgoKREVNQU5EX0dFThAOQvUBCiJj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zQhtBZHZlcnRpc2lu",
            "Z0NoYW5uZWxUeXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9lbnVtcztlbnVtc6IC",
            "A0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyMC5FbnVtc8oCHkdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYyMFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYyMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum), global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The channel type a campaign may target to serve on.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdvertisingChannelTypeEnum : pb::IMessage<AdvertisingChannelTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdvertisingChannelTypeEnum> _parser = new pb::MessageParser<AdvertisingChannelTypeEnum>(() => new AdvertisingChannelTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdvertisingChannelTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvertisingChannelTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvertisingChannelTypeEnum(AdvertisingChannelTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdvertisingChannelTypeEnum Clone() {
      return new AdvertisingChannelTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdvertisingChannelTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdvertisingChannelTypeEnum other) {
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
    public void MergeFrom(AdvertisingChannelTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AdvertisingChannelTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the various advertising channel types.
      /// </summary>
      public enum AdvertisingChannelType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Search Network. Includes display bundled, and Search+ campaigns.
        /// </summary>
        [pbr::OriginalName("SEARCH")] Search = 2,
        /// <summary>
        /// Google Display Network only.
        /// </summary>
        [pbr::OriginalName("DISPLAY")] Display = 3,
        /// <summary>
        /// Shopping campaigns serve on the shopping property
        /// and on google.com search results.
        /// </summary>
        [pbr::OriginalName("SHOPPING")] Shopping = 4,
        /// <summary>
        /// Hotel Ads campaigns.
        /// </summary>
        [pbr::OriginalName("HOTEL")] Hotel = 5,
        /// <summary>
        /// Video campaigns.
        /// </summary>
        [pbr::OriginalName("VIDEO")] Video = 6,
        /// <summary>
        /// App Campaigns, and App Campaigns for Engagement, that run
        /// across multiple channels.
        /// </summary>
        [pbr::OriginalName("MULTI_CHANNEL")] MultiChannel = 7,
        /// <summary>
        /// Local ads campaigns.
        /// </summary>
        [pbr::OriginalName("LOCAL")] Local = 8,
        /// <summary>
        /// Smart campaigns.
        /// </summary>
        [pbr::OriginalName("SMART")] Smart = 9,
        /// <summary>
        /// Performance Max campaigns.
        /// </summary>
        [pbr::OriginalName("PERFORMANCE_MAX")] PerformanceMax = 10,
        /// <summary>
        /// Local services campaigns.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICES")] LocalServices = 11,
        /// <summary>
        /// Travel campaigns.
        /// </summary>
        [pbr::OriginalName("TRAVEL")] Travel = 13,
        /// <summary>
        /// Demand Gen campaigns.
        /// </summary>
        [pbr::OriginalName("DEMAND_GEN")] DemandGen = 14,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
