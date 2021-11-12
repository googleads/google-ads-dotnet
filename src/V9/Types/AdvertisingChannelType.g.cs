// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/enums/advertising_channel_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/enums/advertising_channel_type.proto</summary>
  public static partial class AdvertisingChannelTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/enums/advertising_channel_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdvertisingChannelTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvItABChpBZHZlcnRp",
            "c2luZ0NoYW5uZWxUeXBlRW51bSKxAQoWQWR2ZXJ0aXNpbmdDaGFubmVsVHlw",
            "ZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZTRUFSQ0gQAhIL",
            "CgdESVNQTEFZEAMSDAoIU0hPUFBJTkcQBBIJCgVIT1RFTBAFEgkKBVZJREVP",
            "EAYSEQoNTVVMVElfQ0hBTk5FTBAHEgkKBUxPQ0FMEAgSCQoFU01BUlQQCRIT",
            "Cg9QRVJGT1JNQU5DRV9NQVgQCkLwAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LmVudW1zQhtBZHZlcnRpc2luZ0NoYW5uZWxUeXBlUHJvdG9QAVpC",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3Y5L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjkuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxFbnVt",
            "c+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum), global::Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The channel type a campaign may target to serve on.
  /// </summary>
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
      get { return global::Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeReflection.Descriptor.MessageTypes[0]; }
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
