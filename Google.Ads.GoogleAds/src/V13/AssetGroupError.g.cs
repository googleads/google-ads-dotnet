// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/asset_group_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/asset_group_error.proto</summary>
  public static partial class AssetGroupErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/asset_group_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL2Fzc2V0X2dyb3Vw",
            "X2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMuZXJyb3Jz",
            "Ip0FChNBc3NldEdyb3VwRXJyb3JFbnVtIoUFCg9Bc3NldEdyb3VwRXJyb3IS",
            "DwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEgoORFVQTElDQVRFX05B",
            "TUUQAhIsCihDQU5OT1RfQUREX0FTU0VUX0dST1VQX0ZPUl9DQU1QQUlHTl9U",
            "WVBFEAMSHQoZTk9UX0VOT1VHSF9IRUFETElORV9BU1NFVBAEEiIKHk5PVF9F",
            "Tk9VR0hfTE9OR19IRUFETElORV9BU1NFVBAFEiAKHE5PVF9FTk9VR0hfREVT",
            "Q1JJUFRJT05fQVNTRVQQBhIiCh5OT1RfRU5PVUdIX0JVU0lORVNTX05BTUVf",
            "QVNTRVQQBxIkCiBOT1RfRU5PVUdIX01BUktFVElOR19JTUFHRV9BU1NFVBAI",
            "EisKJ05PVF9FTk9VR0hfU1FVQVJFX01BUktFVElOR19JTUFHRV9BU1NFVBAJ",
            "EhkKFU5PVF9FTk9VR0hfTE9HT19BU1NFVBAKEjwKOEZJTkFMX1VSTF9TSE9Q",
            "UElOR19NRVJDSEFOVF9IT01FX1BBR0VfVVJMX0RPTUFJTlNfRElGRkVSEAsS",
            "JAogUEFUSDFfUkVRVUlSRURfV0hFTl9QQVRIMl9JU19TRVQQDBIeChpTSE9S",
            "VF9ERVNDUklQVElPTl9SRVFVSVJFRBANEhYKEkZJTkFMX1VSTF9SRVFVSVJF",
            "RBAOEioKJkZJTkFMX1VSTF9DT05UQUlOU19JTlZBTElEX0RPTUFJTl9OQU1F",
            "EA8SHwobQURfQ1VTVE9NSVpFUl9OT1RfU1VQUE9SVEVEEBASMgouQ0FOTk9U",
            "X01VVEFURV9BU1NFVF9HUk9VUF9GT1JfUkVNT1ZFRF9DQU1QQUlHThARQvQB",
            "CiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEzLmVycm9yc0IUQXNzZXRH",
            "cm91cEVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMy9lcnJvcnM7ZXJyb3JzogID",
            "R0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEzLkVycm9yc8oCH0dvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYxM1xFcnJvcnPqAiNHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTM6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.AssetGroupErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.AssetGroupErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.AssetGroupErrorEnum.Types.AssetGroupError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset group errors.
  /// </summary>
  public sealed partial class AssetGroupErrorEnum : pb::IMessage<AssetGroupErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroupErrorEnum> _parser = new pb::MessageParser<AssetGroupErrorEnum>(() => new AssetGroupErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroupErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.AssetGroupErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum(AssetGroupErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroupErrorEnum Clone() {
      return new AssetGroupErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroupErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroupErrorEnum other) {
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
    public void MergeFrom(AssetGroupErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AssetGroupErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset group errors.
      /// </summary>
      public enum AssetGroupError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Each asset group in a single campaign must have a unique name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 2,
        /// <summary>
        /// Cannot add asset group for the campaign type.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_ASSET_GROUP_FOR_CAMPAIGN_TYPE")] CannotAddAssetGroupForCampaignType = 3,
        /// <summary>
        /// Not enough headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_HEADLINE_ASSET")] NotEnoughHeadlineAsset = 4,
        /// <summary>
        /// Not enough long headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_LONG_HEADLINE_ASSET")] NotEnoughLongHeadlineAsset = 5,
        /// <summary>
        /// Not enough description headline asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_DESCRIPTION_ASSET")] NotEnoughDescriptionAsset = 6,
        /// <summary>
        /// Not enough business name asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_BUSINESS_NAME_ASSET")] NotEnoughBusinessNameAsset = 7,
        /// <summary>
        /// Not enough marketing image asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_MARKETING_IMAGE_ASSET")] NotEnoughMarketingImageAsset = 8,
        /// <summary>
        /// Not enough square marketing image asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_SQUARE_MARKETING_IMAGE_ASSET")] NotEnoughSquareMarketingImageAsset = 9,
        /// <summary>
        /// Not enough logo asset for a valid asset group.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_LOGO_ASSET")] NotEnoughLogoAsset = 10,
        /// <summary>
        /// Final url and shopping merchant url does not have the same domain.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SHOPPING_MERCHANT_HOME_PAGE_URL_DOMAINS_DIFFER")] FinalUrlShoppingMerchantHomePageUrlDomainsDiffer = 11,
        /// <summary>
        /// Path1 required when path2 is set.
        /// </summary>
        [pbr::OriginalName("PATH1_REQUIRED_WHEN_PATH2_IS_SET")] Path1RequiredWhenPath2IsSet = 12,
        /// <summary>
        /// At least one short description asset is required for a valid asset group.
        /// </summary>
        [pbr::OriginalName("SHORT_DESCRIPTION_REQUIRED")] ShortDescriptionRequired = 13,
        /// <summary>
        /// Final url field is required for asset group.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_REQUIRED")] FinalUrlRequired = 14,
        /// <summary>
        /// Final url contains invalid domain name.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_CONTAINS_INVALID_DOMAIN_NAME")] FinalUrlContainsInvalidDomainName = 15,
        /// <summary>
        /// Ad customizers are not supported in asset group's text field.
        /// </summary>
        [pbr::OriginalName("AD_CUSTOMIZER_NOT_SUPPORTED")] AdCustomizerNotSupported = 16,
        /// <summary>
        /// Cannot mutate asset group for campaign with removed status.
        /// </summary>
        [pbr::OriginalName("CANNOT_MUTATE_ASSET_GROUP_FOR_REMOVED_CAMPAIGN")] CannotMutateAssetGroupForRemovedCampaign = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
