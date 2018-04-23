// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/date_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/date_error.proto</summary>
  public static partial class DateErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/date_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DateErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvZGF0ZV9lcnJvci5w",
            "cm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJyb3JzIuACCg1EYXRl",
            "RXJyb3JFbnVtIs4CCglEYXRlRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdV",
            "TktOT1dOEAESIAocSU5WQUxJRF9GSUVMRF9WQUxVRVNfSU5fREFURRACEiUK",
            "IUlOVkFMSURfRklFTERfVkFMVUVTX0lOX0RBVEVfVElNRRADEhcKE0lOVkFM",
            "SURfU1RSSU5HX0RBVEUQBBIcChhJTlZBTElEX1NUUklOR19EQVRFX1RJTUUQ",
            "BhIdChlFQVJMSUVSX1RIQU5fTUlOSU1VTV9EQVRFEAcSGwoXTEFURVJfVEhB",
            "Tl9NQVhJTVVNX0RBVEUQCBIzCi9EQVRFX1JBTkdFX01JTklNVU1fREFURV9M",
            "QVRFUl9USEFOX01BWElNVU1fREFURRAJEjIKLkRBVEVfUkFOR0VfTUlOSU1V",
            "TV9BTkRfTUFYSU1VTV9EQVRFU19CT1RIX05VTEwQCkLEAQoiY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYwLmVycm9yc0IORGF0ZUVycm9yUHJvdG9QAVpE",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxF",
            "cnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.DateErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.DateErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.DateErrorEnum.Types.DateError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible date errors.
  /// </summary>
  public sealed partial class DateErrorEnum : pb::IMessage<DateErrorEnum> {
    private static readonly pb::MessageParser<DateErrorEnum> _parser = new pb::MessageParser<DateErrorEnum>(() => new DateErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DateErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.DateErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateErrorEnum(DateErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateErrorEnum Clone() {
      return new DateErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DateErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DateErrorEnum other) {
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
    public void MergeFrom(DateErrorEnum other) {
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
    /// <summary>Container for nested types declared in the DateErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible date errors.
      /// </summary>
      public enum DateError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Given field values do not correspond to a valid date.
        /// </summary>
        [pbr::OriginalName("INVALID_FIELD_VALUES_IN_DATE")] InvalidFieldValuesInDate = 2,
        /// <summary>
        /// Given field values do not correspond to a valid date time.
        /// </summary>
        [pbr::OriginalName("INVALID_FIELD_VALUES_IN_DATE_TIME")] InvalidFieldValuesInDateTime = 3,
        /// <summary>
        /// The string date's format should be yyyymmdd.
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE")] InvalidStringDate = 4,
        /// <summary>
        /// The string date time's format should be yyyymmdd hhmmss [tz].
        /// </summary>
        [pbr::OriginalName("INVALID_STRING_DATE_TIME")] InvalidStringDateTime = 6,
        /// <summary>
        /// Date is before allowed minimum.
        /// </summary>
        [pbr::OriginalName("EARLIER_THAN_MINIMUM_DATE")] EarlierThanMinimumDate = 7,
        /// <summary>
        /// Date is after allowed maximum.
        /// </summary>
        [pbr::OriginalName("LATER_THAN_MAXIMUM_DATE")] LaterThanMaximumDate = 8,
        /// <summary>
        /// Date range bounds are not in order.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_MINIMUM_DATE_LATER_THAN_MAXIMUM_DATE")] DateRangeMinimumDateLaterThanMaximumDate = 9,
        /// <summary>
        /// Both dates in range are null.
        /// </summary>
        [pbr::OriginalName("DATE_RANGE_MINIMUM_AND_MAXIMUM_DATES_BOTH_NULL")] DateRangeMinimumAndMaximumDatesBothNull = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
