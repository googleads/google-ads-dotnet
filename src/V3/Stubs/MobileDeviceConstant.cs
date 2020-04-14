// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/mobile_device_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/mobile_device_constant.proto</summary>
  public static partial class MobileDeviceConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/mobile_device_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobileDeviceConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvbW9iaWxlX2Rl",
            "dmljZV9jb25zdGFudC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMu",
            "cmVzb3VyY2VzGjZnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9tb2Jp",
            "bGVfZGV2aWNlX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZp",
            "b3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9w",
            "cm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9u",
            "cy5wcm90byKABAoUTW9iaWxlRGV2aWNlQ29uc3RhbnQSTAoNcmVzb3VyY2Vf",
            "bmFtZRgBIAEoCUI14EED+kEvCi1nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20v",
            "TW9iaWxlRGV2aWNlQ29uc3RhbnQSLAoCaWQYAiABKAsyGy5nb29nbGUucHJv",
            "dG9idWYuSW50NjRWYWx1ZUID4EEDEi8KBG5hbWUYAyABKAsyHC5nb29nbGUu",
            "cHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxI8ChFtYW51ZmFjdHVyZXJfbmFt",
            "ZRgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEkAK",
            "FW9wZXJhdGluZ19zeXN0ZW1fbmFtZRgFIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZUID4EEDElcKBHR5cGUYBiABKA4yRC5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52My5lbnVtcy5Nb2JpbGVEZXZpY2VUeXBlRW51bS5Nb2Jp",
            "bGVEZXZpY2VUeXBlQgPgQQM6YupBXwotZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL01vYmlsZURldmljZUNvbnN0YW50Ei5tb2JpbGVEZXZpY2VDb25zdGFu",
            "dHMve21vYmlsZV9kZXZpY2VfY29uc3RhbnR9QoYCCiVjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjMucmVzb3VyY2VzQhlNb2JpbGVEZXZpY2VDb25zdGFu",
            "dFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFw",
            "aXMvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FB",
            "qgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjMuUmVzb3VyY2VzygIhR29vZ2xl",
            "XEFkc1xHb29nbGVBZHNcVjNcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdv",
            "b2dsZUFkczo6VjM6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Enums.MobileDeviceTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.MobileDeviceConstant), global::Google.Ads.GoogleAds.V3.Resources.MobileDeviceConstant.Parser, new[]{ "ResourceName", "Id", "Name", "ManufacturerName", "OperatingSystemName", "Type" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A mobile device constant.
  /// </summary>
  public sealed partial class MobileDeviceConstant : pb::IMessage<MobileDeviceConstant> {
    private static readonly pb::MessageParser<MobileDeviceConstant> _parser = new pb::MessageParser<MobileDeviceConstant>(() => new MobileDeviceConstant());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MobileDeviceConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.MobileDeviceConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileDeviceConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileDeviceConstant(MobileDeviceConstant other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      Name = other.Name;
      ManufacturerName = other.ManufacturerName;
      OperatingSystemName = other.OperatingSystemName;
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MobileDeviceConstant Clone() {
      return new MobileDeviceConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the mobile device constant.
    /// Mobile device constant resource names have the form:
    ///
    /// `mobileDeviceConstants/{criterion_id}`
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
    /// Output only. The ID of the mobile device constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string name_;
    /// <summary>
    /// Output only. The name of the mobile device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "manufacturer_name" field.</summary>
    public const int ManufacturerNameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_manufacturerName_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string manufacturerName_;
    /// <summary>
    /// Output only. The manufacturer of the mobile device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ManufacturerName {
      get { return manufacturerName_; }
      set {
        manufacturerName_ = value;
      }
    }


    /// <summary>Field number for the "operating_system_name" field.</summary>
    public const int OperatingSystemNameFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_operatingSystemName_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string operatingSystemName_;
    /// <summary>
    /// Output only. The operating system of the mobile device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OperatingSystemName {
      get { return operatingSystemName_; }
      set {
        operatingSystemName_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V3.Enums.MobileDeviceTypeEnum.Types.MobileDeviceType type_ = 0;
    /// <summary>
    /// Output only. The type of mobile device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.MobileDeviceTypeEnum.Types.MobileDeviceType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MobileDeviceConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MobileDeviceConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (ManufacturerName != other.ManufacturerName) return false;
      if (OperatingSystemName != other.OperatingSystemName) return false;
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (manufacturerName_ != null) hash ^= ManufacturerName.GetHashCode();
      if (operatingSystemName_ != null) hash ^= OperatingSystemName.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
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
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (manufacturerName_ != null) {
        _single_manufacturerName_codec.WriteTagAndValue(output, ManufacturerName);
      }
      if (operatingSystemName_ != null) {
        _single_operatingSystemName_codec.WriteTagAndValue(output, OperatingSystemName);
      }
      if (Type != 0) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Type);
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
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (manufacturerName_ != null) {
        size += _single_manufacturerName_codec.CalculateSizeWithTag(ManufacturerName);
      }
      if (operatingSystemName_ != null) {
        size += _single_operatingSystemName_codec.CalculateSizeWithTag(OperatingSystemName);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MobileDeviceConstant other) {
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
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.manufacturerName_ != null) {
        if (manufacturerName_ == null || other.ManufacturerName != "") {
          ManufacturerName = other.ManufacturerName;
        }
      }
      if (other.operatingSystemName_ != null) {
        if (operatingSystemName_ == null || other.OperatingSystemName != "") {
          OperatingSystemName = other.OperatingSystemName;
        }
      }
      if (other.Type != 0) {
        Type = other.Type;
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
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 34: {
            string value = _single_manufacturerName_codec.Read(input);
            if (manufacturerName_ == null || value != "") {
              ManufacturerName = value;
            }
            break;
          }
          case 42: {
            string value = _single_operatingSystemName_codec.Read(input);
            if (operatingSystemName_ == null || value != "") {
              OperatingSystemName = value;
            }
            break;
          }
          case 48: {
            Type = (global::Google.Ads.GoogleAds.V3.Enums.MobileDeviceTypeEnum.Types.MobileDeviceType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
