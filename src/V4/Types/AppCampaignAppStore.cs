// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/app_campaign_app_store.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/app_campaign_app_store.proto</summary>
  public static partial class AppCampaignAppStoreReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/app_campaign_app_store.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AppCampaignAppStoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9hcHBfY2FtcGFpZ25f",
            "YXBwX3N0b3JlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVt",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJ5ChdBcHBDYW1wYWln",
            "bkFwcFN0b3JlRW51bSJeChNBcHBDYW1wYWlnbkFwcFN0b3JlEg8KC1VOU1BF",
            "Q0lGSUVEEAASCwoHVU5LTk9XThABEhMKD0FQUExFX0FQUF9TVE9SRRACEhQK",
            "EEdPT0dMRV9BUFBfU1RPUkUQA0LtAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY0LmVudW1zQhhBcHBDYW1wYWlnbkFwcFN0b3JlUHJvdG9QAVpCZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3Y0L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjQuRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxFbnVtc+oC",
            "IUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.AppCampaignAppStoreEnum), global::Google.Ads.GoogleAds.V4.Enums.AppCampaignAppStoreEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.AppCampaignAppStoreEnum.Types.AppCampaignAppStore) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The application store that distributes mobile applications.
  /// </summary>
  public sealed partial class AppCampaignAppStoreEnum : pb::IMessage<AppCampaignAppStoreEnum> {
    private static readonly pb::MessageParser<AppCampaignAppStoreEnum> _parser = new pb::MessageParser<AppCampaignAppStoreEnum>(() => new AppCampaignAppStoreEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AppCampaignAppStoreEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.AppCampaignAppStoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignAppStoreEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignAppStoreEnum(AppCampaignAppStoreEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AppCampaignAppStoreEnum Clone() {
      return new AppCampaignAppStoreEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AppCampaignAppStoreEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AppCampaignAppStoreEnum other) {
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AppCampaignAppStoreEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AppCampaignAppStoreEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing app campaign app store.
      /// </summary>
      public enum AppCampaignAppStore {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Apple app store.
        /// </summary>
        [pbr::OriginalName("APPLE_APP_STORE")] AppleAppStore = 2,
        /// <summary>
        /// Google play.
        /// </summary>
        [pbr::OriginalName("GOOGLE_APP_STORE")] GoogleAppStore = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
