// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/android_privacy_shared_key_google_network_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/android_privacy_shared_key_google_network_type.proto</summary>
  public static partial class AndroidPrivacySharedKeyGoogleNetworkTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/android_privacy_shared_key_google_network_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AndroidPrivacySharedKeyGoogleNetworkTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cldnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL2FuZHJvaWRf",
            "cHJpdmFjeV9zaGFyZWRfa2V5X2dvb2dsZV9uZXR3b3JrX3R5cGUucHJvdG8S",
            "Imdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5yZXNvdXJjZXMaRWdvb2dsZS9h",
            "ZHMvZ29vZ2xlYWRzL3YyMC9lbnVtcy9hbmRyb2lkX3ByaXZhY3lfaW50ZXJh",
            "Y3Rpb25fdHlwZS5wcm90bxpBZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIwL2Vu",
            "dW1zL2FuZHJvaWRfcHJpdmFjeV9uZXR3b3JrX3R5cGUucHJvdG8aH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8ikgYKKEFuZHJvaWRQcml2YWN5U2hhcmVkS2V5R29vZ2xlTmV0",
            "d29ya1R5cGUSYAoNcmVzb3VyY2VfbmFtZRgBIAEoCUJJ4EED+kFDCkFnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQW5kcm9pZFByaXZhY3lTaGFyZWRLZXlH",
            "b29nbGVOZXR3b3JrVHlwZRIYCgtjYW1wYWlnbl9pZBgCIAEoA0ID4EEDEo4B",
            "CiBhbmRyb2lkX3ByaXZhY3lfaW50ZXJhY3Rpb25fdHlwZRgDIAEoDjJfLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lbnVtcy5BbmRyb2lkUHJpdmFjeUlu",
            "dGVyYWN0aW9uVHlwZUVudW0uQW5kcm9pZFByaXZhY3lJbnRlcmFjdGlvblR5",
            "cGVCA+BBAxItCiBhbmRyb2lkX3ByaXZhY3lfaW50ZXJhY3Rpb25fZGF0ZRgE",
            "IAEoCUID4EEDEoIBChxhbmRyb2lkX3ByaXZhY3lfbmV0d29ya190eXBlGAUg",
            "ASgOMlcuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zLkFuZHJvaWRQ",
            "cml2YWN5TmV0d29ya1R5cGVFbnVtLkFuZHJvaWRQcml2YWN5TmV0d29ya1R5",
            "cGVCA+BBAxIkChdzaGFyZWRfbmV0d29ya190eXBlX2tleRgGIAEoCUID4EED",
            "Ov4B6kH6AQpBZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0FuZHJvaWRQcml2",
            "YWN5U2hhcmVkS2V5R29vZ2xlTmV0d29ya1R5cGUStAFjdXN0b21lcnMve2N1",
            "c3RvbWVyX2lkfS9hbmRyb2lkUHJpdmFjeVNoYXJlZEtleUdvb2dsZU5ldHdv",
            "cmtUeXBlcy97Y2FtcGFpZ25faWR9fnthbmRyb2lkX3ByaXZhY3lfaW50ZXJh",
            "Y3Rpb25fdHlwZX1+e2FuZHJvaWRfcHJpdmFjeV9uZXR3b3JrX3R5cGV9fnth",
            "bmRyb2lkX3ByaXZhY3lfaW50ZXJhY3Rpb25fZGF0ZX1CnwIKJmNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MjAucmVzb3VyY2VzQi1BbmRyb2lkUHJpdmFj",
            "eVNoYXJlZEtleUdvb2dsZU5ldHdvcmtUeXBlUHJvdG9QAVpLZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yy",
            "MC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjIwLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYy",
            "MFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjA6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.AndroidPrivacySharedKeyGoogleNetworkType), global::Google.Ads.GoogleAds.V20.Resources.AndroidPrivacySharedKeyGoogleNetworkType.Parser, new[]{ "ResourceName", "CampaignId", "AndroidPrivacyInteractionType", "AndroidPrivacyInteractionDate", "AndroidPrivacyNetworkType", "SharedNetworkTypeKey" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// An Android privacy shared key view for Google network type key.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AndroidPrivacySharedKeyGoogleNetworkType : pb::IMessage<AndroidPrivacySharedKeyGoogleNetworkType>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AndroidPrivacySharedKeyGoogleNetworkType> _parser = new pb::MessageParser<AndroidPrivacySharedKeyGoogleNetworkType>(() => new AndroidPrivacySharedKeyGoogleNetworkType());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AndroidPrivacySharedKeyGoogleNetworkType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.AndroidPrivacySharedKeyGoogleNetworkTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleNetworkType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleNetworkType(AndroidPrivacySharedKeyGoogleNetworkType other) : this() {
      resourceName_ = other.resourceName_;
      campaignId_ = other.campaignId_;
      androidPrivacyInteractionType_ = other.androidPrivacyInteractionType_;
      androidPrivacyInteractionDate_ = other.androidPrivacyInteractionDate_;
      androidPrivacyNetworkType_ = other.androidPrivacyNetworkType_;
      sharedNetworkTypeKey_ = other.sharedNetworkTypeKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AndroidPrivacySharedKeyGoogleNetworkType Clone() {
      return new AndroidPrivacySharedKeyGoogleNetworkType(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the Android privacy shared key.
    /// Android privacy shared key resource names have the form:
    ///
    /// `customers/{customer_id}/androidPrivacySharedKeyGoogleNetworkTypes/{campaign_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date(yyyy-mm-dd)}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 2;
    private long campaignId_;
    /// <summary>
    /// Output only. The campaign ID used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CampaignId {
      get { return campaignId_; }
      set {
        campaignId_ = value;
      }
    }

    /// <summary>Field number for the "android_privacy_interaction_type" field.</summary>
    public const int AndroidPrivacyInteractionTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType androidPrivacyInteractionType_ = global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified;
    /// <summary>
    /// Output only. The interaction type enum used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType AndroidPrivacyInteractionType {
      get { return androidPrivacyInteractionType_; }
      set {
        androidPrivacyInteractionType_ = value;
      }
    }

    /// <summary>Field number for the "android_privacy_interaction_date" field.</summary>
    public const int AndroidPrivacyInteractionDateFieldNumber = 4;
    private string androidPrivacyInteractionDate_ = "";
    /// <summary>
    /// Output only. The interaction date used in the shared key encoding in the
    /// format of "YYYY-MM-DD" in UTC timezone.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AndroidPrivacyInteractionDate {
      get { return androidPrivacyInteractionDate_; }
      set {
        androidPrivacyInteractionDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "android_privacy_network_type" field.</summary>
    public const int AndroidPrivacyNetworkTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType androidPrivacyNetworkType_ = global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified;
    /// <summary>
    /// Output only. The network type enum used in the share key encoding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType AndroidPrivacyNetworkType {
      get { return androidPrivacyNetworkType_; }
      set {
        androidPrivacyNetworkType_ = value;
      }
    }

    /// <summary>Field number for the "shared_network_type_key" field.</summary>
    public const int SharedNetworkTypeKeyFieldNumber = 6;
    private string sharedNetworkTypeKey_ = "";
    /// <summary>
    /// Output only. 128 bit hex string of the encoded shared network type key,
    /// including a '0x' prefix. This key can be used to do a bitwise OR operator
    /// with the aggregate conversion key to create a full aggregation key to
    /// retrieve the Aggregate API Report in Android Privacy Sandbox.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SharedNetworkTypeKey {
      get { return sharedNetworkTypeKey_; }
      set {
        sharedNetworkTypeKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AndroidPrivacySharedKeyGoogleNetworkType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AndroidPrivacySharedKeyGoogleNetworkType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CampaignId != other.CampaignId) return false;
      if (AndroidPrivacyInteractionType != other.AndroidPrivacyInteractionType) return false;
      if (AndroidPrivacyInteractionDate != other.AndroidPrivacyInteractionDate) return false;
      if (AndroidPrivacyNetworkType != other.AndroidPrivacyNetworkType) return false;
      if (SharedNetworkTypeKey != other.SharedNetworkTypeKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CampaignId != 0L) hash ^= CampaignId.GetHashCode();
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) hash ^= AndroidPrivacyInteractionType.GetHashCode();
      if (AndroidPrivacyInteractionDate.Length != 0) hash ^= AndroidPrivacyInteractionDate.GetHashCode();
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) hash ^= AndroidPrivacyNetworkType.GetHashCode();
      if (SharedNetworkTypeKey.Length != 0) hash ^= SharedNetworkTypeKey.GetHashCode();
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AndroidPrivacyNetworkType);
      }
      if (SharedNetworkTypeKey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SharedNetworkTypeKey);
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) AndroidPrivacyNetworkType);
      }
      if (SharedNetworkTypeKey.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(SharedNetworkTypeKey);
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
      if (CampaignId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CampaignId);
      }
      if (AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AndroidPrivacyInteractionType);
      }
      if (AndroidPrivacyInteractionDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AndroidPrivacyInteractionDate);
      }
      if (AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) AndroidPrivacyNetworkType);
      }
      if (SharedNetworkTypeKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SharedNetworkTypeKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AndroidPrivacySharedKeyGoogleNetworkType other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CampaignId != 0L) {
        CampaignId = other.CampaignId;
      }
      if (other.AndroidPrivacyInteractionType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType.Unspecified) {
        AndroidPrivacyInteractionType = other.AndroidPrivacyInteractionType;
      }
      if (other.AndroidPrivacyInteractionDate.Length != 0) {
        AndroidPrivacyInteractionDate = other.AndroidPrivacyInteractionDate;
      }
      if (other.AndroidPrivacyNetworkType != global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType.Unspecified) {
        AndroidPrivacyNetworkType = other.AndroidPrivacyNetworkType;
      }
      if (other.SharedNetworkTypeKey.Length != 0) {
        SharedNetworkTypeKey = other.SharedNetworkTypeKey;
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
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            AndroidPrivacyInteractionType = (global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType) input.ReadEnum();
            break;
          }
          case 34: {
            AndroidPrivacyInteractionDate = input.ReadString();
            break;
          }
          case 40: {
            AndroidPrivacyNetworkType = (global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType) input.ReadEnum();
            break;
          }
          case 50: {
            SharedNetworkTypeKey = input.ReadString();
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
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            AndroidPrivacyInteractionType = (global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyInteractionTypeEnum.Types.AndroidPrivacyInteractionType) input.ReadEnum();
            break;
          }
          case 34: {
            AndroidPrivacyInteractionDate = input.ReadString();
            break;
          }
          case 40: {
            AndroidPrivacyNetworkType = (global::Google.Ads.GoogleAds.V20.Enums.AndroidPrivacyNetworkTypeEnum.Types.AndroidPrivacyNetworkType) input.ReadEnum();
            break;
          }
          case 50: {
            SharedNetworkTypeKey = input.ReadString();
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
