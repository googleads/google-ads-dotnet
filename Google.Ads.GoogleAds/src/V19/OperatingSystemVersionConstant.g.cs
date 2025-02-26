// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/resources/operating_system_version_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/resources/operating_system_version_constant.proto</summary>
  public static partial class OperatingSystemVersionConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/resources/operating_system_version_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperatingSystemVersionConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ckpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvcmVzb3VyY2VzL29wZXJhdGlu",
            "Z19zeXN0ZW1fdmVyc2lvbl9jb25zdGFudC5wcm90bxIiZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE5LnJlc291cmNlcxpLZ29vZ2xlL2Fkcy9nb29nbGVhZHMv",
            "djE5L2VudW1zL29wZXJhdGluZ19zeXN0ZW1fdmVyc2lvbl9vcGVyYXRvcl90",
            "eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhln",
            "b29nbGUvYXBpL3Jlc291cmNlLnByb3RvIp4ECh5PcGVyYXRpbmdTeXN0ZW1W",
            "ZXJzaW9uQ29uc3RhbnQSVgoNcmVzb3VyY2VfbmFtZRgBIAEoCUI/4EED+kE5",
            "Cjdnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vT3BlcmF0aW5nU3lzdGVtVmVy",
            "c2lvbkNvbnN0YW50EhQKAmlkGAcgASgDQgPgQQNIAIgBARIWCgRuYW1lGAgg",
            "ASgJQgPgQQNIAYgBARIiChBvc19tYWpvcl92ZXJzaW9uGAkgASgFQgPgQQNI",
            "AogBARIiChBvc19taW5vcl92ZXJzaW9uGAogASgFQgPgQQNIA4gBARKFAQoN",
            "b3BlcmF0b3JfdHlwZRgGIAEoDjJpLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "OS5lbnVtcy5PcGVyYXRpbmdTeXN0ZW1WZXJzaW9uT3BlcmF0b3JUeXBlRW51",
            "bS5PcGVyYXRpbmdTeXN0ZW1WZXJzaW9uT3BlcmF0b3JUeXBlQgPgQQM6bOpB",
            "aQo3Z29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL09wZXJhdGluZ1N5c3RlbVZl",
            "cnNpb25Db25zdGFudBIub3BlcmF0aW5nU3lzdGVtVmVyc2lvbkNvbnN0YW50",
            "cy97Y3JpdGVyaW9uX2lkfUIFCgNfaWRCBwoFX25hbWVCEwoRX29zX21ham9y",
            "X3ZlcnNpb25CEwoRX29zX21pbm9yX3ZlcnNpb25ClQIKJmNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MTkucmVzb3VyY2VzQiNPcGVyYXRpbmdTeXN0ZW1W",
            "ZXJzaW9uQ29uc3RhbnRQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjE5L3Jlc291cmNlczty",
            "ZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMTkuUmVz",
            "b3VyY2VzygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjE5XFJlc291cmNlc+oC",
            "Jkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOTo6UmVzb3VyY2VzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Resources.OperatingSystemVersionConstant), global::Google.Ads.GoogleAds.V19.Resources.OperatingSystemVersionConstant.Parser, new[]{ "ResourceName", "Id", "Name", "OsMajorVersion", "OsMinorVersion", "OperatorType" }, new[]{ "Id", "Name", "OsMajorVersion", "OsMinorVersion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A mobile operating system version or a range of versions, depending on
  /// `operator_type`. List of available mobile platforms at
  /// https://developers.google.com/google-ads/api/reference/data/codes-formats#mobile-platforms
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class OperatingSystemVersionConstant : pb::IMessage<OperatingSystemVersionConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<OperatingSystemVersionConstant> _parser = new pb::MessageParser<OperatingSystemVersionConstant>(() => new OperatingSystemVersionConstant());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<OperatingSystemVersionConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Resources.OperatingSystemVersionConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperatingSystemVersionConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperatingSystemVersionConstant(OperatingSystemVersionConstant other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      name_ = other.name_;
      osMajorVersion_ = other.osMajorVersion_;
      osMinorVersion_ = other.osMinorVersion_;
      operatorType_ = other.operatorType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public OperatingSystemVersionConstant Clone() {
      return new OperatingSystemVersionConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the operating system version constant.
    /// Operating system version constant resource names have the form:
    ///
    /// `operatingSystemVersionConstants/{criterion_id}`
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
    public const int IdFieldNumber = 7;
    private readonly static long IdDefaultValue = 0L;

    private long id_;
    /// <summary>
    /// Output only. The ID of the operating system version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 8;
    private readonly static string NameDefaultValue = "";

    private string name_;
    /// <summary>
    /// Output only. Name of the operating system.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_ ?? NameDefaultValue; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasName {
      get { return name_ != null; }
    }
    /// <summary>Clears the value of the "name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearName() {
      name_ = null;
    }

    /// <summary>Field number for the "os_major_version" field.</summary>
    public const int OsMajorVersionFieldNumber = 9;
    private readonly static int OsMajorVersionDefaultValue = 0;

    private int osMajorVersion_;
    /// <summary>
    /// Output only. The OS Major Version number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OsMajorVersion {
      get { if ((_hasBits0 & 2) != 0) { return osMajorVersion_; } else { return OsMajorVersionDefaultValue; } }
      set {
        _hasBits0 |= 2;
        osMajorVersion_ = value;
      }
    }
    /// <summary>Gets whether the "os_major_version" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOsMajorVersion {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "os_major_version" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOsMajorVersion() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "os_minor_version" field.</summary>
    public const int OsMinorVersionFieldNumber = 10;
    private readonly static int OsMinorVersionDefaultValue = 0;

    private int osMinorVersion_;
    /// <summary>
    /// Output only. The OS Minor Version number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int OsMinorVersion {
      get { if ((_hasBits0 & 4) != 0) { return osMinorVersion_; } else { return OsMinorVersionDefaultValue; } }
      set {
        _hasBits0 |= 4;
        osMinorVersion_ = value;
      }
    }
    /// <summary>Gets whether the "os_minor_version" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOsMinorVersion {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "os_minor_version" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOsMinorVersion() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "operator_type" field.</summary>
    public const int OperatorTypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType operatorType_ = global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified;
    /// <summary>
    /// Output only. Determines whether this constant represents a single version
    /// or a range of versions.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType OperatorType {
      get { return operatorType_; }
      set {
        operatorType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as OperatingSystemVersionConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(OperatingSystemVersionConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (OsMajorVersion != other.OsMajorVersion) return false;
      if (OsMinorVersion != other.OsMinorVersion) return false;
      if (OperatorType != other.OperatorType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasName) hash ^= Name.GetHashCode();
      if (HasOsMajorVersion) hash ^= OsMajorVersion.GetHashCode();
      if (HasOsMinorVersion) hash ^= OsMinorVersion.GetHashCode();
      if (OperatorType != global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified) hash ^= OperatorType.GetHashCode();
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
      if (OperatorType != global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) OperatorType);
      }
      if (HasId) {
        output.WriteRawTag(56);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(66);
        output.WriteString(Name);
      }
      if (HasOsMajorVersion) {
        output.WriteRawTag(72);
        output.WriteInt32(OsMajorVersion);
      }
      if (HasOsMinorVersion) {
        output.WriteRawTag(80);
        output.WriteInt32(OsMinorVersion);
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
      if (OperatorType != global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) OperatorType);
      }
      if (HasId) {
        output.WriteRawTag(56);
        output.WriteInt64(Id);
      }
      if (HasName) {
        output.WriteRawTag(66);
        output.WriteString(Name);
      }
      if (HasOsMajorVersion) {
        output.WriteRawTag(72);
        output.WriteInt32(OsMajorVersion);
      }
      if (HasOsMinorVersion) {
        output.WriteRawTag(80);
        output.WriteInt32(OsMinorVersion);
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
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasOsMajorVersion) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OsMajorVersion);
      }
      if (HasOsMinorVersion) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OsMinorVersion);
      }
      if (OperatorType != global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OperatorType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(OperatingSystemVersionConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasName) {
        Name = other.Name;
      }
      if (other.HasOsMajorVersion) {
        OsMajorVersion = other.OsMajorVersion;
      }
      if (other.HasOsMinorVersion) {
        OsMinorVersion = other.OsMinorVersion;
      }
      if (other.OperatorType != global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType.Unspecified) {
        OperatorType = other.OperatorType;
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
          case 48: {
            OperatorType = (global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType) input.ReadEnum();
            break;
          }
          case 56: {
            Id = input.ReadInt64();
            break;
          }
          case 66: {
            Name = input.ReadString();
            break;
          }
          case 72: {
            OsMajorVersion = input.ReadInt32();
            break;
          }
          case 80: {
            OsMinorVersion = input.ReadInt32();
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
          case 48: {
            OperatorType = (global::Google.Ads.GoogleAds.V19.Enums.OperatingSystemVersionOperatorTypeEnum.Types.OperatingSystemVersionOperatorType) input.ReadEnum();
            break;
          }
          case 56: {
            Id = input.ReadInt64();
            break;
          }
          case 66: {
            Name = input.ReadString();
            break;
          }
          case 72: {
            OsMajorVersion = input.ReadInt32();
            break;
          }
          case 80: {
            OsMinorVersion = input.ReadInt32();
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
