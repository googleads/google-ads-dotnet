// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_label_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/ad_group_label_service.proto</summary>
  public static partial class AdGroupLabelServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/ad_group_label_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupLabelServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9hZF9ncm91cF9s",
            "YWJlbF9zZXJ2aWNlLnByb3RvEiBnb29nbGUuYWRzLmdvb2dsZWFkcy52My5z",
            "ZXJ2aWNlcxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzL2Fk",
            "X2dyb3VwX2xhYmVsLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnBy",
            "b3RvGhdnb29nbGUvYXBpL2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVs",
            "ZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxoX",
            "Z29vZ2xlL3JwYy9zdGF0dXMucHJvdG8iXgoWR2V0QWRHcm91cExhYmVsUmVx",
            "dWVzdBJECg1yZXNvdXJjZV9uYW1lGAEgASgJQi3gQQL6QScKJWdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwTGFiZWwiuAEKGk11dGF0ZUFkR3Jv",
            "dXBMYWJlbHNSZXF1ZXN0EhgKC2N1c3RvbWVyX2lkGAEgASgJQgPgQQISUAoK",
            "b3BlcmF0aW9ucxgCIAMoCzI3Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNl",
            "cnZpY2VzLkFkR3JvdXBMYWJlbE9wZXJhdGlvbkID4EECEhcKD3BhcnRpYWxf",
            "ZmFpbHVyZRgDIAEoCBIVCg12YWxpZGF0ZV9vbmx5GAQgASgIInkKFUFkR3Jv",
            "dXBMYWJlbE9wZXJhdGlvbhJBCgZjcmVhdGUYASABKAsyLy5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5yZXNvdXJjZXMuQWRHcm91cExhYmVsSAASEAoGcmVt",
            "b3ZlGAIgASgJSABCCwoJb3BlcmF0aW9uIp0BChtNdXRhdGVBZEdyb3VwTGFi",
            "ZWxzUmVzcG9uc2USMQoVcGFydGlhbF9mYWlsdXJlX2Vycm9yGAMgASgLMhIu",
            "Z29vZ2xlLnJwYy5TdGF0dXMSSwoHcmVzdWx0cxgCIAMoCzI6Lmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLk11dGF0ZUFkR3JvdXBMYWJlbFJl",
            "c3VsdCIxChhNdXRhdGVBZEdyb3VwTGFiZWxSZXN1bHQSFQoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCTLnAwoTQWRHcm91cExhYmVsU2VydmljZRLFAQoPR2V0QWRH",
            "cm91cExhYmVsEjguZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2VydmljZXMu",
            "R2V0QWRHcm91cExhYmVsUmVxdWVzdBovLmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYzLnJlc291cmNlcy5BZEdyb3VwTGFiZWwiR4LT5JMCMRIvL3YzL3tyZXNv",
            "dXJjZV9uYW1lPWN1c3RvbWVycy8qL2FkR3JvdXBMYWJlbHMvKn3aQQ1yZXNv",
            "dXJjZV9uYW1lEuoBChNNdXRhdGVBZEdyb3VwTGFiZWxzEjwuZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjMuc2VydmljZXMuTXV0YXRlQWRHcm91cExhYmVsc1Jl",
            "cXVlc3QaPS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNlcy5NdXRh",
            "dGVBZEdyb3VwTGFiZWxzUmVzcG9uc2UiVoLT5JMCNyIyL3YzL2N1c3RvbWVy",
            "cy97Y3VzdG9tZXJfaWQ9Kn0vYWRHcm91cExhYmVsczptdXRhdGU6ASraQRZj",
            "dXN0b21lcl9pZCxvcGVyYXRpb25zGhvKQRhnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb21C/wEKJGNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5zZXJ2aWNl",
            "c0IYQWRHcm91cExhYmVsU2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcu",
            "b3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9zZXJ2",
            "aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYz",
            "LlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcU2VydmljZXPq",
            "AiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6U2VydmljZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabelReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupLabelRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsRequest.Parser, new[]{ "CustomerId", "Operations", "PartialFailure", "ValidateOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation), global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation.Parser, new[]{ "Create", "Remove" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelsResponse.Parser, new[]{ "PartialFailureError", "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [AdGroupLabelService.GetAdGroupLabel][google.ads.googleads.v3.services.AdGroupLabelService.GetAdGroupLabel].
  /// </summary>
  public sealed partial class GetAdGroupLabelRequest : pb::IMessage<GetAdGroupLabelRequest> {
    private static readonly pb::MessageParser<GetAdGroupLabelRequest> _parser = new pb::MessageParser<GetAdGroupLabelRequest>(() => new GetAdGroupLabelRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAdGroupLabelRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupLabelRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupLabelRequest(GetAdGroupLabelRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupLabelRequest Clone() {
      return new GetAdGroupLabelRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the ad group label to fetch.
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
      return Equals(other as GetAdGroupLabelRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAdGroupLabelRequest other) {
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
    public void MergeFrom(GetAdGroupLabelRequest other) {
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

  /// <summary>
  /// Request message for [AdGroupLabelService.MutateAdGroupLabels][google.ads.googleads.v3.services.AdGroupLabelService.MutateAdGroupLabels].
  /// </summary>
  public sealed partial class MutateAdGroupLabelsRequest : pb::IMessage<MutateAdGroupLabelsRequest> {
    private static readonly pb::MessageParser<MutateAdGroupLabelsRequest> _parser = new pb::MessageParser<MutateAdGroupLabelsRequest>(() => new MutateAdGroupLabelsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupLabelsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsRequest(MutateAdGroupLabelsRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      partialFailure_ = other.partialFailure_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsRequest Clone() {
      return new MutateAdGroupLabelsRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// Required. ID of the customer whose ad group labels are being modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CustomerId {
      get { return customerId_; }
      set {
        customerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "operations" field.</summary>
    public const int OperationsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation>();
    /// <summary>
    /// Required. The list of operations to perform on ad group labels.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelOperation> Operations {
      get { return operations_; }
    }

    /// <summary>Field number for the "partial_failure" field.</summary>
    public const int PartialFailureFieldNumber = 3;
    private bool partialFailure_;
    /// <summary>
    /// If true, successful operations will be carried out and invalid
    /// operations will return errors. If false, all operations will be carried
    /// out in one transaction if and only if they are all valid.
    /// Default is false.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool PartialFailure {
      get { return partialFailure_; }
      set {
        partialFailure_ = value;
      }
    }

    /// <summary>Field number for the "validate_only" field.</summary>
    public const int ValidateOnlyFieldNumber = 4;
    private bool validateOnly_;
    /// <summary>
    /// If true, the request is validated but not executed. Only errors are
    /// returned, not results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ValidateOnly {
      get { return validateOnly_; }
      set {
        validateOnly_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAdGroupLabelsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupLabelsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if(!operations_.Equals(other.operations_)) return false;
      if (PartialFailure != other.PartialFailure) return false;
      if (ValidateOnly != other.ValidateOnly) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId.Length != 0) hash ^= CustomerId.GetHashCode();
      hash ^= operations_.GetHashCode();
      if (PartialFailure != false) hash ^= PartialFailure.GetHashCode();
      if (ValidateOnly != false) hash ^= ValidateOnly.GetHashCode();
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
      if (CustomerId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(CustomerId);
      }
      operations_.WriteTo(output, _repeated_operations_codec);
      if (PartialFailure != false) {
        output.WriteRawTag(24);
        output.WriteBool(PartialFailure);
      }
      if (ValidateOnly != false) {
        output.WriteRawTag(32);
        output.WriteBool(ValidateOnly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CustomerId);
      }
      size += operations_.CalculateSize(_repeated_operations_codec);
      if (PartialFailure != false) {
        size += 1 + 1;
      }
      if (ValidateOnly != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAdGroupLabelsRequest other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId.Length != 0) {
        CustomerId = other.CustomerId;
      }
      operations_.Add(other.operations_);
      if (other.PartialFailure != false) {
        PartialFailure = other.PartialFailure;
      }
      if (other.ValidateOnly != false) {
        ValidateOnly = other.ValidateOnly;
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
            CustomerId = input.ReadString();
            break;
          }
          case 18: {
            operations_.AddEntriesFrom(input, _repeated_operations_codec);
            break;
          }
          case 24: {
            PartialFailure = input.ReadBool();
            break;
          }
          case 32: {
            ValidateOnly = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A single operation (create, remove) on an ad group label.
  /// </summary>
  public sealed partial class AdGroupLabelOperation : pb::IMessage<AdGroupLabelOperation> {
    private static readonly pb::MessageParser<AdGroupLabelOperation> _parser = new pb::MessageParser<AdGroupLabelOperation>(() => new AdGroupLabelOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupLabelOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabelOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabelOperation(AdGroupLabelOperation other) : this() {
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabelOperation Clone() {
      return new AdGroupLabelOperation(this);
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new ad group
    /// label.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    /// <summary>Field number for the "remove" field.</summary>
    public const int RemoveFieldNumber = 2;
    /// <summary>
    /// Remove operation: A resource name for the ad group label
    /// being removed, in this format:
    ///
    /// `customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Remove {
      get { return operationCase_ == OperationOneofCase.Remove ? (string) operation_ : ""; }
      set {
        operation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        operationCase_ = OperationOneofCase.Remove;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
      Remove = 2,
    }
    private OperationOneofCase operationCase_ = OperationOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OperationOneofCase OperationCase {
      get { return operationCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearOperation() {
      operationCase_ = OperationOneofCase.None;
      operation_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupLabelOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupLabelOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Create, other.Create)) return false;
      if (Remove != other.Remove) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
      if (operationCase_ == OperationOneofCase.Remove) hash ^= Remove.GetHashCode();
      hash ^= (int) operationCase_;
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
      if (operationCase_ == OperationOneofCase.Create) {
        output.WriteRawTag(10);
        output.WriteMessage(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        output.WriteRawTag(18);
        output.WriteString(Remove);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (operationCase_ == OperationOneofCase.Create) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Create);
      }
      if (operationCase_ == OperationOneofCase.Remove) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Remove);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupLabelOperation other) {
      if (other == null) {
        return;
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel();
          }
          Create.MergeFrom(other.Create);
          break;
        case OperationOneofCase.Remove:
          Remove = other.Remove;
          break;
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
            global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel subBuilder = new global::Google.Ads.GoogleAds.V3.Resources.AdGroupLabel();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
          case 18: {
            Remove = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for an ad group labels mutate.
  /// </summary>
  public sealed partial class MutateAdGroupLabelsResponse : pb::IMessage<MutateAdGroupLabelsResponse> {
    private static readonly pb::MessageParser<MutateAdGroupLabelsResponse> _parser = new pb::MessageParser<MutateAdGroupLabelsResponse>(() => new MutateAdGroupLabelsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupLabelsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsResponse(MutateAdGroupLabelsResponse other) : this() {
      partialFailureError_ = other.partialFailureError_ != null ? other.partialFailureError_.Clone() : null;
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelsResponse Clone() {
      return new MutateAdGroupLabelsResponse(this);
    }

    /// <summary>Field number for the "partial_failure_error" field.</summary>
    public const int PartialFailureErrorFieldNumber = 3;
    private global::Google.Rpc.Status partialFailureError_;
    /// <summary>
    /// Errors that pertain to operation failures in the partial failure mode.
    /// Returned only when partial_failure = true and all errors occur inside the
    /// operations. If any errors occur outside the operations (e.g. auth errors),
    /// we return an RPC level error.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Rpc.Status PartialFailureError {
      get { return partialFailureError_; }
      set {
        partialFailureError_ = value;
      }
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupLabelResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateAdGroupLabelsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupLabelsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PartialFailureError, other.PartialFailureError)) return false;
      if(!results_.Equals(other.results_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (partialFailureError_ != null) hash ^= PartialFailureError.GetHashCode();
      hash ^= results_.GetHashCode();
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
      results_.WriteTo(output, _repeated_results_codec);
      if (partialFailureError_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(PartialFailureError);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (partialFailureError_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PartialFailureError);
      }
      size += results_.CalculateSize(_repeated_results_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MutateAdGroupLabelsResponse other) {
      if (other == null) {
        return;
      }
      if (other.partialFailureError_ != null) {
        if (partialFailureError_ == null) {
          PartialFailureError = new global::Google.Rpc.Status();
        }
        PartialFailureError.MergeFrom(other.PartialFailureError);
      }
      results_.Add(other.results_);
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
          case 18: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
          case 26: {
            if (partialFailureError_ == null) {
              PartialFailureError = new global::Google.Rpc.Status();
            }
            input.ReadMessage(PartialFailureError);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The result for an ad group label mutate.
  /// </summary>
  public sealed partial class MutateAdGroupLabelResult : pb::IMessage<MutateAdGroupLabelResult> {
    private static readonly pb::MessageParser<MutateAdGroupLabelResult> _parser = new pb::MessageParser<MutateAdGroupLabelResult>(() => new MutateAdGroupLabelResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateAdGroupLabelResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupLabelServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelResult(MutateAdGroupLabelResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateAdGroupLabelResult Clone() {
      return new MutateAdGroupLabelResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Returned for successful operations.
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
      return Equals(other as MutateAdGroupLabelResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateAdGroupLabelResult other) {
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
    public void MergeFrom(MutateAdGroupLabelResult other) {
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
