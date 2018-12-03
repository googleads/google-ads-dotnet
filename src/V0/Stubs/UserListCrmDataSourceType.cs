// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/user_list_crm_data_source_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/user_list_crm_data_source_type.proto</summary>
  public static partial class UserListCrmDataSourceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/user_list_crm_data_source_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListCrmDataSourceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy91c2VyX2xpc3RfY3Jt",
            "X2RhdGFfc291cmNlX3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zIqcBCh1Vc2VyTGlzdENybURhdGFTb3VyY2VUeXBlRW51bSKF",
            "AQoZVXNlckxpc3RDcm1EYXRhU291cmNlVHlwZRIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIPCgtGSVJTVF9QQVJUWRACEh0KGVRISVJEX1BBUlRZ",
            "X0NSRURJVF9CVVJFQVUQAxIaChZUSElSRF9QQVJUWV9WT1RFUl9GSUxFEARC",
            "zwEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5lbnVtc0IeVXNlckxp",
            "c3RDcm1EYXRhU291cmNlVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MC9lbnVtcztl",
            "bnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYwLkVudW1zygId",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjBcRW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListCrmDataSourceTypeEnum), global::Google.Ads.GoogleAds.V0.Enums.UserListCrmDataSourceTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListCrmDataSourceTypeEnum.Types.UserListCrmDataSourceType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Indicates source of Crm upload data.
  /// </summary>
  public sealed partial class UserListCrmDataSourceTypeEnum : pb::IMessage<UserListCrmDataSourceTypeEnum> {
    private static readonly pb::MessageParser<UserListCrmDataSourceTypeEnum> _parser = new pb::MessageParser<UserListCrmDataSourceTypeEnum>(() => new UserListCrmDataSourceTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListCrmDataSourceTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.UserListCrmDataSourceTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCrmDataSourceTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCrmDataSourceTypeEnum(UserListCrmDataSourceTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListCrmDataSourceTypeEnum Clone() {
      return new UserListCrmDataSourceTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListCrmDataSourceTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListCrmDataSourceTypeEnum other) {
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
    public void MergeFrom(UserListCrmDataSourceTypeEnum other) {
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
    /// <summary>Container for nested types declared in the UserListCrmDataSourceTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible user list crm data source type.
      /// </summary>
      public enum UserListCrmDataSourceType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The uploaded data is first party data.
        /// </summary>
        [pbr::OriginalName("FIRST_PARTY")] FirstParty = 2,
        /// <summary>
        /// The uploaded data is from a third party credit bureau.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_CREDIT_BUREAU")] ThirdPartyCreditBureau = 3,
        /// <summary>
        /// The uploaded data is from a third party voter file.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_VOTER_FILE")] ThirdPartyVoterFile = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
