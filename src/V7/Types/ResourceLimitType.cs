// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/enums/resource_limit_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/enums/resource_limit_type.proto</summary>
  public static partial class ResourceLimitTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/enums/resource_limit_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ResourceLimitTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lbnVtcy9yZXNvdXJjZV9saW1p",
            "dF90eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5lbnVtcxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLAGgoVUmVzb3VyY2VMaW1p",
            "dFR5cGVFbnVtIqYaChFSZXNvdXJjZUxpbWl0VHlwZRIPCgtVTlNQRUNJRklF",
            "RBAAEgsKB1VOS05PV04QARIaChZDQU1QQUlHTlNfUEVSX0NVU1RPTUVSEAIS",
            "HwobQkFTRV9DQU1QQUlHTlNfUEVSX0NVU1RPTUVSEAMSJQohRVhQRVJJTUVO",
            "VF9DQU1QQUlHTlNfUEVSX0NVU1RPTUVSEGkSIAocSE9URUxfQ0FNUEFJR05T",
            "X1BFUl9DVVNUT01FUhAEEikKJVNNQVJUX1NIT1BQSU5HX0NBTVBBSUdOU19Q",
            "RVJfQ1VTVE9NRVIQBRIaChZBRF9HUk9VUFNfUEVSX0NBTVBBSUdOEAYSIwof",
            "QURfR1JPVVBTX1BFUl9TSE9QUElOR19DQU1QQUlHThAIEiAKHEFEX0dST1VQ",
            "U19QRVJfSE9URUxfQ0FNUEFJR04QCRIqCiZSRVBPUlRJTkdfQURfR1JPVVBT",
            "X1BFUl9MT0NBTF9DQU1QQUlHThAKEigKJFJFUE9SVElOR19BRF9HUk9VUFNf",
            "UEVSX0FQUF9DQU1QQUlHThALEigKJE1BTkFHRURfQURfR1JPVVBTX1BFUl9T",
            "TUFSVF9DQU1QQUlHThA0EiIKHkFEX0dST1VQX0NSSVRFUklBX1BFUl9DVVNU",
            "T01FUhAMEicKI0JBU0VfQURfR1JPVVBfQ1JJVEVSSUFfUEVSX0NVU1RPTUVS",
            "EA0SLQopRVhQRVJJTUVOVF9BRF9HUk9VUF9DUklURVJJQV9QRVJfQ1VTVE9N",
            "RVIQaxIiCh5BRF9HUk9VUF9DUklURVJJQV9QRVJfQ0FNUEFJR04QDhIiCh5D",
            "QU1QQUlHTl9DUklURVJJQV9QRVJfQ1VTVE9NRVIQDxInCiNCQVNFX0NBTVBB",
            "SUdOX0NSSVRFUklBX1BFUl9DVVNUT01FUhAQEi0KKUVYUEVSSU1FTlRfQ0FN",
            "UEFJR05fQ1JJVEVSSUFfUEVSX0NVU1RPTUVSEGwSIQodV0VCUEFHRV9DUklU",
            "RVJJQV9QRVJfQ1VTVE9NRVIQERImCiJCQVNFX1dFQlBBR0VfQ1JJVEVSSUFf",
            "UEVSX0NVU1RPTUVSEBISLAooRVhQRVJJTUVOVF9XRUJQQUdFX0NSSVRFUklB",
            "X1BFUl9DVVNUT01FUhATEisKJ0NPTUJJTkVEX0FVRElFTkNFX0NSSVRFUklB",
            "X1BFUl9BRF9HUk9VUBAUEjUKMUNVU1RPTUVSX05FR0FUSVZFX1BMQUNFTUVO",
            "VF9DUklURVJJQV9QRVJfQ1VTVE9NRVIQFRI7CjdDVVNUT01FUl9ORUdBVElW",
            "RV9ZT1VUVUJFX0NIQU5ORUxfQ1JJVEVSSUFfUEVSX0NVU1RPTUVSEBYSGQoV",
            "Q1JJVEVSSUFfUEVSX0FEX0dST1VQEBcSHwobTElTVElOR19HUk9VUFNfUEVS",
            "X0FEX0dST1VQEBgSKgomRVhQTElDSVRMWV9TSEFSRURfQlVER0VUU19QRVJf",
            "Q1VTVE9NRVIQGRIqCiZJTVBMSUNJVExZX1NIQVJFRF9CVURHRVRTX1BFUl9D",
            "VVNUT01FUhAaEisKJ0NPTUJJTkVEX0FVRElFTkNFX0NSSVRFUklBX1BFUl9D",
            "QU1QQUlHThAbEiIKHk5FR0FUSVZFX0tFWVdPUkRTX1BFUl9DQU1QQUlHThAc",
            "EiQKIE5FR0FUSVZFX1BMQUNFTUVOVFNfUEVSX0NBTVBBSUdOEB0SHAoYR0VP",
            "X1RBUkdFVFNfUEVSX0NBTVBBSUdOEB4SIwofTkVHQVRJVkVfSVBfQkxPQ0tT",
            "X1BFUl9DQU1QQUlHThAgEhwKGFBST1hJTUlUSUVTX1BFUl9DQU1QQUlHThAh",
            "EigKJExJU1RJTkdfU0NPUEVTX1BFUl9TSE9QUElOR19DQU1QQUlHThAiEiwK",
            "KExJU1RJTkdfU0NPUEVTX1BFUl9OT05fU0hPUFBJTkdfQ0FNUEFJR04QIxIk",
            "CiBORUdBVElWRV9LRVlXT1JEU19QRVJfU0hBUkVEX1NFVBAkEiYKIk5FR0FU",
            "SVZFX1BMQUNFTUVOVFNfUEVSX1NIQVJFRF9TRVQQJRItCilTSEFSRURfU0VU",
            "U19QRVJfQ1VTVE9NRVJfRk9SX1RZUEVfREVGQVVMVBAoEj4KOlNIQVJFRF9T",
            "RVRTX1BFUl9DVVNUT01FUl9GT1JfTkVHQVRJVkVfUExBQ0VNRU5UX0xJU1Rf",
            "TE9XRVIQKRI7CjdIT1RFTF9BRFZBTkNFX0JPT0tJTkdfV0lORE9XX0JJRF9N",
            "T0RJRklFUlNfUEVSX0FEX0dST1VQECwSIwofQklERElOR19TVFJBVEVHSUVT",
            "X1BFUl9DVVNUT01FUhAtEiEKHUJBU0lDX1VTRVJfTElTVFNfUEVSX0NVU1RP",
            "TUVSEC8SIwofTE9HSUNBTF9VU0VSX0xJU1RTX1BFUl9DVVNUT01FUhAwEiIK",
            "HkJBU0VfQURfR1JPVVBfQURTX1BFUl9DVVNUT01FUhA1EigKJEVYUEVSSU1F",
            "TlRfQURfR1JPVVBfQURTX1BFUl9DVVNUT01FUhA2Eh0KGUFEX0dST1VQX0FE",
            "U19QRVJfQ0FNUEFJR04QNxIjCh9URVhUX0FORF9PVEhFUl9BRFNfUEVSX0FE",
            "X0dST1VQEDgSGgoWSU1BR0VfQURTX1BFUl9BRF9HUk9VUBA5EiMKH1NIT1BQ",
            "SU5HX1NNQVJUX0FEU19QRVJfQURfR1JPVVAQOhImCiJSRVNQT05TSVZFX1NF",
            "QVJDSF9BRFNfUEVSX0FEX0dST1VQEDsSGAoUQVBQX0FEU19QRVJfQURfR1JP",
            "VVAQPBIjCh9BUFBfRU5HQUdFTUVOVF9BRFNfUEVSX0FEX0dST1VQED0SGgoW",
            "TE9DQUxfQURTX1BFUl9BRF9HUk9VUBA+EhoKFlZJREVPX0FEU19QRVJfQURf",
            "R1JPVVAQPxImCiJMRUFEX0ZPUk1fQVNTRVRfTElOS1NfUEVSX0NBTVBBSUdO",
            "EEQSEwoPVkVSU0lPTlNfUEVSX0FEEFISGwoXVVNFUl9GRUVEU19QRVJfQ1VT",
            "VE9NRVIQWhIdChlTWVNURU1fRkVFRFNfUEVSX0NVU1RPTUVSEFsSHAoYRkVF",
            "RF9BVFRSSUJVVEVTX1BFUl9GRUVEEFwSGwoXRkVFRF9JVEVNU19QRVJfQ1VT",
            "VE9NRVIQXhIfChtDQU1QQUlHTl9GRUVEU19QRVJfQ1VTVE9NRVIQXxIkCiBC",
            "QVNFX0NBTVBBSUdOX0ZFRURTX1BFUl9DVVNUT01FUhBgEioKJkVYUEVSSU1F",
            "TlRfQ0FNUEFJR05fRkVFRFNfUEVSX0NVU1RPTUVSEG0SHwobQURfR1JPVVBf",
            "RkVFRFNfUEVSX0NVU1RPTUVSEGESJAogQkFTRV9BRF9HUk9VUF9GRUVEU19Q",
            "RVJfQ1VTVE9NRVIQYhIqCiZFWFBFUklNRU5UX0FEX0dST1VQX0ZFRURTX1BF",
            "Ul9DVVNUT01FUhBuEh8KG0FEX0dST1VQX0ZFRURTX1BFUl9DQU1QQUlHThBj",
            "Eh8KG0ZFRURfSVRFTV9TRVRTX1BFUl9DVVNUT01FUhBkEiAKHEZFRURfSVRF",
            "TVNfUEVSX0ZFRURfSVRFTV9TRVQQZRIlCiFDQU1QQUlHTl9FWFBFUklNRU5U",
            "U19QRVJfQ1VTVE9NRVIQcBIoCiRFWFBFUklNRU5UX0FSTVNfUEVSX1ZJREVP",
            "X0VYUEVSSU1FTlQQcRIdChlPV05FRF9MQUJFTFNfUEVSX0NVU1RPTUVSEHMS",
            "FwoTTEFCRUxTX1BFUl9DQU1QQUlHThB1EhcKE0xBQkVMU19QRVJfQURfR1JP",
            "VVAQdhIaChZMQUJFTFNfUEVSX0FEX0dST1VQX0FEEHcSIQodTEFCRUxTX1BF",
            "Ul9BRF9HUk9VUF9DUklURVJJT04QeBIeChpUQVJHRVRfQ1VTVE9NRVJTX1BF",
            "Ul9MQUJFTBB5EicKI0tFWVdPUkRfUExBTlNfUEVSX1VTRVJfUEVSX0NVU1RP",
            "TUVSEHoSMwovS0VZV09SRF9QTEFOX0FEX0dST1VQX0tFWVdPUkRTX1BFUl9L",
            "RVlXT1JEX1BMQU4QexIrCidLRVlXT1JEX1BMQU5fQURfR1JPVVBTX1BFUl9L",
            "RVlXT1JEX1BMQU4QfBIzCi9LRVlXT1JEX1BMQU5fTkVHQVRJVkVfS0VZV09S",
            "RFNfUEVSX0tFWVdPUkRfUExBThB9EisKJ0tFWVdPUkRfUExBTl9DQU1QQUlH",
            "TlNfUEVSX0tFWVdPUkRfUExBThB+EiQKH0NPTlZFUlNJT05fQUNUSU9OU19Q",
            "RVJfQ1VTVE9NRVIQgAESIQocQkFUQ0hfSk9CX09QRVJBVElPTlNfUEVSX0pP",
            "QhCCARIcChdCQVRDSF9KT0JTX1BFUl9DVVNUT01FUhCDARI5CjRIT1RFTF9D",
            "SEVDS19JTl9EQVRFX1JBTkdFX0JJRF9NT0RJRklFUlNfUEVSX0FEX0dST1VQ",
            "EIQBQusBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXNCFlJl",
            "c291cmNlTGltaXRUeXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y3L2VudW1zO2VudW1z",
            "ogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjcuRW51bXPKAh1Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWN1xFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlY3OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Enums.ResourceLimitTypeEnum), global::Google.Ads.GoogleAds.V7.Enums.ResourceLimitTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Enums.ResourceLimitTypeEnum.Types.ResourceLimitType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible resource limit types.
  /// </summary>
  public sealed partial class ResourceLimitTypeEnum : pb::IMessage<ResourceLimitTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ResourceLimitTypeEnum> _parser = new pb::MessageParser<ResourceLimitTypeEnum>(() => new ResourceLimitTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ResourceLimitTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Enums.ResourceLimitTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceLimitTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceLimitTypeEnum(ResourceLimitTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ResourceLimitTypeEnum Clone() {
      return new ResourceLimitTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ResourceLimitTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ResourceLimitTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ResourceLimitTypeEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ResourceLimitTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Resource limit type.
      /// </summary>
      public enum ResourceLimitType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified operation unknown
        /// in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Number of ENABLED and PAUSED campaigns per customer.
        /// </summary>
        [pbr::OriginalName("CAMPAIGNS_PER_CUSTOMER")] CampaignsPerCustomer = 2,
        /// <summary>
        /// Number of ENABLED and PAUSED base campaigns per customer.
        /// </summary>
        [pbr::OriginalName("BASE_CAMPAIGNS_PER_CUSTOMER")] BaseCampaignsPerCustomer = 3,
        /// <summary>
        /// Number of ENABLED and PAUSED experiment campaigns per customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_CAMPAIGNS_PER_CUSTOMER")] ExperimentCampaignsPerCustomer = 105,
        /// <summary>
        /// Number of ENABLED and PAUSED Hotel campaigns per customer.
        /// </summary>
        [pbr::OriginalName("HOTEL_CAMPAIGNS_PER_CUSTOMER")] HotelCampaignsPerCustomer = 4,
        /// <summary>
        /// Number of ENABLED and PAUSED Smart Shopping campaigns per customer.
        /// </summary>
        [pbr::OriginalName("SMART_SHOPPING_CAMPAIGNS_PER_CUSTOMER")] SmartShoppingCampaignsPerCustomer = 5,
        /// <summary>
        /// Number of ENABLED ad groups per campaign.
        /// </summary>
        [pbr::OriginalName("AD_GROUPS_PER_CAMPAIGN")] AdGroupsPerCampaign = 6,
        /// <summary>
        /// Number of ENABLED ad groups per Shopping campaign.
        /// </summary>
        [pbr::OriginalName("AD_GROUPS_PER_SHOPPING_CAMPAIGN")] AdGroupsPerShoppingCampaign = 8,
        /// <summary>
        /// Number of ENABLED ad groups per Hotel campaign.
        /// </summary>
        [pbr::OriginalName("AD_GROUPS_PER_HOTEL_CAMPAIGN")] AdGroupsPerHotelCampaign = 9,
        /// <summary>
        /// Number of ENABLED reporting ad groups per local campaign.
        /// </summary>
        [pbr::OriginalName("REPORTING_AD_GROUPS_PER_LOCAL_CAMPAIGN")] ReportingAdGroupsPerLocalCampaign = 10,
        /// <summary>
        /// Number of ENABLED reporting ad groups per App campaign. It includes app
        /// campaign and app campaign for engagement.
        /// </summary>
        [pbr::OriginalName("REPORTING_AD_GROUPS_PER_APP_CAMPAIGN")] ReportingAdGroupsPerAppCampaign = 11,
        /// <summary>
        /// Number of ENABLED managed ad groups per smart campaign.
        /// </summary>
        [pbr::OriginalName("MANAGED_AD_GROUPS_PER_SMART_CAMPAIGN")] ManagedAdGroupsPerSmartCampaign = 52,
        /// <summary>
        /// Number of ENABLED ad group criteria per customer.
        /// An ad group criterion is considered as ENABLED if:
        /// 1. it's not REMOVED
        /// 2. its ad group is not REMOVED
        /// 3. its campaign is not REMOVED.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERIA_PER_CUSTOMER")] AdGroupCriteriaPerCustomer = 12,
        /// <summary>
        /// Number of ad group criteria across all base campaigns for a customer.
        /// </summary>
        [pbr::OriginalName("BASE_AD_GROUP_CRITERIA_PER_CUSTOMER")] BaseAdGroupCriteriaPerCustomer = 13,
        /// <summary>
        /// Number of ad group criteria across all experiment campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_AD_GROUP_CRITERIA_PER_CUSTOMER")] ExperimentAdGroupCriteriaPerCustomer = 107,
        /// <summary>
        /// Number of ENABLED ad group criteria per campaign.
        /// An ad group criterion is considered as ENABLED if:
        /// 1. it's not REMOVED
        /// 2. its ad group is not REMOVED.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERIA_PER_CAMPAIGN")] AdGroupCriteriaPerCampaign = 14,
        /// <summary>
        /// Number of ENABLED campaign criteria per customer.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CRITERIA_PER_CUSTOMER")] CampaignCriteriaPerCustomer = 15,
        /// <summary>
        /// Number of ENABLED campaign criteria across all base campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("BASE_CAMPAIGN_CRITERIA_PER_CUSTOMER")] BaseCampaignCriteriaPerCustomer = 16,
        /// <summary>
        /// Number of ENABLED campaign criteria across all experiment campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_CAMPAIGN_CRITERIA_PER_CUSTOMER")] ExperimentCampaignCriteriaPerCustomer = 108,
        /// <summary>
        /// Number of ENABLED webpage criteria per customer, including
        /// campaign level and ad group level.
        /// </summary>
        [pbr::OriginalName("WEBPAGE_CRITERIA_PER_CUSTOMER")] WebpageCriteriaPerCustomer = 17,
        /// <summary>
        /// Number of ENABLED webpage criteria across all base campaigns for
        /// a customer.
        /// </summary>
        [pbr::OriginalName("BASE_WEBPAGE_CRITERIA_PER_CUSTOMER")] BaseWebpageCriteriaPerCustomer = 18,
        /// <summary>
        /// Meximum number of ENABLED webpage criteria across all experiment
        /// campaigns for a customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_WEBPAGE_CRITERIA_PER_CUSTOMER")] ExperimentWebpageCriteriaPerCustomer = 19,
        /// <summary>
        /// Number of combined audience criteria per ad group.
        /// </summary>
        [pbr::OriginalName("COMBINED_AUDIENCE_CRITERIA_PER_AD_GROUP")] CombinedAudienceCriteriaPerAdGroup = 20,
        /// <summary>
        /// Limit for placement criterion type group in customer negative criterion.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NEGATIVE_PLACEMENT_CRITERIA_PER_CUSTOMER")] CustomerNegativePlacementCriteriaPerCustomer = 21,
        /// <summary>
        /// Limit for YouTube TV channels in customer negative criterion.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NEGATIVE_YOUTUBE_CHANNEL_CRITERIA_PER_CUSTOMER")] CustomerNegativeYoutubeChannelCriteriaPerCustomer = 22,
        /// <summary>
        /// Number of ENABLED criteria per ad group.
        /// </summary>
        [pbr::OriginalName("CRITERIA_PER_AD_GROUP")] CriteriaPerAdGroup = 23,
        /// <summary>
        /// Number of listing group criteria per ad group.
        /// </summary>
        [pbr::OriginalName("LISTING_GROUPS_PER_AD_GROUP")] ListingGroupsPerAdGroup = 24,
        /// <summary>
        /// Number of ENABLED explicitly shared budgets per customer.
        /// </summary>
        [pbr::OriginalName("EXPLICITLY_SHARED_BUDGETS_PER_CUSTOMER")] ExplicitlySharedBudgetsPerCustomer = 25,
        /// <summary>
        /// Number of ENABLED implicitly shared budgets per customer.
        /// </summary>
        [pbr::OriginalName("IMPLICITLY_SHARED_BUDGETS_PER_CUSTOMER")] ImplicitlySharedBudgetsPerCustomer = 26,
        /// <summary>
        /// Number of combined audience criteria per campaign.
        /// </summary>
        [pbr::OriginalName("COMBINED_AUDIENCE_CRITERIA_PER_CAMPAIGN")] CombinedAudienceCriteriaPerCampaign = 27,
        /// <summary>
        /// Number of negative keywords per campaign.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_KEYWORDS_PER_CAMPAIGN")] NegativeKeywordsPerCampaign = 28,
        /// <summary>
        /// Number of excluded campaign criteria in placement dimension, e.g.
        /// placement, mobile application, YouTube channel, etc. The API criterion
        /// type is NOT limited to placement only, and this does not include
        /// exclusions at the ad group or other levels.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_PLACEMENTS_PER_CAMPAIGN")] NegativePlacementsPerCampaign = 29,
        /// <summary>
        /// Number of geo targets per campaign.
        /// </summary>
        [pbr::OriginalName("GEO_TARGETS_PER_CAMPAIGN")] GeoTargetsPerCampaign = 30,
        /// <summary>
        /// Number of negative IP blocks per campaign.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_IP_BLOCKS_PER_CAMPAIGN")] NegativeIpBlocksPerCampaign = 32,
        /// <summary>
        /// Number of proximity targets per campaign.
        /// </summary>
        [pbr::OriginalName("PROXIMITIES_PER_CAMPAIGN")] ProximitiesPerCampaign = 33,
        /// <summary>
        /// Number of listing scopes per Shopping campaign.
        /// </summary>
        [pbr::OriginalName("LISTING_SCOPES_PER_SHOPPING_CAMPAIGN")] ListingScopesPerShoppingCampaign = 34,
        /// <summary>
        /// Number of listing scopes per non-Shopping campaign.
        /// </summary>
        [pbr::OriginalName("LISTING_SCOPES_PER_NON_SHOPPING_CAMPAIGN")] ListingScopesPerNonShoppingCampaign = 35,
        /// <summary>
        /// Number of criteria per negative keyword shared set.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_KEYWORDS_PER_SHARED_SET")] NegativeKeywordsPerSharedSet = 36,
        /// <summary>
        /// Number of criteria per negative placement shared set.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_PLACEMENTS_PER_SHARED_SET")] NegativePlacementsPerSharedSet = 37,
        /// <summary>
        /// Default number of shared sets allowed per type per customer.
        /// </summary>
        [pbr::OriginalName("SHARED_SETS_PER_CUSTOMER_FOR_TYPE_DEFAULT")] SharedSetsPerCustomerForTypeDefault = 40,
        /// <summary>
        /// Number of shared sets of negative placement list type for a
        /// manager customer.
        /// </summary>
        [pbr::OriginalName("SHARED_SETS_PER_CUSTOMER_FOR_NEGATIVE_PLACEMENT_LIST_LOWER")] SharedSetsPerCustomerForNegativePlacementListLower = 41,
        /// <summary>
        /// Number of hotel_advance_booking_window bid modifiers per ad group.
        /// </summary>
        [pbr::OriginalName("HOTEL_ADVANCE_BOOKING_WINDOW_BID_MODIFIERS_PER_AD_GROUP")] HotelAdvanceBookingWindowBidModifiersPerAdGroup = 44,
        /// <summary>
        /// Number of ENABLED shared bidding strategies per customer.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGIES_PER_CUSTOMER")] BiddingStrategiesPerCustomer = 45,
        /// <summary>
        /// Number of open basic user lists per customer.
        /// </summary>
        [pbr::OriginalName("BASIC_USER_LISTS_PER_CUSTOMER")] BasicUserListsPerCustomer = 47,
        /// <summary>
        /// Number of open logical user lists per customer.
        /// </summary>
        [pbr::OriginalName("LOGICAL_USER_LISTS_PER_CUSTOMER")] LogicalUserListsPerCustomer = 48,
        /// <summary>
        /// Number of ENABLED and PAUSED ad group ads across all base campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("BASE_AD_GROUP_ADS_PER_CUSTOMER")] BaseAdGroupAdsPerCustomer = 53,
        /// <summary>
        /// Number of ENABLED and PAUSED ad group ads across all experiment campaigns
        /// for a customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_AD_GROUP_ADS_PER_CUSTOMER")] ExperimentAdGroupAdsPerCustomer = 54,
        /// <summary>
        /// Number of ENABLED and PAUSED ad group ads per campaign.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_ADS_PER_CAMPAIGN")] AdGroupAdsPerCampaign = 55,
        /// <summary>
        /// Number of ENABLED ads per ad group that do not fall in to other buckets.
        /// Includes text and many other types.
        /// </summary>
        [pbr::OriginalName("TEXT_AND_OTHER_ADS_PER_AD_GROUP")] TextAndOtherAdsPerAdGroup = 56,
        /// <summary>
        /// Number of ENABLED image ads per ad group.
        /// </summary>
        [pbr::OriginalName("IMAGE_ADS_PER_AD_GROUP")] ImageAdsPerAdGroup = 57,
        /// <summary>
        /// Number of ENABLED shopping smart ads per ad group.
        /// </summary>
        [pbr::OriginalName("SHOPPING_SMART_ADS_PER_AD_GROUP")] ShoppingSmartAdsPerAdGroup = 58,
        /// <summary>
        /// Number of ENABLED responsive search ads per ad group.
        /// </summary>
        [pbr::OriginalName("RESPONSIVE_SEARCH_ADS_PER_AD_GROUP")] ResponsiveSearchAdsPerAdGroup = 59,
        /// <summary>
        /// Number of ENABLED app ads per ad group.
        /// </summary>
        [pbr::OriginalName("APP_ADS_PER_AD_GROUP")] AppAdsPerAdGroup = 60,
        /// <summary>
        /// Number of ENABLED app engagement ads per ad group.
        /// </summary>
        [pbr::OriginalName("APP_ENGAGEMENT_ADS_PER_AD_GROUP")] AppEngagementAdsPerAdGroup = 61,
        /// <summary>
        /// Number of ENABLED local ads per ad group.
        /// </summary>
        [pbr::OriginalName("LOCAL_ADS_PER_AD_GROUP")] LocalAdsPerAdGroup = 62,
        /// <summary>
        /// Number of ENABLED video ads per ad group.
        /// </summary>
        [pbr::OriginalName("VIDEO_ADS_PER_AD_GROUP")] VideoAdsPerAdGroup = 63,
        /// <summary>
        /// Number of ENABLED lead form asset links per campaign.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_ASSET_LINKS_PER_CAMPAIGN")] LeadFormAssetLinksPerCampaign = 68,
        /// <summary>
        /// Number of versions per ad.
        /// </summary>
        [pbr::OriginalName("VERSIONS_PER_AD")] VersionsPerAd = 82,
        /// <summary>
        /// Number of ENABLED user feeds per customer.
        /// </summary>
        [pbr::OriginalName("USER_FEEDS_PER_CUSTOMER")] UserFeedsPerCustomer = 90,
        /// <summary>
        /// Number of ENABLED system feeds per customer.
        /// </summary>
        [pbr::OriginalName("SYSTEM_FEEDS_PER_CUSTOMER")] SystemFeedsPerCustomer = 91,
        /// <summary>
        /// Number of feed attributes per feed.
        /// </summary>
        [pbr::OriginalName("FEED_ATTRIBUTES_PER_FEED")] FeedAttributesPerFeed = 92,
        /// <summary>
        /// Number of ENABLED feed items per customer.
        /// </summary>
        [pbr::OriginalName("FEED_ITEMS_PER_CUSTOMER")] FeedItemsPerCustomer = 94,
        /// <summary>
        /// Number of ENABLED campaign feeds per customer.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEEDS_PER_CUSTOMER")] CampaignFeedsPerCustomer = 95,
        /// <summary>
        /// Number of ENABLED campaign feeds across all base campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("BASE_CAMPAIGN_FEEDS_PER_CUSTOMER")] BaseCampaignFeedsPerCustomer = 96,
        /// <summary>
        /// Number of ENABLED campaign feeds across all experiment campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_CAMPAIGN_FEEDS_PER_CUSTOMER")] ExperimentCampaignFeedsPerCustomer = 109,
        /// <summary>
        /// Number of ENABLED ad group feeds per customer.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEEDS_PER_CUSTOMER")] AdGroupFeedsPerCustomer = 97,
        /// <summary>
        /// Number of ENABLED ad group feeds across all base campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("BASE_AD_GROUP_FEEDS_PER_CUSTOMER")] BaseAdGroupFeedsPerCustomer = 98,
        /// <summary>
        /// Number of ENABLED ad group feeds across all experiment campaigns for a
        /// customer.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_AD_GROUP_FEEDS_PER_CUSTOMER")] ExperimentAdGroupFeedsPerCustomer = 110,
        /// <summary>
        /// Number of ENABLED ad group feeds per campaign.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEEDS_PER_CAMPAIGN")] AdGroupFeedsPerCampaign = 99,
        /// <summary>
        /// Number of ENABLED feed items per customer.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_SETS_PER_CUSTOMER")] FeedItemSetsPerCustomer = 100,
        /// <summary>
        /// Number of feed items per feed item set.
        /// </summary>
        [pbr::OriginalName("FEED_ITEMS_PER_FEED_ITEM_SET")] FeedItemsPerFeedItemSet = 101,
        /// <summary>
        /// Number of ENABLED campaign experiments per customer.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_EXPERIMENTS_PER_CUSTOMER")] CampaignExperimentsPerCustomer = 112,
        /// <summary>
        /// Number of video experiment arms per experiment.
        /// </summary>
        [pbr::OriginalName("EXPERIMENT_ARMS_PER_VIDEO_EXPERIMENT")] ExperimentArmsPerVideoExperiment = 113,
        /// <summary>
        /// Number of owned labels per customer.
        /// </summary>
        [pbr::OriginalName("OWNED_LABELS_PER_CUSTOMER")] OwnedLabelsPerCustomer = 115,
        /// <summary>
        /// Number of applied labels per campaign.
        /// </summary>
        [pbr::OriginalName("LABELS_PER_CAMPAIGN")] LabelsPerCampaign = 117,
        /// <summary>
        /// Number of applied labels per ad group.
        /// </summary>
        [pbr::OriginalName("LABELS_PER_AD_GROUP")] LabelsPerAdGroup = 118,
        /// <summary>
        /// Number of applied labels per ad group ad.
        /// </summary>
        [pbr::OriginalName("LABELS_PER_AD_GROUP_AD")] LabelsPerAdGroupAd = 119,
        /// <summary>
        /// Number of applied labels per ad group criterion.
        /// </summary>
        [pbr::OriginalName("LABELS_PER_AD_GROUP_CRITERION")] LabelsPerAdGroupCriterion = 120,
        /// <summary>
        /// Number of customers with a single label applied.
        /// </summary>
        [pbr::OriginalName("TARGET_CUSTOMERS_PER_LABEL")] TargetCustomersPerLabel = 121,
        /// <summary>
        /// Number of ENABLED keyword plans per user per customer.
        /// The limit is applied per &lt;user, customer> pair because by default a plan
        /// is private to a user of a customer. Each user of a customer has his or
        /// her own independent limit.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLANS_PER_USER_PER_CUSTOMER")] KeywordPlansPerUserPerCustomer = 122,
        /// <summary>
        /// Number of keyword plan ad group keywords per keyword plan.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_AD_GROUP_KEYWORDS_PER_KEYWORD_PLAN")] KeywordPlanAdGroupKeywordsPerKeywordPlan = 123,
        /// <summary>
        /// Number of keyword plan ad groups per keyword plan.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_AD_GROUPS_PER_KEYWORD_PLAN")] KeywordPlanAdGroupsPerKeywordPlan = 124,
        /// <summary>
        /// Number of keyword plan negative keywords (both campaign and ad group) per
        /// keyword plan.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_NEGATIVE_KEYWORDS_PER_KEYWORD_PLAN")] KeywordPlanNegativeKeywordsPerKeywordPlan = 125,
        /// <summary>
        /// Number of keyword plan campaigns per keyword plan.
        /// </summary>
        [pbr::OriginalName("KEYWORD_PLAN_CAMPAIGNS_PER_KEYWORD_PLAN")] KeywordPlanCampaignsPerKeywordPlan = 126,
        /// <summary>
        /// Number of ENABLED conversion actions per customer.
        /// </summary>
        [pbr::OriginalName("CONVERSION_ACTIONS_PER_CUSTOMER")] ConversionActionsPerCustomer = 128,
        /// <summary>
        /// Number of operations in a single batch job.
        /// </summary>
        [pbr::OriginalName("BATCH_JOB_OPERATIONS_PER_JOB")] BatchJobOperationsPerJob = 130,
        /// <summary>
        /// Number of PENDING or ENABLED batch jobs per customer.
        /// </summary>
        [pbr::OriginalName("BATCH_JOBS_PER_CUSTOMER")] BatchJobsPerCustomer = 131,
        /// <summary>
        /// Number of hotel check-in date range bid modifiers per ad agroup.
        /// </summary>
        [pbr::OriginalName("HOTEL_CHECK_IN_DATE_RANGE_BID_MODIFIERS_PER_AD_GROUP")] HotelCheckInDateRangeBidModifiersPerAdGroup = 132,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
