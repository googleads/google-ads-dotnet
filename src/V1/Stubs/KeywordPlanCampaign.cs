// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/keyword_plan_campaign.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/keyword_plan_campaign.proto</summary>
  public static partial class KeywordPlanCampaignReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/keyword_plan_campaign.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCampaignReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMva2V5d29yZF9w",
            "bGFuX2NhbXBhaWduLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52MS5y",
            "ZXNvdXJjZXMaOGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2VudW1zL2tleXdv",
            "cmRfcGxhbl9uZXR3b3JrLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBl",
            "cnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i2gMKE0tl",
            "eXdvcmRQbGFuQ2FtcGFpZ24SFQoNcmVzb3VyY2VfbmFtZRgBIAEoCRIyCgxr",
            "ZXl3b3JkX3BsYW4YAiABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWUSJwoCaWQYAyABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZRIq",
            "CgRuYW1lGAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEjgK",
            "Emxhbmd1YWdlX2NvbnN0YW50cxgFIAMoCzIcLmdvb2dsZS5wcm90b2J1Zi5T",
            "dHJpbmdWYWx1ZRJmChRrZXl3b3JkX3BsYW5fbmV0d29yaxgGIAEoDjJILmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVudW1zLktleXdvcmRQbGFuTmV0d29y",
            "a0VudW0uS2V5d29yZFBsYW5OZXR3b3JrEjMKDmNwY19iaWRfbWljcm9zGAcg",
            "ASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWUSTAoLZ2VvX3Rhcmdl",
            "dHMYCCADKAsyNy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5yZXNvdXJjZXMu",
            "S2V5d29yZFBsYW5HZW9UYXJnZXQiUQoUS2V5d29yZFBsYW5HZW9UYXJnZXQS",
            "OQoTZ2VvX3RhcmdldF9jb25zdGFudBgBIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZUKFAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "LnJlc291cmNlc0IYS2V5d29yZFBsYW5DYW1wYWlnblByb3RvUAFaSmdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjEuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjFcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanNetworkReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanCampaign), global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanCampaign.Parser, new[]{ "ResourceName", "KeywordPlan", "Id", "Name", "LanguageConstants", "KeywordPlanNetwork", "CpcBidMicros", "GeoTargets" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget), global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget.Parser, new[]{ "GeoTargetConstant" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Plan campaign.
  /// Max number of keyword plan campaigns per plan allowed: 1.
  /// </summary>
  public sealed partial class KeywordPlanCampaign : pb::IMessage<KeywordPlanCampaign> {
    private static readonly pb::MessageParser<KeywordPlanCampaign> _parser = new pb::MessageParser<KeywordPlanCampaign>(() => new KeywordPlanCampaign());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanCampaign> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanCampaignReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaign() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaign(KeywordPlanCampaign other) : this() {
      resourceName_ = other.resourceName_;
      KeywordPlan = other.KeywordPlan;
      Id = other.Id;
      Name = other.Name;
      languageConstants_ = other.languageConstants_.Clone();
      keywordPlanNetwork_ = other.keywordPlanNetwork_;
      CpcBidMicros = other.CpcBidMicros;
      geoTargets_ = other.geoTargets_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanCampaign Clone() {
      return new KeywordPlanCampaign(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the Keyword Plan campaign.
    /// KeywordPlanCampaign resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlanCampaigns/{kp_campaign_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_plan" field.</summary>
    public const int KeywordPlanFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_keywordPlan_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string keywordPlan_;
    /// <summary>
    /// The keyword plan this campaign belongs to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeywordPlan {
      get { return keywordPlan_; }
      set {
        keywordPlan_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// The ID of the Keyword Plan campaign.
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
    /// The name of the Keyword Plan campaign.
    ///
    /// This field is required and should not be empty when creating Keyword Plan
    /// campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }

    /// <summary>Field number for the "language_constants" field.</summary>
    public const int LanguageConstantsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_languageConstants_codec
        = pb::FieldCodec.ForClassWrapper<string>(42);
    private readonly pbc::RepeatedField<string> languageConstants_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The languages targeted for the Keyword Plan campaign.
    /// Max allowed: 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> LanguageConstants {
      get { return languageConstants_; }
    }

    /// <summary>Field number for the "keyword_plan_network" field.</summary>
    public const int KeywordPlanNetworkFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork_ = 0;
    /// <summary>
    /// Targeting network.
    ///
    /// This field is required and should not be empty when creating Keyword Plan
    /// campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanNetworkEnum.Types.KeywordPlanNetwork KeywordPlanNetwork {
      get { return keywordPlanNetwork_; }
      set {
        keywordPlanNetwork_ = value;
      }
    }

    /// <summary>Field number for the "cpc_bid_micros" field.</summary>
    public const int CpcBidMicrosFieldNumber = 7;
    private static readonly pb::FieldCodec<long?> _single_cpcBidMicros_codec = pb::FieldCodec.ForStructWrapper<long>(58);
    private long? cpcBidMicros_;
    /// <summary>
    /// A default max cpc bid in micros, and in the account currency, for all ad
    /// groups under the campaign.
    ///
    /// This field is required and should not be empty when creating Keyword Plan
    /// campaigns.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CpcBidMicros {
      get { return cpcBidMicros_; }
      set {
        cpcBidMicros_ = value;
      }
    }

    /// <summary>Field number for the "geo_targets" field.</summary>
    public const int GeoTargetsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget> _repeated_geoTargets_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget> geoTargets_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget>();
    /// <summary>
    /// The geo targets.
    /// Max number allowed: 20.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanGeoTarget> GeoTargets {
      get { return geoTargets_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanCampaign);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanCampaign other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (KeywordPlan != other.KeywordPlan) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!languageConstants_.Equals(other.languageConstants_)) return false;
      if (KeywordPlanNetwork != other.KeywordPlanNetwork) return false;
      if (CpcBidMicros != other.CpcBidMicros) return false;
      if(!geoTargets_.Equals(other.geoTargets_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (keywordPlan_ != null) hash ^= KeywordPlan.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      hash ^= languageConstants_.GetHashCode();
      if (KeywordPlanNetwork != 0) hash ^= KeywordPlanNetwork.GetHashCode();
      if (cpcBidMicros_ != null) hash ^= CpcBidMicros.GetHashCode();
      hash ^= geoTargets_.GetHashCode();
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
      if (keywordPlan_ != null) {
        _single_keywordPlan_codec.WriteTagAndValue(output, KeywordPlan);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      languageConstants_.WriteTo(output, _repeated_languageConstants_codec);
      if (KeywordPlanNetwork != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) KeywordPlanNetwork);
      }
      if (cpcBidMicros_ != null) {
        _single_cpcBidMicros_codec.WriteTagAndValue(output, CpcBidMicros);
      }
      geoTargets_.WriteTo(output, _repeated_geoTargets_codec);
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
      if (keywordPlan_ != null) {
        size += _single_keywordPlan_codec.CalculateSizeWithTag(KeywordPlan);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      size += languageConstants_.CalculateSize(_repeated_languageConstants_codec);
      if (KeywordPlanNetwork != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) KeywordPlanNetwork);
      }
      if (cpcBidMicros_ != null) {
        size += _single_cpcBidMicros_codec.CalculateSizeWithTag(CpcBidMicros);
      }
      size += geoTargets_.CalculateSize(_repeated_geoTargets_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanCampaign other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.keywordPlan_ != null) {
        if (keywordPlan_ == null || other.KeywordPlan != "") {
          KeywordPlan = other.KeywordPlan;
        }
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
      languageConstants_.Add(other.languageConstants_);
      if (other.KeywordPlanNetwork != 0) {
        KeywordPlanNetwork = other.KeywordPlanNetwork;
      }
      if (other.cpcBidMicros_ != null) {
        if (cpcBidMicros_ == null || other.CpcBidMicros != 0L) {
          CpcBidMicros = other.CpcBidMicros;
        }
      }
      geoTargets_.Add(other.geoTargets_);
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
          case 18: {
            string value = _single_keywordPlan_codec.Read(input);
            if (keywordPlan_ == null || value != "") {
              KeywordPlan = value;
            }
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
          case 42: {
            languageConstants_.AddEntriesFrom(input, _repeated_languageConstants_codec);
            break;
          }
          case 48: {
            keywordPlanNetwork_ = (global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanNetworkEnum.Types.KeywordPlanNetwork) input.ReadEnum();
            break;
          }
          case 58: {
            long? value = _single_cpcBidMicros_codec.Read(input);
            if (cpcBidMicros_ == null || value != 0L) {
              CpcBidMicros = value;
            }
            break;
          }
          case 66: {
            geoTargets_.AddEntriesFrom(input, _repeated_geoTargets_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A geo target.
  /// Next ID: 3
  /// </summary>
  public sealed partial class KeywordPlanGeoTarget : pb::IMessage<KeywordPlanGeoTarget> {
    private static readonly pb::MessageParser<KeywordPlanGeoTarget> _parser = new pb::MessageParser<KeywordPlanGeoTarget>(() => new KeywordPlanGeoTarget());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanGeoTarget> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.KeywordPlanCampaignReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanGeoTarget() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanGeoTarget(KeywordPlanGeoTarget other) : this() {
      GeoTargetConstant = other.GeoTargetConstant;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanGeoTarget Clone() {
      return new KeywordPlanGeoTarget(this);
    }

    /// <summary>Field number for the "geo_target_constant" field.</summary>
    public const int GeoTargetConstantFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_geoTargetConstant_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string geoTargetConstant_;
    /// <summary>
    /// Required. The resource name of the geo target.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GeoTargetConstant {
      get { return geoTargetConstant_; }
      set {
        geoTargetConstant_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanGeoTarget);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanGeoTarget other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (GeoTargetConstant != other.GeoTargetConstant) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (geoTargetConstant_ != null) hash ^= GeoTargetConstant.GetHashCode();
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
      if (geoTargetConstant_ != null) {
        _single_geoTargetConstant_codec.WriteTagAndValue(output, GeoTargetConstant);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (geoTargetConstant_ != null) {
        size += _single_geoTargetConstant_codec.CalculateSizeWithTag(GeoTargetConstant);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanGeoTarget other) {
      if (other == null) {
        return;
      }
      if (other.geoTargetConstant_ != null) {
        if (geoTargetConstant_ == null || other.GeoTargetConstant != "") {
          GeoTargetConstant = other.GeoTargetConstant;
        }
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
            string value = _single_geoTargetConstant_codec.Read(input);
            if (geoTargetConstant_ == null || value != "") {
              GeoTargetConstant = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
