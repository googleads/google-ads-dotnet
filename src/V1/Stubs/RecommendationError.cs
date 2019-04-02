// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/recommendation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/recommendation_error.proto</summary>
  public static partial class RecommendationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/recommendation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvcmVjb21tZW5kYXRp",
            "b25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9y",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLaAwoXUmVjb21tZW5k",
            "YXRpb25FcnJvckVudW0ivgMKE1JlY29tbWVuZGF0aW9uRXJyb3ISDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESGwoXQlVER0VUX0FNT1VOVF9UT09f",
            "U01BTEwQAhIbChdCVURHRVRfQU1PVU5UX1RPT19MQVJHRRADEhkKFUlOVkFM",
            "SURfQlVER0VUX0FNT1VOVBAEEhAKDFBPTElDWV9FUlJPUhAFEhYKEklOVkFM",
            "SURfQklEX0FNT1VOVBAGEhkKFUFER1JPVVBfS0VZV09SRF9MSU1JVBAHEiIK",
            "HlJFQ09NTUVOREFUSU9OX0FMUkVBRFlfQVBQTElFRBAIEh4KGlJFQ09NTUVO",
            "REFUSU9OX0lOVkFMSURBVEVEEAkSFwoTVE9PX01BTllfT1BFUkFUSU9OUxAK",
            "EhEKDU5PX09QRVJBVElPTlMQCxIhCh1ESUZGRVJFTlRfVFlQRVNfTk9UX1NV",
            "UFBPUlRFRBAMEhsKF0RVUExJQ0FURV9SRVNPVVJDRV9OQU1FEA0SJAogUkVD",
            "T01NRU5EQVRJT05fQUxSRUFEWV9ESVNNSVNTRUQQDhIZChVJTlZBTElEX0FQ",
            "UExZX1JFUVVFU1QQD0LzAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "LmVycm9yc0IYUmVjb21tZW5kYXRpb25FcnJvclByb3RvUAFaRGdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEuRXJyb3JzygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcRXJyb3Jz6gIi",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.RecommendationErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.RecommendationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.RecommendationErrorEnum.Types.RecommendationError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a recommendation.
  /// </summary>
  public sealed partial class RecommendationErrorEnum : pb::IMessage<RecommendationErrorEnum> {
    private static readonly pb::MessageParser<RecommendationErrorEnum> _parser = new pb::MessageParser<RecommendationErrorEnum>(() => new RecommendationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RecommendationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.RecommendationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationErrorEnum(RecommendationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RecommendationErrorEnum Clone() {
      return new RecommendationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RecommendationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RecommendationErrorEnum other) {
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
    public void MergeFrom(RecommendationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the RecommendationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a recommendation.
      /// </summary>
      public enum RecommendationError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The specified budget amount is too low e.g. lower than minimum currency
        /// unit or lower than ad group minimum cost-per-click.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_SMALL")] BudgetAmountTooSmall = 2,
        /// <summary>
        /// The specified budget amount is too large.
        /// </summary>
        [pbr::OriginalName("BUDGET_AMOUNT_TOO_LARGE")] BudgetAmountTooLarge = 3,
        /// <summary>
        /// The specified budget amount is not a valid amount. e.g. not a multiple
        /// of minimum currency unit.
        /// </summary>
        [pbr::OriginalName("INVALID_BUDGET_AMOUNT")] InvalidBudgetAmount = 4,
        /// <summary>
        /// The specified keyword or ad violates ad policy.
        /// </summary>
        [pbr::OriginalName("POLICY_ERROR")] PolicyError = 5,
        /// <summary>
        /// The specified bid amount is not valid. e.g. too many fractional digits,
        /// or negative amount.
        /// </summary>
        [pbr::OriginalName("INVALID_BID_AMOUNT")] InvalidBidAmount = 6,
        /// <summary>
        /// The number of keywords in ad group have reached the maximum allowed.
        /// </summary>
        [pbr::OriginalName("ADGROUP_KEYWORD_LIMIT")] AdgroupKeywordLimit = 7,
        /// <summary>
        /// The recommendation requested to apply has already been applied.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_APPLIED")] RecommendationAlreadyApplied = 8,
        /// <summary>
        /// The recommendation requested to apply has been invalidated.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_INVALIDATED")] RecommendationInvalidated = 9,
        /// <summary>
        /// The number of operations in a single request exceeds the maximum allowed.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERATIONS")] TooManyOperations = 10,
        /// <summary>
        /// There are no operations in the request.
        /// </summary>
        [pbr::OriginalName("NO_OPERATIONS")] NoOperations = 11,
        /// <summary>
        /// Operations with multiple recommendation types are not supported when
        /// partial failure mode is not enabled.
        /// </summary>
        [pbr::OriginalName("DIFFERENT_TYPES_NOT_SUPPORTED")] DifferentTypesNotSupported = 12,
        /// <summary>
        /// Request contains multiple operations with the same resource_name.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_RESOURCE_NAME")] DuplicateResourceName = 13,
        /// <summary>
        /// The recommendation requested to dismiss has already been dismissed.
        /// </summary>
        [pbr::OriginalName("RECOMMENDATION_ALREADY_DISMISSED")] RecommendationAlreadyDismissed = 14,
        /// <summary>
        /// The recommendation apply request was malformed and invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APPLY_REQUEST")] InvalidApplyRequest = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
