// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/topic_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/topic_constant_service.proto</summary>
  public static partial class TopicConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/topic_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TopicConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy90b3BpY19jb25z",
            "dGFudF9zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52NC5z",
            "ZXJ2aWNlcxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjQvcmVzb3VyY2VzL3Rv",
            "cGljX2NvbnN0YW50LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVs",
            "ZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJg",
            "ChdHZXRUb3BpY0NvbnN0YW50UmVxdWVzdBJFCg1yZXNvdXJjZV9uYW1lGAEg",
            "ASgJQi7gQQL6QSgKJmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Ub3BpY0Nv",
            "bnN0YW50Mp0CChRUb3BpY0NvbnN0YW50U2VydmljZRK9AQoQR2V0VG9waWND",
            "b25zdGFudBI5Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnNlcnZpY2VzLkdl",
            "dFRvcGljQ29uc3RhbnRSZXF1ZXN0GjAuZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djQucmVzb3VyY2VzLlRvcGljQ29uc3RhbnQiPILT5JMCJhIkL3Y0L3tyZXNv",
            "dXJjZV9uYW1lPXRvcGljQ29uc3RhbnRzLyp92kENcmVzb3VyY2VfbmFtZRpF",
            "ykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t0kEnaHR0cHM6Ly93d3cuZ29v",
            "Z2xlYXBpcy5jb20vYXV0aC9hZHdvcmRzQoACCiRjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjQuc2VydmljZXNCGVRvcGljQ29uc3RhbnRTZXJ2aWNlUHJv",
            "dG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3Y0L3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIgR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjQuU2VydmljZXPKAiBHb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWNFxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlY0OjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.TopicConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetTopicConstantRequest), global::Google.Ads.GoogleAds.V4.Services.GetTopicConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [TopicConstantService.GetTopicConstant][google.ads.googleads.v4.services.TopicConstantService.GetTopicConstant].
  /// </summary>
  public sealed partial class GetTopicConstantRequest : pb::IMessage<GetTopicConstantRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetTopicConstantRequest> _parser = new pb::MessageParser<GetTopicConstantRequest>(() => new GetTopicConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetTopicConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.TopicConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTopicConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTopicConstantRequest(GetTopicConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetTopicConstantRequest Clone() {
      return new GetTopicConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the Topic to fetch.
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
      return Equals(other as GetTopicConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetTopicConstantRequest other) {
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
    public void MergeFrom(GetTopicConstantRequest other) {
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
