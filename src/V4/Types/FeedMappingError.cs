// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/feed_mapping_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/feed_mapping_error.proto</summary>
  public static partial class FeedMappingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/feed_mapping_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedMappingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvZmVlZF9tYXBwaW5n",
            "X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lcnJvcnMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ikgYKFEZlZWRNYXBwaW5n",
            "RXJyb3JFbnVtIvkFChBGZWVkTWFwcGluZ0Vycm9yEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEh0KGUlOVkFMSURfUExBQ0VIT0xERVJfRklFTEQQ",
            "AhIbChdJTlZBTElEX0NSSVRFUklPTl9GSUVMRBADEhwKGElOVkFMSURfUExB",
            "Q0VIT0xERVJfVFlQRRAEEhoKFklOVkFMSURfQ1JJVEVSSU9OX1RZUEUQBRIf",
            "ChtOT19BVFRSSUJVVEVfRklFTERfTUFQUElOR1MQBxIgChxGRUVEX0FUVFJJ",
            "QlVURV9UWVBFX01JU01BVENIEAgSOAo0Q0FOTk9UX09QRVJBVEVfT05fTUFQ",
            "UElOR1NfRk9SX1NZU1RFTV9HRU5FUkFURURfRkVFRBAJEioKJk1VTFRJUExF",
            "X01BUFBJTkdTX0ZPUl9QTEFDRUhPTERFUl9UWVBFEAoSKAokTVVMVElQTEVf",
            "TUFQUElOR1NfRk9SX0NSSVRFUklPTl9UWVBFEAsSKwonTVVMVElQTEVfTUFQ",
            "UElOR1NfRk9SX1BMQUNFSE9MREVSX0ZJRUxEEAwSKQolTVVMVElQTEVfTUFQ",
            "UElOR1NfRk9SX0NSSVRFUklPTl9GSUVMRBANEicKI1VORVhQRUNURURfQVRU",
            "UklCVVRFX0ZJRUxEX01BUFBJTkdTEA4SLgoqTE9DQVRJT05fUExBQ0VIT0xE",
            "RVJfT05MWV9GT1JfUExBQ0VTX0ZFRURTEA8SKQolQ0FOTk9UX01PRElGWV9N",
            "QVBQSU5HU19GT1JfVFlQRURfRkVFRBAQEjoKNklOVkFMSURfUExBQ0VIT0xE",
            "RVJfVFlQRV9GT1JfTk9OX1NZU1RFTV9HRU5FUkFURURfRkVFRBAREjsKN0lO",
            "VkFMSURfUExBQ0VIT0xERVJfVFlQRV9GT1JfU1lTVEVNX0dFTkVSQVRFRF9G",
            "RUVEX1RZUEUQEhIpCiVBVFRSSUJVVEVfRklFTERfTUFQUElOR19NSVNTSU5H",
            "X0ZJRUxEEBNC8AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lcnJv",
            "cnNCFUZlZWRNYXBwaW5nRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvZXJyb3Jz",
            "O2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY0LkVycm9y",
            "c8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XEVycm9yc+oCIkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlY0OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.FeedMappingErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.FeedMappingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.FeedMappingErrorEnum.Types.FeedMappingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item errors.
  /// </summary>
  public sealed partial class FeedMappingErrorEnum : pb::IMessage<FeedMappingErrorEnum> {
    private static readonly pb::MessageParser<FeedMappingErrorEnum> _parser = new pb::MessageParser<FeedMappingErrorEnum>(() => new FeedMappingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedMappingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.FeedMappingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedMappingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedMappingErrorEnum(FeedMappingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedMappingErrorEnum Clone() {
      return new FeedMappingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedMappingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(FeedMappingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedMappingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
