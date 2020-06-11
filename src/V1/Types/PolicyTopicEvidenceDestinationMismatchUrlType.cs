// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/enums/policy_topic_evidence_destination_mismatch_url_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
  public static partial class PolicyTopicEvidenceDestinationMismatchUrlTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEvidenceDestinationMismatchUrlTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cldnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9wb2xpY3lfdG9waWNf",
            "ZXZpZGVuY2VfZGVzdGluYXRpb25fbWlzbWF0Y2hfdXJsX3R5cGUucHJvdG8S",
            "HWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvIuQBCjFQb2xpY3lUb3BpY0V2aWRlbmNlRGVzdGlu",
            "YXRpb25NaXNtYXRjaFVybFR5cGVFbnVtIq4BCi1Qb2xpY3lUb3BpY0V2aWRl",
            "bmNlRGVzdGluYXRpb25NaXNtYXRjaFVybFR5cGUSDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESDwoLRElTUExBWV9VUkwQAhINCglGSU5BTF9VUkwQ",
            "AxIUChBGSU5BTF9NT0JJTEVfVVJMEAQSEAoMVFJBQ0tJTkdfVVJMEAUSFwoT",
            "TU9CSUxFX1RSQUNLSU5HX1VSTBAGQocCCiFjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEuZW51bXNCMlBvbGljeVRvcGljRXZpZGVuY2VEZXN0aW5hdGlv",
            "bk1pc21hdGNoVXJsVHlwZVByb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLkVudW1zygIdR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjFcRW51bXPqAiFHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum), global::Google.Ads.GoogleAds.V1.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Types.PolicyTopicEvidenceDestinationMismatchUrlType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic evidence destination
  /// mismatch url types.
  /// </summary>
  public sealed partial class PolicyTopicEvidenceDestinationMismatchUrlTypeEnum : pb::IMessage<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> {
    private static readonly pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> _parser = new pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum>(() => new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum Clone() {
      return new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEvidenceDestinationMismatchUrlTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
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
    public void MergeFrom(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
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
    /// <summary>Container for nested types declared in the PolicyTopicEvidenceDestinationMismatchUrlTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic evidence destination mismatch url types.
      /// </summary>
      public enum PolicyTopicEvidenceDestinationMismatchUrlType {
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
        /// The display url.
        /// </summary>
        [pbr::OriginalName("DISPLAY_URL")] DisplayUrl = 2,
        /// <summary>
        /// The final url.
        /// </summary>
        [pbr::OriginalName("FINAL_URL")] FinalUrl = 3,
        /// <summary>
        /// The final mobile url.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URL")] FinalMobileUrl = 4,
        /// <summary>
        /// The tracking url template, with substituted desktop url.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 5,
        /// <summary>
        /// The tracking url template, with substituted mobile url.
        /// </summary>
        [pbr::OriginalName("MOBILE_TRACKING_URL")] MobileTrackingUrl = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
