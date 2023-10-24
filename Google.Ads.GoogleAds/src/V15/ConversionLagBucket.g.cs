// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/enums/conversion_lag_bucket.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/enums/conversion_lag_bucket.proto</summary>
  public static partial class ConversionLagBucketReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/enums/conversion_lag_bucket.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionLagBucketReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvY29udmVyc2lvbl9s",
            "YWdfYnVja2V0LnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuZW51",
            "bXMiuwQKF0NvbnZlcnNpb25MYWdCdWNrZXRFbnVtIp8EChNDb252ZXJzaW9u",
            "TGFnQnVja2V0Eg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhUKEUxF",
            "U1NfVEhBTl9PTkVfREFZEAISEwoPT05FX1RPX1RXT19EQVlTEAMSFQoRVFdP",
            "X1RPX1RIUkVFX0RBWVMQBBIWChJUSFJFRV9UT19GT1VSX0RBWVMQBRIVChFG",
            "T1VSX1RPX0ZJVkVfREFZUxAGEhQKEEZJVkVfVE9fU0lYX0RBWVMQBxIVChFT",
            "SVhfVE9fU0VWRU5fREFZUxAIEhcKE1NFVkVOX1RPX0VJR0hUX0RBWVMQCRIW",
            "ChJFSUdIVF9UT19OSU5FX0RBWVMQChIUChBOSU5FX1RPX1RFTl9EQVlTEAsS",
            "FgoSVEVOX1RPX0VMRVZFTl9EQVlTEAwSGQoVRUxFVkVOX1RPX1RXRUxWRV9E",
            "QVlTEA0SGwoXVFdFTFZFX1RPX1RISVJURUVOX0RBWVMQDhIdChlUSElSVEVF",
            "Tl9UT19GT1VSVEVFTl9EQVlTEA8SHwobRk9VUlRFRU5fVE9fVFdFTlRZX09O",
            "RV9EQVlTEBASHQoZVFdFTlRZX09ORV9UT19USElSVFlfREFZUxAREh0KGVRI",
            "SVJUWV9UT19GT1JUWV9GSVZFX0RBWVMQEhIcChhGT1JUWV9GSVZFX1RPX1NJ",
            "WFRZX0RBWVMQExIYChRTSVhUWV9UT19OSU5FVFlfREFZUxAUQvIBCiJjb20u",
            "Z29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LmVudW1zQhhDb252ZXJzaW9uTGFn",
            "QnVja2V0UHJvdG9QAVpDZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNS9lbnVtcztlbnVtc6ICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxNS5FbnVtc8oCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYxNVxFbnVtc+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxNTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Enums.ConversionLagBucketEnum), global::Google.Ads.GoogleAds.V15.Enums.ConversionLagBucketEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Enums.ConversionLagBucketEnum.Types.ConversionLagBucket) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum representing the number of days between impression and
  /// conversion.
  /// </summary>
  public sealed partial class ConversionLagBucketEnum : pb::IMessage<ConversionLagBucketEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionLagBucketEnum> _parser = new pb::MessageParser<ConversionLagBucketEnum>(() => new ConversionLagBucketEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionLagBucketEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Enums.ConversionLagBucketReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionLagBucketEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionLagBucketEnum(ConversionLagBucketEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionLagBucketEnum Clone() {
      return new ConversionLagBucketEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionLagBucketEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionLagBucketEnum other) {
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
    public void MergeFrom(ConversionLagBucketEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionLagBucketEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum representing the number of days between impression and conversion.
      /// </summary>
      public enum ConversionLagBucket {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Conversion lag bucket from 0 to 1 day. 0 day is included, 1 day is not.
        /// </summary>
        [pbr::OriginalName("LESS_THAN_ONE_DAY")] LessThanOneDay = 2,
        /// <summary>
        /// Conversion lag bucket from 1 to 2 days. 1 day is included, 2 days is not.
        /// </summary>
        [pbr::OriginalName("ONE_TO_TWO_DAYS")] OneToTwoDays = 3,
        /// <summary>
        /// Conversion lag bucket from 2 to 3 days. 2 days is included,
        /// 3 days is not.
        /// </summary>
        [pbr::OriginalName("TWO_TO_THREE_DAYS")] TwoToThreeDays = 4,
        /// <summary>
        /// Conversion lag bucket from 3 to 4 days. 3 days is included,
        /// 4 days is not.
        /// </summary>
        [pbr::OriginalName("THREE_TO_FOUR_DAYS")] ThreeToFourDays = 5,
        /// <summary>
        /// Conversion lag bucket from 4 to 5 days. 4 days is included,
        /// 5 days is not.
        /// </summary>
        [pbr::OriginalName("FOUR_TO_FIVE_DAYS")] FourToFiveDays = 6,
        /// <summary>
        /// Conversion lag bucket from 5 to 6 days. 5 days is included,
        /// 6 days is not.
        /// </summary>
        [pbr::OriginalName("FIVE_TO_SIX_DAYS")] FiveToSixDays = 7,
        /// <summary>
        /// Conversion lag bucket from 6 to 7 days. 6 days is included,
        /// 7 days is not.
        /// </summary>
        [pbr::OriginalName("SIX_TO_SEVEN_DAYS")] SixToSevenDays = 8,
        /// <summary>
        /// Conversion lag bucket from 7 to 8 days. 7 days is included,
        /// 8 days is not.
        /// </summary>
        [pbr::OriginalName("SEVEN_TO_EIGHT_DAYS")] SevenToEightDays = 9,
        /// <summary>
        /// Conversion lag bucket from 8 to 9 days. 8 days is included,
        /// 9 days is not.
        /// </summary>
        [pbr::OriginalName("EIGHT_TO_NINE_DAYS")] EightToNineDays = 10,
        /// <summary>
        /// Conversion lag bucket from 9 to 10 days. 9 days is included,
        /// 10 days is not.
        /// </summary>
        [pbr::OriginalName("NINE_TO_TEN_DAYS")] NineToTenDays = 11,
        /// <summary>
        /// Conversion lag bucket from 10 to 11 days. 10 days is included,
        /// 11 days is not.
        /// </summary>
        [pbr::OriginalName("TEN_TO_ELEVEN_DAYS")] TenToElevenDays = 12,
        /// <summary>
        /// Conversion lag bucket from 11 to 12 days. 11 days is included,
        /// 12 days is not.
        /// </summary>
        [pbr::OriginalName("ELEVEN_TO_TWELVE_DAYS")] ElevenToTwelveDays = 13,
        /// <summary>
        /// Conversion lag bucket from 12 to 13 days. 12 days is included,
        /// 13 days is not.
        /// </summary>
        [pbr::OriginalName("TWELVE_TO_THIRTEEN_DAYS")] TwelveToThirteenDays = 14,
        /// <summary>
        /// Conversion lag bucket from 13 to 14 days. 13 days is included,
        /// 14 days is not.
        /// </summary>
        [pbr::OriginalName("THIRTEEN_TO_FOURTEEN_DAYS")] ThirteenToFourteenDays = 15,
        /// <summary>
        /// Conversion lag bucket from 14 to 21 days. 14 days is included,
        /// 21 days is not.
        /// </summary>
        [pbr::OriginalName("FOURTEEN_TO_TWENTY_ONE_DAYS")] FourteenToTwentyOneDays = 16,
        /// <summary>
        /// Conversion lag bucket from 21 to 30 days. 21 days is included,
        /// 30 days is not.
        /// </summary>
        [pbr::OriginalName("TWENTY_ONE_TO_THIRTY_DAYS")] TwentyOneToThirtyDays = 17,
        /// <summary>
        /// Conversion lag bucket from 30 to 45 days. 30 days is included,
        /// 45 days is not.
        /// </summary>
        [pbr::OriginalName("THIRTY_TO_FORTY_FIVE_DAYS")] ThirtyToFortyFiveDays = 18,
        /// <summary>
        /// Conversion lag bucket from 45 to 60 days. 45 days is included,
        /// 60 days is not.
        /// </summary>
        [pbr::OriginalName("FORTY_FIVE_TO_SIXTY_DAYS")] FortyFiveToSixtyDays = 19,
        /// <summary>
        /// Conversion lag bucket from 60 to 90 days. 60 days is included,
        /// 90 days is not.
        /// </summary>
        [pbr::OriginalName("SIXTY_TO_NINETY_DAYS")] SixtyToNinetyDays = 20,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
