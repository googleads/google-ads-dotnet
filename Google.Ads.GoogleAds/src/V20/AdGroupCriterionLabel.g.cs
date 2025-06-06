// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/ad_group_criterion_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/ad_group_criterion_label.proto</summary>
  public static partial class AdGroupCriterionLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/ad_group_criterion_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2NyaXRlcmlvbl9sYWJlbC5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djIwLnJlc291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKmAwoVQWRHcm91cENyaXRl",
            "cmlvbkxhYmVsEk0KDXJlc291cmNlX25hbWUYASABKAlCNuBBBfpBMAouZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBDcml0ZXJpb25MYWJlbBJS",
            "ChJhZF9ncm91cF9jcml0ZXJpb24YBCABKAlCMeBBBfpBKwopZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tL0FkR3JvdXBDcml0ZXJpb25IAIgBARI6CgVsYWJl",
            "bBgFIAEoCUIm4EEF+kEgCh5nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vTGFi",
            "ZWxIAYgBATqMAepBiAEKLmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdy",
            "b3VwQ3JpdGVyaW9uTGFiZWwSVmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2Fk",
            "R3JvdXBDcml0ZXJpb25MYWJlbHMve2FkX2dyb3VwX2lkfX57Y3JpdGVyaW9u",
            "X2lkfX57bGFiZWxfaWR9QhUKE19hZF9ncm91cF9jcml0ZXJpb25CCAoGX2xh",
            "YmVsQowCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLnJlc291cmNl",
            "c0IaQWRHcm91cENyaXRlcmlvbkxhYmVsUHJvdG9QAVpLZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9y",
            "ZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjIwLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxS",
            "ZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjA6OlJlc291",
            "cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.AdGroupCriterionLabel), global::Google.Ads.GoogleAds.V20.Resources.AdGroupCriterionLabel.Parser, new[]{ "ResourceName", "AdGroupCriterion", "Label" }, new[]{ "AdGroupCriterion", "Label" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A relationship between an ad group criterion and a label.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AdGroupCriterionLabel : pb::IMessage<AdGroupCriterionLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupCriterionLabel> _parser = new pb::MessageParser<AdGroupCriterionLabel>(() => new AdGroupCriterionLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupCriterionLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.AdGroupCriterionLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionLabel(AdGroupCriterionLabel other) : this() {
      resourceName_ = other.resourceName_;
      adGroupCriterion_ = other.adGroupCriterion_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCriterionLabel Clone() {
      return new AdGroupCriterionLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group criterion label.
    /// Ad group criterion label resource names have the form:
    /// `customers/{customer_id}/adGroupCriterionLabels/{ad_group_id}~{criterion_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group_criterion" field.</summary>
    public const int AdGroupCriterionFieldNumber = 4;
    private readonly static string AdGroupCriterionDefaultValue = "";

    private string adGroupCriterion_;
    /// <summary>
    /// Immutable. The ad group criterion to which the label is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroupCriterion {
      get { return adGroupCriterion_ ?? AdGroupCriterionDefaultValue; }
      set {
        adGroupCriterion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "ad_group_criterion" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAdGroupCriterion {
      get { return adGroupCriterion_ != null; }
    }
    /// <summary>Clears the value of the "ad_group_criterion" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAdGroupCriterion() {
      adGroupCriterion_ = null;
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 5;
    private readonly static string LabelDefaultValue = "";

    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the ad group criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Label {
      get { return label_ ?? LabelDefaultValue; }
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
      return Equals(other as AdGroupCriterionLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupCriterionLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroupCriterion != other.AdGroupCriterion) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasAdGroupCriterion) hash ^= AdGroupCriterion.GetHashCode();
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
      if (HasAdGroupCriterion) {
        output.WriteRawTag(34);
        output.WriteString(AdGroupCriterion);
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
      if (HasAdGroupCriterion) {
        output.WriteRawTag(34);
        output.WriteString(AdGroupCriterion);
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
      if (HasAdGroupCriterion) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroupCriterion);
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
    public void MergeFrom(AdGroupCriterionLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasAdGroupCriterion) {
        AdGroupCriterion = other.AdGroupCriterion;
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
            AdGroupCriterion = input.ReadString();
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
            AdGroupCriterion = input.ReadString();
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
