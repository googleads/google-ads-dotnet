// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/campaign_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/campaign_asset.proto</summary>
  public static partial class CampaignAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/campaign_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "YXNzZXQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNl",
            "cxo0Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51bXMvYXNzZXRfZmllbGRf",
            "dHlwZS5wcm90bxo1Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51bXMvYXNz",
            "ZXRfbGlua19zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8ilQQKDUNhbXBh",
            "aWduQXNzZXQSRQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIu4EEF+kEoCiZnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25Bc3NldBJACghjYW1wYWln",
            "bhgGIAEoCUIp4EEF+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2Ft",
            "cGFpZ25IAIgBARI6CgVhc3NldBgHIAEoCUIm4EEF+kEgCh5nb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQXNzZXRIAYgBARJZCgpmaWVsZF90eXBlGAQgASgO",
            "MkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuQXNzZXRGaWVsZFR5",
            "cGVFbnVtLkFzc2V0RmllbGRUeXBlQgPgQQUSUgoGc3RhdHVzGAUgASgOMkIu",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuQXNzZXRMaW5rU3RhdHVz",
            "RW51bS5Bc3NldExpbmtTdGF0dXM6eepBdgomZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0NhbXBhaWduQXNzZXQSTGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9",
            "L2NhbXBhaWduQXNzZXRzL3tjYW1wYWlnbl9pZH1+e2Fzc2V0X2lkfX57Zmll",
            "bGRfdHlwZX1CCwoJX2NhbXBhaWduQggKBl9hc3NldEL/AQolY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNlc0ISQ2FtcGFpZ25Bc3NldFBy",
            "b3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIh",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjkuUmVzb3VyY2VzygIhR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjlcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6Vjk6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CampaignAsset), global::Google.Ads.GoogleAds.V9.Resources.CampaignAsset.Parser, new[]{ "ResourceName", "Campaign", "Asset", "FieldType", "Status" }, new[]{ "Campaign", "Asset" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between a Campaign and an Asset.
  /// </summary>
  public sealed partial class CampaignAsset : pb::IMessage<CampaignAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignAsset> _parser = new pb::MessageParser<CampaignAsset>(() => new CampaignAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CampaignAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAsset(CampaignAsset other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignAsset Clone() {
      return new CampaignAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign asset.
    /// CampaignAsset resource names have the form:
    ///
    /// `customers/{customer_id}/campaignAssets/{campaign_id}~{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 6;
    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the asset is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? ""; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 7;
    private string asset_;
    /// <summary>
    /// Immutable. The asset which is linked to the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_ ?? ""; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "asset" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAsset {
      get { return asset_ != null; }
    }
    /// <summary>Clears the value of the "asset" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAsset() {
      asset_ = null;
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Immutable. Role that the asset takes under the linked campaign.
    /// Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// Status of the campaign asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasAsset) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (FieldType != global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      if (HasAsset) {
        output.WriteRawTag(58);
        output.WriteString(Asset);
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
      if (FieldType != global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      if (HasAsset) {
        output.WriteRawTag(58);
        output.WriteString(Asset);
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
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasAsset) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasAsset) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 58: {
            Asset = input.ReadString();
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
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 58: {
            Asset = input.ReadString();
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
