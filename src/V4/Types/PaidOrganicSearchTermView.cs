// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/paid_organic_search_term_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/paid_organic_search_term_view.proto</summary>
  public static partial class PaidOrganicSearchTermViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/paid_organic_search_term_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaidOrganicSearchTermViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvcGFpZF9vcmdh",
            "bmljX3NlYXJjaF90ZXJtX3ZpZXcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY0LnJlc291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5w",
            "cm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3Rv",
            "YnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvIrICChlQYWlkT3JnYW5pY1NlYXJjaFRlcm1WaWV3ElEKDXJlc291cmNl",
            "X25hbWUYASABKAlCOuBBA/pBNAoyZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L1BhaWRPcmdhbmljU2VhcmNoVGVybVZpZXcSNgoLc2VhcmNoX3Rlcm0YAiAB",
            "KAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAzqJAepBhQEK",
            "Mmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9QYWlkT3JnYW5pY1NlYXJjaFRl",
            "cm1WaWV3Ek9jdXN0b21lcnMve2N1c3RvbWVyfS9wYWlkT3JnYW5pY1NlYXJj",
            "aFRlcm1WaWV3cy97cGFpZF9vcmdhbmljX3NlYXJjaF90ZXJtX3ZpZXd9QosC",
            "CiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQucmVzb3VyY2VzQh5QYWlk",
            "T3JnYW5pY1NlYXJjaFRlcm1WaWV3UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L3Jlc291",
            "cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "NC5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxSZXNvdXJj",
            "ZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6UmVzb3VyY2VzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.PaidOrganicSearchTermView), global::Google.Ads.GoogleAds.V4.Resources.PaidOrganicSearchTermView.Parser, new[]{ "ResourceName", "SearchTerm" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A paid organic search term view providing a view of search stats across
  /// ads and organic listings aggregated by search term at the ad group level.
  /// </summary>
  public sealed partial class PaidOrganicSearchTermView : pb::IMessage<PaidOrganicSearchTermView> {
    private static readonly pb::MessageParser<PaidOrganicSearchTermView> _parser = new pb::MessageParser<PaidOrganicSearchTermView>(() => new PaidOrganicSearchTermView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PaidOrganicSearchTermView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.PaidOrganicSearchTermViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaidOrganicSearchTermView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaidOrganicSearchTermView(PaidOrganicSearchTermView other) : this() {
      resourceName_ = other.resourceName_;
      SearchTerm = other.SearchTerm;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PaidOrganicSearchTermView Clone() {
      return new PaidOrganicSearchTermView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the search term view.
    /// Search term view resource names have the form:
    ///
    /// `customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~
    /// {ad_group_id}~{URL-base64 search term}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "search_term" field.</summary>
    public const int SearchTermFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_searchTerm_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string searchTerm_;
    /// <summary>
    /// Output only. The search term.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SearchTerm {
      get { return searchTerm_; }
      set {
        searchTerm_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PaidOrganicSearchTermView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PaidOrganicSearchTermView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SearchTerm != other.SearchTerm) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (searchTerm_ != null) hash ^= SearchTerm.GetHashCode();
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
      if (searchTerm_ != null) {
        _single_searchTerm_codec.WriteTagAndValue(output, SearchTerm);
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
      if (searchTerm_ != null) {
        size += _single_searchTerm_codec.CalculateSizeWithTag(SearchTerm);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PaidOrganicSearchTermView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.searchTerm_ != null) {
        if (searchTerm_ == null || other.SearchTerm != "") {
          SearchTerm = other.SearchTerm;
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
            string value = _single_searchTerm_codec.Read(input);
            if (searchTerm_ == null || value != "") {
              SearchTerm = value;
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
