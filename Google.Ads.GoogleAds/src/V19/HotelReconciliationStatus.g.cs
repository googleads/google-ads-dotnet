// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/hotel_reconciliation_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/hotel_reconciliation_status.proto</summary>
  public static partial class HotelReconciliationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/hotel_reconciliation_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static HotelReconciliationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvaG90ZWxfcmVjb25j",
            "aWxpYXRpb25fc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTkuZW51bXMirQEKHUhvdGVsUmVjb25jaWxpYXRpb25TdGF0dXNFbnVtIosB",
            "ChlIb3RlbFJlY29uY2lsaWF0aW9uU3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEhcKE1JFU0VSVkFUSU9OX0VOQUJMRUQQAhIZChVSRUNP",
            "TkNJTElBVElPTl9ORUVERUQQAxIOCgpSRUNPTkNJTEVEEAQSDAoIQ0FOQ0VM",
            "RUQQBUL4AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lbnVtc0Ie",
            "SG90ZWxSZWNvbmNpbGlhdGlvblN0YXR1c1Byb3RvUAFaQ2dvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTkv",
            "ZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTku",
            "RW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTlcRW51bXPqAiJHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMTk6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.HotelReconciliationStatusEnum), global::Google.Ads.GoogleAds.V19.Enums.HotelReconciliationStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.HotelReconciliationStatusEnum.Types.HotelReconciliationStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for HotelReconciliationStatus.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class HotelReconciliationStatusEnum : pb::IMessage<HotelReconciliationStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<HotelReconciliationStatusEnum> _parser = new pb::MessageParser<HotelReconciliationStatusEnum>(() => new HotelReconciliationStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<HotelReconciliationStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.HotelReconciliationStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliationStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliationStatusEnum(HotelReconciliationStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public HotelReconciliationStatusEnum Clone() {
      return new HotelReconciliationStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as HotelReconciliationStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(HotelReconciliationStatusEnum other) {
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
    public void MergeFrom(HotelReconciliationStatusEnum other) {
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
    /// <summary>Container for nested types declared in the HotelReconciliationStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Status of the hotel booking reconciliation.
      /// </summary>
      public enum HotelReconciliationStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Bookings are for a future date, or a stay is underway but the check-out
        /// date hasn't passed. An active reservation can't be reconciled.
        /// </summary>
        [pbr::OriginalName("RESERVATION_ENABLED")] ReservationEnabled = 2,
        /// <summary>
        /// Check-out has already taken place, or the booked dates have passed
        /// without cancellation. Bookings that are not reconciled within 45 days of
        /// the check-out date are billed based on the original booking price.
        /// </summary>
        [pbr::OriginalName("RECONCILIATION_NEEDED")] ReconciliationNeeded = 3,
        /// <summary>
        /// These bookings have been reconciled. Reconciled bookings are billed 45
        /// days after the check-out date.
        /// </summary>
        [pbr::OriginalName("RECONCILED")] Reconciled = 4,
        /// <summary>
        /// This booking was marked as canceled. Canceled stays with a value greater
        /// than zero (due to minimum stay rules or cancellation fees) are billed 45
        /// days after the check-out date.
        /// </summary>
        [pbr::OriginalName("CANCELED")] Canceled = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
