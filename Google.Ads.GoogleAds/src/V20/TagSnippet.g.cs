// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/common/tag_snippet.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/common/tag_snippet.proto</summary>
  public static partial class TagSnippetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/common/tag_snippet.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TagSnippetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvY29tbW9uL3RhZ19zbmlwcGV0",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuY29tbW9uGj5nb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvdHJhY2tpbmdfY29kZV9wYWdl",
            "X2Zvcm1hdC5wcm90bxo3Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIwL2VudW1z",
            "L3RyYWNraW5nX2NvZGVfdHlwZS5wcm90byKpAgoKVGFnU25pcHBldBJTCgR0",
            "eXBlGAEgASgOMkUuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zLlRy",
            "YWNraW5nQ29kZVR5cGVFbnVtLlRyYWNraW5nQ29kZVR5cGUSZgoLcGFnZV9m",
            "b3JtYXQYAiABKA4yUS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXMu",
            "VHJhY2tpbmdDb2RlUGFnZUZvcm1hdEVudW0uVHJhY2tpbmdDb2RlUGFnZUZv",
            "cm1hdBIcCg9nbG9iYWxfc2l0ZV90YWcYBSABKAlIAIgBARIaCg1ldmVudF9z",
            "bmlwcGV0GAYgASgJSAGIAQFCEgoQX2dsb2JhbF9zaXRlX3RhZ0IQCg5fZXZl",
            "bnRfc25pcHBldELvAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5j",
            "b21tb25CD1RhZ1NuaXBwZXRQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIwL2NvbW1vbjtj",
            "b21tb26iAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMjAuQ29tbW9u",
            "ygIfR29vZ2xlXEFkc1xHb29nbGVBZHNcVjIwXENvbW1vbuoCI0dvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYyMDo6Q29tbW9uYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Common.TagSnippet), global::Google.Ads.GoogleAds.V20.Common.TagSnippet.Parser, new[]{ "Type", "PageFormat", "GlobalSiteTag", "EventSnippet" }, new[]{ "GlobalSiteTag", "EventSnippet" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The site tag and event snippet pair for a TrackingCodeType.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TagSnippet : pb::IMessage<TagSnippet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TagSnippet> _parser = new pb::MessageParser<TagSnippet>(() => new TagSnippet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TagSnippet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Common.TagSnippetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TagSnippet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TagSnippet(TagSnippet other) : this() {
      type_ = other.type_;
      pageFormat_ = other.pageFormat_;
      globalSiteTag_ = other.globalSiteTag_;
      eventSnippet_ = other.eventSnippet_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TagSnippet Clone() {
      return new TagSnippet(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType type_ = global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified;
    /// <summary>
    /// The type of the generated tag snippets for tracking conversions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "page_format" field.</summary>
    public const int PageFormatFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat pageFormat_ = global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified;
    /// <summary>
    /// The format of the web page where the tracking tag and snippet will be
    /// installed, for example, HTML.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat PageFormat {
      get { return pageFormat_; }
      set {
        pageFormat_ = value;
      }
    }

    /// <summary>Field number for the "global_site_tag" field.</summary>
    public const int GlobalSiteTagFieldNumber = 5;
    private readonly static string GlobalSiteTagDefaultValue = "";

    private string globalSiteTag_;
    /// <summary>
    /// The site tag that adds visitors to your basic remarketing lists and sets
    /// new cookies on your domain.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string GlobalSiteTag {
      get { return globalSiteTag_ ?? GlobalSiteTagDefaultValue; }
      set {
        globalSiteTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "global_site_tag" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasGlobalSiteTag {
      get { return globalSiteTag_ != null; }
    }
    /// <summary>Clears the value of the "global_site_tag" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearGlobalSiteTag() {
      globalSiteTag_ = null;
    }

    /// <summary>Field number for the "event_snippet" field.</summary>
    public const int EventSnippetFieldNumber = 6;
    private readonly static string EventSnippetDefaultValue = "";

    private string eventSnippet_;
    /// <summary>
    /// The event snippet that works with the site tag to track actions that
    /// should be counted as conversions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EventSnippet {
      get { return eventSnippet_ ?? EventSnippetDefaultValue; }
      set {
        eventSnippet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "event_snippet" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEventSnippet {
      get { return eventSnippet_ != null; }
    }
    /// <summary>Clears the value of the "event_snippet" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEventSnippet() {
      eventSnippet_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TagSnippet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TagSnippet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (PageFormat != other.PageFormat) return false;
      if (GlobalSiteTag != other.GlobalSiteTag) return false;
      if (EventSnippet != other.EventSnippet) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified) hash ^= Type.GetHashCode();
      if (PageFormat != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified) hash ^= PageFormat.GetHashCode();
      if (HasGlobalSiteTag) hash ^= GlobalSiteTag.GetHashCode();
      if (HasEventSnippet) hash ^= EventSnippet.GetHashCode();
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
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (PageFormat != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PageFormat);
      }
      if (HasGlobalSiteTag) {
        output.WriteRawTag(42);
        output.WriteString(GlobalSiteTag);
      }
      if (HasEventSnippet) {
        output.WriteRawTag(50);
        output.WriteString(EventSnippet);
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
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (PageFormat != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PageFormat);
      }
      if (HasGlobalSiteTag) {
        output.WriteRawTag(42);
        output.WriteString(GlobalSiteTag);
      }
      if (HasEventSnippet) {
        output.WriteRawTag(50);
        output.WriteString(EventSnippet);
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
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (PageFormat != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PageFormat);
      }
      if (HasGlobalSiteTag) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GlobalSiteTag);
      }
      if (HasEventSnippet) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventSnippet);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TagSnippet other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType.Unspecified) {
        Type = other.Type;
      }
      if (other.PageFormat != global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat.Unspecified) {
        PageFormat = other.PageFormat;
      }
      if (other.HasGlobalSiteTag) {
        GlobalSiteTag = other.GlobalSiteTag;
      }
      if (other.HasEventSnippet) {
        EventSnippet = other.EventSnippet;
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
          case 8: {
            Type = (global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType) input.ReadEnum();
            break;
          }
          case 16: {
            PageFormat = (global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat) input.ReadEnum();
            break;
          }
          case 42: {
            GlobalSiteTag = input.ReadString();
            break;
          }
          case 50: {
            EventSnippet = input.ReadString();
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
          case 8: {
            Type = (global::Google.Ads.GoogleAds.V20.Enums.TrackingCodeTypeEnum.Types.TrackingCodeType) input.ReadEnum();
            break;
          }
          case 16: {
            PageFormat = (global::Google.Ads.GoogleAds.V20.Enums.TrackingCodePageFormatEnum.Types.TrackingCodePageFormat) input.ReadEnum();
            break;
          }
          case 42: {
            GlobalSiteTag = input.ReadString();
            break;
          }
          case 50: {
            EventSnippet = input.ReadString();
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
