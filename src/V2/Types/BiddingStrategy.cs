// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/bidding_strategy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/bidding_strategy.proto</summary>
  public static partial class BiddingStrategyReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/bidding_strategy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingStrategyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvYmlkZGluZ19z",
            "dHJhdGVneS5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3Vy",
            "Y2VzGixnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9jb21tb24vYmlkZGluZy5w",
            "cm90bxo7Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIvZW51bXMvYmlkZGluZ19z",
            "dHJhdGVneV9zdGF0dXMucHJvdG8aOWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yy",
            "L2VudW1zL2JpZGRpbmdfc3RyYXRlZ3lfdHlwZS5wcm90bxofZ29vZ2xlL2Fw",
            "aS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5w",
            "cm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUv",
            "YXBpL2Fubm90YXRpb25zLnByb3RvIvYICg9CaWRkaW5nU3RyYXRlZ3kSRwoN",
            "cmVzb3VyY2VfbmFtZRgBIAEoCUIw4EEF+kEqCihnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQmlkZGluZ1N0cmF0ZWd5EiwKAmlkGAMgASgLMhsuZ29vZ2xl",
            "LnByb3RvYnVmLkludDY0VmFsdWVCA+BBAxIqCgRuYW1lGAQgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEmMKBnN0YXR1cxgPIAEoDjJOLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zLkJpZGRpbmdTdHJhdGVneVN0",
            "YXR1c0VudW0uQmlkZGluZ1N0cmF0ZWd5U3RhdHVzQgPgQQMSXQoEdHlwZRgF",
            "IAEoDjJKLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmVudW1zLkJpZGRpbmdT",
            "dHJhdGVneVR5cGVFbnVtLkJpZGRpbmdTdHJhdGVneVR5cGVCA+BBAxI4Cg5j",
            "YW1wYWlnbl9jb3VudBgNIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZh",
            "bHVlQgPgQQMSRAoabm9uX3JlbW92ZWRfY2FtcGFpZ25fY291bnQYDiABKAsy",
            "Gy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDEkMKDGVuaGFuY2Vk",
            "X2NwYxgHIAEoCzIrLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmNvbW1vbi5F",
            "bmhhbmNlZENwY0gAEkwKEXBhZ2Vfb25lX3Byb21vdGVkGAggASgLMi8uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIuY29tbW9uLlBhZ2VPbmVQcm9tb3RlZEgA",
            "Ej8KCnRhcmdldF9jcGEYCSABKAsyKS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "Mi5jb21tb24uVGFyZ2V0Q3BhSAASWAoXdGFyZ2V0X2ltcHJlc3Npb25fc2hh",
            "cmUYMCABKAsyNS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5jb21tb24uVGFy",
            "Z2V0SW1wcmVzc2lvblNoYXJlSAASUgoUdGFyZ2V0X291dHJhbmtfc2hhcmUY",
            "CiABKAsyMi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5jb21tb24uVGFyZ2V0",
            "T3V0cmFua1NoYXJlSAASQQoLdGFyZ2V0X3JvYXMYCyABKAsyKi5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52Mi5jb21tb24uVGFyZ2V0Um9hc0gAEkMKDHRhcmdl",
            "dF9zcGVuZBgMIAEoCzIrLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLmNvbW1v",
            "bi5UYXJnZXRTcGVuZEgAOmjqQWUKKGdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9CaWRkaW5nU3RyYXRlZ3kSOWN1c3RvbWVycy97Y3VzdG9tZXJ9L2JpZGRp",
            "bmdTdHJhdGVnaWVzL3tiaWRkaW5nX3N0cmF0ZWd5fUIICgZzY2hlbWVCgQIK",
            "JWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNvdXJjZXNCFEJpZGRp",
            "bmdTdHJhdGVneVByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXM7cmVzb3Vy",
            "Y2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuUmVzb3VyY2Vz",
            "ygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjJcUmVzb3VyY2Vz6gIlR29vZ2xl",
            "OjpBZHM6Okdvb2dsZUFkczo6VjI6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Common.BiddingReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.BiddingStrategy), global::Google.Ads.GoogleAds.V2.Resources.BiddingStrategy.Parser, new[]{ "ResourceName", "Id", "Name", "Status", "Type", "CampaignCount", "NonRemovedCampaignCount", "EnhancedCpc", "PageOnePromoted", "TargetCpa", "TargetImpressionShare", "TargetOutrankShare", "TargetRoas", "TargetSpend" }, new[]{ "Scheme" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A bidding strategy.
  /// </summary>
  public sealed partial class BiddingStrategy : pb::IMessage<BiddingStrategy> {
    private static readonly pb::MessageParser<BiddingStrategy> _parser = new pb::MessageParser<BiddingStrategy>(() => new BiddingStrategy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingStrategy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.BiddingStrategyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategy(BiddingStrategy other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      status_ = other.status_;
      type_ = other.type_;
      CampaignCount = other.CampaignCount;
      NonRemovedCampaignCount = other.NonRemovedCampaignCount;
      switch (other.SchemeCase) {
        case SchemeOneofCase.EnhancedCpc:
          EnhancedCpc = other.EnhancedCpc.Clone();
          break;
        case SchemeOneofCase.PageOnePromoted:
          PageOnePromoted = other.PageOnePromoted.Clone();
          break;
        case SchemeOneofCase.TargetCpa:
          TargetCpa = other.TargetCpa.Clone();
          break;
        case SchemeOneofCase.TargetImpressionShare:
          TargetImpressionShare = other.TargetImpressionShare.Clone();
          break;
        case SchemeOneofCase.TargetOutrankShare:
          TargetOutrankShare = other.TargetOutrankShare.Clone();
          break;
        case SchemeOneofCase.TargetRoas:
          TargetRoas = other.TargetRoas.Clone();
          break;
        case SchemeOneofCase.TargetSpend:
          TargetSpend = other.TargetSpend.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategy Clone() {
      return new BiddingStrategy(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the bidding strategy.
    /// Bidding strategy resource names have the form:
    ///
    /// `customers/{customer_id}/biddingStrategies/{bidding_strategy_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the bidding strategy.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// The name of the bidding strategy.
    /// All bidding strategies within an account must be named distinctly.
    ///
    /// The length of this string should be between 1 and 255, inclusive,
    /// in UTF-8 bytes, (trimmed).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 15;
    private global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus status_ = global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the bidding strategy.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType type_ = global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType.Unspecified;
    /// <summary>
    /// Output only. The type of the bidding strategy.
    /// Create a bidding strategy by setting the bidding scheme.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "campaign_count" field.</summary>
    public const int CampaignCountFieldNumber = 13;
    private static readonly pb::FieldCodec<long?> _single_campaignCount_codec = pb::FieldCodec.ForStructWrapper<long>(106);
    private long? campaignCount_;
    /// <summary>
    /// Output only. The number of campaigns attached to this bidding strategy.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CampaignCount {
      get { return campaignCount_; }
      set {
        campaignCount_ = value;
      }
    }


    /// <summary>Field number for the "non_removed_campaign_count" field.</summary>
    public const int NonRemovedCampaignCountFieldNumber = 14;
    private static readonly pb::FieldCodec<long?> _single_nonRemovedCampaignCount_codec = pb::FieldCodec.ForStructWrapper<long>(114);
    private long? nonRemovedCampaignCount_;
    /// <summary>
    /// Output only. The number of non-removed campaigns attached to this bidding strategy.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? NonRemovedCampaignCount {
      get { return nonRemovedCampaignCount_; }
      set {
        nonRemovedCampaignCount_ = value;
      }
    }


    /// <summary>Field number for the "enhanced_cpc" field.</summary>
    public const int EnhancedCpcFieldNumber = 7;
    /// <summary>
    /// A bidding strategy that raises bids for clicks that seem more likely to
    /// lead to a conversion and lowers them for clicks where they seem less
    /// likely.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.EnhancedCpc EnhancedCpc {
      get { return schemeCase_ == SchemeOneofCase.EnhancedCpc ? (global::Google.Ads.GoogleAds.V2.Common.EnhancedCpc) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.EnhancedCpc;
      }
    }

    /// <summary>Field number for the "page_one_promoted" field.</summary>
    public const int PageOnePromotedFieldNumber = 8;
    /// <summary>
    /// A bidding strategy that sets max CPC bids to target impressions on
    /// page one or page one promoted slots on google.com.
    /// This field is deprecated. Creating a new bidding strategy with this
    /// field or attaching bidding strategies with this field to a campaign will
    /// fail. Mutates to strategies that already have this scheme populated are
    /// allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.PageOnePromoted PageOnePromoted {
      get { return schemeCase_ == SchemeOneofCase.PageOnePromoted ? (global::Google.Ads.GoogleAds.V2.Common.PageOnePromoted) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.PageOnePromoted;
      }
    }

    /// <summary>Field number for the "target_cpa" field.</summary>
    public const int TargetCpaFieldNumber = 9;
    /// <summary>
    /// A bidding strategy that sets bids to help get as many conversions as
    /// possible at the target cost-per-acquisition (CPA) you set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.TargetCpa TargetCpa {
      get { return schemeCase_ == SchemeOneofCase.TargetCpa ? (global::Google.Ads.GoogleAds.V2.Common.TargetCpa) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.TargetCpa;
      }
    }

    /// <summary>Field number for the "target_impression_share" field.</summary>
    public const int TargetImpressionShareFieldNumber = 48;
    /// <summary>
    /// A bidding strategy that automatically optimizes towards a desired
    /// percentage of impressions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.TargetImpressionShare TargetImpressionShare {
      get { return schemeCase_ == SchemeOneofCase.TargetImpressionShare ? (global::Google.Ads.GoogleAds.V2.Common.TargetImpressionShare) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.TargetImpressionShare;
      }
    }

    /// <summary>Field number for the "target_outrank_share" field.</summary>
    public const int TargetOutrankShareFieldNumber = 10;
    /// <summary>
    /// A bidding strategy that sets bids based on the target fraction of
    /// auctions where the advertiser should outrank a specific competitor.
    /// This field is deprecated. Creating a new bidding strategy with this
    /// field or attaching bidding strategies with this field to a campaign will
    /// fail. Mutates to strategies that already have this scheme populated are
    /// allowed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.TargetOutrankShare TargetOutrankShare {
      get { return schemeCase_ == SchemeOneofCase.TargetOutrankShare ? (global::Google.Ads.GoogleAds.V2.Common.TargetOutrankShare) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.TargetOutrankShare;
      }
    }

    /// <summary>Field number for the "target_roas" field.</summary>
    public const int TargetRoasFieldNumber = 11;
    /// <summary>
    /// A bidding strategy that helps you maximize revenue while averaging a
    /// specific target Return On Ad Spend (ROAS).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.TargetRoas TargetRoas {
      get { return schemeCase_ == SchemeOneofCase.TargetRoas ? (global::Google.Ads.GoogleAds.V2.Common.TargetRoas) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.TargetRoas;
      }
    }

    /// <summary>Field number for the "target_spend" field.</summary>
    public const int TargetSpendFieldNumber = 12;
    /// <summary>
    /// A bid strategy that sets your bids to help get as many clicks as
    /// possible within your budget.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Common.TargetSpend TargetSpend {
      get { return schemeCase_ == SchemeOneofCase.TargetSpend ? (global::Google.Ads.GoogleAds.V2.Common.TargetSpend) scheme_ : null; }
      set {
        scheme_ = value;
        schemeCase_ = value == null ? SchemeOneofCase.None : SchemeOneofCase.TargetSpend;
      }
    }

    private object scheme_;
    /// <summary>Enum of possible cases for the "scheme" oneof.</summary>
    public enum SchemeOneofCase {
      None = 0,
      EnhancedCpc = 7,
      PageOnePromoted = 8,
      TargetCpa = 9,
      TargetImpressionShare = 48,
      TargetOutrankShare = 10,
      TargetRoas = 11,
      TargetSpend = 12,
    }
    private SchemeOneofCase schemeCase_ = SchemeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SchemeOneofCase SchemeCase {
      get { return schemeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearScheme() {
      schemeCase_ = SchemeOneofCase.None;
      scheme_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BiddingStrategy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BiddingStrategy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (Status != other.Status) return false;
      if (Type != other.Type) return false;
      if (CampaignCount != other.CampaignCount) return false;
      if (NonRemovedCampaignCount != other.NonRemovedCampaignCount) return false;
      if (!object.Equals(EnhancedCpc, other.EnhancedCpc)) return false;
      if (!object.Equals(PageOnePromoted, other.PageOnePromoted)) return false;
      if (!object.Equals(TargetCpa, other.TargetCpa)) return false;
      if (!object.Equals(TargetImpressionShare, other.TargetImpressionShare)) return false;
      if (!object.Equals(TargetOutrankShare, other.TargetOutrankShare)) return false;
      if (!object.Equals(TargetRoas, other.TargetRoas)) return false;
      if (!object.Equals(TargetSpend, other.TargetSpend)) return false;
      if (SchemeCase != other.SchemeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Unspecified) hash ^= Status.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType.Unspecified) hash ^= Type.GetHashCode();
      if (campaignCount_ != null) hash ^= CampaignCount.GetHashCode();
      if (nonRemovedCampaignCount_ != null) hash ^= NonRemovedCampaignCount.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.EnhancedCpc) hash ^= EnhancedCpc.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.PageOnePromoted) hash ^= PageOnePromoted.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.TargetCpa) hash ^= TargetCpa.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.TargetImpressionShare) hash ^= TargetImpressionShare.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.TargetOutrankShare) hash ^= TargetOutrankShare.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.TargetRoas) hash ^= TargetRoas.GetHashCode();
      if (schemeCase_ == SchemeOneofCase.TargetSpend) hash ^= TargetSpend.GetHashCode();
      hash ^= (int) schemeCase_;
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
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Type);
      }
      if (schemeCase_ == SchemeOneofCase.EnhancedCpc) {
        output.WriteRawTag(58);
        output.WriteMessage(EnhancedCpc);
      }
      if (schemeCase_ == SchemeOneofCase.PageOnePromoted) {
        output.WriteRawTag(66);
        output.WriteMessage(PageOnePromoted);
      }
      if (schemeCase_ == SchemeOneofCase.TargetCpa) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetCpa);
      }
      if (schemeCase_ == SchemeOneofCase.TargetOutrankShare) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetOutrankShare);
      }
      if (schemeCase_ == SchemeOneofCase.TargetRoas) {
        output.WriteRawTag(90);
        output.WriteMessage(TargetRoas);
      }
      if (schemeCase_ == SchemeOneofCase.TargetSpend) {
        output.WriteRawTag(98);
        output.WriteMessage(TargetSpend);
      }
      if (campaignCount_ != null) {
        _single_campaignCount_codec.WriteTagAndValue(output, CampaignCount);
      }
      if (nonRemovedCampaignCount_ != null) {
        _single_nonRemovedCampaignCount_codec.WriteTagAndValue(output, NonRemovedCampaignCount);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Unspecified) {
        output.WriteRawTag(120);
        output.WriteEnum((int) Status);
      }
      if (schemeCase_ == SchemeOneofCase.TargetImpressionShare) {
        output.WriteRawTag(130, 3);
        output.WriteMessage(TargetImpressionShare);
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
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (campaignCount_ != null) {
        size += _single_campaignCount_codec.CalculateSizeWithTag(CampaignCount);
      }
      if (nonRemovedCampaignCount_ != null) {
        size += _single_nonRemovedCampaignCount_codec.CalculateSizeWithTag(NonRemovedCampaignCount);
      }
      if (schemeCase_ == SchemeOneofCase.EnhancedCpc) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EnhancedCpc);
      }
      if (schemeCase_ == SchemeOneofCase.PageOnePromoted) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PageOnePromoted);
      }
      if (schemeCase_ == SchemeOneofCase.TargetCpa) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpa);
      }
      if (schemeCase_ == SchemeOneofCase.TargetImpressionShare) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(TargetImpressionShare);
      }
      if (schemeCase_ == SchemeOneofCase.TargetOutrankShare) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetOutrankShare);
      }
      if (schemeCase_ == SchemeOneofCase.TargetRoas) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetRoas);
      }
      if (schemeCase_ == SchemeOneofCase.TargetSpend) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetSpend);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BiddingStrategy other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType.Unspecified) {
        Type = other.Type;
      }
      if (other.campaignCount_ != null) {
        if (campaignCount_ == null || other.CampaignCount != 0L) {
          CampaignCount = other.CampaignCount;
        }
      }
      if (other.nonRemovedCampaignCount_ != null) {
        if (nonRemovedCampaignCount_ == null || other.NonRemovedCampaignCount != 0L) {
          NonRemovedCampaignCount = other.NonRemovedCampaignCount;
        }
      }
      switch (other.SchemeCase) {
        case SchemeOneofCase.EnhancedCpc:
          if (EnhancedCpc == null) {
            EnhancedCpc = new global::Google.Ads.GoogleAds.V2.Common.EnhancedCpc();
          }
          EnhancedCpc.MergeFrom(other.EnhancedCpc);
          break;
        case SchemeOneofCase.PageOnePromoted:
          if (PageOnePromoted == null) {
            PageOnePromoted = new global::Google.Ads.GoogleAds.V2.Common.PageOnePromoted();
          }
          PageOnePromoted.MergeFrom(other.PageOnePromoted);
          break;
        case SchemeOneofCase.TargetCpa:
          if (TargetCpa == null) {
            TargetCpa = new global::Google.Ads.GoogleAds.V2.Common.TargetCpa();
          }
          TargetCpa.MergeFrom(other.TargetCpa);
          break;
        case SchemeOneofCase.TargetImpressionShare:
          if (TargetImpressionShare == null) {
            TargetImpressionShare = new global::Google.Ads.GoogleAds.V2.Common.TargetImpressionShare();
          }
          TargetImpressionShare.MergeFrom(other.TargetImpressionShare);
          break;
        case SchemeOneofCase.TargetOutrankShare:
          if (TargetOutrankShare == null) {
            TargetOutrankShare = new global::Google.Ads.GoogleAds.V2.Common.TargetOutrankShare();
          }
          TargetOutrankShare.MergeFrom(other.TargetOutrankShare);
          break;
        case SchemeOneofCase.TargetRoas:
          if (TargetRoas == null) {
            TargetRoas = new global::Google.Ads.GoogleAds.V2.Common.TargetRoas();
          }
          TargetRoas.MergeFrom(other.TargetRoas);
          break;
        case SchemeOneofCase.TargetSpend:
          if (TargetSpend == null) {
            TargetSpend = new global::Google.Ads.GoogleAds.V2.Common.TargetSpend();
          }
          TargetSpend.MergeFrom(other.TargetSpend);
          break;
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
          case 26: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 40: {
            Type = (global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyTypeEnum.Types.BiddingStrategyType) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V2.Common.EnhancedCpc subBuilder = new global::Google.Ads.GoogleAds.V2.Common.EnhancedCpc();
            if (schemeCase_ == SchemeOneofCase.EnhancedCpc) {
              subBuilder.MergeFrom(EnhancedCpc);
            }
            input.ReadMessage(subBuilder);
            EnhancedCpc = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V2.Common.PageOnePromoted subBuilder = new global::Google.Ads.GoogleAds.V2.Common.PageOnePromoted();
            if (schemeCase_ == SchemeOneofCase.PageOnePromoted) {
              subBuilder.MergeFrom(PageOnePromoted);
            }
            input.ReadMessage(subBuilder);
            PageOnePromoted = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V2.Common.TargetCpa subBuilder = new global::Google.Ads.GoogleAds.V2.Common.TargetCpa();
            if (schemeCase_ == SchemeOneofCase.TargetCpa) {
              subBuilder.MergeFrom(TargetCpa);
            }
            input.ReadMessage(subBuilder);
            TargetCpa = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V2.Common.TargetOutrankShare subBuilder = new global::Google.Ads.GoogleAds.V2.Common.TargetOutrankShare();
            if (schemeCase_ == SchemeOneofCase.TargetOutrankShare) {
              subBuilder.MergeFrom(TargetOutrankShare);
            }
            input.ReadMessage(subBuilder);
            TargetOutrankShare = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V2.Common.TargetRoas subBuilder = new global::Google.Ads.GoogleAds.V2.Common.TargetRoas();
            if (schemeCase_ == SchemeOneofCase.TargetRoas) {
              subBuilder.MergeFrom(TargetRoas);
            }
            input.ReadMessage(subBuilder);
            TargetRoas = subBuilder;
            break;
          }
          case 98: {
            global::Google.Ads.GoogleAds.V2.Common.TargetSpend subBuilder = new global::Google.Ads.GoogleAds.V2.Common.TargetSpend();
            if (schemeCase_ == SchemeOneofCase.TargetSpend) {
              subBuilder.MergeFrom(TargetSpend);
            }
            input.ReadMessage(subBuilder);
            TargetSpend = subBuilder;
            break;
          }
          case 106: {
            long? value = _single_campaignCount_codec.Read(input);
            if (campaignCount_ == null || value != 0L) {
              CampaignCount = value;
            }
            break;
          }
          case 114: {
            long? value = _single_nonRemovedCampaignCount_codec.Read(input);
            if (nonRemovedCampaignCount_ == null || value != 0L) {
              NonRemovedCampaignCount = value;
            }
            break;
          }
          case 120: {
            Status = (global::Google.Ads.GoogleAds.V2.Enums.BiddingStrategyStatusEnum.Types.BiddingStrategyStatus) input.ReadEnum();
            break;
          }
          case 386: {
            global::Google.Ads.GoogleAds.V2.Common.TargetImpressionShare subBuilder = new global::Google.Ads.GoogleAds.V2.Common.TargetImpressionShare();
            if (schemeCase_ == SchemeOneofCase.TargetImpressionShare) {
              subBuilder.MergeFrom(TargetImpressionShare);
            }
            input.ReadMessage(subBuilder);
            TargetImpressionShare = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
