// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/errors/feed_mapping_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/errors/feed_mapping_error.proto</summary>
  public static partial class FeedMappingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/errors/feed_mapping_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedMappingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZXJyb3JzL2ZlZWRfbWFwcGlu",
            "Z19lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVycm9y",
            "cyKyBgoURmVlZE1hcHBpbmdFcnJvckVudW0imQYKEEZlZWRNYXBwaW5nRXJy",
            "b3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESHQoZSU5WQUxJRF9Q",
            "TEFDRUhPTERFUl9GSUVMRBACEhsKF0lOVkFMSURfQ1JJVEVSSU9OX0ZJRUxE",
            "EAMSHAoYSU5WQUxJRF9QTEFDRUhPTERFUl9UWVBFEAQSGgoWSU5WQUxJRF9D",
            "UklURVJJT05fVFlQRRAFEh8KG05PX0FUVFJJQlVURV9GSUVMRF9NQVBQSU5H",
            "UxAHEiAKHEZFRURfQVRUUklCVVRFX1RZUEVfTUlTTUFUQ0gQCBI4CjRDQU5O",
            "T1RfT1BFUkFURV9PTl9NQVBQSU5HU19GT1JfU1lTVEVNX0dFTkVSQVRFRF9G",
            "RUVEEAkSKgomTVVMVElQTEVfTUFQUElOR1NfRk9SX1BMQUNFSE9MREVSX1RZ",
            "UEUQChIoCiRNVUxUSVBMRV9NQVBQSU5HU19GT1JfQ1JJVEVSSU9OX1RZUEUQ",
            "CxIrCidNVUxUSVBMRV9NQVBQSU5HU19GT1JfUExBQ0VIT0xERVJfRklFTEQQ",
            "DBIpCiVNVUxUSVBMRV9NQVBQSU5HU19GT1JfQ1JJVEVSSU9OX0ZJRUxEEA0S",
            "JwojVU5FWFBFQ1RFRF9BVFRSSUJVVEVfRklFTERfTUFQUElOR1MQDhIuCipM",
            "T0NBVElPTl9QTEFDRUhPTERFUl9PTkxZX0ZPUl9QTEFDRVNfRkVFRFMQDxIp",
            "CiVDQU5OT1RfTU9ESUZZX01BUFBJTkdTX0ZPUl9UWVBFRF9GRUVEEBASOgo2",
            "SU5WQUxJRF9QTEFDRUhPTERFUl9UWVBFX0ZPUl9OT05fU1lTVEVNX0dFTkVS",
            "QVRFRF9GRUVEEBESOwo3SU5WQUxJRF9QTEFDRUhPTERFUl9UWVBFX0ZPUl9T",
            "WVNURU1fR0VORVJBVEVEX0ZFRURfVFlQRRASEikKJUFUVFJJQlVURV9GSUVM",
            "RF9NQVBQSU5HX01JU1NJTkdfRklFTEQQExIeChpMRUdBQ1lfRkVFRF9UWVBF",
            "X1JFQURfT05MWRAUQvUBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIw",
            "LmVycm9yc0IVRmVlZE1hcHBpbmdFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MjAv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYy",
            "MC5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMjBcRXJyb3Jz6gIj",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjIwOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Errors.FeedMappingErrorEnum), global::Google.Ads.GoogleAds.V20.Errors.FeedMappingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Errors.FeedMappingErrorEnum.Types.FeedMappingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FeedMappingErrorEnum : pb::IMessage<FeedMappingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedMappingErrorEnum> _parser = new pb::MessageParser<FeedMappingErrorEnum>(() => new FeedMappingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedMappingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Errors.FeedMappingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedMappingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedMappingErrorEnum(FeedMappingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedMappingErrorEnum Clone() {
      return new FeedMappingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedMappingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedMappingErrorEnum other) {
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
    public void MergeFrom(FeedMappingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedMappingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed item errors.
      /// </summary>
      public enum FeedMappingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The given placeholder field does not exist.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_FIELD")] InvalidPlaceholderField = 2,
        /// <summary>
        /// The given criterion field does not exist.
        /// </summary>
        [pbr::OriginalName("INVALID_CRITERION_FIELD")] InvalidCriterionField = 3,
        /// <summary>
        /// The given placeholder type does not exist.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE")] InvalidPlaceholderType = 4,
        /// <summary>
        /// The given criterion type does not exist.
        /// </summary>
        [pbr::OriginalName("INVALID_CRITERION_TYPE")] InvalidCriterionType = 5,
        /// <summary>
        /// A feed mapping must contain at least one attribute field mapping.
        /// </summary>
        [pbr::OriginalName("NO_ATTRIBUTE_FIELD_MAPPINGS")] NoAttributeFieldMappings = 7,
        /// <summary>
        /// The type of the feed attribute referenced in the attribute field mapping
        /// must match the type of the placeholder field.
        /// </summary>
        [pbr::OriginalName("FEED_ATTRIBUTE_TYPE_MISMATCH")] FeedAttributeTypeMismatch = 8,
        /// <summary>
        /// A feed mapping for a system generated feed cannot be operated on.
        /// </summary>
        [pbr::OriginalName("CANNOT_OPERATE_ON_MAPPINGS_FOR_SYSTEM_GENERATED_FEED")] CannotOperateOnMappingsForSystemGeneratedFeed = 9,
        /// <summary>
        /// Only one feed mapping for a placeholder type is allowed per feed or
        /// customer (depending on the placeholder type).
        /// </summary>
        [pbr::OriginalName("MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_TYPE")] MultipleMappingsForPlaceholderType = 10,
        /// <summary>
        /// Only one feed mapping for a criterion type is allowed per customer.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_MAPPINGS_FOR_CRITERION_TYPE")] MultipleMappingsForCriterionType = 11,
        /// <summary>
        /// Only one feed attribute mapping for a placeholder field is allowed
        /// (depending on the placeholder type).
        /// </summary>
        [pbr::OriginalName("MULTIPLE_MAPPINGS_FOR_PLACEHOLDER_FIELD")] MultipleMappingsForPlaceholderField = 12,
        /// <summary>
        /// Only one feed attribute mapping for a criterion field is allowed
        /// (depending on the criterion type).
        /// </summary>
        [pbr::OriginalName("MULTIPLE_MAPPINGS_FOR_CRITERION_FIELD")] MultipleMappingsForCriterionField = 13,
        /// <summary>
        /// This feed mapping may not contain any explicit attribute field mappings.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_ATTRIBUTE_FIELD_MAPPINGS")] UnexpectedAttributeFieldMappings = 14,
        /// <summary>
        /// Location placeholder feed mappings can only be created for Places feeds.
        /// </summary>
        [pbr::OriginalName("LOCATION_PLACEHOLDER_ONLY_FOR_PLACES_FEEDS")] LocationPlaceholderOnlyForPlacesFeeds = 15,
        /// <summary>
        /// Mappings for typed feeds cannot be modified.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_MAPPINGS_FOR_TYPED_FEED")] CannotModifyMappingsForTypedFeed = 16,
        /// <summary>
        /// The given placeholder type can only be mapped to system generated feeds.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE_FOR_NON_SYSTEM_GENERATED_FEED")] InvalidPlaceholderTypeForNonSystemGeneratedFeed = 17,
        /// <summary>
        /// The given placeholder type cannot be mapped to a system generated feed
        /// with the given type.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_TYPE_FOR_SYSTEM_GENERATED_FEED_TYPE")] InvalidPlaceholderTypeForSystemGeneratedFeedType = 18,
        /// <summary>
        /// The "field" oneof was not set in an AttributeFieldMapping.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTE_FIELD_MAPPING_MISSING_FIELD")] AttributeFieldMappingMissingField = 19,
        /// <summary>
        /// Feed is read only.
        /// </summary>
        [pbr::OriginalName("LEGACY_FEED_TYPE_READ_ONLY")] LegacyFeedTypeReadOnly = 20,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
