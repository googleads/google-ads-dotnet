// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/video.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/video.proto</summary>
  public static partial class VideoReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/video.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VideoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci1nb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvdmlkZW8ucHJv",
            "dG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNlcxofZ29vZ2xl",
            "L2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJj",
            "ZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byK6AgoFVmlk",
            "ZW8SPQoNcmVzb3VyY2VfbmFtZRgBIAEoCUIm4EED+kEgCh5nb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vVmlkZW8SFAoCaWQYBiABKAlCA+BBA0gAiAEBEhwK",
            "CmNoYW5uZWxfaWQYByABKAlCA+BBA0gBiAEBEiEKD2R1cmF0aW9uX21pbGxp",
            "cxgIIAEoA0ID4EEDSAKIAQESFwoFdGl0bGUYCSABKAlCA+BBA0gDiAEBOk7q",
            "QUsKHmdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9WaWRlbxIpY3VzdG9tZXJz",
            "L3tjdXN0b21lcl9pZH0vdmlkZW9zL3t2aWRlb19pZH1CBQoDX2lkQg0KC19j",
            "aGFubmVsX2lkQhIKEF9kdXJhdGlvbl9taWxsaXNCCAoGX3RpdGxlQvcBCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkucmVzb3VyY2VzQgpWaWRlb1By",
            "b3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIh",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjkuUmVzb3VyY2VzygIhR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjlcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6Vjk6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.Video), global::Google.Ads.GoogleAds.V9.Resources.Video.Parser, new[]{ "ResourceName", "Id", "ChannelId", "DurationMillis", "Title" }, new[]{ "Id", "ChannelId", "DurationMillis", "Title" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A video.
  /// </summary>
  public sealed partial class Video : pb::IMessage<Video>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Video> _parser = new pb::MessageParser<Video>(() => new Video());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Video> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.VideoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Video() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Video(Video other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      channelId_ = other.channelId_;
      durationMillis_ = other.durationMillis_;
      title_ = other.title_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Video Clone() {
      return new Video(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the video.
    /// Video resource names have the form:
    ///
    /// `customers/{customer_id}/videos/{video_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 6;
    private string id_;
    /// <summary>
    /// Output only. The ID of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_ ?? ""; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return id_ != null; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      id_ = null;
    }

    /// <summary>Field number for the "channel_id" field.</summary>
    public const int ChannelIdFieldNumber = 7;
    private string channelId_;
    /// <summary>
    /// Output only. The owner channel id of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ChannelId {
      get { return channelId_ ?? ""; }
      set {
        channelId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "channel_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasChannelId {
      get { return channelId_ != null; }
    }
    /// <summary>Clears the value of the "channel_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearChannelId() {
      channelId_ = null;
    }

    /// <summary>Field number for the "duration_millis" field.</summary>
    public const int DurationMillisFieldNumber = 8;
    private long durationMillis_;
    /// <summary>
    /// Output only. The duration of the video in milliseconds.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long DurationMillis {
      get { if ((_hasBits0 & 1) != 0) { return durationMillis_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        durationMillis_ = value;
      }
    }
    /// <summary>Gets whether the "duration_millis" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDurationMillis {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "duration_millis" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDurationMillis() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 9;
    private string title_;
    /// <summary>
    /// Output only. The title of the video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_ ?? ""; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "title" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTitle {
      get { return title_ != null; }
    }
    /// <summary>Clears the value of the "title" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTitle() {
      title_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Video);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasChannelId) hash ^= ChannelId.GetHashCode();
      if (HasDurationMillis) hash ^= DurationMillis.GetHashCode();
      if (HasTitle) hash ^= Title.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasId) {
        output.WriteRawTag(50);
        output.WriteString(Id);
      }
      if (HasChannelId) {
        output.WriteRawTag(58);
        output.WriteString(ChannelId);
      }
      if (HasDurationMillis) {
        output.WriteRawTag(64);
        output.WriteInt64(DurationMillis);
      }
      if (HasTitle) {
        output.WriteRawTag(74);
        output.WriteString(Title);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasId) {
        output.WriteRawTag(50);
        output.WriteString(Id);
      }
      if (HasChannelId) {
        output.WriteRawTag(58);
        output.WriteString(ChannelId);
      }
      if (HasDurationMillis) {
        output.WriteRawTag(64);
        output.WriteInt64(DurationMillis);
      }
      if (HasTitle) {
        output.WriteRawTag(74);
        output.WriteString(Title);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (HasChannelId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChannelId);
      }
      if (HasDurationMillis) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DurationMillis);
      }
      if (HasTitle) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Video other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasChannelId) {
        ChannelId = other.ChannelId;
      }
      if (other.HasDurationMillis) {
        DurationMillis = other.DurationMillis;
      }
      if (other.HasTitle) {
        Title = other.Title;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 50: {
            Id = input.ReadString();
            break;
          }
          case 58: {
            ChannelId = input.ReadString();
            break;
          }
          case 64: {
            DurationMillis = input.ReadInt64();
            break;
          }
          case 74: {
            Title = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
          case 50: {
            Id = input.ReadString();
            break;
          }
          case 58: {
            ChannelId = input.ReadString();
            break;
          }
          case 64: {
            DurationMillis = input.ReadInt64();
            break;
          }
          case 74: {
            Title = input.ReadString();
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
