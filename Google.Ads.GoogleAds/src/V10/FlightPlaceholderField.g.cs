// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/flight_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/flight_placeholder_field.proto</summary>
  public static partial class FlightPlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/flight_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FlightPlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvZmxpZ2h0X3BsYWNl",
            "aG9sZGVyX2ZpZWxkLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTAu",
            "ZW51bXMisgMKGkZsaWdodFBsYWNlaG9sZGVyRmllbGRFbnVtIpMDChZGbGln",
            "aHRQbGFjZWhvbGRlckZpZWxkEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEhIKDkRFU1RJTkFUSU9OX0lEEAISDQoJT1JJR0lOX0lEEAMSFgoSRkxJ",
            "R0hUX0RFU0NSSVBUSU9OEAQSDwoLT1JJR0lOX05BTUUQBRIUChBERVNUSU5B",
            "VElPTl9OQU1FEAYSEAoMRkxJR0hUX1BSSUNFEAcSEwoPRk9STUFUVEVEX1BS",
            "SUNFEAgSFQoRRkxJR0hUX1NBTEVfUFJJQ0UQCRIYChRGT1JNQVRURURfU0FM",
            "RV9QUklDRRAKEg0KCUlNQUdFX1VSTBALEg4KCkZJTkFMX1VSTFMQDBIVChFG",
            "SU5BTF9NT0JJTEVfVVJMUxANEhAKDFRSQUNLSU5HX1VSTBAOEhQKEEFORFJP",
            "SURfQVBQX0xJTksQDxIbChdTSU1JTEFSX0RFU1RJTkFUSU9OX0lEUxAQEhAK",
            "DElPU19BUFBfTElOSxAREhQKEElPU19BUFBfU1RPUkVfSUQQEkL2AQoiY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5lbnVtc0IcRmxpZ2h0c1BsYWNl",
            "aG9sZGVyRmllbGRQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2VudW1zogID",
            "R0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIeR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjEwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.FlightPlaceholderFieldEnum), global::Google.Ads.GoogleAds.V10.Enums.FlightPlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.FlightPlaceholderFieldEnum.Types.FlightPlaceholderField) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Flight placeholder fields.
  /// For more information about dynamic remarketing feeds, see
  /// https://support.google.com/google-ads/answer/6053288.
  /// </summary>
  public sealed partial class FlightPlaceholderFieldEnum : pb::IMessage<FlightPlaceholderFieldEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FlightPlaceholderFieldEnum> _parser = new pb::MessageParser<FlightPlaceholderFieldEnum>(() => new FlightPlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FlightPlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.FlightPlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightPlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightPlaceholderFieldEnum(FlightPlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FlightPlaceholderFieldEnum Clone() {
      return new FlightPlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FlightPlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FlightPlaceholderFieldEnum other) {
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
    public void MergeFrom(FlightPlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the FlightPlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible values for Flight placeholder fields.
      /// </summary>
      public enum FlightPlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. Required. Destination id. Example: PAR, LON.
        /// For feed items that only have destination id, destination id must be a
        /// unique key. For feed items that have both destination id and origin id,
        /// then the combination must be a unique key.
        /// </summary>
        [pbr::OriginalName("DESTINATION_ID")] DestinationId = 2,
        /// <summary>
        /// Data Type: STRING. Origin id. Example: PAR, LON.
        /// Optional. Combination of destination id and origin id must be unique per
        /// offer.
        /// </summary>
        [pbr::OriginalName("ORIGIN_ID")] OriginId = 3,
        /// <summary>
        /// Data Type: STRING. Required. Main headline with product name to be shown
        /// in dynamic ad.
        /// </summary>
        [pbr::OriginalName("FLIGHT_DESCRIPTION")] FlightDescription = 4,
        /// <summary>
        /// Data Type: STRING. Shorter names are recommended.
        /// </summary>
        [pbr::OriginalName("ORIGIN_NAME")] OriginName = 5,
        /// <summary>
        /// Data Type: STRING. Shorter names are recommended.
        /// </summary>
        [pbr::OriginalName("DESTINATION_NAME")] DestinationName = 6,
        /// <summary>
        /// Data Type: STRING. Price to be shown in the ad.
        /// Example: "100.00 USD"
        /// </summary>
        [pbr::OriginalName("FLIGHT_PRICE")] FlightPrice = 7,
        /// <summary>
        /// Data Type: STRING. Formatted price to be shown in the ad.
        /// Example: "Starting at $100.00 USD", "$80 - $100"
        /// </summary>
        [pbr::OriginalName("FORMATTED_PRICE")] FormattedPrice = 8,
        /// <summary>
        /// Data Type: STRING. Sale price to be shown in the ad.
        /// Example: "80.00 USD"
        /// </summary>
        [pbr::OriginalName("FLIGHT_SALE_PRICE")] FlightSalePrice = 9,
        /// <summary>
        /// Data Type: STRING. Formatted sale price to be shown in the ad.
        /// Example: "On sale for $80.00", "$60 - $80"
        /// </summary>
        [pbr::OriginalName("FORMATTED_SALE_PRICE")] FormattedSalePrice = 10,
        /// <summary>
        /// Data Type: URL. Image to be displayed in the ad.
        /// </summary>
        [pbr::OriginalName("IMAGE_URL")] ImageUrl = 11,
        /// <summary>
        /// Data Type: URL_LIST. Required. Final URLs for the ad when using Upgraded
        /// URLs. User will be redirected to these URLs when they click on an ad, or
        /// when they click on a specific flight for ads that show multiple
        /// flights.
        /// </summary>
        [pbr::OriginalName("FINAL_URLS")] FinalUrls = 12,
        /// <summary>
        /// Data Type: URL_LIST. Final mobile URLs for the ad when using Upgraded
        /// URLs.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URLS")] FinalMobileUrls = 13,
        /// <summary>
        /// Data Type: URL. Tracking template for the ad when using Upgraded URLs.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 14,
        /// <summary>
        /// Data Type: STRING. Android app link. Must be formatted as:
        /// android-app://{package_id}/{scheme}/{host_path}.
        /// The components are defined as follows:
        /// package_id: app ID as specified in Google Play.
        /// scheme: the scheme to pass to the application. Can be HTTP, or a custom
        ///   scheme.
        /// host_path: identifies the specific content within your application.
        /// </summary>
        [pbr::OriginalName("ANDROID_APP_LINK")] AndroidAppLink = 15,
        /// <summary>
        /// Data Type: STRING_LIST. List of recommended destination IDs to show
        /// together with this item.
        /// </summary>
        [pbr::OriginalName("SIMILAR_DESTINATION_IDS")] SimilarDestinationIds = 16,
        /// <summary>
        /// Data Type: STRING. iOS app link.
        /// </summary>
        [pbr::OriginalName("IOS_APP_LINK")] IosAppLink = 17,
        /// <summary>
        /// Data Type: INT64. iOS app store ID.
        /// </summary>
        [pbr::OriginalName("IOS_APP_STORE_ID")] IosAppStoreId = 18,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
