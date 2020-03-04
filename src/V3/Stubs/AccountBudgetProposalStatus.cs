// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/account_budget_proposal_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/account_budget_proposal_status.proto</summary>
  public static partial class AccountBudgetProposalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/account_budget_proposal_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccountBudgetProposalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9hY2NvdW50X2J1ZGdl",
            "dF9wcm9wb3NhbF9zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYzLmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqoBCh9B",
            "Y2NvdW50QnVkZ2V0UHJvcG9zYWxTdGF0dXNFbnVtIoYBChtBY2NvdW50QnVk",
            "Z2V0UHJvcG9zYWxTdGF0dXMSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESCwoHUEVORElORxACEhEKDUFQUFJPVkVEX0hFTEQQAxIMCghBUFBST1ZF",
            "RBAEEg0KCUNBTkNFTExFRBAFEgwKCFJFSkVDVEVEEAZC9QEKIWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IgQWNjb3VudEJ1ZGdldFByb3Bv",
            "c2FsU3RhdHVzUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.AccountBudgetProposalStatusEnum), global::Google.Ads.GoogleAds.V3.Enums.AccountBudgetProposalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.AccountBudgetProposalStatusEnum.Types.AccountBudgetProposalStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing AccountBudgetProposal statuses.
  /// </summary>
  public sealed partial class AccountBudgetProposalStatusEnum : pb::IMessage<AccountBudgetProposalStatusEnum> {
    private static readonly pb::MessageParser<AccountBudgetProposalStatusEnum> _parser = new pb::MessageParser<AccountBudgetProposalStatusEnum>(() => new AccountBudgetProposalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccountBudgetProposalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.AccountBudgetProposalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountBudgetProposalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountBudgetProposalStatusEnum(AccountBudgetProposalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccountBudgetProposalStatusEnum Clone() {
      return new AccountBudgetProposalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccountBudgetProposalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccountBudgetProposalStatusEnum other) {
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
    public void MergeFrom(AccountBudgetProposalStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AccountBudgetProposalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible statuses of an AccountBudgetProposal.
      /// </summary>
      public enum AccountBudgetProposalStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The proposal is pending approval.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 2,
        /// <summary>
        /// The proposal has been approved but the corresponding billing setup
        /// has not.  This can occur for proposals that set up the first budget
        /// when signing up for billing or when performing a change of bill-to
        /// operation.
        /// </summary>
        [pbr::OriginalName("APPROVED_HELD")] ApprovedHeld = 3,
        /// <summary>
        /// The proposal has been approved.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 4,
        /// <summary>
        /// The proposal has been cancelled by the user.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 5,
        /// <summary>
        /// The proposal has been rejected by the user, e.g. by rejecting an
        /// acceptance email.
        /// </summary>
        [pbr::OriginalName("REJECTED")] Rejected = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
