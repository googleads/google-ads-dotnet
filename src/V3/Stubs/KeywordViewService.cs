// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/keyword_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/keyword_view_service.proto</summary>
  public static partial class KeywordViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/keyword_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9rZXl3b3JkX3Zp",
            "ZXdfc2VydmljZS5wcm90bxIgZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2Vy",
            "dmljZXMaNGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL3Jlc291cmNlcy9rZXl3",
            "b3JkX3ZpZXcucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8a",
            "F2dvb2dsZS9hcGkvY2xpZW50LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2Jl",
            "aGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvIlwKFUdl",
            "dEtleXdvcmRWaWV3UmVxdWVzdBJDCg1yZXNvdXJjZV9uYW1lGAEgASgJQizg",
            "QQL6QSYKJGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9LZXl3b3JkVmlldzL1",
            "AQoSS2V5d29yZFZpZXdTZXJ2aWNlEsEBCg5HZXRLZXl3b3JkVmlldxI3Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLkdldEtleXdvcmRWaWV3",
            "UmVxdWVzdBouLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlcy5L",
            "ZXl3b3JkVmlldyJGgtPkkwIwEi4vdjMve3Jlc291cmNlX25hbWU9Y3VzdG9t",
            "ZXJzLyova2V5d29yZFZpZXdzLyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tQv4BCiRjb20uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjMuc2VydmljZXNCF0tleXdvcmRWaWV3U2VydmljZVByb3RvUAFa",
            "SGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dv",
            "b2dsZWFkcy92My9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5B",
            "ZHMuR29vZ2xlQWRzLlYzLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjNcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6",
            "U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.KeywordViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetKeywordViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetKeywordViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [KeywordViewService.GetKeywordView][google.ads.googleads.v3.services.KeywordViewService.GetKeywordView].
  /// </summary>
  public sealed partial class GetKeywordViewRequest : pb::IMessage<GetKeywordViewRequest> {
    private static readonly pb::MessageParser<GetKeywordViewRequest> _parser = new pb::MessageParser<GetKeywordViewRequest>(() => new GetKeywordViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetKeywordViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.KeywordViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKeywordViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKeywordViewRequest(GetKeywordViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetKeywordViewRequest Clone() {
      return new GetKeywordViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the keyword view to fetch.
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
      return Equals(other as GetKeywordViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetKeywordViewRequest other) {
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
    public void MergeFrom(GetKeywordViewRequest other) {
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
