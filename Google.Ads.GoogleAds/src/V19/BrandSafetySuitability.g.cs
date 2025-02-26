// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/brand_safety_suitability.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/brand_safety_suitability.proto</summary>
  public static partial class BrandSafetySuitabilityReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/brand_safety_suitability.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrandSafetySuitabilityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvYnJhbmRfc2FmZXR5",
            "X3N1aXRhYmlsaXR5LnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTku",
            "ZW51bXMimwEKGkJyYW5kU2FmZXR5U3VpdGFiaWxpdHlFbnVtIn0KFkJyYW5k",
            "U2FmZXR5U3VpdGFiaWxpdHkSDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dO",
            "EAESFgoSRVhQQU5ERURfSU5WRU5UT1JZEAISFgoSU1RBTkRBUkRfSU5WRU5U",
            "T1JZEAMSFQoRTElNSVRFRF9JTlZFTlRPUlkQBEL1AQoiY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxOS5lbnVtc0IbQnJhbmRTYWZldHlTdWl0YWJpbGl0",
            "eVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92MTkvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTkuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMTlcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTk6",
            "OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.BrandSafetySuitabilityEnum), global::Google.Ads.GoogleAds.V19.Enums.BrandSafetySuitabilityEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.BrandSafetySuitabilityEnum.Types.BrandSafetySuitability) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum with 3-Tier brand safety suitability control.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BrandSafetySuitabilityEnum : pb::IMessage<BrandSafetySuitabilityEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BrandSafetySuitabilityEnum> _parser = new pb::MessageParser<BrandSafetySuitabilityEnum>(() => new BrandSafetySuitabilityEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BrandSafetySuitabilityEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.BrandSafetySuitabilityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSafetySuitabilityEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSafetySuitabilityEnum(BrandSafetySuitabilityEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSafetySuitabilityEnum Clone() {
      return new BrandSafetySuitabilityEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BrandSafetySuitabilityEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BrandSafetySuitabilityEnum other) {
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
    public void MergeFrom(BrandSafetySuitabilityEnum other) {
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
    /// <summary>Container for nested types declared in the BrandSafetySuitabilityEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// 3-Tier brand safety suitability control.
      /// </summary>
      public enum BrandSafetySuitability {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// This option lets you show ads across all inventory on YouTube and video
        /// partners that meet our standards for monetization. This option may be an
        /// appropriate choice for brands that want maximum access to the full
        /// breadth of videos eligible for ads, including, for example, videos that
        /// have strong profanity in the context of comedy or a documentary, or
        /// excessive violence as featured in video games.
        /// </summary>
        [pbr::OriginalName("EXPANDED_INVENTORY")] ExpandedInventory = 2,
        /// <summary>
        /// This option lets you show ads across a wide range of content that's
        /// appropriate for most brands, such as popular music videos, documentaries,
        /// and movie trailers. The content you can show ads on is based on YouTube's
        /// advertiser-friendly content guidelines that take into account, for
        /// example, the strength or frequency of profanity, or the appropriateness
        /// of subject matter like sensitive events. Ads won't show, for example, on
        /// content with repeated strong profanity, strong sexual content, or graphic
        /// violence.
        /// </summary>
        [pbr::OriginalName("STANDARD_INVENTORY")] StandardInventory = 3,
        /// <summary>
        /// This option lets you show ads on a reduced range of content that's
        /// appropriate for brands with particularly strict guidelines around
        /// inappropriate language and sexual suggestiveness; above and beyond what
        /// YouTube's advertiser-friendly content guidelines address. The videos
        /// accessible in this sensitive category meet heightened requirements,
        /// especially for inappropriate language and sexual suggestiveness. For
        /// example, your ads will be excluded from showing on some of YouTube's most
        /// popular music videos and other pop culture content across YouTube and
        /// Google video partners.
        /// </summary>
        [pbr::OriginalName("LIMITED_INVENTORY")] LimitedInventory = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
