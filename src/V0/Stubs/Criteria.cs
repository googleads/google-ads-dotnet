// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/common/criteria.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/common/criteria.proto</summary>
  public static partial class CriteriaReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/common/criteria.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CriteriaReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9jb21tb24vY3JpdGVyaWEucHJv",
            "dG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmNvbW1vbho2Z29vZ2xlL2Fk",
            "cy9nb29nbGVhZHMvdjAvZW51bXMva2V5d29yZF9tYXRjaF90eXBlLnByb3Rv",
            "Gh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8ikwEKC0tleXdvcmRJ",
            "bmZvEioKBHRleHQYASABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWUSWAoKbWF0Y2hfdHlwZRgCIAEoDjJELmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zLktleXdvcmRNYXRjaFR5cGVFbnVtLktleXdvcmRNYXRjaFR5",
            "cGVCwwEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5jb21tb25CDUNy",
            "aXRlcmlhUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2NvbW1vbjtjb21tb26iAgNHQUGq",
            "Ah5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5Db21tb27KAh5Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMFxDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Common.KeywordInfo), global::Google.Ads.GoogleAds.V0.Common.KeywordInfo.Parser, new[]{ "Text", "MatchType" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A keyword criterion.
  /// </summary>
  public sealed partial class KeywordInfo : pb::IMessage<KeywordInfo> {
    private static readonly pb::MessageParser<KeywordInfo> _parser = new pb::MessageParser<KeywordInfo>(() => new KeywordInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Common.CriteriaReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordInfo(KeywordInfo other) : this() {
      Text = other.Text;
      matchType_ = other.matchType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordInfo Clone() {
      return new KeywordInfo(this);
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_text_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string text_;
    /// <summary>
    /// The text of the keyword (at most 80 characters and 10 words).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = value;
      }
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType matchType_ = 0;
    /// <summary>
    /// The match type of the keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Text != other.Text) return false;
      if (MatchType != other.MatchType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (text_ != null) hash ^= Text.GetHashCode();
      if (MatchType != 0) hash ^= MatchType.GetHashCode();
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
      if (text_ != null) {
        _single_text_codec.WriteTagAndValue(output, Text);
      }
      if (MatchType != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MatchType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (text_ != null) {
        size += _single_text_codec.CalculateSizeWithTag(Text);
      }
      if (MatchType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordInfo other) {
      if (other == null) {
        return;
      }
      if (other.text_ != null) {
        if (text_ == null || other.Text != "") {
          Text = other.Text;
        }
      }
      if (other.MatchType != 0) {
        MatchType = other.MatchType;
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
            string value = _single_text_codec.Read(input);
            if (text_ == null || value != "") {
              Text = value;
            }
            break;
          }
          case 16: {
            matchType_ = (global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
