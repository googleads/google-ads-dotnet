// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/common/explorer_auto_optimizer_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/common/explorer_auto_optimizer_setting.proto</summary>
  public static partial class ExplorerAutoOptimizerSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/common/explorer_auto_optimizer_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExplorerAutoOptimizerSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vZXhwbG9yZXJfYXV0",
            "b19vcHRpbWl6ZXJfc2V0dGluZy5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjAuY29tbW9uGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8a",
            "HGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iSgocRXhwbG9yZXJBdXRv",
            "T3B0aW1pemVyU2V0dGluZxIqCgZvcHRfaW4YASABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuQm9vbFZhbHVlQvwBCiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djAuY29tbW9uQiFFeHBsb3JlckF1dG9PcHRpbWl6ZXJTZXR0aW5nUHJvdG9Q",
            "AVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YwL2NvbW1vbjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMC5Db21tb27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MFxDb21tb27qAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMDo6Q29tbW9u",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.ExplorerAutoOptimizerSetting), global::Google.Ads.GoogleAds.V0.Common.ExplorerAutoOptimizerSetting.Parser, new[]{ "OptIn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for the
  /// &lt;a href="https://support.google.com/google-ads/answer/190596">
  /// Display Campaign Optimizer&lt;/a>, initially termed "Explorer".
  /// </summary>
  public sealed partial class ExplorerAutoOptimizerSetting : pb::IMessage<ExplorerAutoOptimizerSetting> {
    private static readonly pb::MessageParser<ExplorerAutoOptimizerSetting> _parser = new pb::MessageParser<ExplorerAutoOptimizerSetting>(() => new ExplorerAutoOptimizerSetting());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExplorerAutoOptimizerSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.ExplorerAutoOptimizerSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExplorerAutoOptimizerSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExplorerAutoOptimizerSetting(ExplorerAutoOptimizerSetting other) : this() {
      OptIn = other.OptIn;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExplorerAutoOptimizerSetting Clone() {
      return new ExplorerAutoOptimizerSetting(this);
    }

    /// <summary>Field number for the "opt_in" field.</summary>
    public const int OptInFieldNumber = 1;
    private static readonly pb::FieldCodec<bool?> _single_optIn_codec = pb::FieldCodec.ForStructWrapper<bool>(10);
    private bool? optIn_;
    /// <summary>
    /// Indicates whether the optimizer is turned on.
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
      return Equals(other as ExplorerAutoOptimizerSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExplorerAutoOptimizerSetting other) {
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
    public void MergeFrom(ExplorerAutoOptimizerSetting other) {
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
