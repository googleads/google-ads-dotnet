// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/user_list_number_rule_item_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/user_list_number_rule_item_operator.proto</summary>
  public static partial class UserListNumberRuleItemOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/user_list_number_rule_item_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListNumberRuleItemOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy91c2VyX2xpc3RfbnVt",
            "YmVyX3J1bGVfaXRlbV9vcGVyYXRvci5wcm90bxIdZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "1QEKIlVzZXJMaXN0TnVtYmVyUnVsZUl0ZW1PcGVyYXRvckVudW0irgEKHlVz",
            "ZXJMaXN0TnVtYmVyUnVsZUl0ZW1PcGVyYXRvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIQCgxHUkVBVEVSX1RIQU4QAhIZChVHUkVBVEVSX1RI",
            "QU5fT1JfRVFVQUwQAxIKCgZFUVVBTFMQBBIOCgpOT1RfRVFVQUxTEAUSDQoJ",
            "TEVTU19USEFOEAYSFgoSTEVTU19USEFOX09SX0VRVUFMEAdC+AEKIWNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IjVXNlckxpc3ROdW1iZXJS",
            "dWxlSXRlbU9wZXJhdG9yUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1z",
            "ogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListNumberRuleItemOperatorEnum), global::Google.Ads.GoogleAds.V3.Enums.UserListNumberRuleItemOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListNumberRuleItemOperatorEnum.Types.UserListNumberRuleItemOperator) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Supported rule operator for number type.
  /// </summary>
  public sealed partial class UserListNumberRuleItemOperatorEnum : pb::IMessage<UserListNumberRuleItemOperatorEnum> {
    private static readonly pb::MessageParser<UserListNumberRuleItemOperatorEnum> _parser = new pb::MessageParser<UserListNumberRuleItemOperatorEnum>(() => new UserListNumberRuleItemOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListNumberRuleItemOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.UserListNumberRuleItemOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListNumberRuleItemOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListNumberRuleItemOperatorEnum(UserListNumberRuleItemOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListNumberRuleItemOperatorEnum Clone() {
      return new UserListNumberRuleItemOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListNumberRuleItemOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(UserListNumberRuleItemOperatorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListNumberRuleItemOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
