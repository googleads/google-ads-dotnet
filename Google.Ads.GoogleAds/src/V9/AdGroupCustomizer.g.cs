// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/ad_group_customizer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/ad_group_customizer.proto</summary>
  public static partial class AdGroupCustomizerReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/ad_group_customizer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCustomizerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "Y3VzdG9taXplci5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkucmVz",
            "b3VyY2VzGjVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vY3VzdG9t",
            "aXplcl92YWx1ZS5wcm90bxo7Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51",
            "bXMvY3VzdG9taXplcl92YWx1ZV9zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkv",
            "ZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJv",
            "dG8iogQKEUFkR3JvdXBDdXN0b21pemVyEkkKDXJlc291cmNlX25hbWUYASAB",
            "KAlCMuBBBfpBLAoqZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBD",
            "dXN0b21pemVyEjoKCGFkX2dyb3VwGAIgASgJQijgQQX6QSIKIGdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwElUKFGN1c3RvbWl6ZXJfYXR0cmli",
            "dXRlGAMgASgJQjfgQQLgQQX6QS4KLGdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DdXN0b21pemVyQXR0cmlidXRlEmMKBnN0YXR1cxgEIAEoDjJOLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY5LmVudW1zLkN1c3RvbWl6ZXJWYWx1ZVN0YXR1",
            "c0VudW0uQ3VzdG9taXplclZhbHVlU3RhdHVzQgPgQQMSQwoFdmFsdWUYBSAB",
            "KAsyLy5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5jb21tb24uQ3VzdG9taXpl",
            "clZhbHVlQgPgQQI6hAHqQYABCipnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "QWRHcm91cEN1c3RvbWl6ZXISUmN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2Fk",
            "R3JvdXBDdXN0b21pemVycy97YWRfZ3JvdXBfaWR9fntjdXN0b21pemVyX2F0",
            "dHJpYnV0ZV9pZH1CgwIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5y",
            "ZXNvdXJjZXNCFkFkR3JvdXBDdXN0b21pemVyUHJvdG9QAVpKZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y5",
            "L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WOS5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWOVxS",
            "ZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWOTo6UmVzb3Vy",
            "Y2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Common.CustomizerValueReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.AdGroupCustomizer), global::Google.Ads.GoogleAds.V9.Resources.AdGroupCustomizer.Parser, new[]{ "ResourceName", "AdGroup", "CustomizerAttribute", "Status", "Value" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A customizer value for the associated CustomizerAttribute at the AdGroup
  /// level.
  /// </summary>
  public sealed partial class AdGroupCustomizer : pb::IMessage<AdGroupCustomizer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupCustomizer> _parser = new pb::MessageParser<AdGroupCustomizer>(() => new AdGroupCustomizer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupCustomizer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.AdGroupCustomizerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCustomizer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCustomizer(AdGroupCustomizer other) : this() {
      resourceName_ = other.resourceName_;
      adGroup_ = other.adGroup_;
      customizerAttribute_ = other.customizerAttribute_;
      status_ = other.status_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupCustomizer Clone() {
      return new AdGroupCustomizer(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group customizer.
    /// Ad group customizer resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}`
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
    /// Immutable. The ad group to which the customizer attribute is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customizer_attribute" field.</summary>
    public const int CustomizerAttributeFieldNumber = 3;
    private string customizerAttribute_ = "";
    /// <summary>
    /// Required. Immutable. The customizer attribute which is linked to the ad group.
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
    private global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus status_ = global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the ad group customizer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V9.Common.CustomizerValue value_;
    /// <summary>
    /// Required. The value to associate with the customizer attribute at this level. The
    /// value must be of the type specified for the CustomizerAttribute.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.CustomizerValue Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupCustomizer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupCustomizer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
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
      if (AdGroup.Length != 0) hash ^= AdGroup.GetHashCode();
      if (CustomizerAttribute.Length != 0) hash ^= CustomizerAttribute.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
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
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (CustomizerAttribute.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
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
      if (AdGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (CustomizerAttribute.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomizerAttribute);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
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
    public void MergeFrom(AdGroupCustomizer other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AdGroup.Length != 0) {
        AdGroup = other.AdGroup;
      }
      if (other.CustomizerAttribute.Length != 0) {
        CustomizerAttribute = other.CustomizerAttribute;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Ads.GoogleAds.V9.Common.CustomizerValue();
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
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V9.Common.CustomizerValue();
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
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            CustomizerAttribute = input.ReadString();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.CustomizerValueStatusEnum.Types.CustomizerValueStatus) input.ReadEnum();
            break;
          }
          case 42: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V9.Common.CustomizerValue();
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
