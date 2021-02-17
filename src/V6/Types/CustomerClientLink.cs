// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/resources/customer_client_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/resources/customer_client_link.proto</summary>
  public static partial class CustomerClientLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/resources/customer_client_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y2xpZW50X2xpbmsucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY2LnJl",
            "c291cmNlcxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjYvZW51bXMvbWFuYWdl",
            "cl9saW5rX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90byL0AwoSQ3VzdG9tZXJDbGllbnRMaW5rEkoK",
            "DXJlc291cmNlX25hbWUYASABKAlCM+BBBfpBLQorZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL0N1c3RvbWVyQ2xpZW50TGluaxJHCg9jbGllbnRfY3VzdG9t",
            "ZXIYByABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1",
            "c3RvbWVySACIAQESIQoPbWFuYWdlcl9saW5rX2lkGAggASgDQgPgQQNIAYgB",
            "ARJWCgZzdGF0dXMYBSABKA4yRi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5l",
            "bnVtcy5NYW5hZ2VyTGlua1N0YXR1c0VudW0uTWFuYWdlckxpbmtTdGF0dXMS",
            "EwoGaGlkZGVuGAkgASgISAKIAQE6hQHqQYEBCitnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ3VzdG9tZXJDbGllbnRMaW5rElJjdXN0b21lcnMve2N1c3Rv",
            "bWVyX2lkfS9jdXN0b21lckNsaWVudExpbmtzL3tjbGllbnRfY3VzdG9tZXJf",
            "aWR9fnttYW5hZ2VyX2xpbmtfaWR9QhIKEF9jbGllbnRfY3VzdG9tZXJCEgoQ",
            "X21hbmFnZXJfbGlua19pZEIJCgdfaGlkZGVuQoQCCiVjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjYucmVzb3VyY2VzQhdDdXN0b21lckNsaWVudExpbmtQ",
            "cm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjYvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoC",
            "IUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY2LlJlc291cmNlc8oCIUdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFY2XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlY2OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Resources.CustomerClientLink), global::Google.Ads.GoogleAds.V6.Resources.CustomerClientLink.Parser, new[]{ "ResourceName", "ClientCustomer", "ManagerLinkId", "Status", "Hidden" }, new[]{ "ClientCustomer", "ManagerLinkId", "Hidden" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents customer client link relationship.
  /// </summary>
  public sealed partial class CustomerClientLink : pb::IMessage<CustomerClientLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerClientLink> _parser = new pb::MessageParser<CustomerClientLink>(() => new CustomerClientLink());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerClientLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Resources.CustomerClientLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink(CustomerClientLink other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      clientCustomer_ = other.clientCustomer_;
      managerLinkId_ = other.managerLinkId_;
      status_ = other.status_;
      hidden_ = other.hidden_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerClientLink Clone() {
      return new CustomerClientLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// CustomerClientLink resource names have the form:
    /// `customers/{customer_id}/customerClientLinks/{client_customer_id}~{manager_link_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_customer" field.</summary>
    public const int ClientCustomerFieldNumber = 7;
    private string clientCustomer_;
    /// <summary>
    /// Immutable. The client customer linked to this customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientCustomer {
      get { return clientCustomer_ ?? ""; }
      set {
        clientCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "client_customer" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasClientCustomer {
      get { return clientCustomer_ != null; }
    }
    /// <summary>Clears the value of the "client_customer" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearClientCustomer() {
      clientCustomer_ = null;
    }

    /// <summary>Field number for the "manager_link_id" field.</summary>
    public const int ManagerLinkIdFieldNumber = 8;
    private long managerLinkId_;
    /// <summary>
    /// Output only. This is uniquely identifies a customer client link. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ManagerLinkId {
      get { if ((_hasBits0 & 1) != 0) { return managerLinkId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        managerLinkId_ = value;
      }
    }
    /// <summary>Gets whether the "manager_link_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasManagerLinkId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "manager_link_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearManagerLinkId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus status_ = global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified;
    /// <summary>
    /// This is the status of the link between client and manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 9;
    private bool hidden_;
    /// <summary>
    /// The visibility of the link. Users can choose whether or not to see hidden
    /// links in the Google Ads UI.
    /// Default value is false
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Hidden {
      get { if ((_hasBits0 & 2) != 0) { return hidden_; } else { return false; } }
      set {
        _hasBits0 |= 2;
        hidden_ = value;
      }
    }
    /// <summary>Gets whether the "hidden" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasHidden {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "hidden" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearHidden() {
      _hasBits0 &= ~2;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerClientLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerClientLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ClientCustomer != other.ClientCustomer) return false;
      if (ManagerLinkId != other.ManagerLinkId) return false;
      if (Status != other.Status) return false;
      if (Hidden != other.Hidden) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasClientCustomer) hash ^= ClientCustomer.GetHashCode();
      if (HasManagerLinkId) hash ^= ManagerLinkId.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (HasHidden) hash ^= Hidden.GetHashCode();
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
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasClientCustomer) {
        output.WriteRawTag(58);
        output.WriteString(ClientCustomer);
      }
      if (HasManagerLinkId) {
        output.WriteRawTag(64);
        output.WriteInt64(ManagerLinkId);
      }
      if (HasHidden) {
        output.WriteRawTag(72);
        output.WriteBool(Hidden);
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
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasClientCustomer) {
        output.WriteRawTag(58);
        output.WriteString(ClientCustomer);
      }
      if (HasManagerLinkId) {
        output.WriteRawTag(64);
        output.WriteInt64(ManagerLinkId);
      }
      if (HasHidden) {
        output.WriteRawTag(72);
        output.WriteBool(Hidden);
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
      if (HasClientCustomer) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientCustomer);
      }
      if (HasManagerLinkId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (HasHidden) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerClientLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasClientCustomer) {
        ClientCustomer = other.ClientCustomer;
      }
      if (other.HasManagerLinkId) {
        ManagerLinkId = other.ManagerLinkId;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.HasHidden) {
        Hidden = other.Hidden;
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
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
          case 58: {
            ClientCustomer = input.ReadString();
            break;
          }
          case 64: {
            ManagerLinkId = input.ReadInt64();
            break;
          }
          case 72: {
            Hidden = input.ReadBool();
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
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V6.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
          case 58: {
            ClientCustomer = input.ReadString();
            break;
          }
          case 64: {
            ManagerLinkId = input.ReadInt64();
            break;
          }
          case 72: {
            Hidden = input.ReadBool();
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
