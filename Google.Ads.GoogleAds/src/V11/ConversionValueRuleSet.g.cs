// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/conversion_value_rule_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/conversion_value_rule_set.proto</summary>
  public static partial class ConversionValueRuleSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/conversion_value_rule_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionValueRuleSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2NvbnZlcnNp",
            "b25fdmFsdWVfcnVsZV9zZXQucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxMS5yZXNvdXJjZXMaP2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMS9lbnVt",
            "cy9jb252ZXJzaW9uX2FjdGlvbl9jYXRlZ29yeS5wcm90bxpFZ29vZ2xlL2Fk",
            "cy9nb29nbGVhZHMvdjExL2VudW1zL2NvbnZlcnNpb25fdmFsdWVfcnVsZV9z",
            "ZXRfc3RhdHVzLnByb3RvGkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51",
            "bXMvdmFsdWVfcnVsZV9zZXRfYXR0YWNobWVudF90eXBlLnByb3RvGj1nb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvdmFsdWVfcnVsZV9zZXRfZGlt",
            "ZW5zaW9uLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3Rv",
            "Ghlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIqYHChZDb252ZXJzaW9uVmFs",
            "dWVSdWxlU2V0Ek4KDXJlc291cmNlX25hbWUYASABKAlCN+BBBfpBMQovZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0NvbnZlcnNpb25WYWx1ZVJ1bGVTZXQS",
            "DwoCaWQYAiABKANCA+BBAxJRChZjb252ZXJzaW9uX3ZhbHVlX3J1bGVzGAMg",
            "AygJQjH6QS4KLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Db252ZXJzaW9u",
            "VmFsdWVSdWxlEmMKCmRpbWVuc2lvbnMYBCADKA4yTy5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTEuZW51bXMuVmFsdWVSdWxlU2V0RGltZW5zaW9uRW51bS5W",
            "YWx1ZVJ1bGVTZXREaW1lbnNpb24SQQoOb3duZXJfY3VzdG9tZXIYBSABKAlC",
            "KeBBA/pBIwohZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyEncK",
            "D2F0dGFjaG1lbnRfdHlwZRgGIAEoDjJZLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxMS5lbnVtcy5WYWx1ZVJ1bGVTZXRBdHRhY2htZW50VHlwZUVudW0uVmFs",
            "dWVSdWxlU2V0QXR0YWNobWVudFR5cGVCA+BBBRI4CghjYW1wYWlnbhgHIAEo",
            "CUIm+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ24ScgoG",
            "c3RhdHVzGAggASgOMl0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVudW1z",
            "LkNvbnZlcnNpb25WYWx1ZVJ1bGVTZXRTdGF0dXNFbnVtLkNvbnZlcnNpb25W",
            "YWx1ZVJ1bGVTZXRTdGF0dXNCA+BBAxKAAQocY29udmVyc2lvbl9hY3Rpb25f",
            "Y2F0ZWdvcmllcxgJIAMoDjJVLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5l",
            "bnVtcy5Db252ZXJzaW9uQWN0aW9uQ2F0ZWdvcnlFbnVtLkNvbnZlcnNpb25B",
            "Y3Rpb25DYXRlZ29yeUID4EEFOoUB6kGBAQovZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0NvbnZlcnNpb25WYWx1ZVJ1bGVTZXQSTmN1c3RvbWVycy97Y3Vz",
            "dG9tZXJfaWR9L2NvbnZlcnNpb25WYWx1ZVJ1bGVTZXRzL3tjb252ZXJzaW9u",
            "X3ZhbHVlX3J1bGVfc2V0X2lkfUKNAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMS5yZXNvdXJjZXNCG0NvbnZlcnNpb25WYWx1ZVJ1bGVTZXRQcm90",
            "b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjExL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMTEuUmVzb3VyY2VzygIiR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjExXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxMTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.ConversionValueRuleSet), global::Google.Ads.GoogleAds.V11.Resources.ConversionValueRuleSet.Parser, new[]{ "ResourceName", "Id", "ConversionValueRules", "Dimensions", "OwnerCustomer", "AttachmentType", "Campaign", "Status", "ConversionActionCategories" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A conversion value rule set
  /// </summary>
  public sealed partial class ConversionValueRuleSet : pb::IMessage<ConversionValueRuleSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionValueRuleSet> _parser = new pb::MessageParser<ConversionValueRuleSet>(() => new ConversionValueRuleSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionValueRuleSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.ConversionValueRuleSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSet(ConversionValueRuleSet other) : this() {
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      conversionValueRules_ = other.conversionValueRules_.Clone();
      dimensions_ = other.dimensions_.Clone();
      ownerCustomer_ = other.ownerCustomer_;
      attachmentType_ = other.attachmentType_;
      campaign_ = other.campaign_;
      status_ = other.status_;
      conversionActionCategories_ = other.conversionActionCategories_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleSet Clone() {
      return new ConversionValueRuleSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the conversion value rule set.
    /// Conversion value rule set resource names have the form:
    ///
    /// `customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}`
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
    public const int IdFieldNumber = 2;
    private long id_;
    /// <summary>
    /// Output only. The ID of the conversion value rule set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "conversion_value_rules" field.</summary>
    public const int ConversionValueRulesFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_conversionValueRules_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> conversionValueRules_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Resource names of rules within the rule set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> ConversionValueRules {
      get { return conversionValueRules_; }
    }

    /// <summary>Field number for the "dimensions" field.</summary>
    public const int DimensionsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension> _repeated_dimensions_codec
        = pb::FieldCodec.ForEnum(34, x => (int) x, x => (global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension> dimensions_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension>();
    /// <summary>
    /// Defines dimensions for Value Rule conditions. The condition types of value
    /// rules within this value rule set must be of these dimensions. The first
    /// entry in this list is the primary dimension of the included value rules.
    /// When using value rule primary dimension segmentation, conversion values
    /// will be segmented into the values adjusted by value rules and the original
    /// values, if some value rules apply.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetDimensionEnum.Types.ValueRuleSetDimension> Dimensions {
      get { return dimensions_; }
    }

    /// <summary>Field number for the "owner_customer" field.</summary>
    public const int OwnerCustomerFieldNumber = 5;
    private string ownerCustomer_ = "";
    /// <summary>
    /// Output only. The resource name of the conversion value rule set's owner customer.
    /// When the value rule set is inherited from a manager
    /// customer, owner_customer will be the resource name of the manager whereas
    /// the customer in the resource_name will be of the requesting serving
    /// customer.
    /// ** Read-only **
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OwnerCustomer {
      get { return ownerCustomer_; }
      set {
        ownerCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "attachment_type" field.</summary>
    public const int AttachmentTypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType attachmentType_ = global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified;
    /// <summary>
    /// Immutable. Defines the scope where the conversion value rule set is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType AttachmentType {
      get { return attachmentType_; }
      set {
        attachmentType_ = value;
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 7;
    private string campaign_ = "";
    /// <summary>
    /// The resource name of the campaign when the conversion value rule
    /// set is attached to a campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus status_ = global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the conversion value rule set.
    /// ** Read-only **
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "conversion_action_categories" field.</summary>
    public const int ConversionActionCategoriesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory> _repeated_conversionActionCategories_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory> conversionActionCategories_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory>();
    /// <summary>
    /// Immutable. The conversion action categories of the conversion value rule set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V11.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory> ConversionActionCategories {
      get { return conversionActionCategories_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionValueRuleSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionValueRuleSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if(!conversionValueRules_.Equals(other.conversionValueRules_)) return false;
      if(!dimensions_.Equals(other.dimensions_)) return false;
      if (OwnerCustomer != other.OwnerCustomer) return false;
      if (AttachmentType != other.AttachmentType) return false;
      if (Campaign != other.Campaign) return false;
      if (Status != other.Status) return false;
      if(!conversionActionCategories_.Equals(other.conversionActionCategories_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Id != 0L) hash ^= Id.GetHashCode();
      hash ^= conversionValueRules_.GetHashCode();
      hash ^= dimensions_.GetHashCode();
      if (OwnerCustomer.Length != 0) hash ^= OwnerCustomer.GetHashCode();
      if (AttachmentType != global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified) hash ^= AttachmentType.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified) hash ^= Status.GetHashCode();
      hash ^= conversionActionCategories_.GetHashCode();
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      conversionValueRules_.WriteTo(output, _repeated_conversionValueRules_codec);
      dimensions_.WriteTo(output, _repeated_dimensions_codec);
      if (OwnerCustomer.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OwnerCustomer);
      }
      if (AttachmentType != global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) AttachmentType);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Campaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      conversionActionCategories_.WriteTo(output, _repeated_conversionActionCategories_codec);
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
      if (Id != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Id);
      }
      conversionValueRules_.WriteTo(ref output, _repeated_conversionValueRules_codec);
      dimensions_.WriteTo(ref output, _repeated_dimensions_codec);
      if (OwnerCustomer.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OwnerCustomer);
      }
      if (AttachmentType != global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) AttachmentType);
      }
      if (Campaign.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Campaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      conversionActionCategories_.WriteTo(ref output, _repeated_conversionActionCategories_codec);
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
      size += conversionValueRules_.CalculateSize(_repeated_conversionValueRules_codec);
      size += dimensions_.CalculateSize(_repeated_dimensions_codec);
      if (OwnerCustomer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OwnerCustomer);
      }
      if (AttachmentType != global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AttachmentType);
      }
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      size += conversionActionCategories_.CalculateSize(_repeated_conversionActionCategories_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversionValueRuleSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Id != 0L) {
        Id = other.Id;
      }
      conversionValueRules_.Add(other.conversionValueRules_);
      dimensions_.Add(other.dimensions_);
      if (other.OwnerCustomer.Length != 0) {
        OwnerCustomer = other.OwnerCustomer;
      }
      if (other.AttachmentType != global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType.Unspecified) {
        AttachmentType = other.AttachmentType;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus.Unspecified) {
        Status = other.Status;
      }
      conversionActionCategories_.Add(other.conversionActionCategories_);
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
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            conversionValueRules_.AddEntriesFrom(input, _repeated_conversionValueRules_codec);
            break;
          }
          case 34:
          case 32: {
            dimensions_.AddEntriesFrom(input, _repeated_dimensions_codec);
            break;
          }
          case 42: {
            OwnerCustomer = input.ReadString();
            break;
          }
          case 48: {
            AttachmentType = (global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType) input.ReadEnum();
            break;
          }
          case 58: {
            Campaign = input.ReadString();
            break;
          }
          case 64: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus) input.ReadEnum();
            break;
          }
          case 74:
          case 72: {
            conversionActionCategories_.AddEntriesFrom(input, _repeated_conversionActionCategories_codec);
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
            Id = input.ReadInt64();
            break;
          }
          case 26: {
            conversionValueRules_.AddEntriesFrom(ref input, _repeated_conversionValueRules_codec);
            break;
          }
          case 34:
          case 32: {
            dimensions_.AddEntriesFrom(ref input, _repeated_dimensions_codec);
            break;
          }
          case 42: {
            OwnerCustomer = input.ReadString();
            break;
          }
          case 48: {
            AttachmentType = (global::Google.Ads.GoogleAds.V11.Enums.ValueRuleSetAttachmentTypeEnum.Types.ValueRuleSetAttachmentType) input.ReadEnum();
            break;
          }
          case 58: {
            Campaign = input.ReadString();
            break;
          }
          case 64: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.ConversionValueRuleSetStatusEnum.Types.ConversionValueRuleSetStatus) input.ReadEnum();
            break;
          }
          case 74:
          case 72: {
            conversionActionCategories_.AddEntriesFrom(ref input, _repeated_conversionActionCategories_codec);
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
