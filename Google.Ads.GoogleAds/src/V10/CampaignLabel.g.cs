// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/campaign_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/campaign_label.proto</summary>
  public static partial class CampaignLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/campaign_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL2NhbXBhaWdu",
            "X2xhYmVsLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvItkCCg1DYW1wYWlnbkxhYmVsEkUKDXJlc291",
            "cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL0NhbXBhaWduTGFiZWwSQAoIY2FtcGFpZ24YBCABKAlCKeBBBfpBIwoh",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBhaWduSACIAQESOgoFbGFi",
            "ZWwYBSABKAlCJuBBBfpBIAoeZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0xh",
            "YmVsSAGIAQE6bOpBaQomZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0NhbXBh",
            "aWduTGFiZWwSP2N1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2NhbXBhaWduTGFi",
            "ZWxzL3tjYW1wYWlnbl9pZH1+e2xhYmVsX2lkfUILCglfY2FtcGFpZ25CCAoG",
            "X2xhYmVsQoQCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLnJlc291",
            "cmNlc0ISQ2FtcGFpZ25MYWJlbFByb3RvUAFaS2dvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3Vy",
            "Y2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "MC5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcUmVzb3Vy",
            "Y2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpSZXNvdXJjZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.CampaignLabel), global::Google.Ads.GoogleAds.V10.Resources.CampaignLabel.Parser, new[]{ "ResourceName", "Campaign", "Label" }, new[]{ "Campaign", "Label" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a relationship between a campaign and a label.
  /// </summary>
  public sealed partial class CampaignLabel : pb::IMessage<CampaignLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignLabel> _parser = new pb::MessageParser<CampaignLabel>(() => new CampaignLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.CampaignLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLabel(CampaignLabel other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignLabel Clone() {
      return new CampaignLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Campaign label resource names have the form:
    /// `customers/{customer_id}/campaignLabels/{campaign_id}~{label_id}`
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
    public const int CampaignFieldNumber = 4;
    private string campaign_;
    /// <summary>
    /// Immutable. The campaign to which the label is attached.
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

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Label {
      get { return label_ ?? ""; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "label" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLabel {
      get { return label_ != null; }
    }
    /// <summary>Clears the value of the "label" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLabel() {
      label_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasLabel) hash ^= Label.GetHashCode();
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
      if (HasCampaign) {
        output.WriteRawTag(34);
        output.WriteString(Campaign);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasCampaign) {
        output.WriteRawTag(34);
        output.WriteString(Campaign);
      }
      if (HasLabel) {
        output.WriteRawTag(42);
        output.WriteString(Label);
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
      if (HasLabel) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasLabel) {
        Label = other.Label;
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
          case 34: {
            Campaign = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
          case 34: {
            Campaign = input.ReadString();
            break;
          }
          case 42: {
            Label = input.ReadString();
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
