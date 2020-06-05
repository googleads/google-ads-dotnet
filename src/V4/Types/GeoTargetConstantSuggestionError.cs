// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/geo_target_constant_suggestion_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/geo_target_constant_suggestion_error.proto</summary>
  public static partial class GeoTargetConstantSuggestionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/geo_target_constant_suggestion_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeoTargetConstantSuggestionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvZ2VvX3RhcmdldF9j",
            "b25zdGFudF9zdWdnZXN0aW9uX2Vycm9yLnByb3RvEh5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52NC5lcnJvcnMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8i2AEKJEdlb1RhcmdldENvbnN0YW50U3VnZ2VzdGlvbkVycm9yRW51bSKv",
            "AQogR2VvVGFyZ2V0Q29uc3RhbnRTdWdnZXN0aW9uRXJyb3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESHAoYTE9DQVRJT05fTkFNRV9TSVpFX0xJ",
            "TUlUEAISFwoTTE9DQVRJT05fTkFNRV9MSU1JVBADEhgKFElOVkFMSURfQ09V",
            "TlRSWV9DT0RFEAQSHAoYUkVRVUVTVF9QQVJBTUVURVJTX1VOU0VUEAVCgAIK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5lcnJvcnNCJUdlb1Rhcmdl",
            "dENvbnN0YW50U3VnZ2VzdGlvbkVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2Vy",
            "cm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5F",
            "cnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxFcnJvcnPqAiJHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.GeoTargetConstantSuggestionErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.GeoTargetConstantSuggestionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.GeoTargetConstantSuggestionErrorEnum.Types.GeoTargetConstantSuggestionError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible geo target constant suggestion errors.
  /// </summary>
  public sealed partial class GeoTargetConstantSuggestionErrorEnum : pb::IMessage<GeoTargetConstantSuggestionErrorEnum> {
    private static readonly pb::MessageParser<GeoTargetConstantSuggestionErrorEnum> _parser = new pb::MessageParser<GeoTargetConstantSuggestionErrorEnum>(() => new GeoTargetConstantSuggestionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GeoTargetConstantSuggestionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.GeoTargetConstantSuggestionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstantSuggestionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstantSuggestionErrorEnum(GeoTargetConstantSuggestionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GeoTargetConstantSuggestionErrorEnum Clone() {
      return new GeoTargetConstantSuggestionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GeoTargetConstantSuggestionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GeoTargetConstantSuggestionErrorEnum other) {
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
    public void MergeFrom(GeoTargetConstantSuggestionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the GeoTargetConstantSuggestionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible geo target constant suggestion errors.
      /// </summary>
      public enum GeoTargetConstantSuggestionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A location name cannot be greater than 300 characters.
        /// </summary>
        [pbr::OriginalName("LOCATION_NAME_SIZE_LIMIT")] LocationNameSizeLimit = 2,
        /// <summary>
        /// At most 25 location names can be specified in a SuggestGeoTargetConstants
        /// method.
        /// </summary>
        [pbr::OriginalName("LOCATION_NAME_LIMIT")] LocationNameLimit = 3,
        /// <summary>
        /// The country code is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 4,
        /// <summary>
        /// Geo target constant resource names or location names must be provided in
        /// the request.
        /// </summary>
        [pbr::OriginalName("REQUEST_PARAMETERS_UNSET")] RequestParametersUnset = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
