// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/resources/asset_group.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/resources/asset_group.proto</summary>
  public static partial class AssetGroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/resources/asset_group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetGroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvcmVzb3VyY2VzL2Fzc2V0X2dy",
            "b3VwLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTkucmVzb3VyY2Vz",
            "GjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvYWRfc3RyZW5ndGgu",
            "cHJvdG8aP2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxOS9lbnVtcy9hc3NldF9n",
            "cm91cF9wcmltYXJ5X3N0YXR1cy5wcm90bxpGZ29vZ2xlL2Fkcy9nb29nbGVh",
            "ZHMvdjE5L2VudW1zL2Fzc2V0X2dyb3VwX3ByaW1hcnlfc3RhdHVzX3JlYXNv",
            "bi5wcm90bxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE5L2VudW1zL2Fzc2V0",
            "X2dyb3VwX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKDBgoKQXNzZXRH",
            "cm91cBJCCg1yZXNvdXJjZV9uYW1lGAEgASgJQivgQQX6QSUKI2dvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9Bc3NldEdyb3VwEg8KAmlkGAkgASgDQgPgQQMS",
            "OwoIY2FtcGFpZ24YAiABKAlCKeBBBfpBIwohZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0NhbXBhaWduEhEKBG5hbWUYAyABKAlCA+BBAhISCgpmaW5hbF91",
            "cmxzGAQgAygJEhkKEWZpbmFsX21vYmlsZV91cmxzGAUgAygJElUKBnN0YXR1",
            "cxgGIAEoDjJFLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lbnVtcy5Bc3Nl",
            "dEdyb3VwU3RhdHVzRW51bS5Bc3NldEdyb3VwU3RhdHVzEnAKDnByaW1hcnlf",
            "c3RhdHVzGAsgASgOMlMuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5LmVudW1z",
            "LkFzc2V0R3JvdXBQcmltYXJ5U3RhdHVzRW51bS5Bc3NldEdyb3VwUHJpbWFy",
            "eVN0YXR1c0ID4EEDEoQBChZwcmltYXJ5X3N0YXR1c19yZWFzb25zGAwgAygO",
            "Ml8uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5LmVudW1zLkFzc2V0R3JvdXBQ",
            "cmltYXJ5U3RhdHVzUmVhc29uRW51bS5Bc3NldEdyb3VwUHJpbWFyeVN0YXR1",
            "c1JlYXNvbkID4EEDEg0KBXBhdGgxGAcgASgJEg0KBXBhdGgyGAggASgJElMK",
            "C2FkX3N0cmVuZ3RoGAogASgOMjkuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5",
            "LmVudW1zLkFkU3RyZW5ndGhFbnVtLkFkU3RyZW5ndGhCA+BBAzpe6kFbCiNn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQXNzZXRHcm91cBI0Y3VzdG9tZXJz",
            "L3tjdXN0b21lcl9pZH0vYXNzZXRHcm91cHMve2Fzc2V0X2dyb3VwX2lkfUKB",
            "AgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5yZXNvdXJjZXNCD0Fz",
            "c2V0R3JvdXBQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE5L3Jlc291cmNlcztyZXNvdXJj",
            "ZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTkuUmVzb3VyY2Vz",
            "ygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE5XFJlc291cmNlc+oCJkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V19.Enums.AdStrengthReflection.Descriptor, global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonReflection.Descriptor, global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Resources.AssetGroup), global::Google.Ads.GoogleAds.V19.Resources.AssetGroup.Parser, new[]{ "ResourceName", "Id", "Campaign", "Name", "FinalUrls", "FinalMobileUrls", "Status", "PrimaryStatus", "PrimaryStatusReasons", "Path1", "Path2", "AdStrength" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An asset group.
  /// AssetGroupAsset is used to link an asset to the asset group.
  /// AssetGroupSignal is used to associate a signal to an asset group.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AssetGroup : pb::IMessage<AssetGroup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetGroup> _parser = new pb::MessageParser<AssetGroup>(() => new AssetGroup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetGroup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Resources.AssetGroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup(AssetGroup other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      campaign_ = other.campaign_;
      name_ = other.name_;
      finalUrls_ = other.finalUrls_.Clone();
      finalMobileUrls_ = other.finalMobileUrls_.Clone();
      status_ = other.status_;
      primaryStatus_ = other.primaryStatus_;
      primaryStatusReasons_ = other.primaryStatusReasons_.Clone();
      path1_ = other.path1_;
      path2_ = other.path2_;
      adStrength_ = other.adStrength_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetGroup Clone() {
      return new AssetGroup(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the asset group.
    /// Asset group resource names have the form:
    ///
    /// `customers/{customer_id}/assetGroups/{asset_group_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 9;
    private long id_;
    /// <summary>
    /// Output only. The ID of the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign with which this asset group is associated.
    /// The asset which is linked to the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    /// <summary>
    /// Required. Name of the asset group. Required. It must have a minimum length
    /// of 1 and maximum length of 128. It must be unique under a campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "final_urls" field.</summary>
    public const int FinalUrlsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_finalUrls_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> finalUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of final URLs after all cross domain redirects. In performance max,
    /// by default, the urls are eligible for expansion unless opted out.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalUrls {
      get { return finalUrls_; }
    }

    /// <summary>Field number for the "final_mobile_urls" field.</summary>
    public const int FinalMobileUrlsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_finalMobileUrls_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> finalMobileUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of final mobile URLs after all cross domain redirects. In
    /// performance max, by default, the urls are eligible for expansion
    /// unless opted out.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalMobileUrls {
      get { return finalMobileUrls_; }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus status_ = global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified;
    /// <summary>
    /// The status of the asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "primary_status" field.</summary>
    public const int PrimaryStatusFieldNumber = 11;
    private global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus primaryStatus_ = global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified;
    /// <summary>
    /// Output only. The primary status of the asset group. Provides insights into
    /// why an asset group is not serving or not serving optimally.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus PrimaryStatus {
      get { return primaryStatus_; }
      set {
        primaryStatus_ = value;
      }
    }

    /// <summary>Field number for the "primary_status_reasons" field.</summary>
    public const int PrimaryStatusReasonsFieldNumber = 12;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonEnum.Types.AssetGroupPrimaryStatusReason> _repeated_primaryStatusReasons_codec
        = pb::FieldCodec.ForEnum(98, x => (int) x, x => (global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonEnum.Types.AssetGroupPrimaryStatusReason) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonEnum.Types.AssetGroupPrimaryStatusReason> primaryStatusReasons_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonEnum.Types.AssetGroupPrimaryStatusReason>();
    /// <summary>
    /// Output only. Provides reasons into why an asset group is not serving or not
    /// serving optimally. It will be empty when the asset group is serving without
    /// issues.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusReasonEnum.Types.AssetGroupPrimaryStatusReason> PrimaryStatusReasons {
      get { return primaryStatusReasons_; }
    }

    /// <summary>Field number for the "path1" field.</summary>
    public const int Path1FieldNumber = 7;
    private string path1_ = "";
    /// <summary>
    /// First part of text that may appear appended to the url displayed in
    /// the ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path1 {
      get { return path1_; }
      set {
        path1_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "path2" field.</summary>
    public const int Path2FieldNumber = 8;
    private string path2_ = "";
    /// <summary>
    /// Second part of text that may appear appended to the url displayed in
    /// the ad. This field can only be set when path1 is set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Path2 {
      get { return path2_; }
      set {
        path2_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_strength" field.</summary>
    public const int AdStrengthFieldNumber = 10;
    private global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength adStrength_ = global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified;
    /// <summary>
    /// Output only. Overall ad strength of this asset group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength AdStrength {
      get { return adStrength_; }
      set {
        adStrength_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetGroup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetGroup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Campaign != other.Campaign) return false;
      if (Name != other.Name) return false;
      if(!finalUrls_.Equals(other.finalUrls_)) return false;
      if(!finalMobileUrls_.Equals(other.finalMobileUrls_)) return false;
      if (Status != other.Status) return false;
      if (PrimaryStatus != other.PrimaryStatus) return false;
      if(!primaryStatusReasons_.Equals(other.primaryStatusReasons_)) return false;
      if (Path1 != other.Path1) return false;
      if (Path2 != other.Path2) return false;
      if (AdStrength != other.AdStrength) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= finalUrls_.GetHashCode();
      hash ^= finalMobileUrls_.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) hash ^= Status.GetHashCode();
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified) hash ^= PrimaryStatus.GetHashCode();
      hash ^= primaryStatusReasons_.GetHashCode();
      if (Path1.Length != 0) hash ^= Path1.GetHashCode();
      if (Path2.Length != 0) hash ^= Path2.GetHashCode();
      if (AdStrength != global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) hash ^= AdStrength.GetHashCode();
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      finalUrls_.WriteTo(output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(output, _repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Path1.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Path1);
      }
      if (Path2.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Path2);
      }
      if (Id != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) AdStrength);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusReasons_.WriteTo(output, _repeated_primaryStatusReasons_codec);
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      finalUrls_.WriteTo(ref output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(ref output, _repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
      }
      if (Path1.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Path1);
      }
      if (Path2.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Path2);
      }
      if (Id != 0L) {
        output.WriteRawTag(72);
        output.WriteInt64(Id);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        output.WriteRawTag(80);
        output.WriteEnum((int) AdStrength);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) PrimaryStatus);
      }
      primaryStatusReasons_.WriteTo(ref output, _repeated_primaryStatusReasons_codec);
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
      if (Id != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += finalUrls_.CalculateSize(_repeated_finalUrls_codec);
      size += finalMobileUrls_.CalculateSize(_repeated_finalMobileUrls_codec);
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (PrimaryStatus != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PrimaryStatus);
      }
      size += primaryStatusReasons_.CalculateSize(_repeated_primaryStatusReasons_codec);
      if (Path1.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path1);
      }
      if (Path2.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path2);
      }
      if (AdStrength != global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AdStrength);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetGroup other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      finalUrls_.Add(other.finalUrls_);
      finalMobileUrls_.Add(other.finalMobileUrls_);
      if (other.Status != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.PrimaryStatus != global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus.Unspecified) {
        PrimaryStatus = other.PrimaryStatus;
      }
      primaryStatusReasons_.Add(other.primaryStatusReasons_);
      if (other.Path1.Length != 0) {
        Path1 = other.Path1;
      }
      if (other.Path2.Length != 0) {
        Path2 = other.Path2;
      }
      if (other.AdStrength != global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength.Unspecified) {
        AdStrength = other.AdStrength;
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
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            finalUrls_.AddEntriesFrom(input, _repeated_finalUrls_codec);
            break;
          }
          case 42: {
            finalMobileUrls_.AddEntriesFrom(input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus) input.ReadEnum();
            break;
          }
          case 58: {
            Path1 = input.ReadString();
            break;
          }
          case 66: {
            Path2 = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            AdStrength = (global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 88: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus) input.ReadEnum();
            break;
          }
          case 98:
          case 96: {
            primaryStatusReasons_.AddEntriesFrom(input, _repeated_primaryStatusReasons_codec);
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
          case 18: {
            Campaign = input.ReadString();
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
          case 34: {
            finalUrls_.AddEntriesFrom(ref input, _repeated_finalUrls_codec);
            break;
          }
          case 42: {
            finalMobileUrls_.AddEntriesFrom(ref input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 48: {
            Status = (global::Google.Ads.GoogleAds.V19.Enums.AssetGroupStatusEnum.Types.AssetGroupStatus) input.ReadEnum();
            break;
          }
          case 58: {
            Path1 = input.ReadString();
            break;
          }
          case 66: {
            Path2 = input.ReadString();
            break;
          }
          case 72: {
            Id = input.ReadInt64();
            break;
          }
          case 80: {
            AdStrength = (global::Google.Ads.GoogleAds.V19.Enums.AdStrengthEnum.Types.AdStrength) input.ReadEnum();
            break;
          }
          case 88: {
            PrimaryStatus = (global::Google.Ads.GoogleAds.V19.Enums.AssetGroupPrimaryStatusEnum.Types.AssetGroupPrimaryStatus) input.ReadEnum();
            break;
          }
          case 98:
          case 96: {
            primaryStatusReasons_.AddEntriesFrom(ref input, _repeated_primaryStatusReasons_codec);
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
