// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/errors/billing_setup_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/errors/billing_setup_error.proto</summary>
  public static partial class BillingSetupErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/errors/billing_setup_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BillingSetupErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZXJyb3JzL2JpbGxpbmdfc2V0",
            "dXBfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lcnJv",
            "cnMi5gYKFUJpbGxpbmdTZXR1cEVycm9yRW51bSLMBgoRQmlsbGluZ1NldHVw",
            "RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESJwojQ0FOTk9U",
            "X1VTRV9FWElTVElOR19BTkRfTkVXX0FDQ09VTlQQAhInCiNDQU5OT1RfUkVN",
            "T1ZFX1NUQVJURURfQklMTElOR19TRVRVUBADEjIKLkNBTk5PVF9DSEFOR0Vf",
            "QklMTElOR19UT19TQU1FX1BBWU1FTlRTX0FDQ09VTlQQBBIzCi9CSUxMSU5H",
            "X1NFVFVQX05PVF9QRVJNSVRURURfRk9SX0NVU1RPTUVSX1NUQVRVUxAFEhwK",
            "GElOVkFMSURfUEFZTUVOVFNfQUNDT1VOVBAGEjUKMUJJTExJTkdfU0VUVVBf",
            "Tk9UX1BFUk1JVFRFRF9GT1JfQ1VTVE9NRVJfQ0FURUdPUlkQBxIbChdJTlZB",
            "TElEX1NUQVJUX1RJTUVfVFlQRRAIEiMKH1RISVJEX1BBUlRZX0FMUkVBRFlf",
            "SEFTX0JJTExJTkcQCRIdChlCSUxMSU5HX1NFVFVQX0lOX1BST0dSRVNTEAoS",
            "GAoUTk9fU0lHTlVQX1BFUk1JU1NJT04QCxIhCh1DSEFOR0VfT0ZfQklMTF9U",
            "T19JTl9QUk9HUkVTUxAMEh4KGlBBWU1FTlRTX1BST0ZJTEVfTk9UX0ZPVU5E",
            "EA0SHgoaUEFZTUVOVFNfQUNDT1VOVF9OT1RfRk9VTkQQDhIfChtQQVlNRU5U",
            "U19QUk9GSUxFX0lORUxJR0lCTEUQDxIfChtQQVlNRU5UU19BQ0NPVU5UX0lO",
            "RUxJR0lCTEUQEBIkCiBDVVNUT01FUl9ORUVEU19JTlRFUk5BTF9BUFBST1ZB",
            "TBAREjcKM1BBWU1FTlRTX1BST0ZJTEVfTkVFRFNfU0VSVklDRV9BR1JFRU1F",
            "TlRfQUNDRVBUQU5DRRASEjYKMlBBWU1FTlRTX0FDQ09VTlRfSU5FTElHSUJM",
            "RV9DVVJSRU5DWV9DT0RFX01JU01BVENIEBMSIAocRlVUVVJFX1NUQVJUX1RJ",
            "TUVfUFJPSElCSVRFRBAUEjAKLFRPT19NQU5ZX0JJTExJTkdfU0VUVVBTX0ZP",
            "Ul9QQVlNRU5UU19BQ0NPVU5UEBVC9gEKI2NvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MjAuZXJyb3JzQhZCaWxsaW5nU2V0dXBFcnJvclByb3RvUAFaRWdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MjAvZXJyb3JzO2Vycm9yc6ICA0dBQaoCH0dvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYyMC5FcnJvcnPKAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMjBc",
            "RXJyb3Jz6gIjR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjIwOjpFcnJvcnNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Errors.BillingSetupErrorEnum), global::Google.Ads.GoogleAds.V20.Errors.BillingSetupErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Errors.BillingSetupErrorEnum.Types.BillingSetupError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible billing setup errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BillingSetupErrorEnum : pb::IMessage<BillingSetupErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BillingSetupErrorEnum> _parser = new pb::MessageParser<BillingSetupErrorEnum>(() => new BillingSetupErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BillingSetupErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Errors.BillingSetupErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSetupErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSetupErrorEnum(BillingSetupErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BillingSetupErrorEnum Clone() {
      return new BillingSetupErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BillingSetupErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BillingSetupErrorEnum other) {
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
    public void MergeFrom(BillingSetupErrorEnum other) {
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
    /// <summary>Container for nested types declared in the BillingSetupErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible billing setup errors.
      /// </summary>
      public enum BillingSetupError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot specify both an existing payments account and a new payments
        /// account when setting up billing.
        /// </summary>
        [pbr::OriginalName("CANNOT_USE_EXISTING_AND_NEW_ACCOUNT")] CannotUseExistingAndNewAccount = 2,
        /// <summary>
        /// Cannot cancel an approved billing setup whose start time has passed.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_STARTED_BILLING_SETUP")] CannotRemoveStartedBillingSetup = 3,
        /// <summary>
        /// Cannot perform a Change of Bill-To (CBT) to the same payments account.
        /// </summary>
        [pbr::OriginalName("CANNOT_CHANGE_BILLING_TO_SAME_PAYMENTS_ACCOUNT")] CannotChangeBillingToSamePaymentsAccount = 4,
        /// <summary>
        /// Billing setups can only be used by customers with ENABLED or DRAFT
        /// status.
        /// </summary>
        [pbr::OriginalName("BILLING_SETUP_NOT_PERMITTED_FOR_CUSTOMER_STATUS")] BillingSetupNotPermittedForCustomerStatus = 5,
        /// <summary>
        /// Billing setups must either include a correctly formatted existing
        /// payments account id, or a non-empty new payments account name.
        /// </summary>
        [pbr::OriginalName("INVALID_PAYMENTS_ACCOUNT")] InvalidPaymentsAccount = 6,
        /// <summary>
        /// Only billable and third-party customers can create billing setups.
        /// </summary>
        [pbr::OriginalName("BILLING_SETUP_NOT_PERMITTED_FOR_CUSTOMER_CATEGORY")] BillingSetupNotPermittedForCustomerCategory = 7,
        /// <summary>
        /// Billing setup creations can only use NOW for start time type.
        /// </summary>
        [pbr::OriginalName("INVALID_START_TIME_TYPE")] InvalidStartTimeType = 8,
        /// <summary>
        /// Billing setups can only be created for a third-party customer if they do
        /// not already have a setup.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_ALREADY_HAS_BILLING")] ThirdPartyAlreadyHasBilling = 9,
        /// <summary>
        /// Billing setups cannot be created if there is already a pending billing in
        /// progress.
        /// </summary>
        [pbr::OriginalName("BILLING_SETUP_IN_PROGRESS")] BillingSetupInProgress = 10,
        /// <summary>
        /// Billing setups can only be created by customers who have permission to
        /// setup billings. Users can contact a representative for help setting up
        /// permissions.
        /// </summary>
        [pbr::OriginalName("NO_SIGNUP_PERMISSION")] NoSignupPermission = 11,
        /// <summary>
        /// Billing setups cannot be created if there is already a future-approved
        /// billing.
        /// </summary>
        [pbr::OriginalName("CHANGE_OF_BILL_TO_IN_PROGRESS")] ChangeOfBillToInProgress = 12,
        /// <summary>
        /// Requested payments profile not found.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_PROFILE_NOT_FOUND")] PaymentsProfileNotFound = 13,
        /// <summary>
        /// Requested payments account not found.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_ACCOUNT_NOT_FOUND")] PaymentsAccountNotFound = 14,
        /// <summary>
        /// Billing setup creation failed because the payments profile is ineligible.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_PROFILE_INELIGIBLE")] PaymentsProfileIneligible = 15,
        /// <summary>
        /// Billing setup creation failed because the payments account is ineligible.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_ACCOUNT_INELIGIBLE")] PaymentsAccountIneligible = 16,
        /// <summary>
        /// Billing setup creation failed because the payments profile needs internal
        /// approval.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NEEDS_INTERNAL_APPROVAL")] CustomerNeedsInternalApproval = 17,
        /// <summary>
        /// Billing setup creation failed because the user needs to accept master
        /// service agreement on the payments profile.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_PROFILE_NEEDS_SERVICE_AGREEMENT_ACCEPTANCE")] PaymentsProfileNeedsServiceAgreementAcceptance = 18,
        /// <summary>
        /// Payments account has different currency code than the current customer
        /// and hence cannot be used to setup billing.
        /// </summary>
        [pbr::OriginalName("PAYMENTS_ACCOUNT_INELIGIBLE_CURRENCY_CODE_MISMATCH")] PaymentsAccountIneligibleCurrencyCodeMismatch = 19,
        /// <summary>
        /// A start time in the future cannot be used because there is currently no
        /// active billing setup for this customer.
        /// </summary>
        [pbr::OriginalName("FUTURE_START_TIME_PROHIBITED")] FutureStartTimeProhibited = 20,
        /// <summary>
        /// The payments account has maximum number of billing setups.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_BILLING_SETUPS_FOR_PAYMENTS_ACCOUNT")] TooManyBillingSetupsForPaymentsAccount = 21,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
