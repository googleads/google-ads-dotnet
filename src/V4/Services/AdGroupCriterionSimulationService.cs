// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/ad_group_criterion_simulation_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/ad_group_criterion_simulation_service.proto</summary>
  public static partial class AdGroupCriterionSimulationServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/ad_group_criterion_simulation_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupCriterionSimulationServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckxnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy9hZF9ncm91cF9j",
            "cml0ZXJpb25fc2ltdWxhdGlvbl9zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52NC5zZXJ2aWNlcxpFZ29vZ2xlL2Fkcy9nb29nbGVhZHMv",
            "djQvcmVzb3VyY2VzL2FkX2dyb3VwX2NyaXRlcmlvbl9zaW11bGF0aW9uLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBp",
            "L2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJ6CiRHZXRBZEdyb3VwQ3Jp",
            "dGVyaW9uU2ltdWxhdGlvblJlcXVlc3QSUgoNcmVzb3VyY2VfbmFtZRgBIAEo",
            "CUI74EEC+kE1CjNnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cENy",
            "aXRlcmlvblNpbXVsYXRpb24ywAIKIUFkR3JvdXBDcml0ZXJpb25TaW11bGF0",
            "aW9uU2VydmljZRL9AQodR2V0QWRHcm91cENyaXRlcmlvblNpbXVsYXRpb24S",
            "Ri5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5zZXJ2aWNlcy5HZXRBZEdyb3Vw",
            "Q3JpdGVyaW9uU2ltdWxhdGlvblJlcXVlc3QaPS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52NC5yZXNvdXJjZXMuQWRHcm91cENyaXRlcmlvblNpbXVsYXRpb24i",
            "VYLT5JMCPxI9L3Y0L3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8qL2FkR3Jv",
            "dXBDcml0ZXJpb25TaW11bGF0aW9ucy8qfdpBDXJlc291cmNlX25hbWUaG8pB",
            "GGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbUKNAgokY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY0LnNlcnZpY2VzQiZBZEdyb3VwQ3JpdGVyaW9uU2ltdWxh",
            "dGlvblNlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvc2VydmljZXM7c2Vydmlj",
            "ZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5TZXJ2aWNlc8oC",
            "IEdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XFNlcnZpY2Vz6gIkR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjQ6OlNlcnZpY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.AdGroupCriterionSimulationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupCriterionSimulationRequest), global::Google.Ads.GoogleAds.V4.Services.GetAdGroupCriterionSimulationRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [AdGroupCriterionSimulationService.GetAdGroupCriterionSimulation][google.ads.googleads.v4.services.AdGroupCriterionSimulationService.GetAdGroupCriterionSimulation].
  /// </summary>
  public sealed partial class GetAdGroupCriterionSimulationRequest : pb::IMessage<GetAdGroupCriterionSimulationRequest> {
    private static readonly pb::MessageParser<GetAdGroupCriterionSimulationRequest> _parser = new pb::MessageParser<GetAdGroupCriterionSimulationRequest>(() => new GetAdGroupCriterionSimulationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAdGroupCriterionSimulationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.AdGroupCriterionSimulationServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupCriterionSimulationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupCriterionSimulationRequest(GetAdGroupCriterionSimulationRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupCriterionSimulationRequest Clone() {
      return new GetAdGroupCriterionSimulationRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the ad group criterion simulation to fetch.
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
      return Equals(other as GetAdGroupCriterionSimulationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAdGroupCriterionSimulationRequest other) {
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
    public void MergeFrom(GetAdGroupCriterionSimulationRequest other) {
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
