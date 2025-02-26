// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/common/text_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/common/text_label.proto</summary>
  public static partial class TextLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/common/text_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvY29tbW9uL3RleHRfbGFiZWwu",
            "cHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5jb21tb24iaQoJVGV4",
            "dExhYmVsEh0KEGJhY2tncm91bmRfY29sb3IYAyABKAlIAIgBARIYCgtkZXNj",
            "cmlwdGlvbhgEIAEoCUgBiAEBQhMKEV9iYWNrZ3JvdW5kX2NvbG9yQg4KDF9k",
            "ZXNjcmlwdGlvbkLuAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5j",
            "b21tb25CDlRleHRMYWJlbFByb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTkvY29tbW9uO2Nv",
            "bW1vbqICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxOS5Db21tb27K",
            "Ah9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTlcQ29tbW9u6gIjR29vZ2xlOjpB",
            "ZHM6Okdvb2dsZUFkczo6VjE5OjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Common.TextLabel), global::Google.Ads.GoogleAds.V19.Common.TextLabel.Parser, new[]{ "BackgroundColor", "Description" }, new[]{ "BackgroundColor", "Description" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A type of label displaying text on a colored background.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class TextLabel : pb::IMessage<TextLabel>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextLabel> _parser = new pb::MessageParser<TextLabel>(() => new TextLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Common.TextLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextLabel(TextLabel other) : this() {
      backgroundColor_ = other.backgroundColor_;
      description_ = other.description_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextLabel Clone() {
      return new TextLabel(this);
    }

    /// <summary>Field number for the "background_color" field.</summary>
    public const int BackgroundColorFieldNumber = 3;
    private readonly static string BackgroundColorDefaultValue = "";

    private string backgroundColor_;
    /// <summary>
    /// Background color of the label in HEX format. This string must match the
    /// regular expression '^\#([a-fA-F0-9]{6}|[a-fA-F0-9]{3})$'.
    /// Note: The background color may not be visible for manager accounts.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BackgroundColor {
      get { return backgroundColor_ ?? BackgroundColorDefaultValue; }
      set {
        backgroundColor_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "background_color" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBackgroundColor {
      get { return backgroundColor_ != null; }
    }
    /// <summary>Clears the value of the "background_color" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBackgroundColor() {
      backgroundColor_ = null;
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private readonly static string DescriptionDefaultValue = "";

    private string description_;
    /// <summary>
    /// A short description of the label. The length must be no more than 200
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_ ?? DescriptionDefaultValue; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "description" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDescription {
      get { return description_ != null; }
    }
    /// <summary>Clears the value of the "description" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDescription() {
      description_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BackgroundColor != other.BackgroundColor) return false;
      if (Description != other.Description) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasBackgroundColor) hash ^= BackgroundColor.GetHashCode();
      if (HasDescription) hash ^= Description.GetHashCode();
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
      if (HasBackgroundColor) {
        output.WriteRawTag(26);
        output.WriteString(BackgroundColor);
      }
      if (HasDescription) {
        output.WriteRawTag(34);
        output.WriteString(Description);
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
      if (HasBackgroundColor) {
        output.WriteRawTag(26);
        output.WriteString(BackgroundColor);
      }
      if (HasDescription) {
        output.WriteRawTag(34);
        output.WriteString(Description);
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
      if (HasBackgroundColor) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BackgroundColor);
      }
      if (HasDescription) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextLabel other) {
      if (other == null) {
        return;
      }
      if (other.HasBackgroundColor) {
        BackgroundColor = other.BackgroundColor;
      }
      if (other.HasDescription) {
        Description = other.Description;
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
          case 26: {
            BackgroundColor = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
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
          case 26: {
            BackgroundColor = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
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
