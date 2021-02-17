// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/resources/customer_user_access_invitation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/resources/customer_user_access_invitation.proto</summary>
  public static partial class CustomerUserAccessInvitationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/resources/customer_user_access_invitation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerUserAccessInvitationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckdnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "dXNlcl9hY2Nlc3NfaW52aXRhdGlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjYucmVzb3VyY2VzGjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9l",
            "bnVtcy9hY2Nlc3NfaW52aXRhdGlvbl9zdGF0dXMucHJvdG8aL2dvb2dsZS9h",
            "ZHMvZ29vZ2xlYWRzL3Y2L2VudW1zL2FjY2Vzc19yb2xlLnByb3RvGh9nb29n",
            "bGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291",
            "cmNlLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpcEChxD",
            "dXN0b21lclVzZXJBY2Nlc3NJbnZpdGF0aW9uElQKDXJlc291cmNlX25hbWUY",
            "ASABKAlCPeBBBfpBNwo1Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3Rv",
            "bWVyVXNlckFjY2Vzc0ludml0YXRpb24SGgoNaW52aXRhdGlvbl9pZBgCIAEo",
            "A0ID4EEDElIKC2FjY2Vzc19yb2xlGAMgASgOMjguZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjYuZW51bXMuQWNjZXNzUm9sZUVudW0uQWNjZXNzUm9sZUID4EEF",
            "EhoKDWVtYWlsX2FkZHJlc3MYBCABKAlCA+BBBRIfChJjcmVhdGlvbl9kYXRl",
            "X3RpbWUYBSABKAlCA+BBAxJwChFpbnZpdGF0aW9uX3N0YXR1cxgGIAEoDjJQ",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY2LmVudW1zLkFjY2Vzc0ludml0YXRp",
            "b25TdGF0dXNFbnVtLkFjY2Vzc0ludml0YXRpb25TdGF0dXNCA+BBAzqBAepB",
            "fgo1Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyVXNlckFjY2Vz",
            "c0ludml0YXRpb24SRWN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2N1c3RvbWVy",
            "VXNlckFjY2Vzc0ludml0YXRpb25zL3tpbnZpdGF0aW9uX2lkfUKOAgolY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY2LnJlc291cmNlc0IhQ3VzdG9tZXJV",
            "c2VyQWNjZXNzSW52aXRhdGlvblByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ni9yZXNvdXJj",
            "ZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjYu",
            "UmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjZcUmVzb3VyY2Vz",
            "6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjY6OlJlc291cmNlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.AccessRoleReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Resources.CustomerUserAccessInvitation), global::Google.Ads.GoogleAds.V6.Resources.CustomerUserAccessInvitation.Parser, new[]{ "ResourceName", "InvitationId", "AccessRole", "EmailAddress", "CreationDateTime", "InvitationStatus" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represent an invitation to a new user on this customer account.
  /// </summary>
  public sealed partial class CustomerUserAccessInvitation : pb::IMessage<CustomerUserAccessInvitation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerUserAccessInvitation> _parser = new pb::MessageParser<CustomerUserAccessInvitation>(() => new CustomerUserAccessInvitation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerUserAccessInvitation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Resources.CustomerUserAccessInvitationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccessInvitation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccessInvitation(CustomerUserAccessInvitation other) : this() {
      resourceName_ = other.resourceName_;
      invitationId_ = other.invitationId_;
      accessRole_ = other.accessRole_;
      emailAddress_ = other.emailAddress_;
      creationDateTime_ = other.creationDateTime_;
      invitationStatus_ = other.invitationStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerUserAccessInvitation Clone() {
      return new CustomerUserAccessInvitation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Resource names have the form:
    /// `customers/{customer_id}/customerUserAccessInvitations/{invitation_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "invitation_id" field.</summary>
    public const int InvitationIdFieldNumber = 2;
    private long invitationId_;
    /// <summary>
    /// Output only. The ID of the invitation.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long InvitationId {
      get { return invitationId_; }
      set {
        invitationId_ = value;
      }
    }

    /// <summary>Field number for the "access_role" field.</summary>
    public const int AccessRoleFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole accessRole_ = global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified;
    /// <summary>
    /// Immutable. Access role of the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole AccessRole {
      get { return accessRole_; }
      set {
        accessRole_ = value;
      }
    }

    /// <summary>Field number for the "email_address" field.</summary>
    public const int EmailAddressFieldNumber = 4;
    private string emailAddress_ = "";
    /// <summary>
    /// Immutable. Email address the invitation was sent to.
    /// This can differ from the email address of the account
    /// that accepts the invite.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EmailAddress {
      get { return emailAddress_; }
      set {
        emailAddress_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "creation_date_time" field.</summary>
    public const int CreationDateTimeFieldNumber = 5;
    private string creationDateTime_ = "";
    /// <summary>
    /// Output only. Time invitation was created.
    /// This field is read-only.
    /// The format is "YYYY-MM-DD HH:MM:SS".
    /// Examples: "2018-03-05 09:15:00" or "2018-02-01 14:34:30"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CreationDateTime {
      get { return creationDateTime_; }
      set {
        creationDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "invitation_status" field.</summary>
    public const int InvitationStatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus invitationStatus_ = global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified;
    /// <summary>
    /// Output only. Invitation status of the user.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus InvitationStatus {
      get { return invitationStatus_; }
      set {
        invitationStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerUserAccessInvitation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerUserAccessInvitation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (InvitationId != other.InvitationId) return false;
      if (AccessRole != other.AccessRole) return false;
      if (EmailAddress != other.EmailAddress) return false;
      if (CreationDateTime != other.CreationDateTime) return false;
      if (InvitationStatus != other.InvitationStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (InvitationId != 0L) hash ^= InvitationId.GetHashCode();
      if (AccessRole != global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) hash ^= AccessRole.GetHashCode();
      if (EmailAddress.Length != 0) hash ^= EmailAddress.GetHashCode();
      if (CreationDateTime.Length != 0) hash ^= CreationDateTime.GetHashCode();
      if (InvitationStatus != global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified) hash ^= InvitationStatus.GetHashCode();
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
      if (InvitationId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(InvitationId);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AccessRole);
      }
      if (EmailAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EmailAddress);
      }
      if (CreationDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CreationDateTime);
      }
      if (InvitationStatus != global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) InvitationStatus);
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
      if (InvitationId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(InvitationId);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AccessRole);
      }
      if (EmailAddress.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EmailAddress);
      }
      if (CreationDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CreationDateTime);
      }
      if (InvitationStatus != global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) InvitationStatus);
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
      if (InvitationId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(InvitationId);
      }
      if (AccessRole != global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AccessRole);
      }
      if (EmailAddress.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EmailAddress);
      }
      if (CreationDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CreationDateTime);
      }
      if (InvitationStatus != global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) InvitationStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerUserAccessInvitation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.InvitationId != 0L) {
        InvitationId = other.InvitationId;
      }
      if (other.AccessRole != global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole.Unspecified) {
        AccessRole = other.AccessRole;
      }
      if (other.EmailAddress.Length != 0) {
        EmailAddress = other.EmailAddress;
      }
      if (other.CreationDateTime.Length != 0) {
        CreationDateTime = other.CreationDateTime;
      }
      if (other.InvitationStatus != global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus.Unspecified) {
        InvitationStatus = other.InvitationStatus;
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
            InvitationId = input.ReadInt64();
            break;
          }
          case 24: {
            AccessRole = (global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 34: {
            EmailAddress = input.ReadString();
            break;
          }
          case 42: {
            CreationDateTime = input.ReadString();
            break;
          }
          case 48: {
            InvitationStatus = (global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus) input.ReadEnum();
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
            InvitationId = input.ReadInt64();
            break;
          }
          case 24: {
            AccessRole = (global::Google.Ads.GoogleAds.V6.Enums.AccessRoleEnum.Types.AccessRole) input.ReadEnum();
            break;
          }
          case 34: {
            EmailAddress = input.ReadString();
            break;
          }
          case 42: {
            CreationDateTime = input.ReadString();
            break;
          }
          case 48: {
            InvitationStatus = (global::Google.Ads.GoogleAds.V6.Enums.AccessInvitationStatusEnum.Types.AccessInvitationStatus) input.ReadEnum();
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
