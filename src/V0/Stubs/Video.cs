// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/resources/video.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/resources/video.proto</summary>
  public static partial class VideoReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/resources/video.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92MC9yZXNvdXJjZXMvdmlkZW8ucHJv",
            "dG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLnJlc291cmNlcxoeZ29vZ2xl",
            "L3Byb3RvYnVmL3dyYXBwZXJzLnByb3RvGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvIt0BCgVWaWRlbxIVCg1yZXNvdXJjZV9uYW1lGAEgASgJEigK",
            "AmlkGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEjAKCmNo",
            "YW5uZWxfaWQYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUS",
            "NAoPZHVyYXRpb25fbWlsbGlzGAQgASgLMhsuZ29vZ2xlLnByb3RvYnVmLklu",
            "dDY0VmFsdWUSKwoFdGl0bGUYBSABKAsyHC5nb29nbGUucHJvdG9idWYuU3Ry",
            "aW5nVmFsdWVC9wEKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MC5yZXNv",
            "dXJjZXNCClZpZGVvUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL3Jlc291cmNlcztyZXNv",
            "dXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMC5SZXNvdXJj",
            "ZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWMFxSZXNvdXJjZXPqAiVHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWMDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Resources.Video), global::Google.Ads.GoogleAds.V0.Resources.Video.Parser, new[]{ "ResourceName", "Id", "ChannelId", "DurationMillis", "Title" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A video.
  /// </summary>
  public sealed partial class Video : pb::IMessage<Video> {
    private static readonly pb::MessageParser<Video> _parser = new pb::MessageParser<Video>(() => new Video());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Video> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Resources.VideoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Video() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Video(Video other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      ChannelId = other.ChannelId;
      DurationMillis = other.DurationMillis;
      Title = other.Title;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Video Clone() {
      return new Video(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the video.
    /// Video resource names have the form:
    ///
    /// `customers/{customer_id}/videos/{video_id}`
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
    private static readonly pb::FieldCodec<string> _single_id_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string id_;
    /// <summary>
    /// The ID of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "channel_id" field.</summary>
    public const int ChannelIdFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_channelId_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string channelId_;
    /// <summary>
    /// The owner channel id of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChannelId {
      get { return channelId_; }
      set {
        channelId_ = value;
      }
    }

    /// <summary>Field number for the "duration_millis" field.</summary>
    public const int DurationMillisFieldNumber = 4;
    private static readonly pb::FieldCodec<long?> _single_durationMillis_codec = pb::FieldCodec.ForStructWrapper<long>(34);
    private long? durationMillis_;
    /// <summary>
    /// The duration of the video in milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? DurationMillis {
      get { return durationMillis_; }
      set {
        durationMillis_ = value;
      }
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_title_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string title_;
    /// <summary>
    /// The title of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Title {
      get { return title_; }
      set {
        title_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Video);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Video other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (ChannelId != other.ChannelId) return false;
      if (DurationMillis != other.DurationMillis) return false;
      if (Title != other.Title) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (channelId_ != null) hash ^= ChannelId.GetHashCode();
      if (durationMillis_ != null) hash ^= DurationMillis.GetHashCode();
      if (title_ != null) hash ^= Title.GetHashCode();
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
      if (channelId_ != null) {
        _single_channelId_codec.WriteTagAndValue(output, ChannelId);
      }
      if (durationMillis_ != null) {
        _single_durationMillis_codec.WriteTagAndValue(output, DurationMillis);
      }
      if (title_ != null) {
        _single_title_codec.WriteTagAndValue(output, Title);
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
      if (channelId_ != null) {
        size += _single_channelId_codec.CalculateSizeWithTag(ChannelId);
      }
      if (durationMillis_ != null) {
        size += _single_durationMillis_codec.CalculateSizeWithTag(DurationMillis);
      }
      if (title_ != null) {
        size += _single_title_codec.CalculateSizeWithTag(Title);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Video other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      if (other.channelId_ != null) {
        if (channelId_ == null || other.ChannelId != "") {
          ChannelId = other.ChannelId;
        }
      }
      if (other.durationMillis_ != null) {
        if (durationMillis_ == null || other.DurationMillis != 0L) {
          DurationMillis = other.DurationMillis;
        }
      }
      if (other.title_ != null) {
        if (title_ == null || other.Title != "") {
          Title = other.Title;
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
            string value = _single_id_codec.Read(input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
          case 26: {
            string value = _single_channelId_codec.Read(input);
            if (channelId_ == null || value != "") {
              ChannelId = value;
            }
            break;
          }
          case 34: {
            long? value = _single_durationMillis_codec.Read(input);
            if (durationMillis_ == null || value != 0L) {
              DurationMillis = value;
            }
            break;
          }
          case 42: {
            string value = _single_title_codec.Read(input);
            if (title_ == null || value != "") {
              Title = value;
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
