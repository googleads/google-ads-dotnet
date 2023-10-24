// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/errors/ad_group_feed_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/errors/ad_group_feed_error.proto</summary>
  public static partial class AdGroupFeedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/errors/ad_group_feed_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupFeedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZXJyb3JzL2FkX2dyb3VwX2Zl",
            "ZWRfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5lcnJv",
            "cnMi3AIKFEFkR3JvdXBGZWVkRXJyb3JFbnVtIsMCChBBZEdyb3VwRmVlZEVy",
            "cm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiwKKEZFRURfQUxS",
            "RUFEWV9FWElTVFNfRk9SX1BMQUNFSE9MREVSX1RZUEUQAhIiCh5DQU5OT1Rf",
            "Q1JFQVRFX0ZPUl9SRU1PVkVEX0ZFRUQQAxIfChtBREdST1VQX0ZFRURfQUxS",
            "RUFEWV9FWElTVFMQBBIqCiZDQU5OT1RfT1BFUkFURV9PTl9SRU1PVkVEX0FE",
            "R1JPVVBfRkVFRBAFEhwKGElOVkFMSURfUExBQ0VIT0xERVJfVFlQRRAGEiwK",
            "KE1JU1NJTkdfRkVFRE1BUFBJTkdfRk9SX1BMQUNFSE9MREVSX1RZUEUQBxIm",
            "CiJOT19FWElTVElOR19MT0NBVElPTl9DVVNUT01FUl9GRUVEEAhC9QEKI2Nv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuZXJyb3JzQhVBZEdyb3VwRmVl",
            "ZEVycm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNS9lcnJvcnM7ZXJyb3JzogIDR0FB",
            "qgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE1LkVycm9yc8oCH0dvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYxNVxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTU6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Errors.AdGroupFeedErrorEnum), global::Google.Ads.GoogleAds.V15.Errors.AdGroupFeedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Errors.AdGroupFeedErrorEnum.Types.AdGroupFeedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ad group feed errors.
  /// </summary>
  public sealed partial class AdGroupFeedErrorEnum : pb::IMessage<AdGroupFeedErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupFeedErrorEnum> _parser = new pb::MessageParser<AdGroupFeedErrorEnum>(() => new AdGroupFeedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupFeedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Errors.AdGroupFeedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupFeedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupFeedErrorEnum(AdGroupFeedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupFeedErrorEnum Clone() {
      return new AdGroupFeedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupFeedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupFeedErrorEnum other) {
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
    public void MergeFrom(AdGroupFeedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupFeedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ad group feed errors.
      /// </summary>
      public enum AdGroupFeedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An active feed already exists for this ad group and place holder type.
        /// </summary>
        [pbr::OriginalName("FEED_ALREADY_EXISTS_FOR_PLACEHOLDER_TYPE")] FeedAlreadyExistsForPlaceholderType = 2,
        /// <summary>
        /// The specified feed is removed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_FOR_REMOVED_FEED")] CannotCreateForRemovedFeed = 3,
        /// <summary>
        /// The AdGroupFeed already exists. UPDATE operation should be used to modify
        /// the existing AdGroupFeed.
        /// </summary>
        [pbr::OriginalName("ADGROUP_FEED_ALREADY_EXISTS")] AdgroupFeedAlreadyExists = 4,
        /// <summary>
        /// Cannot operate on removed AdGroupFeed.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_REMOVED_ADGROUP_FEED")] CannotOperateOnRemovedAdgroupFeed = 5,
        /// <summary>
        /// Invalid placeholder type.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE")] InvalidPlaceholderType = 6,
        /// <summary>
        /// Feed mapping for this placeholder type does not exist.
        /// </summary>
        [pbr::OriginalName("MISSING_FEEDMAPPING_FOR_PLACEHOLDER_TYPE")] MissingFeedmappingForPlaceholderType = 7,
        /// <summary>
        /// Location AdGroupFeeds cannot be created unless there is a location
        /// CustomerFeed for the specified feed.
        /// </summary>
        [pbr::OriginalName("NO_EXISTING_LOCATION_CUSTOMER_FEED")] NoExistingLocationCustomerFeed = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
