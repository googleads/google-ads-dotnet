// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/conversion_action_category.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/conversion_action_category.proto</summary>
  public static partial class ConversionActionCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/conversion_action_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionActionCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9jb252ZXJzaW9uX2Fj",
            "dGlvbl9jYXRlZ29yeS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAu",
            "ZW51bXMipwEKHENvbnZlcnNpb25BY3Rpb25DYXRlZ29yeUVudW0ihgEKGENv",
            "bnZlcnNpb25BY3Rpb25DYXRlZ29yeRIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARILCgdERUZBVUxUEAISDQoJUEFHRV9WSUVXEAMSDAoIUFVSQ0hB",
            "U0UQBBIKCgZTSUdOVVAQBRIICgRMRUFEEAYSDAoIRE9XTkxPQUQQB0LOAQoh",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zQh1Db252ZXJzaW9u",
            "QWN0aW9uQ2F0ZWdvcnlQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjAvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5FbnVtc8oCHUdvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYwXEVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ConversionActionCategoryEnum), global::Google.Ads.GoogleAds.V0.Enums.ConversionActionCategoryEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the category of conversions that are associated
  /// with a ConversionAction.
  /// </summary>
  public sealed partial class ConversionActionCategoryEnum : pb::IMessage<ConversionActionCategoryEnum> {
    private static readonly pb::MessageParser<ConversionActionCategoryEnum> _parser = new pb::MessageParser<ConversionActionCategoryEnum>(() => new ConversionActionCategoryEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ConversionActionCategoryEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ConversionActionCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionActionCategoryEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionActionCategoryEnum(ConversionActionCategoryEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConversionActionCategoryEnum Clone() {
      return new ConversionActionCategoryEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ConversionActionCategoryEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ConversionActionCategoryEnum other) {
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
    public void MergeFrom(ConversionActionCategoryEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionActionCategoryEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The category of conversions that are associated with a ConversionAction.
      /// </summary>
      public enum ConversionActionCategory {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Default category.
        /// </summary>
        [pbr::OriginalName("DEFAULT")] Default = 2,
        /// <summary>
        /// User visiting a page.
        /// </summary>
        [pbr::OriginalName("PAGE_VIEW")] PageView = 3,
        /// <summary>
        /// Purchase, sales, or "order placed" event.
        /// </summary>
        [pbr::OriginalName("PURCHASE")] Purchase = 4,
        /// <summary>
        /// Signup user action.
        /// </summary>
        [pbr::OriginalName("SIGNUP")] Signup = 5,
        /// <summary>
        /// Lead-generating action.
        /// </summary>
        [pbr::OriginalName("LEAD")] Lead = 6,
        /// <summary>
        /// Software download action (as for an app).
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
