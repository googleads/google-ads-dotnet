// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/local_services_lead_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/local_services_lead_status.proto</summary>
  public static partial class LocalServicesLeadStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/local_services_lead_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalServicesLeadStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvbG9jYWxfc2Vydmlj",
            "ZXNfbGVhZF9zdGF0dXMucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "MC5lbnVtcyK6AQobTG9jYWxTZXJ2aWNlc0xlYWRTdGF0dXNFbnVtIpoBCgpM",
            "ZWFkU3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgcKA05F",
            "VxACEgoKBkFDVElWRRADEgoKBkJPT0tFRBAEEgwKCERFQ0xJTkVEEAUSCwoH",
            "RVhQSVJFRBAGEgwKCERJU0FCTEVEEAcSFQoRQ09OU1VNRVJfREVDTElORUQQ",
            "CBINCglXSVBFRF9PVVQQCUL2AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYyMC5lbnVtc0IcTG9jYWxTZXJ2aWNlc0xlYWRTdGF0dXNQcm90b1ABWkNn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjIwL2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjIwLkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjIwXEVu",
            "dW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjIwOjpFbnVtc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.LocalServicesLeadStatusEnum), global::Google.Ads.GoogleAds.V20.Enums.LocalServicesLeadStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.LocalServicesLeadStatusEnum.Types.LeadStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of lead.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LocalServicesLeadStatusEnum : pb::IMessage<LocalServicesLeadStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalServicesLeadStatusEnum> _parser = new pb::MessageParser<LocalServicesLeadStatusEnum>(() => new LocalServicesLeadStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalServicesLeadStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.LocalServicesLeadStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadStatusEnum(LocalServicesLeadStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadStatusEnum Clone() {
      return new LocalServicesLeadStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalServicesLeadStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalServicesLeadStatusEnum other) {
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
    public void MergeFrom(LocalServicesLeadStatusEnum other) {
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
    /// <summary>Container for nested types declared in the LocalServicesLeadStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible statuses of lead.
      /// </summary>
      public enum LeadStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// New lead which hasn't yet been seen by advertiser.
        /// </summary>
        [pbr::OriginalName("NEW")] New = 2,
        /// <summary>
        /// Lead that thas been interacted by advertiser.
        /// </summary>
        [pbr::OriginalName("ACTIVE")] Active = 3,
        /// <summary>
        /// Lead has been booked.
        /// </summary>
        [pbr::OriginalName("BOOKED")] Booked = 4,
        /// <summary>
        /// Lead was declined by advertiser.
        /// </summary>
        [pbr::OriginalName("DECLINED")] Declined = 5,
        /// <summary>
        /// Lead has expired due to inactivity.
        /// </summary>
        [pbr::OriginalName("EXPIRED")] Expired = 6,
        /// <summary>
        /// Disabled due to spam or dispute.
        /// </summary>
        [pbr::OriginalName("DISABLED")] Disabled = 7,
        /// <summary>
        /// Consumer declined the lead.
        /// </summary>
        [pbr::OriginalName("CONSUMER_DECLINED")] ConsumerDeclined = 8,
        /// <summary>
        /// Personally Identifiable Information of the lead is wiped out.
        /// </summary>
        [pbr::OriginalName("WIPED_OUT")] WipedOut = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
