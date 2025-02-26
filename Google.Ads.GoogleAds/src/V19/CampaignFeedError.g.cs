// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/campaign_feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/campaign_feed_error.proto</summary>
  public static partial class CampaignFeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/campaign_feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignFeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL2NhbXBhaWduX2Zl",
            "ZWRfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lcnJv",
            "cnMijAMKFUNhbXBhaWduRmVlZEVycm9yRW51bSLyAgoRQ2FtcGFpZ25GZWVk",
            "RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESLAooRkVFRF9B",
            "TFJFQURZX0VYSVNUU19GT1JfUExBQ0VIT0xERVJfVFlQRRACEiIKHkNBTk5P",
            "VF9DUkVBVEVfRk9SX1JFTU9WRURfRkVFRBAEEjAKLENBTk5PVF9DUkVBVEVf",
            "QUxSRUFEWV9FWElTVElOR19DQU1QQUlHTl9GRUVEEAUSJwojQ0FOTk9UX01P",
            "RElGWV9SRU1PVkVEX0NBTVBBSUdOX0ZFRUQQBhIcChhJTlZBTElEX1BMQUNF",
            "SE9MREVSX1RZUEUQBxIsCihNSVNTSU5HX0ZFRURNQVBQSU5HX0ZPUl9QTEFD",
            "RUhPTERFUl9UWVBFEAgSJgoiTk9fRVhJU1RJTkdfTE9DQVRJT05fQ1VTVE9N",
            "RVJfRkVFRBAJEh4KGkxFR0FDWV9GRUVEX1RZUEVfUkVBRF9PTkxZEApC9gEK",
            "I2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZXJyb3JzQhZDYW1wYWln",
            "bkZlZWRFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzO2Vycm9yc6IC",
            "A0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOS5FcnJvcnPKAh9Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMTlcRXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjE5OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.CampaignFeedErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.CampaignFeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.CampaignFeedErrorEnum.Types.CampaignFeedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign feed errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignFeedErrorEnum : pb::IMessage<CampaignFeedErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignFeedErrorEnum> _parser = new pb::MessageParser<CampaignFeedErrorEnum>(() => new CampaignFeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignFeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.CampaignFeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignFeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignFeedErrorEnum(CampaignFeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignFeedErrorEnum Clone() {
      return new CampaignFeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignFeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignFeedErrorEnum other) {
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
    public void MergeFrom(CampaignFeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignFeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign feed errors.
      /// </summary>
      public enum CampaignFeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active feed already exists for this campaign and placeholder type.
        /// </summary>
        [pbr::OriginalName("FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] FeedAlreadyExistsForPlaceholderType = 2,
        /// <summary>
        /// The specified feed is removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_FOR_REMOVED_FEED")] CannotCreateForRemovedFeed = 4,
        /// <summary>
        /// The CampaignFeed already exists. UPDATE should be used to modify the
        /// existing CampaignFeed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_ALREADY_EXISTING_CAMPAIGN_FEED")] CannotCreateAlreadyExistingCampaignFeed = 5,
        /// <summary>
        /// Cannot update removed campaign feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_REMOVED_CAMPAIGN_FEED")] CannotModifyRemovedCampaignFeed = 6,
        /// <summary>
        /// Invalid placeholder type.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE")] InvalidPlaceholderType = 7,
        /// <summary>
        /// Feed mapping for this placeholder type does not exist.
        /// </summary>
        [pbr::OriginalName("MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE")] MissingFeedmappingForPlaceholderType = 8,
        /// <summary>
        /// Location CampaignFeeds cannot be created unless there is a location
        /// CustomerFeed for the specified feed.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_LOCATION_CUSTOMER_FEED")] NoExistingLocationCustomerFeed = 9,
        /// <summary>
        /// Feed is read only.
        /// </summary>
        [pbr::OriginalName("LEGACY_FEED_TYPE_READ_ONLY")] LegacyFeedTypeReadOnly = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
