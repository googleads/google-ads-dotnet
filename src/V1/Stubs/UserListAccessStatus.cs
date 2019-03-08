// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/user_list_access_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/user_list_access_status.proto</summary>
  public static partial class UserListAccessStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/user_list_access_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListAccessStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy91c2VyX2xpc3RfYWNj",
            "ZXNzX3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iawoYVXNlckxpc3RB",
            "Y2Nlc3NTdGF0dXNFbnVtIk8KFFVzZXJMaXN0QWNjZXNzU3RhdHVzEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB0VOQUJMRUQQAhIMCghESVNB",
            "QkxFRBADQu4BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZW51bXNC",
            "GVVzZXJMaXN0QWNjZXNzU3RhdHVzUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxL2VudW1z",
            "O2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRW51bXPK",
            "Ah1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxFbnVtc+oCIUdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYxOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.UserListAccessStatusEnum), global::Google.Ads.GoogleAds.V1.Enums.UserListAccessStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.UserListAccessStatusEnum.Types.UserListAccessStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Indicates if this client still has access to the list.
  /// </summary>
  public sealed partial class UserListAccessStatusEnum : pb::IMessage<UserListAccessStatusEnum> {
    private static readonly pb::MessageParser<UserListAccessStatusEnum> _parser = new pb::MessageParser<UserListAccessStatusEnum>(() => new UserListAccessStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListAccessStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.UserListAccessStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListAccessStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListAccessStatusEnum(UserListAccessStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListAccessStatusEnum Clone() {
      return new UserListAccessStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListAccessStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListAccessStatusEnum other) {
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
    public void MergeFrom(UserListAccessStatusEnum other) {
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
    /// <summary>Container for nested types declared in the UserListAccessStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum containing possible user list access statuses.
      /// </summary>
      public enum UserListAccessStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The access is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// The access is disabled.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
