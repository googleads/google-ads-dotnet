// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/ad_group_ad_asset_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/ad_group_ad_asset_view_service.proto</summary>
  public static partial class AdGroupAdAssetViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/ad_group_ad_asset_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAdAssetViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy9hZF9ncm91cF9h",
            "ZF9hc3NldF92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY0LnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNv",
            "dXJjZXMvYWRfZ3JvdXBfYWRfYXNzZXRfdmlldy5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkv",
            "cmVzb3VyY2UucHJvdG8iagocR2V0QWRHcm91cEFkQXNzZXRWaWV3UmVxdWVz",
            "dBJKCg1yZXNvdXJjZV9uYW1lGAEgASgJQjPgQQL6QS0KK2dvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9BZEdyb3VwQWRBc3NldFZpZXcymAIKGUFkR3JvdXBB",
            "ZEFzc2V0Vmlld1NlcnZpY2US3QEKFUdldEFkR3JvdXBBZEFzc2V0VmlldxI+",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNlcnZpY2VzLkdldEFkR3JvdXBB",
            "ZEFzc2V0Vmlld1JlcXVlc3QaNS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5y",
            "ZXNvdXJjZXMuQWRHcm91cEFkQXNzZXRWaWV3Ik2C0+STAjcSNS92NC97cmVz",
            "b3VyY2VfbmFtZT1jdXN0b21lcnMvKi9hZEdyb3VwQWRBc3NldFZpZXdzLyp9",
            "2kENcmVzb3VyY2VfbmFtZRobykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "QoUCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuc2VydmljZXNCHkFk",
            "R3JvdXBBZEFzc2V0Vmlld1NlcnZpY2VQcm90b1ABWkhnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjQvc2Vy",
            "dmljZXM7c2VydmljZXOiAgNHQUGqAiBHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "NC5TZXJ2aWNlc8oCIEdvb2dsZVxBZHNcR29vZ2xlQWRzXFY0XFNlcnZpY2Vz",
            "6gIkR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjQ6OlNlcnZpY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.AdGroupAdAssetViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdAssetViewRequest), global::Google.Ads.GoogleAds.V4.Services.GetAdGroupAdAssetViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [AdGroupAdAssetViewService.GetAdGroupAdAssetView][google.ads.googleads.v4.services.AdGroupAdAssetViewService.GetAdGroupAdAssetView].
  /// </summary>
  public sealed partial class GetAdGroupAdAssetViewRequest : pb::IMessage<GetAdGroupAdAssetViewRequest> {
    private static readonly pb::MessageParser<GetAdGroupAdAssetViewRequest> _parser = new pb::MessageParser<GetAdGroupAdAssetViewRequest>(() => new GetAdGroupAdAssetViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAdGroupAdAssetViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.AdGroupAdAssetViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupAdAssetViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupAdAssetViewRequest(GetAdGroupAdAssetViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupAdAssetViewRequest Clone() {
      return new GetAdGroupAdAssetViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the ad group ad asset view to fetch.
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
      return Equals(other as GetAdGroupAdAssetViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAdGroupAdAssetViewRequest other) {
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
    public void MergeFrom(GetAdGroupAdAssetViewRequest other) {
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
