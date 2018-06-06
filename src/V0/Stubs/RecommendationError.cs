// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/recommendation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/recommendation_error.proto</summary>
  public static partial class RecommendationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/recommendation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecommendationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvcmVjb21tZW5kYXRp",
            "b25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9y",
            "cyLpAQoXUmVjb21tZW5kYXRpb25FcnJvckVudW0izQEKE1JlY29tbWVuZGF0",
            "aW9uRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESGwoXQlVE",
            "R0VUX0FNT1VOVF9UT09fU01BTEwQAhIbChdCVURHRVRfQU1PVU5UX1RPT19M",
            "QVJHRRADEhkKFUlOVkFMSURfQlVER0VUX0FNT1VOVBAEEhAKDFBPTElDWV9F",
            "UlJPUhAFEhYKEklOVkFMSURfQklEX0FNT1VOVBAGEhkKFUFER1JPVVBfS0VZ",
            "V09SRF9MSU1JVBAHQs4BCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAu",
            "ZXJyb3JzQhhSZWNvbW1lbmRhdGlvbkVycm9yUHJvdG9QAVpEZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yw",
            "L2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxFcnJvcnNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.RecommendationErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.RecommendationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.RecommendationErrorEnum.Types.RecommendationError) }, null)
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
      get { return global::Google.Ads.GoogleAds.V0.Errors.RecommendationErrorReflection.Descriptor.MessageTypes[0]; }
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
