// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/user_list_combined_rule_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/user_list_combined_rule_operator.proto</summary>
  public static partial class UserListCombinedRuleOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/user_list_combined_rule_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListCombinedRuleOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy91c2VyX2xpc3RfY29t",
            "YmluZWRfcnVsZV9vcGVyYXRvci5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjIuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8idgog",
            "VXNlckxpc3RDb21iaW5lZFJ1bGVPcGVyYXRvckVudW0iUgocVXNlckxpc3RD",
            "b21iaW5lZFJ1bGVPcGVyYXRvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIHCgNBTkQQAhILCgdBTkRfTk9UEANC9gEKIWNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52Mi5lbnVtc0IhVXNlckxpc3RDb21iaW5lZFJ1bGVPcGVy",
            "YXRvclByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2ds",
            "ZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcztlbnVtc6ICA0dBQaoCHUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVudW1zygIdR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjJcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6",
            "RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListCombinedRuleOperatorEnum), global::Google.Ads.GoogleAds.V2.Enums.UserListCombinedRuleOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListCombinedRuleOperatorEnum.Types.UserListCombinedRuleOperator) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Logical operator connecting two rules.
  /// </summary>
  public sealed partial class UserListCombinedRuleOperatorEnum : pb::IMessage<UserListCombinedRuleOperatorEnum> {
    private static readonly pb::MessageParser<UserListCombinedRuleOperatorEnum> _parser = new pb::MessageParser<UserListCombinedRuleOperatorEnum>(() => new UserListCombinedRuleOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListCombinedRuleOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.UserListCombinedRuleOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCombinedRuleOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCombinedRuleOperatorEnum(UserListCombinedRuleOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCombinedRuleOperatorEnum Clone() {
      return new UserListCombinedRuleOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListCombinedRuleOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListCombinedRuleOperatorEnum other) {
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
    public void MergeFrom(UserListCombinedRuleOperatorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListCombinedRuleOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list combined rule operators.
      /// </summary>
      public enum UserListCombinedRuleOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A AND B.
        /// </summary>
        [pbr::OriginalName("AND")] And = 2,
        /// <summary>
        /// A AND NOT B.
        /// </summary>
        [pbr::OriginalName("AND_NOT")] AndNot = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
