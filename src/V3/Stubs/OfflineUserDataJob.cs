// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/offline_user_data_job.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/offline_user_data_job.proto</summary>
  public static partial class OfflineUserDataJobReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/offline_user_data_job.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OfflineUserDataJobReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvb2ZmbGluZV91",
            "c2VyX2RhdGFfam9iLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52My5y",
            "ZXNvdXJjZXMaNmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL2NvbW1vbi9vZmZs",
            "aW5lX3VzZXJfZGF0YS5wcm90bxpIZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMv",
            "ZW51bXMvb2ZmbGluZV91c2VyX2RhdGFfam9iX2ZhaWx1cmVfcmVhc29uLnBy",
            "b3RvGkBnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9vZmZsaW5lX3Vz",
            "ZXJfZGF0YV9qb2Jfc3RhdHVzLnByb3RvGj5nb29nbGUvYWRzL2dvb2dsZWFk",
            "cy92My9lbnVtcy9vZmZsaW5lX3VzZXJfZGF0YV9qb2JfdHlwZS5wcm90bxof",
            "Z29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9y",
            "ZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnByb3Rv",
            "Ghxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIuAGChJPZmZsaW5lVXNl",
            "ckRhdGFKb2ISSgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIz4EEF+kEtCitnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vT2ZmbGluZVVzZXJEYXRhSm9iEiwKAmlk",
            "GAIgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWVCA+BBAxI1Cgtl",
            "eHRlcm5hbF9pZBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVl",
            "QgPgQQMSYwoEdHlwZRgEIAEoDjJQLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LmVudW1zLk9mZmxpbmVVc2VyRGF0YUpvYlR5cGVFbnVtLk9mZmxpbmVVc2Vy",
            "RGF0YUpvYlR5cGVCA+BBAxJpCgZzdGF0dXMYBSABKA4yVC5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5lbnVtcy5PZmZsaW5lVXNlckRhdGFKb2JTdGF0dXNF",
            "bnVtLk9mZmxpbmVVc2VyRGF0YUpvYlN0YXR1c0ID4EEDEn8KDmZhaWx1cmVf",
            "cmVhc29uGAYgASgOMmIuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMu",
            "T2ZmbGluZVVzZXJEYXRhSm9iRmFpbHVyZVJlYXNvbkVudW0uT2ZmbGluZVVz",
            "ZXJEYXRhSm9iRmFpbHVyZVJlYXNvbkID4EEDEm8KIWN1c3RvbWVyX21hdGNo",
            "X3VzZXJfbGlzdF9tZXRhZGF0YRgHIAEoCzI9Lmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYzLmNvbW1vbi5DdXN0b21lck1hdGNoVXNlckxpc3RNZXRhZGF0YUID",
            "4EEDSAASVwoUc3RvcmVfc2FsZXNfbWV0YWRhdGEYCCABKAsyMi5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52My5jb21tb24uU3RvcmVTYWxlc01ldGFkYXRhQgPg",
            "QQNIADpy6kFvCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vT2ZmbGluZVVz",
            "ZXJEYXRhSm9iEkBjdXN0b21lcnMve2N1c3RvbWVyfS9vZmZsaW5lVXNlckRh",
            "dGFKb2JzL3tvZmZsaW5lX3VzZXJfZGF0YV9qb2J9QgoKCG1ldGFkYXRhQoQC",
            "CiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVzb3VyY2VzQhdPZmZs",
            "aW5lVXNlckRhdGFKb2JQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3VyY2VzO3Jl",
            "c291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLlJlc291",
            "cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFJlc291cmNlc+oCJUdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Common.OfflineUserDataReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobFailureReasonReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.OfflineUserDataJob), global::Google.Ads.GoogleAds.V3.Resources.OfflineUserDataJob.Parser, new[]{ "ResourceName", "Id", "ExternalId", "Type", "Status", "FailureReason", "CustomerMatchUserListMetadata", "StoreSalesMetadata" }, new[]{ "Metadata" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A job containing offline user data of store visitors, or user list members
  /// that will be processed asynchronously. The uploaded data isn't readable and
  /// the processing results of the job can only be read using
  /// OfflineUserDataJobService.GetOfflineUserDataJob.
  /// </summary>
  public sealed partial class OfflineUserDataJob : pb::IMessage<OfflineUserDataJob> {
    private static readonly pb::MessageParser<OfflineUserDataJob> _parser = new pb::MessageParser<OfflineUserDataJob>(() => new OfflineUserDataJob());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OfflineUserDataJob> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.OfflineUserDataJobReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob(OfflineUserDataJob other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      ExternalId = other.ExternalId;
      type_ = other.type_;
      status_ = other.status_;
      failureReason_ = other.failureReason_;
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          CustomerMatchUserListMetadata = other.CustomerMatchUserListMetadata.Clone();
          break;
        case MetadataOneofCase.StoreSalesMetadata:
          StoreSalesMetadata = other.StoreSalesMetadata.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OfflineUserDataJob Clone() {
      return new OfflineUserDataJob(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the offline user data job.
    /// Offline user data job resource names have the form:
    ///
    /// `customers/{customer_id}/offlineUserDataJobs/{offline_user_data_job_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// Output only. ID of this offline user data job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "external_id" field.</summary>
    public const int ExternalIdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_externalId_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? externalId_;
    /// <summary>
    /// Output only. User specified job ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? ExternalId {
      get { return externalId_; }
      set {
        externalId_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType type_ = 0;
    /// <summary>
    /// Output only. Type of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus status_ = 0;
    /// <summary>
    /// Output only. Status of the job.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "failure_reason" field.</summary>
    public const int FailureReasonFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason failureReason_ = 0;
    /// <summary>
    /// Output only. Reason for the processing failure, if status is FAILED.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason FailureReason {
      get { return failureReason_; }
      set {
        failureReason_ = value;
      }
    }

    /// <summary>Field number for the "customer_match_user_list_metadata" field.</summary>
    public const int CustomerMatchUserListMetadataFieldNumber = 7;
    /// <summary>
    /// Output only. Metadata for data updates to a CRM-based user list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.CustomerMatchUserListMetadata CustomerMatchUserListMetadata {
      get { return metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata ? (global::Google.Ads.GoogleAds.V3.Common.CustomerMatchUserListMetadata) metadata_ : null; }
      set {
        metadata_ = value;
        metadataCase_ = value == null ? MetadataOneofCase.None : MetadataOneofCase.CustomerMatchUserListMetadata;
      }
    }

    /// <summary>Field number for the "store_sales_metadata" field.</summary>
    public const int StoreSalesMetadataFieldNumber = 8;
    /// <summary>
    /// Output only. Metadata for store sales data update.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.StoreSalesMetadata StoreSalesMetadata {
      get { return metadataCase_ == MetadataOneofCase.StoreSalesMetadata ? (global::Google.Ads.GoogleAds.V3.Common.StoreSalesMetadata) metadata_ : null; }
      set {
        metadata_ = value;
        metadataCase_ = value == null ? MetadataOneofCase.None : MetadataOneofCase.StoreSalesMetadata;
      }
    }

    private object metadata_;
    /// <summary>Enum of possible cases for the "metadata" oneof.</summary>
    public enum MetadataOneofCase {
      None = 0,
      CustomerMatchUserListMetadata = 7,
      StoreSalesMetadata = 8,
    }
    private MetadataOneofCase metadataCase_ = MetadataOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MetadataOneofCase MetadataCase {
      get { return metadataCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMetadata() {
      metadataCase_ = MetadataOneofCase.None;
      metadata_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OfflineUserDataJob);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OfflineUserDataJob other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (ExternalId != other.ExternalId) return false;
      if (Type != other.Type) return false;
      if (Status != other.Status) return false;
      if (FailureReason != other.FailureReason) return false;
      if (!object.Equals(CustomerMatchUserListMetadata, other.CustomerMatchUserListMetadata)) return false;
      if (!object.Equals(StoreSalesMetadata, other.StoreSalesMetadata)) return false;
      if (MetadataCase != other.MetadataCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (externalId_ != null) hash ^= ExternalId.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
      if (FailureReason != 0) hash ^= FailureReason.GetHashCode();
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) hash ^= CustomerMatchUserListMetadata.GetHashCode();
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) hash ^= StoreSalesMetadata.GetHashCode();
      hash ^= (int) metadataCase_;
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
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (externalId_ != null) {
        _single_externalId_codec.WriteTagAndValue(output, ExternalId);
      }
      if (Type != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (Status != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (FailureReason != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) FailureReason);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        output.WriteRawTag(58);
        output.WriteMessage(CustomerMatchUserListMetadata);
      }
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
        output.WriteRawTag(66);
        output.WriteMessage(StoreSalesMetadata);
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
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (externalId_ != null) {
        size += _single_externalId_codec.CalculateSizeWithTag(ExternalId);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (FailureReason != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FailureReason);
      }
      if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomerMatchUserListMetadata);
      }
      if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(StoreSalesMetadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OfflineUserDataJob other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.externalId_ != null) {
        if (externalId_ == null || other.ExternalId != 0L) {
          ExternalId = other.ExternalId;
        }
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Status != 0) {
        Status = other.Status;
      }
      if (other.FailureReason != 0) {
        FailureReason = other.FailureReason;
      }
      switch (other.MetadataCase) {
        case MetadataOneofCase.CustomerMatchUserListMetadata:
          if (CustomerMatchUserListMetadata == null) {
            CustomerMatchUserListMetadata = new global::Google.Ads.GoogleAds.V3.Common.CustomerMatchUserListMetadata();
          }
          CustomerMatchUserListMetadata.MergeFrom(other.CustomerMatchUserListMetadata);
          break;
        case MetadataOneofCase.StoreSalesMetadata:
          if (StoreSalesMetadata == null) {
            StoreSalesMetadata = new global::Google.Ads.GoogleAds.V3.Common.StoreSalesMetadata();
          }
          StoreSalesMetadata.MergeFrom(other.StoreSalesMetadata);
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
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 26: {
            long? value = _single_externalId_codec.Read(input);
            if (externalId_ == null || value != 0L) {
              ExternalId = value;
            }
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobTypeEnum.Types.OfflineUserDataJobType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobStatusEnum.Types.OfflineUserDataJobStatus) input.ReadEnum();
            break;
          }
          case 48: {
            FailureReason = (global::Google.Ads.GoogleAds.V3.Enums.OfflineUserDataJobFailureReasonEnum.Types.OfflineUserDataJobFailureReason) input.ReadEnum();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V3.Common.CustomerMatchUserListMetadata subBuilder = new global::Google.Ads.GoogleAds.V3.Common.CustomerMatchUserListMetadata();
            if (metadataCase_ == MetadataOneofCase.CustomerMatchUserListMetadata) {
              subBuilder.MergeFrom(CustomerMatchUserListMetadata);
            }
            input.ReadMessage(subBuilder);
            CustomerMatchUserListMetadata = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V3.Common.StoreSalesMetadata subBuilder = new global::Google.Ads.GoogleAds.V3.Common.StoreSalesMetadata();
            if (metadataCase_ == MetadataOneofCase.StoreSalesMetadata) {
              subBuilder.MergeFrom(StoreSalesMetadata);
            }
            input.ReadMessage(subBuilder);
            StoreSalesMetadata = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
