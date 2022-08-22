// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/app_campaign_bidding_strategy_goal_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/app_campaign_bidding_strategy_goal_type.proto</summary>
  public static partial class AppCampaignBiddingStrategyGoalTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/app_campaign_bidding_strategy_goal_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppCampaignBiddingStrategyGoalTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvYXBwX2NhbXBhaWdu",
            "X2JpZGRpbmdfc3RyYXRlZ3lfZ29hbF90eXBlLnByb3RvEh5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MTAuZW51bXMikwMKJkFwcENhbXBhaWduQmlkZGluZ1N0",
            "cmF0ZWd5R29hbFR5cGVFbnVtIugCCiJBcHBDYW1wYWlnbkJpZGRpbmdTdHJh",
            "dGVneUdvYWxUeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEikK",
            "JU9QVElNSVpFX0lOU1RBTExTX1RBUkdFVF9JTlNUQUxMX0NPU1QQAhIzCi9P",
            "UFRJTUlaRV9JTl9BUFBfQ09OVkVSU0lPTlNfVEFSR0VUX0lOU1RBTExfQ09T",
            "VBADEjYKMk9QVElNSVpFX0lOX0FQUF9DT05WRVJTSU9OU19UQVJHRVRfQ09O",
            "VkVSU0lPTl9DT1NUEAQSKAokT1BUSU1JWkVfUkVUVVJOX09OX0FEVkVSVElT",
            "SU5HX1NQRU5EEAUSLworT1BUSU1JWkVfUFJFX1JFR0lTVFJBVElPTl9DT05W",
            "RVJTSU9OX1ZPTFVNRRAGEjEKLU9QVElNSVpFX0lOU1RBTExTX1dJVEhPVVRf",
            "VEFSR0VUX0lOU1RBTExfQ09TVBAHQoECCiJjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjEwLmVudW1zQidBcHBDYW1wYWlnbkJpZGRpbmdTdHJhdGVneUdv",
            "YWxUeXBlUHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMC9lbnVtcztlbnVtc6ICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMC5FbnVtc8oCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxMFxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.AppCampaignBiddingStrategyGoalTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.AppCampaignBiddingStrategyGoalTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.AppCampaignBiddingStrategyGoalTypeEnum.Types.AppCampaignBiddingStrategyGoalType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing goal towards which the bidding strategy of an
  /// app campaign should optimize for.
  /// </summary>
  public sealed partial class AppCampaignBiddingStrategyGoalTypeEnum : pb::IMessage<AppCampaignBiddingStrategyGoalTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum> _parser = new pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum>(() => new AppCampaignBiddingStrategyGoalTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AppCampaignBiddingStrategyGoalTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.AppCampaignBiddingStrategyGoalTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AppCampaignBiddingStrategyGoalTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AppCampaignBiddingStrategyGoalTypeEnum(AppCampaignBiddingStrategyGoalTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AppCampaignBiddingStrategyGoalTypeEnum Clone() {
      return new AppCampaignBiddingStrategyGoalTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AppCampaignBiddingStrategyGoalTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AppCampaignBiddingStrategyGoalTypeEnum other) {
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
    public void MergeFrom(AppCampaignBiddingStrategyGoalTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AppCampaignBiddingStrategyGoalTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Goal type of App campaign BiddingStrategy.
      /// </summary>
      public enum AppCampaignBiddingStrategyGoalType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Aim to maximize the number of app installs. The cpa bid is the
        /// target cost per install.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_INSTALLS_TARGET_INSTALL_COST")] OptimizeInstallsTargetInstallCost = 2,
        /// <summary>
        /// Aim to maximize the long term number of selected in-app conversions from
        /// app installs. The cpa bid is the target cost per install.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_IN_APP_CONVERSIONS_TARGET_INSTALL_COST")] OptimizeInAppConversionsTargetInstallCost = 3,
        /// <summary>
        /// Aim to maximize the long term number of selected in-app conversions from
        /// app installs. The cpa bid is the target cost per in-app conversion. Note
        /// that the actual cpa may seem higher than the target cpa at first, since
        /// the long term conversions haven't happened yet.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_IN_APP_CONVERSIONS_TARGET_CONVERSION_COST")] OptimizeInAppConversionsTargetConversionCost = 4,
        /// <summary>
        /// Aim to maximize all conversions' value, for example, install + selected
        /// in-app conversions while achieving or exceeding target return on
        /// advertising spend.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_RETURN_ON_ADVERTISING_SPEND")] OptimizeReturnOnAdvertisingSpend = 5,
        /// <summary>
        /// Aim to maximize the pre-registration of the app.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_PRE_REGISTRATION_CONVERSION_VOLUME")] OptimizePreRegistrationConversionVolume = 6,
        /// <summary>
        /// Aim to maximize installation of the app without target cost-per-install.
        /// </summary>
        [pbr::OriginalName("OPTIMIZE_INSTALLS_WITHOUT_TARGET_INSTALL_COST")] OptimizeInstallsWithoutTargetInstallCost = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
