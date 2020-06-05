// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/not_whitelisted_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/not_whitelisted_error.proto</summary>
  public static partial class NotWhitelistedErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/not_whitelisted_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NotWhitelistedErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvbm90X3doaXRlbGlz",
            "dGVkX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lcnJv",
            "cnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ifQoXTm90V2hpdGVs",
            "aXN0ZWRFcnJvckVudW0iYgoTTm90V2hpdGVsaXN0ZWRFcnJvchIPCgtVTlNQ",
            "RUNJRklFRBAAEgsKB1VOS05PV04QARItCilDVVNUT01FUl9OT1RfV0hJVEVM",
            "SVNURURfRk9SX1RISVNfRkVBVFVSRRACQvMBCiJjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjQuZXJyb3JzQhhOb3RXaGl0ZWxpc3RlZEVycm9yUHJvdG9Q",
            "AVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3Y0L2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WNC5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "NFxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6RXJyb3Jz",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.NotWhitelistedErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.NotWhitelistedErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.NotWhitelistedErrorEnum.Types.NotWhitelistedError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible not whitelisted errors.
  /// </summary>
  public sealed partial class NotWhitelistedErrorEnum : pb::IMessage<NotWhitelistedErrorEnum> {
    private static readonly pb::MessageParser<NotWhitelistedErrorEnum> _parser = new pb::MessageParser<NotWhitelistedErrorEnum>(() => new NotWhitelistedErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NotWhitelistedErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.NotWhitelistedErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotWhitelistedErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotWhitelistedErrorEnum(NotWhitelistedErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NotWhitelistedErrorEnum Clone() {
      return new NotWhitelistedErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NotWhitelistedErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NotWhitelistedErrorEnum other) {
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
    public void MergeFrom(NotWhitelistedErrorEnum other) {
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
    /// <summary>Container for nested types declared in the NotWhitelistedErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible not whitelisted errors.
      /// </summary>
      public enum NotWhitelistedError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Customer is not whitelisted for accessing this feature.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_WHITELISTED_FOR_THIS_FEATURE")] CustomerNotWhitelistedForThisFeature = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
