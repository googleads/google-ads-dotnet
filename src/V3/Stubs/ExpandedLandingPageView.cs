// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/expanded_landing_page_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/expanded_landing_page_view.proto</summary>
  public static partial class ExpandedLandingPageViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/expanded_landing_page_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExpandedLandingPageViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvZXhwYW5kZWRf",
            "bGFuZGluZ19wYWdlX3ZpZXcucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYzLnJlc291cmNlcxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVm",
            "L3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3Rv",
            "Iq0CChdFeHBhbmRlZExhbmRpbmdQYWdlVmlldxJPCg1yZXNvdXJjZV9uYW1l",
            "GAEgASgJQjjgQQP6QTIKMGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9FeHBh",
            "bmRlZExhbmRpbmdQYWdlVmlldxI9ChJleHBhbmRlZF9maW5hbF91cmwYAiAB",
            "KAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAzqBAepBfgow",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0V4cGFuZGVkTGFuZGluZ1BhZ2VW",
            "aWV3EkpjdXN0b21lcnMve2N1c3RvbWVyfS9leHBhbmRlZExhbmRpbmdQYWdl",
            "Vmlld3Mve2V4cGFuZGVkX2xhbmRpbmdfcGFnZV92aWV3fUKJAgolY29tLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlc0IcRXhwYW5kZWRMYW5k",
            "aW5nUGFnZVZpZXdQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzO3Jlc291",
            "cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLlJlc291cmNl",
            "c8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFJlc291cmNlc+oCJUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.ExpandedLandingPageView), global::Google.Ads.GoogleAds.V3.Resources.ExpandedLandingPageView.Parser, new[]{ "ResourceName", "ExpandedFinalUrl" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A landing page view with metrics aggregated at the expanded final URL
  /// level.
  /// </summary>
  public sealed partial class ExpandedLandingPageView : pb::IMessage<ExpandedLandingPageView> {
    private static readonly pb::MessageParser<ExpandedLandingPageView> _parser = new pb::MessageParser<ExpandedLandingPageView>(() => new ExpandedLandingPageView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ExpandedLandingPageView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.ExpandedLandingPageViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExpandedLandingPageView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExpandedLandingPageView(ExpandedLandingPageView other) : this() {
      resourceName_ = other.resourceName_;
      ExpandedFinalUrl = other.ExpandedFinalUrl;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ExpandedLandingPageView Clone() {
      return new ExpandedLandingPageView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the expanded landing page view.
    /// Expanded landing page view resource names have the form:
    ///
    /// `customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "expanded_final_url" field.</summary>
    public const int ExpandedFinalUrlFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_expandedFinalUrl_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string expandedFinalUrl_;
    /// <summary>
    /// Output only. The final URL that clicks are directed to.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExpandedFinalUrl {
      get { return expandedFinalUrl_; }
      set {
        expandedFinalUrl_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ExpandedLandingPageView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ExpandedLandingPageView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ExpandedFinalUrl != other.ExpandedFinalUrl) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (expandedFinalUrl_ != null) hash ^= ExpandedFinalUrl.GetHashCode();
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
      if (expandedFinalUrl_ != null) {
        _single_expandedFinalUrl_codec.WriteTagAndValue(output, ExpandedFinalUrl);
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
      if (expandedFinalUrl_ != null) {
        size += _single_expandedFinalUrl_codec.CalculateSizeWithTag(ExpandedFinalUrl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ExpandedLandingPageView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.expandedFinalUrl_ != null) {
        if (expandedFinalUrl_ == null || other.ExpandedFinalUrl != "") {
          ExpandedFinalUrl = other.ExpandedFinalUrl;
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
            string value = _single_expandedFinalUrl_codec.Read(input);
            if (expandedFinalUrl_ == null || value != "") {
              ExpandedFinalUrl = value;
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
