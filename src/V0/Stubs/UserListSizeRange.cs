// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/user_list_size_range.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/user_list_size_range.proto</summary>
  public static partial class UserListSizeRangeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/user_list_size_range.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListSizeRangeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy91c2VyX2xpc3Rfc2l6",
            "ZV9yYW5nZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXMa",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ilAUKFVVzZXJMaXN0U2l6",
            "ZVJhbmdlRW51bSL6BAoRVXNlckxpc3RTaXplUmFuZ2USDwoLVU5TUEVDSUZJ",
            "RUQQABILCgdVTktOT1dOEAESGgoWTEVTU19USEFOX0ZJVkVfSFVORFJFRBAC",
            "EhoKFkxFU1NfVEhBTl9PTkVfVEhPVVNBTkQQAxIgChxPTkVfVEhPVVNBTkRf",
            "VE9fVEVOX1RIT1VTQU5EEAQSIgoeVEVOX1RIT1VTQU5EX1RPX0ZJRlRZX1RI",
            "T1VTQU5EEAUSKgomRklGVFlfVEhPVVNBTkRfVE9fT05FX0hVTkRSRURfVEhP",
            "VVNBTkQQBhIyCi5PTkVfSFVORFJFRF9USE9VU0FORF9UT19USFJFRV9IVU5E",
            "UkVEX1RIT1VTQU5EEAcSMwovVEhSRUVfSFVORFJFRF9USE9VU0FORF9UT19G",
            "SVZFX0hVTkRSRURfVEhPVVNBTkQQCBIoCiRGSVZFX0hVTkRSRURfVEhPVVNB",
            "TkRfVE9fT05FX01JTExJT04QCRIeChpPTkVfTUlMTElPTl9UT19UV09fTUlM",
            "TElPThAKEiAKHFRXT19NSUxMSU9OX1RPX1RIUkVFX01JTExJT04QCxIhCh1U",
            "SFJFRV9NSUxMSU9OX1RPX0ZJVkVfTUlMTElPThAMEh8KG0ZJVkVfTUlMTElP",
            "Tl9UT19URU5fTUlMTElPThANEiEKHVRFTl9NSUxMSU9OX1RPX1RXRU5UWV9N",
            "SUxMSU9OEA4SJAogVFdFTlRZX01JTExJT05fVE9fVEhJUlRZX01JTExJT04Q",
            "DxIjCh9USElSVFlfTUlMTElPTl9UT19GSUZUWV9NSUxMSU9OEBASFgoST1ZF",
            "Ul9GSUZUWV9NSUxMSU9OEBFC6wEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MC5lbnVtc0IWVXNlckxpc3RTaXplUmFuZ2VQcm90b1ABWkJnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMv",
            "djAvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MC5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1z6gIhR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListSizeRangeEnum), global::Google.Ads.GoogleAds.V0.Enums.UserListSizeRangeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.UserListSizeRangeEnum.Types.UserListSizeRange) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Size range in terms of number of users of a UserList.
  /// </summary>
  public sealed partial class UserListSizeRangeEnum : pb::IMessage<UserListSizeRangeEnum> {
    private static readonly pb::MessageParser<UserListSizeRangeEnum> _parser = new pb::MessageParser<UserListSizeRangeEnum>(() => new UserListSizeRangeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserListSizeRangeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.UserListSizeRangeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListSizeRangeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListSizeRangeEnum(UserListSizeRangeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserListSizeRangeEnum Clone() {
      return new UserListSizeRangeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserListSizeRangeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserListSizeRangeEnum other) {
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
    public void MergeFrom(UserListSizeRangeEnum other) {
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
    /// <summary>Container for nested types declared in the UserListSizeRangeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum containing possible user list size ranges.
      /// </summary>
      public enum UserListSizeRange {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// User list has less than 500 users.
        /// </summary>
        [pbr::OriginalName("LESS_THAN_FIVE_HUNDRED")] LessThanFiveHundred = 2,
        /// <summary>
        /// User list has number of users in range of 500 to 1000.
        /// </summary>
        [pbr::OriginalName("LESS_THAN_ONE_THOUSAND")] LessThanOneThousand = 3,
        /// <summary>
        /// User list has number of users in range of 1000 to 10000.
        /// </summary>
        [pbr::OriginalName("ONE_THOUSAND_TO_TEN_THOUSAND")] OneThousandToTenThousand = 4,
        /// <summary>
        /// User list has number of users in range of 10000 to 50000.
        /// </summary>
        [pbr::OriginalName("TEN_THOUSAND_TO_FIFTY_THOUSAND")] TenThousandToFiftyThousand = 5,
        /// <summary>
        /// User list has number of users in range of 50000 to 100000.
        /// </summary>
        [pbr::OriginalName("FIFTY_THOUSAND_TO_ONE_HUNDRED_THOUSAND")] FiftyThousandToOneHundredThousand = 6,
        /// <summary>
        /// User list has number of users in range of 100000 to 300000.
        /// </summary>
        [pbr::OriginalName("ONE_HUNDRED_THOUSAND_TO_THREE_HUNDRED_THOUSAND")] OneHundredThousandToThreeHundredThousand = 7,
        /// <summary>
        /// User list has number of users in range of 300000 to 500000.
        /// </summary>
        [pbr::OriginalName("THREE_HUNDRED_THOUSAND_TO_FIVE_HUNDRED_THOUSAND")] ThreeHundredThousandToFiveHundredThousand = 8,
        /// <summary>
        /// User list has number of users in range of 500000 to 1 million.
        /// </summary>
        [pbr::OriginalName("FIVE_HUNDRED_THOUSAND_TO_ONE_MILLION")] FiveHundredThousandToOneMillion = 9,
        /// <summary>
        /// User list has number of users in range of 1 to 2 millions.
        /// </summary>
        [pbr::OriginalName("ONE_MILLION_TO_TWO_MILLION")] OneMillionToTwoMillion = 10,
        /// <summary>
        /// User list has number of users in range of 2 to 3 millions.
        /// </summary>
        [pbr::OriginalName("TWO_MILLION_TO_THREE_MILLION")] TwoMillionToThreeMillion = 11,
        /// <summary>
        /// User list has number of users in range of 3 to 5 millions.
        /// </summary>
        [pbr::OriginalName("THREE_MILLION_TO_FIVE_MILLION")] ThreeMillionToFiveMillion = 12,
        /// <summary>
        /// User list has number of users in range of 5 to 10 millions.
        /// </summary>
        [pbr::OriginalName("FIVE_MILLION_TO_TEN_MILLION")] FiveMillionToTenMillion = 13,
        /// <summary>
        /// User list has number of users in range of 10 to 20 millions.
        /// </summary>
        [pbr::OriginalName("TEN_MILLION_TO_TWENTY_MILLION")] TenMillionToTwentyMillion = 14,
        /// <summary>
        /// User list has number of users in range of 20 to 30 millions.
        /// </summary>
        [pbr::OriginalName("TWENTY_MILLION_TO_THIRTY_MILLION")] TwentyMillionToThirtyMillion = 15,
        /// <summary>
        /// User list has number of users in range of 30 to 50 millions.
        /// </summary>
        [pbr::OriginalName("THIRTY_MILLION_TO_FIFTY_MILLION")] ThirtyMillionToFiftyMillion = 16,
        /// <summary>
        /// User list has over 50 million users.
        /// </summary>
        [pbr::OriginalName("OVER_FIFTY_MILLION")] OverFiftyMillion = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
