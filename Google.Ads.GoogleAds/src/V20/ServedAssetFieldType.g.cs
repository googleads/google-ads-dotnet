// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/served_asset_field_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/served_asset_field_type.proto</summary>
  public static partial class ServedAssetFieldTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/served_asset_field_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServedAssetFieldTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvc2VydmVkX2Fzc2V0",
            "X2ZpZWxkX3R5cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5l",
            "bnVtcyKPBQoYU2VydmVkQXNzZXRGaWVsZFR5cGVFbnVtIvIEChRTZXJ2ZWRB",
            "c3NldEZpZWxkVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIO",
            "CgpIRUFETElORV8xEAISDgoKSEVBRExJTkVfMhADEg4KCkhFQURMSU5FXzMQ",
            "BBIRCg1ERVNDUklQVElPTl8xEAUSEQoNREVTQ1JJUFRJT05fMhAGEgwKCEhF",
            "QURMSU5FEAcSGAoUSEVBRExJTkVfSU5fUE9SVFJBSVQQCBIRCg1MT05HX0hF",
            "QURMSU5FEAkSDwoLREVTQ1JJUFRJT04QChIbChdERVNDUklQVElPTl9JTl9Q",
            "T1JUUkFJVBALEh0KGUJVU0lORVNTX05BTUVfSU5fUE9SVFJBSVQQDBIRCg1C",
            "VVNJTkVTU19OQU1FEA0SEwoPTUFSS0VUSU5HX0lNQUdFEA4SHwobTUFSS0VU",
            "SU5HX0lNQUdFX0lOX1BPUlRSQUlUEA8SGgoWU1FVQVJFX01BUktFVElOR19J",
            "TUFHRRAQEhwKGFBPUlRSQUlUX01BUktFVElOR19JTUFHRRAREggKBExPR08Q",
            "EhISCg5MQU5EU0NBUEVfTE9HTxATEhIKDkNBTExfVE9fQUNUSU9OEBQSEgoO",
            "WU9VX1RVQkVfVklERU8QFRIMCghTSVRFTElOSxAWEggKBENBTEwQFxIOCgpN",
            "T0JJTEVfQVBQEBgSCwoHQ0FMTE9VVBAZEhYKElNUUlVDVFVSRURfU05JUFBF",
            "VBAaEgkKBVBSSUNFEBsSDQoJUFJPTU9USU9OEBwSDAoIQURfSU1BR0UQHRIN",
            "CglMRUFEX0ZPUk0QHhIRCg1CVVNJTkVTU19MT0dPEB9C8wEKImNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXNCGVNlcnZlZEFzc2V0RmllbGRU",
            "eXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9lbnVtcztlbnVtc6ICA0dBQaoCHkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYyMC5FbnVtc8oCHkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFYyMFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYy",
            "MDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.ServedAssetFieldTypeEnum), global::Google.Ads.GoogleAds.V20.Enums.ServedAssetFieldTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset field types.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ServedAssetFieldTypeEnum : pb::IMessage<ServedAssetFieldTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ServedAssetFieldTypeEnum> _parser = new pb::MessageParser<ServedAssetFieldTypeEnum>(() => new ServedAssetFieldTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ServedAssetFieldTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.ServedAssetFieldTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServedAssetFieldTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServedAssetFieldTypeEnum(ServedAssetFieldTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ServedAssetFieldTypeEnum Clone() {
      return new ServedAssetFieldTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ServedAssetFieldTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ServedAssetFieldTypeEnum other) {
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
    public void MergeFrom(ServedAssetFieldTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ServedAssetFieldTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible asset field types.
      /// </summary>
      public enum ServedAssetFieldType {
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
        /// The asset is used in headline 1.
        /// </summary>
        [pbr::OriginalName("HEADLINE_1")] Headline1 = 2,
        /// <summary>
        /// The asset is used in headline 2.
        /// </summary>
        [pbr::OriginalName("HEADLINE_2")] Headline2 = 3,
        /// <summary>
        /// The asset is used in headline 3.
        /// </summary>
        [pbr::OriginalName("HEADLINE_3")] Headline3 = 4,
        /// <summary>
        /// The asset is used in description 1.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION_1")] Description1 = 5,
        /// <summary>
        /// The asset is used in description 2.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION_2")] Description2 = 6,
        /// <summary>
        /// The asset was used in a headline. Use this only if there is only one
        /// headline in the ad. Otherwise, use the HEADLINE_1, HEADLINE_2 or
        /// HEADLINE_3 enums
        /// </summary>
        [pbr::OriginalName("HEADLINE")] Headline = 7,
        /// <summary>
        /// The asset was used as a headline in portrait image.
        /// </summary>
        [pbr::OriginalName("HEADLINE_IN_PORTRAIT")] HeadlineInPortrait = 8,
        /// <summary>
        /// The asset was used in a long headline (used in MultiAssetResponsiveAd).
        /// </summary>
        [pbr::OriginalName("LONG_HEADLINE")] LongHeadline = 9,
        /// <summary>
        /// The asset was used in a description. Use this only if there is only one
        /// description in the ad. Otherwise, use the DESCRIPTION_1 or DESCRIPTION_@
        /// enums
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 10,
        /// <summary>
        /// The asset was used as description in portrait image.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION_IN_PORTRAIT")] DescriptionInPortrait = 11,
        /// <summary>
        /// The asset was used as business name in portrait image.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME_IN_PORTRAIT")] BusinessNameInPortrait = 12,
        /// <summary>
        /// The asset was used as business name.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME")] BusinessName = 13,
        /// <summary>
        /// The asset was used as a marketing image.
        /// </summary>
        [pbr::OriginalName("MARKETING_IMAGE")] MarketingImage = 14,
        /// <summary>
        /// The asset was used as a marketing image in portrait image.
        /// </summary>
        [pbr::OriginalName("MARKETING_IMAGE_IN_PORTRAIT")] MarketingImageInPortrait = 15,
        /// <summary>
        /// The asset was used as a square marketing image.
        /// </summary>
        [pbr::OriginalName("SQUARE_MARKETING_IMAGE")] SquareMarketingImage = 16,
        /// <summary>
        /// The asset was used as a portrait marketing image.
        /// </summary>
        [pbr::OriginalName("PORTRAIT_MARKETING_IMAGE")] PortraitMarketingImage = 17,
        /// <summary>
        /// The asset was used as a logo.
        /// </summary>
        [pbr::OriginalName("LOGO")] Logo = 18,
        /// <summary>
        /// The asset was used as a landscape logo.
        /// </summary>
        [pbr::OriginalName("LANDSCAPE_LOGO")] LandscapeLogo = 19,
        /// <summary>
        /// The asset was used as a call-to-action.
        /// </summary>
        [pbr::OriginalName("CALL_TO_ACTION")] CallToAction = 20,
        /// <summary>
        /// The asset was used as a YouTube video.
        /// </summary>
        [pbr::OriginalName("YOU_TUBE_VIDEO")] YouTubeVideo = 21,
        /// <summary>
        /// This asset is used as a sitelink.
        /// </summary>
        [pbr::OriginalName("SITELINK")] Sitelink = 22,
        /// <summary>
        /// This asset is used as a call.
        /// </summary>
        [pbr::OriginalName("CALL")] Call = 23,
        /// <summary>
        /// This asset is used as a mobile app.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP")] MobileApp = 24,
        /// <summary>
        /// This asset is used as a callout.
        /// </summary>
        [pbr::OriginalName("CALLOUT")] Callout = 25,
        /// <summary>
        /// This asset is used as a structured snippet.
        /// </summary>
        [pbr::OriginalName("STRUCTURED_SNIPPET")] StructuredSnippet = 26,
        /// <summary>
        /// This asset is used as a price.
        /// </summary>
        [pbr::OriginalName("PRICE")] Price = 27,
        /// <summary>
        /// This asset is used as a promotion.
        /// </summary>
        [pbr::OriginalName("PROMOTION")] Promotion = 28,
        /// <summary>
        /// This asset is used as an image.
        /// </summary>
        [pbr::OriginalName("AD_IMAGE")] AdImage = 29,
        /// <summary>
        /// The asset is used as a lead form.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM")] LeadForm = 30,
        /// <summary>
        /// The asset is used as a business logo.
        /// </summary>
        [pbr::OriginalName("BUSINESS_LOGO")] BusinessLogo = 31,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
