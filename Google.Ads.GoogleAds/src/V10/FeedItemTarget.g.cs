// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/feed_item_target.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/feed_item_target.proto</summary>
  public static partial class FeedItemTargetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/feed_item_target.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemTargetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2ZlZWRfaXRl",
            "bV90YXJnZXQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5yZXNv",
            "dXJjZXMaLmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMC9jb21tb24vY3JpdGVy",
            "aWEucHJvdG8aPGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMC9lbnVtcy9mZWVk",
            "X2l0ZW1fdGFyZ2V0X2RldmljZS5wcm90bxo8Z29vZ2xlL2Fkcy9nb29nbGVh",
            "ZHMvdjEwL2VudW1zL2ZlZWRfaXRlbV90YXJnZXRfc3RhdHVzLnByb3RvGjpn",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvZmVlZF9pdGVtX3Rhcmdl",
            "dF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3Rv",
            "Ghlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIq4ICg5GZWVkSXRlbVRhcmdl",
            "dBJGCg1yZXNvdXJjZV9uYW1lGAEgASgJQi/gQQX6QSkKJ2dvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9GZWVkSXRlbVRhcmdldBJBCglmZWVkX2l0ZW0YDCAB",
            "KAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0ZlZWRJdGVt",
            "SAGIAQESbQoVZmVlZF9pdGVtX3RhcmdldF90eXBlGAMgASgOMkkuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEwLmVudW1zLkZlZWRJdGVtVGFyZ2V0VHlwZUVu",
            "dW0uRmVlZEl0ZW1UYXJnZXRUeXBlQgPgQQMSJQoTZmVlZF9pdGVtX3Rhcmdl",
            "dF9pZBgNIAEoA0ID4EEDSAKIAQESYgoGc3RhdHVzGAsgASgOMk0uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEwLmVudW1zLkZlZWRJdGVtVGFyZ2V0U3RhdHVz",
            "RW51bS5GZWVkSXRlbVRhcmdldFN0YXR1c0ID4EEDEj0KCGNhbXBhaWduGA4g",
            "ASgJQingQQX6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWln",
            "bkgAEjwKCGFkX2dyb3VwGA8gASgJQijgQQX6QSIKIGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9BZEdyb3VwSAASRAoHa2V5d29yZBgHIAEoCzIsLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxMC5jb21tb24uS2V5d29yZEluZm9CA+BBBUgA",
            "ElEKE2dlb190YXJnZXRfY29uc3RhbnQYECABKAlCMuBBBfpBLAoqZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0dlb1RhcmdldENvbnN0YW50SAASZAoGZGV2",
            "aWNlGAkgASgOMk0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zLkZl",
            "ZWRJdGVtVGFyZ2V0RGV2aWNlRW51bS5GZWVkSXRlbVRhcmdldERldmljZUID",
            "4EEFSAASSwoLYWRfc2NoZWR1bGUYCiABKAsyLy5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAuY29tbW9uLkFkU2NoZWR1bGVJbmZvQgPgQQVIADqdAepBmQEK",
            "J2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9GZWVkSXRlbVRhcmdldBJuY3Vz",
            "dG9tZXJzL3tjdXN0b21lcl9pZH0vZmVlZEl0ZW1UYXJnZXRzL3tmZWVkX2lk",
            "fX57ZmVlZF9pdGVtX2lkfX57ZmVlZF9pdGVtX3RhcmdldF90eXBlfX57ZmVl",
            "ZF9pdGVtX3RhcmdldF9pZH1CCAoGdGFyZ2V0QgwKCl9mZWVkX2l0ZW1CFgoU",
            "X2ZlZWRfaXRlbV90YXJnZXRfaWRChQIKJmNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAucmVzb3VyY2VzQhNGZWVkSXRlbVRhcmdldFByb3RvUAFaS2dv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTAvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYxMC5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMTBcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6",
            "VjEwOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V10.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetDeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.FeedItemTarget), global::Google.Ads.GoogleAds.V10.Resources.FeedItemTarget.Parser, new[]{ "ResourceName", "FeedItem", "FeedItemTargetType", "FeedItemTargetId", "Status", "Campaign", "AdGroup", "Keyword", "GeoTargetConstant", "Device", "AdSchedule" }, new[]{ "Target", "FeedItem", "FeedItemTargetId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A feed item target.
  /// </summary>
  public sealed partial class FeedItemTarget : pb::IMessage<FeedItemTarget>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemTarget> _parser = new pb::MessageParser<FeedItemTarget>(() => new FeedItemTarget());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedItemTarget> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.FeedItemTargetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTarget() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTarget(FeedItemTarget other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      feedItem_ = other.feedItem_;
      feedItemTargetType_ = other.feedItemTargetType_;
      feedItemTargetId_ = other.feedItemTargetId_;
      status_ = other.status_;
      switch (other.TargetCase) {
        case TargetOneofCase.Campaign:
          Campaign = other.Campaign;
          break;
        case TargetOneofCase.AdGroup:
          AdGroup = other.AdGroup;
          break;
        case TargetOneofCase.Keyword:
          Keyword = other.Keyword.Clone();
          break;
        case TargetOneofCase.GeoTargetConstant:
          GeoTargetConstant = other.GeoTargetConstant;
          break;
        case TargetOneofCase.Device:
          Device = other.Device;
          break;
        case TargetOneofCase.AdSchedule:
          AdSchedule = other.AdSchedule.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTarget Clone() {
      return new FeedItemTarget(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the feed item target.
    /// Feed item target resource names have the form:
    /// `customers/{customer_id}/feedItemTargets/{feed_id}~{feed_item_id}~{feed_item_target_type}~{feed_item_target_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed_item" field.</summary>
    public const int FeedItemFieldNumber = 12;
    private string feedItem_;
    /// <summary>
    /// Immutable. The feed item to which this feed item target belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FeedItem {
      get { return feedItem_ ?? ""; }
      set {
        feedItem_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "feed_item" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFeedItem {
      get { return feedItem_ != null; }
    }
    /// <summary>Clears the value of the "feed_item" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFeedItem() {
      feedItem_ = null;
    }

    /// <summary>Field number for the "feed_item_target_type" field.</summary>
    public const int FeedItemTargetTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType feedItemTargetType_ = global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified;
    /// <summary>
    /// Output only. The target type of this feed item target. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType FeedItemTargetType {
      get { return feedItemTargetType_; }
      set {
        feedItemTargetType_ = value;
      }
    }

    /// <summary>Field number for the "feed_item_target_id" field.</summary>
    public const int FeedItemTargetIdFieldNumber = 13;
    private long feedItemTargetId_;
    /// <summary>
    /// Output only. The ID of the targeted resource. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FeedItemTargetId {
      get { if ((_hasBits0 & 1) != 0) { return feedItemTargetId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        feedItemTargetId_ = value;
      }
    }
    /// <summary>Gets whether the "feed_item_target_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasFeedItemTargetId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "feed_item_target_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearFeedItemTargetId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 11;
    private global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus status_ = global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified;
    /// <summary>
    /// Output only. Status of the feed item target.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 14;
    /// <summary>
    /// Immutable. The targeted campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return targetCase_ == TargetOneofCase.Campaign ? (string) target_ : ""; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        targetCase_ = TargetOneofCase.Campaign;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 15;
    /// <summary>
    /// Immutable. The targeted ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return targetCase_ == TargetOneofCase.AdGroup ? (string) target_ : ""; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        targetCase_ = TargetOneofCase.AdGroup;
      }
    }

    /// <summary>Field number for the "keyword" field.</summary>
    public const int KeywordFieldNumber = 7;
    /// <summary>
    /// Immutable. The targeted keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Common.KeywordInfo Keyword {
      get { return targetCase_ == TargetOneofCase.Keyword ? (global::Google.Ads.GoogleAds.V10.Common.KeywordInfo) target_ : null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.Keyword;
      }
    }

    /// <summary>Field number for the "geo_target_constant" field.</summary>
    public const int GeoTargetConstantFieldNumber = 16;
    /// <summary>
    /// Immutable. The targeted geo target constant resource name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GeoTargetConstant {
      get { return targetCase_ == TargetOneofCase.GeoTargetConstant ? (string) target_ : ""; }
      set {
        target_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        targetCase_ = TargetOneofCase.GeoTargetConstant;
      }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 9;
    /// <summary>
    /// Immutable. The targeted device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice Device {
      get { return targetCase_ == TargetOneofCase.Device ? (global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice) target_ : global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Unspecified; }
      set {
        target_ = value;
        targetCase_ = TargetOneofCase.Device;
      }
    }

    /// <summary>Field number for the "ad_schedule" field.</summary>
    public const int AdScheduleFieldNumber = 10;
    /// <summary>
    /// Immutable. The targeted schedule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo AdSchedule {
      get { return targetCase_ == TargetOneofCase.AdSchedule ? (global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo) target_ : null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.AdSchedule;
      }
    }

    private object target_;
    /// <summary>Enum of possible cases for the "target" oneof.</summary>
    public enum TargetOneofCase {
      None = 0,
      Campaign = 14,
      AdGroup = 15,
      Keyword = 7,
      GeoTargetConstant = 16,
      Device = 9,
      AdSchedule = 10,
    }
    private TargetOneofCase targetCase_ = TargetOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetOneofCase TargetCase {
      get { return targetCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTarget() {
      targetCase_ = TargetOneofCase.None;
      target_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedItemTarget);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedItemTarget other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (FeedItem != other.FeedItem) return false;
      if (FeedItemTargetType != other.FeedItemTargetType) return false;
      if (FeedItemTargetId != other.FeedItemTargetId) return false;
      if (Status != other.Status) return false;
      if (Campaign != other.Campaign) return false;
      if (AdGroup != other.AdGroup) return false;
      if (!object.Equals(Keyword, other.Keyword)) return false;
      if (GeoTargetConstant != other.GeoTargetConstant) return false;
      if (Device != other.Device) return false;
      if (!object.Equals(AdSchedule, other.AdSchedule)) return false;
      if (TargetCase != other.TargetCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasFeedItem) hash ^= FeedItem.GetHashCode();
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) hash ^= FeedItemTargetType.GetHashCode();
      if (HasFeedItemTargetId) hash ^= FeedItemTargetId.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified) hash ^= Status.GetHashCode();
      if (targetCase_ == TargetOneofCase.Campaign) hash ^= Campaign.GetHashCode();
      if (targetCase_ == TargetOneofCase.AdGroup) hash ^= AdGroup.GetHashCode();
      if (targetCase_ == TargetOneofCase.Keyword) hash ^= Keyword.GetHashCode();
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) hash ^= GeoTargetConstant.GetHashCode();
      if (targetCase_ == TargetOneofCase.Device) hash ^= Device.GetHashCode();
      if (targetCase_ == TargetOneofCase.AdSchedule) hash ^= AdSchedule.GetHashCode();
      hash ^= (int) targetCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FeedItemTargetType);
      }
      if (targetCase_ == TargetOneofCase.Keyword) {
        output.WriteRawTag(58);
        output.WriteMessage(Keyword);
      }
      if (targetCase_ == TargetOneofCase.Device) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Device);
      }
      if (targetCase_ == TargetOneofCase.AdSchedule) {
        output.WriteRawTag(82);
        output.WriteMessage(AdSchedule);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      if (HasFeedItem) {
        output.WriteRawTag(98);
        output.WriteString(FeedItem);
      }
      if (HasFeedItemTargetId) {
        output.WriteRawTag(104);
        output.WriteInt64(FeedItemTargetId);
      }
      if (targetCase_ == TargetOneofCase.Campaign) {
        output.WriteRawTag(114);
        output.WriteString(Campaign);
      }
      if (targetCase_ == TargetOneofCase.AdGroup) {
        output.WriteRawTag(122);
        output.WriteString(AdGroup);
      }
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) {
        output.WriteRawTag(130, 1);
        output.WriteString(GeoTargetConstant);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FeedItemTargetType);
      }
      if (targetCase_ == TargetOneofCase.Keyword) {
        output.WriteRawTag(58);
        output.WriteMessage(Keyword);
      }
      if (targetCase_ == TargetOneofCase.Device) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Device);
      }
      if (targetCase_ == TargetOneofCase.AdSchedule) {
        output.WriteRawTag(82);
        output.WriteMessage(AdSchedule);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Status);
      }
      if (HasFeedItem) {
        output.WriteRawTag(98);
        output.WriteString(FeedItem);
      }
      if (HasFeedItemTargetId) {
        output.WriteRawTag(104);
        output.WriteInt64(FeedItemTargetId);
      }
      if (targetCase_ == TargetOneofCase.Campaign) {
        output.WriteRawTag(114);
        output.WriteString(Campaign);
      }
      if (targetCase_ == TargetOneofCase.AdGroup) {
        output.WriteRawTag(122);
        output.WriteString(AdGroup);
      }
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) {
        output.WriteRawTag(130, 1);
        output.WriteString(GeoTargetConstant);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasFeedItem) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FeedItem);
      }
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FeedItemTargetType);
      }
      if (HasFeedItemTargetId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FeedItemTargetId);
      }
      if (Status != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (targetCase_ == TargetOneofCase.Campaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (targetCase_ == TargetOneofCase.AdGroup) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (targetCase_ == TargetOneofCase.Keyword) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Keyword);
      }
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(GeoTargetConstant);
      }
      if (targetCase_ == TargetOneofCase.Device) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Device);
      }
      if (targetCase_ == TargetOneofCase.AdSchedule) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdSchedule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedItemTarget other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasFeedItem) {
        FeedItem = other.FeedItem;
      }
      if (other.FeedItemTargetType != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        FeedItemTargetType = other.FeedItemTargetType;
      }
      if (other.HasFeedItemTargetId) {
        FeedItemTargetId = other.FeedItemTargetId;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus.Unspecified) {
        Status = other.Status;
      }
      switch (other.TargetCase) {
        case TargetOneofCase.Campaign:
          Campaign = other.Campaign;
          break;
        case TargetOneofCase.AdGroup:
          AdGroup = other.AdGroup;
          break;
        case TargetOneofCase.Keyword:
          if (Keyword == null) {
            Keyword = new global::Google.Ads.GoogleAds.V10.Common.KeywordInfo();
          }
          Keyword.MergeFrom(other.Keyword);
          break;
        case TargetOneofCase.GeoTargetConstant:
          GeoTargetConstant = other.GeoTargetConstant;
          break;
        case TargetOneofCase.Device:
          Device = other.Device;
          break;
        case TargetOneofCase.AdSchedule:
          if (AdSchedule == null) {
            AdSchedule = new global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo();
          }
          AdSchedule.MergeFrom(other.AdSchedule);
          break;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            FeedItemTargetType = (global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V10.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V10.Common.KeywordInfo();
            if (targetCase_ == TargetOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 72: {
            target_ = input.ReadEnum();
            targetCase_ = TargetOneofCase.Device;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo subBuilder = new global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo();
            if (targetCase_ == TargetOneofCase.AdSchedule) {
              subBuilder.MergeFrom(AdSchedule);
            }
            input.ReadMessage(subBuilder);
            AdSchedule = subBuilder;
            break;
          }
          case 88: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus) input.ReadEnum();
            break;
          }
          case 98: {
            FeedItem = input.ReadString();
            break;
          }
          case 104: {
            FeedItemTargetId = input.ReadInt64();
            break;
          }
          case 114: {
            Campaign = input.ReadString();
            break;
          }
          case 122: {
            AdGroup = input.ReadString();
            break;
          }
          case 130: {
            GeoTargetConstant = input.ReadString();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 24: {
            FeedItemTargetType = (global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V10.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V10.Common.KeywordInfo();
            if (targetCase_ == TargetOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 72: {
            target_ = input.ReadEnum();
            targetCase_ = TargetOneofCase.Device;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo subBuilder = new global::Google.Ads.GoogleAds.V10.Common.AdScheduleInfo();
            if (targetCase_ == TargetOneofCase.AdSchedule) {
              subBuilder.MergeFrom(AdSchedule);
            }
            input.ReadMessage(subBuilder);
            AdSchedule = subBuilder;
            break;
          }
          case 88: {
            Status = (global::Google.Ads.GoogleAds.V10.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus) input.ReadEnum();
            break;
          }
          case 98: {
            FeedItem = input.ReadString();
            break;
          }
          case 104: {
            FeedItemTargetId = input.ReadInt64();
            break;
          }
          case 114: {
            Campaign = input.ReadString();
            break;
          }
          case 122: {
            AdGroup = input.ReadString();
            break;
          }
          case 130: {
            GeoTargetConstant = input.ReadString();
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
