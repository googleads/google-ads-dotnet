// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/criterion_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/criterion_type.proto</summary>
  public static partial class CriterionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/criterion_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvY3JpdGVyaW9uX3R5",
            "cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lbnVtcyKhBgoR",
            "Q3JpdGVyaW9uVHlwZUVudW0iiwYKDUNyaXRlcmlvblR5cGUSDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESCwoHS0VZV09SRBACEg0KCVBMQUNFTUVO",
            "VBADEhcKE01PQklMRV9BUFBfQ0FURUdPUlkQBBIWChJNT0JJTEVfQVBQTElD",
            "QVRJT04QBRIKCgZERVZJQ0UQBhIMCghMT0NBVElPThAHEhEKDUxJU1RJTkdf",
            "R1JPVVAQCBIPCgtBRF9TQ0hFRFVMRRAJEg0KCUFHRV9SQU5HRRAKEgoKBkdF",
            "TkRFUhALEhAKDElOQ09NRV9SQU5HRRAMEhMKD1BBUkVOVEFMX1NUQVRVUxAN",
            "EhEKDVlPVVRVQkVfVklERU8QDhITCg9ZT1VUVUJFX0NIQU5ORUwQDxINCglV",
            "U0VSX0xJU1QQEBINCglQUk9YSU1JVFkQERIJCgVUT1BJQxASEhEKDUxJU1RJ",
            "TkdfU0NPUEUQExIMCghMQU5HVUFHRRAUEgwKCElQX0JMT0NLEBUSEQoNQ09O",
            "VEVOVF9MQUJFTBAWEgsKB0NBUlJJRVIQFxIRCg1VU0VSX0lOVEVSRVNUEBgS",
            "CwoHV0VCUEFHRRAZEhwKGE9QRVJBVElOR19TWVNURU1fVkVSU0lPThAaEhUK",
            "EUFQUF9QQVlNRU5UX01PREVMEBsSEQoNTU9CSUxFX0RFVklDRRAcEhMKD0NV",
            "U1RPTV9BRkZJTklUWRAdEhEKDUNVU1RPTV9JTlRFTlQQHhISCg5MT0NBVElP",
            "Tl9HUk9VUBAfEhMKD0NVU1RPTV9BVURJRU5DRRAgEhUKEUNPTUJJTkVEX0FV",
            "RElFTkNFECESEQoNS0VZV09SRF9USEVNRRAiEgwKCEFVRElFTkNFECMSGQoV",
            "TkVHQVRJVkVfS0VZV09SRF9MSVNUECQSFAoQTE9DQUxfU0VSVklDRV9JRBAl",
            "EhAKDFNFQVJDSF9USEVNRRAmEgkKBUJSQU5EECcSDgoKQlJBTkRfTElTVBAo",
            "Eg4KCkxJRkVfRVZFTlQQKRIQCgxXRUJQQUdFX0xJU1QQKkLsAQoiY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lbnVtc0ISQ3JpdGVyaW9uVHlwZVBy",
            "b3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MjAvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMjAuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMjBcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjA6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.CriterionTypeEnum), global::Google.Ads.GoogleAds.V20.Enums.CriterionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.CriterionTypeEnum.Types.CriterionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The possible types of a criterion.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CriterionTypeEnum : pb::IMessage<CriterionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CriterionTypeEnum> _parser = new pb::MessageParser<CriterionTypeEnum>(() => new CriterionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CriterionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.CriterionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionTypeEnum(CriterionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionTypeEnum Clone() {
      return new CriterionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CriterionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CriterionTypeEnum other) {
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
    public void MergeFrom(CriterionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible criterion types.
      /// </summary>
      public enum CriterionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword, for example, 'mars cruise'.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 2,
        /// <summary>
        /// Placement, also known as Website, for example, 'www.flowers4sale.com'
        /// </summary>
        [pbr::OriginalName("PLACEMENT")] Placement = 3,
        /// <summary>
        /// Mobile application categories to target.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_CATEGORY")] MobileAppCategory = 4,
        /// <summary>
        /// Mobile applications to target.
        /// </summary>
        [pbr::OriginalName("MOBILE_APPLICATION")] MobileApplication = 5,
        /// <summary>
        /// Devices to target.
        /// </summary>
        [pbr::OriginalName("DEVICE")] Device = 6,
        /// <summary>
        /// Locations to target.
        /// </summary>
        [pbr::OriginalName("LOCATION")] Location = 7,
        /// <summary>
        /// Listing groups to target.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUP")] ListingGroup = 8,
        /// <summary>
        /// Ad Schedule.
        /// </summary>
        [pbr::OriginalName("AD_SCHEDULE")] AdSchedule = 9,
        /// <summary>
        /// Age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 10,
        /// <summary>
        /// Gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 11,
        /// <summary>
        /// Income Range.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 12,
        /// <summary>
        /// Parental status.
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 13,
        /// <summary>
        /// YouTube Video.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 14,
        /// <summary>
        /// YouTube Channel.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_CHANNEL")] YoutubeChannel = 15,
        /// <summary>
        /// User list.
        /// </summary>
        [pbr::OriginalName("USER_LIST")] UserList = 16,
        /// <summary>
        /// Proximity.
        /// </summary>
        [pbr::OriginalName("PROXIMITY")] Proximity = 17,
        /// <summary>
        /// A topic target on the display network (for example, "Pets &amp; Animals").
        /// </summary>
        [pbr::OriginalName("TOPIC")] Topic = 18,
        /// <summary>
        /// Listing scope to target.
        /// </summary>
        [pbr::OriginalName("LISTING_SCOPE")] ListingScope = 19,
        /// <summary>
        /// Language.
        /// </summary>
        [pbr::OriginalName("LANGUAGE")] Language = 20,
        /// <summary>
        /// IpBlock.
        /// </summary>
        [pbr::OriginalName("IP_BLOCK")] IpBlock = 21,
        /// <summary>
        /// Content Label for category exclusion.
        /// </summary>
        [pbr::OriginalName("CONTENT_LABEL")] ContentLabel = 22,
        /// <summary>
        /// Carrier.
        /// </summary>
        [pbr::OriginalName("CARRIER")] Carrier = 23,
        /// <summary>
        /// A category the user is interested in.
        /// </summary>
        [pbr::OriginalName("USER_INTEREST")] UserInterest = 24,
        /// <summary>
        /// Webpage criterion for dynamic search ads.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 25,
        /// <summary>
        /// Operating system version.
        /// </summary>
        [pbr::OriginalName("OPERATING_SYSTEM_VERSION")] OperatingSystemVersion = 26,
        /// <summary>
        /// App payment model.
        /// </summary>
        [pbr::OriginalName("APP_PAYMENT_MODEL")] AppPaymentModel = 27,
        /// <summary>
        /// Mobile device.
        /// </summary>
        [pbr::OriginalName("MOBILE_DEVICE")] MobileDevice = 28,
        /// <summary>
        /// Custom affinity.
        /// </summary>
        [pbr::OriginalName("CUSTOM_AFFINITY")] CustomAffinity = 29,
        /// <summary>
        /// Custom intent.
        /// </summary>
        [pbr::OriginalName("CUSTOM_INTENT")] CustomIntent = 30,
        /// <summary>
        /// Location group.
        /// </summary>
        [pbr::OriginalName("LOCATION_GROUP")] LocationGroup = 31,
        /// <summary>
        /// Custom audience
        /// </summary>
        [pbr::OriginalName("CUSTOM_AUDIENCE")] CustomAudience = 32,
        /// <summary>
        /// Combined audience
        /// </summary>
        [pbr::OriginalName("COMBINED_AUDIENCE")] CombinedAudience = 33,
        /// <summary>
        /// Smart Campaign keyword theme
        /// </summary>
        [pbr::OriginalName("KEYWORD_THEME")] KeywordTheme = 34,
        /// <summary>
        /// Audience
        /// </summary>
        [pbr::OriginalName("AUDIENCE")] Audience = 35,
        /// <summary>
        /// Negative Keyword List
        /// </summary>
        [pbr::OriginalName("NEGATIVE_KEYWORD_LIST")] NegativeKeywordList = 36,
        /// <summary>
        /// Local Services Ads Service ID.
        /// </summary>
        [pbr::OriginalName("LOCAL_SERVICE_ID")] LocalServiceId = 37,
        /// <summary>
        /// Search Theme.
        /// </summary>
        [pbr::OriginalName("SEARCH_THEME")] SearchTheme = 38,
        /// <summary>
        /// Brand
        /// </summary>
        [pbr::OriginalName("BRAND")] Brand = 39,
        /// <summary>
        /// Brand List
        /// </summary>
        [pbr::OriginalName("BRAND_LIST")] BrandList = 40,
        /// <summary>
        /// Life Event
        /// </summary>
        [pbr::OriginalName("LIFE_EVENT")] LifeEvent = 41,
        /// <summary>
        /// Webpage List
        /// </summary>
        [pbr::OriginalName("WEBPAGE_LIST")] WebpageList = 42,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
