// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/parental_status_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/services/parental_status_view_service.proto</summary>
  public static partial class ParentalStatusViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/services/parental_status_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParentalStatusViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcy9wYXJlbnRhbF9z",
            "dGF0dXNfdmlld19zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52NC5zZXJ2aWNlcxo8Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjQvcmVzb3Vy",
            "Y2VzL3BhcmVudGFsX3N0YXR1c192aWV3LnByb3RvGhxnb29nbGUvYXBpL2Fu",
            "bm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90byJqChxHZXRQYXJlbnRhbFN0YXR1c1ZpZXdSZXF1ZXN0EkoK",
            "DXJlc291cmNlX25hbWUYASABKAlCM+BBAvpBLQorZ29vZ2xlYWRzLmdvb2ds",
            "ZWFwaXMuY29tL1BhcmVudGFsU3RhdHVzVmlldzLCAgoZUGFyZW50YWxTdGF0",
            "dXNWaWV3U2VydmljZRLdAQoVR2V0UGFyZW50YWxTdGF0dXNWaWV3Ej4uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjQuc2VydmljZXMuR2V0UGFyZW50YWxTdGF0",
            "dXNWaWV3UmVxdWVzdBo1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LnJlc291",
            "cmNlcy5QYXJlbnRhbFN0YXR1c1ZpZXciTYLT5JMCNxI1L3Y0L3tyZXNvdXJj",
            "ZV9uYW1lPWN1c3RvbWVycy8qL3BhcmVudGFsU3RhdHVzVmlld3MvKn3aQQ1y",
            "ZXNvdXJjZV9uYW1lGkXKQRhnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdo",
            "dHRwczovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Fkd29yZHNChQIKJGNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5zZXJ2aWNlc0IeUGFyZW50YWxT",
            "dGF0dXNWaWV3U2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92NC9zZXJ2aWNlcztz",
            "ZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlY0LlNlcnZp",
            "Y2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjRcU2VydmljZXPqAiRHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Resources.ParentalStatusViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Services.GetParentalStatusViewRequest), global::Google.Ads.GoogleAds.V4.Services.GetParentalStatusViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [ParentalStatusViewService.GetParentalStatusView][google.ads.googleads.v4.services.ParentalStatusViewService.GetParentalStatusView].
  /// </summary>
  public sealed partial class GetParentalStatusViewRequest : pb::IMessage<GetParentalStatusViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetParentalStatusViewRequest> _parser = new pb::MessageParser<GetParentalStatusViewRequest>(() => new GetParentalStatusViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetParentalStatusViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Services.ParentalStatusViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParentalStatusViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParentalStatusViewRequest(GetParentalStatusViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetParentalStatusViewRequest Clone() {
      return new GetParentalStatusViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the parental status view to fetch.
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
      return Equals(other as GetParentalStatusViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetParentalStatusViewRequest other) {
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
    public void MergeFrom(GetParentalStatusViewRequest other) {
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
