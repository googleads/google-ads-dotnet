// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/shared_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/shared_set.proto</summary>
  public static partial class SharedSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/shared_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvc2hhcmVkX3Nl",
            "dC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIucmVzb3VyY2VzGjVn",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9zaGFyZWRfc2V0X3N0YXR1",
            "cy5wcm90bxozZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIvZW51bXMvc2hhcmVk",
            "X3NldF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnBy",
            "b3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29nbGUvcHJvdG9i",
            "dWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8ingQKCVNoYXJlZFNldBJBCg1yZXNvdXJjZV9uYW1lGAEgASgJQirgQQX6",
            "QSQKImdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9TaGFyZWRTZXQSLAoCaWQY",
            "AiABKAsyGy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDElEKBHR5",
            "cGUYAyABKA4yPi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtcy5TaGFy",
            "ZWRTZXRUeXBlRW51bS5TaGFyZWRTZXRUeXBlQgPgQQUSKgoEbmFtZRgEIAEo",
            "CzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRJXCgZzdGF0dXMYBSAB",
            "KA4yQi5nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtcy5TaGFyZWRTZXRT",
            "dGF0dXNFbnVtLlNoYXJlZFNldFN0YXR1c0ID4EEDEjYKDG1lbWJlcl9jb3Vu",
            "dBgGIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQMSOQoP",
            "cmVmZXJlbmNlX2NvdW50GAcgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0",
            "VmFsdWVCA+BBAzpV6kFSCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU2hh",
            "cmVkU2V0EixjdXN0b21lcnMve2N1c3RvbWVyfS9zaGFyZWRTZXRzL3tzaGFy",
            "ZWRfc2V0fUL7AQolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291",
            "cmNlc0IOU2hhcmVkU2V0UHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2Vu",
            "cHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMi5SZXNv",
            "dXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxSZXNvdXJjZXPqAiVH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMjo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.SharedSet), global::Google.Ads.GoogleAds.V2.Resources.SharedSet.Parser, new[]{ "ResourceName", "Id", "Type", "Name", "Status", "MemberCount", "ReferenceCount" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// SharedSets are used for sharing criterion exclusions across multiple
  /// campaigns.
  /// </summary>
  public sealed partial class SharedSet : pb::IMessage<SharedSet> {
    private static readonly pb::MessageParser<SharedSet> _parser = new pb::MessageParser<SharedSet>(() => new SharedSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SharedSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.SharedSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedSet(SharedSet other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      type_ = other.type_;
      Name = other.Name;
      status_ = other.status_;
      MemberCount = other.MemberCount;
      ReferenceCount = other.ReferenceCount;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedSet Clone() {
      return new SharedSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the shared set.
    /// Shared set resource names have the form:
    ///
    /// `customers/{customer_id}/sharedSets/{shared_set_id}`
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
    /// Output only. The ID of this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType type_ = global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified;
    /// <summary>
    /// Immutable. The type of this shared set: each shared set holds only a single kind
    /// of resource. Required. Immutable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string name_;
    /// <summary>
    /// The name of this shared set. Required.
    /// Shared Sets must have names that are unique among active shared sets of
    /// the same type.
    /// The length of this string should be between 1 and 255 UTF-8 bytes,
    /// inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus status_ = global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified;
    /// <summary>
    /// Output only. The status of this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "member_count" field.</summary>
    public const int MemberCountFieldNumber = 6;
    private static readonly pb::FieldCodec<long?> _single_memberCount_codec = pb::FieldCodec.ForStructWrapper<long>(50);
    private long? memberCount_;
    /// <summary>
    /// Output only. The number of shared criteria within this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? MemberCount {
      get { return memberCount_; }
      set {
        memberCount_ = value;
      }
    }


    /// <summary>Field number for the "reference_count" field.</summary>
    public const int ReferenceCountFieldNumber = 7;
    private static readonly pb::FieldCodec<long?> _single_referenceCount_codec = pb::FieldCodec.ForStructWrapper<long>(58);
    private long? referenceCount_;
    /// <summary>
    /// Output only. The number of campaigns associated with this shared set. Read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? ReferenceCount {
      get { return referenceCount_; }
      set {
        referenceCount_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SharedSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SharedSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (Name != other.Name) return false;
      if (Status != other.Status) return false;
      if (MemberCount != other.MemberCount) return false;
      if (ReferenceCount != other.ReferenceCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) hash ^= Type.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) hash ^= Status.GetHashCode();
      if (memberCount_ != null) hash ^= MemberCount.GetHashCode();
      if (referenceCount_ != null) hash ^= ReferenceCount.GetHashCode();
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
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (memberCount_ != null) {
        _single_memberCount_codec.WriteTagAndValue(output, MemberCount);
      }
      if (referenceCount_ != null) {
        _single_referenceCount_codec.WriteTagAndValue(output, ReferenceCount);
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
      if (Type != global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (Status != global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (memberCount_ != null) {
        size += _single_memberCount_codec.CalculateSizeWithTag(MemberCount);
      }
      if (referenceCount_ != null) {
        size += _single_referenceCount_codec.CalculateSizeWithTag(ReferenceCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SharedSet other) {
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
      if (other.Type != global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType.Unspecified) {
        Type = other.Type;
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.Status != global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.memberCount_ != null) {
        if (memberCount_ == null || other.MemberCount != 0L) {
          MemberCount = other.MemberCount;
        }
      }
      if (other.referenceCount_ != null) {
        if (referenceCount_ == null || other.ReferenceCount != 0L) {
          ReferenceCount = other.ReferenceCount;
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
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V2.Enums.SharedSetTypeEnum.Types.SharedSetType) input.ReadEnum();
            break;
          }
          case 34: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V2.Enums.SharedSetStatusEnum.Types.SharedSetStatus) input.ReadEnum();
            break;
          }
          case 50: {
            long? value = _single_memberCount_codec.Read(input);
            if (memberCount_ == null || value != 0L) {
              MemberCount = value;
            }
            break;
          }
          case 58: {
            long? value = _single_referenceCount_codec.Read(input);
            if (referenceCount_ == null || value != 0L) {
              ReferenceCount = value;
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
