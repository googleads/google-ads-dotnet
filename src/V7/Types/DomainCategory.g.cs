// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/domain_category.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/domain_category.proto</summary>
  public static partial class DomainCategoryReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/domain_category.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DomainCategoryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvZG9tYWluX2Nh",
            "dGVnb3J5LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5yZXNvdXJj",
            "ZXMaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8ingUKDkRvbWFpbkNhdGVnb3J5EkYKDXJlc291cmNlX25hbWUYASABKAlC",
            "L+BBA/pBKQonZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0RvbWFpbkNhdGVn",
            "b3J5EkAKCGNhbXBhaWduGAogASgJQingQQP6QSMKIWdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9DYW1wYWlnbkgAiAEBEhoKCGNhdGVnb3J5GAsgASgJQgPg",
            "QQNIAYgBARIfCg1sYW5ndWFnZV9jb2RlGAwgASgJQgPgQQNIAogBARIYCgZk",
            "b21haW4YDSABKAlCA+BBA0gDiAEBEiMKEWNvdmVyYWdlX2ZyYWN0aW9uGA4g",
            "ASgBQgPgQQNIBIgBARIfCg1jYXRlZ29yeV9yYW5rGA8gASgDQgPgQQNIBYgB",
            "ARIeCgxoYXNfY2hpbGRyZW4YECABKAhCA+BBA0gGiAEBEiwKGnJlY29tbWVu",
            "ZGVkX2NwY19iaWRfbWljcm9zGBEgASgDQgPgQQNIB4gBATqHAepBgwEKJ2dv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Eb21haW5DYXRlZ29yeRJYY3VzdG9t",
            "ZXJzL3tjdXN0b21lcl9pZH0vZG9tYWluQ2F0ZWdvcmllcy97Y2FtcGFpZ25f",
            "aWR9fntiYXNlNjRfY2F0ZWdvcnl9fntsYW5ndWFnZV9jb2RlfUILCglfY2Ft",
            "cGFpZ25CCwoJX2NhdGVnb3J5QhAKDl9sYW5ndWFnZV9jb2RlQgkKB19kb21h",
            "aW5CFAoSX2NvdmVyYWdlX2ZyYWN0aW9uQhAKDl9jYXRlZ29yeV9yYW5rQg8K",
            "DV9oYXNfY2hpbGRyZW5CHQobX3JlY29tbWVuZGVkX2NwY19iaWRfbWljcm9z",
            "QoACCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVzb3VyY2VzQhNE",
            "b21haW5DYXRlZ29yeVByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXM7cmVz",
            "b3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjcuUmVzb3Vy",
            "Y2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdcUmVzb3VyY2Vz6gIlR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.DomainCategory), global::Google.Ads.GoogleAds.V7.Resources.DomainCategory.Parser, new[]{ "ResourceName", "Campaign", "Category", "LanguageCode", "Domain", "CoverageFraction", "CategoryRank", "HasChildren", "RecommendedCpcBidMicros" }, new[]{ "Campaign", "Category", "LanguageCode", "Domain", "CoverageFraction", "CategoryRank", "HasChildren", "RecommendedCpcBidMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A category generated automatically by crawling a domain. If a campaign uses
  /// the DynamicSearchAdsSetting, then domain categories will be generated for
  /// the domain. The categories can be targeted using WebpageConditionInfo.
  /// See: https://support.google.com/google-ads/answer/2471185
  /// </summary>
  public sealed partial class DomainCategory : pb::IMessage<DomainCategory>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DomainCategory> _parser = new pb::MessageParser<DomainCategory>(() => new DomainCategory());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DomainCategory> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.DomainCategoryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainCategory() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainCategory(DomainCategory other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      campaign_ = other.campaign_;
      category_ = other.category_;
      languageCode_ = other.languageCode_;
      domain_ = other.domain_;
      coverageFraction_ = other.coverageFraction_;
      categoryRank_ = other.categoryRank_;
      hasChildren_ = other.hasChildren_;
      recommendedCpcBidMicros_ = other.recommendedCpcBidMicros_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DomainCategory Clone() {
      return new DomainCategory(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the domain category.
    /// Domain category resource names have the form:
    ///
    /// `customers/{customer_id}/domainCategories/{campaign_id}~{category_base64}~{language_code}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 10;
    private string campaign_;
    /// <summary>
    /// Output only. The campaign this category is recommended for.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Campaign {
      get { return campaign_ ?? ""; }
      set {
        campaign_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "campaign" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCampaign {
      get { return campaign_ != null; }
    }
    /// <summary>Clears the value of the "campaign" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCampaign() {
      campaign_ = null;
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 11;
    private string category_;
    /// <summary>
    /// Output only. Recommended category for the website domain. e.g. if you have a website
    /// about electronics, the categories could be "cameras", "televisions", etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Category {
      get { return category_ ?? ""; }
      set {
        category_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "category" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCategory {
      get { return category_ != null; }
    }
    /// <summary>Clears the value of the "category" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCategory() {
      category_ = null;
    }

    /// <summary>Field number for the "language_code" field.</summary>
    public const int LanguageCodeFieldNumber = 12;
    private string languageCode_;
    /// <summary>
    /// Output only. The language code specifying the language of the website. e.g. "en" for
    /// English. The language can be specified in the DynamicSearchAdsSetting
    /// required for dynamic search ads. This is the language of the pages from
    /// your website that you want Google Ads to find, create ads for,
    /// and match searches with.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LanguageCode {
      get { return languageCode_ ?? ""; }
      set {
        languageCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "language_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLanguageCode {
      get { return languageCode_ != null; }
    }
    /// <summary>Clears the value of the "language_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLanguageCode() {
      languageCode_ = null;
    }

    /// <summary>Field number for the "domain" field.</summary>
    public const int DomainFieldNumber = 13;
    private string domain_;
    /// <summary>
    /// Output only. The domain for the website. The domain can be specified in the
    /// DynamicSearchAdsSetting required for dynamic search ads.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Domain {
      get { return domain_ ?? ""; }
      set {
        domain_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "domain" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDomain {
      get { return domain_ != null; }
    }
    /// <summary>Clears the value of the "domain" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDomain() {
      domain_ = null;
    }

    /// <summary>Field number for the "coverage_fraction" field.</summary>
    public const int CoverageFractionFieldNumber = 14;
    private double coverageFraction_;
    /// <summary>
    /// Output only. Fraction of pages on your site that this category matches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public double CoverageFraction {
      get { if ((_hasBits0 & 1) != 0) { return coverageFraction_; } else { return 0D; } }
      set {
        _hasBits0 |= 1;
        coverageFraction_ = value;
      }
    }
    /// <summary>Gets whether the "coverage_fraction" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCoverageFraction {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "coverage_fraction" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCoverageFraction() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "category_rank" field.</summary>
    public const int CategoryRankFieldNumber = 15;
    private long categoryRank_;
    /// <summary>
    /// Output only. The position of this category in the set of categories. Lower numbers
    /// indicate a better match for the domain. null indicates not recommended.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CategoryRank {
      get { if ((_hasBits0 & 2) != 0) { return categoryRank_; } else { return 0L; } }
      set {
        _hasBits0 |= 2;
        categoryRank_ = value;
      }
    }
    /// <summary>Gets whether the "category_rank" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCategoryRank {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "category_rank" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCategoryRank() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "has_children" field.</summary>
    public const int HasChildrenFieldNumber = 16;
    private bool hasChildren_;
    /// <summary>
    /// Output only. Indicates whether this category has sub-categories.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasChildren {
      get { if ((_hasBits0 & 4) != 0) { return hasChildren_; } else { return false; } }
      set {
        _hasBits0 |= 4;
        hasChildren_ = value;
      }
    }
    /// <summary>Gets whether the "has_children" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHasChildren {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "has_children" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHasChildren() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "recommended_cpc_bid_micros" field.</summary>
    public const int RecommendedCpcBidMicrosFieldNumber = 17;
    private long recommendedCpcBidMicros_;
    /// <summary>
    /// Output only. The recommended cost per click for the category.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RecommendedCpcBidMicros {
      get { if ((_hasBits0 & 8) != 0) { return recommendedCpcBidMicros_; } else { return 0L; } }
      set {
        _hasBits0 |= 8;
        recommendedCpcBidMicros_ = value;
      }
    }
    /// <summary>Gets whether the "recommended_cpc_bid_micros" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRecommendedCpcBidMicros {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "recommended_cpc_bid_micros" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRecommendedCpcBidMicros() {
      _hasBits0 &= ~8;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DomainCategory);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DomainCategory other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Campaign != other.Campaign) return false;
      if (Category != other.Category) return false;
      if (LanguageCode != other.LanguageCode) return false;
      if (Domain != other.Domain) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CoverageFraction, other.CoverageFraction)) return false;
      if (CategoryRank != other.CategoryRank) return false;
      if (HasChildren != other.HasChildren) return false;
      if (RecommendedCpcBidMicros != other.RecommendedCpcBidMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasCampaign) hash ^= Campaign.GetHashCode();
      if (HasCategory) hash ^= Category.GetHashCode();
      if (HasLanguageCode) hash ^= LanguageCode.GetHashCode();
      if (HasDomain) hash ^= Domain.GetHashCode();
      if (HasCoverageFraction) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CoverageFraction);
      if (HasCategoryRank) hash ^= CategoryRank.GetHashCode();
      if (HasHasChildren) hash ^= HasChildren.GetHashCode();
      if (HasRecommendedCpcBidMicros) hash ^= RecommendedCpcBidMicros.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasCampaign) {
        output.WriteRawTag(82);
        output.WriteString(Campaign);
      }
      if (HasCategory) {
        output.WriteRawTag(90);
        output.WriteString(Category);
      }
      if (HasLanguageCode) {
        output.WriteRawTag(98);
        output.WriteString(LanguageCode);
      }
      if (HasDomain) {
        output.WriteRawTag(106);
        output.WriteString(Domain);
      }
      if (HasCoverageFraction) {
        output.WriteRawTag(113);
        output.WriteDouble(CoverageFraction);
      }
      if (HasCategoryRank) {
        output.WriteRawTag(120);
        output.WriteInt64(CategoryRank);
      }
      if (HasHasChildren) {
        output.WriteRawTag(128, 1);
        output.WriteBool(HasChildren);
      }
      if (HasRecommendedCpcBidMicros) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(RecommendedCpcBidMicros);
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasCampaign) {
        output.WriteRawTag(82);
        output.WriteString(Campaign);
      }
      if (HasCategory) {
        output.WriteRawTag(90);
        output.WriteString(Category);
      }
      if (HasLanguageCode) {
        output.WriteRawTag(98);
        output.WriteString(LanguageCode);
      }
      if (HasDomain) {
        output.WriteRawTag(106);
        output.WriteString(Domain);
      }
      if (HasCoverageFraction) {
        output.WriteRawTag(113);
        output.WriteDouble(CoverageFraction);
      }
      if (HasCategoryRank) {
        output.WriteRawTag(120);
        output.WriteInt64(CategoryRank);
      }
      if (HasHasChildren) {
        output.WriteRawTag(128, 1);
        output.WriteBool(HasChildren);
      }
      if (HasRecommendedCpcBidMicros) {
        output.WriteRawTag(136, 1);
        output.WriteInt64(RecommendedCpcBidMicros);
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
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasCampaign) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Campaign);
      }
      if (HasCategory) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Category);
      }
      if (HasLanguageCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LanguageCode);
      }
      if (HasDomain) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Domain);
      }
      if (HasCoverageFraction) {
        size += 1 + 8;
      }
      if (HasCategoryRank) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CategoryRank);
      }
      if (HasHasChildren) {
        size += 2 + 1;
      }
      if (HasRecommendedCpcBidMicros) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(RecommendedCpcBidMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DomainCategory other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasCampaign) {
        Campaign = other.Campaign;
      }
      if (other.HasCategory) {
        Category = other.Category;
      }
      if (other.HasLanguageCode) {
        LanguageCode = other.LanguageCode;
      }
      if (other.HasDomain) {
        Domain = other.Domain;
      }
      if (other.HasCoverageFraction) {
        CoverageFraction = other.CoverageFraction;
      }
      if (other.HasCategoryRank) {
        CategoryRank = other.CategoryRank;
      }
      if (other.HasHasChildren) {
        HasChildren = other.HasChildren;
      }
      if (other.HasRecommendedCpcBidMicros) {
        RecommendedCpcBidMicros = other.RecommendedCpcBidMicros;
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
            ResourceName = input.ReadString();
            break;
          }
          case 82: {
            Campaign = input.ReadString();
            break;
          }
          case 90: {
            Category = input.ReadString();
            break;
          }
          case 98: {
            LanguageCode = input.ReadString();
            break;
          }
          case 106: {
            Domain = input.ReadString();
            break;
          }
          case 113: {
            CoverageFraction = input.ReadDouble();
            break;
          }
          case 120: {
            CategoryRank = input.ReadInt64();
            break;
          }
          case 128: {
            HasChildren = input.ReadBool();
            break;
          }
          case 136: {
            RecommendedCpcBidMicros = input.ReadInt64();
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
            ResourceName = input.ReadString();
            break;
          }
          case 82: {
            Campaign = input.ReadString();
            break;
          }
          case 90: {
            Category = input.ReadString();
            break;
          }
          case 98: {
            LanguageCode = input.ReadString();
            break;
          }
          case 106: {
            Domain = input.ReadString();
            break;
          }
          case 113: {
            CoverageFraction = input.ReadDouble();
            break;
          }
          case 120: {
            CategoryRank = input.ReadInt64();
            break;
          }
          case 128: {
            HasChildren = input.ReadBool();
            break;
          }
          case 136: {
            RecommendedCpcBidMicros = input.ReadInt64();
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
