// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/conversion_goal_campaign_config_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/conversion_goal_campaign_config_error.proto</summary>
  public static partial class ConversionGoalCampaignConfigErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/conversion_goal_campaign_config_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionGoalCampaignConfigErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cktnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL2NvbnZlcnNpb25f",
            "Z29hbF9jYW1wYWlnbl9jb25maWdfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYxOS5lcnJvcnMirQMKJUNvbnZlcnNpb25Hb2FsQ2FtcGFp",
            "Z25Db25maWdFcnJvckVudW0igwMKIUNvbnZlcnNpb25Hb2FsQ2FtcGFpZ25D",
            "b25maWdFcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARJACjxD",
            "QU5OT1RfVVNFX0NBTVBBSUdOX0dPQUxfRk9SX1NFQVJDSF9BRFNfMzYwX01B",
            "TkFHRURfQ0FNUEFJR04QAhJBCj1DVVNUT01fR09BTF9ET0VTX05PVF9CRUxP",
            "TkdfVE9fR09PR0xFX0FEU19DT05WRVJTSU9OX0NVU1RPTUVSEAMSJQohQ0FN",
            "UEFJR05fQ0FOTk9UX1VTRV9VTklGSUVEX0dPQUxTEAQSGgoWRU1QVFlfQ09O",
            "VkVSU0lPTl9HT0FMUxAFEjIKLlNUT1JFX1NBTEVfU1RPUkVfVklTSVRfQ0FO",
            "Tk9UX0JFX0JPVEhfSU5DTFVERUQQBhJECkBQRVJGT1JNQU5DRV9NQVhfQ0FN",
            "UEFJR05fQ0FOTk9UX1VTRV9DVVNUT01fR09BTF9XSVRIX1NUT1JFX1NBTEVT",
            "EAdChgIKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZXJyb3JzQiZD",
            "b252ZXJzaW9uR29hbENhbXBhaWduQ29uZmlnRXJyb3JQcm90b1ABWkVnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjE5L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMTkuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE5XEVy",
            "cm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6RXJyb3JzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.ConversionGoalCampaignConfigErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.ConversionGoalCampaignConfigErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.ConversionGoalCampaignConfigErrorEnum.Types.ConversionGoalCampaignConfigError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion goal campaign config
  /// errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ConversionGoalCampaignConfigErrorEnum : pb::IMessage<ConversionGoalCampaignConfigErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionGoalCampaignConfigErrorEnum> _parser = new pb::MessageParser<ConversionGoalCampaignConfigErrorEnum>(() => new ConversionGoalCampaignConfigErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionGoalCampaignConfigErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.ConversionGoalCampaignConfigErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfigErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfigErrorEnum(ConversionGoalCampaignConfigErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionGoalCampaignConfigErrorEnum Clone() {
      return new ConversionGoalCampaignConfigErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionGoalCampaignConfigErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionGoalCampaignConfigErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConversionGoalCampaignConfigErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the ConversionGoalCampaignConfigErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion goal campaign config errors.
      /// </summary>
      public enum ConversionGoalCampaignConfigError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Campaign is managed by Search Ads 360 but uses Unified Goal.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_CAMPAIGN_GOAL_FOR_SEARCH_ADS_360_MANAGED_CAMPAIGN")] CannotUseCampaignGoalForSearchAds360ManagedCampaign = 2,
        /// <summary>
        /// The campaign is using a custom goal that does not belong to its Google
        /// Ads conversion customer (conversion tracking customer).
        /// </summary>
        [pbr::OriginalName("CUSTOM_GOAL_DOES_NOT_BELONG_TO_GOOGLE_ADS_CONVERSION_CUSTOMER")] CustomGoalDoesNotBelongToGoogleAdsConversionCustomer = 3,
        /// <summary>
        /// The campaign is not allowed to use unified goals.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_USE_UNIFIED_GOALS")] CampaignCannotUseUnifiedGoals = 4,
        /// <summary>
        /// The campaign is using campaign override goals but has no goals
        /// configured.
        /// </summary>
        [pbr::OriginalName("EMPTY_CONVERSION_GOALS")] EmptyConversionGoals = 5,
        /// <summary>
        /// STORE_SALE and STORE_VISIT conversion types cannot be both included in
        /// campaign level goal.
        /// </summary>
        [pbr::OriginalName("STORE_SALE_STORE_VISIT_CANNOT_BE_BOTH_INCLUDED")] StoreSaleStoreVisitCannotBeBothIncluded = 6,
        /// <summary>
        /// Performance Max campaign is not allowed to use custom goal with store
        /// sales conversion type.
        /// </summary>
        [pbr::OriginalName("PERFORMANCE_MAX_CAMPAIGN_CANNOT_USE_CUSTOM_GOAL_WITH_STORE_SALES")] PerformanceMaxCampaignCannotUseCustomGoalWithStoreSales = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
