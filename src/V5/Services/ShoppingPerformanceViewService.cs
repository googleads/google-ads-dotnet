// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v5/services/shopping_performance_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V5.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v5/services/shopping_performance_view_service.proto</summary>
  public static partial class ShoppingPerformanceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v5/services/shopping_performance_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ShoppingPerformanceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckhnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9zZXJ2aWNlcy9zaG9wcGluZ19w",
            "ZXJmb3JtYW5jZV92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY1LnNlcnZpY2VzGkFnb29nbGUvYWRzL2dvb2dsZWFkcy92NS9y",
            "ZXNvdXJjZXMvc2hvcHBpbmdfcGVyZm9ybWFuY2Vfdmlldy5wcm90bxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQu",
            "cHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8idAohR2V0U2hvcHBpbmdQZXJmb3JtYW5j",
            "ZVZpZXdSZXF1ZXN0Ek8KDXJlc291cmNlX25hbWUYASABKAlCOOBBAvpBMgow",
            "Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1Nob3BwaW5nUGVyZm9ybWFuY2VW",
            "aWV3MtgCCh5TaG9wcGluZ1BlcmZvcm1hbmNlVmlld1NlcnZpY2US7gEKGkdl",
            "dFNob3BwaW5nUGVyZm9ybWFuY2VWaWV3EkMuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjUuc2VydmljZXMuR2V0U2hvcHBpbmdQZXJmb3JtYW5jZVZpZXdSZXF1",
            "ZXN0GjouZ29vZ2xlLmFkcy5nb29nbGVhZHMudjUucmVzb3VyY2VzLlNob3Bw",
            "aW5nUGVyZm9ybWFuY2VWaWV3Ik+C0+STAjkSNy92NS97cmVzb3VyY2VfbmFt",
            "ZT1jdXN0b21lcnMvKi9zaG9wcGluZ1BlcmZvcm1hbmNlVmlld33aQQ1yZXNv",
            "dXJjZV9uYW1lGkXKQRhnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb23SQSdodHRw",
            "czovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2Fkd29yZHNCigIKJGNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52NS5zZXJ2aWNlc0IjU2hvcHBpbmdQZXJm",
            "b3JtYW5jZVZpZXdTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y1L3NlcnZpY2Vz",
            "O3NlcnZpY2VzogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjUuU2Vy",
            "dmljZXPKAiBHb29nbGVcQWRzXEdvb2dsZUFkc1xWNVxTZXJ2aWNlc+oCJEdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlY1OjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V5.Resources.ShoppingPerformanceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V5.Services.GetShoppingPerformanceViewRequest), global::Google.Ads.GoogleAds.V5.Services.GetShoppingPerformanceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for
  /// [ShoppingPerformanceViewService.GetShoppingPerformanceView][google.ads.googleads.v5.services.ShoppingPerformanceViewService.GetShoppingPerformanceView].
  /// </summary>
  public sealed partial class GetShoppingPerformanceViewRequest : pb::IMessage<GetShoppingPerformanceViewRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetShoppingPerformanceViewRequest> _parser = new pb::MessageParser<GetShoppingPerformanceViewRequest>(() => new GetShoppingPerformanceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetShoppingPerformanceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V5.Services.ShoppingPerformanceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetShoppingPerformanceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetShoppingPerformanceViewRequest(GetShoppingPerformanceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetShoppingPerformanceViewRequest Clone() {
      return new GetShoppingPerformanceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the Shopping performance view to fetch.
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
      return Equals(other as GetShoppingPerformanceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetShoppingPerformanceViewRequest other) {
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
    public void MergeFrom(GetShoppingPerformanceViewRequest other) {
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
