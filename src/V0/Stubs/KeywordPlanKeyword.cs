// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/keyword_plan_keyword.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/keyword_plan_keyword.proto</summary>
  public static partial class KeywordPlanKeywordReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/keyword_plan_keyword.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanKeywordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMva2V5d29yZF9w",
            "bGFuX2tleXdvcmQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJl",
            "c291cmNlcxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjAvZW51bXMva2V5d29y",
            "ZF9tYXRjaF90eXBlLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMu",
            "cHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8izAIKEktleXdv",
            "cmRQbGFuS2V5d29yZBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJEjsKFWtleXdv",
            "cmRfcGxhbl9hZF9ncm91cBgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJp",
            "bmdWYWx1ZRInCgJpZBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZh",
            "bHVlEioKBHRleHQYBCABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWUSWAoKbWF0Y2hfdHlwZRgFIAEoDjJELmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYwLmVudW1zLktleXdvcmRNYXRjaFR5cGVFbnVtLktleXdvcmRNYXRjaFR5",
            "cGUSMwoOY3BjX2JpZF9taWNyb3MYBiABKAsyGy5nb29nbGUucHJvdG9idWYu",
            "SW50NjRWYWx1ZUKEAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJl",
            "c291cmNlc0IXS2V5d29yZFBsYW5LZXl3b3JkUHJvdG9QAVpKZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yw",
            "L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMC5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxS",
            "ZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMDo6UmVzb3Vy",
            "Y2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanKeyword), global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanKeyword.Parser, new[]{ "ResourceName", "KeywordPlanAdGroup", "Id", "Text", "MatchType", "CpcBidMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Plan ad group keyword.
  /// Max number of keyword plan keywords per plan: 2500.
  /// </summary>
  public sealed partial class KeywordPlanKeyword : pb::IMessage<KeywordPlanKeyword> {
    private static readonly pb::MessageParser<KeywordPlanKeyword> _parser = new pb::MessageParser<KeywordPlanKeyword>(() => new KeywordPlanKeyword());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanKeyword> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.KeywordPlanKeywordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanKeyword() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanKeyword(KeywordPlanKeyword other) : this() {
      resourceName_ = other.resourceName_;
      KeywordPlanAdGroup = other.KeywordPlanAdGroup;
      Id = other.Id;
      Text = other.Text;
      matchType_ = other.matchType_;
      CpcBidMicros = other.CpcBidMicros;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanKeyword Clone() {
      return new KeywordPlanKeyword(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the Keyword Plan ad group keyword.
    /// KeywordPlanKeyword resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlanKeywords/{kp_ad_group_keyword_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_plan_ad_group" field.</summary>
    public const int KeywordPlanAdGroupFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_keywordPlanAdGroup_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string keywordPlanAdGroup_;
    /// <summary>
    /// The Keyword Plan ad group to which this keyword belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeywordPlanAdGroup {
      get { return keywordPlanAdGroup_; }
      set {
        keywordPlanAdGroup_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// The ID of the Keyword Plan keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "text" field.</summary>
    public const int TextFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_text_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string text_;
    /// <summary>
    /// The keyword text.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Text {
      get { return text_; }
      set {
        text_ = value;
      }
    }

    /// <summary>Field number for the "match_type" field.</summary>
    public const int MatchTypeFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType matchType_ = 0;
    /// <summary>
    /// The keyword match type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    /// <summary>Field number for the "cpc_bid_micros" field.</summary>
    public const int CpcBidMicrosFieldNumber = 6;
    private static readonly pb::FieldCodec<long?> _single_cpcBidMicros_codec = pb::FieldCodec.ForStructWrapper<long>(50);
    private long? cpcBidMicros_;
    /// <summary>
    /// A keyword level max cpc bid in micros, in the account currency, that
    /// overrides the keyword plan ad group cpc bid.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CpcBidMicros {
      get { return cpcBidMicros_; }
      set {
        cpcBidMicros_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanKeyword);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanKeyword other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (KeywordPlanAdGroup != other.KeywordPlanAdGroup) return false;
      if (Id != other.Id) return false;
      if (Text != other.Text) return false;
      if (MatchType != other.MatchType) return false;
      if (CpcBidMicros != other.CpcBidMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (keywordPlanAdGroup_ != null) hash ^= KeywordPlanAdGroup.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (text_ != null) hash ^= Text.GetHashCode();
      if (MatchType != 0) hash ^= MatchType.GetHashCode();
      if (cpcBidMicros_ != null) hash ^= CpcBidMicros.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (keywordPlanAdGroup_ != null) {
        _single_keywordPlanAdGroup_codec.WriteTagAndValue(output, KeywordPlanAdGroup);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (text_ != null) {
        _single_text_codec.WriteTagAndValue(output, Text);
      }
      if (MatchType != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MatchType);
      }
      if (cpcBidMicros_ != null) {
        _single_cpcBidMicros_codec.WriteTagAndValue(output, CpcBidMicros);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (keywordPlanAdGroup_ != null) {
        size += _single_keywordPlanAdGroup_codec.CalculateSizeWithTag(KeywordPlanAdGroup);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (text_ != null) {
        size += _single_text_codec.CalculateSizeWithTag(Text);
      }
      if (MatchType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (cpcBidMicros_ != null) {
        size += _single_cpcBidMicros_codec.CalculateSizeWithTag(CpcBidMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanKeyword other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.keywordPlanAdGroup_ != null) {
        if (keywordPlanAdGroup_ == null || other.KeywordPlanAdGroup != "") {
          KeywordPlanAdGroup = other.KeywordPlanAdGroup;
        }
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.text_ != null) {
        if (text_ == null || other.Text != "") {
          Text = other.Text;
        }
      }
      if (other.MatchType != 0) {
        MatchType = other.MatchType;
      }
      if (other.cpcBidMicros_ != null) {
        if (cpcBidMicros_ == null || other.CpcBidMicros != 0L) {
          CpcBidMicros = other.CpcBidMicros;
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_keywordPlanAdGroup_codec.Read(input);
            if (keywordPlanAdGroup_ == null || value != "") {
              KeywordPlanAdGroup = value;
            }
            break;
          }
          case 26: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_text_codec.Read(input);
            if (text_ == null || value != "") {
              Text = value;
            }
            break;
          }
          case 40: {
            matchType_ = (global::Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType) input.ReadEnum();
            break;
          }
          case 50: {
            long? value = _single_cpcBidMicros_codec.Read(input);
            if (cpcBidMicros_ == null || value != 0L) {
              CpcBidMicros = value;
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
