// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/price_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/price_placeholder_field.proto</summary>
  public static partial class PricePlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/price_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PricePlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvcHJpY2VfcGxhY2Vo",
            "b2xkZXJfZmllbGQucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5l",
            "bnVtcyLvCQoZUHJpY2VQbGFjZWhvbGRlckZpZWxkRW51bSLRCQoVUHJpY2VQ",
            "bGFjZWhvbGRlckZpZWxkEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EggKBFRZUEUQAhITCg9QUklDRV9RVUFMSUZJRVIQAxIVChFUUkFDS0lOR19U",
            "RU1QTEFURRAEEgwKCExBTkdVQUdFEAUSFAoQRklOQUxfVVJMX1NVRkZJWBAG",
            "EhEKDUlURU1fMV9IRUFERVIQZBIWChJJVEVNXzFfREVTQ1JJUFRJT04QZRIQ",
            "CgxJVEVNXzFfUFJJQ0UQZhIPCgtJVEVNXzFfVU5JVBBnEhUKEUlURU1fMV9G",
            "SU5BTF9VUkxTEGgSHAoYSVRFTV8xX0ZJTkFMX01PQklMRV9VUkxTEGkSEgoN",
            "SVRFTV8yX0hFQURFUhDIARIXChJJVEVNXzJfREVTQ1JJUFRJT04QyQESEQoM",
            "SVRFTV8yX1BSSUNFEMoBEhAKC0lURU1fMl9VTklUEMsBEhYKEUlURU1fMl9G",
            "SU5BTF9VUkxTEMwBEh0KGElURU1fMl9GSU5BTF9NT0JJTEVfVVJMUxDNARIS",
            "Cg1JVEVNXzNfSEVBREVSEKwCEhcKEklURU1fM19ERVNDUklQVElPThCtAhIR",
            "CgxJVEVNXzNfUFJJQ0UQrgISEAoLSVRFTV8zX1VOSVQQrwISFgoRSVRFTV8z",
            "X0ZJTkFMX1VSTFMQsAISHQoYSVRFTV8zX0ZJTkFMX01PQklMRV9VUkxTELEC",
            "EhIKDUlURU1fNF9IRUFERVIQkAMSFwoSSVRFTV80X0RFU0NSSVBUSU9OEJED",
            "EhEKDElURU1fNF9QUklDRRCSAxIQCgtJVEVNXzRfVU5JVBCTAxIWChFJVEVN",
            "XzRfRklOQUxfVVJMUxCUAxIdChhJVEVNXzRfRklOQUxfTU9CSUxFX1VSTFMQ",
            "lQMSEgoNSVRFTV81X0hFQURFUhD0AxIXChJJVEVNXzVfREVTQ1JJUFRJT04Q",
            "9QMSEQoMSVRFTV81X1BSSUNFEPYDEhAKC0lURU1fNV9VTklUEPcDEhYKEUlU",
            "RU1fNV9GSU5BTF9VUkxTEPgDEh0KGElURU1fNV9GSU5BTF9NT0JJTEVfVVJM",
            "UxD5AxISCg1JVEVNXzZfSEVBREVSENgEEhcKEklURU1fNl9ERVNDUklQVElP",
            "ThDZBBIRCgxJVEVNXzZfUFJJQ0UQ2gQSEAoLSVRFTV82X1VOSVQQ2wQSFgoR",
            "SVRFTV82X0ZJTkFMX1VSTFMQ3AQSHQoYSVRFTV82X0ZJTkFMX01PQklMRV9V",
            "UkxTEN0EEhIKDUlURU1fN19IRUFERVIQvAUSFwoSSVRFTV83X0RFU0NSSVBU",
            "SU9OEL0FEhEKDElURU1fN19QUklDRRC+BRIQCgtJVEVNXzdfVU5JVBC/BRIW",
            "ChFJVEVNXzdfRklOQUxfVVJMUxDABRIdChhJVEVNXzdfRklOQUxfTU9CSUxF",
            "X1VSTFMQwQUSEgoNSVRFTV84X0hFQURFUhCgBhIXChJJVEVNXzhfREVTQ1JJ",
            "UFRJT04QoQYSEQoMSVRFTV84X1BSSUNFEKIGEhAKC0lURU1fOF9VTklUEKMG",
            "EhYKEUlURU1fOF9GSU5BTF9VUkxTEKQGEh0KGElURU1fOF9GSU5BTF9NT0JJ",
            "TEVfVVJMUxClBkL0AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5l",
            "bnVtc0IaUHJpY2VQbGFjZWhvbGRlckZpZWxkUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "MC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "MC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMFxFbnVtc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.PricePlaceholderFieldEnum), global::Google.Ads.GoogleAds.V10.Enums.PricePlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.PricePlaceholderFieldEnum.Types.PricePlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Price placeholder fields.
  /// </summary>
  public sealed partial class PricePlaceholderFieldEnum : pb::IMessage<PricePlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PricePlaceholderFieldEnum> _parser = new pb::MessageParser<PricePlaceholderFieldEnum>(() => new PricePlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PricePlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.PricePlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PricePlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PricePlaceholderFieldEnum(PricePlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PricePlaceholderFieldEnum Clone() {
      return new PricePlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PricePlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PricePlaceholderFieldEnum other) {
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
    public void MergeFrom(PricePlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the PricePlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Price placeholder fields.
      /// </summary>
      public enum PricePlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The type of your price feed. Must match one of the
        /// predefined price feed type exactly.
        /// </summary>
        [pbr::OriginalName("TYPE")] Type = 2,
        /// <summary>
        /// Data Type: STRING. The qualifier of each price. Must match one of the
        /// predefined price qualifiers exactly.
        /// </summary>
        [pbr::OriginalName("PRICE_QUALIFIER")] PriceQualifier = 3,
        /// <summary>
        /// Data Type: URL. Tracking template for the price feed when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_TEMPLATE")] TrackingTemplate = 4,
        /// <summary>
        /// Data Type: STRING. Language of the price feed. Must match one of the
        /// available available locale codes exactly.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 5,
        /// <summary>
        /// Data Type: STRING. Final URL suffix for the price feed when using
        /// parallel tracking.
        /// </summary>
        [pbr::OriginalName("FINAL_URL_SUFFIX")] FinalUrlSuffix = 6,
        /// <summary>
        /// Data Type: STRING. The header of item 1 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_1_HEADER")] Item1Header = 100,
        /// <summary>
        /// Data Type: STRING. The description of item 1 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_1_DESCRIPTION")] Item1Description = 101,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 1 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_1_PRICE")] Item1Price = 102,
        /// <summary>
        /// Data Type: STRING. The price unit of item 1 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_1_UNIT")] Item1Unit = 103,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 1 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_1_FINAL_URLS")] Item1FinalUrls = 104,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 1 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_1_FINAL_MOBILE_URLS")] Item1FinalMobileUrls = 105,
        /// <summary>
        /// Data Type: STRING. The header of item 2 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_2_HEADER")] Item2Header = 200,
        /// <summary>
        /// Data Type: STRING. The description of item 2 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_2_DESCRIPTION")] Item2Description = 201,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 2 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_2_PRICE")] Item2Price = 202,
        /// <summary>
        /// Data Type: STRING. The price unit of item 2 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_2_UNIT")] Item2Unit = 203,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 2 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_2_FINAL_URLS")] Item2FinalUrls = 204,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 2 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_2_FINAL_MOBILE_URLS")] Item2FinalMobileUrls = 205,
        /// <summary>
        /// Data Type: STRING. The header of item 3 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_3_HEADER")] Item3Header = 300,
        /// <summary>
        /// Data Type: STRING. The description of item 3 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_3_DESCRIPTION")] Item3Description = 301,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 3 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_3_PRICE")] Item3Price = 302,
        /// <summary>
        /// Data Type: STRING. The price unit of item 3 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_3_UNIT")] Item3Unit = 303,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 3 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_3_FINAL_URLS")] Item3FinalUrls = 304,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 3 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_3_FINAL_MOBILE_URLS")] Item3FinalMobileUrls = 305,
        /// <summary>
        /// Data Type: STRING. The header of item 4 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_4_HEADER")] Item4Header = 400,
        /// <summary>
        /// Data Type: STRING. The description of item 4 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_4_DESCRIPTION")] Item4Description = 401,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 4 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_4_PRICE")] Item4Price = 402,
        /// <summary>
        /// Data Type: STRING. The price unit of item 4 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_4_UNIT")] Item4Unit = 403,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 4 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_4_FINAL_URLS")] Item4FinalUrls = 404,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 4 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_4_FINAL_MOBILE_URLS")] Item4FinalMobileUrls = 405,
        /// <summary>
        /// Data Type: STRING. The header of item 5 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_5_HEADER")] Item5Header = 500,
        /// <summary>
        /// Data Type: STRING. The description of item 5 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_5_DESCRIPTION")] Item5Description = 501,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 5 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_5_PRICE")] Item5Price = 502,
        /// <summary>
        /// Data Type: STRING. The price unit of item 5 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_5_UNIT")] Item5Unit = 503,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 5 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_5_FINAL_URLS")] Item5FinalUrls = 504,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 5 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_5_FINAL_MOBILE_URLS")] Item5FinalMobileUrls = 505,
        /// <summary>
        /// Data Type: STRING. The header of item 6 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_6_HEADER")] Item6Header = 600,
        /// <summary>
        /// Data Type: STRING. The description of item 6 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_6_DESCRIPTION")] Item6Description = 601,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 6 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_6_PRICE")] Item6Price = 602,
        /// <summary>
        /// Data Type: STRING. The price unit of item 6 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_6_UNIT")] Item6Unit = 603,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 6 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_6_FINAL_URLS")] Item6FinalUrls = 604,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 6 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_6_FINAL_MOBILE_URLS")] Item6FinalMobileUrls = 605,
        /// <summary>
        /// Data Type: STRING. The header of item 7 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_7_HEADER")] Item7Header = 700,
        /// <summary>
        /// Data Type: STRING. The description of item 7 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_7_DESCRIPTION")] Item7Description = 701,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 7 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_7_PRICE")] Item7Price = 702,
        /// <summary>
        /// Data Type: STRING. The price unit of item 7 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_7_UNIT")] Item7Unit = 703,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 7 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_7_FINAL_URLS")] Item7FinalUrls = 704,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 7 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_7_FINAL_MOBILE_URLS")] Item7FinalMobileUrls = 705,
        /// <summary>
        /// Data Type: STRING. The header of item 8 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_8_HEADER")] Item8Header = 800,
        /// <summary>
        /// Data Type: STRING. The description of item 8 of the table.
        /// </summary>
        [pbr::OriginalName("ITEM_8_DESCRIPTION")] Item8Description = 801,
        /// <summary>
        /// Data Type: MONEY. The price (money with currency) of item 8 of the table,
        /// for example, 30 USD. The currency must match one of the available
        /// currencies.
        /// </summary>
        [pbr::OriginalName("ITEM_8_PRICE")] Item8Price = 802,
        /// <summary>
        /// Data Type: STRING. The price unit of item 8 of the table. Must match one
        /// of the predefined price units.
        /// </summary>
        [pbr::OriginalName("ITEM_8_UNIT")] Item8Unit = 803,
        /// <summary>
        /// Data Type: URL_LIST. The final URLs of item 8 of the table when using
        /// Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_8_FINAL_URLS")] Item8FinalUrls = 804,
        /// <summary>
        /// Data Type: URL_LIST. The final mobile URLs of item 8 of the table when
        /// using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("ITEM_8_FINAL_MOBILE_URLS")] Item8FinalMobileUrls = 805,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
