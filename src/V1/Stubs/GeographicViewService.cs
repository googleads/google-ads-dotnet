// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/services/geographic_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/services/geographic_view_service.proto</summary>
  public static partial class GeographicViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/services/geographic_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeographicViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9zZXJ2aWNlcy9nZW9ncmFwaGlj",
            "X3ZpZXdfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEu",
            "c2VydmljZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL3Jlc291cmNlcy9n",
            "ZW9ncmFwaGljX3ZpZXcucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8iMQoYR2V0R2VvZ3JhcGhpY1ZpZXdSZXF1ZXN0EhUKDXJlc291cmNl",
            "X25hbWUYASABKAky1wEKFUdlb2dyYXBoaWNWaWV3U2VydmljZRK9AQoRR2V0",
            "R2VvZ3JhcGhpY1ZpZXcSOi5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5zZXJ2",
            "aWNlcy5HZXRHZW9ncmFwaGljVmlld1JlcXVlc3QaMS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MS5yZXNvdXJjZXMuR2VvZ3JhcGhpY1ZpZXciOYLT5JMCMxIx",
            "L3YxL3tyZXNvdXJjZV9uYW1lPWN1c3RvbWVycy8qL2dlb2dyYXBoaWNWaWV3",
            "cy8qfUKBAgokY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnNlcnZpY2Vz",
            "QhpHZW9ncmFwaGljVmlld1NlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEvc2Vy",
            "dmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MS5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXFNlcnZpY2Vz",
            "6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OlNlcnZpY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Resources.GeographicViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Services.GetGeographicViewRequest), global::Google.Ads.GoogleAds.V1.Services.GetGeographicViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [GeographicViewService.GetGeographicView][google.ads.googleads.v1.services.GeographicViewService.GetGeographicView].
  /// </summary>
  public sealed partial class GetGeographicViewRequest : pb::IMessage<GetGeographicViewRequest> {
    private static readonly pb::MessageParser<GetGeographicViewRequest> _parser = new pb::MessageParser<GetGeographicViewRequest>(() => new GetGeographicViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGeographicViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Services.GeographicViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeographicViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeographicViewRequest(GetGeographicViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetGeographicViewRequest Clone() {
      return new GetGeographicViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the geographic view to fetch.
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
      return Equals(other as GetGeographicViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetGeographicViewRequest other) {
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
    public void MergeFrom(GetGeographicViewRequest other) {
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
