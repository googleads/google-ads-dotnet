// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/campaign_budget_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/campaign_budget_error.proto</summary>
  public static partial class CampaignBudgetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/campaign_budget_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignBudgetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2NhbXBhaWduX2J1",
            "ZGdldF9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVy",
            "cm9ycyKzBgoXQ2FtcGFpZ25CdWRnZXRFcnJvckVudW0ilwYKE0NhbXBhaWdu",
            "QnVkZ2V0RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESJAog",
            "Q0FNUEFJR05fQlVER0VUX0NBTk5PVF9CRV9TSEFSRUQQERIbChdDQU1QQUlH",
            "Tl9CVURHRVRfUkVNT1ZFRBACEhoKFkNBTVBBSUdOX0JVREdFVF9JTl9VU0UQ",
            "AxIoCiRDQU1QQUlHTl9CVURHRVRfUEVSSU9EX05PVF9BVkFJTEFCTEUQBBI8",
            "CjhDQU5OT1RfTU9ESUZZX0ZJRUxEX09GX0lNUExJQ0lUTFlfU0hBUkVEX0NB",
            "TVBBSUdOX0JVREdFVBAGEjYKMkNBTk5PVF9VUERBVEVfQ0FNUEFJR05fQlVE",
            "R0VUX1RPX0lNUExJQ0lUTFlfU0hBUkVEEAcSQwo/Q0FOTk9UX1VQREFURV9D",
            "QU1QQUlHTl9CVURHRVRfVE9fRVhQTElDSVRMWV9TSEFSRURfV0lUSE9VVF9O",
            "QU1FEAgSNgoyQ0FOTk9UX1VQREFURV9DQU1QQUlHTl9CVURHRVRfVE9fRVhQ",
            "TElDSVRMWV9TSEFSRUQQCRJICkRDQU5OT1RfVVNFX0lNUExJQ0lUTFlfU0hB",
            "UkVEX0NBTVBBSUdOX0JVREdFVF9XSVRIX01VTFRJUExFX0NBTVBBSUdOUxAK",
            "EhIKDkRVUExJQ0FURV9OQU1FEAsSIgoeTU9ORVlfQU1PVU5UX0lOX1dST05H",
            "X0NVUlJFTkNZEAwSLworTU9ORVlfQU1PVU5UX0xFU1NfVEhBTl9DVVJSRU5D",
            "WV9NSU5JTVVNX0NQQxANEhoKFk1PTkVZX0FNT1VOVF9UT09fTEFSR0UQDhIZ",
            "ChVORUdBVElWRV9NT05FWV9BTU9VTlQQDxIpCiVOT05fTVVMVElQTEVfT0Zf",
            "TUlOSU1VTV9DVVJSRU5DWV9VTklUEBASPQo5VE9UQUxfQlVER0VUX0FNT1VO",
            "VF9NVVNUX0JFX1VOU0VUX0ZPUl9CVURHRVRfUEVSSU9EX0RBSUxZEBISEgoO",
            "SU5WQUxJRF9QRVJJT0QQE0L4AQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxMS5lcnJvcnNCGENhbXBhaWduQnVkZ2V0RXJyb3JQcm90b1ABWkVnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVh",
            "ZHMvdjExL2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMTEuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjExXEVy",
            "cm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMTo6RXJyb3JzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignBudgetErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.CampaignBudgetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.CampaignBudgetErrorEnum.Types.CampaignBudgetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign budget errors.
  /// </summary>
  public sealed partial class CampaignBudgetErrorEnum : pb::IMessage<CampaignBudgetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignBudgetErrorEnum> _parser = new pb::MessageParser<CampaignBudgetErrorEnum>(() => new CampaignBudgetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignBudgetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.CampaignBudgetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBudgetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBudgetErrorEnum(CampaignBudgetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignBudgetErrorEnum Clone() {
      return new CampaignBudgetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignBudgetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignBudgetErrorEnum other) {
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
    public void MergeFrom(CampaignBudgetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CampaignBudgetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign budget errors.
      /// </summary>
      public enum CampaignBudgetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The campaign budget cannot be shared.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_CANNOT_BE_SHARED")] CampaignBudgetCannotBeShared = 17,
        /// <summary>
        /// The requested campaign budget no longer exists.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_REMOVED")] CampaignBudgetRemoved = 2,
        /// <summary>
        /// The campaign budget is associated with at least one campaign, and so the
        /// campaign budget cannot be removed.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_IN_USE")] CampaignBudgetInUse = 3,
        /// <summary>
        /// Customer is not on the allow-list for this campaign budget period.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_BUDGET_PERIOD_NOT_AVAILABLE")] CampaignBudgetPeriodNotAvailable = 4,
        /// <summary>
        /// This field is not mutable on implicitly shared campaign budgets
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_FIELD_OF_IMPLICITLY_SHARED_CAMPAIGN_BUDGET")] CannotModifyFieldOfImplicitlySharedCampaignBudget = 6,
        /// <summary>
        /// Cannot change explicitly shared campaign budgets back to implicitly
        /// shared ones.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_IMPLICITLY_SHARED")] CannotUpdateCampaignBudgetToImplicitlyShared = 7,
        /// <summary>
        /// An implicit campaign budget without a name cannot be changed to
        /// explicitly shared campaign budget.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_EXPLICITLY_SHARED_WITHOUT_NAME")] CannotUpdateCampaignBudgetToExplicitlySharedWithoutName = 8,
        /// <summary>
        /// Cannot change an implicitly shared campaign budget to an explicitly
        /// shared one.
        /// </summary>
        [pbr::OriginalName("CANNOT_UPDATE_CAMPAIGN_BUDGET_TO_EXPLICITLY_SHARED")] CannotUpdateCampaignBudgetToExplicitlyShared = 9,
        /// <summary>
        /// Only explicitly shared campaign budgets can be used with multiple
        /// campaigns.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_IMPLICITLY_SHARED_CAMPAIGN_BUDGET_WITH_MULTIPLE_CAMPAIGNS")] CannotUseImplicitlySharedCampaignBudgetWithMultipleCampaigns = 10,
        /// <summary>
        /// A campaign budget with this name already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_NAME")] DuplicateName = 11,
        /// <summary>
        /// A money amount was not in the expected currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_IN_WRONG_CURRENCY")] MoneyAmountInWrongCurrency = 12,
        /// <summary>
        /// A money amount was less than the minimum CPC for currency.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_LESS_THAN_CURRENCY_MINIMUM_CPC")] MoneyAmountLessThanCurrencyMinimumCpc = 13,
        /// <summary>
        /// A money amount was greater than the maximum allowed.
        /// </summary>
        [pbr::OriginalName("MONEY_AMOUNT_TOO_LARGE")] MoneyAmountTooLarge = 14,
        /// <summary>
        /// A money amount was negative.
        /// </summary>
        [pbr::OriginalName("NEGATIVE_MONEY_AMOUNT")] NegativeMoneyAmount = 15,
        /// <summary>
        /// A money amount was not a multiple of a minimum unit.
        /// </summary>
        [pbr::OriginalName("NON_MULTIPLE_OF_MINIMUM_CURRENCY_UNIT")] NonMultipleOfMinimumCurrencyUnit = 16,
        /// <summary>
        /// Total budget amount must be unset when BudgetPeriod is DAILY.
        /// </summary>
        [pbr::OriginalName("TOTAL_BUDGET_AMOUNT_MUST_BE_UNSET_FOR_BUDGET_PERIOD_DAILY")] TotalBudgetAmountMustBeUnsetForBudgetPeriodDaily = 18,
        /// <summary>
        /// The period of the budget is not allowed.
        /// </summary>
        [pbr::OriginalName("INVALID_PERIOD")] InvalidPeriod = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
