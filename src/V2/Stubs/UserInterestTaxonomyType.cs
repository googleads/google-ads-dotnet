// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/user_interest_taxonomy_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/user_interest_taxonomy_type.proto</summary>
  public static partial class UserInterestTaxonomyTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/user_interest_taxonomy_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserInterestTaxonomyTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy91c2VyX2ludGVyZXN0",
            "X3RheG9ub215X3R5cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIr8BChxVc2Vy",
            "SW50ZXJlc3RUYXhvbm9teVR5cGVFbnVtIp4BChhVc2VySW50ZXJlc3RUYXhv",
            "bm9teVR5cGUSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIQUZG",
            "SU5JVFkQAhINCglJTl9NQVJLRVQQAxIbChdNT0JJTEVfQVBQX0lOU1RBTExf",
            "VVNFUhAEEhAKDFZFUlRJQ0FMX0dFTxAFEhgKFE5FV19TTUFSVF9QSE9ORV9V",
            "U0VSEAZC8gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtc0Id",
            "VXNlckludGVyZXN0VGF4b25vbXlUeXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2Vu",
            "dW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51",
            "bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.UserInterestTaxonomyTypeEnum), global::Google.Ads.GoogleAds.V2.Enums.UserInterestTaxonomyTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.UserInterestTaxonomyTypeEnum.Types.UserInterestTaxonomyType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing a UserInterestTaxonomyType.
  /// </summary>
  public sealed partial class UserInterestTaxonomyTypeEnum : pb::IMessage<UserInterestTaxonomyTypeEnum> {
    private static readonly pb::MessageParser<UserInterestTaxonomyTypeEnum> _parser = new pb::MessageParser<UserInterestTaxonomyTypeEnum>(() => new UserInterestTaxonomyTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserInterestTaxonomyTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.UserInterestTaxonomyTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInterestTaxonomyTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInterestTaxonomyTypeEnum(UserInterestTaxonomyTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserInterestTaxonomyTypeEnum Clone() {
      return new UserInterestTaxonomyTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserInterestTaxonomyTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserInterestTaxonomyTypeEnum other) {
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
    public void MergeFrom(UserInterestTaxonomyTypeEnum other) {
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
    /// <summary>Container for nested types declared in the UserInterestTaxonomyTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum containing the possible UserInterestTaxonomyTypes.
      /// </summary>
      public enum UserInterestTaxonomyType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The affinity for this user interest.
        /// </summary>
        [pbr::OriginalName("AFFINITY")] Affinity = 2,
        /// <summary>
        /// The market for this user interest.
        /// </summary>
        [pbr::OriginalName("IN_MARKET")] InMarket = 3,
        /// <summary>
        /// Users known to have installed applications in the specified categories.
        /// </summary>
        [pbr::OriginalName("MOBILE_APP_INSTALL_USER")] MobileAppInstallUser = 4,
        /// <summary>
        /// The geographical location of the interest-based vertical.
        /// </summary>
        [pbr::OriginalName("VERTICAL_GEO")] VerticalGeo = 5,
        /// <summary>
        /// User interest criteria for new smart phone users.
        /// </summary>
        [pbr::OriginalName("NEW_SMART_PHONE_USER")] NewSmartPhoneUser = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
