// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/media_file_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/services/media_file_service.proto</summary>
  public static partial class MediaFileServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/services/media_file_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaFileServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjlnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9zZXJ2aWNlcy9tZWRpYV9maWxl",
            "X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnNlcnZp",
            "Y2VzGjJnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvbWVkaWFf",
            "ZmlsZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90bxoXZ29v",
            "Z2xlL3JwYy9zdGF0dXMucHJvdG8aF2dvb2dsZS9hcGkvY2xpZW50LnByb3Rv",
            "IiwKE0dldE1lZGlhRmlsZVJlcXVlc3QSFQoNcmVzb3VyY2VfbmFtZRgBIAEo",
            "CSKoAQoXTXV0YXRlTWVkaWFGaWxlc1JlcXVlc3QSEwoLY3VzdG9tZXJfaWQY",
            "ASABKAkSSAoKb3BlcmF0aW9ucxgCIAMoCzI0Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYyLnNlcnZpY2VzLk1lZGlhRmlsZU9wZXJhdGlvbhIXCg9wYXJ0aWFs",
            "X2ZhaWx1cmUYAyABKAgSFQoNdmFsaWRhdGVfb25seRgEIAEoCCJhChJNZWRp",
            "YUZpbGVPcGVyYXRpb24SPgoGY3JlYXRlGAEgASgLMiwuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjIucmVzb3VyY2VzLk1lZGlhRmlsZUgAQgsKCW9wZXJhdGlv",
            "biKXAQoYTXV0YXRlTWVkaWFGaWxlc1Jlc3BvbnNlEjEKFXBhcnRpYWxfZmFp",
            "bHVyZV9lcnJvchgDIAEoCzISLmdvb2dsZS5ycGMuU3RhdHVzEkgKB3Jlc3Vs",
            "dHMYAiADKAsyNy5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5zZXJ2aWNlcy5N",
            "dXRhdGVNZWRpYUZpbGVSZXN1bHQiLgoVTXV0YXRlTWVkaWFGaWxlUmVzdWx0",
            "EhUKDXJlc291cmNlX25hbWUYASABKAkyowMKEE1lZGlhRmlsZVNlcnZpY2US",
            "qQEKDEdldE1lZGlhRmlsZRI1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnNl",
            "cnZpY2VzLkdldE1lZGlhRmlsZVJlcXVlc3QaLC5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5yZXNvdXJjZXMuTWVkaWFGaWxlIjSC0+STAi4SLC92Mi97cmVz",
            "b3VyY2VfbmFtZT1jdXN0b21lcnMvKi9tZWRpYUZpbGVzLyp9EsUBChBNdXRh",
            "dGVNZWRpYUZpbGVzEjkuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuc2Vydmlj",
            "ZXMuTXV0YXRlTWVkaWFGaWxlc1JlcXVlc3QaOi5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52Mi5zZXJ2aWNlcy5NdXRhdGVNZWRpYUZpbGVzUmVzcG9uc2UiOoLT",
            "5JMCNCIvL3YyL2N1c3RvbWVycy97Y3VzdG9tZXJfaWQ9Kn0vbWVkaWFGaWxl",
            "czptdXRhdGU6ASoaG8pBGGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbUL8AQok",
            "Y29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnNlcnZpY2VzQhVNZWRpYUZp",
            "bGVTZXJ2aWNlUHJvdG9QAVpIZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL3NlcnZpY2VzO3NlcnZpY2Vz",
            "ogIDR0FBqgIgR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuU2VydmljZXPKAiBH",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMlxTZXJ2aWNlc+oCJEdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYyOjpTZXJ2aWNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Resources.MediaFileReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Rpc.StatusReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.GetMediaFileRequest), global::Google.Ads.GoogleAds.V2.Services.GetMediaFileRequest.Parser, new[]{ "ResourceName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateMediaFilesRequest), global::Google.Ads.GoogleAds.V2.Services.MutateMediaFilesRequest.Parser, new[]{ "CustomerId", "Operations", "PartialFailure", "ValidateOnly" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation), global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation.Parser, new[]{ "Create" }, new[]{ "Operation" }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateMediaFilesResponse), global::Google.Ads.GoogleAds.V2.Services.MutateMediaFilesResponse.Parser, new[]{ "PartialFailureError", "Results" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult), global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [MediaFileService.GetMediaFile][google.ads.googleads.v2.services.MediaFileService.GetMediaFile]
  /// </summary>
  public sealed partial class GetMediaFileRequest : pb::IMessage<GetMediaFileRequest> {
    private static readonly pb::MessageParser<GetMediaFileRequest> _parser = new pb::MessageParser<GetMediaFileRequest>(() => new GetMediaFileRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMediaFileRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.MediaFileServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMediaFileRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMediaFileRequest(GetMediaFileRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMediaFileRequest Clone() {
      return new GetMediaFileRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the media file to fetch.
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
      return Equals(other as GetMediaFileRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMediaFileRequest other) {
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
    public void MergeFrom(GetMediaFileRequest other) {
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
  /// Request message for [MediaFileService.MutateMediaFiles][google.ads.googleads.v2.services.MediaFileService.MutateMediaFiles]
  /// </summary>
  public sealed partial class MutateMediaFilesRequest : pb::IMessage<MutateMediaFilesRequest> {
    private static readonly pb::MessageParser<MutateMediaFilesRequest> _parser = new pb::MessageParser<MutateMediaFilesRequest>(() => new MutateMediaFilesRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateMediaFilesRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.MediaFileServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesRequest(MutateMediaFilesRequest other) : this() {
      customerId_ = other.customerId_;
      operations_ = other.operations_.Clone();
      partialFailure_ = other.partialFailure_;
      validateOnly_ = other.validateOnly_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesRequest Clone() {
      return new MutateMediaFilesRequest(this);
    }

    /// <summary>Field number for the "customer_id" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private string customerId_ = "";
    /// <summary>
    /// The ID of the customer whose media files are being modified.
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
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation> _repeated_operations_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation> operations_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation>();
    /// <summary>
    /// The list of operations to perform on individual media file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MediaFileOperation> Operations {
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
      return Equals(other as MutateMediaFilesRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateMediaFilesRequest other) {
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
    public void MergeFrom(MutateMediaFilesRequest other) {
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
  /// A single operation to create media file.
  /// </summary>
  public sealed partial class MediaFileOperation : pb::IMessage<MediaFileOperation> {
    private static readonly pb::MessageParser<MediaFileOperation> _parser = new pb::MessageParser<MediaFileOperation>(() => new MediaFileOperation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaFileOperation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.MediaFileServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileOperation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileOperation(MediaFileOperation other) : this() {
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          Create = other.Create.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileOperation Clone() {
      return new MediaFileOperation(this);
    }

    /// <summary>Field number for the "create" field.</summary>
    public const int CreateFieldNumber = 1;
    /// <summary>
    /// Create operation: No resource name is expected for the new media file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Resources.MediaFile Create {
      get { return operationCase_ == OperationOneofCase.Create ? (global::Google.Ads.GoogleAds.V2.Resources.MediaFile) operation_ : null; }
      set {
        operation_ = value;
        operationCase_ = value == null ? OperationOneofCase.None : OperationOneofCase.Create;
      }
    }

    private object operation_;
    /// <summary>Enum of possible cases for the "operation" oneof.</summary>
    public enum OperationOneofCase {
      None = 0,
      Create = 1,
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
      return Equals(other as MediaFileOperation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaFileOperation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Create, other.Create)) return false;
      if (OperationCase != other.OperationCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (operationCase_ == OperationOneofCase.Create) hash ^= Create.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MediaFileOperation other) {
      if (other == null) {
        return;
      }
      switch (other.OperationCase) {
        case OperationOneofCase.Create:
          if (Create == null) {
            Create = new global::Google.Ads.GoogleAds.V2.Resources.MediaFile();
          }
          Create.MergeFrom(other.Create);
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
            global::Google.Ads.GoogleAds.V2.Resources.MediaFile subBuilder = new global::Google.Ads.GoogleAds.V2.Resources.MediaFile();
            if (operationCase_ == OperationOneofCase.Create) {
              subBuilder.MergeFrom(Create);
            }
            input.ReadMessage(subBuilder);
            Create = subBuilder;
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Response message for a media file mutate.
  /// </summary>
  public sealed partial class MutateMediaFilesResponse : pb::IMessage<MutateMediaFilesResponse> {
    private static readonly pb::MessageParser<MutateMediaFilesResponse> _parser = new pb::MessageParser<MutateMediaFilesResponse>(() => new MutateMediaFilesResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateMediaFilesResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.MediaFileServiceReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesResponse(MutateMediaFilesResponse other) : this() {
      partialFailureError_ = other.partialFailureError_ != null ? other.partialFailureError_.Clone() : null;
      results_ = other.results_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFilesResponse Clone() {
      return new MutateMediaFilesResponse(this);
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
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult> _repeated_results_codec
        = pb::FieldCodec.ForMessage(18, global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult> results_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult>();
    /// <summary>
    /// All results for the mutate.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V2.Services.MutateMediaFileResult> Results {
      get { return results_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MutateMediaFilesResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateMediaFilesResponse other) {
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
    public void MergeFrom(MutateMediaFilesResponse other) {
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
  /// The result for the media file mutate.
  /// </summary>
  public sealed partial class MutateMediaFileResult : pb::IMessage<MutateMediaFileResult> {
    private static readonly pb::MessageParser<MutateMediaFileResult> _parser = new pb::MessageParser<MutateMediaFileResult>(() => new MutateMediaFileResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MutateMediaFileResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Services.MediaFileServiceReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFileResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFileResult(MutateMediaFileResult other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MutateMediaFileResult Clone() {
      return new MutateMediaFileResult(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name returned for successful operations.
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
      return Equals(other as MutateMediaFileResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MutateMediaFileResult other) {
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
    public void MergeFrom(MutateMediaFileResult other) {
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
