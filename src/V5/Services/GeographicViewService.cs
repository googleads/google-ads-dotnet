// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/geographic_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/services/geographic_view_service.proto</summary>
  public static partial class GeographicViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/services/geographic_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GeographicViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92NS9zZXJ2aWNlcy9nZW9ncmFwaGlj",
            "X3ZpZXdfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUu",
            "c2VydmljZXMaN2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y1L3Jlc291cmNlcy9n",
            "ZW9ncmFwaGljX3ZpZXcucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "ImIKGEdldEdlb2dyYXBoaWNWaWV3UmVxdWVzdBJGCg1yZXNvdXJjZV9uYW1l",
            "GAEgASgJQi/gQQL6QSkKJ2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9HZW9n",
            "cmFwaGljVmlldzKuAgoVR2VvZ3JhcGhpY1ZpZXdTZXJ2aWNlEs0BChFHZXRH",
            "ZW9ncmFwaGljVmlldxI6Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY1LnNlcnZp",
            "Y2VzLkdldEdlb2dyYXBoaWNWaWV3UmVxdWVzdBoxLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY1LnJlc291cmNlcy5HZW9ncmFwaGljVmlldyJJgtPkkwIzEjEv",
            "djUve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovZ2VvZ3JhcGhpY1ZpZXdz",
            "Lyp92kENcmVzb3VyY2VfbmFtZRpFykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29t0kEnaHR0cHM6Ly93d3cuZ29vZ2xlYXBpcy5jb20vYXV0aC9hZHdvcmRz",
            "QoECCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUuc2VydmljZXNCGkdl",
            "b2dyYXBoaWNWaWV3U2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NS9zZXJ2aWNl",
            "cztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlY1LlNl",
            "cnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjVcU2VydmljZXPqAiRH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNTo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V5.Resources.GeographicViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Services.GetGeographicViewRequest), global::Google.Ads.GoogleAds.V5.Services.GetGeographicViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [GeographicViewService.GetGeographicView][google.ads.googleads.v5.services.GeographicViewService.GetGeographicView].
  /// </summary>
  public sealed partial class GetGeographicViewRequest : pb::IMessage<GetGeographicViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetGeographicViewRequest> _parser = new pb::MessageParser<GetGeographicViewRequest>(() => new GetGeographicViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetGeographicViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Services.GeographicViewServiceReflection.Descriptor.MessageTypes[0]; }
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
    /// Required. The resource name of the geographic view to fetch.
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

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
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
