// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/google_ads_field_category.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/google_ads_field_category.proto</summary>
  public static partial class GoogleAdsFieldCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/google_ads_field_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GoogleAdsFieldCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvZ29vZ2xlX2Fkc19m",
            "aWVsZF9jYXRlZ29yeS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEw",
            "LmVudW1zIooBChpHb29nbGVBZHNGaWVsZENhdGVnb3J5RW51bSJsChZHb29n",
            "bGVBZHNGaWVsZENhdGVnb3J5Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9X",
            "ThABEgwKCFJFU09VUkNFEAISDQoJQVRUUklCVVRFEAMSCwoHU0VHTUVOVBAF",
            "EgoKBk1FVFJJQxAGQvUBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEw",
            "LmVudW1zQhtHb29nbGVBZHNGaWVsZENhdGVnb3J5UHJvdG9QAVpDZ29vZ2xl",
            "LmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRz",
            "L3YxMC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYxMC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMFxFbnVtc+oC",
            "Ikdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.GoogleAdsFieldCategoryEnum), global::Google.Ads.GoogleAds.V10.Enums.GoogleAdsFieldCategoryEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum that determines if the described artifact is a resource
  /// or a field, and if it is a field, when it segments search queries.
  /// </summary>
  public sealed partial class GoogleAdsFieldCategoryEnum : pb::IMessage<GoogleAdsFieldCategoryEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GoogleAdsFieldCategoryEnum> _parser = new pb::MessageParser<GoogleAdsFieldCategoryEnum>(() => new GoogleAdsFieldCategoryEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GoogleAdsFieldCategoryEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.GoogleAdsFieldCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GoogleAdsFieldCategoryEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GoogleAdsFieldCategoryEnum(GoogleAdsFieldCategoryEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GoogleAdsFieldCategoryEnum Clone() {
      return new GoogleAdsFieldCategoryEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GoogleAdsFieldCategoryEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GoogleAdsFieldCategoryEnum other) {
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
    public void MergeFrom(GoogleAdsFieldCategoryEnum other) {
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
    /// <summary>Container for nested types declared in the GoogleAdsFieldCategoryEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The category of the artifact.
      /// </summary>
      public enum GoogleAdsFieldCategory {
        /// <summary>
        /// Unspecified
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Unknown
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The described artifact is a resource.
        /// </summary>
        [pbr::OriginalName("RESOURCE")] Resource = 2,
        /// <summary>
        /// The described artifact is a field and is an attribute of a resource.
        /// Including a resource attribute field in a query may segment the query if
        /// the resource to which it is attributed segments the resource found in
        /// the FROM clause.
        /// </summary>
        [pbr::OriginalName("ATTRIBUTE")] Attribute = 3,
        /// <summary>
        /// The described artifact is a field and always segments search queries.
        /// </summary>
        [pbr::OriginalName("SEGMENT")] Segment = 5,
        /// <summary>
        /// The described artifact is a field and is a metric. It never segments
        /// search queries.
        /// </summary>
        [pbr::OriginalName("METRIC")] Metric = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
