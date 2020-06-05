// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/custom_interest_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/custom_interest_error.proto</summary>
  public static partial class CustomInterestErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/custom_interest_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomInterestErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvY3VzdG9tX2ludGVy",
            "ZXN0X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lcnJv",
            "cnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i2QIKF0N1c3RvbUlu",
            "dGVyZXN0RXJyb3JFbnVtIr0CChNDdXN0b21JbnRlcmVzdEVycm9yEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhUKEU5BTUVfQUxSRUFEWV9VU0VE",
            "EAISRgpCQ1VTVE9NX0lOVEVSRVNUX01FTUJFUl9JRF9BTkRfVFlQRV9QQVJB",
            "TUVURVJfTk9UX1BSRVNFTlRfSU5fUkVNT1ZFEAMSIAocVFlQRV9BTkRfUEFS",
            "QU1FVEVSX05PVF9GT1VORBAEEiYKIlRZUEVfQU5EX1BBUkFNRVRFUl9BTFJF",
            "QURZX0VYSVNURUQQBRInCiNJTlZBTElEX0NVU1RPTV9JTlRFUkVTVF9NRU1C",
            "RVJfVFlQRRAGEh4KGkNBTk5PVF9SRU1PVkVfV0hJTEVfSU5fVVNFEAcSFgoS",
            "Q0FOTk9UX0NIQU5HRV9UWVBFEAhC8wEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52NC5lcnJvcnNCGEN1c3RvbUludGVyZXN0RXJyb3JQcm90b1ABWkRn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjQvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlY0LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XEVy",
            "cm9yc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpFcnJvcnNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.CustomInterestErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.CustomInterestErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.CustomInterestErrorEnum.Types.CustomInterestError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible custom interest errors.
  /// </summary>
  public sealed partial class CustomInterestErrorEnum : pb::IMessage<CustomInterestErrorEnum> {
    private static readonly pb::MessageParser<CustomInterestErrorEnum> _parser = new pb::MessageParser<CustomInterestErrorEnum>(() => new CustomInterestErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomInterestErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.CustomInterestErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestErrorEnum(CustomInterestErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomInterestErrorEnum Clone() {
      return new CustomInterestErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomInterestErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomInterestErrorEnum other) {
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
    public void MergeFrom(CustomInterestErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CustomInterestErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible custom interest errors.
      /// </summary>
      public enum CustomInterestError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Duplicate custom interest name ignoring case.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_USED")] NameAlreadyUsed = 2,
        /// <summary>
        /// In the remove custom interest member operation, both member ID and
        /// pair [type, parameter] are not present.
        /// </summary>
        [pbr::OriginalName("CUSTOM_INTEREST_MEMBER_ID_AND_TYPE_PARAMETER_NOT_PRESENT_IN_REMOVE")] CustomInterestMemberIdAndTypeParameterNotPresentInRemove = 3,
        /// <summary>
        /// The pair of [type, parameter] does not exist.
        /// </summary>
        [pbr::OriginalName("TYPE_AND_PARAMETER_NOT_FOUND")] TypeAndParameterNotFound = 4,
        /// <summary>
        /// The pair of [type, parameter] already exists.
        /// </summary>
        [pbr::OriginalName("TYPE_AND_PARAMETER_ALREADY_EXISTED")] TypeAndParameterAlreadyExisted = 5,
        /// <summary>
        /// Unsupported custom interest member type.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOM_INTEREST_MEMBER_TYPE")] InvalidCustomInterestMemberType = 6,
        /// <summary>
        /// Cannot remove a custom interest while it's still being targeted.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_WHILE_IN_USE")] CannotRemoveWhileInUse = 7,
        /// <summary>
        /// Cannot mutate custom interest type.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_TYPE")] CannotChangeType = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
