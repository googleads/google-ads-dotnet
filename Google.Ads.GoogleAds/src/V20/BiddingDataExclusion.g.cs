// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/bidding_data_exclusion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/bidding_data_exclusion.proto</summary>
  public static partial class BiddingDataExclusionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/bidding_data_exclusion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingDataExclusionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL2JpZGRpbmdf",
            "ZGF0YV9leGNsdXNpb24ucHJvdG8SImdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYy",
            "MC5yZXNvdXJjZXMaPWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YyMC9lbnVtcy9h",
            "ZHZlcnRpc2luZ19jaGFubmVsX3R5cGUucHJvdG8aK2dvb2dsZS9hZHMvZ29v",
            "Z2xlYWRzL3YyMC9lbnVtcy9kZXZpY2UucHJvdG8aPGdvb2dsZS9hZHMvZ29v",
            "Z2xlYWRzL3YyMC9lbnVtcy9zZWFzb25hbGl0eV9ldmVudF9zY29wZS5wcm90",
            "bxo9Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIwL2VudW1zL3NlYXNvbmFsaXR5",
            "X2V2ZW50X3N0YXR1cy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlv",
            "ci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byKYBgoUQmlkZGlu",
            "Z0RhdGFFeGNsdXNpb24STAoNcmVzb3VyY2VfbmFtZRgBIAEoCUI14EEF+kEv",
            "Ci1nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQmlkZGluZ0RhdGFFeGNsdXNp",
            "b24SHgoRZGF0YV9leGNsdXNpb25faWQYAiABKANCA+BBAxJeCgVzY29wZRgD",
            "IAEoDjJPLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5lbnVtcy5TZWFzb25h",
            "bGl0eUV2ZW50U2NvcGVFbnVtLlNlYXNvbmFsaXR5RXZlbnRTY29wZRJmCgZz",
            "dGF0dXMYBCABKA4yUS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXMu",
            "U2Vhc29uYWxpdHlFdmVudFN0YXR1c0VudW0uU2Vhc29uYWxpdHlFdmVudFN0",
            "YXR1c0ID4EEDEhwKD3N0YXJ0X2RhdGVfdGltZRgFIAEoCUID4EECEhoKDWVu",
            "ZF9kYXRlX3RpbWUYBiABKAlCA+BBAhIMCgRuYW1lGAcgASgJEhMKC2Rlc2Ny",
            "aXB0aW9uGAggASgJEkIKB2RldmljZXMYCSADKA4yMS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MjAuZW51bXMuRGV2aWNlRW51bS5EZXZpY2USOQoJY2FtcGFp",
            "Z25zGAogAygJQib6QSMKIWdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1w",
            "YWlnbhJ0ChlhZHZlcnRpc2luZ19jaGFubmVsX3R5cGVzGAsgAygOMlEuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zLkFkdmVydGlzaW5nQ2hhbm5l",
            "bFR5cGVFbnVtLkFkdmVydGlzaW5nQ2hhbm5lbFR5cGU6eOpBdQotZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0JpZGRpbmdEYXRhRXhjbHVzaW9uEkRjdXN0",
            "b21lcnMve2N1c3RvbWVyX2lkfS9iaWRkaW5nRGF0YUV4Y2x1c2lvbnMve3Nl",
            "YXNvbmFsaXR5X2V2ZW50X2lkfUKLAgomY29tLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYyMC5yZXNvdXJjZXNCGUJpZGRpbmdEYXRhRXhjbHVzaW9uUHJvdG9Q",
            "AVpLZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMv",
            "Z29vZ2xlYWRzL3YyMC9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIiR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjIwLlJlc291cmNlc8oCIkdvb2dsZVxBZHNc",
            "R29vZ2xlQWRzXFYyMFxSZXNvdXJjZXPqAiZHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMjA6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.DeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.BiddingDataExclusion), global::Google.Ads.GoogleAds.V20.Resources.BiddingDataExclusion.Parser, new[]{ "ResourceName", "DataExclusionId", "Scope", "Status", "StartDateTime", "EndDateTime", "Name", "Description", "Devices", "Campaigns", "AdvertisingChannelTypes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a bidding data exclusion. Bidding data exclusions can be set in
  /// client accounts only, and cannot be used in manager accounts.
  ///
  /// See "About data exclusions" at
  /// https://support.google.com/google-ads/answer/10370710.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BiddingDataExclusion : pb::IMessage<BiddingDataExclusion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingDataExclusion> _parser = new pb::MessageParser<BiddingDataExclusion>(() => new BiddingDataExclusion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BiddingDataExclusion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.BiddingDataExclusionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingDataExclusion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingDataExclusion(BiddingDataExclusion other) : this() {
      resourceName_ = other.resourceName_;
      dataExclusionId_ = other.dataExclusionId_;
      scope_ = other.scope_;
      status_ = other.status_;
      startDateTime_ = other.startDateTime_;
      endDateTime_ = other.endDateTime_;
      name_ = other.name_;
      description_ = other.description_;
      devices_ = other.devices_.Clone();
      campaigns_ = other.campaigns_.Clone();
      advertisingChannelTypes_ = other.advertisingChannelTypes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingDataExclusion Clone() {
      return new BiddingDataExclusion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the data exclusion.
    /// Data exclusion resource names have the form:
    ///
    /// `customers/{customer_id}/biddingDataExclusions/{data_exclusion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data_exclusion_id" field.</summary>
    public const int DataExclusionIdFieldNumber = 2;
    private long dataExclusionId_;
    /// <summary>
    /// Output only. The ID of the data exclusion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long DataExclusionId {
      get { return dataExclusionId_; }
      set {
        dataExclusionId_ = value;
      }
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope scope_ = global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified;
    /// <summary>
    /// The scope of the data exclusion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus status_ = global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified;
    /// <summary>
    /// Output only. The status of the data exclusion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "start_date_time" field.</summary>
    public const int StartDateTimeFieldNumber = 5;
    private string startDateTime_ = "";
    /// <summary>
    /// Required. The inclusive start time of the data exclusion in yyyy-MM-dd
    /// HH:mm:ss format.
    ///
    /// A data exclusion is backward looking and should be used for events that
    /// start in the past and end either in the past or future.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDateTime {
      get { return startDateTime_; }
      set {
        startDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_date_time" field.</summary>
    public const int EndDateTimeFieldNumber = 6;
    private string endDateTime_ = "";
    /// <summary>
    /// Required. The exclusive end time of the data exclusion in yyyy-MM-dd
    /// HH:mm:ss format.
    ///
    /// The length of [start_date_time, end_date_time) interval must be
    /// within (0, 14 days].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDateTime {
      get { return endDateTime_; }
      set {
        endDateTime_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 7;
    private string name_ = "";
    /// <summary>
    /// The name of the data exclusion. The name can be at most 255
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 8;
    private string description_ = "";
    /// <summary>
    /// The description of the data exclusion. The description can be at
    /// most 2048 characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "devices" field.</summary>
    public const int DevicesFieldNumber = 9;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V20.Enums.DeviceEnum.Types.Device> _repeated_devices_codec
        = pb::FieldCodec.ForEnum(74, x => (int) x, x => (global::Google.Ads.GoogleAds.V20.Enums.DeviceEnum.Types.Device) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.DeviceEnum.Types.Device> devices_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.DeviceEnum.Types.Device>();
    /// <summary>
    /// If not specified, all devices will be included in this exclusion.
    /// Otherwise, only the specified targeted devices will be included in this
    /// exclusion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.DeviceEnum.Types.Device> Devices {
      get { return devices_; }
    }

    /// <summary>Field number for the "campaigns" field.</summary>
    public const int CampaignsFieldNumber = 10;
    private static readonly pb::FieldCodec<string> _repeated_campaigns_codec
        = pb::FieldCodec.ForString(82);
    private readonly pbc::RepeatedField<string> campaigns_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The data exclusion will apply to the campaigns listed when the scope of
    /// this exclusion is CAMPAIGN. The maximum number of campaigns per event is
    /// 2000.
    /// Note: a data exclusion with both advertising_channel_types and
    /// campaign_ids is not supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Campaigns {
      get { return campaigns_; }
    }

    /// <summary>Field number for the "advertising_channel_types" field.</summary>
    public const int AdvertisingChannelTypesFieldNumber = 11;
    private static readonly pb::FieldCodec<global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> _repeated_advertisingChannelTypes_codec
        = pb::FieldCodec.ForEnum(90, x => (int) x, x => (global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType) x);
    private readonly pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> advertisingChannelTypes_ = new pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType>();
    /// <summary>
    /// The data_exclusion will apply to all the campaigns under the listed
    /// channels retroactively as well as going forward when the scope of this
    /// exclusion is CHANNEL.
    /// The supported advertising channel types are DISPLAY, SEARCH and SHOPPING.
    /// Note: a data exclusion with both advertising_channel_types and
    /// campaign_ids is not supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.GoogleAds.V20.Enums.AdvertisingChannelTypeEnum.Types.AdvertisingChannelType> AdvertisingChannelTypes {
      get { return advertisingChannelTypes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BiddingDataExclusion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BiddingDataExclusion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (DataExclusionId != other.DataExclusionId) return false;
      if (Scope != other.Scope) return false;
      if (Status != other.Status) return false;
      if (StartDateTime != other.StartDateTime) return false;
      if (EndDateTime != other.EndDateTime) return false;
      if (Name != other.Name) return false;
      if (Description != other.Description) return false;
      if(!devices_.Equals(other.devices_)) return false;
      if(!campaigns_.Equals(other.campaigns_)) return false;
      if(!advertisingChannelTypes_.Equals(other.advertisingChannelTypes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (DataExclusionId != 0L) hash ^= DataExclusionId.GetHashCode();
      if (Scope != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) hash ^= Scope.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) hash ^= Status.GetHashCode();
      if (StartDateTime.Length != 0) hash ^= StartDateTime.GetHashCode();
      if (EndDateTime.Length != 0) hash ^= EndDateTime.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      hash ^= devices_.GetHashCode();
      hash ^= campaigns_.GetHashCode();
      hash ^= advertisingChannelTypes_.GetHashCode();
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
      if (DataExclusionId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(DataExclusionId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (StartDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDateTime);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      devices_.WriteTo(output, _repeated_devices_codec);
      campaigns_.WriteTo(output, _repeated_campaigns_codec);
      advertisingChannelTypes_.WriteTo(output, _repeated_advertisingChannelTypes_codec);
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
      if (DataExclusionId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(DataExclusionId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Status);
      }
      if (StartDateTime.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDateTime);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Name);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Description);
      }
      devices_.WriteTo(ref output, _repeated_devices_codec);
      campaigns_.WriteTo(ref output, _repeated_campaigns_codec);
      advertisingChannelTypes_.WriteTo(ref output, _repeated_advertisingChannelTypes_codec);
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
      if (DataExclusionId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(DataExclusionId);
      }
      if (Scope != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scope);
      }
      if (Status != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (StartDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDateTime);
      }
      if (EndDateTime.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDateTime);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      size += devices_.CalculateSize(_repeated_devices_codec);
      size += campaigns_.CalculateSize(_repeated_campaigns_codec);
      size += advertisingChannelTypes_.CalculateSize(_repeated_advertisingChannelTypes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BiddingDataExclusion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.DataExclusionId != 0L) {
        DataExclusionId = other.DataExclusionId;
      }
      if (other.Scope != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope.Unspecified) {
        Scope = other.Scope;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus.Unspecified) {
        Status = other.Status;
      }
      if (other.StartDateTime.Length != 0) {
        StartDateTime = other.StartDateTime;
      }
      if (other.EndDateTime.Length != 0) {
        EndDateTime = other.EndDateTime;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      devices_.Add(other.devices_);
      campaigns_.Add(other.campaigns_);
      advertisingChannelTypes_.Add(other.advertisingChannelTypes_);
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
          case 16: {
            DataExclusionId = input.ReadInt64();
            break;
          }
          case 24: {
            Scope = (global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus) input.ReadEnum();
            break;
          }
          case 42: {
            StartDateTime = input.ReadString();
            break;
          }
          case 50: {
            EndDateTime = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74:
          case 72: {
            devices_.AddEntriesFrom(input, _repeated_devices_codec);
            break;
          }
          case 82: {
            campaigns_.AddEntriesFrom(input, _repeated_campaigns_codec);
            break;
          }
          case 90:
          case 88: {
            advertisingChannelTypes_.AddEntriesFrom(input, _repeated_advertisingChannelTypes_codec);
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
          case 16: {
            DataExclusionId = input.ReadInt64();
            break;
          }
          case 24: {
            Scope = (global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventScopeEnum.Types.SeasonalityEventScope) input.ReadEnum();
            break;
          }
          case 32: {
            Status = (global::Google.Ads.GoogleAds.V20.Enums.SeasonalityEventStatusEnum.Types.SeasonalityEventStatus) input.ReadEnum();
            break;
          }
          case 42: {
            StartDateTime = input.ReadString();
            break;
          }
          case 50: {
            EndDateTime = input.ReadString();
            break;
          }
          case 58: {
            Name = input.ReadString();
            break;
          }
          case 66: {
            Description = input.ReadString();
            break;
          }
          case 74:
          case 72: {
            devices_.AddEntriesFrom(ref input, _repeated_devices_codec);
            break;
          }
          case 82: {
            campaigns_.AddEntriesFrom(ref input, _repeated_campaigns_codec);
            break;
          }
          case 90:
          case 88: {
            advertisingChannelTypes_.AddEntriesFrom(ref input, _repeated_advertisingChannelTypes_codec);
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
