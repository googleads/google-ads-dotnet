// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/user_list_string_rule_item_operator.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/user_list_string_rule_item_operator.proto</summary>
  public static partial class UserListStringRuleItemOperatorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/user_list_string_rule_item_operator.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListStringRuleItemOperatorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy91c2VyX2xpc3Rfc3Ry",
            "aW5nX3J1bGVfaXRlbV9vcGVyYXRvci5wcm90bxIdZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjIuZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "6QEKIlVzZXJMaXN0U3RyaW5nUnVsZUl0ZW1PcGVyYXRvckVudW0iwgEKHlVz",
            "ZXJMaXN0U3RyaW5nUnVsZUl0ZW1PcGVyYXRvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIMCghDT05UQUlOUxACEgoKBkVRVUFMUxADEg8KC1NU",
            "QVJUU19XSVRIEAQSDQoJRU5EU19XSVRIEAUSDgoKTk9UX0VRVUFMUxAGEhAK",
            "DE5PVF9DT05UQUlOUxAHEhMKD05PVF9TVEFSVFNfV0lUSBAIEhEKDU5PVF9F",
            "TkRTX1dJVEgQCUL4AQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zQiNVc2VyTGlzdFN0cmluZ1J1bGVJdGVtT3BlcmF0b3JQcm90b1ABWkJn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjIvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMi5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyXEVudW1z",
            "6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjI6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListStringRuleItemOperatorEnum), global::Google.Ads.GoogleAds.V2.Enums.UserListStringRuleItemOperatorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.UserListStringRuleItemOperatorEnum.Types.UserListStringRuleItemOperator) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Supported rule operator for string type.
  /// </summary>
  public sealed partial class UserListStringRuleItemOperatorEnum : pb::IMessage<UserListStringRuleItemOperatorEnum> {
    private static readonly pb::MessageParser<UserListStringRuleItemOperatorEnum> _parser = new pb::MessageParser<UserListStringRuleItemOperatorEnum>(() => new UserListStringRuleItemOperatorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListStringRuleItemOperatorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.UserListStringRuleItemOperatorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListStringRuleItemOperatorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListStringRuleItemOperatorEnum(UserListStringRuleItemOperatorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListStringRuleItemOperatorEnum Clone() {
      return new UserListStringRuleItemOperatorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListStringRuleItemOperatorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListStringRuleItemOperatorEnum other) {
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
    public void MergeFrom(UserListStringRuleItemOperatorEnum other) {
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
    /// <summary>Container for nested types declared in the UserListStringRuleItemOperatorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list string rule item operators.
      /// </summary>
      public enum UserListStringRuleItemOperator {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Contains.
        /// </summary>
        [pbr::OriginalName("CONTAINS")] Contains = 2,
        /// <summary>
        /// Equals.
        /// </summary>
        [pbr::OriginalName("EQUALS")] Equals = 3,
        /// <summary>
        /// Starts with.
        /// </summary>
        [pbr::OriginalName("STARTS_WITH")] StartsWith = 4,
        /// <summary>
        /// Ends with.
        /// </summary>
        [pbr::OriginalName("ENDS_WITH")] EndsWith = 5,
        /// <summary>
        /// Not equals.
        /// </summary>
        [pbr::OriginalName("NOT_EQUALS")] NotEquals = 6,
        /// <summary>
        /// Not contains.
        /// </summary>
        [pbr::OriginalName("NOT_CONTAINS")] NotContains = 7,
        /// <summary>
        /// Not starts with.
        /// </summary>
        [pbr::OriginalName("NOT_STARTS_WITH")] NotStartsWith = 8,
        /// <summary>
        /// Not ends with.
        /// </summary>
        [pbr::OriginalName("NOT_ENDS_WITH")] NotEndsWith = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
