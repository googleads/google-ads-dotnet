// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/customer_user_access.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/customer_user_access.proto</summary>
  public static partial class CustomerUserAccessReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/customer_user_access.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerUserAccessReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "dXNlcl9hY2Nlc3MucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJl",
            "c291cmNlcxovZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvYWNjZXNz",
            "X3JvbGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8a",
            "GWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3Rh",
            "dGlvbnMucHJvdG8i+gMKEkN1c3RvbWVyVXNlckFjY2VzcxJKCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjPgQQX6QS0KK2dvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DdXN0b21lclVzZXJBY2Nlc3MSFAoHdXNlcl9pZBgCIAEoA0ID4EEDEh8K",
            "DWVtYWlsX2FkZHJlc3MYAyABKAlCA+BBA0gAiAEBEk0KC2FjY2Vzc19yb2xl",
            "GAQgASgOMjguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMuQWNjZXNz",
            "Um9sZUVudW0uQWNjZXNzUm9sZRIrChlhY2Nlc3NfY3JlYXRpb25fZGF0ZV90",
            "aW1lGAYgASgJQgPgQQNIAYgBARIsChppbnZpdGVyX3VzZXJfZW1haWxfYWRk",
            "cmVzcxgHIAEoCUID4EEDSAKIAQE6aOpBZQorZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0N1c3RvbWVyVXNlckFjY2VzcxI2Y3VzdG9tZXJzL3tjdXN0b21l",
            "cl9pZH0vY3VzdG9tZXJVc2VyQWNjZXNzZXMve3VzZXJfaWR9QhAKDl9lbWFp",
            "bF9hZGRyZXNzQhwKGl9hY2Nlc3NfY3JlYXRpb25fZGF0ZV90aW1lQh0KG19p",
            "bnZpdGVyX3VzZXJfZW1haWxfYWRkcmVzc0KEAgolY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY3LnJlc291cmNlc0IXQ3VzdG9tZXJVc2VyQWNjZXNzUHJv",
            "dG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3Y3L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WNy5SZXNvdXJjZXPKAiFHb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWN1xSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWNzo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Enums.AccessRoleReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess), global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccess.Parser, new[]{ "ResourceName", "UserId", "EmailAddress", "AccessRole", "AccessCreationDateTime", "InviterUserEmailAddress" }, new[]{ "EmailAddress", "AccessCreationDateTime", "InviterUserEmailAddress" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the permission of a single user onto a single customer.
  /// </summary>
  public sealed partial class CustomerUserAccess : pb::IMessage<CustomerUserAccess>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerUserAccess> _parser = new pb::MessageParser<CustomerUserAccess>(() => new CustomerUserAccess());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerUserAccess> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.CustomerUserAccessReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccess() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccess(CustomerUserAccess other) : this() {
      resourceName_ = other.resourceName_;
      userId_ = other.userId_;
      emailAddress_ = other.emailAddress_;
      accessRole_ = other.accessRole_;
      accessCreationDateTime_ = other.accessCreationDateTime_;
      inviterUserEmailAddress_ = other.inviterUserEmailAddress_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccess Clone() {
      return new CustomerUserAccess(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Resource names have the form:
    /// `customers/{customer_id}/customerUserAccesses/{user_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 2;
    private long userId_;
    /// <summary>
    /// Output only. User id of the user with the customer access.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }

    /// <summary>Field number for the "email_address" field.</summary>
    public const int EmailAddressFieldNumber = 3;
    private string emailAddress_;
    /// <summary>
    /// Output only. Email address of the user.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EmailAddress {
      get { return emailAddress_ ?? ""; }
      set {
        emailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "email_address" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasEmailAddress {
      get { return emailAddress_ != null; }
    }
    /// <summary>Clears the value of the "email_address" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearEmailAddress() {
      emailAddress_ = null;
    }

    /// <summary>Field number for the "access_role" field.</summary>
    public const int AccessRoleFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole accessRole_ = global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified;
    /// <summary>
    /// Access role of the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole AccessRole {
      get { return accessRole_; }
      set {
        accessRole_ = value;
      }
    }

    /// <summary>Field number for the "access_creation_date_time" field.</summary>
    public const int AccessCreationDateTimeFieldNumber = 6;
    private string accessCreationDateTime_;
    /// <summary>
    /// Output only. The customer user access creation time.
    /// Read only field
    /// The format is "YYYY-MM-DD HH:MM:SS".
    /// Examples: "2018-03-05 09:15:00" or "2018-02-01 14:34:30"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AccessCreationDateTime {
      get { return accessCreationDateTime_ ?? ""; }
      set {
        accessCreationDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "access_creation_date_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAccessCreationDateTime {
      get { return accessCreationDateTime_ != null; }
    }
    /// <summary>Clears the value of the "access_creation_date_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAccessCreationDateTime() {
      accessCreationDateTime_ = null;
    }

    /// <summary>Field number for the "inviter_user_email_address" field.</summary>
    public const int InviterUserEmailAddressFieldNumber = 7;
    private string inviterUserEmailAddress_;
    /// <summary>
    /// Output only. The email address of the inviter user.
    /// Read only field
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string InviterUserEmailAddress {
      get { return inviterUserEmailAddress_ ?? ""; }
      set {
        inviterUserEmailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "inviter_user_email_address" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasInviterUserEmailAddress {
      get { return inviterUserEmailAddress_ != null; }
    }
    /// <summary>Clears the value of the "inviter_user_email_address" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearInviterUserEmailAddress() {
      inviterUserEmailAddress_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerUserAccess);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerUserAccess other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (UserId != other.UserId) return false;
      if (EmailAddress != other.EmailAddress) return false;
      if (AccessRole != other.AccessRole) return false;
      if (AccessCreationDateTime != other.AccessCreationDateTime) return false;
      if (InviterUserEmailAddress != other.InviterUserEmailAddress) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (UserId != 0L) hash ^= UserId.GetHashCode();
      if (HasEmailAddress) hash ^= EmailAddress.GetHashCode();
      if (AccessRole != global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) hash ^= AccessRole.GetHashCode();
      if (HasAccessCreationDateTime) hash ^= AccessCreationDateTime.GetHashCode();
      if (HasInviterUserEmailAddress) hash ^= InviterUserEmailAddress.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (UserId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UserId);
      }
      if (HasEmailAddress) {
        output.WriteRawTag(26);
        output.WriteString(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        output.WriteRawTag(50);
        output.WriteString(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        output.WriteRawTag(58);
        output.WriteString(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (UserId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(UserId);
      }
      if (HasEmailAddress) {
        output.WriteRawTag(26);
        output.WriteString(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        output.WriteRawTag(50);
        output.WriteString(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        output.WriteRawTag(58);
        output.WriteString(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (UserId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(UserId);
      }
      if (HasEmailAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmailAddress);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AccessRole);
      }
      if (HasAccessCreationDateTime) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AccessCreationDateTime);
      }
      if (HasInviterUserEmailAddress) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InviterUserEmailAddress);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerUserAccess other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.UserId != 0L) {
        UserId = other.UserId;
      }
      if (other.HasEmailAddress) {
        EmailAddress = other.EmailAddress;
      }
      if (other.AccessRole != global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        AccessRole = other.AccessRole;
      }
      if (other.HasAccessCreationDateTime) {
        AccessCreationDateTime = other.AccessCreationDateTime;
      }
      if (other.HasInviterUserEmailAddress) {
        InviterUserEmailAddress = other.InviterUserEmailAddress;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            UserId = input.ReadInt64();
            break;
          }
          case 26: {
            EmailAddress = input.ReadString();
            break;
          }
          case 32: {
            AccessRole = (global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 50: {
            AccessCreationDateTime = input.ReadString();
            break;
          }
          case 58: {
            InviterUserEmailAddress = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            UserId = input.ReadInt64();
            break;
          }
          case 26: {
            EmailAddress = input.ReadString();
            break;
          }
          case 32: {
            AccessRole = (global::Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 50: {
            AccessCreationDateTime = input.ReadString();
            break;
          }
          case 58: {
            InviterUserEmailAddress = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
