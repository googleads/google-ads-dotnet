// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/feed_error.proto</summary>
  public static partial class FeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL2ZlZWRfZXJyb3Iu",
            "cHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lcnJvcnMi6wYKDUZl",
            "ZWRFcnJvckVudW0i2QYKCUZlZWRFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIeChpBVFRSSUJVVEVfTkFNRVNfTk9UX1VOSVFVRRACEi8K",
            "K0FUVFJJQlVURVNfRE9fTk9UX01BVENIX0VYSVNUSU5HX0FUVFJJQlVURVMQ",
            "AxIuCipDQU5OT1RfU1BFQ0lGWV9VU0VSX09SSUdJTl9GT1JfU1lTVEVNX0ZF",
            "RUQQBBI0CjBDQU5OT1RfU1BFQ0lGWV9HT09HTEVfT1JJR0lOX0ZPUl9OT05f",
            "U1lTVEVNX0ZFRUQQBRIyCi5DQU5OT1RfU1BFQ0lGWV9GRUVEX0FUVFJJQlVU",
            "RVNfRk9SX1NZU1RFTV9GRUVEEAYSNAowQ0FOTk9UX1VQREFURV9GRUVEX0FU",
            "VFJJQlVURVNfV0lUSF9PUklHSU5fR09PR0xFEAcSEAoMRkVFRF9SRU1PVkVE",
            "EAgSGAoUSU5WQUxJRF9PUklHSU5fVkFMVUUQCRIbChdGRUVEX09SSUdJTl9J",
            "U19OT1RfVVNFUhAKEiAKHElOVkFMSURfQVVUSF9UT0tFTl9GT1JfRU1BSUwQ",
            "CxIRCg1JTlZBTElEX0VNQUlMEAwSFwoTRFVQTElDQVRFX0ZFRURfTkFNRRAN",
            "EhUKEUlOVkFMSURfRkVFRF9OQU1FEA4SFgoSTUlTU0lOR19PQVVUSF9JTkZP",
            "EA8SLgoqTkVXX0FUVFJJQlVURV9DQU5OT1RfQkVfUEFSVF9PRl9VTklRVUVf",
            "S0VZEBASFwoTVE9PX01BTllfQVRUUklCVVRFUxAREhwKGElOVkFMSURfQlVT",
            "SU5FU1NfQUNDT1VOVBASEjMKL0JVU0lORVNTX0FDQ09VTlRfQ0FOTk9UX0FD",
            "Q0VTU19MT0NBVElPTl9BQ0NPVU5UEBMSHgoaSU5WQUxJRF9BRkZJTElBVEVf",
            "Q0hBSU5fSUQQFBIZChVEVVBMSUNBVEVfU1lTVEVNX0ZFRUQQFRIUChBHTUJf",
            "QUNDRVNTX0VSUk9SEBYSNQoxQ0FOTk9UX0hBVkVfTE9DQVRJT05fQU5EX0FG",
            "RklMSUFURV9MT0NBVElPTl9GRUVEUxAXEiMKH0xFR0FDWV9FWFRFTlNJT05f",
            "VFlQRV9SRUFEX09OTFkQGELuAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxOS5lcnJvcnNCDkZlZWRFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTkvZXJy",
            "b3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOS5F",
            "cnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTlcRXJyb3Jz6gIjR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjE5OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.FeedErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.FeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.FeedErrorEnum.Types.FeedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeedErrorEnum : pb::IMessage<FeedErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedErrorEnum> _parser = new pb::MessageParser<FeedErrorEnum>(() => new FeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.FeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedErrorEnum(FeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedErrorEnum Clone() {
      return new FeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedErrorEnum other) {
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
    public void MergeFrom(FeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed errors.
      /// </summary>
      public enum FeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The names of the FeedAttributes must be unique.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTE_NAMES_NOT_UNIQUE")] AttributeNamesNotUnique = 2,
        /// <summary>
        /// The attribute list must be an exact copy of the existing list if the
        /// attribute ID's are present.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTES_DO_NOT_MATCH_EXISTING_ATTRIBUTES")] AttributesDoNotMatchExistingAttributes = 3,
        /// <summary>
        /// Cannot specify USER origin for a system generated feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_USER_ORIGIN_FOR_SYSTEM_FEED")] CannotSpecifyUserOriginForSystemFeed = 4,
        /// <summary>
        /// Cannot specify GOOGLE origin for a non-system generated feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_GOOGLE_ORIGIN_FOR_NON_SYSTEM_FEED")] CannotSpecifyGoogleOriginForNonSystemFeed = 5,
        /// <summary>
        /// Cannot specify feed attributes for system feed.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_FEED_ATTRIBUTES_FOR_SYSTEM_FEED")] CannotSpecifyFeedAttributesForSystemFeed = 6,
        /// <summary>
        /// Cannot update FeedAttributes on feed with origin GOOGLE.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_FEED_ATTRIBUTES_WITH_ORIGIN_GOOGLE")] CannotUpdateFeedAttributesWithOriginGoogle = 7,
        /// <summary>
        /// The given ID refers to a removed Feed. Removed Feeds are immutable.
        /// </summary>
        [pbr::OriginalName("FEED_REMOVED")] FeedRemoved = 8,
        /// <summary>
        /// The origin of the feed is not valid for the client.
        /// </summary>
        [pbr::OriginalName("INVALID_ORIGIN_VALUE")] InvalidOriginValue = 9,
        /// <summary>
        /// A user can only create and modify feeds with USER origin.
        /// </summary>
        [pbr::OriginalName("FEED_ORIGIN_IS_NOT_USER")] FeedOriginIsNotUser = 10,
        /// <summary>
        /// Invalid auth token for the given email.
        /// </summary>
        [pbr::OriginalName("INVALID_AUTH_TOKEN_FOR_EMAIL")] InvalidAuthTokenForEmail = 11,
        /// <summary>
        /// Invalid email specified.
        /// </summary>
        [pbr::OriginalName("INVALID_EMAIL")] InvalidEmail = 12,
        /// <summary>
        /// Feed name matches that of another active Feed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_FEED_NAME")] DuplicateFeedName = 13,
        /// <summary>
        /// Name of feed is not allowed.
        /// </summary>
        [pbr::OriginalName("INVALID_FEED_NAME")] InvalidFeedName = 14,
        /// <summary>
        /// Missing OAuthInfo.
        /// </summary>
        [pbr::OriginalName("MISSING_OAUTH_INFO")] MissingOauthInfo = 15,
        /// <summary>
        /// New FeedAttributes must not affect the unique key.
        /// </summary>
        [pbr::OriginalName("NEW_ATTRIBUTE_CANNOT_BE_PART_OF_UNIQUE_KEY")] NewAttributeCannotBePartOfUniqueKey = 16,
        /// <summary>
        /// Too many FeedAttributes for a Feed.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ATTRIBUTES")] TooManyAttributes = 17,
        /// <summary>
        /// The business account is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_BUSINESS_ACCOUNT")] InvalidBusinessAccount = 18,
        /// <summary>
        /// Business account cannot access Business Profile.
        /// </summary>
        [pbr::OriginalName("BUSINESS_ACCOUNT_CANNOT_ACCESS_LOCATION_ACCOUNT")] BusinessAccountCannotAccessLocationAccount = 19,
        /// <summary>
        /// Invalid chain ID provided for affiliate location feed.
        /// </summary>
        [pbr::OriginalName("INVALID_AFFILIATE_CHAIN_ID")] InvalidAffiliateChainId = 20,
        /// <summary>
        /// There is already a feed with the given system feed generation data.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_SYSTEM_FEED")] DuplicateSystemFeed = 21,
        /// <summary>
        /// An error occurred accessing Business Profile.
        /// </summary>
        [pbr::OriginalName("GMB_ACCESS_ERROR")] GmbAccessError = 22,
        /// <summary>
        /// A customer cannot have both LOCATION and AFFILIATE_LOCATION feeds.
        /// </summary>
        [pbr::OriginalName("CANNOT_HAVE_LOCATION_AND_AFFILIATE_LOCATION_FEEDS")] CannotHaveLocationAndAffiliateLocationFeeds = 23,
        /// <summary>
        /// Feed-based extension is read-only for this extension type.
        /// </summary>
        [pbr::OriginalName("LEGACY_EXTENSION_TYPE_READ_ONLY")] LegacyExtensionTypeReadOnly = 24,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
