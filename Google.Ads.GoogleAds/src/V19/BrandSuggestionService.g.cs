// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/services/brand_suggestion_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/services/brand_suggestion_service.proto</summary>
  public static partial class BrandSuggestionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/services/brand_suggestion_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrandSuggestionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvc2VydmljZXMvYnJhbmRfc3Vn",
            "Z2VzdGlvbl9zZXJ2aWNlLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTkuc2VydmljZXMaMGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxOS9lbnVtcy9i",
            "cmFuZF9zdGF0ZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRf",
            "YmVoYXZpb3IucHJvdG8ifwoUU3VnZ2VzdEJyYW5kc1JlcXVlc3QSGAoLY3Vz",
            "dG9tZXJfaWQYASABKAlCA+BBAhIeCgxicmFuZF9wcmVmaXgYAiABKAlCA+BB",
            "AkgAiAEBEhwKD3NlbGVjdGVkX2JyYW5kcxgDIAMoCUID4EEBQg8KDV9icmFu",
            "ZF9wcmVmaXgiWwoVU3VnZ2VzdEJyYW5kc1Jlc3BvbnNlEkIKBmJyYW5kcxgB",
            "IAMoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5zZXJ2aWNlcy5CcmFu",
            "ZFN1Z2dlc3Rpb24igwEKD0JyYW5kU3VnZ2VzdGlvbhIKCgJpZBgBIAEoCRIM",
            "CgRuYW1lGAIgASgJEgwKBHVybHMYAyADKAkSSAoFc3RhdGUYBCABKA4yOS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZW51bXMuQnJhbmRTdGF0ZUVudW0u",
            "QnJhbmRTdGF0ZTK4AgoWQnJhbmRTdWdnZXN0aW9uU2VydmljZRLWAQoNU3Vn",
            "Z2VzdEJyYW5kcxI3Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5zZXJ2aWNl",
            "cy5TdWdnZXN0QnJhbmRzUmVxdWVzdBo4Lmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxOS5zZXJ2aWNlcy5TdWdnZXN0QnJhbmRzUmVzcG9uc2UiUtpBGGN1c3Rv",
            "bWVyX2lkLGJyYW5kX3ByZWZpeILT5JMCMSIsL3YxOS9jdXN0b21lcnMve2N1",
            "c3RvbWVyX2lkPSp9OnN1Z2dlc3RCcmFuZHM6ASoaRcpBGGdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbdJBJ2h0dHBzOi8vd3d3Lmdvb2dsZWFwaXMuY29tL2F1",
            "dGgvYWR3b3Jkc0KHAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5z",
            "ZXJ2aWNlc0IbQnJhbmRTdWdnZXN0aW9uU2VydmljZVByb3RvUAFaSWdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFk",
            "cy92MTkvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMTkuU2VydmljZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xW",
            "MTlcU2VydmljZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTk6OlNl",
            "cnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V19.Enums.BrandStateReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Services.SuggestBrandsRequest), global::Google.Ads.GoogleAds.V19.Services.SuggestBrandsRequest.Parser, new[]{ "CustomerId", "BrandPrefix", "SelectedBrands" }, new[]{ "BrandPrefix" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Services.SuggestBrandsResponse), global::Google.Ads.GoogleAds.V19.Services.SuggestBrandsResponse.Parser, new[]{ "Brands" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion), global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion.Parser, new[]{ "Id", "Name", "Urls", "State" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [BrandSuggestionService.SuggestBrands][google.ads.googleads.v19.services.BrandSuggestionService.SuggestBrands].
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SuggestBrandsRequest : pb::IMessage<SuggestBrandsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestBrandsRequest> _parser = new pb::MessageParser<SuggestBrandsRequest>(() => new SuggestBrandsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestBrandsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Services.BrandSuggestionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsRequest(SuggestBrandsRequest other) : this() {
      customerId_ = other.customerId_;
      brandPrefix_ = other.brandPrefix_;
      selectedBrands_ = other.selectedBrands_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsRequest Clone() {
      return new SuggestBrandsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. The ID of the customer onto which to apply the brand suggestion
    /// operation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "brand_prefix" field.</summary>
    public const int BrandPrefixFieldNumber = 2;
    private readonly static string BrandPrefixDefaultValue = "";

    private string brandPrefix_;
    /// <summary>
    /// Required. The prefix of a brand name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BrandPrefix {
      get { return brandPrefix_ ?? BrandPrefixDefaultValue; }
      set {
        brandPrefix_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "brand_prefix" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBrandPrefix {
      get { return brandPrefix_ != null; }
    }
    /// <summary>Clears the value of the "brand_prefix" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBrandPrefix() {
      brandPrefix_ = null;
    }

    /// <summary>Field number for the "selected_brands" field.</summary>
    public const int SelectedBrandsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_selectedBrands_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> selectedBrands_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Optional. Ids of the brands already selected by advertisers. They will be
    /// excluded in response. These are expected to be brand ids not brand names.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> SelectedBrands {
      get { return selectedBrands_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestBrandsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestBrandsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (BrandPrefix != other.BrandPrefix) return false;
      if(!selectedBrands_.Equals(other.selectedBrands_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      if (HasBrandPrefix) hash ^= BrandPrefix.GetHashCode();
      hash ^= selectedBrands_.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (HasBrandPrefix) {
        output.WriteRawTag(18);
        output.WriteString(BrandPrefix);
      }
      selectedBrands_.WriteTo(output, _repeated_selectedBrands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      if (HasBrandPrefix) {
        output.WriteRawTag(18);
        output.WriteString(BrandPrefix);
      }
      selectedBrands_.WriteTo(ref output, _repeated_selectedBrands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      if (HasBrandPrefix) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BrandPrefix);
      }
      size += selectedBrands_.CalculateSize(_repeated_selectedBrands_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestBrandsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      if (other.HasBrandPrefix) {
        BrandPrefix = other.BrandPrefix;
      }
      selectedBrands_.Add(other.selectedBrands_);
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            BrandPrefix = input.ReadString();
            break;
          }
          case 26: {
            selectedBrands_.AddEntriesFrom(input, _repeated_selectedBrands_codec);
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            BrandPrefix = input.ReadString();
            break;
          }
          case 26: {
            selectedBrands_.AddEntriesFrom(ref input, _repeated_selectedBrands_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response message for
  /// [BrandSuggestionService.SuggestBrands][google.ads.googleads.v19.services.BrandSuggestionService.SuggestBrands].
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SuggestBrandsResponse : pb::IMessage<SuggestBrandsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SuggestBrandsResponse> _parser = new pb::MessageParser<SuggestBrandsResponse>(() => new SuggestBrandsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SuggestBrandsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Services.BrandSuggestionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsResponse(SuggestBrandsResponse other) : this() {
      brands_ = other.brands_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SuggestBrandsResponse Clone() {
      return new SuggestBrandsResponse(this);
    }

    /// <summary>Field number for the "brands" field.</summary>
    public const int BrandsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion> _repeated_brands_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion> brands_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion>();
    /// <summary>
    /// Generated brand suggestions of verified brands for the given prefix.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V19.Services.BrandSuggestion> Brands {
      get { return brands_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SuggestBrandsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SuggestBrandsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!brands_.Equals(other.brands_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= brands_.GetHashCode();
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
      brands_.WriteTo(output, _repeated_brands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      brands_.WriteTo(ref output, _repeated_brands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += brands_.CalculateSize(_repeated_brands_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SuggestBrandsResponse other) {
      if (other == null) {
        return;
      }
      brands_.Add(other.brands_);
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
            brands_.AddEntriesFrom(input, _repeated_brands_codec);
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
            brands_.AddEntriesFrom(ref input, _repeated_brands_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Information of brand suggestion.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BrandSuggestion : pb::IMessage<BrandSuggestion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BrandSuggestion> _parser = new pb::MessageParser<BrandSuggestion>(() => new BrandSuggestion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BrandSuggestion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Services.BrandSuggestionServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSuggestion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSuggestion(BrandSuggestion other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      urls_ = other.urls_.Clone();
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BrandSuggestion Clone() {
      return new BrandSuggestion(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    /// Id for the brand. It would be CKG MID for verified/global scoped brands.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    /// <summary>
    /// Name of the brand.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "urls" field.</summary>
    public const int UrlsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_urls_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> urls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Urls which uniquely identify the brand.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Urls {
      get { return urls_; }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState state_ = global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified;
    /// <summary>
    /// Current state of the brand.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BrandSuggestion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BrandSuggestion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if(!urls_.Equals(other.urls_)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= urls_.GetHashCode();
      if (State != global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified) hash ^= State.GetHashCode();
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      urls_.WriteTo(output, _repeated_urls_codec);
      if (State != global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
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
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      urls_.WriteTo(ref output, _repeated_urls_codec);
      if (State != global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) State);
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
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += urls_.CalculateSize(_repeated_urls_codec);
      if (State != global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BrandSuggestion other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      urls_.Add(other.urls_);
      if (other.State != global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState.Unspecified) {
        State = other.State;
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
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            urls_.AddEntriesFrom(input, _repeated_urls_codec);
            break;
          }
          case 32: {
            State = (global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState) input.ReadEnum();
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
            Id = input.ReadString();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 26: {
            urls_.AddEntriesFrom(ref input, _repeated_urls_codec);
            break;
          }
          case 32: {
            State = (global::Google.Ads.GoogleAds.V19.Enums.BrandStateEnum.Types.BrandState) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
