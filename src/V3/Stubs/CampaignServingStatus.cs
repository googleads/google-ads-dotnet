// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/campaign_serving_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/campaign_serving_status.proto</summary>
  public static partial class CampaignServingStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/campaign_serving_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignServingStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9jYW1wYWlnbl9zZXJ2",
            "aW5nX3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8ikAEKGUNhbXBhaWdu",
            "U2VydmluZ1N0YXR1c0VudW0icwoVQ2FtcGFpZ25TZXJ2aW5nU3RhdHVzEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB1NFUlZJTkcQAhIICgRO",
            "T05FEAMSCQoFRU5ERUQQBBILCgdQRU5ESU5HEAUSDQoJU1VTUEVOREVEEAZC",
            "7wEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IaQ2FtcGFp",
            "Z25TZXJ2aW5nU3RhdHVzUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zO2VudW1z",
            "ogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuRW51bXPKAh1Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWM1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYzOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.CampaignServingStatusEnum), global::Google.Ads.GoogleAds.V3.Enums.CampaignServingStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.CampaignServingStatusEnum.Types.CampaignServingStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing Campaign serving statuses.
  /// </summary>
  public sealed partial class CampaignServingStatusEnum : pb::IMessage<CampaignServingStatusEnum> {
    private static readonly pb::MessageParser<CampaignServingStatusEnum> _parser = new pb::MessageParser<CampaignServingStatusEnum>(() => new CampaignServingStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignServingStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.CampaignServingStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignServingStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignServingStatusEnum(CampaignServingStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignServingStatusEnum Clone() {
      return new CampaignServingStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignServingStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignServingStatusEnum other) {
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
    public void MergeFrom(CampaignServingStatusEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignServingStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible serving statuses of a campaign.
      /// </summary>
      public enum CampaignServingStatus {
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
        /// Serving.
        /// </summary>
        [pbr::OriginalName("SERVING")] Serving = 2,
        /// <summary>
        /// None.
        /// </summary>
        [pbr::OriginalName("NONE")] None = 3,
        /// <summary>
        /// Ended.
        /// </summary>
        [pbr::OriginalName("ENDED")] Ended = 4,
        /// <summary>
        /// Pending.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 5,
        /// <summary>
        /// Suspended.
        /// </summary>
        [pbr::OriginalName("SUSPENDED")] Suspended = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
