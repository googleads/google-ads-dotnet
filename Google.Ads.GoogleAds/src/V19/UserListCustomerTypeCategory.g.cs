// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/user_list_customer_type_category.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/user_list_customer_type_category.proto</summary>
  public static partial class UserListCustomerTypeCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/user_list_customer_type_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListCustomerTypeCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvdXNlcl9saXN0X2N1",
            "c3RvbWVyX3R5cGVfY2F0ZWdvcnkucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxOS5lbnVtcyLnAwogVXNlckxpc3RDdXN0b21lclR5cGVDYXRlZ29y",
            "eUVudW0iwgMKHFVzZXJMaXN0Q3VzdG9tZXJUeXBlQ2F0ZWdvcnkSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoNQUxMX0NVU1RPTUVSUxACEg4K",
            "ClBVUkNIQVNFUlMQAxIYChRISUdIX1ZBTFVFX0NVU1RPTUVSUxAEEhgKFERJ",
            "U0VOR0FHRURfQ1VTVE9NRVJTEAUSEwoPUVVBTElGSUVEX0xFQURTEAYSEwoP",
            "Q09OVkVSVEVEX0xFQURTEAcSFAoQUEFJRF9TVUJTQ1JJQkVSUxAIEhQKEExP",
            "WUFMVFlfU0lHTl9VUFMQCRITCg9DQVJUX0FCQU5ET05FUlMQChIaChZMT1lB",
            "TFRZX1RJRVJfMV9NRU1CRVJTEAsSGgoWTE9ZQUxUWV9USUVSXzJfTUVNQkVS",
            "UxAMEhoKFkxPWUFMVFlfVElFUl8zX01FTUJFUlMQDRIaChZMT1lBTFRZX1RJ",
            "RVJfNF9NRU1CRVJTEA4SGgoWTE9ZQUxUWV9USUVSXzVfTUVNQkVSUxAPEhoK",
            "FkxPWUFMVFlfVElFUl82X01FTUJFUlMQEBIaChZMT1lBTFRZX1RJRVJfN19N",
            "RU1CRVJTEBFC+wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZW51",
            "bXNCIVVzZXJMaXN0Q3VzdG9tZXJUeXBlQ2F0ZWdvcnlQcm90b1ABWkNnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjE5L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjE5LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE5XEVudW1z",
            "6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE5OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.UserListCustomerTypeCategoryEnum), global::Google.Ads.GoogleAds.V19.Enums.UserListCustomerTypeCategoryEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The user list customer type categories.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserListCustomerTypeCategoryEnum : pb::IMessage<UserListCustomerTypeCategoryEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserListCustomerTypeCategoryEnum> _parser = new pb::MessageParser<UserListCustomerTypeCategoryEnum>(() => new UserListCustomerTypeCategoryEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserListCustomerTypeCategoryEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.UserListCustomerTypeCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerTypeCategoryEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerTypeCategoryEnum(UserListCustomerTypeCategoryEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerTypeCategoryEnum Clone() {
      return new UserListCustomerTypeCategoryEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserListCustomerTypeCategoryEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserListCustomerTypeCategoryEnum other) {
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
    public void MergeFrom(UserListCustomerTypeCategoryEnum other) {
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
    /// <summary>Container for nested types declared in the UserListCustomerTypeCategoryEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum containing possible user list customer type categories.
      /// </summary>
      public enum UserListCustomerTypeCategory {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Unknown type.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Customer type category for all customers.
        /// </summary>
        [pbr::OriginalName("ALL_CUSTOMERS")] AllCustomers = 2,
        /// <summary>
        /// Customer type category for all purchasers.
        /// </summary>
        [pbr::OriginalName("PURCHASERS")] Purchasers = 3,
        /// <summary>
        /// Customer type category for high value purchasers.
        /// </summary>
        [pbr::OriginalName("HIGH_VALUE_CUSTOMERS")] HighValueCustomers = 4,
        /// <summary>
        /// Customer type category for disengaged purchasers.
        /// </summary>
        [pbr::OriginalName("DISENGAGED_CUSTOMERS")] DisengagedCustomers = 5,
        /// <summary>
        /// Customer type category for qualified leads.
        /// </summary>
        [pbr::OriginalName("QUALIFIED_LEADS")] QualifiedLeads = 6,
        /// <summary>
        /// Customer type category for converted leads.
        /// </summary>
        [pbr::OriginalName("CONVERTED_LEADS")] ConvertedLeads = 7,
        /// <summary>
        /// Customer type category for paid subscribers.
        /// </summary>
        [pbr::OriginalName("PAID_SUBSCRIBERS")] PaidSubscribers = 8,
        /// <summary>
        /// Customer type category for loyalty signups.
        /// </summary>
        [pbr::OriginalName("LOYALTY_SIGN_UPS")] LoyaltySignUps = 9,
        /// <summary>
        /// Customer type category for cart abandoners.
        /// </summary>
        [pbr::OriginalName("CART_ABANDONERS")] CartAbandoners = 10,
        /// <summary>
        /// Customer type category for loyalty tier 1 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_1_MEMBERS")] LoyaltyTier1Members = 11,
        /// <summary>
        /// Customer type category for loyalty tier 2 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_2_MEMBERS")] LoyaltyTier2Members = 12,
        /// <summary>
        /// Customer type category for loyalty tier 3 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_3_MEMBERS")] LoyaltyTier3Members = 13,
        /// <summary>
        /// Customer type category for loyalty tier 4 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_4_MEMBERS")] LoyaltyTier4Members = 14,
        /// <summary>
        /// Customer type category for loyalty tier 5 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_5_MEMBERS")] LoyaltyTier5Members = 15,
        /// <summary>
        /// Customer type category for loyalty tier 6 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_6_MEMBERS")] LoyaltyTier6Members = 16,
        /// <summary>
        /// Customer type category for loyalty tier 7 members.
        /// </summary>
        [pbr::OriginalName("LOYALTY_TIER_7_MEMBERS")] LoyaltyTier7Members = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
