// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/operating_system_version_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/operating_system_version_constant_service.proto</summary>
  public static partial class OperatingSystemVersionConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/operating_system_version_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperatingSystemVersionConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9vcGVyYXRpbmdf",
            "c3lzdGVtX3ZlcnNpb25fY29uc3RhbnRfc2VydmljZS5wcm90bxIgZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjMuc2VydmljZXMaSWdvb2dsZS9hZHMvZ29vZ2xl",
            "YWRzL3YzL3Jlc291cmNlcy9vcGVyYXRpbmdfc3lzdGVtX3ZlcnNpb25fY29u",
            "c3RhbnQucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8aF2dv",
            "b2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2",
            "aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIoIBCihHZXRP",
            "cGVyYXRpbmdTeXN0ZW1WZXJzaW9uQ29uc3RhbnRSZXF1ZXN0ElYKDXJlc291",
            "cmNlX25hbWUYASABKAlCP+BBAvpBOQo3Z29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL09wZXJhdGluZ1N5c3RlbVZlcnNpb25Db25zdGFudDLIAgolT3BlcmF0",
            "aW5nU3lzdGVtVmVyc2lvbkNvbnN0YW50U2VydmljZRKBAgohR2V0T3BlcmF0",
            "aW5nU3lzdGVtVmVyc2lvbkNvbnN0YW50EkouZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuc2VydmljZXMuR2V0T3BlcmF0aW5nU3lzdGVtVmVyc2lvbkNvbnN0",
            "YW50UmVxdWVzdBpBLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNl",
            "cy5PcGVyYXRpbmdTeXN0ZW1WZXJzaW9uQ29uc3RhbnQiTYLT5JMCNxI1L3Yz",
            "L3tyZXNvdXJjZV9uYW1lPW9wZXJhdGluZ1N5c3RlbVZlcnNpb25Db25zdGFu",
            "dHMvKn3aQQ1yZXNvdXJjZV9uYW1lGhvKQRhnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb21CkQIKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNl",
            "c0IqT3BlcmF0aW5nU3lzdGVtVmVyc2lvbkNvbnN0YW50U2VydmljZVByb3Rv",
            "UAFaSGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92My9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYzLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjNcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mzo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.OperatingSystemVersionConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetOperatingSystemVersionConstantRequest), global::Google.Ads.GoogleAds.V3.Services.GetOperatingSystemVersionConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [OperatingSystemVersionConstantService.GetOperatingSystemVersionConstant][google.ads.googleads.v3.services.OperatingSystemVersionConstantService.GetOperatingSystemVersionConstant].
  /// </summary>
  public sealed partial class GetOperatingSystemVersionConstantRequest : pb::IMessage<GetOperatingSystemVersionConstantRequest> {
    private static readonly pb::MessageParser<GetOperatingSystemVersionConstantRequest> _parser = new pb::MessageParser<GetOperatingSystemVersionConstantRequest>(() => new GetOperatingSystemVersionConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetOperatingSystemVersionConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.OperatingSystemVersionConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetOperatingSystemVersionConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetOperatingSystemVersionConstantRequest(GetOperatingSystemVersionConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetOperatingSystemVersionConstantRequest Clone() {
      return new GetOperatingSystemVersionConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the OS version to fetch.
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
      return Equals(other as GetOperatingSystemVersionConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetOperatingSystemVersionConstantRequest other) {
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
    public void MergeFrom(GetOperatingSystemVersionConstantRequest other) {
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
