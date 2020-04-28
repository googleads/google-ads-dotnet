// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/customer_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/customer_label.proto</summary>
  public static partial class CustomerLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/customer_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "bGFiZWwucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNl",
            "cxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqACCg1DdXN0b21l",
            "ckxhYmVsEkUKDXJlc291cmNlX25hbWUYASABKAlCLuBBBfpBKAomZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyTGFiZWwSMwoIY3VzdG9tZXIY",
            "AiABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxIwCgVs",
            "YWJlbBgDIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EED",
            "OmHqQV4KJmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lckxhYmVs",
            "EjRjdXN0b21lcnMve2N1c3RvbWVyfS9jdXN0b21lckxhYmVscy97Y3VzdG9t",
            "ZXJfbGFiZWx9Qv8BCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVz",
            "b3VyY2VzQhJDdXN0b21lckxhYmVsUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YzL3Jlc291",
            "cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "My5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWM1xSZXNvdXJj",
            "ZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6UmVzb3VyY2VzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CustomerLabel), global::Google.Ads.GoogleAds.V3.Resources.CustomerLabel.Parser, new[]{ "ResourceName", "Customer", "Label" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a relationship between a customer and a label. This customer may
  /// not have access to all the labels attached to it. Additional CustomerLabels
  /// may be returned by increasing permissions with login-customer-id.
  /// </summary>
  public sealed partial class CustomerLabel : pb::IMessage<CustomerLabel> {
    private static readonly pb::MessageParser<CustomerLabel> _parser = new pb::MessageParser<CustomerLabel>(() => new CustomerLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CustomerLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerLabel(CustomerLabel other) : this() {
      resourceName_ = other.resourceName_;
      Customer = other.Customer;
      Label = other.Label;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerLabel Clone() {
      return new CustomerLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// Customer label resource names have the form:
    /// `customers/{customer_id}/customerLabels/{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer" field.</summary>
    public const int CustomerFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_customer_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string customer_;
    /// <summary>
    /// Output only. The resource name of the customer to which the label is attached.
    /// Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Customer {
      get { return customer_; }
      set {
        customer_ = value;
      }
    }


    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_label_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string label_;
    /// <summary>
    /// Output only. The resource name of the label assigned to the customer.
    ///
    /// Note: the Customer ID portion of the label resource name is not
    /// validated when creating a new CustomerLabel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Customer != other.Customer) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (customer_ != null) hash ^= Customer.GetHashCode();
      if (label_ != null) hash ^= Label.GetHashCode();
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
      if (customer_ != null) {
        _single_customer_codec.WriteTagAndValue(output, Customer);
      }
      if (label_ != null) {
        _single_label_codec.WriteTagAndValue(output, Label);
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
      if (customer_ != null) {
        size += _single_customer_codec.CalculateSizeWithTag(Customer);
      }
      if (label_ != null) {
        size += _single_label_codec.CalculateSizeWithTag(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.customer_ != null) {
        if (customer_ == null || other.Customer != "") {
          Customer = other.Customer;
        }
      }
      if (other.label_ != null) {
        if (label_ == null || other.Label != "") {
          Label = other.Label;
        }
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
          case 18: {
            string value = _single_customer_codec.Read(input);
            if (customer_ == null || value != "") {
              Customer = value;
            }
            break;
          }
          case 26: {
            string value = _single_label_codec.Read(input);
            if (label_ == null || value != "") {
              Label = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
