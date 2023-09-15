// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v14/enums/shopping_add_products_to_campaign_recommendation_enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V14.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v14/enums/shopping_add_products_to_campaign_recommendation_enum.proto</summary>
  public static partial class ShoppingAddProductsToCampaignRecommendationEnumReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v14/enums/shopping_add_products_to_campaign_recommendation_enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShoppingAddProductsToCampaignRecommendationEnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTQvZW51bXMvc2hvcHBpbmdfYWRk",
            "X3Byb2R1Y3RzX3RvX2NhbXBhaWduX3JlY29tbWVuZGF0aW9uX2VudW0ucHJv",
            "dG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNC5lbnVtcyKsAgovU2hvcHBp",
            "bmdBZGRQcm9kdWN0c1RvQ2FtcGFpZ25SZWNvbW1lbmRhdGlvbkVudW0i+AEK",
            "BlJlYXNvbhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARI1CjFNRVJD",
            "SEFOVF9DRU5URVJfQUNDT1VOVF9IQVNfTk9fU1VCTUlUVEVEX1BST0RVQ1RT",
            "EAISPQo5TUVSQ0hBTlRfQ0VOVEVSX0FDQ09VTlRfSEFTX05PX1NVQk1JVFRF",
            "RF9QUk9EVUNUU19JTl9GRUVEEAMSLQopQURTX0FDQ09VTlRfRVhDTFVERVNf",
            "T0ZGRVJTX0ZST01fQ0FNUEFJR04QBBIrCidBTExfUFJPRFVDVFNfQVJFX0VY",
            "Q0xVREVEX0ZST01fQ0FNUEFJR04QBUKOAgoiY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxNC5lbnVtc0I0U2hvcHBpbmdBZGRQcm9kdWN0c1RvQ2FtcGFp",
            "Z25SZWNvbW1lbmRhdGlvbkVudW1Qcm90b1ABWkNnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE0L2VudW1z",
            "O2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE0LkVudW1z",
            "ygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE0XEVudW1z6gIiR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjE0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V14.Enums.ShoppingAddProductsToCampaignRecommendationEnum), global::Google.Ads.GoogleAds.V14.Enums.ShoppingAddProductsToCampaignRecommendationEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V14.Enums.ShoppingAddProductsToCampaignRecommendationEnum.Types.Reason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Indicates the key issue that results in a shopping campaign targeting zero
  /// products.
  /// </summary>
  public sealed partial class ShoppingAddProductsToCampaignRecommendationEnum : pb::IMessage<ShoppingAddProductsToCampaignRecommendationEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ShoppingAddProductsToCampaignRecommendationEnum> _parser = new pb::MessageParser<ShoppingAddProductsToCampaignRecommendationEnum>(() => new ShoppingAddProductsToCampaignRecommendationEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ShoppingAddProductsToCampaignRecommendationEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V14.Enums.ShoppingAddProductsToCampaignRecommendationEnumReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShoppingAddProductsToCampaignRecommendationEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShoppingAddProductsToCampaignRecommendationEnum(ShoppingAddProductsToCampaignRecommendationEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ShoppingAddProductsToCampaignRecommendationEnum Clone() {
      return new ShoppingAddProductsToCampaignRecommendationEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ShoppingAddProductsToCampaignRecommendationEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ShoppingAddProductsToCampaignRecommendationEnum other) {
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
    public void MergeFrom(ShoppingAddProductsToCampaignRecommendationEnum other) {
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
    /// <summary>Container for nested types declared in the ShoppingAddProductsToCampaignRecommendationEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Issues that results in a shopping campaign targeting zero products.
      /// </summary>
      public enum Reason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The Merchant Center account does not have any submitted products.
        /// </summary>
        [pbr::OriginalName("MERCHANT_CENTER_ACCOUNT_HAS_NO_SUBMITTED_PRODUCTS")] MerchantCenterAccountHasNoSubmittedProducts = 2,
        /// <summary>
        /// The Merchant Center account does not have any submitted products in the
        /// feed.
        /// </summary>
        [pbr::OriginalName("MERCHANT_CENTER_ACCOUNT_HAS_NO_SUBMITTED_PRODUCTS_IN_FEED")] MerchantCenterAccountHasNoSubmittedProductsInFeed = 3,
        /// <summary>
        /// The Google Ads account has active campaign filters that prevents
        /// inclusion of offers in the campaign.
        /// </summary>
        [pbr::OriginalName("ADS_ACCOUNT_EXCLUDES_OFFERS_FROM_CAMPAIGN")] AdsAccountExcludesOffersFromCampaign = 4,
        /// <summary>
        /// All products available have been explicitly excluded from
        /// being targeted by the campaign.
        /// </summary>
        [pbr::OriginalName("ALL_PRODUCTS_ARE_EXCLUDED_FROM_CAMPAIGN")] AllProductsAreExcludedFromCampaign = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code