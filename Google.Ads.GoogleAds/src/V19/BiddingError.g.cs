// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/bidding_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/bidding_error.proto</summary>
  public static partial class BiddingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/bidding_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL2JpZGRpbmdfZXJy",
            "b3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lcnJvcnMi0wkK",
            "EEJpZGRpbmdFcnJvckVudW0ivgkKDEJpZGRpbmdFcnJvchIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIrCidCSURESU5HX1NUUkFURUdZX1RSQU5T",
            "SVRJT05fTk9UX0FMTE9XRUQQAhIuCipDQU5OT1RfQVRUQUNIX0JJRERJTkdf",
            "U1RSQVRFR1lfVE9fQ0FNUEFJR04QBxIrCidJTlZBTElEX0FOT05ZTU9VU19C",
            "SURESU5HX1NUUkFURUdZX1RZUEUQChIhCh1JTlZBTElEX0JJRERJTkdfU1RS",
            "QVRFR1lfVFlQRRAOEg8KC0lOVkFMSURfQklEEBESMwovQklERElOR19TVFJB",
            "VEVHWV9OT1RfQVZBSUxBQkxFX0ZPUl9BQ0NPVU5UX1RZUEUQEhIwCixDQU5O",
            "T1RfQ1JFQVRFX0NBTVBBSUdOX1dJVEhfQklERElOR19TVFJBVEVHWRAVEk8K",
            "S0NBTk5PVF9UQVJHRVRfQ09OVEVOVF9ORVRXT1JLX09OTFlfV0lUSF9DQU1Q",
            "QUlHTl9MRVZFTF9QT1BfQklERElOR19TVFJBVEVHWRAXEjMKL0JJRERJTkdf",
            "U1RSQVRFR1lfTk9UX1NVUFBPUlRFRF9XSVRIX0FEX1NDSEVEVUxFEBgSMQot",
            "UEFZX1BFUl9DT05WRVJTSU9OX05PVF9BVkFJTEFCTEVfRk9SX0NVU1RPTUVS",
            "EBkSMgouUEFZX1BFUl9DT05WRVJTSU9OX05PVF9BTExPV0VEX1dJVEhfVEFS",
            "R0VUX0NQQRAaEjoKNkJJRERJTkdfU1RSQVRFR1lfTk9UX0FMTE9XRURfRk9S",
            "X1NFQVJDSF9PTkxZX0NBTVBBSUdOUxAbEjsKN0JJRERJTkdfU1RSQVRFR1lf",
            "Tk9UX1NVUFBPUlRFRF9JTl9EUkFGVFNfT1JfRVhQRVJJTUVOVFMQHBJJCkVC",
            "SURESU5HX1NUUkFURUdZX1RZUEVfRE9FU19OT1RfU1VQUE9SVF9QUk9EVUNU",
            "X1RZUEVfQURHUk9VUF9DUklURVJJT04QHRIRCg1CSURfVE9PX1NNQUxMEB4S",
            "DwoLQklEX1RPT19CSUcQHxIiCh5CSURfVE9PX01BTllfRlJBQ1RJT05BTF9E",
            "SUdJVFMQIBIXChNJTlZBTElEX0RPTUFJTl9OQU1FECESJAogTk9UX0NPTVBB",
            "VElCTEVfV0lUSF9QQVlNRU5UX01PREUQIhI5CjVCSURESU5HX1NUUkFURUdZ",
            "X1RZUEVfSU5DT01QQVRJQkxFX1dJVEhfU0hBUkVEX0JVREdFVBAlEi8KK0JJ",
            "RERJTkdfU1RSQVRFR1lfQU5EX0JVREdFVF9NVVNUX0JFX0FMSUdORUQQJhJP",
            "CktCSURESU5HX1NUUkFURUdZX0FORF9CVURHRVRfTVVTVF9CRV9BVFRBQ0hF",
            "RF9UT19USEVfU0FNRV9DQU1QQUlHTlNfVE9fQUxJR04QJxI4CjRCSURESU5H",
            "X1NUUkFURUdZX0FORF9CVURHRVRfTVVTVF9CRV9SRU1PVkVEX1RPR0VUSEVS",
            "ECgSPAo4Q1BDX0JJRF9GTE9PUl9NSUNST1NfR1JFQVRFUl9USEFOX0NQQ19C",
            "SURfQ0VJTElOR19NSUNST1MQKULxAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxOS5lcnJvcnNCEUJpZGRpbmdFcnJvclByb3RvUAFaRWdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTkvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYxOS5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTlcRXJyb3Jz",
            "6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE5OjpFcnJvcnNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.BiddingErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.BiddingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.BiddingErrorEnum.Types.BiddingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BiddingErrorEnum : pb::IMessage<BiddingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingErrorEnum> _parser = new pb::MessageParser<BiddingErrorEnum>(() => new BiddingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BiddingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.BiddingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingErrorEnum(BiddingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingErrorEnum Clone() {
      return new BiddingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BiddingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BiddingErrorEnum other) {
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
    public void MergeFrom(BiddingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the BiddingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible bidding errors.
      /// </summary>
      public enum BiddingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot transition to new bidding strategy.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TRANSITION_NOT_ALLOWED")] BiddingStrategyTransitionNotAllowed = 2,
        /// <summary>
        /// Cannot attach bidding strategy to campaign.
        /// </summary>
        [pbr::OriginalName("CANNOT_ATTACH_BIDDING_STRATEGY_TO_CAMPAIGN")] CannotAttachBiddingStrategyToCampaign = 7,
        /// <summary>
        /// Bidding strategy is not supported or cannot be used as anonymous.
        /// </summary>
        [pbr::OriginalName("INVALID_ANONYMOUS_BIDDING_STRATEGY_TYPE")] InvalidAnonymousBiddingStrategyType = 10,
        /// <summary>
        /// The type does not match the named strategy's type.
        /// </summary>
        [pbr::OriginalName("INVALID_BIDDING_STRATEGY_TYPE")] InvalidBiddingStrategyType = 14,
        /// <summary>
        /// The bid is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_BID")] InvalidBid = 17,
        /// <summary>
        /// Bidding strategy is not available for the account type.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_AVAILABLE_FOR_ACCOUNT_TYPE")] BiddingStrategyNotAvailableForAccountType = 18,
        /// <summary>
        /// Campaign can not be created with given bidding strategy. It can be
        /// transitioned to the strategy, once eligible.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_CAMPAIGN_WITH_BIDDING_STRATEGY")] CannotCreateCampaignWithBiddingStrategy = 21,
        /// <summary>
        /// Cannot target content network only as campaign uses Page One Promoted
        /// bidding strategy.
        /// </summary>
        [pbr::OriginalName("CANNOT_TARGET_CONTENT_NETWORK_ONLY_WITH_CAMPAIGN_LEVEL_POP_BIDDING_STRATEGY")] CannotTargetContentNetworkOnlyWithCampaignLevelPopBiddingStrategy = 23,
        /// <summary>
        /// Budget Optimizer and Target Spend bidding strategies are not supported
        /// for campaigns with AdSchedule targeting.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_SUPPORTED_WITH_AD_SCHEDULE")] BiddingStrategyNotSupportedWithAdSchedule = 24,
        /// <summary>
        /// Pay per conversion is not available to all the customer, only few
        /// customers on the allow-list can use this.
        /// </summary>
        [pbr::OriginalName("PAY_PER_CONVERSION_NOT_AVAILABLE_FOR_CUSTOMER")] PayPerConversionNotAvailableForCustomer = 25,
        /// <summary>
        /// Pay per conversion is not allowed with Target CPA.
        /// </summary>
        [pbr::OriginalName("PAY_PER_CONVERSION_NOT_ALLOWED_WITH_TARGET_CPA")] PayPerConversionNotAllowedWithTargetCpa = 26,
        /// <summary>
        /// Cannot set bidding strategy to Manual CPM for search network only
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_ALLOWED_FOR_SEARCH_ONLY_CAMPAIGNS")] BiddingStrategyNotAllowedForSearchOnlyCampaigns = 27,
        /// <summary>
        /// The bidding strategy is not supported for use in drafts or experiments.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_NOT_SUPPORTED_IN_DRAFTS_OR_EXPERIMENTS")] BiddingStrategyNotSupportedInDraftsOrExperiments = 28,
        /// <summary>
        /// Bidding strategy type does not support product type ad group criterion.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TYPE_DOES_NOT_SUPPORT_PRODUCT_TYPE_ADGROUP_CRITERION")] BiddingStrategyTypeDoesNotSupportProductTypeAdgroupCriterion = 29,
        /// <summary>
        /// Bid amount is too small.
        /// </summary>
        [pbr::OriginalName("BID_TOO_SMALL")] BidTooSmall = 30,
        /// <summary>
        /// Bid amount is too big.
        /// </summary>
        [pbr::OriginalName("BID_TOO_BIG")] BidTooBig = 31,
        /// <summary>
        /// Bid has too many fractional digit precision.
        /// </summary>
        [pbr::OriginalName("BID_TOO_MANY_FRACTIONAL_DIGITS")] BidTooManyFractionalDigits = 32,
        /// <summary>
        /// Invalid domain name specified.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMAIN_NAME")] InvalidDomainName = 33,
        /// <summary>
        /// The field is not compatible with the payment mode.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_PAYMENT_MODE")] NotCompatibleWithPaymentMode = 34,
        /// <summary>
        /// Bidding strategy type is incompatible with shared budget.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_TYPE_INCOMPATIBLE_WITH_SHARED_BUDGET")] BiddingStrategyTypeIncompatibleWithSharedBudget = 37,
        /// <summary>
        /// The attached bidding strategy and budget must be aligned with each other
        /// if alignment is specified on either entity.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_AND_BUDGET_MUST_BE_ALIGNED")] BiddingStrategyAndBudgetMustBeAligned = 38,
        /// <summary>
        /// The attached bidding strategy and budget must be attached to the same
        /// campaigns to become aligned.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_AND_BUDGET_MUST_BE_ATTACHED_TO_THE_SAME_CAMPAIGNS_TO_ALIGN")] BiddingStrategyAndBudgetMustBeAttachedToTheSameCampaignsToAlign = 39,
        /// <summary>
        /// The aligned bidding strategy and budget must be removed at the same time.
        /// </summary>
        [pbr::OriginalName("BIDDING_STRATEGY_AND_BUDGET_MUST_BE_REMOVED_TOGETHER")] BiddingStrategyAndBudgetMustBeRemovedTogether = 40,
        /// <summary>
        /// cpc_bid_floor_micros is greater than cpc_bid_ceiling_micros.
        /// </summary>
        [pbr::OriginalName("CPC_BID_FLOOR_MICROS_GREATER_THAN_CPC_BID_CEILING_MICROS")] CpcBidFloorMicrosGreaterThanCpcBidCeilingMicros = 41,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
