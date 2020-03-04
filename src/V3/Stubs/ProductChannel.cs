// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/product_channel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/product_channel.proto</summary>
  public static partial class ProductChannelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/product_channel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductChannelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9wcm9kdWN0X2NoYW5u",
            "ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIlsKElByb2R1Y3RDaGFubmVsRW51",
            "bSJFCg5Qcm9kdWN0Q2hhbm5lbBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIKCgZPTkxJTkUQAhIJCgVMT0NBTBADQugBCiFjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjMuZW51bXNCE1Byb2R1Y3RDaGFubmVsUHJvdG9QAVpC",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWM1xFbnVt",
            "c+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.ProductChannelEnum), global::Google.Ads.GoogleAds.V3.Enums.ProductChannelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.ProductChannelEnum.Types.ProductChannel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Locality of a product offer.
  /// </summary>
  public sealed partial class ProductChannelEnum : pb::IMessage<ProductChannelEnum> {
    private static readonly pb::MessageParser<ProductChannelEnum> _parser = new pb::MessageParser<ProductChannelEnum>(() => new ProductChannelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductChannelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.ProductChannelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum(ProductChannelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum Clone() {
      return new ProductChannelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductChannelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductChannelEnum other) {
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
    public void MergeFrom(ProductChannelEnum other) {
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
    /// <summary>Container for nested types declared in the ProductChannelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the locality of a product offer.
      /// </summary>
      public enum ProductChannel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The item is sold online.
        /// </summary>
        [pbr::OriginalName("ONLINE")] Online = 2,
        /// <summary>
        /// The item is sold in local stores.
        /// </summary>
        [pbr::OriginalName("LOCAL")] Local = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
