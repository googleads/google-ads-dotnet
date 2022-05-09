// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/common/url_collection.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/common/url_collection.proto</summary>
  public static partial class UrlCollectionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/common/url_collection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UrlCollectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vdXJsX2NvbGxlY3Rp",
            "b24ucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbiKyAQoN",
            "VXJsQ29sbGVjdGlvbhIeChF1cmxfY29sbGVjdGlvbl9pZBgFIAEoCUgAiAEB",
            "EhIKCmZpbmFsX3VybHMYBiADKAkSGQoRZmluYWxfbW9iaWxlX3VybHMYByAD",
            "KAkSIgoVdHJhY2tpbmdfdXJsX3RlbXBsYXRlGAggASgJSAGIAQFCFAoSX3Vy",
            "bF9jb2xsZWN0aW9uX2lkQhgKFl90cmFja2luZ191cmxfdGVtcGxhdGVC7QEK",
            "ImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5jb21tb25CElVybENvbGxl",
            "Y3Rpb25Qcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29n",
            "bGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvY29tbW9uO2NvbW1vbqICA0dBQaoC",
            "Hkdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LkNvbW1vbsoCHkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFY5XENvbW1vbuoCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlY5OjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.UrlCollection), global::Google.Ads.GoogleAds.V9.Common.UrlCollection.Parser, new[]{ "UrlCollectionId", "FinalUrls", "FinalMobileUrls", "TrackingUrlTemplate" }, new[]{ "UrlCollectionId", "TrackingUrlTemplate" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Collection of urls that is tagged with a unique identifier.
  /// </summary>
  public sealed partial class UrlCollection : pb::IMessage<UrlCollection>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UrlCollection> _parser = new pb::MessageParser<UrlCollection>(() => new UrlCollection());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UrlCollection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.UrlCollectionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlCollection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlCollection(UrlCollection other) : this() {
      urlCollectionId_ = other.urlCollectionId_;
      finalUrls_ = other.finalUrls_.Clone();
      finalMobileUrls_ = other.finalMobileUrls_.Clone();
      trackingUrlTemplate_ = other.trackingUrlTemplate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UrlCollection Clone() {
      return new UrlCollection(this);
    }

    /// <summary>Field number for the "url_collection_id" field.</summary>
    public const int UrlCollectionIdFieldNumber = 5;
    private string urlCollectionId_;
    /// <summary>
    /// Unique identifier for this UrlCollection instance.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UrlCollectionId {
      get { return urlCollectionId_ ?? ""; }
      set {
        urlCollectionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "url_collection_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasUrlCollectionId {
      get { return urlCollectionId_ != null; }
    }
    /// <summary>Clears the value of the "url_collection_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUrlCollectionId() {
      urlCollectionId_ = null;
    }

    /// <summary>Field number for the "final_urls" field.</summary>
    public const int FinalUrlsFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _repeated_finalUrls_codec
        = pb::FieldCodec.ForString(50);
    private readonly pbc::RepeatedField<string> finalUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of possible final URLs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalUrls {
      get { return finalUrls_; }
    }

    /// <summary>Field number for the "final_mobile_urls" field.</summary>
    public const int FinalMobileUrlsFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_finalMobileUrls_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> finalMobileUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// A list of possible final mobile URLs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> FinalMobileUrls {
      get { return finalMobileUrls_; }
    }

    /// <summary>Field number for the "tracking_url_template" field.</summary>
    public const int TrackingUrlTemplateFieldNumber = 8;
    private string trackingUrlTemplate_;
    /// <summary>
    /// URL template for constructing a tracking URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TrackingUrlTemplate {
      get { return trackingUrlTemplate_ ?? ""; }
      set {
        trackingUrlTemplate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "tracking_url_template" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTrackingUrlTemplate {
      get { return trackingUrlTemplate_ != null; }
    }
    /// <summary>Clears the value of the "tracking_url_template" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTrackingUrlTemplate() {
      trackingUrlTemplate_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UrlCollection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UrlCollection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UrlCollectionId != other.UrlCollectionId) return false;
      if(!finalUrls_.Equals(other.finalUrls_)) return false;
      if(!finalMobileUrls_.Equals(other.finalMobileUrls_)) return false;
      if (TrackingUrlTemplate != other.TrackingUrlTemplate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasUrlCollectionId) hash ^= UrlCollectionId.GetHashCode();
      hash ^= finalUrls_.GetHashCode();
      hash ^= finalMobileUrls_.GetHashCode();
      if (HasTrackingUrlTemplate) hash ^= TrackingUrlTemplate.GetHashCode();
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
      if (HasUrlCollectionId) {
        output.WriteRawTag(42);
        output.WriteString(UrlCollectionId);
      }
      finalUrls_.WriteTo(output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(output, _repeated_finalMobileUrls_codec);
      if (HasTrackingUrlTemplate) {
        output.WriteRawTag(66);
        output.WriteString(TrackingUrlTemplate);
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
      if (HasUrlCollectionId) {
        output.WriteRawTag(42);
        output.WriteString(UrlCollectionId);
      }
      finalUrls_.WriteTo(ref output, _repeated_finalUrls_codec);
      finalMobileUrls_.WriteTo(ref output, _repeated_finalMobileUrls_codec);
      if (HasTrackingUrlTemplate) {
        output.WriteRawTag(66);
        output.WriteString(TrackingUrlTemplate);
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
      if (HasUrlCollectionId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UrlCollectionId);
      }
      size += finalUrls_.CalculateSize(_repeated_finalUrls_codec);
      size += finalMobileUrls_.CalculateSize(_repeated_finalMobileUrls_codec);
      if (HasTrackingUrlTemplate) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TrackingUrlTemplate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UrlCollection other) {
      if (other == null) {
        return;
      }
      if (other.HasUrlCollectionId) {
        UrlCollectionId = other.UrlCollectionId;
      }
      finalUrls_.Add(other.finalUrls_);
      finalMobileUrls_.Add(other.finalMobileUrls_);
      if (other.HasTrackingUrlTemplate) {
        TrackingUrlTemplate = other.TrackingUrlTemplate;
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
          case 42: {
            UrlCollectionId = input.ReadString();
            break;
          }
          case 50: {
            finalUrls_.AddEntriesFrom(input, _repeated_finalUrls_codec);
            break;
          }
          case 58: {
            finalMobileUrls_.AddEntriesFrom(input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 66: {
            TrackingUrlTemplate = input.ReadString();
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
          case 42: {
            UrlCollectionId = input.ReadString();
            break;
          }
          case 50: {
            finalUrls_.AddEntriesFrom(ref input, _repeated_finalUrls_codec);
            break;
          }
          case 58: {
            finalMobileUrls_.AddEntriesFrom(ref input, _repeated_finalMobileUrls_codec);
            break;
          }
          case 66: {
            TrackingUrlTemplate = input.ReadString();
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
