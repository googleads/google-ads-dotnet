// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/custom_audience_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/custom_audience_error.proto</summary>
  public static partial class CustomAudienceErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/custom_audience_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomAudienceErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2N1c3RvbV9hdWRp",
            "ZW5jZV9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVy",
            "cm9ycyLFAgoXQ3VzdG9tQXVkaWVuY2VFcnJvckVudW0iqQIKE0N1c3RvbUF1",
            "ZGllbmNlRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESFQoR",
            "TkFNRV9BTFJFQURZX1VTRUQQAhIeChpDQU5OT1RfUkVNT1ZFX1dISUxFX0lO",
            "X1VTRRADEhwKGFJFU09VUkNFX0FMUkVBRFlfUkVNT1ZFRBAEEi0KKU1FTUJF",
            "Ul9UWVBFX0FORF9QQVJBTUVURVJfQUxSRUFEWV9FWElTVEVEEAUSFwoTSU5W",
            "QUxJRF9NRU1CRVJfVFlQRRAGEigKJE1FTUJFUl9UWVBFX0FORF9WQUxVRV9E",
            "T0VTX05PVF9NQVRDSBAHEhQKEFBPTElDWV9WSU9MQVRJT04QCBIXChNJTlZB",
            "TElEX1RZUEVfQ0hBTkdFEAlC+AEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTAuZXJyb3JzQhhDdXN0b21BdWRpZW5jZUVycm9yUHJvdG9QAVpFZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YxMC9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjEwLkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMFxF",
            "cnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTA6OkVycm9yc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.CustomAudienceErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.CustomAudienceErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.CustomAudienceErrorEnum.Types.CustomAudienceError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible custom audience errors.
  /// </summary>
  public sealed partial class CustomAudienceErrorEnum : pb::IMessage<CustomAudienceErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomAudienceErrorEnum> _parser = new pb::MessageParser<CustomAudienceErrorEnum>(() => new CustomAudienceErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomAudienceErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.CustomAudienceErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomAudienceErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomAudienceErrorEnum(CustomAudienceErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomAudienceErrorEnum Clone() {
      return new CustomAudienceErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomAudienceErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomAudienceErrorEnum other) {
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
    public void MergeFrom(CustomAudienceErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CustomAudienceErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible custom audience errors.
      /// </summary>
      public enum CustomAudienceError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// New name in the custom audience is duplicated ignoring cases.
        /// </summary>
        [pbr::OriginalName("NAME_ALREADY_USED")] NameAlreadyUsed = 2,
        /// <summary>
        /// Cannot remove a custom audience while it's still being used as targeting.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_WHILE_IN_USE")] CannotRemoveWhileInUse = 3,
        /// <summary>
        /// Cannot update or remove a custom audience that is already removed.
        /// </summary>
        [pbr::OriginalName("RESOURCE_ALREADY_REMOVED")] ResourceAlreadyRemoved = 4,
        /// <summary>
        /// The pair of [type, value] already exists in members.
        /// </summary>
        [pbr::OriginalName("MEMBER_TYPE_AND_PARAMETER_ALREADY_EXISTED")] MemberTypeAndParameterAlreadyExisted = 5,
        /// <summary>
        /// Member type is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MEMBER_TYPE")] InvalidMemberType = 6,
        /// <summary>
        /// Member type does not have associated value.
        /// </summary>
        [pbr::OriginalName("MEMBER_TYPE_AND_VALUE_DOES_NOT_MATCH")] MemberTypeAndValueDoesNotMatch = 7,
        /// <summary>
        /// Custom audience contains a member that violates policy.
        /// </summary>
        [pbr::OriginalName("POLICY_VIOLATION")] PolicyViolation = 8,
        /// <summary>
        /// Change in custom audience type is not allowed.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE_CHANGE")] InvalidTypeChange = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
