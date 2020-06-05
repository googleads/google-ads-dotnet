// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/keyword_plan_negative_keyword.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/keyword_plan_negative_keyword.proto</summary>
  public static partial class KeywordPlanNegativeKeywordReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/keyword_plan_negative_keyword.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanNegativeKeywordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMva2V5d29yZF9w",
            "bGFuX25lZ2F0aXZlX2tleXdvcmQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY0LnJlc291cmNlcxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjQvZW51",
            "bXMva2V5d29yZF9tYXRjaF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5n",
            "b29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5u",
            "b3RhdGlvbnMucHJvdG8iogQKGktleXdvcmRQbGFuTmVnYXRpdmVLZXl3b3Jk",
            "ElIKDXJlc291cmNlX25hbWUYASABKAlCO+BBBfpBNQozZ29vZ2xlYWRzLmdv",
            "b2dsZWFwaXMuY29tL0tleXdvcmRQbGFuTmVnYXRpdmVLZXl3b3JkEm4KFWtl",
            "eXdvcmRfcGxhbl9jYW1wYWlnbhgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5T",
            "dHJpbmdWYWx1ZUIx+kEuCixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vS2V5",
            "d29yZFBsYW5DYW1wYWlnbhIsCgJpZBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1",
            "Zi5JbnQ2NFZhbHVlQgPgQQMSKgoEdGV4dBgEIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZRJYCgptYXRjaF90eXBlGAUgASgOMkQuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjQuZW51bXMuS2V5d29yZE1hdGNoVHlwZUVudW0u",
            "S2V5d29yZE1hdGNoVHlwZTqLAepBhwEKM2dvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9LZXl3b3JkUGxhbk5lZ2F0aXZlS2V5d29yZBJQY3VzdG9tZXJzL3tj",
            "dXN0b21lcn0va2V5d29yZFBsYW5OZWdhdGl2ZUtleXdvcmRzL3trZXl3b3Jk",
            "X3BsYW5fbmVnYXRpdmVfa2V5d29yZH1CjAIKJWNvbS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52NC5yZXNvdXJjZXNCH0tleXdvcmRQbGFuTmVnYXRpdmVLZXl3",
            "b3JkUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L3Jlc291cmNlcztyZXNvdXJjZXOiAgNH",
            "QUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5SZXNvdXJjZXPKAiFHb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWNFxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWNDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.KeywordPlanNegativeKeyword), global::Google.Ads.GoogleAds.V4.Resources.KeywordPlanNegativeKeyword.Parser, new[]{ "ResourceName", "KeywordPlanCampaign", "Id", "Text", "MatchType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Keyword Plan negative keyword.
  /// Max number of keyword plan negative keywords per plan: 1000.
  /// </summary>
  public sealed partial class KeywordPlanNegativeKeyword : pb::IMessage<KeywordPlanNegativeKeyword> {
    private static readonly pb::MessageParser<KeywordPlanNegativeKeyword> _parser = new pb::MessageParser<KeywordPlanNegativeKeyword>(() => new KeywordPlanNegativeKeyword());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanNegativeKeyword> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.KeywordPlanNegativeKeywordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNegativeKeyword() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNegativeKeyword(KeywordPlanNegativeKeyword other) : this() {
      resourceName_ = other.resourceName_;
      KeywordPlanCampaign = other.KeywordPlanCampaign;
      Id = other.Id;
      Text = other.Text;
      matchType_ = other.matchType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanNegativeKeyword Clone() {
      return new KeywordPlanNegativeKeyword(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the Keyword Plan negative keyword.
    /// KeywordPlanNegativeKeyword resource names have the form:
    ///
    /// `customers/{customer_id}/keywordPlanNegativeKeywords/{kp_negative_keyword_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "keyword_plan_campaign" field.</summary>
    public const int KeywordPlanCampaignFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_keywordPlanCampaign_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string keywordPlanCampaign_;
    /// <summary>
    /// The Keyword Plan campaign to which this negative keyword belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string KeywordPlanCampaign {
      get { return keywordPlanCampaign_; }
      set {
        keywordPlanCampaign_ = value;
      }
    }


    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the Keyword Plan negative keyword.
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
    private global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType matchType_ = global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified;
    /// <summary>
    /// The keyword match type.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType MatchType {
      get { return matchType_; }
      set {
        matchType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanNegativeKeyword);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanNegativeKeyword other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (KeywordPlanCampaign != other.KeywordPlanCampaign) return false;
      if (Id != other.Id) return false;
      if (Text != other.Text) return false;
      if (MatchType != other.MatchType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (keywordPlanCampaign_ != null) hash ^= KeywordPlanCampaign.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (text_ != null) hash ^= Text.GetHashCode();
      if (MatchType != global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) hash ^= MatchType.GetHashCode();
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
      if (keywordPlanCampaign_ != null) {
        _single_keywordPlanCampaign_codec.WriteTagAndValue(output, KeywordPlanCampaign);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (text_ != null) {
        _single_text_codec.WriteTagAndValue(output, Text);
      }
      if (MatchType != global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) MatchType);
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
      if (keywordPlanCampaign_ != null) {
        size += _single_keywordPlanCampaign_codec.CalculateSizeWithTag(KeywordPlanCampaign);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (text_ != null) {
        size += _single_text_codec.CalculateSizeWithTag(Text);
      }
      if (MatchType != global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MatchType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanNegativeKeyword other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.keywordPlanCampaign_ != null) {
        if (keywordPlanCampaign_ == null || other.KeywordPlanCampaign != "") {
          KeywordPlanCampaign = other.KeywordPlanCampaign;
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
      if (other.MatchType != global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType.Unspecified) {
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            string value = _single_keywordPlanCampaign_codec.Read(input);
            if (keywordPlanCampaign_ == null || value != "") {
              KeywordPlanCampaign = value;
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
            MatchType = (global::Google.Ads.GoogleAds.V4.Enums.KeywordMatchTypeEnum.Types.KeywordMatchType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
