// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/google_ads_field_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/google_ads_field_service.proto</summary>
  public static partial class GoogleAdsFieldServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/google_ads_field_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GoogleAdsFieldServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9nb29nbGVfYWRz",
            "X2ZpZWxkX3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYw",
            "LnNlcnZpY2VzGjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMv",
            "Z29vZ2xlX2Fkc19maWVsZC5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byIxChhHZXRHb29nbGVBZHNGaWVsZFJlcXVlc3QSFQoNcmVzb3Vy",
            "Y2VfbmFtZRgBIAEoCSJUChxTZWFyY2hHb29nbGVBZHNGaWVsZHNSZXF1ZXN0",
            "Eg0KBXF1ZXJ5GAEgASgJEhIKCnBhZ2VfdG9rZW4YAiABKAkSEQoJcGFnZV9z",
            "aXplGAMgASgFIpkBCh1TZWFyY2hHb29nbGVBZHNGaWVsZHNSZXNwb25zZRJC",
            "CgdyZXN1bHRzGAEgAygLMjEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVz",
            "b3VyY2VzLkdvb2dsZUFkc0ZpZWxkEhcKD25leHRfcGFnZV90b2tlbhgCIAEo",
            "CRIbChN0b3RhbF9yZXN1bHRzX2NvdW50GAMgASgDMo0DChVHb29nbGVBZHNG",
            "aWVsZFNlcnZpY2USsQEKEUdldEdvb2dsZUFkc0ZpZWxkEjouZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjAuc2VydmljZXMuR2V0R29vZ2xlQWRzRmllbGRSZXF1",
            "ZXN0GjEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzLkdvb2ds",
            "ZUFkc0ZpZWxkIi2C0+STAicSJS92MC97cmVzb3VyY2VfbmFtZT1nb29nbGVB",
            "ZHNGaWVsZHMvKn0SvwEKFVNlYXJjaEdvb2dsZUFkc0ZpZWxkcxI+Lmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYwLnNlcnZpY2VzLlNlYXJjaEdvb2dsZUFkc0Zp",
            "ZWxkc1JlcXVlc3QaPy5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNl",
            "cy5TZWFyY2hHb29nbGVBZHNGaWVsZHNSZXNwb25zZSIlgtPkkwIfIhovdjAv",
            "Z29vZ2xlQWRzRmllbGRzOnNlYXJjaDoBKkKBAgokY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYwLnNlcnZpY2VzQhpHb29nbGVBZHNGaWVsZFNlcnZpY2VQ",
            "cm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjAvc2VydmljZXM7c2VydmljZXOiAgNHQUGqAiBH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMC5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYwXFNlcnZpY2Vz6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjA6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsFieldReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetGoogleAdsFieldRequest), global::Google.Ads.GoogleAds.V0.Services.GetGoogleAdsFieldRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.SearchGoogleAdsFieldsRequest), global::Google.Ads.GoogleAds.V0.Services.SearchGoogleAdsFieldsRequest.Parser, new[]{ "Query", "PageToken", "PageSize" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.SearchGoogleAdsFieldsResponse), global::Google.Ads.GoogleAds.V0.Services.SearchGoogleAdsFieldsResponse.Parser, new[]{ "Results", "NextPageToken", "TotalResultsCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [GoogleAdsFieldService.GetGoogleAdsField][google.ads.googleads.v0.services.GoogleAdsFieldService.GetGoogleAdsField].
  /// </summary>
  public sealed partial class GetGoogleAdsFieldRequest : pb::IMessage<GetGoogleAdsFieldRequest> {
    private static readonly pb::MessageParser<GetGoogleAdsFieldRequest> _parser = new pb::MessageParser<GetGoogleAdsFieldRequest>(() => new GetGoogleAdsFieldRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGoogleAdsFieldRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.GoogleAdsFieldServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGoogleAdsFieldRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGoogleAdsFieldRequest(GetGoogleAdsFieldRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGoogleAdsFieldRequest Clone() {
      return new GetGoogleAdsFieldRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the field to get.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetGoogleAdsFieldRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGoogleAdsFieldRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetGoogleAdsFieldRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
        }
      }
    }

  }

  /// <summary>
  /// Request message for [GoogleAdsFieldService.SearchGoogleAdsFields][google.ads.googleads.v0.services.GoogleAdsFieldService.SearchGoogleAdsFields].
  /// </summary>
  public sealed partial class SearchGoogleAdsFieldsRequest : pb::IMessage<SearchGoogleAdsFieldsRequest> {
    private static readonly pb::MessageParser<SearchGoogleAdsFieldsRequest> _parser = new pb::MessageParser<SearchGoogleAdsFieldsRequest>(() => new SearchGoogleAdsFieldsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchGoogleAdsFieldsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.GoogleAdsFieldServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsRequest(SearchGoogleAdsFieldsRequest other) : this() {
      query_ = other.query_;
      pageToken_ = other.pageToken_;
      pageSize_ = other.pageSize_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsRequest Clone() {
      return new SearchGoogleAdsFieldsRequest(this);
    }

    /// <summary>Field number for the "query" field.</summary>
    public const int QueryFieldNumber = 1;
    private string query_ = "";
    /// <summary>
    /// The query string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Query {
      get { return query_; }
      set {
        query_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 2;
    private string pageToken_ = "";
    /// <summary>
    /// Token of the page to retrieve. If not specified, the first page of
    /// results will be returned. Use the value obtained from `next_page_token`
    /// in the previous response in order to request the next page of results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 3;
    private int pageSize_;
    /// <summary>
    /// Number of elements to retrieve in a single page.
    /// When too large a page is requested, the server may decide to further
    /// limit the number of returned resources.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchGoogleAdsFieldsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchGoogleAdsFieldsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Query != other.Query) return false;
      if (PageToken != other.PageToken) return false;
      if (PageSize != other.PageSize) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Query.Length != 0) hash ^= Query.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
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
      if (Query.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Query);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PageToken);
      }
      if (PageSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Query.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Query);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SearchGoogleAdsFieldsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Query.Length != 0) {
        Query = other.Query;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
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
            Query = input.ReadString();
            break;
          }
          case 18: {
            PageToken = input.ReadString();
            break;
          }
          case 24: {
            PageSize = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for [GoogleAdsFieldService.SearchGoogleAdsFields][google.ads.googleads.v0.services.GoogleAdsFieldService.SearchGoogleAdsFields].
  /// </summary>
  public sealed partial class SearchGoogleAdsFieldsResponse : pb::IMessage<SearchGoogleAdsFieldsResponse> {
    private static readonly pb::MessageParser<SearchGoogleAdsFieldsResponse> _parser = new pb::MessageParser<SearchGoogleAdsFieldsResponse>(() => new SearchGoogleAdsFieldsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SearchGoogleAdsFieldsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.GoogleAdsFieldServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsResponse(SearchGoogleAdsFieldsResponse other) : this() {
      results_ = other.results_.Clone();
      nextPageToken_ = other.nextPageToken_;
      totalResultsCount_ = other.totalResultsCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SearchGoogleAdsFieldsResponse Clone() {
      return new SearchGoogleAdsFieldsResponse(this);
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsField> _repeated_results_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsField.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsField> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsField>();
    /// <summary>
    /// The list of fields that matched the query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V0.Resources.GoogleAdsField> Results {
      get { return results_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// Pagination token used to retrieve the next page of results. Pass the
    /// content of this string as the `page_token` attribute of the next request.
    /// `next_page_token` is not returned for the last page.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "total_results_count" field.</summary>
    public const int TotalResultsCountFieldNumber = 3;
    private long totalResultsCount_;
    /// <summary>
    /// Total number of results that match the query ignoring the LIMIT clause.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long TotalResultsCount {
      get { return totalResultsCount_; }
      set {
        totalResultsCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SearchGoogleAdsFieldsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SearchGoogleAdsFieldsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!results_.Equals(other.results_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      if (TotalResultsCount != other.TotalResultsCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= results_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      if (TotalResultsCount != 0L) hash ^= TotalResultsCount.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalResultsCount != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(TotalResultsCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += results_.CalculateSize(_repeated_results_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (TotalResultsCount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(TotalResultsCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SearchGoogleAdsFieldsResponse other) {
      if (other == null) {
        return;
      }
      results_.Add(other.results_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
      if (other.TotalResultsCount != 0L) {
        TotalResultsCount = other.TotalResultsCount;
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
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalResultsCount = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
