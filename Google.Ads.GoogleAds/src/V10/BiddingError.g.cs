// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/bidding_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/bidding_error.proto</summary>
  public static partial class BiddingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/bidding_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2JpZGRpbmdfZXJy",
            "b3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lcnJvcnMiqgoK",
            "EEJpZGRpbmdFcnJvckVudW0ilQoKDEJpZGRpbmdFcnJvchIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIrCidCSURESU5HX1NUUkFURUdZX1RSQU5T",
            "SVRJT05fTk9UX0FMTE9XRUQQAhIuCipDQU5OT1RfQVRUQUNIX0JJRERJTkdf",
            "U1RSQVRFR1lfVE9fQ0FNUEFJR04QBxIrCidJTlZBTElEX0FOT05ZTU9VU19C",
            "SURESU5HX1NUUkFURUdZX1RZUEUQChIhCh1JTlZBTElEX0JJRERJTkdfU1RS",
            "QVRFR1lfVFlQRRAOEg8KC0lOVkFMSURfQklEEBESMwovQklERElOR19TVFJB",
            "VEVHWV9OT1RfQVZBSUxBQkxFX0ZPUl9BQ0NPVU5UX1RZUEUQEhIjCh9DT05W",
            "RVJTSU9OX1RSQUNLSU5HX05PVF9FTkFCTEVEEBMSGgoWTk9UX0VOT1VHSF9D",
            "T05WRVJTSU9OUxAUEjAKLENBTk5PVF9DUkVBVEVfQ0FNUEFJR05fV0lUSF9C",
            "SURESU5HX1NUUkFURUdZEBUSTwpLQ0FOTk9UX1RBUkdFVF9DT05URU5UX05F",
            "VFdPUktfT05MWV9XSVRIX0NBTVBBSUdOX0xFVkVMX1BPUF9CSURESU5HX1NU",
            "UkFURUdZEBcSMwovQklERElOR19TVFJBVEVHWV9OT1RfU1VQUE9SVEVEX1dJ",
            "VEhfQURfU0NIRURVTEUQGBIxCi1QQVlfUEVSX0NPTlZFUlNJT05fTk9UX0FW",
            "QUlMQUJMRV9GT1JfQ1VTVE9NRVIQGRIyCi5QQVlfUEVSX0NPTlZFUlNJT05f",
            "Tk9UX0FMTE9XRURfV0lUSF9UQVJHRVRfQ1BBEBoSOgo2QklERElOR19TVFJB",
            "VEVHWV9OT1RfQUxMT1dFRF9GT1JfU0VBUkNIX09OTFlfQ0FNUEFJR05TEBsS",
            "Owo3QklERElOR19TVFJBVEVHWV9OT1RfU1VQUE9SVEVEX0lOX0RSQUZUU19P",
            "Ul9FWFBFUklNRU5UUxAcEkkKRUJJRERJTkdfU1RSQVRFR1lfVFlQRV9ET0VT",
            "X05PVF9TVVBQT1JUX1BST0RVQ1RfVFlQRV9BREdST1VQX0NSSVRFUklPThAd",
            "EhEKDUJJRF9UT09fU01BTEwQHhIPCgtCSURfVE9PX0JJRxAfEiIKHkJJRF9U",
            "T09fTUFOWV9GUkFDVElPTkFMX0RJR0lUUxAgEhcKE0lOVkFMSURfRE9NQUlO",
            "X05BTUUQIRIkCiBOT1RfQ09NUEFUSUJMRV9XSVRIX1BBWU1FTlRfTU9ERRAi",
            "EiMKH05PVF9DT01QQVRJQkxFX1dJVEhfQlVER0VUX1RZUEUQIxItCilOT1Rf",
            "Q09NUEFUSUJMRV9XSVRIX0JJRERJTkdfU1RSQVRFR1lfVFlQRRAkEjkKNUJJ",
            "RERJTkdfU1RSQVRFR1lfVFlQRV9JTkNPTVBBVElCTEVfV0lUSF9TSEFSRURf",
            "QlVER0VUECUSLworQklERElOR19TVFJBVEVHWV9BTkRfQlVER0VUX01VU1Rf",
            "QkVfQUxJR05FRBAmEk8KS0JJRERJTkdfU1RSQVRFR1lfQU5EX0JVREdFVF9N",
            "VVNUX0JFX0FUVEFDSEVEX1RPX1RIRV9TQU1FX0NBTVBBSUdOU19UT19BTElH",
            "ThAnEjgKNEJJRERJTkdfU1RSQVRFR1lfQU5EX0JVREdFVF9NVVNUX0JFX1JF",
            "TU9WRURfVE9HRVRIRVIQKELxAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxMC5lcnJvcnNCEUJpZGRpbmdFcnJvclByb3RvUAFaRWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "MC5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTBcRXJyb3Jz6gIj",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.BiddingErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.BiddingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.BiddingErrorEnum.Types.BiddingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bidding errors.
  /// </summary>
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
      get { return global::Google.Ads.GoogleAds.V10.Errors.BiddingErrorReflection.Descriptor.MessageTypes[0]; }
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
        /// Conversion tracking is not enabled in the campaign that has value-based
        /// bidding transitions.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_NOT_ENABLED")] ConversionTrackingNotEnabled = 19,
        /// <summary>
        /// Not enough conversions tracked for value-based bidding transitions.
        /// </summary>
        [pbr::OriginalName("NOT_ENOUGH_CONVERSIONS")] NotEnoughConversions = 20,
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
        /// The field is not compatible with the budget type.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_BUDGET_TYPE")] NotCompatibleWithBudgetType = 35,
        /// <summary>
        /// The field is not compatible with the bidding strategy type.
        /// </summary>
        [pbr::OriginalName("NOT_COMPATIBLE_WITH_BIDDING_STRATEGY_TYPE")] NotCompatibleWithBiddingStrategyType = 36,
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
