// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/customer_pay_per_conversion_eligibility_failure_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/customer_pay_per_conversion_eligibility_failure_reason.proto</summary>
  public static partial class CustomerPayPerConversionEligibilityFailureReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/customer_pay_per_conversion_eligibility_failure_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerPayPerConversionEligibilityFailureReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clpnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9jdXN0b21lcl9wYXlf",
            "cGVyX2NvbnZlcnNpb25fZWxpZ2liaWxpdHlfZmFpbHVyZV9yZWFzb24ucHJv",
            "dG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zGhxnb29nbGUvYXBp",
            "L2Fubm90YXRpb25zLnByb3RvItECCjRDdXN0b21lclBheVBlckNvbnZlcnNp",
            "b25FbGlnaWJpbGl0eUZhaWx1cmVSZWFzb25FbnVtIpgCCjBDdXN0b21lclBh",
            "eVBlckNvbnZlcnNpb25FbGlnaWJpbGl0eUZhaWx1cmVSZWFzb24SDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESGgoWTk9UX0VOT1VHSF9DT05WRVJT",
            "SU9OUxACEhsKF0NPTlZFUlNJT05fTEFHX1RPT19ISUdIEAMSIwofSEFTX0NB",
            "TVBBSUdOX1dJVEhfU0hBUkVEX0JVREdFVBAEEiAKHEhBU19VUExPQURfQ0xJ",
            "Q0tTX0NPTlZFUlNJT04QBRIgChxBVkVSQUdFX0RBSUxZX1NQRU5EX1RPT19I",
            "SUdIEAYSGQoVQU5BTFlTSVNfTk9UX0NPTVBMRVRFEAcSCQoFT1RIRVIQCEKK",
            "AgohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zQjVDdXN0b21l",
            "clBheVBlckNvbnZlcnNpb25FbGlnaWJpbGl0eUZhaWx1cmVSZWFzb25Qcm90",
            "b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjEvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMS5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "XEVudW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OkVudW1zYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum), global::Google.Ads.GoogleAds.V1.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.CustomerPayPerConversionEligibilityFailureReasonEnum.Types.CustomerPayPerConversionEligibilityFailureReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing reasons why a customer is not eligible to use
  /// PaymentMode.CONVERSIONS.
  /// </summary>
  public sealed partial class CustomerPayPerConversionEligibilityFailureReasonEnum : pb::IMessage<CustomerPayPerConversionEligibilityFailureReasonEnum> {
    private static readonly pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum> _parser = new pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum>(() => new CustomerPayPerConversionEligibilityFailureReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerPayPerConversionEligibilityFailureReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.CustomerPayPerConversionEligibilityFailureReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerPayPerConversionEligibilityFailureReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerPayPerConversionEligibilityFailureReasonEnum(CustomerPayPerConversionEligibilityFailureReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerPayPerConversionEligibilityFailureReasonEnum Clone() {
      return new CustomerPayPerConversionEligibilityFailureReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerPayPerConversionEligibilityFailureReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerPayPerConversionEligibilityFailureReasonEnum other) {
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
    public void MergeFrom(CustomerPayPerConversionEligibilityFailureReasonEnum other) {
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
    /// <summary>Container for nested types declared in the CustomerPayPerConversionEligibilityFailureReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible reasons a customer is not eligible to use
      /// PaymentMode.CONVERSIONS.
      /// </summary>
      public enum CustomerPayPerConversionEligibilityFailureReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Customer does not have enough conversions.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_CONVERSIONS")] NotEnoughConversions = 2,
        /// <summary>
        /// Customer's conversion lag is too high.
        /// </summary>
        [pbr::OriginalName("CONVERSION_LAG_TOO_HIGH")] ConversionLagTooHigh = 3,
        /// <summary>
        /// Customer uses shared budgets.
        /// </summary>
        [pbr::OriginalName("HAS_CAMPAIGN_WITH_SHARED_BUDGET")] HasCampaignWithSharedBudget = 4,
        /// <summary>
        /// Customer has conversions with ConversionActionType.UPLOAD_CLICKS.
        /// </summary>
        [pbr::OriginalName("HAS_UPLOAD_CLICKS_CONVERSION")] HasUploadClicksConversion = 5,
        /// <summary>
        /// Customer's average daily spend is too high.
        /// </summary>
        [pbr::OriginalName("AVERAGE_DAILY_SPEND_TOO_HIGH")] AverageDailySpendTooHigh = 6,
        /// <summary>
        /// Customer's eligibility has not yet been calculated by the Google Ads
        /// backend. Check back soon.
        /// </summary>
        [pbr::OriginalName("ANALYSIS_NOT_COMPLETE")] AnalysisNotComplete = 7,
        /// <summary>
        /// Customer is not eligible due to other reasons.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
