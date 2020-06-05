// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/campaign_criterion_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/campaign_criterion_status.proto</summary>
  public static partial class CampaignCriterionStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/campaign_criterion_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9jYW1wYWlnbl9jcml0",
            "ZXJpb25fc3RhdHVzLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ8ChtDYW1wYWln",
            "bkNyaXRlcmlvblN0YXR1c0VudW0iXQoXQ2FtcGFpZ25Dcml0ZXJpb25TdGF0",
            "dXMSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESCwoHRU5BQkxFRBAC",
            "EgoKBlBBVVNFRBADEgsKB1JFTU9WRUQQBELxAQohY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY0LmVudW1zQhxDYW1wYWlnbkNyaXRlcmlvblN0YXR1c1By",
            "b3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92NC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlY0LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjRcRW51bXPqAiFHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6RW51bXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.CampaignCriterionStatusEnum), global::Google.Ads.GoogleAds.V4.Enums.CampaignCriterionStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.CampaignCriterionStatusEnum.Types.CampaignCriterionStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing CampaignCriterion statuses.
  /// </summary>
  public sealed partial class CampaignCriterionStatusEnum : pb::IMessage<CampaignCriterionStatusEnum> {
    private static readonly pb::MessageParser<CampaignCriterionStatusEnum> _parser = new pb::MessageParser<CampaignCriterionStatusEnum>(() => new CampaignCriterionStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterionStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.CampaignCriterionStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionStatusEnum(CampaignCriterionStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionStatusEnum Clone() {
      return new CampaignCriterionStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterionStatusEnum other) {
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
    public void MergeFrom(CampaignCriterionStatusEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignCriterionStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible statuses of a CampaignCriterion.
      /// </summary>
      public enum CampaignCriterionStatus {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign criterion is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// The campaign criterion is paused.
        /// </summary>
        [pbr::OriginalName("PAUSED")] Paused = 3,
        /// <summary>
        /// The campaign criterion is removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
