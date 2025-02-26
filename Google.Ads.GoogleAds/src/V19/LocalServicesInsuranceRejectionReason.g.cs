// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/local_services_insurance_rejection_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/local_services_insurance_rejection_reason.proto</summary>
  public static partial class LocalServicesInsuranceRejectionReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/local_services_insurance_rejection_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalServicesInsuranceRejectionReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ck5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvbG9jYWxfc2Vydmlj",
            "ZXNfaW5zdXJhbmNlX3JlamVjdGlvbl9yZWFzb24ucHJvdG8SHmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxOS5lbnVtcyKyAwopTG9jYWxTZXJ2aWNlc0luc3Vy",
            "YW5jZVJlamVjdGlvblJlYXNvbkVudW0ihAMKJUxvY2FsU2VydmljZXNJbnN1",
            "cmFuY2VSZWplY3Rpb25SZWFzb24SDwoLVU5TUEVDSUZJRUQQABILCgdVTktO",
            "T1dOEAESGgoWQlVTSU5FU1NfTkFNRV9NSVNNQVRDSBACEiEKHUlOU1VSQU5D",
            "RV9BTU9VTlRfSU5TVUZGSUNJRU5UEAMSCwoHRVhQSVJFRBAEEhAKDE5PX1NJ",
            "R05BVFVSRRAFEhQKEE5PX1BPTElDWV9OVU1CRVIQBhIjCh9OT19DT01NRVJD",
            "SUFMX0dFTkVSQUxfTElBQklMSVRZEAcSEwoPRURJVEFCTEVfRk9STUFUEAgS",
            "FQoRQ0FURUdPUllfTUlTTUFUQ0gQCRIbChdNSVNTSU5HX0VYUElSQVRJT05f",
            "REFURRAKEhAKDFBPT1JfUVVBTElUWRALEhYKElBPVEVOVElBTExZX0VESVRF",
            "RBAMEhcKE1dST05HX0RPQ1VNRU5UX1RZUEUQDRINCglOT05fRklOQUwQDhIJ",
            "CgVPVEhFUhAPQoQCCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5LmVu",
            "dW1zQipMb2NhbFNlcnZpY2VzSW5zdXJhbmNlUmVqZWN0aW9uUmVhc29uUHJv",
            "dG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3YxOS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYxOS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRz",
            "XFYxOVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6RW51",
            "bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.LocalServicesInsuranceRejectionReasonEnum), global::Google.Ads.GoogleAds.V19.Enums.LocalServicesInsuranceRejectionReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.LocalServicesInsuranceRejectionReasonEnum.Types.LocalServicesInsuranceRejectionReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the rejection reason of a local services
  /// insurance verification artifact.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LocalServicesInsuranceRejectionReasonEnum : pb::IMessage<LocalServicesInsuranceRejectionReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalServicesInsuranceRejectionReasonEnum> _parser = new pb::MessageParser<LocalServicesInsuranceRejectionReasonEnum>(() => new LocalServicesInsuranceRejectionReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalServicesInsuranceRejectionReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.LocalServicesInsuranceRejectionReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesInsuranceRejectionReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesInsuranceRejectionReasonEnum(LocalServicesInsuranceRejectionReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesInsuranceRejectionReasonEnum Clone() {
      return new LocalServicesInsuranceRejectionReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalServicesInsuranceRejectionReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalServicesInsuranceRejectionReasonEnum other) {
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
    public void MergeFrom(LocalServicesInsuranceRejectionReasonEnum other) {
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
    /// <summary>Container for nested types declared in the LocalServicesInsuranceRejectionReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enums describing possible rejection reasons of a local services insurance
      /// verification artifact.
      /// </summary>
      public enum LocalServicesInsuranceRejectionReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Business name doesn't match business name for the Local Services Ad.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME_MISMATCH")] BusinessNameMismatch = 2,
        /// <summary>
        /// Insurance amount doesn't meet requirement listed in the legal summaries
        /// documentation for that geographic + category ID combination.
        /// </summary>
        [pbr::OriginalName("INSURANCE_AMOUNT_INSUFFICIENT")] InsuranceAmountInsufficient = 3,
        /// <summary>
        /// Insurance document is expired.
        /// </summary>
        [pbr::OriginalName("EXPIRED")] Expired = 4,
        /// <summary>
        /// Insurance document is missing a signature.
        /// </summary>
        [pbr::OriginalName("NO_SIGNATURE")] NoSignature = 5,
        /// <summary>
        /// Insurance document is missing a policy number.
        /// </summary>
        [pbr::OriginalName("NO_POLICY_NUMBER")] NoPolicyNumber = 6,
        /// <summary>
        /// Commercial General Liability(CGL) box is not marked in the insurance
        /// document.
        /// </summary>
        [pbr::OriginalName("NO_COMMERCIAL_GENERAL_LIABILITY")] NoCommercialGeneralLiability = 7,
        /// <summary>
        /// Insurance document is in an editable format.
        /// </summary>
        [pbr::OriginalName("EDITABLE_FORMAT")] EditableFormat = 8,
        /// <summary>
        /// Insurance document does not cover insurance for a particular category.
        /// </summary>
        [pbr::OriginalName("CATEGORY_MISMATCH")] CategoryMismatch = 9,
        /// <summary>
        /// Insurance document is missing an expiration date.
        /// </summary>
        [pbr::OriginalName("MISSING_EXPIRATION_DATE")] MissingExpirationDate = 10,
        /// <summary>
        /// Insurance document is poor quality - blurry images, illegible, etc...
        /// </summary>
        [pbr::OriginalName("POOR_QUALITY")] PoorQuality = 11,
        /// <summary>
        /// Insurance document is suspected of being edited.
        /// </summary>
        [pbr::OriginalName("POTENTIALLY_EDITED")] PotentiallyEdited = 12,
        /// <summary>
        /// Insurance document not accepted. For example, documents of insurance
        /// proposals, but missing coverages are not accepted.
        /// </summary>
        [pbr::OriginalName("WRONG_DOCUMENT_TYPE")] WrongDocumentType = 13,
        /// <summary>
        /// Insurance document is not final.
        /// </summary>
        [pbr::OriginalName("NON_FINAL")] NonFinal = 14,
        /// <summary>
        /// Insurance document has another flaw not listed explicitly.
        /// </summary>
        [pbr::OriginalName("OTHER")] Other = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
