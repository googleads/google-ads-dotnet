// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/manager_link_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/manager_link_error.proto</summary>
  public static partial class ManagerLinkErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/manager_link_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ManagerLinkErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvbWFuYWdlcl9saW5r",
            "X2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lcnJvcnMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i/QMKFE1hbmFnZXJMaW5r",
            "RXJyb3JFbnVtIuQDChBNYW5hZ2VyTGlua0Vycm9yEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEicKI0FDQ09VTlRTX05PVF9DT01QQVRJQkxFX0ZP",
            "Ul9MSU5LSU5HEAISFQoRVE9PX01BTllfTUFOQUdFUlMQAxIUChBUT09fTUFO",
            "WV9JTlZJVEVTEAQSIwofQUxSRUFEWV9JTlZJVEVEX0JZX1RISVNfTUFOQUdF",
            "UhAFEiMKH0FMUkVBRFlfTUFOQUdFRF9CWV9USElTX01BTkFHRVIQBhIgChxB",
            "TFJFQURZX01BTkFHRURfSU5fSElFUkFSQ0hZEAcSGQoVRFVQTElDQVRFX0NI",
            "SUxEX0ZPVU5EEAgSHAoYQ0xJRU5UX0hBU19OT19BRE1JTl9VU0VSEAkSFgoS",
            "TUFYX0RFUFRIX0VYQ0VFREVEEAoSFQoRQ1lDTEVfTk9UX0FMTE9XRUQQCxIV",
            "ChFUT09fTUFOWV9BQ0NPVU5UUxAMEiAKHFRPT19NQU5ZX0FDQ09VTlRTX0FU",
            "X01BTkFHRVIQDRIlCiFOT05fT1dORVJfVVNFUl9DQU5OT1RfTU9ESUZZX0xJ",
            "TksQDhIoCiRTVVNQRU5ERURfQUNDT1VOVF9DQU5OT1RfQUREX0NMSUVOVFMQ",
            "D0LwAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9yc0IVTWFu",
            "YWdlckxpbmtFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnM7ZXJyb3Jz",
            "ogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRXJyb3JzygIeR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjFcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.ManagerLinkErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.ManagerLinkErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.ManagerLinkErrorEnum.Types.ManagerLinkError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible ManagerLink errors.
  /// </summary>
  public sealed partial class ManagerLinkErrorEnum : pb::IMessage<ManagerLinkErrorEnum> {
    private static readonly pb::MessageParser<ManagerLinkErrorEnum> _parser = new pb::MessageParser<ManagerLinkErrorEnum>(() => new ManagerLinkErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ManagerLinkErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.ManagerLinkErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ManagerLinkErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ManagerLinkErrorEnum(ManagerLinkErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ManagerLinkErrorEnum Clone() {
      return new ManagerLinkErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ManagerLinkErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ManagerLinkErrorEnum other) {
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
    public void MergeFrom(ManagerLinkErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ManagerLinkErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible ManagerLink errors.
      /// </summary>
      public enum ManagerLinkError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The manager and client have incompatible account types.
        /// </summary>
        [pbr::OriginalName("ACCOUNTS_NOT_COMPATIBLE_FOR_LINKING")] AccountsNotCompatibleForLinking = 2,
        /// <summary>
        /// Client is already linked to too many managers.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_MANAGERS")] TooManyManagers = 3,
        /// <summary>
        /// Manager has too many pending invitations.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_INVITES")] TooManyInvites = 4,
        /// <summary>
        /// Client is already invited by this manager.
        /// </summary>
        [pbr::OriginalName("ALREADY_INVITED_BY_THIS_MANAGER")] AlreadyInvitedByThisManager = 5,
        /// <summary>
        /// The client is already managed by this manager.
        /// </summary>
        [pbr::OriginalName("ALREADY_MANAGED_BY_THIS_MANAGER")] AlreadyManagedByThisManager = 6,
        /// <summary>
        /// Client is already managed in hierarchy.
        /// </summary>
        [pbr::OriginalName("ALREADY_MANAGED_IN_HIERARCHY")] AlreadyManagedInHierarchy = 7,
        /// <summary>
        /// Manger and sub-manager to be linked have duplicate client.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_CHILD_FOUND")] DuplicateChildFound = 8,
        /// <summary>
        /// Client has no active user that can access the client account.
        /// </summary>
        [pbr::OriginalName("CLIENT_HAS_NO_ADMIN_USER")] ClientHasNoAdminUser = 9,
        /// <summary>
        /// Adding this link would exceed the maximum hierarchy depth.
        /// </summary>
        [pbr::OriginalName("MAX_DEPTH_EXCEEDED")] MaxDepthExceeded = 10,
        /// <summary>
        /// Adding this link will create a cycle.
        /// </summary>
        [pbr::OriginalName("CYCLE_NOT_ALLOWED")] CycleNotAllowed = 11,
        /// <summary>
        /// Manager account has the maximum number of linked clients.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ACCOUNTS")] TooManyAccounts = 12,
        /// <summary>
        /// Parent manager account has the maximum number of linked clients.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_ACCOUNTS_AT_MANAGER")] TooManyAccountsAtManager = 13,
        /// <summary>
        /// The account is not authorized owner.
        /// </summary>
        [pbr::OriginalName("NON_OWNER_USER_CANNOT_MODIFY_LINK")] NonOwnerUserCannotModifyLink = 14,
        /// <summary>
        /// Your manager account is suspended, and you are no longer allowed to link
        /// to clients.
        /// </summary>
        [pbr::OriginalName("SUSPENDED_ACCOUNT_CANNOT_ADD_CLIENTS")] SuspendedAccountCannotAddClients = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
