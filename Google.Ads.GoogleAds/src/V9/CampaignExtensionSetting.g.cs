// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/campaign_extension_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/campaign_extension_setting.proto</summary>
  public static partial class CampaignExtensionSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/campaign_extension_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignExtensionSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "ZXh0ZW5zaW9uX3NldHRpbmcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnY5LnJlc291cmNlcxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51bXMv",
            "ZXh0ZW5zaW9uX3NldHRpbmdfZGV2aWNlLnByb3RvGjJnb29nbGUvYWRzL2dv",
            "b2dsZWFkcy92OS9lbnVtcy9leHRlbnNpb25fdHlwZS5wcm90bxofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90byLVBAoYQ2FtcGFpZ25FeHRlbnNpb25TZXR0aW5nElAKDXJlc291",
            "cmNlX25hbWUYASABKAlCOeBBBfpBMwoxZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduRXh0ZW5zaW9uU2V0dGluZxJbCg5leHRlbnNpb25fdHlw",
            "ZRgCIAEoDjI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVudW1zLkV4dGVu",
            "c2lvblR5cGVFbnVtLkV4dGVuc2lvblR5cGVCA+BBBRJACghjYW1wYWlnbhgG",
            "IAEoCUIp4EEF+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFp",
            "Z25IAIgBARJNChRleHRlbnNpb25fZmVlZF9pdGVtcxgHIAMoCUIv+kEsCipn",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRXh0ZW5zaW9uRmVlZEl0ZW0SYAoG",
            "ZGV2aWNlGAUgASgOMlAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMu",
            "RXh0ZW5zaW9uU2V0dGluZ0RldmljZUVudW0uRXh0ZW5zaW9uU2V0dGluZ0Rl",
            "dmljZTqJAepBhQEKMWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWln",
            "bkV4dGVuc2lvblNldHRpbmcSUGN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2Nh",
            "bXBhaWduRXh0ZW5zaW9uU2V0dGluZ3Mve2NhbXBhaWduX2lkfX57ZXh0ZW5z",
            "aW9uX3R5cGV9QgsKCV9jYW1wYWlnbkKKAgolY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY5LnJlc291cmNlc0IdQ2FtcGFpZ25FeHRlbnNpb25TZXR0aW5n",
            "UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3Y5L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGq",
            "AiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WOS5SZXNvdXJjZXPKAiFHb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWOVxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWOTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CampaignExtensionSetting), global::Google.Ads.GoogleAds.V9.Resources.CampaignExtensionSetting.Parser, new[]{ "ResourceName", "ExtensionType", "Campaign", "ExtensionFeedItems", "Device" }, new[]{ "Campaign" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign extension setting.
  /// </summary>
  public sealed partial class CampaignExtensionSetting : pb::IMessage<CampaignExtensionSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignExtensionSetting> _parser = new pb::MessageParser<CampaignExtensionSetting>(() => new CampaignExtensionSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignExtensionSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CampaignExtensionSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExtensionSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExtensionSetting(CampaignExtensionSetting other) : this() {
      resourceName_ = other.resourceName_;
      extensionType_ = other.extensionType_;
      campaign_ = other.campaign_;
      extensionFeedItems_ = other.extensionFeedItems_.Clone();
      device_ = other.device_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignExtensionSetting Clone() {
      return new CampaignExtensionSetting(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign extension setting.
    /// CampaignExtensionSetting resource names have the form:
    ///
    /// `customers/{customer_id}/campaignExtensionSettings/{campaign_id}~{extension_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "extension_type" field.</summary>
    public const int ExtensionTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType extensionType_ = global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified;
    /// <summary>
    /// Immutable. The extension type of the customer extension setting.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType ExtensionType {
      get { return extensionType_; }
      set {
        extensionType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 6;
    private string campaign_;
    /// <summary>
    /// Immutable. The resource name of the campaign. The linked extension feed items will
    /// serve under this campaign.
    /// Campaign resource names have the form:
    ///
    /// `customers/{customer_id}/campaigns/{campaign_id}`
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

    /// <summary>Field number for the "extension_feed_items" field.</summary>
    public const int ExtensionFeedItemsFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_extensionFeedItems_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> extensionFeedItems_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The resource names of the extension feed items to serve under the campaign.
    /// ExtensionFeedItem resource names have the form:
    ///
    /// `customers/{customer_id}/extensionFeedItems/{feed_item_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ExtensionFeedItems {
      get { return extensionFeedItems_; }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice device_ = global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified;
    /// <summary>
    /// The device for which the extensions will serve. Optional.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice Device {
      get { return device_; }
      set {
        device_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignExtensionSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignExtensionSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ExtensionType != other.ExtensionType) return false;
      if (Campaign != other.Campaign) return false;
      if(!extensionFeedItems_.Equals(other.extensionFeedItems_)) return false;
      if (Device != other.Device) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (ExtensionType != global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) hash ^= ExtensionType.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      hash ^= extensionFeedItems_.GetHashCode();
      if (Device != global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) hash ^= Device.GetHashCode();
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Device);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      extensionFeedItems_.WriteTo(output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ExtensionType);
      }
      if (Device != global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Device);
      }
      if (HasCampaign) {
        output.WriteRawTag(50);
        output.WriteString(Campaign);
      }
      extensionFeedItems_.WriteTo(ref output, _repeated_extensionFeedItems_codec);
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
      if (ExtensionType != global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ExtensionType);
      }
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      size += extensionFeedItems_.CalculateSize(_repeated_extensionFeedItems_codec);
      if (Device != global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Device);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignExtensionSetting other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.ExtensionType != global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType.Unspecified) {
        ExtensionType = other.ExtensionType;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      extensionFeedItems_.Add(other.extensionFeedItems_);
      if (other.Device != global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice.Unspecified) {
        Device = other.Device;
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
          case 16: {
            ExtensionType = (global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 40: {
            Device = (global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 58: {
            extensionFeedItems_.AddEntriesFrom(input, _repeated_extensionFeedItems_codec);
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
          case 16: {
            ExtensionType = (global::Google.Ads.GoogleAds.V9.Enums.ExtensionTypeEnum.Types.ExtensionType) input.ReadEnum();
            break;
          }
          case 40: {
            Device = (global::Google.Ads.GoogleAds.V9.Enums.ExtensionSettingDeviceEnum.Types.ExtensionSettingDevice) input.ReadEnum();
            break;
          }
          case 50: {
            Campaign = input.ReadString();
            break;
          }
          case 58: {
            extensionFeedItems_.AddEntriesFrom(ref input, _repeated_extensionFeedItems_codec);
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
