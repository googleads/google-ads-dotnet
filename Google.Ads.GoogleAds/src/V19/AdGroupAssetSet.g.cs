// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/resources/ad_group_asset_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/resources/ad_group_asset_set.proto</summary>
  public static partial class AdGroupAssetSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/resources/ad_group_asset_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAssetSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2Fzc2V0X3NldC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE5LnJl",
            "c291cmNlcxo6Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjE5L2VudW1zL2Fzc2V0",
            "X3NldF9saW5rX3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhh",
            "dmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKqAwoPQWRH",
            "cm91cEFzc2V0U2V0EkcKDXJlc291cmNlX25hbWUYASABKAlCMOBBBfpBKgoo",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBBc3NldFNldBI6Cghh",
            "ZF9ncm91cBgCIAEoCUIo4EEF+kEiCiBnb29nbGVhZHMuZ29vZ2xlYXBpcy5j",
            "b20vQWRHcm91cBI8Cglhc3NldF9zZXQYAyABKAlCKeBBBfpBIwohZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0Fzc2V0U2V0El4KBnN0YXR1cxgEIAEoDjJJ",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lbnVtcy5Bc3NldFNldExpbmtT",
            "dGF0dXNFbnVtLkFzc2V0U2V0TGlua1N0YXR1c0ID4EEDOnTqQXEKKGdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwQXNzZXRTZXQSRWN1c3RvbWVy",
            "cy97Y3VzdG9tZXJfaWR9L2FkR3JvdXBBc3NldFNldHMve2FkX2dyb3VwX2lk",
            "fX57YXNzZXRfc2V0X2lkfUKGAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxOS5yZXNvdXJjZXNCFEFkR3JvdXBBc3NldFNldFByb3RvUAFaS2dvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MTkvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxOS5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMTlcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE5",
            "OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Resources.AdGroupAssetSet), global::Google.Ads.GoogleAds.V19.Resources.AdGroupAssetSet.Parser, new[]{ "ResourceName", "AdGroup", "AssetSet", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// AdGroupAssetSet is the linkage between an ad group and an asset set.
  /// Creating an AdGroupAssetSet links an asset set with an ad group.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdGroupAssetSet : pb::IMessage<AdGroupAssetSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAssetSet> _parser = new pb::MessageParser<AdGroupAssetSet>(() => new AdGroupAssetSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAssetSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Resources.AdGroupAssetSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAssetSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAssetSet(AdGroupAssetSet other) : this() {
      resourceName_ = other.resourceName_;
      adGroup_ = other.adGroup_;
      assetSet_ = other.assetSet_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAssetSet Clone() {
      return new AdGroupAssetSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group asset set.
    /// Ad group asset set resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 2;
    private string adGroup_ = "";
    /// <summary>
    /// Immutable. The ad group to which this asset set is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset_set" field.</summary>
    public const int AssetSetFieldNumber = 3;
    private string assetSet_ = "";
    /// <summary>
    /// Immutable. The asset set which is linked to the ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AssetSet {
      get { return assetSet_; }
      set {
        assetSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus status_ = global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the ad group asset set. Read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAssetSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAssetSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
      if (AssetSet != other.AssetSet) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AdGroup.Length != 0) hash ^= AdGroup.GetHashCode();
      if (AssetSet.Length != 0) hash ^= AssetSet.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (AssetSet.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
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
      if (AdGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (AssetSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AssetSet);
      }
      if (Status != global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAssetSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AdGroup.Length != 0) {
        AdGroup = other.AdGroup;
      }
      if (other.AssetSet.Length != 0) {
        AssetSet = other.AssetSet;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus.Unspecified) {
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
          case 18: {
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            AssetSet = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            AssetSet = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V19.Enums.AssetSetLinkStatusEnum.Types.AssetSetLinkStatus) input.ReadEnum();
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
