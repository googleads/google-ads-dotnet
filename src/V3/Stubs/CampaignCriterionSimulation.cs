// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/campaign_criterion_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/campaign_criterion_simulation.proto</summary>
  public static partial class CampaignCriterionSimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/campaign_criterion_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignCriterionSimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "Y3JpdGVyaW9uX3NpbXVsYXRpb24ucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYzLnJlc291cmNlcxovZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvY29t",
            "bW9uL3NpbXVsYXRpb24ucHJvdG8aQmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Yz",
            "L2VudW1zL3NpbXVsYXRpb25fbW9kaWZpY2F0aW9uX21ldGhvZC5wcm90bxoz",
            "Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvZW51bXMvc2ltdWxhdGlvbl90eXBl",
            "LnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29n",
            "bGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29nbGUvcHJvdG9idWYvd3JhcHBl",
            "cnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iqAYKG0Nh",
            "bXBhaWduQ3JpdGVyaW9uU2ltdWxhdGlvbhJTCg1yZXNvdXJjZV9uYW1lGAEg",
            "ASgJQjzgQQP6QTYKNGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWln",
            "bkNyaXRlcmlvblNpbXVsYXRpb24SNQoLY2FtcGFpZ25faWQYAiABKAsyGy5n",
            "b29nbGUucHJvdG9idWYuSW50NjRWYWx1ZUID4EEDEjYKDGNyaXRlcmlvbl9p",
            "ZBgDIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQMSUwoE",
            "dHlwZRgEIAEoDjJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zLlNp",
            "bXVsYXRpb25UeXBlRW51bS5TaW11bGF0aW9uVHlwZUID4EEDEn4KE21vZGlm",
            "aWNhdGlvbl9tZXRob2QYBSABKA4yXC5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "My5lbnVtcy5TaW11bGF0aW9uTW9kaWZpY2F0aW9uTWV0aG9kRW51bS5TaW11",
            "bGF0aW9uTW9kaWZpY2F0aW9uTWV0aG9kQgPgQQMSNQoKc3RhcnRfZGF0ZRgG",
            "IAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEjMKCGVu",
            "ZF9kYXRlGAcgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQgPg",
            "QQMSZgoXYmlkX21vZGlmaWVyX3BvaW50X2xpc3QYCCABKAsyPi5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52My5jb21tb24uQmlkTW9kaWZpZXJTaW11bGF0aW9u",
            "UG9pbnRMaXN0QgPgQQNIADqNAepBiQEKNGdvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9DYW1wYWlnbkNyaXRlcmlvblNpbXVsYXRpb24SUWN1c3RvbWVycy97",
            "Y3VzdG9tZXJ9L2NhbXBhaWduQ3JpdGVyaW9uU2ltdWxhdGlvbnMve2NhbXBh",
            "aWduX2NyaXRlcmlvbl9zaW11bGF0aW9ufUIMCgpwb2ludF9saXN0Qo0CCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVzb3VyY2VzQiBDYW1wYWln",
            "bkNyaXRlcmlvblNpbXVsYXRpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvcmVzb3Vy",
            "Y2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlYz",
            "LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFJlc291cmNl",
            "c+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpSZXNvdXJjZXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CampaignCriterionSimulation), global::Google.Ads.GoogleAds.V3.Resources.CampaignCriterionSimulation.Parser, new[]{ "ResourceName", "CampaignId", "CriterionId", "Type", "ModificationMethod", "StartDate", "EndDate", "BidModifierPointList" }, new[]{ "PointList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign criterion simulation. Supported combinations of advertising
  /// channel type, criterion ids, simulation type and simulation modification
  /// method is detailed below respectively.
  ///
  /// 1. SEARCH - 30000,30001,30002 - BID_MODIFIER - UNIFORM
  /// 2. SHOPPING - 30000,30001,30002 - BID_MODIFIER - UNIFORM
  /// 3. DISPLAY - 30001 - BID_MODIFIER - UNIFORM
  /// </summary>
  public sealed partial class CampaignCriterionSimulation : pb::IMessage<CampaignCriterionSimulation> {
    private static readonly pb::MessageParser<CampaignCriterionSimulation> _parser = new pb::MessageParser<CampaignCriterionSimulation>(() => new CampaignCriterionSimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CampaignCriterionSimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CampaignCriterionSimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionSimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionSimulation(CampaignCriterionSimulation other) : this() {
      resourceName_ = other.resourceName_;
      CampaignId = other.CampaignId;
      CriterionId = other.CriterionId;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      StartDate = other.StartDate;
      EndDate = other.EndDate;
      switch (other.PointListCase) {
        case PointListOneofCase.BidModifierPointList:
          BidModifierPointList = other.BidModifierPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CampaignCriterionSimulation Clone() {
      return new CampaignCriterionSimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the campaign criterion simulation.
    /// Campaign criterion simulation resource names have the form:
    ///
    /// `customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_campaignId_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? campaignId_;
    /// <summary>
    /// Output only. Campaign ID of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CampaignId {
      get { return campaignId_; }
      set {
        campaignId_ = value;
      }
    }


    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_criterionId_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? criterionId_;
    /// <summary>
    /// Output only. Criterion ID of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CriterionId {
      get { return criterionId_; }
      set {
        criterionId_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified;
    /// <summary>
    /// Output only. How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_startDate_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string startDate_;
    /// <summary>
    /// Output only. First day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StartDate {
      get { return startDate_; }
      set {
        startDate_ = value;
      }
    }


    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _single_endDate_codec = pb::FieldCodec.ForClassWrapper<string>(58);
    private string endDate_;
    /// <summary>
    /// Output only. Last day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = value;
      }
    }


    /// <summary>Field number for the "bid_modifier_point_list" field.</summary>
    public const int BidModifierPointListFieldNumber = 8;
    /// <summary>
    /// Output only. Simulation points if the simulation type is BID_MODIFIER.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.BidModifierSimulationPointList BidModifierPointList {
      get { return pointListCase_ == PointListOneofCase.BidModifierPointList ? (global::Google.Ads.GoogleAds.V3.Common.BidModifierSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.BidModifierPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      BidModifierPointList = 8,
    }
    private PointListOneofCase pointListCase_ = PointListOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PointListOneofCase PointListCase {
      get { return pointListCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearPointList() {
      pointListCase_ = PointListOneofCase.None;
      pointList_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CampaignCriterionSimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CampaignCriterionSimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CampaignId != other.CampaignId) return false;
      if (CriterionId != other.CriterionId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(BidModifierPointList, other.BidModifierPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (campaignId_ != null) hash ^= CampaignId.GetHashCode();
      if (criterionId_ != null) hash ^= CriterionId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
      if (startDate_ != null) hash ^= StartDate.GetHashCode();
      if (endDate_ != null) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.BidModifierPointList) hash ^= BidModifierPointList.GetHashCode();
      hash ^= (int) pointListCase_;
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
      if (campaignId_ != null) {
        _single_campaignId_codec.WriteTagAndValue(output, CampaignId);
      }
      if (criterionId_ != null) {
        _single_criterionId_codec.WriteTagAndValue(output, CriterionId);
      }
      if (Type != global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) ModificationMethod);
      }
      if (startDate_ != null) {
        _single_startDate_codec.WriteTagAndValue(output, StartDate);
      }
      if (endDate_ != null) {
        _single_endDate_codec.WriteTagAndValue(output, EndDate);
      }
      if (pointListCase_ == PointListOneofCase.BidModifierPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(BidModifierPointList);
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
      if (campaignId_ != null) {
        size += _single_campaignId_codec.CalculateSizeWithTag(CampaignId);
      }
      if (criterionId_ != null) {
        size += _single_criterionId_codec.CalculateSizeWithTag(CriterionId);
      }
      if (Type != global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (startDate_ != null) {
        size += _single_startDate_codec.CalculateSizeWithTag(StartDate);
      }
      if (endDate_ != null) {
        size += _single_endDate_codec.CalculateSizeWithTag(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.BidModifierPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BidModifierPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CampaignCriterionSimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.campaignId_ != null) {
        if (campaignId_ == null || other.CampaignId != 0L) {
          CampaignId = other.CampaignId;
        }
      }
      if (other.criterionId_ != null) {
        if (criterionId_ == null || other.CriterionId != 0L) {
          CriterionId = other.CriterionId;
        }
      }
      if (other.Type != global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        Type = other.Type;
      }
      if (other.ModificationMethod != global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.startDate_ != null) {
        if (startDate_ == null || other.StartDate != "") {
          StartDate = other.StartDate;
        }
      }
      if (other.endDate_ != null) {
        if (endDate_ == null || other.EndDate != "") {
          EndDate = other.EndDate;
        }
      }
      switch (other.PointListCase) {
        case PointListOneofCase.BidModifierPointList:
          if (BidModifierPointList == null) {
            BidModifierPointList = new global::Google.Ads.GoogleAds.V3.Common.BidModifierSimulationPointList();
          }
          BidModifierPointList.MergeFrom(other.BidModifierPointList);
          break;
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
            long? value = _single_campaignId_codec.Read(input);
            if (campaignId_ == null || value != 0L) {
              CampaignId = value;
            }
            break;
          }
          case 26: {
            long? value = _single_criterionId_codec.Read(input);
            if (criterionId_ == null || value != 0L) {
              CriterionId = value;
            }
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V3.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 40: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V3.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 50: {
            string value = _single_startDate_codec.Read(input);
            if (startDate_ == null || value != "") {
              StartDate = value;
            }
            break;
          }
          case 58: {
            string value = _single_endDate_codec.Read(input);
            if (endDate_ == null || value != "") {
              EndDate = value;
            }
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V3.Common.BidModifierSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V3.Common.BidModifierSimulationPointList();
            if (pointListCase_ == PointListOneofCase.BidModifierPointList) {
              subBuilder.MergeFrom(BidModifierPointList);
            }
            input.ReadMessage(subBuilder);
            BidModifierPointList = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
