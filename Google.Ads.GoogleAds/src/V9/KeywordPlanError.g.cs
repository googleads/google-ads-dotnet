// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/errors/keyword_plan_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/errors/keyword_plan_error.proto</summary>
  public static partial class KeywordPlanErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/errors/keyword_plan_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9lcnJvcnMva2V5d29yZF9wbGFu",
            "X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5lcnJvcnMi",
            "yAMKFEtleXdvcmRQbGFuRXJyb3JFbnVtIq8DChBLZXl3b3JkUGxhbkVycm9y",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEh8KG0JJRF9NVUxUSVBM",
            "SUVSX09VVF9PRl9SQU5HRRACEhAKDEJJRF9UT09fSElHSBADEg8KC0JJRF9U",
            "T09fTE9XEAQSIgoeQklEX1RPT19NQU5ZX0ZSQUNUSU9OQUxfRElHSVRTEAUS",
            "GAoUREFJTFlfQlVER0VUX1RPT19MT1cQBhIrCidEQUlMWV9CVURHRVRfVE9P",
            "X01BTllfRlJBQ1RJT05BTF9ESUdJVFMQBxIRCg1JTlZBTElEX1ZBTFVFEAgS",
            "IAocS0VZV09SRF9QTEFOX0hBU19OT19LRVlXT1JEUxAJEhwKGEtFWVdPUkRf",
            "UExBTl9OT1RfRU5BQkxFRBAKEhoKFktFWVdPUkRfUExBTl9OT1RfRk9VTkQQ",
            "CxIPCgtNSVNTSU5HX0JJRBANEhsKF01JU1NJTkdfRk9SRUNBU1RfUEVSSU9E",
            "EA4SHwobSU5WQUxJRF9GT1JFQ0FTVF9EQVRFX1JBTkdFEA8SEAoMSU5WQUxJ",
            "RF9OQU1FEBBC8AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5lcnJv",
            "cnNCFUtleXdvcmRQbGFuRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvZXJyb3Jz",
            "O2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LkVycm9y",
            "c8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XEVycm9yc+oCIkdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlY5OjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Errors.KeywordPlanErrorEnum), global::Google.Ads.GoogleAds.V9.Errors.KeywordPlanErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V9.Errors.KeywordPlanErrorEnum.Types.KeywordPlanError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible errors from applying a keyword plan
  /// resource (keyword plan, keyword plan campaign, keyword plan ad group or
  /// keyword plan keyword) or KeywordPlanService RPC.
  /// </summary>
  public sealed partial class KeywordPlanErrorEnum : pb::IMessage<KeywordPlanErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<KeywordPlanErrorEnum> _parser = new pb::MessageParser<KeywordPlanErrorEnum>(() => new KeywordPlanErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<KeywordPlanErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Errors.KeywordPlanErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanErrorEnum(KeywordPlanErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public KeywordPlanErrorEnum Clone() {
      return new KeywordPlanErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(KeywordPlanErrorEnum other) {
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
    public void MergeFrom(KeywordPlanErrorEnum other) {
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
    /// <summary>Container for nested types declared in the KeywordPlanErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible errors from applying a keyword plan.
      /// </summary>
      public enum KeywordPlanError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The plan's bid multiplier value is outside the valid range.
        /// </summary>
        [pbr::OriginalName("BID_MULTIPLIER_OUT_OF_RANGE")] BidMultiplierOutOfRange = 2,
        /// <summary>
        /// The plan's bid value is too high.
        /// </summary>
        [pbr::OriginalName("BID_TOO_HIGH")] BidTooHigh = 3,
        /// <summary>
        /// The plan's bid value is too low.
        /// </summary>
        [pbr::OriginalName("BID_TOO_LOW")] BidTooLow = 4,
        /// <summary>
        /// The plan's cpc bid is not a multiple of the minimum billable unit.
        /// </summary>
        [pbr::OriginalName("BID_TOO_MANY_FRACTIONAL_DIGITS")] BidTooManyFractionalDigits = 5,
        /// <summary>
        /// The plan's daily budget value is too low.
        /// </summary>
        [pbr::OriginalName("DAILY_BUDGET_TOO_LOW")] DailyBudgetTooLow = 6,
        /// <summary>
        /// The plan's daily budget is not a multiple of the minimum billable unit.
        /// </summary>
        [pbr::OriginalName("DAILY_BUDGET_TOO_MANY_FRACTIONAL_DIGITS")] DailyBudgetTooManyFractionalDigits = 7,
        /// <summary>
        /// The input has an invalid value.
        /// </summary>
        [pbr::OriginalName("INVALID_VALUE")] InvalidValue = 8,
        /// <summary>
        /// The plan has no keyword.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_HAS_NO_KEYWORDS")] KeywordPlanHasNoKeywords = 9,
        /// <summary>
        /// The plan is not enabled and API cannot provide mutation, forecast or
        /// stats.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_NOT_ENABLED")] KeywordPlanNotEnabled = 10,
        /// <summary>
        /// The requested plan cannot be found for providing forecast or stats.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_NOT_FOUND")] KeywordPlanNotFound = 11,
        /// <summary>
        /// The plan is missing a cpc bid.
        /// </summary>
        [pbr::OriginalName("MISSING_BID")] MissingBid = 13,
        /// <summary>
        /// The plan is missing required forecast_period field.
        /// </summary>
        [pbr::OriginalName("MISSING_FORECAST_PERIOD")] MissingForecastPeriod = 14,
        /// <summary>
        /// The plan's forecast_period has invalid forecast date range.
        /// </summary>
        [pbr::OriginalName("INVALID_FORECAST_DATE_RANGE")] InvalidForecastDateRange = 15,
        /// <summary>
        /// The plan's name is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_NAME")] InvalidName = 16,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
