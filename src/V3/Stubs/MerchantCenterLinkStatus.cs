// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/merchant_center_link_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/merchant_center_link_status.proto</summary>
  public static partial class MerchantCenterLinkStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/merchant_center_link_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MerchantCenterLinkStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9tZXJjaGFudF9jZW50",
            "ZXJfbGlua19zdGF0dXMucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LmVudW1zGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvInIKHE1lcmNo",
            "YW50Q2VudGVyTGlua1N0YXR1c0VudW0iUgoYTWVyY2hhbnRDZW50ZXJMaW5r",
            "U3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB0VOQUJM",
            "RUQQAhILCgdQRU5ESU5HEANC8gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52My5lbnVtc0IdTWVyY2hhbnRDZW50ZXJMaW5rU3RhdHVzUHJvdG9QAVpC",
            "Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29v",
            "Z2xlYWRzL3YzL2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjMuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWM1xFbnVt",
            "c+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.MerchantCenterLinkStatusEnum), global::Google.Ads.GoogleAds.V3.Enums.MerchantCenterLinkStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of a Google Merchant Center
  /// link.
  /// </summary>
  public sealed partial class MerchantCenterLinkStatusEnum : pb::IMessage<MerchantCenterLinkStatusEnum> {
    private static readonly pb::MessageParser<MerchantCenterLinkStatusEnum> _parser = new pb::MessageParser<MerchantCenterLinkStatusEnum>(() => new MerchantCenterLinkStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantCenterLinkStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.MerchantCenterLinkStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLinkStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLinkStatusEnum(MerchantCenterLinkStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLinkStatusEnum Clone() {
      return new MerchantCenterLinkStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantCenterLinkStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantCenterLinkStatusEnum other) {
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
    public void MergeFrom(MerchantCenterLinkStatusEnum other) {
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
    /// <summary>Container for nested types declared in the MerchantCenterLinkStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Describes the possible statuses for a link between a Google Ads customer
      /// and a Google Merchant Center account.
      /// </summary>
      public enum MerchantCenterLinkStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The link is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// The link has no effect. It was proposed by the Merchant Center Account
        /// owner and hasn't been confirmed by the customer.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
