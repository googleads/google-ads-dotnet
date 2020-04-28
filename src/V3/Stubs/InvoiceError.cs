// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/invoice_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/invoice_error.proto</summary>
  public static partial class InvoiceErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/invoice_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static InvoiceErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvaW52b2ljZV9lcnJv",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZXJyb3JzGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvInMKEEludm9pY2VFcnJvckVudW0i",
            "XwoMSW52b2ljZUVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EhYKEllFQVJfTU9OVEhfVE9PX09MRBACEhkKFU5PVF9JTlZPSUNFRF9DVVNU",
            "T01FUhADQuwBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZXJyb3Jz",
            "QhFJbnZvaWNlRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZXJyb3JzO2Vycm9y",
            "c6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVycm9yc8oCHkdv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVycm9yc+oCIkdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYzOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.InvoiceErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.InvoiceErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.InvoiceErrorEnum.Types.InvoiceError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible invoice errors.
  /// </summary>
  public sealed partial class InvoiceErrorEnum : pb::IMessage<InvoiceErrorEnum> {
    private static readonly pb::MessageParser<InvoiceErrorEnum> _parser = new pb::MessageParser<InvoiceErrorEnum>(() => new InvoiceErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InvoiceErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.InvoiceErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvoiceErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvoiceErrorEnum(InvoiceErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InvoiceErrorEnum Clone() {
      return new InvoiceErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InvoiceErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InvoiceErrorEnum other) {
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
    public void MergeFrom(InvoiceErrorEnum other) {
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
    /// <summary>Container for nested types declared in the InvoiceErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible invoice errors.
      /// </summary>
      public enum InvoiceError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot request invoices issued before 2019-01-01.
        /// </summary>
        [pbr::OriginalName("YEAR_MONTH_TOO_OLD")] YearMonthTooOld = 2,
        /// <summary>
        /// Cannot request invoices for customer who doesn't receive invoices.
        /// </summary>
        [pbr::OriginalName("NOT_INVOICED_CUSTOMER")] NotInvoicedCustomer = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
