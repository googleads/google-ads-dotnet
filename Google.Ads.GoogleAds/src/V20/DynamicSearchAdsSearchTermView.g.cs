// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/dynamic_search_ads_search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/dynamic_search_ads_search_term_view.proto</summary>
  public static partial class DynamicSearchAdsSearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/dynamic_search_ads_search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DynamicSearchAdsSearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL2R5bmFtaWNf",
            "c2VhcmNoX2Fkc19zZWFyY2hfdGVybV92aWV3LnByb3RvEiJnb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MjAucmVzb3VyY2VzGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvItAFCh5E",
            "eW5hbWljU2VhcmNoQWRzU2VhcmNoVGVybVZpZXcSVgoNcmVzb3VyY2VfbmFt",
            "ZRgBIAEoCUI/4EED+kE5Cjdnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRHlu",
            "YW1pY1NlYXJjaEFkc1NlYXJjaFRlcm1WaWV3Eh0KC3NlYXJjaF90ZXJtGAkg",
            "ASgJQgPgQQNIAIgBARIaCghoZWFkbGluZRgKIAEoCUID4EEDSAGIAQESHgoM",
            "bGFuZGluZ19wYWdlGAsgASgJQgPgQQNIAogBARIaCghwYWdlX3VybBgMIAEo",
            "CUID4EEDSAOIAQESJgoUaGFzX25lZ2F0aXZlX2tleXdvcmQYDSABKAhCA+BB",
            "A0gEiAEBEiYKFGhhc19tYXRjaGluZ19rZXl3b3JkGA4gASgIQgPgQQNIBYgB",
            "ARIiChBoYXNfbmVnYXRpdmVfdXJsGA8gASgIQgPgQQNIBogBATroAepB5AEK",
            "N2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9EeW5hbWljU2VhcmNoQWRzU2Vh",
            "cmNoVGVybVZpZXcSqAFjdXN0b21lcnMve2N1c3RvbWVyX2lkfS9keW5hbWlj",
            "U2VhcmNoQWRzU2VhcmNoVGVybVZpZXdzL3thZF9ncm91cF9pZH1+e3NlYXJj",
            "aF90ZXJtX2ZpbmdlcnByaW50fX57aGVhZGxpbmVfZmluZ2VycHJpbnR9fnts",
            "YW5kaW5nX3BhZ2VfZmluZ2VycHJpbnR9fntwYWdlX3VybF9maW5nZXJwcmlu",
            "dH1CDgoMX3NlYXJjaF90ZXJtQgsKCV9oZWFkbGluZUIPCg1fbGFuZGluZ19w",
            "YWdlQgsKCV9wYWdlX3VybEIXChVfaGFzX25lZ2F0aXZlX2tleXdvcmRCFwoV",
            "X2hhc19tYXRjaGluZ19rZXl3b3JkQhMKEV9oYXNfbmVnYXRpdmVfdXJsQpUC",
            "CiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLnJlc291cmNlc0IjRHlu",
            "YW1pY1NlYXJjaEFkc1NlYXJjaFRlcm1WaWV3UHJvdG9QAVpLZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yy",
            "MC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjIwLlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYy",
            "MFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjA6OlJl",
            "c291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.DynamicSearchAdsSearchTermView), global::Google.Ads.GoogleAds.V20.Resources.DynamicSearchAdsSearchTermView.Parser, new[]{ "ResourceName", "SearchTerm", "Headline", "LandingPage", "PageUrl", "HasNegativeKeyword", "HasMatchingKeyword", "HasNegativeUrl" }, new[]{ "SearchTerm", "Headline", "LandingPage", "PageUrl", "HasNegativeKeyword", "HasMatchingKeyword", "HasNegativeUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A dynamic search ads search term view.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DynamicSearchAdsSearchTermView : pb::IMessage<DynamicSearchAdsSearchTermView>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DynamicSearchAdsSearchTermView> _parser = new pb::MessageParser<DynamicSearchAdsSearchTermView>(() => new DynamicSearchAdsSearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DynamicSearchAdsSearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.DynamicSearchAdsSearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DynamicSearchAdsSearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DynamicSearchAdsSearchTermView(DynamicSearchAdsSearchTermView other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      searchTerm_ = other.searchTerm_;
      headline_ = other.headline_;
      landingPage_ = other.landingPage_;
      pageUrl_ = other.pageUrl_;
      hasNegativeKeyword_ = other.hasNegativeKeyword_;
      hasMatchingKeyword_ = other.hasMatchingKeyword_;
      hasNegativeUrl_ = other.hasNegativeUrl_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DynamicSearchAdsSearchTermView Clone() {
      return new DynamicSearchAdsSearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the dynamic search ads search term view.
    /// Dynamic search ads search term view resource names have the form:
    ///
    /// `customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 9;
    private readonly static string SearchTermDefaultValue = "";

    private string searchTerm_;
    /// <summary>
    /// Output only. Search term
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SearchTerm {
      get { return searchTerm_ ?? SearchTermDefaultValue; }
      set {
        searchTerm_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "search_term" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasSearchTerm {
      get { return searchTerm_ != null; }
    }
    /// <summary>Clears the value of the "search_term" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearSearchTerm() {
      searchTerm_ = null;
    }

    /// <summary>Field number for the "headline" field.</summary>
    public const int HeadlineFieldNumber = 10;
    private readonly static string HeadlineDefaultValue = "";

    private string headline_;
    /// <summary>
    /// Output only. The dynamically generated headline of the Dynamic Search Ad.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Headline {
      get { return headline_ ?? HeadlineDefaultValue; }
      set {
        headline_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "headline" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHeadline {
      get { return headline_ != null; }
    }
    /// <summary>Clears the value of the "headline" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHeadline() {
      headline_ = null;
    }

    /// <summary>Field number for the "landing_page" field.</summary>
    public const int LandingPageFieldNumber = 11;
    private readonly static string LandingPageDefaultValue = "";

    private string landingPage_;
    /// <summary>
    /// Output only. The dynamically selected landing page URL of the impression.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string LandingPage {
      get { return landingPage_ ?? LandingPageDefaultValue; }
      set {
        landingPage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "landing_page" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasLandingPage {
      get { return landingPage_ != null; }
    }
    /// <summary>Clears the value of the "landing_page" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearLandingPage() {
      landingPage_ = null;
    }

    /// <summary>Field number for the "page_url" field.</summary>
    public const int PageUrlFieldNumber = 12;
    private readonly static string PageUrlDefaultValue = "";

    private string pageUrl_;
    /// <summary>
    /// Output only. The URL of page feed item served for the impression.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PageUrl {
      get { return pageUrl_ ?? PageUrlDefaultValue; }
      set {
        pageUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "page_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasPageUrl {
      get { return pageUrl_ != null; }
    }
    /// <summary>Clears the value of the "page_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPageUrl() {
      pageUrl_ = null;
    }

    /// <summary>Field number for the "has_negative_keyword" field.</summary>
    public const int HasNegativeKeywordFieldNumber = 13;
    private readonly static bool HasNegativeKeywordDefaultValue = false;

    private bool hasNegativeKeyword_;
    /// <summary>
    /// Output only. True if query matches a negative keyword.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNegativeKeyword {
      get { if ((_hasBits0 & 1) != 0) { return hasNegativeKeyword_; } else { return HasNegativeKeywordDefaultValue; } }
      set {
        _hasBits0 |= 1;
        hasNegativeKeyword_ = value;
      }
    }
    /// <summary>Gets whether the "has_negative_keyword" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHasNegativeKeyword {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "has_negative_keyword" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHasNegativeKeyword() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "has_matching_keyword" field.</summary>
    public const int HasMatchingKeywordFieldNumber = 14;
    private readonly static bool HasMatchingKeywordDefaultValue = false;

    private bool hasMatchingKeyword_;
    /// <summary>
    /// Output only. True if query is added to targeted keywords.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMatchingKeyword {
      get { if ((_hasBits0 & 2) != 0) { return hasMatchingKeyword_; } else { return HasMatchingKeywordDefaultValue; } }
      set {
        _hasBits0 |= 2;
        hasMatchingKeyword_ = value;
      }
    }
    /// <summary>Gets whether the "has_matching_keyword" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHasMatchingKeyword {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "has_matching_keyword" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHasMatchingKeyword() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "has_negative_url" field.</summary>
    public const int HasNegativeUrlFieldNumber = 15;
    private readonly static bool HasNegativeUrlDefaultValue = false;

    private bool hasNegativeUrl_;
    /// <summary>
    /// Output only. True if query matches a negative url.
    ///
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasNegativeUrl {
      get { if ((_hasBits0 & 4) != 0) { return hasNegativeUrl_; } else { return HasNegativeUrlDefaultValue; } }
      set {
        _hasBits0 |= 4;
        hasNegativeUrl_ = value;
      }
    }
    /// <summary>Gets whether the "has_negative_url" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasHasNegativeUrl {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "has_negative_url" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearHasNegativeUrl() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DynamicSearchAdsSearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DynamicSearchAdsSearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      if (Headline != other.Headline) return false;
      if (LandingPage != other.LandingPage) return false;
      if (PageUrl != other.PageUrl) return false;
      if (HasNegativeKeyword != other.HasNegativeKeyword) return false;
      if (HasMatchingKeyword != other.HasMatchingKeyword) return false;
      if (HasNegativeUrl != other.HasNegativeUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasSearchTerm) hash ^= SearchTerm.GetHashCode();
      if (HasHeadline) hash ^= Headline.GetHashCode();
      if (HasLandingPage) hash ^= LandingPage.GetHashCode();
      if (HasPageUrl) hash ^= PageUrl.GetHashCode();
      if (HasHasNegativeKeyword) hash ^= HasNegativeKeyword.GetHashCode();
      if (HasHasMatchingKeyword) hash ^= HasMatchingKeyword.GetHashCode();
      if (HasHasNegativeUrl) hash ^= HasNegativeUrl.GetHashCode();
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
      if (HasSearchTerm) {
        output.WriteRawTag(74);
        output.WriteString(SearchTerm);
      }
      if (HasHeadline) {
        output.WriteRawTag(82);
        output.WriteString(Headline);
      }
      if (HasLandingPage) {
        output.WriteRawTag(90);
        output.WriteString(LandingPage);
      }
      if (HasPageUrl) {
        output.WriteRawTag(98);
        output.WriteString(PageUrl);
      }
      if (HasHasNegativeKeyword) {
        output.WriteRawTag(104);
        output.WriteBool(HasNegativeKeyword);
      }
      if (HasHasMatchingKeyword) {
        output.WriteRawTag(112);
        output.WriteBool(HasMatchingKeyword);
      }
      if (HasHasNegativeUrl) {
        output.WriteRawTag(120);
        output.WriteBool(HasNegativeUrl);
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
      if (HasSearchTerm) {
        output.WriteRawTag(74);
        output.WriteString(SearchTerm);
      }
      if (HasHeadline) {
        output.WriteRawTag(82);
        output.WriteString(Headline);
      }
      if (HasLandingPage) {
        output.WriteRawTag(90);
        output.WriteString(LandingPage);
      }
      if (HasPageUrl) {
        output.WriteRawTag(98);
        output.WriteString(PageUrl);
      }
      if (HasHasNegativeKeyword) {
        output.WriteRawTag(104);
        output.WriteBool(HasNegativeKeyword);
      }
      if (HasHasMatchingKeyword) {
        output.WriteRawTag(112);
        output.WriteBool(HasMatchingKeyword);
      }
      if (HasHasNegativeUrl) {
        output.WriteRawTag(120);
        output.WriteBool(HasNegativeUrl);
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
      if (HasSearchTerm) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SearchTerm);
      }
      if (HasHeadline) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Headline);
      }
      if (HasLandingPage) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LandingPage);
      }
      if (HasPageUrl) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageUrl);
      }
      if (HasHasNegativeKeyword) {
        size += 1 + 1;
      }
      if (HasHasMatchingKeyword) {
        size += 1 + 1;
      }
      if (HasHasNegativeUrl) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DynamicSearchAdsSearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasSearchTerm) {
        SearchTerm = other.SearchTerm;
      }
      if (other.HasHeadline) {
        Headline = other.Headline;
      }
      if (other.HasLandingPage) {
        LandingPage = other.LandingPage;
      }
      if (other.HasPageUrl) {
        PageUrl = other.PageUrl;
      }
      if (other.HasHasNegativeKeyword) {
        HasNegativeKeyword = other.HasNegativeKeyword;
      }
      if (other.HasHasMatchingKeyword) {
        HasMatchingKeyword = other.HasMatchingKeyword;
      }
      if (other.HasHasNegativeUrl) {
        HasNegativeUrl = other.HasNegativeUrl;
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
          case 74: {
            SearchTerm = input.ReadString();
            break;
          }
          case 82: {
            Headline = input.ReadString();
            break;
          }
          case 90: {
            LandingPage = input.ReadString();
            break;
          }
          case 98: {
            PageUrl = input.ReadString();
            break;
          }
          case 104: {
            HasNegativeKeyword = input.ReadBool();
            break;
          }
          case 112: {
            HasMatchingKeyword = input.ReadBool();
            break;
          }
          case 120: {
            HasNegativeUrl = input.ReadBool();
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
          case 74: {
            SearchTerm = input.ReadString();
            break;
          }
          case 82: {
            Headline = input.ReadString();
            break;
          }
          case 90: {
            LandingPage = input.ReadString();
            break;
          }
          case 98: {
            PageUrl = input.ReadString();
            break;
          }
          case 104: {
            HasNegativeKeyword = input.ReadBool();
            break;
          }
          case 112: {
            HasMatchingKeyword = input.ReadBool();
            break;
          }
          case 120: {
            HasNegativeUrl = input.ReadBool();
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
