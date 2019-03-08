// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/shared_criterion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/shared_criterion_error.proto</summary>
  public static partial class SharedCriterionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/shared_criterion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedCriterionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvc2hhcmVkX2NyaXRl",
            "cmlvbl9lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZXJy",
            "b3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoQBChhTaGFyZWRD",
            "cml0ZXJpb25FcnJvckVudW0iaAoUU2hhcmVkQ3JpdGVyaW9uRXJyb3ISDwoL",
            "VU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESMgouQ1JJVEVSSU9OX1RZUEVf",
            "Tk9UX0FMTE9XRURfRk9SX1NIQVJFRF9TRVRfVFlQRRACQvQBCiJjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjEuZXJyb3JzQhlTaGFyZWRDcml0ZXJpb25F",
            "cnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIe",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRXJyb3JzygIeR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjFcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.SharedCriterionErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.SharedCriterionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.SharedCriterionErrorEnum.Types.SharedCriterionError) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible shared criterion errors.
  /// </summary>
  public sealed partial class SharedCriterionErrorEnum : pb::IMessage<SharedCriterionErrorEnum> {
    private static readonly pb::MessageParser<SharedCriterionErrorEnum> _parser = new pb::MessageParser<SharedCriterionErrorEnum>(() => new SharedCriterionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SharedCriterionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.SharedCriterionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterionErrorEnum(SharedCriterionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterionErrorEnum Clone() {
      return new SharedCriterionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SharedCriterionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SharedCriterionErrorEnum other) {
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
    public void MergeFrom(SharedCriterionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the SharedCriterionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible shared criterion errors.
      /// </summary>
      public enum SharedCriterionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The criterion is not appropriate for the shared set type.
        /// </summary>
        [pbr::OriginalName("CRITERION_TYPE_NOT_ALLOWED_FOR_SHARED_SET_TYPE")] CriterionTypeNotAllowedForSharedSetType = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
