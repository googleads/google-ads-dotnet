// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/conversion_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/conversion_action_type.proto</summary>
  public static partial class ConversionActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/conversion_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvY29udmVyc2lvbl9h",
            "Y3Rpb25fdHlwZS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVu",
            "dW1zIukIChhDb252ZXJzaW9uQWN0aW9uVHlwZUVudW0izAgKFENvbnZlcnNp",
            "b25BY3Rpb25UeXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsK",
            "B0FEX0NBTEwQAhIRCg1DTElDS19UT19DQUxMEAMSGAoUR09PR0xFX1BMQVlf",
            "RE9XTkxPQUQQBBIfChtHT09HTEVfUExBWV9JTl9BUFBfUFVSQ0hBU0UQBRIQ",
            "CgxVUExPQURfQ0FMTFMQBhIRCg1VUExPQURfQ0xJQ0tTEAcSCwoHV0VCUEFH",
            "RRAIEhAKDFdFQlNJVEVfQ0FMTBAJEh0KGVNUT1JFX1NBTEVTX0RJUkVDVF9V",
            "UExPQUQQChIPCgtTVE9SRV9TQUxFUxALEh8KG0ZJUkVCQVNFX0FORFJPSURf",
            "RklSU1RfT1BFThAMEiQKIEZJUkVCQVNFX0FORFJPSURfSU5fQVBQX1BVUkNI",
            "QVNFEA0SGwoXRklSRUJBU0VfQU5EUk9JRF9DVVNUT00QDhIbChdGSVJFQkFT",
            "RV9JT1NfRklSU1RfT1BFThAPEiAKHEZJUkVCQVNFX0lPU19JTl9BUFBfUFVS",
            "Q0hBU0UQEBIXChNGSVJFQkFTRV9JT1NfQ1VTVE9NEBESMAosVEhJUkRfUEFS",
            "VFlfQVBQX0FOQUxZVElDU19BTkRST0lEX0ZJUlNUX09QRU4QEhI1CjFUSElS",
            "RF9QQVJUWV9BUFBfQU5BTFlUSUNTX0FORFJPSURfSU5fQVBQX1BVUkNIQVNF",
            "EBMSLAooVEhJUkRfUEFSVFlfQVBQX0FOQUxZVElDU19BTkRST0lEX0NVU1RP",
            "TRAUEiwKKFRISVJEX1BBUlRZX0FQUF9BTkFMWVRJQ1NfSU9TX0ZJUlNUX09Q",
            "RU4QFRIxCi1USElSRF9QQVJUWV9BUFBfQU5BTFlUSUNTX0lPU19JTl9BUFBf",
            "UFVSQ0hBU0UQFhIoCiRUSElSRF9QQVJUWV9BUFBfQU5BTFlUSUNTX0lPU19D",
            "VVNUT00QFxIgChxBTkRST0lEX0FQUF9QUkVfUkVHSVNUUkFUSU9OEBgSIwof",
            "QU5EUk9JRF9JTlNUQUxMU19BTExfT1RIRVJfQVBQUxAZEhUKEUZMT09ETElH",
            "SFRfQUNUSU9OEBoSGgoWRkxPT0RMSUdIVF9UUkFOU0FDVElPThAbEhEKDUdP",
            "T0dMRV9IT1NURUQQHBIUChBMRUFEX0ZPUk1fU1VCTUlUEB0SDgoKU0FMRVNG",
            "T1JDRRAeEhIKDlNFQVJDSF9BRFNfMzYwEB8SJAogU01BUlRfQ0FNUEFJR05f",
            "QURfQ0xJQ0tTX1RPX0NBTEwQIBIlCiFTTUFSVF9DQU1QQUlHTl9NQVBfQ0xJ",
            "Q0tTX1RPX0NBTEwQIRIhCh1TTUFSVF9DQU1QQUlHTl9NQVBfRElSRUNUSU9O",
            "UxAiEiAKHFNNQVJUX0NBTVBBSUdOX1RSQUNLRURfQ0FMTFMQIxIQCgxTVE9S",
            "RV9WSVNJVFMQJELzAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5l",
            "bnVtc0IZQ29udmVyc2lvbkFjdGlvblR5cGVQcm90b1ABWkNnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEw",
            "L2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEw",
            "LkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEwXEVudW1z6gIiR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.ConversionActionTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.ConversionActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.ConversionActionTypeEnum.Types.ConversionActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible types of a conversion action.
  /// </summary>
  public sealed partial class ConversionActionTypeEnum : pb::IMessage<ConversionActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionActionTypeEnum> _parser = new pb::MessageParser<ConversionActionTypeEnum>(() => new ConversionActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.ConversionActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum(ConversionActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionActionTypeEnum Clone() {
      return new ConversionActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionActionTypeEnum other) {
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
    public void MergeFrom(ConversionActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible types of a conversion action.
      /// </summary>
      public enum ConversionActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversions that occur when a user clicks on an ad's call extension.
        /// </summary>
        [pbr::OriginalName("AD_CALL")] AdCall = 2,
        /// <summary>
        /// Conversions that occur when a user on a mobile device clicks a phone
        /// number.
        /// </summary>
        [pbr::OriginalName("CLICK_TO_CALL")] ClickToCall = 3,
        /// <summary>
        /// Conversions that occur when a user downloads a mobile app from the Google
        /// Play Store.
        /// </summary>
        [pbr::OriginalName("GOOGLE_PLAY_DOWNLOAD")] GooglePlayDownload = 4,
        /// <summary>
        /// Conversions that occur when a user makes a purchase in an app through
        /// Android billing.
        /// </summary>
        [pbr::OriginalName("GOOGLE_PLAY_IN_APP_PURCHASE")] GooglePlayInAppPurchase = 5,
        /// <summary>
        /// Call conversions that are tracked by the advertiser and uploaded.
        /// </summary>
        [pbr::OriginalName("UPLOAD_CALLS")] UploadCalls = 6,
        /// <summary>
        /// Conversions that are tracked by the advertiser and uploaded with
        /// attributed clicks.
        /// </summary>
        [pbr::OriginalName("UPLOAD_CLICKS")] UploadClicks = 7,
        /// <summary>
        /// Conversions that occur on a webpage.
        /// </summary>
        [pbr::OriginalName("WEBPAGE")] Webpage = 8,
        /// <summary>
        /// Conversions that occur when a user calls a dynamically-generated phone
        /// number from an advertiser's website.
        /// </summary>
        [pbr::OriginalName("WEBSITE_CALL")] WebsiteCall = 9,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant
        /// data uploads.
        /// Only customers on the allowlist can use store sales direct upload types.
        /// </summary>
        [pbr::OriginalName("STORE_SALES_DIRECT_UPLOAD")] StoreSalesDirectUpload = 10,
        /// <summary>
        /// Store Sales conversion based on first-party or third-party merchant
        /// data uploads and/or from in-store purchases using cards from payment
        /// networks.
        /// Only customers on the allowlist can use store sales types.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("STORE_SALES")] StoreSales = 11,
        /// <summary>
        /// Android app first open conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_FIRST_OPEN")] FirebaseAndroidFirstOpen = 12,
        /// <summary>
        /// Android app in app purchase conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_IN_APP_PURCHASE")] FirebaseAndroidInAppPurchase = 13,
        /// <summary>
        /// Android app custom conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_ANDROID_CUSTOM")] FirebaseAndroidCustom = 14,
        /// <summary>
        /// iOS app first open conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_FIRST_OPEN")] FirebaseIosFirstOpen = 15,
        /// <summary>
        /// iOS app in app purchase conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_IN_APP_PURCHASE")] FirebaseIosInAppPurchase = 16,
        /// <summary>
        /// iOS app custom conversions tracked via Firebase.
        /// </summary>
        [pbr::OriginalName("FIREBASE_IOS_CUSTOM")] FirebaseIosCustom = 17,
        /// <summary>
        /// Android app first open conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_FIRST_OPEN")] ThirdPartyAppAnalyticsAndroidFirstOpen = 18,
        /// <summary>
        /// Android app in app purchase conversions tracked via Third Party App
        /// Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_IN_APP_PURCHASE")] ThirdPartyAppAnalyticsAndroidInAppPurchase = 19,
        /// <summary>
        /// Android app custom conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_ANDROID_CUSTOM")] ThirdPartyAppAnalyticsAndroidCustom = 20,
        /// <summary>
        /// iOS app first open conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_FIRST_OPEN")] ThirdPartyAppAnalyticsIosFirstOpen = 21,
        /// <summary>
        /// iOS app in app purchase conversions tracked via Third Party App
        /// Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_IN_APP_PURCHASE")] ThirdPartyAppAnalyticsIosInAppPurchase = 22,
        /// <summary>
        /// iOS app custom conversions tracked via Third Party App Analytics.
        /// </summary>
        [pbr::OriginalName("THIRD_PARTY_APP_ANALYTICS_IOS_CUSTOM")] ThirdPartyAppAnalyticsIosCustom = 23,
        /// <summary>
        /// Conversions that occur when a user pre-registers a mobile app from the
        /// Google Play Store. Read only.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_PRE_REGISTRATION")] AndroidAppPreRegistration = 24,
        /// <summary>
        /// Conversions that track all Google Play downloads which aren't tracked
        /// by an app-specific type. Read only.
        /// </summary>
        [pbr::OriginalName("ANDROID_INSTALLS_ALL_OTHER_APPS")] AndroidInstallsAllOtherApps = 25,
        /// <summary>
        /// Floodlight activity that counts the number of times that users have
        /// visited a particular webpage after seeing or clicking on one of
        /// an advertiser's ads. Read only.
        /// </summary>
        [pbr::OriginalName("FLOODLIGHT_ACTION")] FloodlightAction = 26,
        /// <summary>
        /// Floodlight activity that tracks the number of sales made or the number
        /// of items purchased. Can also capture the total value of each sale.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("FLOODLIGHT_TRANSACTION")] FloodlightTransaction = 27,
        /// <summary>
        /// Conversions that track local actions from Google's products and
        /// services after interacting with an ad. Read only.
        /// </summary>
        [pbr::OriginalName("GOOGLE_HOSTED")] GoogleHosted = 28,
        /// <summary>
        /// Conversions reported when a user submits a lead form. Read only.
        /// </summary>
        [pbr::OriginalName("LEAD_FORM_SUBMIT")] LeadFormSubmit = 29,
        /// <summary>
        /// Conversions that come from Salesforce. Read only.
        /// </summary>
        [pbr::OriginalName("SALESFORCE")] Salesforce = 30,
        /// <summary>
        /// Conversions imported from Search Ads 360 Floodlight data. Read only.
        /// </summary>
        [pbr::OriginalName("SEARCH_ADS_360")] SearchAds360 = 31,
        /// <summary>
        /// Call conversions that occur on Smart campaign Ads without call tracking
        /// setup, using Smart campaign custom criteria. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_AD_CLICKS_TO_CALL")] SmartCampaignAdClicksToCall = 32,
        /// <summary>
        /// The user clicks on a call element within Google Maps. Smart campaign
        /// only. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_MAP_CLICKS_TO_CALL")] SmartCampaignMapClicksToCall = 33,
        /// <summary>
        /// The user requests directions to a business location within Google Maps.
        /// Smart campaign only. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_MAP_DIRECTIONS")] SmartCampaignMapDirections = 34,
        /// <summary>
        /// Call conversions that occur on Smart campaign Ads with call tracking
        /// setup, using Smart campaign custom criteria. Read only.
        /// </summary>
        [pbr::OriginalName("SMART_CAMPAIGN_TRACKED_CALLS")] SmartCampaignTrackedCalls = 35,
        /// <summary>
        /// Conversions that occur when a user visits an advertiser's retail store.
        /// Read only.
        /// </summary>
        [pbr::OriginalName("STORE_VISITS")] StoreVisits = 36,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
