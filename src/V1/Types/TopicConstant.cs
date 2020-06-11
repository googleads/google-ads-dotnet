// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/topic_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/topic_constant.proto</summary>
  public static partial class TopicConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/topic_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TopicConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvdG9waWNfY29u",
            "c3RhbnQucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNl",
            "cxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIvACCg1Ub3BpY0Nv",
            "bnN0YW50EkUKDXJlc291cmNlX25hbWUYASABKAlCLuBBA/pBKAomZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL1RvcGljQ29uc3RhbnQSLAoCaWQYAiABKAsy",
            "Gy5nb29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDEmsKFXRvcGljX2Nv",
            "bnN0YW50X3BhcmVudBgDIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdW",
            "YWx1ZUIu4EED+kEoCiZnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vVG9waWND",
            "b25zdGFudBIvCgRwYXRoGAQgAygLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmlu",
            "Z1ZhbHVlQgPgQQM6TOpBSQomZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1Rv",
            "cGljQ29uc3RhbnQSH3RvcGljQ29uc3RhbnRzL3t0b3BpY19jb25zdGFudH1C",
            "/wEKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5yZXNvdXJjZXNCElRv",
            "cGljQ29uc3RhbnRQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEvcmVzb3VyY2VzO3Jlc291",
            "cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYxLlJlc291cmNl",
            "c8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXFJlc291cmNlc+oCJUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.TopicConstant), global::Google.Ads.GoogleAds.V1.Resources.TopicConstant.Parser, new[]{ "ResourceName", "Id", "TopicConstantParent", "Path" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Use topics to target or exclude placements in the Google Display Network
  /// based on the category into which the placement falls (for example,
  /// "Pets &amp; Animals/Pets/Dogs").
  /// </summary>
  public sealed partial class TopicConstant : pb::IMessage<TopicConstant> {
    private static readonly pb::MessageParser<TopicConstant> _parser = new pb::MessageParser<TopicConstant>(() => new TopicConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TopicConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.TopicConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopicConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopicConstant(TopicConstant other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      TopicConstantParent = other.TopicConstantParent;
      path_ = other.path_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TopicConstant Clone() {
      return new TopicConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the topic constant.
    /// topic constant resource names have the form:
    ///
    /// `topicConstants/{topic_id}`
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
    /// Output only. The ID of the topic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "topic_constant_parent" field.</summary>
    public const int TopicConstantParentFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_topicConstantParent_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string topicConstantParent_;
    /// <summary>
    /// Output only. Resource name of parent of the topic constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TopicConstantParent {
      get { return topicConstantParent_; }
      set {
        topicConstantParent_ = value;
      }
    }


    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_path_codec
        = pb::FieldCodec.ForClassWrapper<string>(34);
    private readonly pbc::RepeatedField<string> path_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The category to target or exclude. Each subsequent element in the array
    /// describes a more specific sub-category. For example,
    /// {"Pets &amp; Animals", "Pets", "Dogs"} represents the
    /// "Pets &amp; Animals/Pets/Dogs" category. List of available topic categories at
    /// https://developers.google.com/adwords/api/docs/appendix/verticals
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Path {
      get { return path_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TopicConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TopicConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (TopicConstantParent != other.TopicConstantParent) return false;
      if(!path_.Equals(other.path_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (topicConstantParent_ != null) hash ^= TopicConstantParent.GetHashCode();
      hash ^= path_.GetHashCode();
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
      if (topicConstantParent_ != null) {
        _single_topicConstantParent_codec.WriteTagAndValue(output, TopicConstantParent);
      }
      path_.WriteTo(output, _repeated_path_codec);
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
      if (topicConstantParent_ != null) {
        size += _single_topicConstantParent_codec.CalculateSizeWithTag(TopicConstantParent);
      }
      size += path_.CalculateSize(_repeated_path_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TopicConstant other) {
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
      if (other.topicConstantParent_ != null) {
        if (topicConstantParent_ == null || other.TopicConstantParent != "") {
          TopicConstantParent = other.TopicConstantParent;
        }
      }
      path_.Add(other.path_);
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
            string value = _single_topicConstantParent_codec.Read(input);
            if (topicConstantParent_ == null || value != "") {
              TopicConstantParent = value;
            }
            break;
          }
          case 34: {
            path_.AddEntriesFrom(input, _repeated_path_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
