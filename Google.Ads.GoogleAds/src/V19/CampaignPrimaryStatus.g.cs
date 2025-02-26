// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/campaign_primary_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/campaign_primary_status.proto</summary>
  public static partial class CampaignPrimaryStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/campaign_primary_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignPrimaryStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvY2FtcGFpZ25fcHJp",
            "bWFyeV9zdGF0dXMucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5l",
            "bnVtcyLSAQoZQ2FtcGFpZ25QcmltYXJ5U3RhdHVzRW51bSK0AQoVQ2FtcGFp",
            "Z25QcmltYXJ5U3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThAB",
            "EgwKCEVMSUdJQkxFEAISCgoGUEFVU0VEEAMSCwoHUkVNT1ZFRBAEEgkKBUVO",
            "REVEEAUSCwoHUEVORElORxAGEhEKDU1JU0NPTkZJR1VSRUQQBxILCgdMSU1J",
            "VEVEEAgSDAoITEVBUk5JTkcQCRIQCgxOT1RfRUxJR0lCTEUQCkL0AQoiY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lbnVtc0IaQ2FtcGFpZ25Qcmlt",
            "YXJ5U3RhdHVzUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxOS9lbnVtcztlbnVtc6ICA0dB",
            "QaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOS5FbnVtc8oCHkdvb2dsZVxB",
            "ZHNcR29vZ2xlQWRzXFYxOVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlYxOTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.CampaignPrimaryStatusEnum), global::Google.Ads.GoogleAds.V19.Enums.CampaignPrimaryStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.CampaignPrimaryStatusEnum.Types.CampaignPrimaryStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign primary status.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class CampaignPrimaryStatusEnum : pb::IMessage<CampaignPrimaryStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignPrimaryStatusEnum> _parser = new pb::MessageParser<CampaignPrimaryStatusEnum>(() => new CampaignPrimaryStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignPrimaryStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.CampaignPrimaryStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignPrimaryStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignPrimaryStatusEnum(CampaignPrimaryStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignPrimaryStatusEnum Clone() {
      return new CampaignPrimaryStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignPrimaryStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignPrimaryStatusEnum other) {
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
    public void MergeFrom(CampaignPrimaryStatusEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignPrimaryStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the possible campaign primary status. Provides insight into
      /// why a campaign is not serving or not serving optimally. Modification to the
      /// campaign and its related entities might take a while to be reflected in
      /// this status.
      /// </summary>
      public enum CampaignPrimaryStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign is eligible to serve.
        /// </summary>
        [pbr::OriginalName("ELIGIBLE")] Eligible = 2,
        /// <summary>
        /// The user-specified campaign status is paused.
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 3,
        /// <summary>
        /// The user-specified campaign status is removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 4,
        /// <summary>
        /// The user-specified time for this campaign to end has passed.
        /// </summary>
        [pbr::OriginalName("ENDED")] Ended = 5,
        /// <summary>
        /// The campaign may serve in the future.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 6,
        /// <summary>
        /// The campaign or its associated entities have incorrect user-specified
        /// settings.
        /// </summary>
        [pbr::OriginalName("MISCONFIGURED")] Misconfigured = 7,
        /// <summary>
        /// The campaign or its associated entities are limited by user-specified
        /// settings.
        /// </summary>
        [pbr::OriginalName("LIMITED")] Limited = 8,
        /// <summary>
        /// The automated bidding system is adjusting to user-specified changes to
        /// the campaign or associated entities.
        /// </summary>
        [pbr::OriginalName("LEARNING")] Learning = 9,
        /// <summary>
        /// The campaign is not eligible to serve.
        /// </summary>
        [pbr::OriginalName("NOT_ELIGIBLE")] NotEligible = 10,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
