// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/product_condition.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/product_condition.proto</summary>
  public static partial class ProductConditionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/product_condition.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductConditionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wcm9kdWN0X2NvbmRp",
            "dGlvbi5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXMaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ibAoUUHJvZHVjdENvbmRpdGlv",
            "bkVudW0iVAoQUHJvZHVjdENvbmRpdGlvbhIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIHCgNORVcQAxIPCgtSRUZVUkJJU0hFRBAEEggKBFVTRUQQ",
            "BULqAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zQhVQcm9k",
            "dWN0Q29uZGl0aW9uUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2VudW1zogID",
            "R0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1Hb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductConditionEnum), global::Google.Ads.GoogleAds.V2.Enums.ProductConditionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.ProductConditionEnum.Types.ProductCondition) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Condition of a product offer.
  /// </summary>
  public sealed partial class ProductConditionEnum : pb::IMessage<ProductConditionEnum> {
    private static readonly pb::MessageParser<ProductConditionEnum> _parser = new pb::MessageParser<ProductConditionEnum>(() => new ProductConditionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductConditionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.ProductConditionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductConditionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductConditionEnum(ProductConditionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductConditionEnum Clone() {
      return new ProductConditionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductConditionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductConditionEnum other) {
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
    public void MergeFrom(ProductConditionEnum other) {
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
    /// <summary>Container for nested types declared in the ProductConditionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the condition of a product offer.
      /// </summary>
      public enum ProductCondition {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The product condition is new.
        /// </summary>
        [pbr::OriginalName("NEW")] New = 3,
        /// <summary>
        /// The product condition is refurbished.
        /// </summary>
        [pbr::OriginalName("REFURBISHED")] Refurbished = 4,
        /// <summary>
        /// The product condition is used.
        /// </summary>
        [pbr::OriginalName("USED")] Used = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
