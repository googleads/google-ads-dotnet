// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/common/targeting_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/common/targeting_setting.proto</summary>
  public static partial class TargetingSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/common/targeting_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetingSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvY29tbW9uL3RhcmdldGluZ19z",
            "ZXR0aW5nLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuY29tbW9u",
            "Gjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvdGFyZ2V0aW5nX2Rp",
            "bWVuc2lvbi5wcm90byLHAQoQVGFyZ2V0aW5nU2V0dGluZxJPChN0YXJnZXRf",
            "cmVzdHJpY3Rpb25zGAEgAygLMjIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIw",
            "LmNvbW1vbi5UYXJnZXRSZXN0cmljdGlvbhJiCh10YXJnZXRfcmVzdHJpY3Rp",
            "b25fb3BlcmF0aW9ucxgCIAMoCzI7Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "MC5jb21tb24uVGFyZ2V0UmVzdHJpY3Rpb25PcGVyYXRpb24inwEKEVRhcmdl",
            "dFJlc3RyaWN0aW9uEmYKE3RhcmdldGluZ19kaW1lbnNpb24YASABKA4ySS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXMuVGFyZ2V0aW5nRGltZW5z",
            "aW9uRW51bS5UYXJnZXRpbmdEaW1lbnNpb24SFQoIYmlkX29ubHkYAyABKAhI",
            "AIgBAUILCglfYmlkX29ubHki9gEKGlRhcmdldFJlc3RyaWN0aW9uT3BlcmF0",
            "aW9uElYKCG9wZXJhdG9yGAEgASgOMkQuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djIwLmNvbW1vbi5UYXJnZXRSZXN0cmljdGlvbk9wZXJhdGlvbi5PcGVyYXRv",
            "chJBCgV2YWx1ZRgCIAEoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5j",
            "b21tb24uVGFyZ2V0UmVzdHJpY3Rpb24iPQoIT3BlcmF0b3ISDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESBwoDQUREEAISCgoGUkVNT1ZFEANC9QEK",
            "I2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuY29tbW9uQhVUYXJnZXRp",
            "bmdTZXR0aW5nUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyMC9jb21tb247Y29tbW9uogID",
            "R0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIwLkNvbW1vbsoCH0dvb2ds",
            "ZVxBZHNcR29vZ2xlQWRzXFYyMFxDb21tb27qAiNHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMjA6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Common.TargetingSetting), global::Google.Ads.GoogleAds.V20.Common.TargetingSetting.Parser, new[]{ "TargetRestrictions", "TargetRestrictionOperations" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Common.TargetRestriction), global::Google.Ads.GoogleAds.V20.Common.TargetRestriction.Parser, new[]{ "TargetingDimension", "BidOnly" }, new[]{ "BidOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation), global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Parser, new[]{ "Operator", "Value" }, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for the targeting-related features, at the campaign and ad group
  /// levels. For more details about the targeting setting, visit
  /// https://support.google.com/google-ads/answer/7365594
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TargetingSetting : pb::IMessage<TargetingSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TargetingSetting> _parser = new pb::MessageParser<TargetingSetting>(() => new TargetingSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TargetingSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Common.TargetingSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingSetting(TargetingSetting other) : this() {
      targetRestrictions_ = other.targetRestrictions_.Clone();
      targetRestrictionOperations_ = other.targetRestrictionOperations_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetingSetting Clone() {
      return new TargetingSetting(this);
    }

    /// <summary>Field number for the "target_restrictions" field.</summary>
    public const int TargetRestrictionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V20.Common.TargetRestriction> _repeated_targetRestrictions_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V20.Common.TargetRestriction.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestriction> targetRestrictions_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestriction>();
    /// <summary>
    /// The per-targeting-dimension setting to restrict the reach of your campaign
    /// or ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestriction> TargetRestrictions {
      get { return targetRestrictions_; }
    }

    /// <summary>Field number for the "target_restriction_operations" field.</summary>
    public const int TargetRestrictionOperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation> _repeated_targetRestrictionOperations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation> targetRestrictionOperations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation>();
    /// <summary>
    /// The list of operations changing the target restrictions.
    ///
    /// Adding a target restriction with a targeting dimension that already exists
    /// causes the existing target restriction to be replaced with the new value.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation> TargetRestrictionOperations {
      get { return targetRestrictionOperations_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TargetingSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TargetingSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!targetRestrictions_.Equals(other.targetRestrictions_)) return false;
      if(!targetRestrictionOperations_.Equals(other.targetRestrictionOperations_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= targetRestrictions_.GetHashCode();
      hash ^= targetRestrictionOperations_.GetHashCode();
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
      targetRestrictions_.WriteTo(output, _repeated_targetRestrictions_codec);
      targetRestrictionOperations_.WriteTo(output, _repeated_targetRestrictionOperations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      targetRestrictions_.WriteTo(ref output, _repeated_targetRestrictions_codec);
      targetRestrictionOperations_.WriteTo(ref output, _repeated_targetRestrictionOperations_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += targetRestrictions_.CalculateSize(_repeated_targetRestrictions_codec);
      size += targetRestrictionOperations_.CalculateSize(_repeated_targetRestrictionOperations_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TargetingSetting other) {
      if (other == null) {
        return;
      }
      targetRestrictions_.Add(other.targetRestrictions_);
      targetRestrictionOperations_.Add(other.targetRestrictionOperations_);
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
          case 10: {
            targetRestrictions_.AddEntriesFrom(input, _repeated_targetRestrictions_codec);
            break;
          }
          case 18: {
            targetRestrictionOperations_.AddEntriesFrom(input, _repeated_targetRestrictionOperations_codec);
            break;
          }
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
          case 10: {
            targetRestrictions_.AddEntriesFrom(ref input, _repeated_targetRestrictions_codec);
            break;
          }
          case 18: {
            targetRestrictionOperations_.AddEntriesFrom(ref input, _repeated_targetRestrictionOperations_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The list of per-targeting-dimension targeting settings.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TargetRestriction : pb::IMessage<TargetRestriction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TargetRestriction> _parser = new pb::MessageParser<TargetRestriction>(() => new TargetRestriction());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TargetRestriction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Common.TargetingSettingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestriction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestriction(TargetRestriction other) : this() {
      _hasBits0 = other._hasBits0;
      targetingDimension_ = other.targetingDimension_;
      bidOnly_ = other.bidOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestriction Clone() {
      return new TargetRestriction(this);
    }

    /// <summary>Field number for the "targeting_dimension" field.</summary>
    public const int TargetingDimensionFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension targetingDimension_ = global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified;
    /// <summary>
    /// The targeting dimension that these settings apply to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension TargetingDimension {
      get { return targetingDimension_; }
      set {
        targetingDimension_ = value;
      }
    }

    /// <summary>Field number for the "bid_only" field.</summary>
    public const int BidOnlyFieldNumber = 3;
    private readonly static bool BidOnlyDefaultValue = false;

    private bool bidOnly_;
    /// <summary>
    /// Indicates whether to restrict your ads to show only for the criteria you
    /// have selected for this targeting_dimension, or to target all values for
    /// this targeting_dimension and show ads based on your targeting in other
    /// TargetingDimensions. A value of `true` means that these criteria will only
    /// apply bid modifiers, and not affect targeting. A value of `false` means
    /// that these criteria will restrict targeting as well as applying bid
    /// modifiers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BidOnly {
      get { if ((_hasBits0 & 1) != 0) { return bidOnly_; } else { return BidOnlyDefaultValue; } }
      set {
        _hasBits0 |= 1;
        bidOnly_ = value;
      }
    }
    /// <summary>Gets whether the "bid_only" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBidOnly {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "bid_only" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBidOnly() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TargetRestriction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TargetRestriction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TargetingDimension != other.TargetingDimension) return false;
      if (BidOnly != other.BidOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TargetingDimension != global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified) hash ^= TargetingDimension.GetHashCode();
      if (HasBidOnly) hash ^= BidOnly.GetHashCode();
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
      if (TargetingDimension != global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TargetingDimension);
      }
      if (HasBidOnly) {
        output.WriteRawTag(24);
        output.WriteBool(BidOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TargetingDimension != global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TargetingDimension);
      }
      if (HasBidOnly) {
        output.WriteRawTag(24);
        output.WriteBool(BidOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TargetingDimension != global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TargetingDimension);
      }
      if (HasBidOnly) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TargetRestriction other) {
      if (other == null) {
        return;
      }
      if (other.TargetingDimension != global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension.Unspecified) {
        TargetingDimension = other.TargetingDimension;
      }
      if (other.HasBidOnly) {
        BidOnly = other.BidOnly;
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
          case 8: {
            TargetingDimension = (global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension) input.ReadEnum();
            break;
          }
          case 24: {
            BidOnly = input.ReadBool();
            break;
          }
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
          case 8: {
            TargetingDimension = (global::Google.Ads.GoogleAds.V20.Enums.TargetingDimensionEnum.Types.TargetingDimension) input.ReadEnum();
            break;
          }
          case 24: {
            BidOnly = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Operation to be performed on a target restriction list in a mutate.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TargetRestrictionOperation : pb::IMessage<TargetRestrictionOperation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TargetRestrictionOperation> _parser = new pb::MessageParser<TargetRestrictionOperation>(() => new TargetRestrictionOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TargetRestrictionOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Common.TargetingSettingReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestrictionOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestrictionOperation(TargetRestrictionOperation other) : this() {
      operator_ = other.operator_;
      value_ = other.value_ != null ? other.value_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TargetRestrictionOperation Clone() {
      return new TargetRestrictionOperation(this);
    }

    /// <summary>Field number for the "operator" field.</summary>
    public const int OperatorFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator operator_ = global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified;
    /// <summary>
    /// Type of list operation to perform.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator Operator {
      get { return operator_; }
      set {
        operator_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V20.Common.TargetRestriction value_;
    /// <summary>
    /// The target restriction being added to or removed from the list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Common.TargetRestriction Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TargetRestrictionOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TargetRestrictionOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Operator != other.Operator) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Operator != global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified) hash ^= Operator.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
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
      if (Operator != global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Operator);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Operator != global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Operator);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Operator != global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Operator);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TargetRestrictionOperation other) {
      if (other == null) {
        return;
      }
      if (other.Operator != global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator.Unspecified) {
        Operator = other.Operator;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          Value = new global::Google.Ads.GoogleAds.V20.Common.TargetRestriction();
        }
        Value.MergeFrom(other.Value);
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
          case 8: {
            Operator = (global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator) input.ReadEnum();
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V20.Common.TargetRestriction();
            }
            input.ReadMessage(Value);
            break;
          }
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
          case 8: {
            Operator = (global::Google.Ads.GoogleAds.V20.Common.TargetRestrictionOperation.Types.Operator) input.ReadEnum();
            break;
          }
          case 18: {
            if (value_ == null) {
              Value = new global::Google.Ads.GoogleAds.V20.Common.TargetRestriction();
            }
            input.ReadMessage(Value);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the TargetRestrictionOperation message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The operator.
      /// </summary>
      public enum Operator {
        /// <summary>
        /// Unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Add the restriction to the existing restrictions.
        /// </summary>
        [pbr::OriginalName("ADD")] Add = 2,
        /// <summary>
        /// Remove the restriction from the existing restrictions.
        /// </summary>
        [pbr::OriginalName("REMOVE")] Remove = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
