// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/user_list_logical_rule_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/user_list_logical_rule_operator.proto</summary>
  public static partial class UserListLogicalRuleOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/user_list_logical_rule_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListLogicalRuleOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy91c2VyX2xpc3RfbG9n",
            "aWNhbF9ydWxlX29wZXJhdG9yLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Mi5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ6Ch9V",
            "c2VyTGlzdExvZ2ljYWxSdWxlT3BlcmF0b3JFbnVtIlcKG1VzZXJMaXN0TG9n",
            "aWNhbFJ1bGVPcGVyYXRvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04Q",
            "ARIHCgNBTEwQAhIHCgNBTlkQAxIICgROT05FEARC9QEKIWNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Mi5lbnVtc0IgVXNlckxpc3RMb2dpY2FsUnVsZU9w",
            "ZXJhdG9yUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2VudW1zogIDR0FBqgId",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYy",
            "OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListLogicalRuleOperatorEnum), global::Google.Ads.GoogleAds.V2.Enums.UserListLogicalRuleOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListLogicalRuleOperatorEnum.Types.UserListLogicalRuleOperator) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The logical operator of the rule.
  /// </summary>
  public sealed partial class UserListLogicalRuleOperatorEnum : pb::IMessage<UserListLogicalRuleOperatorEnum> {
    private static readonly pb::MessageParser<UserListLogicalRuleOperatorEnum> _parser = new pb::MessageParser<UserListLogicalRuleOperatorEnum>(() => new UserListLogicalRuleOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListLogicalRuleOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.UserListLogicalRuleOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum(UserListLogicalRuleOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListLogicalRuleOperatorEnum Clone() {
      return new UserListLogicalRuleOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListLogicalRuleOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListLogicalRuleOperatorEnum other) {
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
    public void MergeFrom(UserListLogicalRuleOperatorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListLogicalRuleOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list logical rule operators.
      /// </summary>
      public enum UserListLogicalRuleOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// And - all of the operands.
        /// </summary>
        [pbr::OriginalName("ALL")] All = 2,
        /// <summary>
        /// Or - at least one of the operands.
        /// </summary>
        [pbr::OriginalName("ANY")] Any = 3,
        /// <summary>
        /// Not - none of the operands.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
