// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/resources/smart_campaign_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/resources/smart_campaign_setting.proto</summary>
  public static partial class SmartCampaignSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/resources/smart_campaign_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SmartCampaignSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3VyY2VzL3NtYXJ0X2Nh",
            "bXBhaWduX3NldHRpbmcucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "MC5yZXNvdXJjZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8a",
            "GWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8i2AQKFFNtYXJ0Q2FtcGFpZ25T",
            "ZXR0aW5nEkwKDXJlc291cmNlX25hbWUYASABKAlCNeBBBfpBLwotZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL1NtYXJ0Q2FtcGFpZ25TZXR0aW5nEjsKCGNh",
            "bXBhaWduGAIgASgJQingQQP6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9DYW1wYWlnbhJaCgxwaG9uZV9udW1iZXIYAyABKAsyRC5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTAucmVzb3VyY2VzLlNtYXJ0Q2FtcGFpZ25TZXR0aW5n",
            "LlBob25lTnVtYmVyEhEKCWZpbmFsX3VybBgEIAEoCRIhChlhZHZlcnRpc2lu",
            "Z19sYW5ndWFnZV9jb2RlGAcgASgJEhcKDWJ1c2luZXNzX25hbWUYBSABKAlI",
            "ABIeChRidXNpbmVzc19sb2NhdGlvbl9pZBgGIAEoA0gAGmUKC1Bob25lTnVt",
            "YmVyEhkKDHBob25lX251bWJlchgBIAEoCUgAiAEBEhkKDGNvdW50cnlfY29k",
            "ZRgCIAEoCUgBiAEBQg8KDV9waG9uZV9udW1iZXJCDwoNX2NvdW50cnlfY29k",
            "ZTpv6kFsCi1nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU21hcnRDYW1wYWln",
            "blNldHRpbmcSO2N1c3RvbWVycy97Y3VzdG9tZXJfaWR9L3NtYXJ0Q2FtcGFp",
            "Z25TZXR0aW5ncy97Y2FtcGFpZ25faWR9QhIKEGJ1c2luZXNzX3NldHRpbmdC",
            "iwIKJmNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAucmVzb3VyY2VzQhlT",
            "bWFydENhbXBhaWduU2V0dGluZ1Byb3RvUAFaS2dvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAvcmVzb3Vy",
            "Y2VzO3Jlc291cmNlc6ICA0dBQaoCIkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "MC5SZXNvdXJjZXPKAiJHb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcUmVzb3Vy",
            "Y2Vz6gImR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpSZXNvdXJjZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting), global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Parser, new[]{ "ResourceName", "Campaign", "PhoneNumber", "FinalUrl", "AdvertisingLanguageCode", "BusinessName", "BusinessLocationId" }, new[]{ "BusinessSetting" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber), global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber.Parser, new[]{ "PhoneNumber_", "CountryCode" }, new[]{ "PhoneNumber", "CountryCode" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for configuring Smart campaigns.
  /// </summary>
  public sealed partial class SmartCampaignSetting : pb::IMessage<SmartCampaignSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SmartCampaignSetting> _parser = new pb::MessageParser<SmartCampaignSetting>(() => new SmartCampaignSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SmartCampaignSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSetting(SmartCampaignSetting other) : this() {
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      phoneNumber_ = other.phoneNumber_ != null ? other.phoneNumber_.Clone() : null;
      finalUrl_ = other.finalUrl_;
      advertisingLanguageCode_ = other.advertisingLanguageCode_;
      switch (other.BusinessSettingCase) {
        case BusinessSettingOneofCase.BusinessName:
          BusinessName = other.BusinessName;
          break;
        case BusinessSettingOneofCase.BusinessLocationId:
          BusinessLocationId = other.BusinessLocationId;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SmartCampaignSetting Clone() {
      return new SmartCampaignSetting(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the Smart campaign setting.
    /// Smart campaign setting resource names have the form:
    ///
    /// `customers/{customer_id}/smartCampaignSettings/{campaign_id}`
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
    /// Output only. The campaign to which these settings apply.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "phone_number" field.</summary>
    public const int PhoneNumberFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber phoneNumber_;
    /// <summary>
    /// Phone number and country code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber PhoneNumber {
      get { return phoneNumber_; }
      set {
        phoneNumber_ = value;
      }
    }

    /// <summary>Field number for the "final_url" field.</summary>
    public const int FinalUrlFieldNumber = 4;
    private string finalUrl_ = "";
    /// <summary>
    /// Landing page url given by user for this Campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string FinalUrl {
      get { return finalUrl_; }
      set {
        finalUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "advertising_language_code" field.</summary>
    public const int AdvertisingLanguageCodeFieldNumber = 7;
    private string advertisingLanguageCode_ = "";
    /// <summary>
    /// The ISO-639-1 language code to advertise in.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdvertisingLanguageCode {
      get { return advertisingLanguageCode_; }
      set {
        advertisingLanguageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "business_name" field.</summary>
    public const int BusinessNameFieldNumber = 5;
    /// <summary>
    /// The name of the business.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BusinessName {
      get { return businessSettingCase_ == BusinessSettingOneofCase.BusinessName ? (string) businessSetting_ : ""; }
      set {
        businessSetting_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        businessSettingCase_ = BusinessSettingOneofCase.BusinessName;
      }
    }

    /// <summary>Field number for the "business_location_id" field.</summary>
    public const int BusinessLocationIdFieldNumber = 6;
    /// <summary>
    /// The ID of the Business Profile location.
    /// The location ID can be fetched by Business Profile API with its form:
    /// accounts/{accountId}/locations/{locationId}. The last {locationId}
    /// component from the Business Profile API represents the
    /// business_location_id. See the [Business Profile API]
    /// (https://developers.google.com/my-business/reference/rest/v4/accounts.locations)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BusinessLocationId {
      get { return businessSettingCase_ == BusinessSettingOneofCase.BusinessLocationId ? (long) businessSetting_ : 0L; }
      set {
        businessSetting_ = value;
        businessSettingCase_ = BusinessSettingOneofCase.BusinessLocationId;
      }
    }

    private object businessSetting_;
    /// <summary>Enum of possible cases for the "business_setting" oneof.</summary>
    public enum BusinessSettingOneofCase {
      None = 0,
      BusinessName = 5,
      BusinessLocationId = 6,
    }
    private BusinessSettingOneofCase businessSettingCase_ = BusinessSettingOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BusinessSettingOneofCase BusinessSettingCase {
      get { return businessSettingCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBusinessSetting() {
      businessSettingCase_ = BusinessSettingOneofCase.None;
      businessSetting_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SmartCampaignSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SmartCampaignSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (!object.Equals(PhoneNumber, other.PhoneNumber)) return false;
      if (FinalUrl != other.FinalUrl) return false;
      if (AdvertisingLanguageCode != other.AdvertisingLanguageCode) return false;
      if (BusinessName != other.BusinessName) return false;
      if (BusinessLocationId != other.BusinessLocationId) return false;
      if (BusinessSettingCase != other.BusinessSettingCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Campaign.Length != 0) hash ^= Campaign.GetHashCode();
      if (phoneNumber_ != null) hash ^= PhoneNumber.GetHashCode();
      if (FinalUrl.Length != 0) hash ^= FinalUrl.GetHashCode();
      if (AdvertisingLanguageCode.Length != 0) hash ^= AdvertisingLanguageCode.GetHashCode();
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessName) hash ^= BusinessName.GetHashCode();
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessLocationId) hash ^= BusinessLocationId.GetHashCode();
      hash ^= (int) businessSettingCase_;
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
      if (phoneNumber_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PhoneNumber);
      }
      if (FinalUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(FinalUrl);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessName) {
        output.WriteRawTag(42);
        output.WriteString(BusinessName);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessLocationId) {
        output.WriteRawTag(48);
        output.WriteInt64(BusinessLocationId);
      }
      if (AdvertisingLanguageCode.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(AdvertisingLanguageCode);
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
      if (phoneNumber_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PhoneNumber);
      }
      if (FinalUrl.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(FinalUrl);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessName) {
        output.WriteRawTag(42);
        output.WriteString(BusinessName);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessLocationId) {
        output.WriteRawTag(48);
        output.WriteInt64(BusinessLocationId);
      }
      if (AdvertisingLanguageCode.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(AdvertisingLanguageCode);
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
      if (phoneNumber_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PhoneNumber);
      }
      if (FinalUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FinalUrl);
      }
      if (AdvertisingLanguageCode.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdvertisingLanguageCode);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BusinessName);
      }
      if (businessSettingCase_ == BusinessSettingOneofCase.BusinessLocationId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BusinessLocationId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SmartCampaignSetting other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Campaign.Length != 0) {
        Campaign = other.Campaign;
      }
      if (other.phoneNumber_ != null) {
        if (phoneNumber_ == null) {
          PhoneNumber = new global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber();
        }
        PhoneNumber.MergeFrom(other.PhoneNumber);
      }
      if (other.FinalUrl.Length != 0) {
        FinalUrl = other.FinalUrl;
      }
      if (other.AdvertisingLanguageCode.Length != 0) {
        AdvertisingLanguageCode = other.AdvertisingLanguageCode;
      }
      switch (other.BusinessSettingCase) {
        case BusinessSettingOneofCase.BusinessName:
          BusinessName = other.BusinessName;
          break;
        case BusinessSettingOneofCase.BusinessLocationId:
          BusinessLocationId = other.BusinessLocationId;
          break;
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
            if (phoneNumber_ == null) {
              PhoneNumber = new global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber();
            }
            input.ReadMessage(PhoneNumber);
            break;
          }
          case 34: {
            FinalUrl = input.ReadString();
            break;
          }
          case 42: {
            BusinessName = input.ReadString();
            break;
          }
          case 48: {
            BusinessLocationId = input.ReadInt64();
            break;
          }
          case 58: {
            AdvertisingLanguageCode = input.ReadString();
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
            if (phoneNumber_ == null) {
              PhoneNumber = new global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Types.PhoneNumber();
            }
            input.ReadMessage(PhoneNumber);
            break;
          }
          case 34: {
            FinalUrl = input.ReadString();
            break;
          }
          case 42: {
            BusinessName = input.ReadString();
            break;
          }
          case 48: {
            BusinessLocationId = input.ReadInt64();
            break;
          }
          case 58: {
            AdvertisingLanguageCode = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SmartCampaignSetting message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Phone number and country code in smart campaign settings.
      /// </summary>
      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Ads.GoogleAds.V10.Resources.SmartCampaignSetting.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PhoneNumber(PhoneNumber other) : this() {
          phoneNumber_ = other.phoneNumber_;
          countryCode_ = other.countryCode_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "phone_number" field.</summary>
        public const int PhoneNumber_FieldNumber = 1;
        private string phoneNumber_;
        /// <summary>
        /// Phone number of the smart campaign.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string PhoneNumber_ {
          get { return phoneNumber_ ?? ""; }
          set {
            phoneNumber_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }
        /// <summary>Gets whether the "phone_number" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasPhoneNumber_ {
          get { return phoneNumber_ != null; }
        }
        /// <summary>Clears the value of the "phone_number" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearPhoneNumber_() {
          phoneNumber_ = null;
        }

        /// <summary>Field number for the "country_code" field.</summary>
        public const int CountryCodeFieldNumber = 2;
        private string countryCode_;
        /// <summary>
        /// Upper-case, two-letter country code as defined by ISO-3166.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string CountryCode {
          get { return countryCode_ ?? ""; }
          set {
            countryCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }
        /// <summary>Gets whether the "country_code" field is set</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool HasCountryCode {
          get { return countryCode_ != null; }
        }
        /// <summary>Clears the value of the "country_code" field</summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void ClearCountryCode() {
          countryCode_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (PhoneNumber_ != other.PhoneNumber_) return false;
          if (CountryCode != other.CountryCode) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (HasPhoneNumber_) hash ^= PhoneNumber_.GetHashCode();
          if (HasCountryCode) hash ^= CountryCode.GetHashCode();
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
          if (HasPhoneNumber_) {
            output.WriteRawTag(10);
            output.WriteString(PhoneNumber_);
          }
          if (HasCountryCode) {
            output.WriteRawTag(18);
            output.WriteString(CountryCode);
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
          if (HasPhoneNumber_) {
            output.WriteRawTag(10);
            output.WriteString(PhoneNumber_);
          }
          if (HasCountryCode) {
            output.WriteRawTag(18);
            output.WriteString(CountryCode);
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
          if (HasPhoneNumber_) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(PhoneNumber_);
          }
          if (HasCountryCode) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(CountryCode);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.HasPhoneNumber_) {
            PhoneNumber_ = other.PhoneNumber_;
          }
          if (other.HasCountryCode) {
            CountryCode = other.CountryCode;
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
                PhoneNumber_ = input.ReadString();
                break;
              }
              case 18: {
                CountryCode = input.ReadString();
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
                PhoneNumber_ = input.ReadString();
                break;
              }
              case 18: {
                CountryCode = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
