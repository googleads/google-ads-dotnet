// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/ad_group_ad_asset_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/ad_group_ad_asset_view.proto</summary>
  public static partial class AdGroupAdAssetViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/ad_group_ad_asset_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdAssetViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "YWRfYXNzZXRfdmlldy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIu",
            "cmVzb3VyY2VzGitnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9jb21tb24vcG9s",
            "aWN5LnByb3RvGjRnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9hc3Nl",
            "dF9maWVsZF90eXBlLnByb3RvGjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9l",
            "bnVtcy9hc3NldF9wZXJmb3JtYW5jZV9sYWJlbC5wcm90bxo6Z29vZ2xlL2Fk",
            "cy9nb29nbGVhZHMvdjIvZW51bXMvcG9saWN5X2FwcHJvdmFsX3N0YXR1cy5w",
            "cm90bxo4Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIvZW51bXMvcG9saWN5X3Jl",
            "dmlld19zdGF0dXMucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5w",
            "cm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKkAwoSQWRHcm91",
            "cEFkQXNzZXRWaWV3EhUKDXJlc291cmNlX25hbWUYASABKAkSMQoLYWRfZ3Jv",
            "dXBfYWQYBSABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSKwoF",
            "YXNzZXQYBiABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSVAoK",
            "ZmllbGRfdHlwZRgCIAEoDjJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zLkFzc2V0RmllbGRUeXBlRW51bS5Bc3NldEZpZWxkVHlwZRJWCg5wb2xp",
            "Y3lfc3VtbWFyeRgDIAEoCzI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJl",
            "c291cmNlcy5BZEdyb3VwQWRBc3NldFBvbGljeVN1bW1hcnkSaQoRcGVyZm9y",
            "bWFuY2VfbGFiZWwYBCABKA4yTi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5l",
            "bnVtcy5Bc3NldFBlcmZvcm1hbmNlTGFiZWxFbnVtLkFzc2V0UGVyZm9ybWFu",
            "Y2VMYWJlbCK1AgobQWRHcm91cEFkQXNzZXRQb2xpY3lTdW1tYXJ5Ek4KFHBv",
            "bGljeV90b3BpY19lbnRyaWVzGAEgAygLMjAuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjIuY29tbW9uLlBvbGljeVRvcGljRW50cnkSXwoNcmV2aWV3X3N0YXR1",
            "cxgCIAEoDjJILmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zLlBvbGlj",
            "eVJldmlld1N0YXR1c0VudW0uUG9saWN5UmV2aWV3U3RhdHVzEmUKD2FwcHJv",
            "dmFsX3N0YXR1cxgDIAEoDjJMLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVu",
            "dW1zLlBvbGljeUFwcHJvdmFsU3RhdHVzRW51bS5Qb2xpY3lBcHByb3ZhbFN0",
            "YXR1c0KEAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291cmNl",
            "c0IXQWRHcm91cEFkQXNzZXRWaWV3UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291",
            "cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "Mi5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxSZXNvdXJj",
            "ZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6UmVzb3VyY2VzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Common.PolicyReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.AssetPerformanceLabelReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.PolicyApprovalStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.PolicyReviewStatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetView), global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetView.Parser, new[]{ "ResourceName", "AdGroupAd", "Asset", "FieldType", "PolicySummary", "PerformanceLabel" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary), global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary.Parser, new[]{ "PolicyTopicEntries", "ReviewStatus", "ApprovalStatus" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between an AdGroupAd and an Asset.
  /// </summary>
  public sealed partial class AdGroupAdAssetView : pb::IMessage<AdGroupAdAssetView> {
    private static readonly pb::MessageParser<AdGroupAdAssetView> _parser = new pb::MessageParser<AdGroupAdAssetView>(() => new AdGroupAdAssetView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAdAssetView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetView(AdGroupAdAssetView other) : this() {
      resourceName_ = other.resourceName_;
      AdGroupAd = other.AdGroupAd;
      Asset = other.Asset;
      fieldType_ = other.fieldType_;
      policySummary_ = other.policySummary_ != null ? other.policySummary_.Clone() : null;
      performanceLabel_ = other.performanceLabel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetView Clone() {
      return new AdGroupAdAssetView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the ad group ad asset view.
    /// Ad group ad asset view resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAdAssets/{AdGroupAdAsset.ad_group_id}~{AdGroupAdAsset.ad.ad_id}~{AdGroupAdAsset.asset_id}~{AdGroupAdAsset.asset_field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_adGroupAd_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string adGroupAd_;
    /// <summary>
    /// The ad group ad to which the asset is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_; }
      set {
        adGroupAd_ = value;
      }
    }


    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_asset_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string asset_;
    /// <summary>
    /// The asset which is linked to the ad group ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = value;
      }
    }


    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V2.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = 0;
    /// <summary>
    /// Role that the asset takes in the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "policy_summary" field.</summary>
    public const int PolicySummaryFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary policySummary_;
    /// <summary>
    /// Policy information for the ad group ad asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary PolicySummary {
      get { return policySummary_; }
      set {
        policySummary_ = value;
      }
    }

    /// <summary>Field number for the "performance_label" field.</summary>
    public const int PerformanceLabelFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V2.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel performanceLabel_ = 0;
    /// <summary>
    /// Performance of an asset linkage.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel PerformanceLabel {
      get { return performanceLabel_; }
      set {
        performanceLabel_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdAssetView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAdAssetView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (!object.Equals(PolicySummary, other.PolicySummary)) return false;
      if (PerformanceLabel != other.PerformanceLabel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroupAd_ != null) hash ^= AdGroupAd.GetHashCode();
      if (asset_ != null) hash ^= Asset.GetHashCode();
      if (FieldType != 0) hash ^= FieldType.GetHashCode();
      if (policySummary_ != null) hash ^= PolicySummary.GetHashCode();
      if (PerformanceLabel != 0) hash ^= PerformanceLabel.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (FieldType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) FieldType);
      }
      if (policySummary_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PolicySummary);
      }
      if (PerformanceLabel != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) PerformanceLabel);
      }
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(output, AdGroupAd);
      }
      if (asset_ != null) {
        _single_asset_codec.WriteTagAndValue(output, Asset);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (adGroupAd_ != null) {
        size += _single_adGroupAd_codec.CalculateSizeWithTag(AdGroupAd);
      }
      if (asset_ != null) {
        size += _single_asset_codec.CalculateSizeWithTag(Asset);
      }
      if (FieldType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (policySummary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PolicySummary);
      }
      if (PerformanceLabel != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PerformanceLabel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupAdAssetView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroupAd_ != null) {
        if (adGroupAd_ == null || other.AdGroupAd != "") {
          AdGroupAd = other.AdGroupAd;
        }
      }
      if (other.asset_ != null) {
        if (asset_ == null || other.Asset != "") {
          Asset = other.Asset;
        }
      }
      if (other.FieldType != 0) {
        FieldType = other.FieldType;
      }
      if (other.policySummary_ != null) {
        if (policySummary_ == null) {
          PolicySummary = new global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary();
        }
        PolicySummary.MergeFrom(other.PolicySummary);
      }
      if (other.PerformanceLabel != 0) {
        PerformanceLabel = other.PerformanceLabel;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 16: {
            FieldType = (global::Google.Ads.GoogleAds.V2.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 26: {
            if (policySummary_ == null) {
              PolicySummary = new global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetPolicySummary();
            }
            input.ReadMessage(PolicySummary);
            break;
          }
          case 32: {
            PerformanceLabel = (global::Google.Ads.GoogleAds.V2.Enums.AssetPerformanceLabelEnum.Types.AssetPerformanceLabel) input.ReadEnum();
            break;
          }
          case 42: {
            string value = _single_adGroupAd_codec.Read(input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
            }
            break;
          }
          case 50: {
            string value = _single_asset_codec.Read(input);
            if (asset_ == null || value != "") {
              Asset = value;
            }
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Contains policy information for an ad group ad asset.
  /// </summary>
  public sealed partial class AdGroupAdAssetPolicySummary : pb::IMessage<AdGroupAdAssetPolicySummary> {
    private static readonly pb::MessageParser<AdGroupAdAssetPolicySummary> _parser = new pb::MessageParser<AdGroupAdAssetPolicySummary>(() => new AdGroupAdAssetPolicySummary());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupAdAssetPolicySummary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.AdGroupAdAssetViewReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetPolicySummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetPolicySummary(AdGroupAdAssetPolicySummary other) : this() {
      policyTopicEntries_ = other.policyTopicEntries_.Clone();
      reviewStatus_ = other.reviewStatus_;
      approvalStatus_ = other.approvalStatus_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupAdAssetPolicySummary Clone() {
      return new AdGroupAdAssetPolicySummary(this);
    }

    /// <summary>Field number for the "policy_topic_entries" field.</summary>
    public const int PolicyTopicEntriesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V2.Common.PolicyTopicEntry> _repeated_policyTopicEntries_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V2.Common.PolicyTopicEntry.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Common.PolicyTopicEntry> policyTopicEntries_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Common.PolicyTopicEntry>();
    /// <summary>
    /// The list of policy findings for the ad group ad asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Common.PolicyTopicEntry> PolicyTopicEntries {
      get { return policyTopicEntries_; }
    }

    /// <summary>Field number for the "review_status" field.</summary>
    public const int ReviewStatusFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V2.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus reviewStatus_ = 0;
    /// <summary>
    /// Where in the review process this ad group ad asset is.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus ReviewStatus {
      get { return reviewStatus_; }
      set {
        reviewStatus_ = value;
      }
    }

    /// <summary>Field number for the "approval_status" field.</summary>
    public const int ApprovalStatusFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V2.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus approvalStatus_ = 0;
    /// <summary>
    /// The overall approval status of this ad group ad asset, calculated based on
    /// the status of its individual policy topic entries.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus ApprovalStatus {
      get { return approvalStatus_; }
      set {
        approvalStatus_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAdAssetPolicySummary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupAdAssetPolicySummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!policyTopicEntries_.Equals(other.policyTopicEntries_)) return false;
      if (ReviewStatus != other.ReviewStatus) return false;
      if (ApprovalStatus != other.ApprovalStatus) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= policyTopicEntries_.GetHashCode();
      if (ReviewStatus != 0) hash ^= ReviewStatus.GetHashCode();
      if (ApprovalStatus != 0) hash ^= ApprovalStatus.GetHashCode();
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
      policyTopicEntries_.WriteTo(output, _repeated_policyTopicEntries_codec);
      if (ReviewStatus != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ReviewStatus);
      }
      if (ApprovalStatus != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += policyTopicEntries_.CalculateSize(_repeated_policyTopicEntries_codec);
      if (ReviewStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ReviewStatus);
      }
      if (ApprovalStatus != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ApprovalStatus);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupAdAssetPolicySummary other) {
      if (other == null) {
        return;
      }
      policyTopicEntries_.Add(other.policyTopicEntries_);
      if (other.ReviewStatus != 0) {
        ReviewStatus = other.ReviewStatus;
      }
      if (other.ApprovalStatus != 0) {
        ApprovalStatus = other.ApprovalStatus;
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
          case 10: {
            policyTopicEntries_.AddEntriesFrom(input, _repeated_policyTopicEntries_codec);
            break;
          }
          case 16: {
            ReviewStatus = (global::Google.Ads.GoogleAds.V2.Enums.PolicyReviewStatusEnum.Types.PolicyReviewStatus) input.ReadEnum();
            break;
          }
          case 24: {
            ApprovalStatus = (global::Google.Ads.GoogleAds.V2.Enums.PolicyApprovalStatusEnum.Types.PolicyApprovalStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
