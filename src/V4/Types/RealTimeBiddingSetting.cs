// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/common/real_time_bidding_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/common/real_time_bidding_setting.proto</summary>
  public static partial class RealTimeBiddingSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/common/real_time_bidding_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RealTimeBiddingSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9jb21tb24vcmVhbF90aW1lX2Jp",
            "ZGRpbmdfc2V0dGluZy5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQu",
            "Y29tbW9uGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iRAoWUmVhbFRpbWVCaWRkaW5nU2V0",
            "dGluZxIqCgZvcHRfaW4YASABKAsyGi5nb29nbGUucHJvdG9idWYuQm9vbFZh",
            "bHVlQvYBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuY29tbW9uQhtS",
            "ZWFsVGltZUJpZGRpbmdTZXR0aW5nUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2NvbW1v",
            "bjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5Db21t",
            "b27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxDb21tb27qAiJHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWNDo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Common.RealTimeBiddingSetting), global::Google.Ads.GoogleAds.V4.Common.RealTimeBiddingSetting.Parser, new[]{ "OptIn" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for Real-Time Bidding, a feature only available for campaigns
  /// targeting the Ad Exchange network.
  /// </summary>
  public sealed partial class RealTimeBiddingSetting : pb::IMessage<RealTimeBiddingSetting> {
    private static readonly pb::MessageParser<RealTimeBiddingSetting> _parser = new pb::MessageParser<RealTimeBiddingSetting>(() => new RealTimeBiddingSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RealTimeBiddingSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Common.RealTimeBiddingSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting(RealTimeBiddingSetting other) : this() {
      OptIn = other.OptIn;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RealTimeBiddingSetting Clone() {
      return new RealTimeBiddingSetting(this);
    }

    /// <summary>Field number for the "opt_in" field.</summary>
    public const int OptInFieldNumber = 1;
    private static readonly pb::FieldCodec<bool?> _single_optIn_codec = pb::FieldCodec.ForStructWrapper<bool>(10);
    private bool? optIn_;
    /// <summary>
    /// Whether the campaign is opted in to real-time bidding.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool? OptIn {
      get { return optIn_; }
      set {
        optIn_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RealTimeBiddingSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RealTimeBiddingSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptIn != other.OptIn) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (optIn_ != null) hash ^= OptIn.GetHashCode();
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
      if (optIn_ != null) {
        _single_optIn_codec.WriteTagAndValue(output, OptIn);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (optIn_ != null) {
        size += _single_optIn_codec.CalculateSizeWithTag(OptIn);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RealTimeBiddingSetting other) {
      if (other == null) {
        return;
      }
      if (other.optIn_ != null) {
        if (optIn_ == null || other.OptIn != false) {
          OptIn = other.OptIn;
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
          case 10: {
            bool? value = _single_optIn_codec.Read(input);
            if (optIn_ == null || value != false) {
              OptIn = value;
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
