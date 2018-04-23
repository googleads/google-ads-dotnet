// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/errors/request_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/errors/request_error.proto</summary>
  public static partial class RequestErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/errors/request_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lcnJvcnMvcmVxdWVzdF9lcnJv",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZXJyb3JzIuMDChBS",
            "ZXF1ZXN0RXJyb3JFbnVtIs4DCgxSZXF1ZXN0RXJyb3ISDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESGQoVUkVTT1VSQ0VfTkFNRV9NSVNTSU5HEAMS",
            "GwoXUkVTT1VSQ0VfTkFNRV9NQUxGT1JNRUQQBBITCg9CQURfUkVTT1VSQ0Vf",
            "SUQQERIXChNJTlZBTElEX0NVU1RPTUVSX0lEEBASFgoST1BFUkFUSU9OX1JF",
            "UVVJUkVEEAUSFgoSUkVTT1VSQ0VfTk9UX0ZPVU5EEAYSFgoSSU5WQUxJRF9Q",
            "QUdFX1RPS0VOEAcSFgoSRVhQSVJFRF9QQUdFX1RPS0VOEAgSGgoWUkVRVUlS",
            "RURfRklFTERfTUlTU0lORxAJEhMKD0lNTVVUQUJMRV9GSUVMRBALEh4KGlRP",
            "T19NQU5ZX01VVEFURV9PUEVSQVRJT05TEA0SKQolQ0FOTk9UX0JFX0VYRUNV",
            "VEVEX0JZX01BTkFHRVJfQUNDT1VOVBAOEh8KG0NBTk5PVF9NT0RJRllfRk9S",
            "RUlHTl9GSUVMRBAPEhYKEklOVkFMSURfRU5VTV9WQUxVRRASEiUKIURFVkVM",
            "T1BFUl9UT0tFTl9QQVJBTUVURVJfTUlTU0lORxATQscBCiJjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAuZXJyb3JzQhFSZXF1ZXN0RXJyb3JQcm90b1AB",
            "WkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYwLkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYw",
            "XEVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Errors.RequestErrorEnum), global::Google.Ads.GoogleAds.V0.Errors.RequestErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Errors.RequestErrorEnum.Types.RequestError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible request errors.
  /// </summary>
  public sealed partial class RequestErrorEnum : pb::IMessage<RequestErrorEnum> {
    private static readonly pb::MessageParser<RequestErrorEnum> _parser = new pb::MessageParser<RequestErrorEnum>(() => new RequestErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RequestErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Errors.RequestErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestErrorEnum(RequestErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RequestErrorEnum Clone() {
      return new RequestErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RequestErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RequestErrorEnum other) {
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
    public void MergeFrom(RequestErrorEnum other) {
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
    /// <summary>Container for nested types declared in the RequestErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible request errors.
      /// </summary>
      public enum RequestError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Resource name is required for this request.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NAME_MISSING")] ResourceNameMissing = 3,
        /// <summary>
        /// Resource name provided is malformed.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NAME_MALFORMED")] ResourceNameMalformed = 4,
        /// <summary>
        /// Resource name provided is malformed.
        /// </summary>
        [pbr::OriginalName("BAD_RESOURCE_ID")] BadResourceId = 17,
        /// <summary>
        /// Customer ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CUSTOMER_ID")] InvalidCustomerId = 16,
        /// <summary>
        /// Mutate operation should have either create, update, or remove specified.
        /// </summary>
        [pbr::OriginalName("OPERATION_REQUIRED")] OperationRequired = 5,
        /// <summary>
        /// Requested resource not found.
        /// </summary>
        [pbr::OriginalName("RESOURCE_NOT_FOUND")] ResourceNotFound = 6,
        /// <summary>
        /// Next page token specified in user request is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_PAGE_TOKEN")] InvalidPageToken = 7,
        /// <summary>
        /// Next page token specified in user request has expired.
        /// </summary>
        [pbr::OriginalName("EXPIRED_PAGE_TOKEN")] ExpiredPageToken = 8,
        /// <summary>
        /// Required field is missing.
        /// </summary>
        [pbr::OriginalName("REQUIRED_FIELD_MISSING")] RequiredFieldMissing = 9,
        /// <summary>
        /// The field cannot be modified because it's immutable. It's also possible
        /// that the field can be modified using 'create' operation but not 'update'.
        /// </summary>
        [pbr::OriginalName("IMMUTABLE_FIELD")] ImmutableField = 11,
        /// <summary>
        /// Received too many entries in request.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_MUTATE_OPERATIONS")] TooManyMutateOperations = 13,
        /// <summary>
        /// Request cannot be executed by a manager account.
        /// </summary>
        [pbr::OriginalName("CANNOT_BE_EXECUTED_BY_MANAGER_ACCOUNT")] CannotBeExecutedByManagerAccount = 14,
        /// <summary>
        /// Mutate request was attempting to modify a readonly field.
        /// For instance, Budget fields can be requested for Ad Group,
        /// but are read-only for adGroups:mutate.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FOREIGN_FIELD")] CannotModifyForeignField = 15,
        /// <summary>
        /// Enum value is not permitted.
        /// </summary>
        [pbr::OriginalName("INVALID_ENUM_VALUE")] InvalidEnumValue = 18,
        /// <summary>
        /// The developer-token parameter is required for all requests.
        /// </summary>
        [pbr::OriginalName("DEVELOPER_TOKEN_PARAMETER_MISSING")] DeveloperTokenParameterMissing = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
