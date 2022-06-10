// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/customer_manager_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/customer_manager_link_error.proto</summary>
  public static partial class CustomerManagerLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/customer_manager_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerManagerLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2N1c3RvbWVyX21h",
            "bmFnZXJfbGlua19lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djExLmVycm9ycyLQAwocQ3VzdG9tZXJNYW5hZ2VyTGlua0Vycm9yRW51bSKv",
            "AwoYQ3VzdG9tZXJNYW5hZ2VyTGlua0Vycm9yEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEhUKEU5PX1BFTkRJTkdfSU5WSVRFEAISJwojU0FNRV9D",
            "TElFTlRfTU9SRV9USEFOX09OQ0VfUEVSX0NBTEwQAxItCilNQU5BR0VSX0hB",
            "U19NQVhfTlVNQkVSX09GX0xJTktFRF9BQ0NPVU5UUxAEEi0KKUNBTk5PVF9V",
            "TkxJTktfQUNDT1VOVF9XSVRIT1VUX0FDVElWRV9VU0VSEAUSKwonQ0FOTk9U",
            "X1JFTU9WRV9MQVNUX0NMSUVOVF9BQ0NPVU5UX09XTkVSEAYSKwonQ0FOTk9U",
            "X0NIQU5HRV9ST0xFX0JZX05PTl9BQ0NPVU5UX09XTkVSEAcSMgouQ0FOTk9U",
            "X0NIQU5HRV9ST0xFX0ZPUl9OT05fQUNUSVZFX0xJTktfQUNDT1VOVBAIEhkK",
            "FURVUExJQ0FURV9DSElMRF9GT1VORBAJEi4KKlRFU1RfQUNDT1VOVF9MSU5L",
            "U19UT09fTUFOWV9DSElMRF9BQ0NPVU5UUxAKQv0BCiNjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjExLmVycm9yc0IdQ3VzdG9tZXJNYW5hZ2VyTGlua0Vy",
            "cm9yUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxMS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIf",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjExLkVycm9yc8oCH0dvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMVxFcnJvcnPqAiNHb29nbGU6OkFkczo6R29vZ2xlQWRz",
            "OjpWMTE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.CustomerManagerLinkErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.CustomerManagerLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.CustomerManagerLinkErrorEnum.Types.CustomerManagerLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible CustomerManagerLink errors.
  /// </summary>
  public sealed partial class CustomerManagerLinkErrorEnum : pb::IMessage<CustomerManagerLinkErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerManagerLinkErrorEnum> _parser = new pb::MessageParser<CustomerManagerLinkErrorEnum>(() => new CustomerManagerLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerManagerLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.CustomerManagerLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLinkErrorEnum(CustomerManagerLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLinkErrorEnum Clone() {
      return new CustomerManagerLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerManagerLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerManagerLinkErrorEnum other) {
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
    public void MergeFrom(CustomerManagerLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CustomerManagerLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible CustomerManagerLink errors.
      /// </summary>
      public enum CustomerManagerLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// No pending invitation.
        /// </summary>
        [pbr::OriginalName("NO_PENDING_INVITE")] NoPendingInvite = 2,
        /// <summary>
        /// Attempt to operate on the same client more than once in the same call.
        /// </summary>
        [pbr::OriginalName("SAME_CLIENT_MORE_THAN_ONCE_PER_CALL")] SameClientMoreThanOncePerCall = 3,
        /// <summary>
        /// Manager account has the maximum number of linked accounts.
        /// </summary>
        [pbr::OriginalName("MANAGER_HAS_MAX_NUMBER_OF_LINKED_ACCOUNTS")] ManagerHasMaxNumberOfLinkedAccounts = 4,
        /// <summary>
        /// If no active user on account it cannot be unlinked from its manager.
        /// </summary>
        [pbr::OriginalName("CANNOT_UNLINK_ACCOUNT_WITHOUT_ACTIVE_USER")] CannotUnlinkAccountWithoutActiveUser = 5,
        /// <summary>
        /// Account should have at least one active owner on it before being
        /// unlinked.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_LAST_CLIENT_ACCOUNT_OWNER")] CannotRemoveLastClientAccountOwner = 6,
        /// <summary>
        /// Only account owners may change their permission role.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_ROLE_BY_NON_ACCOUNT_OWNER")] CannotChangeRoleByNonAccountOwner = 7,
        /// <summary>
        /// When a client's link to its manager is not active, the link role cannot
        /// be changed.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_ROLE_FOR_NON_ACTIVE_LINK_ACCOUNT")] CannotChangeRoleForNonActiveLinkAccount = 8,
        /// <summary>
        /// Attempt to link a child to a parent that contains or will contain
        /// duplicate children.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CHILD_FOUND")] DuplicateChildFound = 9,
        /// <summary>
        /// The authorized customer is a test account. It can add no more than the
        /// allowed number of accounts
        /// </summary>
        [pbr::OriginalName("TEST_ACCOUNT_LINKS_TOO_MANY_CHILD_ACCOUNTS")] TestAccountLinksTooManyChildAccounts = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
