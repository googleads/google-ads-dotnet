// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/criterion_category_channel_availability_mode.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/criterion_category_channel_availability_mode.proto</summary>
  public static partial class CriterionCategoryChannelAvailabilityModeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/criterion_category_channel_availability_mode.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriterionCategoryChannelAvailabilityModeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9jcml0ZXJpb25fY2F0",
            "ZWdvcnlfY2hhbm5lbF9hdmFpbGFiaWxpdHlfbW9kZS5wcm90bxIdZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjguZW51bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlv",
            "bnMucHJvdG8i1AEKLENyaXRlcmlvbkNhdGVnb3J5Q2hhbm5lbEF2YWlsYWJp",
            "bGl0eU1vZGVFbnVtIqMBCihDcml0ZXJpb25DYXRlZ29yeUNoYW5uZWxBdmFp",
            "bGFiaWxpdHlNb2RlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhAK",
            "DEFMTF9DSEFOTkVMUxACEiEKHUNIQU5ORUxfVFlQRV9BTkRfQUxMX1NVQlRZ",
            "UEVTEAMSJAogQ0hBTk5FTF9UWVBFX0FORF9TVUJTRVRfU1VCVFlQRVMQBEKC",
            "AgohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LmVudW1zQi1Dcml0ZXJp",
            "b25DYXRlZ29yeUNoYW5uZWxBdmFpbGFiaWxpdHlNb2RlUHJvdG9QAVpCZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3Y4L2VudW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVB",
            "ZHMuVjguRW51bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWOFxFbnVtc+oC",
            "IUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY4OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.CriterionCategoryChannelAvailabilityModeEnum), global::Google.Ads.GoogleAds.V8.Enums.CriterionCategoryChannelAvailabilityModeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.CriterionCategoryChannelAvailabilityModeEnum.Types.CriterionCategoryChannelAvailabilityMode) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes channel availability mode for a criterion availability - whether
  /// the availability is meant to include all advertising channels, or a
  /// particular channel with all its channel subtypes, or a channel with a certain
  /// subset of channel subtypes.
  /// </summary>
  public sealed partial class CriterionCategoryChannelAvailabilityModeEnum : pb::IMessage<CriterionCategoryChannelAvailabilityModeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CriterionCategoryChannelAvailabilityModeEnum> _parser = new pb::MessageParser<CriterionCategoryChannelAvailabilityModeEnum>(() => new CriterionCategoryChannelAvailabilityModeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CriterionCategoryChannelAvailabilityModeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.CriterionCategoryChannelAvailabilityModeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryChannelAvailabilityModeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryChannelAvailabilityModeEnum(CriterionCategoryChannelAvailabilityModeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionCategoryChannelAvailabilityModeEnum Clone() {
      return new CriterionCategoryChannelAvailabilityModeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CriterionCategoryChannelAvailabilityModeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CriterionCategoryChannelAvailabilityModeEnum other) {
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
    public void MergeFrom(CriterionCategoryChannelAvailabilityModeEnum other) {
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
    /// <summary>Container for nested types declared in the CriterionCategoryChannelAvailabilityModeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum containing the possible CriterionCategoryChannelAvailabilityMode.
      /// </summary>
      public enum CriterionCategoryChannelAvailabilityMode {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The category is available to campaigns of all channel types and subtypes.
        /// </summary>
        [pbr::OriginalName("ALL_CHANNELS")] AllChannels = 2,
        /// <summary>
        /// The category is available to campaigns of a specific channel type,
        /// including all subtypes under it.
        /// </summary>
        [pbr::OriginalName("CHANNEL_TYPE_AND_ALL_SUBTYPES")] ChannelTypeAndAllSubtypes = 3,
        /// <summary>
        /// The category is available to campaigns of a specific channel type and
        /// subtype(s).
        /// </summary>
        [pbr::OriginalName("CHANNEL_TYPE_AND_SUBSET_SUBTYPES")] ChannelTypeAndSubsetSubtypes = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
