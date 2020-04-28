// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/user_list_closing_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/user_list_closing_reason.proto</summary>
  public static partial class UserListClosingReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/user_list_closing_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListClosingReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy91c2VyX2xpc3RfY2xv",
            "c2luZ19yZWFzb24ucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVu",
            "dW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIl4KGVVzZXJMaXN0",
            "Q2xvc2luZ1JlYXNvbkVudW0iQQoVVXNlckxpc3RDbG9zaW5nUmVhc29uEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgoKBlVOVVNFRBACQu8BCiFj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXNCGlVzZXJMaXN0Q2xv",
            "c2luZ1JlYXNvblByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9lbnVtcztlbnVtc6ICA0dB",
            "QaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVudW1zygIdR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjNcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMzo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListClosingReasonEnum), global::Google.Ads.GoogleAds.V3.Enums.UserListClosingReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.UserListClosingReasonEnum.Types.UserListClosingReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Indicates the reason why the userlist was closed.
  /// This enum is only used when a list is auto-closed by the system.
  /// </summary>
  public sealed partial class UserListClosingReasonEnum : pb::IMessage<UserListClosingReasonEnum> {
    private static readonly pb::MessageParser<UserListClosingReasonEnum> _parser = new pb::MessageParser<UserListClosingReasonEnum>(() => new UserListClosingReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListClosingReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.UserListClosingReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListClosingReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListClosingReasonEnum(UserListClosingReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListClosingReasonEnum Clone() {
      return new UserListClosingReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListClosingReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListClosingReasonEnum other) {
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
    public void MergeFrom(UserListClosingReasonEnum other) {
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
    /// <summary>Container for nested types declared in the UserListClosingReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list closing reasons.
      /// </summary>
      public enum UserListClosingReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The userlist was closed because of not being used for over one year.
        /// </summary>
        [pbr::OriginalName("UNUSED")] Unused = 2,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
