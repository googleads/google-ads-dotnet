// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/user_list_number_rule_item_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/user_list_number_rule_item_operator.proto</summary>
  public static partial class UserListNumberRuleItemOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/user_list_number_rule_item_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListNumberRuleItemOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvdXNlcl9saXN0X251",
            "bWJlcl9ydWxlX2l0ZW1fb3BlcmF0b3IucHJvdG8SHmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYyMC5lbnVtcyLVAQoiVXNlckxpc3ROdW1iZXJSdWxlSXRlbU9w",
            "ZXJhdG9yRW51bSKuAQoeVXNlckxpc3ROdW1iZXJSdWxlSXRlbU9wZXJhdG9y",
            "Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhAKDEdSRUFURVJfVEhB",
            "ThACEhkKFUdSRUFURVJfVEhBTl9PUl9FUVVBTBADEgoKBkVRVUFMUxAEEg4K",
            "Ck5PVF9FUVVBTFMQBRINCglMRVNTX1RIQU4QBhIWChJMRVNTX1RIQU5fT1Jf",
            "RVFVQUwQB0L9AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lbnVt",
            "c0IjVXNlckxpc3ROdW1iZXJSdWxlSXRlbU9wZXJhdG9yUHJvdG9QAVpDZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YyMC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYyMC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxFbnVt",
            "c+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.UserListNumberRuleItemOperatorEnum), global::Google.Ads.GoogleAds.V20.Enums.UserListNumberRuleItemOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.UserListNumberRuleItemOperatorEnum.Types.UserListNumberRuleItemOperator) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Supported rule operator for number type.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserListNumberRuleItemOperatorEnum : pb::IMessage<UserListNumberRuleItemOperatorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserListNumberRuleItemOperatorEnum> _parser = new pb::MessageParser<UserListNumberRuleItemOperatorEnum>(() => new UserListNumberRuleItemOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserListNumberRuleItemOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.UserListNumberRuleItemOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListNumberRuleItemOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListNumberRuleItemOperatorEnum(UserListNumberRuleItemOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListNumberRuleItemOperatorEnum Clone() {
      return new UserListNumberRuleItemOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserListNumberRuleItemOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserListNumberRuleItemOperatorEnum other) {
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
    public void MergeFrom(UserListNumberRuleItemOperatorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListNumberRuleItemOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list number rule item operators.
      /// </summary>
      public enum UserListNumberRuleItemOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Greater than.
        /// </summary>
        [pbr::OriginalName("GREATER_THAN")] GreaterThan = 2,
        /// <summary>
        /// Greater than or equal.
        /// </summary>
        [pbr::OriginalName("GREATER_THAN_OR_EQUAL")] GreaterThanOrEqual = 3,
        /// <summary>
        /// Equals.
        /// </summary>
        [pbr::OriginalName("EQUALS")] Equals = 4,
        /// <summary>
        /// Not equals.
        /// </summary>
        [pbr::OriginalName("NOT_EQUALS")] NotEquals = 5,
        /// <summary>
        /// Less than.
        /// </summary>
        [pbr::OriginalName("LESS_THAN")] LessThan = 6,
        /// <summary>
        /// Less than or equal.
        /// </summary>
        [pbr::OriginalName("LESS_THAN_OR_EQUAL")] LessThanOrEqual = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
