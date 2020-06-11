// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/product_bidding_category_level.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/product_bidding_category_level.proto</summary>
  public static partial class ProductBiddingCategoryLevelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/product_bidding_category_level.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductBiddingCategoryLevelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9wcm9kdWN0X2JpZGRp",
            "bmdfY2F0ZWdvcnlfbGV2ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpoBCh9Q",
            "cm9kdWN0QmlkZGluZ0NhdGVnb3J5TGV2ZWxFbnVtIncKG1Byb2R1Y3RCaWRk",
            "aW5nQ2F0ZWdvcnlMZXZlbBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIKCgZMRVZFTDEQAhIKCgZMRVZFTDIQAxIKCgZMRVZFTDMQBBIKCgZMRVZF",
            "TDQQBRIKCgZMRVZFTDUQBkL1AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxLmVudW1zQiBQcm9kdWN0QmlkZGluZ0NhdGVnb3J5TGV2ZWxQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryLevelEnum), global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryLevelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryLevelEnum.Types.ProductBiddingCategoryLevel) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Level of a product bidding category.
  /// </summary>
  public sealed partial class ProductBiddingCategoryLevelEnum : pb::IMessage<ProductBiddingCategoryLevelEnum> {
    private static readonly pb::MessageParser<ProductBiddingCategoryLevelEnum> _parser = new pb::MessageParser<ProductBiddingCategoryLevelEnum>(() => new ProductBiddingCategoryLevelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductBiddingCategoryLevelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.ProductBiddingCategoryLevelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryLevelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryLevelEnum(ProductBiddingCategoryLevelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductBiddingCategoryLevelEnum Clone() {
      return new ProductBiddingCategoryLevelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductBiddingCategoryLevelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductBiddingCategoryLevelEnum other) {
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
    public void MergeFrom(ProductBiddingCategoryLevelEnum other) {
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
    /// <summary>Container for nested types declared in the ProductBiddingCategoryLevelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the level of the product bidding category.
      /// </summary>
      public enum ProductBiddingCategoryLevel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Level 1.
        /// </summary>
        [pbr::OriginalName("LEVEL1")] Level1 = 2,
        /// <summary>
        /// Level 2.
        /// </summary>
        [pbr::OriginalName("LEVEL2")] Level2 = 3,
        /// <summary>
        /// Level 3.
        /// </summary>
        [pbr::OriginalName("LEVEL3")] Level3 = 4,
        /// <summary>
        /// Level 4.
        /// </summary>
        [pbr::OriginalName("LEVEL4")] Level4 = 5,
        /// <summary>
        /// Level 5.
        /// </summary>
        [pbr::OriginalName("LEVEL5")] Level5 = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
