// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v18/errors/customer_client_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V18.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v18/errors/customer_client_link_error.proto</summary>
  public static partial class CustomerClientLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v18/errors/customer_client_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerClientLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTgvZXJyb3JzL2N1c3RvbWVyX2Ns",
            "aWVudF9saW5rX2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTguZXJyb3JzIo8DChtDdXN0b21lckNsaWVudExpbmtFcnJvckVudW0i7wIK",
            "F0N1c3RvbWVyQ2xpZW50TGlua0Vycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEioKJkNMSUVOVF9BTFJFQURZX0lOVklURURfQllfVEhJU19N",
            "QU5BR0VSEAISJwojQ0xJRU5UX0FMUkVBRFlfTUFOQUdFRF9JTl9ISUVSQVJD",
            "SFkQAxIbChdDWUNMSUNfTElOS19OT1RfQUxMT1dFRBAEEiIKHkNVU1RPTUVS",
            "X0hBU19UT09fTUFOWV9BQ0NPVU5UUxAFEiMKH0NMSUVOVF9IQVNfVE9PX01B",
            "TllfSU5WSVRBVElPTlMQBhIqCiZDQU5OT1RfSElERV9PUl9VTkhJREVfTUFO",
            "QUdFUl9BQ0NPVU5UUxAHEi0KKUNVU1RPTUVSX0hBU19UT09fTUFOWV9BQ0NP",
            "VU5UU19BVF9NQU5BR0VSEAgSIAocQ0xJRU5UX0hBU19UT09fTUFOWV9NQU5B",
            "R0VSUxAJQvwBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE4LmVycm9y",
            "c0IcQ3VzdG9tZXJDbGllbnRMaW5rRXJyb3JQcm90b1ABWkVnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE4",
            "L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTguRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE4XEVycm9yc+oC",
            "I0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxODo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V18.Errors.CustomerClientLinkErrorEnum), global::Google.Ads.GoogleAds.V18.Errors.CustomerClientLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V18.Errors.CustomerClientLinkErrorEnum.Types.CustomerClientLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible CustomeClientLink errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CustomerClientLinkErrorEnum : pb::IMessage<CustomerClientLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerClientLinkErrorEnum> _parser = new pb::MessageParser<CustomerClientLinkErrorEnum>(() => new CustomerClientLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerClientLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V18.Errors.CustomerClientLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClientLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClientLinkErrorEnum(CustomerClientLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerClientLinkErrorEnum Clone() {
      return new CustomerClientLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerClientLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerClientLinkErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerClientLinkErrorEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CustomerClientLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible CustomerClientLink errors.
      /// </summary>
      public enum CustomerClientLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Trying to manage a client that already in being managed by customer.
        /// </summary>
        [pbr::OriginalName("CLIENT_ALREADY_INVITED_BY_THIS_MANAGER")] ClientAlreadyInvitedByThisManager = 2,
        /// <summary>
        /// Already managed by some other manager in the hierarchy.
        /// </summary>
        [pbr::OriginalName("CLIENT_ALREADY_MANAGED_IN_HIERARCHY")] ClientAlreadyManagedInHierarchy = 3,
        /// <summary>
        /// Attempt to create a cycle in the hierarchy.
        /// </summary>
        [pbr::OriginalName("CYCLIC_LINK_NOT_ALLOWED")] CyclicLinkNotAllowed = 4,
        /// <summary>
        /// Managed accounts has the maximum number of linked accounts.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_HAS_TOO_MANY_ACCOUNTS")] CustomerHasTooManyAccounts = 5,
        /// <summary>
        /// Invitor has the maximum pending invitations.
        /// </summary>
        [pbr::OriginalName("CLIENT_HAS_TOO_MANY_INVITATIONS")] ClientHasTooManyInvitations = 6,
        /// <summary>
        /// Attempt to change hidden status of a link that is not active.
        /// </summary>
        [pbr::OriginalName("CANNOT_HIDE_OR_UNHIDE_MANAGER_ACCOUNTS")] CannotHideOrUnhideManagerAccounts = 7,
        /// <summary>
        /// Parent manager account has the maximum number of linked accounts.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_HAS_TOO_MANY_ACCOUNTS_AT_MANAGER")] CustomerHasTooManyAccountsAtManager = 8,
        /// <summary>
        /// Client has too many managers.
        /// </summary>
        [pbr::OriginalName("CLIENT_HAS_TOO_MANY_MANAGERS")] ClientHasTooManyManagers = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
