// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/ad_group_criterion_approval_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/ad_group_criterion_approval_status.proto</summary>
  public static partial class AdGroupCriterionApprovalStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/ad_group_criterion_approval_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionApprovalStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkZnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9hZF9ncm91cF9jcml0",
            "ZXJpb25fYXBwcm92YWxfc3RhdHVzLnByb3RvEh1nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5lbnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKq",
            "AQoiQWRHcm91cENyaXRlcmlvbkFwcHJvdmFsU3RhdHVzRW51bSKDAQoeQWRH",
            "cm91cENyaXRlcmlvbkFwcHJvdmFsU3RhdHVzEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEgwKCEFQUFJPVkVEEAISDwoLRElTQVBQUk9WRUQQAxIS",
            "Cg5QRU5ESU5HX1JFVklFVxAEEhAKDFVOREVSX1JFVklFVxAFQvgBCiFjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCI0FkR3JvdXBDcml0ZXJp",
            "b25BcHByb3ZhbFN0YXR1c1Byb3RvUAFaQmdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcztlbnVt",
            "c6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYyLkVudW1zygIdR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjJcRW51bXPqAiFHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMjo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.AdGroupCriterionApprovalStatusEnum), global::Google.Ads.GoogleAds.V2.Enums.AdGroupCriterionApprovalStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.AdGroupCriterionApprovalStatusEnum.Types.AdGroupCriterionApprovalStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible AdGroupCriterion approval statuses.
  /// </summary>
  public sealed partial class AdGroupCriterionApprovalStatusEnum : pb::IMessage<AdGroupCriterionApprovalStatusEnum> {
    private static readonly pb::MessageParser<AdGroupCriterionApprovalStatusEnum> _parser = new pb::MessageParser<AdGroupCriterionApprovalStatusEnum>(() => new AdGroupCriterionApprovalStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupCriterionApprovalStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.AdGroupCriterionApprovalStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionApprovalStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionApprovalStatusEnum(AdGroupCriterionApprovalStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupCriterionApprovalStatusEnum Clone() {
      return new AdGroupCriterionApprovalStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupCriterionApprovalStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupCriterionApprovalStatusEnum other) {
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
    public void MergeFrom(AdGroupCriterionApprovalStatusEnum other) {
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
    /// <summary>Container for nested types declared in the AdGroupCriterionApprovalStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates AdGroupCriterion approval statuses.
      /// </summary>
      public enum AdGroupCriterionApprovalStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Approved.
        /// </summary>
        [pbr::OriginalName("APPROVED")] Approved = 2,
        /// <summary>
        /// Disapproved.
        /// </summary>
        [pbr::OriginalName("DISAPPROVED")] Disapproved = 3,
        /// <summary>
        /// Pending Review.
        /// </summary>
        [pbr::OriginalName("PENDING_REVIEW")] PendingReview = 4,
        /// <summary>
        /// Under review.
        /// </summary>
        [pbr::OriginalName("UNDER_REVIEW")] UnderReview = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
