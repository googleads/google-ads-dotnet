// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/targeting_dimension.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/targeting_dimension.proto</summary>
  public static partial class TargetingDimensionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/targeting_dimension.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetingDimensionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvdGFyZ2V0aW5nX2Rp",
            "bWVuc2lvbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjExLmVudW1z",
            "IsQBChZUYXJnZXRpbmdEaW1lbnNpb25FbnVtIqkBChJUYXJnZXRpbmdEaW1l",
            "bnNpb24SDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESCwoHS0VZV09S",
            "RBACEgwKCEFVRElFTkNFEAMSCQoFVE9QSUMQBBIKCgZHRU5ERVIQBRINCglB",
            "R0VfUkFOR0UQBhINCglQTEFDRU1FTlQQBxITCg9QQVJFTlRBTF9TVEFUVVMQ",
            "CBIQCgxJTkNPTUVfUkFOR0UQCULxAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMS5lbnVtc0IXVGFyZ2V0aW5nRGltZW5zaW9uUHJvdG9QAVpDZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YxMS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYxMS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMVxFbnVt",
            "c+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMTo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.TargetingDimensionEnum), global::Google.Ads.GoogleAds.V11.Enums.TargetingDimensionEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.TargetingDimensionEnum.Types.TargetingDimension) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The dimensions that can be targeted.
  /// </summary>
  public sealed partial class TargetingDimensionEnum : pb::IMessage<TargetingDimensionEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TargetingDimensionEnum> _parser = new pb::MessageParser<TargetingDimensionEnum>(() => new TargetingDimensionEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TargetingDimensionEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.TargetingDimensionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingDimensionEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingDimensionEnum(TargetingDimensionEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingDimensionEnum Clone() {
      return new TargetingDimensionEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TargetingDimensionEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TargetingDimensionEnum other) {
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
    public void MergeFrom(TargetingDimensionEnum other) {
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
    /// <summary>Container for nested types declared in the TargetingDimensionEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible targeting dimensions.
      /// </summary>
      public enum TargetingDimension {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Keyword criteria, for example, 'mars cruise'. KEYWORD may be used as a
        /// custom bid dimension. Keywords are always a targeting dimension, so may
        /// not be set as a target "ALL" dimension with TargetRestriction.
        /// </summary>
        [pbr::OriginalName("KEYWORD")] Keyword = 2,
        /// <summary>
        /// Audience criteria, which include user list, user interest, custom
        /// affinity,  and custom in market.
        /// </summary>
        [pbr::OriginalName("AUDIENCE")] Audience = 3,
        /// <summary>
        /// Topic criteria for targeting categories of content, for example,
        /// 'category::Animals>Pets' Used for Display and Video targeting.
        /// </summary>
        [pbr::OriginalName("TOPIC")] Topic = 4,
        /// <summary>
        /// Criteria for targeting gender.
        /// </summary>
        [pbr::OriginalName("GENDER")] Gender = 5,
        /// <summary>
        /// Criteria for targeting age ranges.
        /// </summary>
        [pbr::OriginalName("AGE_RANGE")] AgeRange = 6,
        /// <summary>
        /// Placement criteria, which include websites like 'www.flowers4sale.com',
        /// as well as mobile applications, mobile app categories, YouTube videos,
        /// and YouTube channels.
        /// </summary>
        [pbr::OriginalName("PLACEMENT")] Placement = 7,
        /// <summary>
        /// Criteria for parental status targeting.
        /// </summary>
        [pbr::OriginalName("PARENTAL_STATUS")] ParentalStatus = 8,
        /// <summary>
        /// Criteria for income range targeting.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE")] IncomeRange = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
