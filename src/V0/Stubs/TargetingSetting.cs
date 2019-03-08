// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/common/targeting_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/common/targeting_setting.proto</summary>
  public static partial class TargetingSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/common/targeting_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TargetingSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vdGFyZ2V0aW5nX3Nl",
            "dHRpbmcucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmNvbW1vbho3",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjAvZW51bXMvdGFyZ2V0aW5nX2RpbWVu",
            "c2lvbi5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvImIKEFRhcmdldGluZ1NldHRp",
            "bmcSTgoTdGFyZ2V0X3Jlc3RyaWN0aW9ucxgBIAMoCzIxLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYwLmNvbW1vbi5UYXJnZXRSZXN0cmljdGlvbiKoAQoRVGFy",
            "Z2V0UmVzdHJpY3Rpb24SZQoTdGFyZ2V0aW5nX2RpbWVuc2lvbhgBIAEoDjJI",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zLlRhcmdldGluZ0RpbWVu",
            "c2lvbkVudW0uVGFyZ2V0aW5nRGltZW5zaW9uEiwKCGJpZF9vbmx5GAIgASgL",
            "MhouZ29vZ2xlLnByb3RvYnVmLkJvb2xWYWx1ZULwAQoiY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYwLmNvbW1vbkIVVGFyZ2V0aW5nU2V0dGluZ1Byb3Rv",
            "UAFaRGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92MC9jb21tb247Y29tbW9uogIDR0FBqgIeR29vZ2xlLkFk",
            "cy5Hb29nbGVBZHMuVjAuQ29tbW9uygIeR29vZ2xlXEFkc1xHb29nbGVBZHNc",
            "VjBcQ29tbW9u6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjA6OkNvbW1v",
            "bmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.TargetingDimensionReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.TargetingSetting), global::Google.Ads.GoogleAds.V0.Common.TargetingSetting.Parser, new[]{ "TargetRestrictions" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.TargetRestriction), global::Google.Ads.GoogleAds.V0.Common.TargetRestriction.Parser, new[]{ "TargetingDimension", "BidOnly" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for the
  /// &lt;a href="https://support.google.com/google-ads/answer/7365594">
  /// targeting related features&lt;/a>, at Campaign and AdGroup level.
  /// </summary>
  public sealed partial class TargetingSetting : pb::IMessage<TargetingSetting> {
    private static readonly pb::MessageParser<TargetingSetting> _parser = new pb::MessageParser<TargetingSetting>(() => new TargetingSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TargetingSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.TargetingSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingSetting(TargetingSetting other) : this() {
      targetRestrictions_ = other.targetRestrictions_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetingSetting Clone() {
      return new TargetingSetting(this);
    }

    /// <summary>Field number for the "target_restrictions" field.</summary>
    public const int TargetRestrictionsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Common.TargetRestriction> _repeated_targetRestrictions_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V0.Common.TargetRestriction.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TargetRestriction> targetRestrictions_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TargetRestriction>();
    /// <summary>
    /// The per-targeting-dimension setting to restrict the reach of your campaign
    /// or ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Common.TargetRestriction> TargetRestrictions {
      get { return targetRestrictions_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TargetingSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TargetingSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!targetRestrictions_.Equals(other.targetRestrictions_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= targetRestrictions_.GetHashCode();
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
      targetRestrictions_.WriteTo(output, _repeated_targetRestrictions_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += targetRestrictions_.CalculateSize(_repeated_targetRestrictions_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TargetingSetting other) {
      if (other == null) {
        return;
      }
      targetRestrictions_.Add(other.targetRestrictions_);
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
          case 10: {
            targetRestrictions_.AddEntriesFrom(input, _repeated_targetRestrictions_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The list of per-targeting-dimension targeting settings.
  /// </summary>
  public sealed partial class TargetRestriction : pb::IMessage<TargetRestriction> {
    private static readonly pb::MessageParser<TargetRestriction> _parser = new pb::MessageParser<TargetRestriction>(() => new TargetRestriction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TargetRestriction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.TargetingSettingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetRestriction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetRestriction(TargetRestriction other) : this() {
      targetingDimension_ = other.targetingDimension_;
      BidOnly = other.BidOnly;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetRestriction Clone() {
      return new TargetRestriction(this);
    }

    /// <summary>Field number for the "targeting_dimension" field.</summary>
    public const int TargetingDimensionFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V0.Enums.TargetingDimensionEnum.Types.TargetingDimension targetingDimension_ = 0;
    /// <summary>
    /// The targeting dimension that these settings apply to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.TargetingDimensionEnum.Types.TargetingDimension TargetingDimension {
      get { return targetingDimension_; }
      set {
        targetingDimension_ = value;
      }
    }

    /// <summary>Field number for the "bid_only" field.</summary>
    public const int BidOnlyFieldNumber = 2;
    private static readonly pb::FieldCodec<bool?> _single_bidOnly_codec = pb::FieldCodec.ForStructWrapper<bool>(18);
    private bool? bidOnly_;
    /// <summary>
    /// Indicates whether to restrict your ads to show only for the criteria you
    /// have selected for this targeting_dimension, or to target all values for
    /// this targeting_dimension and show ads based on your targeting in other
    /// TargetingDimensions. A value of 'true' means that these criteria will only
    /// apply bid modifiers, and not affect targeting. A value of 'false' means
    /// that these criteria will restrict targeting as well as applying bid
    /// modifiers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? BidOnly {
      get { return bidOnly_; }
      set {
        bidOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TargetRestriction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public override int GetHashCode() {
      int hash = 1;
      if (TargetingDimension != 0) hash ^= TargetingDimension.GetHashCode();
      if (bidOnly_ != null) hash ^= BidOnly.GetHashCode();
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
      if (TargetingDimension != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) TargetingDimension);
      }
      if (bidOnly_ != null) {
        _single_bidOnly_codec.WriteTagAndValue(output, BidOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TargetingDimension != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TargetingDimension);
      }
      if (bidOnly_ != null) {
        size += _single_bidOnly_codec.CalculateSizeWithTag(BidOnly);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TargetRestriction other) {
      if (other == null) {
        return;
      }
      if (other.TargetingDimension != 0) {
        TargetingDimension = other.TargetingDimension;
      }
      if (other.bidOnly_ != null) {
        if (bidOnly_ == null || other.BidOnly != false) {
          BidOnly = other.BidOnly;
        }
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
          case 8: {
            targetingDimension_ = (global::Google.Ads.GoogleAds.V0.Enums.TargetingDimensionEnum.Types.TargetingDimension) input.ReadEnum();
            break;
          }
          case 18: {
            bool? value = _single_bidOnly_codec.Read(input);
            if (bidOnly_ == null || value != false) {
              BidOnly = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
