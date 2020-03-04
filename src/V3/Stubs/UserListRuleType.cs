// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/user_list_rule_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/user_list_rule_type.proto</summary>
  public static partial class UserListRuleTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/user_list_rule_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListRuleTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy91c2VyX2xpc3RfcnVs",
            "ZV90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtcxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJoChRVc2VyTGlzdFJ1bGVU",
            "eXBlRW51bSJQChBVc2VyTGlzdFJ1bGVUeXBlEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEg4KCkFORF9PRl9PUlMQAhIOCgpPUl9PRl9BTkRTEANC",
            "6gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IVVXNlckxp",
            "c3RSdWxlVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9lbnVtcztlbnVtc6ICA0dB",
            "QaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVudW1zygIdR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjNcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListRuleTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.UserListRuleTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListRuleTypeEnum.Types.UserListRuleType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Rule based user list rule type.
  /// </summary>
  public sealed partial class UserListRuleTypeEnum : pb::IMessage<UserListRuleTypeEnum> {
    private static readonly pb::MessageParser<UserListRuleTypeEnum> _parser = new pb::MessageParser<UserListRuleTypeEnum>(() => new UserListRuleTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListRuleTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.UserListRuleTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListRuleTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListRuleTypeEnum(UserListRuleTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListRuleTypeEnum Clone() {
      return new UserListRuleTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListRuleTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListRuleTypeEnum other) {
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
    public void MergeFrom(UserListRuleTypeEnum other) {
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
    /// <summary>Container for nested types declared in the UserListRuleTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list rule types.
      /// </summary>
      public enum UserListRuleType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conjunctive normal form.
        /// </summary>
        [pbr::OriginalName("AND_OF_ORS")] AndOfOrs = 2,
        /// <summary>
        /// Disjunctive normal form.
        /// </summary>
        [pbr::OriginalName("OR_OF_ANDS")] OrOfAnds = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
