// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v6/resources/change_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V6.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v6/resources/change_status.proto</summary>
  public static partial class ChangeStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v6/resources/change_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9yZXNvdXJjZXMvY2hhbmdlX3N0",
            "YXR1cy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjYucmVzb3VyY2Vz",
            "Gitnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9hZF90eXBlLnByb3Rv",
            "GkBnb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9hZHZlcnRpc2luZ19j",
            "aGFubmVsX3N1Yl90eXBlLnByb3RvGjxnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "Ni9lbnVtcy9hZHZlcnRpc2luZ19jaGFubmVsX3R5cGUucHJvdG8aO2dvb2ds",
            "ZS9hZHMvZ29vZ2xlYWRzL3Y2L2VudW1zL2NoYW5nZV9zdGF0dXNfb3BlcmF0",
            "aW9uLnByb3RvGj9nb29nbGUvYWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9jaGFu",
            "Z2Vfc3RhdHVzX3Jlc291cmNlX3R5cGUucHJvdG8aMmdvb2dsZS9hZHMvZ29v",
            "Z2xlYWRzL3Y2L2VudW1zL2NyaXRlcmlvbl90eXBlLnByb3RvGi9nb29nbGUv",
            "YWRzL2dvb2dsZWFkcy92Ni9lbnVtcy9mZWVkX29yaWdpbi5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLmCgoM",
            "Q2hhbmdlU3RhdHVzEkQKDXJlc291cmNlX25hbWUYASABKAlCLeBBA/pBJwol",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NoYW5nZVN0YXR1cxInChVsYXN0",
            "X2NoYW5nZV9kYXRlX3RpbWUYGCABKAlCA+BBA0gAiAEBEnAKDXJlc291cmNl",
            "X3R5cGUYBCABKA4yVC5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ni5lbnVtcy5D",
            "aGFuZ2VTdGF0dXNSZXNvdXJjZVR5cGVFbnVtLkNoYW5nZVN0YXR1c1Jlc291",
            "cmNlVHlwZUID4EEDEkAKCGNhbXBhaWduGBEgASgJQingQQP6QSMKIWdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkgBiAEBEj8KCGFkX2dyb3Vw",
            "GBIgASgJQijgQQP6QSIKIGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdy",
            "b3VwSAKIAQESbAoPcmVzb3VyY2Vfc3RhdHVzGAggASgOMk4uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjYuZW51bXMuQ2hhbmdlU3RhdHVzT3BlcmF0aW9uRW51",
            "bS5DaGFuZ2VTdGF0dXNPcGVyYXRpb25CA+BBAxJECgthZF9ncm91cF9hZBgZ",
            "IAEoCUIq4EED+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91",
            "cEFkSAOIAQESUgoSYWRfZ3JvdXBfY3JpdGVyaW9uGBogASgJQjHgQQP6QSsK",
            "KWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwQ3JpdGVyaW9uSASI",
            "AQESUwoSY2FtcGFpZ25fY3JpdGVyaW9uGBsgASgJQjLgQQP6QSwKKmdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkNyaXRlcmlvbkgFiAEBEjgK",
            "BGZlZWQYHCABKAlCJeBBA/pBHwodZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L0ZlZWRIBogBARJBCglmZWVkX2l0ZW0YHSABKAlCKeBBA/pBIwohZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0ZlZWRJdGVtSAeIAQESSAoNYWRfZ3JvdXBf",
            "ZmVlZBgeIAEoCUIs4EED+kEmCiRnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRHcm91cEZlZWRICIgBARJJCg1jYW1wYWlnbl9mZWVkGB8gASgJQi3gQQP6",
            "QScKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbkZlZWRICYgB",
            "ARJXChVhZF9ncm91cF9iaWRfbW9kaWZpZXIYICABKAlCM+BBA/pBLQorZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBCaWRNb2RpZmllckgKiAEB",
            "OmPqQWAKJWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DaGFuZ2VTdGF0dXMS",
            "N2N1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2NoYW5nZVN0YXR1cy97Y2hhbmdl",
            "X3N0YXR1c19pZH1CGAoWX2xhc3RfY2hhbmdlX2RhdGVfdGltZUILCglfY2Ft",
            "cGFpZ25CCwoJX2FkX2dyb3VwQg4KDF9hZF9ncm91cF9hZEIVChNfYWRfZ3Jv",
            "dXBfY3JpdGVyaW9uQhUKE19jYW1wYWlnbl9jcml0ZXJpb25CBwoFX2ZlZWRC",
            "DAoKX2ZlZWRfaXRlbUIQCg5fYWRfZ3JvdXBfZmVlZEIQCg5fY2FtcGFpZ25f",
            "ZmVlZEIYChZfYWRfZ3JvdXBfYmlkX21vZGlmaWVyQv4BCiVjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjYucmVzb3VyY2VzQhFDaGFuZ2VTdGF0dXNQcm90",
            "b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjYvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlY2LlJlc291cmNlc8oCIUdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFY2XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlY2OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V6.Enums.AdTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelSubTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.AdvertisingChannelTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.CriterionTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V6.Enums.FeedOriginReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V6.Resources.ChangeStatus), global::Google.Ads.GoogleAds.V6.Resources.ChangeStatus.Parser, new[]{ "ResourceName", "LastChangeDateTime", "ResourceType", "Campaign", "AdGroup", "ResourceStatus", "AdGroupAd", "AdGroupCriterion", "CampaignCriterion", "Feed", "FeedItem", "AdGroupFeed", "CampaignFeed", "AdGroupBidModifier" }, new[]{ "LastChangeDateTime", "Campaign", "AdGroup", "AdGroupAd", "AdGroupCriterion", "CampaignCriterion", "Feed", "FeedItem", "AdGroupFeed", "CampaignFeed", "AdGroupBidModifier" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the status of returned resource. ChangeStatus could have up to 3
  /// minutes delay to reflect a new change.
  /// </summary>
  public sealed partial class ChangeStatus : pb::IMessage<ChangeStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeStatus> _parser = new pb::MessageParser<ChangeStatus>(() => new ChangeStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChangeStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V6.Resources.ChangeStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus(ChangeStatus other) : this() {
      resourceName_ = other.resourceName_;
      lastChangeDateTime_ = other.lastChangeDateTime_;
      resourceType_ = other.resourceType_;
      campaign_ = other.campaign_;
      adGroup_ = other.adGroup_;
      resourceStatus_ = other.resourceStatus_;
      adGroupAd_ = other.adGroupAd_;
      adGroupCriterion_ = other.adGroupCriterion_;
      campaignCriterion_ = other.campaignCriterion_;
      feed_ = other.feed_;
      feedItem_ = other.feedItem_;
      adGroupFeed_ = other.adGroupFeed_;
      campaignFeed_ = other.campaignFeed_;
      adGroupBidModifier_ = other.adGroupBidModifier_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChangeStatus Clone() {
      return new ChangeStatus(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the change status.
    /// Change status resource names have the form:
    ///
    /// `customers/{customer_id}/changeStatus/{change_status_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_change_date_time" field.</summary>
    public const int LastChangeDateTimeFieldNumber = 24;
    private string lastChangeDateTime_;
    /// <summary>
    /// Output only. Time at which the most recent change has occurred on this resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LastChangeDateTime {
      get { return lastChangeDateTime_ ?? ""; }
      set {
        lastChangeDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "last_change_date_time" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasLastChangeDateTime {
      get { return lastChangeDateTime_ != null; }
    }
    /// <summary>Clears the value of the "last_change_date_time" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearLastChangeDateTime() {
      lastChangeDateTime_ = null;
    }

    /// <summary>Field number for the "resource_type" field.</summary>
    public const int ResourceTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType resourceType_ = global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified;
    /// <summary>
    /// Output only. Represents the type of the changed resource. This dictates what fields
    /// will be set. For example, for AD_GROUP, campaign and ad_group fields will
    /// be set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType ResourceType {
      get { return resourceType_; }
      set {
        resourceType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 17;
    private string campaign_;
    /// <summary>
    /// Output only. The Campaign affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return campaign_ ?? ""; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 18;
    private string adGroup_;
    /// <summary>
    /// Output only. The AdGroup affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_ ?? ""; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroup {
      get { return adGroup_ != null; }
    }
    /// <summary>Clears the value of the "ad_group" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroup() {
      adGroup_ = null;
    }

    /// <summary>Field number for the "resource_status" field.</summary>
    public const int ResourceStatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation resourceStatus_ = global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified;
    /// <summary>
    /// Output only. Represents the status of the changed resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation ResourceStatus {
      get { return resourceStatus_; }
      set {
        resourceStatus_ = value;
      }
    }

    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 25;
    private string adGroupAd_;
    /// <summary>
    /// Output only. The AdGroupAd affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_ ?? ""; }
      set {
        adGroupAd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_ad" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroupAd {
      get { return adGroupAd_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_ad" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroupAd() {
      adGroupAd_ = null;
    }

    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 26;
    private string adGroupCriterion_;
    /// <summary>
    /// Output only. The AdGroupCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupCriterion {
      get { return adGroupCriterion_ ?? ""; }
      set {
        adGroupCriterion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_criterion" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroupCriterion {
      get { return adGroupCriterion_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_criterion" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroupCriterion() {
      adGroupCriterion_ = null;
    }

    /// <summary>Field number for the "campaign_criterion" field.</summary>
    public const int CampaignCriterionFieldNumber = 27;
    private string campaignCriterion_;
    /// <summary>
    /// Output only. The CampaignCriterion affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignCriterion {
      get { return campaignCriterion_ ?? ""; }
      set {
        campaignCriterion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign_criterion" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCampaignCriterion {
      get { return campaignCriterion_ != null; }
    }
    /// <summary>Clears the value of the "campaign_criterion" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCampaignCriterion() {
      campaignCriterion_ = null;
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 28;
    private string feed_;
    /// <summary>
    /// Output only. The Feed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Feed {
      get { return feed_ ?? ""; }
      set {
        feed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "feed" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasFeed {
      get { return feed_ != null; }
    }
    /// <summary>Clears the value of the "feed" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearFeed() {
      feed_ = null;
    }

    /// <summary>Field number for the "feed_item" field.</summary>
    public const int FeedItemFieldNumber = 29;
    private string feedItem_;
    /// <summary>
    /// Output only. The FeedItem affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FeedItem {
      get { return feedItem_ ?? ""; }
      set {
        feedItem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "feed_item" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasFeedItem {
      get { return feedItem_ != null; }
    }
    /// <summary>Clears the value of the "feed_item" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearFeedItem() {
      feedItem_ = null;
    }

    /// <summary>Field number for the "ad_group_feed" field.</summary>
    public const int AdGroupFeedFieldNumber = 30;
    private string adGroupFeed_;
    /// <summary>
    /// Output only. The AdGroupFeed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupFeed {
      get { return adGroupFeed_ ?? ""; }
      set {
        adGroupFeed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_feed" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroupFeed {
      get { return adGroupFeed_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_feed" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroupFeed() {
      adGroupFeed_ = null;
    }

    /// <summary>Field number for the "campaign_feed" field.</summary>
    public const int CampaignFeedFieldNumber = 31;
    private string campaignFeed_;
    /// <summary>
    /// Output only. The CampaignFeed affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CampaignFeed {
      get { return campaignFeed_ ?? ""; }
      set {
        campaignFeed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign_feed" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasCampaignFeed {
      get { return campaignFeed_ != null; }
    }
    /// <summary>Clears the value of the "campaign_feed" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCampaignFeed() {
      campaignFeed_ = null;
    }

    /// <summary>Field number for the "ad_group_bid_modifier" field.</summary>
    public const int AdGroupBidModifierFieldNumber = 32;
    private string adGroupBidModifier_;
    /// <summary>
    /// Output only. The AdGroupBidModifier affected by this change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupBidModifier {
      get { return adGroupBidModifier_ ?? ""; }
      set {
        adGroupBidModifier_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_bid_modifier" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasAdGroupBidModifier {
      get { return adGroupBidModifier_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_bid_modifier" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearAdGroupBidModifier() {
      adGroupBidModifier_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChangeStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (LastChangeDateTime != other.LastChangeDateTime) return false;
      if (ResourceType != other.ResourceType) return false;
      if (Campaign != other.Campaign) return false;
      if (AdGroup != other.AdGroup) return false;
      if (ResourceStatus != other.ResourceStatus) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (CampaignCriterion != other.CampaignCriterion) return false;
      if (Feed != other.Feed) return false;
      if (FeedItem != other.FeedItem) return false;
      if (AdGroupFeed != other.AdGroupFeed) return false;
      if (CampaignFeed != other.CampaignFeed) return false;
      if (AdGroupBidModifier != other.AdGroupBidModifier) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasLastChangeDateTime) hash ^= LastChangeDateTime.GetHashCode();
      if (ResourceType != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) hash ^= ResourceType.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasAdGroup) hash ^= AdGroup.GetHashCode();
      if (ResourceStatus != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) hash ^= ResourceStatus.GetHashCode();
      if (HasAdGroupAd) hash ^= AdGroupAd.GetHashCode();
      if (HasAdGroupCriterion) hash ^= AdGroupCriterion.GetHashCode();
      if (HasCampaignCriterion) hash ^= CampaignCriterion.GetHashCode();
      if (HasFeed) hash ^= Feed.GetHashCode();
      if (HasFeedItem) hash ^= FeedItem.GetHashCode();
      if (HasAdGroupFeed) hash ^= AdGroupFeed.GetHashCode();
      if (HasCampaignFeed) hash ^= CampaignFeed.GetHashCode();
      if (HasAdGroupBidModifier) hash ^= AdGroupBidModifier.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ResourceStatus);
      }
      if (HasCampaign) {
        output.WriteRawTag(138, 1);
        output.WriteString(Campaign);
      }
      if (HasAdGroup) {
        output.WriteRawTag(146, 1);
        output.WriteString(AdGroup);
      }
      if (HasLastChangeDateTime) {
        output.WriteRawTag(194, 1);
        output.WriteString(LastChangeDateTime);
      }
      if (HasAdGroupAd) {
        output.WriteRawTag(202, 1);
        output.WriteString(AdGroupAd);
      }
      if (HasAdGroupCriterion) {
        output.WriteRawTag(210, 1);
        output.WriteString(AdGroupCriterion);
      }
      if (HasCampaignCriterion) {
        output.WriteRawTag(218, 1);
        output.WriteString(CampaignCriterion);
      }
      if (HasFeed) {
        output.WriteRawTag(226, 1);
        output.WriteString(Feed);
      }
      if (HasFeedItem) {
        output.WriteRawTag(234, 1);
        output.WriteString(FeedItem);
      }
      if (HasAdGroupFeed) {
        output.WriteRawTag(242, 1);
        output.WriteString(AdGroupFeed);
      }
      if (HasCampaignFeed) {
        output.WriteRawTag(250, 1);
        output.WriteString(CampaignFeed);
      }
      if (HasAdGroupBidModifier) {
        output.WriteRawTag(130, 2);
        output.WriteString(AdGroupBidModifier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ResourceType);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) ResourceStatus);
      }
      if (HasCampaign) {
        output.WriteRawTag(138, 1);
        output.WriteString(Campaign);
      }
      if (HasAdGroup) {
        output.WriteRawTag(146, 1);
        output.WriteString(AdGroup);
      }
      if (HasLastChangeDateTime) {
        output.WriteRawTag(194, 1);
        output.WriteString(LastChangeDateTime);
      }
      if (HasAdGroupAd) {
        output.WriteRawTag(202, 1);
        output.WriteString(AdGroupAd);
      }
      if (HasAdGroupCriterion) {
        output.WriteRawTag(210, 1);
        output.WriteString(AdGroupCriterion);
      }
      if (HasCampaignCriterion) {
        output.WriteRawTag(218, 1);
        output.WriteString(CampaignCriterion);
      }
      if (HasFeed) {
        output.WriteRawTag(226, 1);
        output.WriteString(Feed);
      }
      if (HasFeedItem) {
        output.WriteRawTag(234, 1);
        output.WriteString(FeedItem);
      }
      if (HasAdGroupFeed) {
        output.WriteRawTag(242, 1);
        output.WriteString(AdGroupFeed);
      }
      if (HasCampaignFeed) {
        output.WriteRawTag(250, 1);
        output.WriteString(CampaignFeed);
      }
      if (HasAdGroupBidModifier) {
        output.WriteRawTag(130, 2);
        output.WriteString(AdGroupBidModifier);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasLastChangeDateTime) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(LastChangeDateTime);
      }
      if (ResourceType != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceType);
      }
      if (HasCampaign) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasAdGroup) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (ResourceStatus != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ResourceStatus);
      }
      if (HasAdGroupAd) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroupAd);
      }
      if (HasAdGroupCriterion) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroupCriterion);
      }
      if (HasCampaignCriterion) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(CampaignCriterion);
      }
      if (HasFeed) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(Feed);
      }
      if (HasFeedItem) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(FeedItem);
      }
      if (HasAdGroupFeed) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroupFeed);
      }
      if (HasCampaignFeed) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(CampaignFeed);
      }
      if (HasAdGroupBidModifier) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AdGroupBidModifier);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChangeStatus other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasLastChangeDateTime) {
        LastChangeDateTime = other.LastChangeDateTime;
      }
      if (other.ResourceType != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType.Unspecified) {
        ResourceType = other.ResourceType;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasAdGroup) {
        AdGroup = other.AdGroup;
      }
      if (other.ResourceStatus != global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation.Unspecified) {
        ResourceStatus = other.ResourceStatus;
      }
      if (other.HasAdGroupAd) {
        AdGroupAd = other.AdGroupAd;
      }
      if (other.HasAdGroupCriterion) {
        AdGroupCriterion = other.AdGroupCriterion;
      }
      if (other.HasCampaignCriterion) {
        CampaignCriterion = other.CampaignCriterion;
      }
      if (other.HasFeed) {
        Feed = other.Feed;
      }
      if (other.HasFeedItem) {
        FeedItem = other.FeedItem;
      }
      if (other.HasAdGroupFeed) {
        AdGroupFeed = other.AdGroupFeed;
      }
      if (other.HasCampaignFeed) {
        CampaignFeed = other.CampaignFeed;
      }
      if (other.HasAdGroupBidModifier) {
        AdGroupBidModifier = other.AdGroupBidModifier;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            ResourceType = (global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
            break;
          }
          case 138: {
            Campaign = input.ReadString();
            break;
          }
          case 146: {
            AdGroup = input.ReadString();
            break;
          }
          case 194: {
            LastChangeDateTime = input.ReadString();
            break;
          }
          case 202: {
            AdGroupAd = input.ReadString();
            break;
          }
          case 210: {
            AdGroupCriterion = input.ReadString();
            break;
          }
          case 218: {
            CampaignCriterion = input.ReadString();
            break;
          }
          case 226: {
            Feed = input.ReadString();
            break;
          }
          case 234: {
            FeedItem = input.ReadString();
            break;
          }
          case 242: {
            AdGroupFeed = input.ReadString();
            break;
          }
          case 250: {
            CampaignFeed = input.ReadString();
            break;
          }
          case 258: {
            AdGroupBidModifier = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 32: {
            ResourceType = (global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) input.ReadEnum();
            break;
          }
          case 64: {
            ResourceStatus = (global::Google.Ads.GoogleAds.V6.Enums.ChangeStatusOperationEnum.Types.ChangeStatusOperation) input.ReadEnum();
            break;
          }
          case 138: {
            Campaign = input.ReadString();
            break;
          }
          case 146: {
            AdGroup = input.ReadString();
            break;
          }
          case 194: {
            LastChangeDateTime = input.ReadString();
            break;
          }
          case 202: {
            AdGroupAd = input.ReadString();
            break;
          }
          case 210: {
            AdGroupCriterion = input.ReadString();
            break;
          }
          case 218: {
            CampaignCriterion = input.ReadString();
            break;
          }
          case 226: {
            Feed = input.ReadString();
            break;
          }
          case 234: {
            FeedItem = input.ReadString();
            break;
          }
          case 242: {
            AdGroupFeed = input.ReadString();
            break;
          }
          case 250: {
            CampaignFeed = input.ReadString();
            break;
          }
          case 258: {
            AdGroupBidModifier = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
