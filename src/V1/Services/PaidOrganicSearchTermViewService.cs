// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/paid_organic_search_term_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/paid_organic_search_term_view_service.proto</summary>
  public static partial class PaidOrganicSearchTermViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/paid_organic_search_term_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaidOrganicSearchTermViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9wYWlkX29yZ2Fu",
            "aWNfc2VhcmNoX3Rlcm1fdmlld19zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MS5zZXJ2aWNlcxpFZ29vZ2xlL2Fkcy9nb29nbGVhZHMv",
            "djEvcmVzb3VyY2VzL3BhaWRfb3JnYW5pY19zZWFyY2hfdGVybV92aWV3LnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBp",
            "L2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJ4CiNHZXRQYWlkT3JnYW5p",
            "Y1NlYXJjaFRlcm1WaWV3UmVxdWVzdBJRCg1yZXNvdXJjZV9uYW1lGAEgASgJ",
            "QjrgQQL6QTQKMmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9QYWlkT3JnYW5p",
            "Y1NlYXJjaFRlcm1WaWV3MrsCCiBQYWlkT3JnYW5pY1NlYXJjaFRlcm1WaWV3",
            "U2VydmljZRL5AQocR2V0UGFpZE9yZ2FuaWNTZWFyY2hUZXJtVmlldxJFLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZpY2VzLkdldFBhaWRPcmdhbmlj",
            "U2VhcmNoVGVybVZpZXdSZXF1ZXN0GjwuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEucmVzb3VyY2VzLlBhaWRPcmdhbmljU2VhcmNoVGVybVZpZXciVILT5JMC",
            "PhI8L3YxL3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8qL3BhaWRPcmdhbmlj",
            "U2VhcmNoVGVybVZpZXdzLyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tQowCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEuc2VydmljZXNCJVBhaWRPcmdhbmljU2VhcmNoVGVybVZpZXdTZXJ2",
            "aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FB",
            "qgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuU2VydmljZXPKAiBHb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWMVxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.PaidOrganicSearchTermViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetPaidOrganicSearchTermViewRequest), global::Google.Ads.GoogleAds.V1.Services.GetPaidOrganicSearchTermViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [PaidOrganicSearchTermViewService.GetPaidOrganicSearchTermView][google.ads.googleads.v1.services.PaidOrganicSearchTermViewService.GetPaidOrganicSearchTermView].
  /// </summary>
  public sealed partial class GetPaidOrganicSearchTermViewRequest : pb::IMessage<GetPaidOrganicSearchTermViewRequest> {
    private static readonly pb::MessageParser<GetPaidOrganicSearchTermViewRequest> _parser = new pb::MessageParser<GetPaidOrganicSearchTermViewRequest>(() => new GetPaidOrganicSearchTermViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetPaidOrganicSearchTermViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.PaidOrganicSearchTermViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPaidOrganicSearchTermViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPaidOrganicSearchTermViewRequest(GetPaidOrganicSearchTermViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetPaidOrganicSearchTermViewRequest Clone() {
      return new GetPaidOrganicSearchTermViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the paid organic search term view to fetch.
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
      return Equals(other as GetPaidOrganicSearchTermViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetPaidOrganicSearchTermViewRequest other) {
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
    public void MergeFrom(GetPaidOrganicSearchTermViewRequest other) {
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

  #endregion

}

#endregion Designer generated code
