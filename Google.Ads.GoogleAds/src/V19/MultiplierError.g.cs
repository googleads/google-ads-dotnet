// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/multiplier_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/multiplier_error.proto</summary>
  public static partial class MultiplierErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/multiplier_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MultiplierErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL211bHRpcGxpZXJf",
            "ZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lcnJvcnMi",
            "zwQKE011bHRpcGxpZXJFcnJvckVudW0itwQKD011bHRpcGxpZXJFcnJvchIP",
            "CgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIXChNNVUxUSVBMSUVSX1RP",
            "T19ISUdIEAISFgoSTVVMVElQTElFUl9UT09fTE9XEAMSHgoaVE9PX01BTllf",
            "RlJBQ1RJT05BTF9ESUdJVFMQBBIvCitNVUxUSVBMSUVSX05PVF9BTExPV0VE",
            "X0ZPUl9CSURESU5HX1NUUkFURUdZEAUSMwovTVVMVElQTElFUl9OT1RfQUxM",
            "T1dFRF9XSEVOX0JBU0VfQklEX0lTX01JU1NJTkcQBhIbChdOT19NVUxUSVBM",
            "SUVSX1NQRUNJRklFRBAHEjAKLE1VTFRJUExJRVJfQ0FVU0VTX0JJRF9UT19F",
            "WENFRURfREFJTFlfQlVER0VUEAgSMgouTVVMVElQTElFUl9DQVVTRVNfQklE",
            "X1RPX0VYQ0VFRF9NT05USExZX0JVREdFVBAJEjEKLU1VTFRJUExJRVJfQ0FV",
            "U0VTX0JJRF9UT19FWENFRURfQ1VTVE9NX0JVREdFVBAKEjMKL01VTFRJUExJ",
            "RVJfQ0FVU0VTX0JJRF9UT19FWENFRURfTUFYX0FMTE9XRURfQklEEAsSMQot",
            "QklEX0xFU1NfVEhBTl9NSU5fQUxMT1dFRF9CSURfV0lUSF9NVUxUSVBMSUVS",
            "EAwSMQotTVVMVElQTElFUl9BTkRfQklERElOR19TVFJBVEVHWV9UWVBFX01J",
            "U01BVENIEA1C9AEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZXJy",
            "b3JzQhRNdWx0aXBsaWVyRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE5L2Vycm9y",
            "cztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTkuRXJy",
            "b3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE5XEVycm9yc+oCI0dvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.MultiplierErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.MultiplierErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.MultiplierErrorEnum.Types.MultiplierError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible multiplier errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MultiplierErrorEnum : pb::IMessage<MultiplierErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MultiplierErrorEnum> _parser = new pb::MessageParser<MultiplierErrorEnum>(() => new MultiplierErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MultiplierErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.MultiplierErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum(MultiplierErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MultiplierErrorEnum Clone() {
      return new MultiplierErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MultiplierErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MultiplierErrorEnum other) {
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
    public void MergeFrom(MultiplierErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MultiplierErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible multiplier errors.
      /// </summary>
      public enum MultiplierError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Multiplier value is too high
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_TOO_HIGH")] MultiplierTooHigh = 2,
        /// <summary>
        /// Multiplier value is too low
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_TOO_LOW")] MultiplierTooLow = 3,
        /// <summary>
        /// Too many fractional digits
        /// </summary>
        [pbr::OriginalName("TOO_MANY_FRACTIONAL_DIGITS")] TooManyFractionalDigits = 4,
        /// <summary>
        /// A multiplier cannot be set for this bidding strategy
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_NOT_ALLOWED_FOR_BIDDING_STRATEGY")] MultiplierNotAllowedForBiddingStrategy = 5,
        /// <summary>
        /// A multiplier cannot be set when there is no base bid (for example,
        /// content max cpc)
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_NOT_ALLOWED_WHEN_BASE_BID_IS_MISSING")] MultiplierNotAllowedWhenBaseBidIsMissing = 6,
        /// <summary>
        /// A bid multiplier must be specified
        /// </summary>
        [pbr::OriginalName("NO_MULTIPLIER_SPECIFIED")] NoMultiplierSpecified = 7,
        /// <summary>
        /// Multiplier causes bid to exceed daily budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_DAILY_BUDGET")] MultiplierCausesBidToExceedDailyBudget = 8,
        /// <summary>
        /// Multiplier causes bid to exceed monthly budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_MONTHLY_BUDGET")] MultiplierCausesBidToExceedMonthlyBudget = 9,
        /// <summary>
        /// Multiplier causes bid to exceed custom budget
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_CUSTOM_BUDGET")] MultiplierCausesBidToExceedCustomBudget = 10,
        /// <summary>
        /// Multiplier causes bid to exceed maximum allowed bid
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_CAUSES_BID_TO_EXCEED_MAX_ALLOWED_BID")] MultiplierCausesBidToExceedMaxAllowedBid = 11,
        /// <summary>
        /// Multiplier causes bid to become less than the minimum bid allowed
        /// </summary>
        [pbr::OriginalName("BID_LESS_THAN_MIN_ALLOWED_BID_WITH_MULTIPLIER")] BidLessThanMinAllowedBidWithMultiplier = 12,
        /// <summary>
        /// Multiplier type (cpc versus cpm) needs to match campaign's bidding
        /// strategy
        /// </summary>
        [pbr::OriginalName("MULTIPLIER_AND_BIDDING_STRATEGY_TYPE_MISMATCH")] MultiplierAndBiddingStrategyTypeMismatch = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
