// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/payment_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/payment_mode.proto</summary>
  public static partial class PaymentModeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/payment_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9wYXltZW50X21vZGUu",
            "cHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvInEKD1BheW1lbnRNb2RlRW51bSJeCgtQ",
            "YXltZW50TW9kZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIKCgZD",
            "TElDS1MQBBIUChBDT05WRVJTSU9OX1ZBTFVFEAUSDwoLQ09OVkVSU0lPTlMQ",
            "BkLlAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zQhBQYXlt",
            "ZW50TW9kZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcztlbnVtc6ICA0dBQaoC",
            "HUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVudW1zygIdR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjJcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.PaymentModeEnum), global::Google.Ads.GoogleAds.V2.Enums.PaymentModeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.PaymentModeEnum.Types.PaymentMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible payment modes.
  /// </summary>
  public sealed partial class PaymentModeEnum : pb::IMessage<PaymentModeEnum> {
    private static readonly pb::MessageParser<PaymentModeEnum> _parser = new pb::MessageParser<PaymentModeEnum>(() => new PaymentModeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PaymentModeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.PaymentModeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentModeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentModeEnum(PaymentModeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaymentModeEnum Clone() {
      return new PaymentModeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PaymentModeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PaymentModeEnum other) {
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
    public void MergeFrom(PaymentModeEnum other) {
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
    /// <summary>Container for nested types declared in the PaymentModeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible payment modes.
      /// </summary>
      public enum PaymentMode {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Pay per click.
        /// </summary>
        [pbr::OriginalName("CLICKS")] Clicks = 4,
        /// <summary>
        /// Pay per conversion value. This mode is only supported by campaigns with
        /// AdvertisingChannelType.HOTEL, BiddingStrategyType.COMMISSION, and
        /// BudgetType.HOTEL_ADS_COMMISSION.
        /// </summary>
        [pbr::OriginalName("CONVERSION_VALUE")] ConversionValue = 5,
        /// <summary>
        /// Pay per conversion. This mode is only supported by campaigns with
        /// AdvertisingChannelType.DISPLAY (excluding
        /// AdvertisingChannelSubType.DISPLAY_GMAIL), BiddingStrategyType.TARGET_CPA,
        /// and BudgetType.FIXED_CPA. The customer must also be eligible for this
        /// mode. See Customer.eligibility_failure_reasons for details.
        /// </summary>
        [pbr::OriginalName("CONVERSIONS")] Conversions = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
