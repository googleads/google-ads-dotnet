// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/services/customer_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/services/customer_service.proto</summary>
  public static partial class CustomerServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/services/customer_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9zZXJ2aWNlcy9jdXN0b21lcl9z",
            "ZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNl",
            "cxowZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjAvcmVzb3VyY2VzL2N1c3RvbWVy",
            "LnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIisKEkdldEN1",
            "c3RvbWVyUmVxdWVzdBIVCg1yZXNvdXJjZV9uYW1lGAEgASgJMq0BCg9DdXN0",
            "b21lclNlcnZpY2USmQEKC0dldEN1c3RvbWVyEjQuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjAuc2VydmljZXMuR2V0Q3VzdG9tZXJSZXF1ZXN0GisuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjAucmVzb3VyY2VzLkN1c3RvbWVyIieC0+STAiES",
            "Hy92MC97cmVzb3VyY2VfbmFtZT1jdXN0b21lcnMvKn1C1AEKJGNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52MC5zZXJ2aWNlc0IUQ3VzdG9tZXJTZXJ2aWNl",
            "UHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YwL3NlcnZpY2VzO3NlcnZpY2VzogIDR0FBqgIg",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuU2VydmljZXPKAiBHb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMFxTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V0.Resources.CustomerReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Services.GetCustomerRequest), global::Google.Ads.GoogleAds.V0.Services.GetCustomerRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CustomerService.GetCustomer][google.ads.googleads.v0.services.CustomerService.GetCustomer].
  /// </summary>
  public sealed partial class GetCustomerRequest : pb::IMessage<GetCustomerRequest> {
    private static readonly pb::MessageParser<GetCustomerRequest> _parser = new pb::MessageParser<GetCustomerRequest>(() => new GetCustomerRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCustomerRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Services.CustomerServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerRequest(GetCustomerRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCustomerRequest Clone() {
      return new GetCustomerRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the customer to fetch.
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
      return Equals(other as GetCustomerRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCustomerRequest other) {
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
    public void MergeFrom(GetCustomerRequest other) {
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
