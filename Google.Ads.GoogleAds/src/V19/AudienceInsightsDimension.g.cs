// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/audience_insights_dimension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/audience_insights_dimension.proto</summary>
  public static partial class AudienceInsightsDimensionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/audience_insights_dimension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AudienceInsightsDimensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvYXVkaWVuY2VfaW5z",
            "aWdodHNfZGltZW5zaW9uLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTkuZW51bXMi7wIKHUF1ZGllbmNlSW5zaWdodHNEaW1lbnNpb25FbnVtIs0C",
            "ChlBdWRpZW5jZUluc2lnaHRzRGltZW5zaW9uEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEgwKCENBVEVHT1JZEAISEwoPS05PV0xFREdFX0dSQVBI",
            "EAMSFgoSR0VPX1RBUkdFVF9DT1VOVFJZEAQSGAoUU1VCX0NPVU5UUllfTE9D",
            "QVRJT04QBRITCg9ZT1VUVUJFX0NIQU5ORUwQBhIaChZZT1VUVUJFX0RZTkFN",
            "SUNfTElORVVQEAcSGgoWQUZGSU5JVFlfVVNFUl9JTlRFUkVTVBAIEhsKF0lO",
            "X01BUktFVF9VU0VSX0lOVEVSRVNUEAkSEwoPUEFSRU5UQUxfU1RBVFVTEAoS",
            "EAoMSU5DT01FX1JBTkdFEAsSDQoJQUdFX1JBTkdFEAwSCgoGR0VOREVSEA0S",
            "EQoNWU9VVFVCRV9WSURFTxAOQvgBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjE5LmVudW1zQh5BdWRpZW5jZUluc2lnaHRzRGltZW5zaW9uUHJvdG9Q",
            "AVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YxOS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMu",
            "R29vZ2xlQWRzLlYxOS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYx",
            "OVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6RW51bXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.AudienceInsightsDimensionEnum), global::Google.Ads.GoogleAds.V19.Enums.AudienceInsightsDimensionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing insights dimensions.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AudienceInsightsDimensionEnum : pb::IMessage<AudienceInsightsDimensionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AudienceInsightsDimensionEnum> _parser = new pb::MessageParser<AudienceInsightsDimensionEnum>(() => new AudienceInsightsDimensionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AudienceInsightsDimensionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.AudienceInsightsDimensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceInsightsDimensionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceInsightsDimensionEnum(AudienceInsightsDimensionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AudienceInsightsDimensionEnum Clone() {
      return new AudienceInsightsDimensionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AudienceInsightsDimensionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AudienceInsightsDimensionEnum other) {
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
    public void MergeFrom(AudienceInsightsDimensionEnum other) {
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
    /// <summary>Container for nested types declared in the AudienceInsightsDimensionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible dimensions for use in generating insights.
      /// </summary>
      public enum AudienceInsightsDimension {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A Product &amp; Service category.
        /// </summary>
        [pbr::OriginalName("CATEGORY")] Category = 2,
        /// <summary>
        /// A Knowledge Graph entity.
        /// </summary>
        [pbr::OriginalName("KNOWLEDGE_GRAPH")] KnowledgeGraph = 3,
        /// <summary>
        /// A country, represented by a geo target.
        /// </summary>
        [pbr::OriginalName("GEO_TARGET_COUNTRY")] GeoTargetCountry = 4,
        /// <summary>
        /// A geographic location within a country.
        /// </summary>
        [pbr::OriginalName("SUB_COUNTRY_LOCATION")] SubCountryLocation = 5,
        /// <summary>
        /// A YouTube channel.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_CHANNEL")] YoutubeChannel = 6,
        /// <summary>
        /// A YouTube Dynamic Lineup.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_DYNAMIC_LINEUP")] YoutubeDynamicLineup = 7,
        /// <summary>
        /// An Affinity UserInterest.
        /// </summary>
        [pbr::OriginalName("AFFINITY_USER_INTEREST")] AffinityUserInterest = 8,
        /// <summary>
        /// An In-Market UserInterest.
        /// </summary>
        [pbr::OriginalName("IN_MARKET_USER_INTEREST")] InMarketUserInterest = 9,
        /// <summary>
        /// A Parental Status value (parent, or not a parent).
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 10,
        /// <summary>
        /// A household income percentile range.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 11,
        /// <summary>
        /// An age range.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 12,
        /// <summary>
        /// A gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 13,
        /// <summary>
        /// A YouTube video.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 14,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
