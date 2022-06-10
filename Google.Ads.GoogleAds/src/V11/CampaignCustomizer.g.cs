// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/campaign_customizer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/campaign_customizer.proto</summary>
  public static partial class CampaignCustomizerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/campaign_customizer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCustomizerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X2N1c3RvbWl6ZXIucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5y",
            "ZXNvdXJjZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxMS9jb21tb24vY3Vz",
            "dG9taXplcl92YWx1ZS5wcm90bxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEx",
            "L2VudW1zL2N1c3RvbWl6ZXJfdmFsdWVfc3RhdHVzLnByb3RvGh9nb29nbGUv",
            "YXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNl",
            "LnByb3RvIqkEChJDYW1wYWlnbkN1c3RvbWl6ZXISSgoNcmVzb3VyY2VfbmFt",
            "ZRgBIAEoCUIz4EEF+kEtCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2Ft",
            "cGFpZ25DdXN0b21pemVyEjsKCGNhbXBhaWduGAIgASgJQingQQX6QSMKIWdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnbhJVChRjdXN0b21pemVy",
            "X2F0dHJpYnV0ZRgDIAEoCUI34EEC4EEF+kEuCixnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ3VzdG9taXplckF0dHJpYnV0ZRJkCgZzdGF0dXMYBCABKA4y",
            "Ty5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXMuQ3VzdG9taXplclZh",
            "bHVlU3RhdHVzRW51bS5DdXN0b21pemVyVmFsdWVTdGF0dXNCA+BBAxJECgV2",
            "YWx1ZRgFIAEoCzIwLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5jb21tb24u",
            "Q3VzdG9taXplclZhbHVlQgPgQQI6hgHqQYIBCitnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vQ2FtcGFpZ25DdXN0b21pemVyElNjdXN0b21lcnMve2N1c3Rv",
            "bWVyX2lkfS9jYW1wYWlnbkN1c3RvbWl6ZXJzL3tjYW1wYWlnbl9pZH1+e2N1",
            "c3RvbWl6ZXJfYXR0cmlidXRlX2lkfUKJAgomY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMS5yZXNvdXJjZXNCF0NhbXBhaWduQ3VzdG9taXplclByb3Rv",
            "UAFaS2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5SZXNvdXJjZXPKAiJHb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMTFcUmVzb3VyY2Vz6gImR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjExOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Common.CustomizerValueReflection.Descriptor, global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CampaignCustomizer), global::Google.Ads.GoogleAds.V11.Resources.CampaignCustomizer.Parser, new[]{ "ResourceName", "Campaign", "CustomizerAttribute", "Status", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customizer value for the associated CustomizerAttribute at the Campaign
  /// level.
  /// </summary>
  public sealed partial class CampaignCustomizer : pb::IMessage<CampaignCustomizer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignCustomizer> _parser = new pb::MessageParser<CampaignCustomizer>(() => new CampaignCustomizer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignCustomizer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CampaignCustomizerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCustomizer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCustomizer(CampaignCustomizer other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      customizerAttribute_ = other.customizerAttribute_;
      status_ = other.status_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignCustomizer Clone() {
      return new CampaignCustomizer(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the campaign customizer.
    /// Campaign customizer resource names have the form:
    ///
    /// `customers/{customer_id}/campaignCustomizers/{campaign_id}~{customizer_attribute_id}`
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
    public const int CampaignFieldNumber = 2;
    private string campaign_ = "";
    /// <summary>
    /// Immutable. The campaign to which the customizer attribute is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customizer_attribute" field.</summary>
    public const int CustomizerAttributeFieldNumber = 3;
    private string customizerAttribute_ = "";
    /// <summary>
    /// Required. Immutable. The customizer attribute which is linked to the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomizerAttribute {
      get { return customizerAttribute_; }
      set {
        customizerAttribute_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus status_ = global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the campaign customizer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V11.Common.CustomizerValue value_;
    /// <summary>
    /// Required. The value to associate with the customizer attribute at this level. The
    /// value must be of the type specified for the CustomizerAttribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Common.CustomizerValue Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignCustomizer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignCustomizer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (CustomizerAttribute != other.CustomizerAttribute) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (CustomizerAttribute.Length != 0) hash ^= CustomizerAttribute.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) hash ^= Status.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (value_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Value);
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
      if (Campaign.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Campaign);
      }
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (value_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Value);
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
      if (Campaign.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (CustomizerAttribute.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignCustomizer other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.CustomizerAttribute.Length != 0) {
        CustomizerAttribute = other.CustomizerAttribute;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Ads.GoogleAds.V11.Common.CustomizerValue();
        }
        Value.MergeFrom(other.Value);
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
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V11.Common.CustomizerValue();
            }
            input.ReadMessage(Value);
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
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V11.Common.CustomizerValue();
            }
            input.ReadMessage(Value);
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
