// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/campaign_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/campaign_simulation.proto</summary>
  public static partial class CampaignSimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/campaign_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignSimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvY2FtcGFpZ25f",
            "c2ltdWxhdGlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVz",
            "b3VyY2VzGi9nb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9jb21tb24vc2ltdWxh",
            "dGlvbi5wcm90bxpCZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvc2lt",
            "dWxhdGlvbl9tb2RpZmljYXRpb25fbWV0aG9kLnByb3RvGjNnb29nbGUvYWRz",
            "L2dvb2dsZWFkcy92Ny9lbnVtcy9zaW11bGF0aW9uX3R5cGUucHJvdG8aH2dv",
            "b2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVz",
            "b3VyY2UucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iswgK",
            "EkNhbXBhaWduU2ltdWxhdGlvbhJKCg1yZXNvdXJjZV9uYW1lGAEgASgJQjPg",
            "QQP6QS0KK2dvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9DYW1wYWlnblNpbXVs",
            "YXRpb24SGAoLY2FtcGFpZ25faWQYAiABKANCA+BBAxJTCgR0eXBlGAMgASgO",
            "MkAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZW51bXMuU2ltdWxhdGlvblR5",
            "cGVFbnVtLlNpbXVsYXRpb25UeXBlQgPgQQMSfgoTbW9kaWZpY2F0aW9uX21l",
            "dGhvZBgEIAEoDjJcLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1zLlNp",
            "bXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2RFbnVtLlNpbXVsYXRpb25Nb2Rp",
            "ZmljYXRpb25NZXRob2RCA+BBAxIXCgpzdGFydF9kYXRlGAUgASgJQgPgQQMS",
            "FQoIZW5kX2RhdGUYBiABKAlCA+BBAxJcChJjcGNfYmlkX3BvaW50X2xpc3QY",
            "ByABKAsyOS5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5jb21tb24uQ3BjQmlk",
            "U2ltdWxhdGlvblBvaW50TGlzdEID4EEDSAASYgoVdGFyZ2V0X2NwYV9wb2lu",
            "dF9saXN0GAggASgLMjwuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuY29tbW9u",
            "LlRhcmdldENwYVNpbXVsYXRpb25Qb2ludExpc3RCA+BBA0gAEmQKFnRhcmdl",
            "dF9yb2FzX3BvaW50X2xpc3QYCSABKAsyPS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Ny5jb21tb24uVGFyZ2V0Um9hc1NpbXVsYXRpb25Qb2ludExpc3RCA+BB",
            "A0gAEnsKInRhcmdldF9pbXByZXNzaW9uX3NoYXJlX3BvaW50X2xpc3QYCiAB",
            "KAsySC5nb29nbGUuYWRzLmdvb2dsZWFkcy52Ny5jb21tb24uVGFyZ2V0SW1w",
            "cmVzc2lvblNoYXJlU2ltdWxhdGlvblBvaW50TGlzdEID4EEDSAASWwoRYnVk",
            "Z2V0X3BvaW50X2xpc3QYCyABKAsyOS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "Ny5jb21tb24uQnVkZ2V0U2ltdWxhdGlvblBvaW50TGlzdEID4EEDSAA6oQHq",
            "QZ0BCitnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ2FtcGFpZ25TaW11bGF0",
            "aW9uEm5jdXN0b21lcnMve2N1c3RvbWVyX2lkfS9jYW1wYWlnblNpbXVsYXRp",
            "b25zL3tjYW1wYWlnbl9pZH1+e3R5cGV9fnttb2RpZmljYXRpb25fbWV0aG9k",
            "fX57c3RhcnRfZGF0ZX1+e2VuZF9kYXRlfUIMCgpwb2ludF9saXN0QoQCCiVj",
            "b20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcucmVzb3VyY2VzQhdDYW1wYWln",
            "blNpbXVsYXRpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90",
            "by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjcvcmVzb3VyY2VzO3Jlc291",
            "cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY3LlJlc291cmNl",
            "c8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY3XFJlc291cmNlc+oCJUdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlY3OjpSZXNvdXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.CampaignSimulation), global::Google.Ads.GoogleAds.V7.Resources.CampaignSimulation.Parser, new[]{ "ResourceName", "CampaignId", "Type", "ModificationMethod", "StartDate", "EndDate", "CpcBidPointList", "TargetCpaPointList", "TargetRoasPointList", "TargetImpressionSharePointList", "BudgetPointList" }, new[]{ "PointList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A campaign simulation. Supported combinations of advertising
  /// channel type, simulation type and simulation modification
  /// method is detailed below respectively.
  ///
  /// SEARCH - CPC_BID - UNIFORM
  /// SEARCH - CPC_BID - SCALING
  /// SEARCH - TARGET_CPA - UNIFORM
  /// SEARCH - TARGET_CPA - SCALING
  /// SEARCH - TARGET_ROAS - UNIFORM
  /// SEARCH - TARGET_IMPRESSION_SHARE - UNIFORM
  /// SEARCH - BUDGET - UNIFORM
  /// SHOPPING - BUDGET - UNIFORM
  /// SHOPPING - TARGET_ROAS - UNIFORM
  /// MULTIPLE - TARGET_CPA - UNIFORM
  /// OWNED_AND_OPERATED - TARGET_CPA - DEFAULT
  /// DISPLAY - TARGET_CPA - UNIFORM
  /// </summary>
  public sealed partial class CampaignSimulation : pb::IMessage<CampaignSimulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignSimulation> _parser = new pb::MessageParser<CampaignSimulation>(() => new CampaignSimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignSimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.CampaignSimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation(CampaignSimulation other) : this() {
      resourceName_ = other.resourceName_;
      campaignId_ = other.campaignId_;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          CpcBidPointList = other.CpcBidPointList.Clone();
          break;
        case PointListOneofCase.TargetCpaPointList:
          TargetCpaPointList = other.TargetCpaPointList.Clone();
          break;
        case PointListOneofCase.TargetRoasPointList:
          TargetRoasPointList = other.TargetRoasPointList.Clone();
          break;
        case PointListOneofCase.TargetImpressionSharePointList:
          TargetImpressionSharePointList = other.TargetImpressionSharePointList.Clone();
          break;
        case PointListOneofCase.BudgetPointList:
          BudgetPointList = other.BudgetPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignSimulation Clone() {
      return new CampaignSimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the campaign simulation.
    /// Campaign simulation resource names have the form:
    ///
    /// `customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "campaign_id" field.</summary>
    public const int CampaignIdFieldNumber = 2;
    private long campaignId_;
    /// <summary>
    /// Output only. Campaign id of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CampaignId {
      get { return campaignId_; }
      set {
        campaignId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified;
    /// <summary>
    /// Output only. How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 5;
    private string startDate_ = "";
    /// <summary>
    /// Output only. First day on which the simulation is based, in YYYY-MM-DD format.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDate {
      get { return startDate_; }
      set {
        startDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 6;
    private string endDate_ = "";
    /// <summary>
    /// Output only. Last day on which the simulation is based, in YYYY-MM-DD format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "cpc_bid_point_list" field.</summary>
    public const int CpcBidPointListFieldNumber = 7;
    /// <summary>
    /// Output only. Simulation points if the simulation type is CPC_BID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList CpcBidPointList {
      get { return pointListCase_ == PointListOneofCase.CpcBidPointList ? (global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.CpcBidPointList;
      }
    }

    /// <summary>Field number for the "target_cpa_point_list" field.</summary>
    public const int TargetCpaPointListFieldNumber = 8;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_CPA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetCpaPointList;
      }
    }

    /// <summary>Field number for the "target_roas_point_list" field.</summary>
    public const int TargetRoasPointListFieldNumber = 9;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_ROAS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList TargetRoasPointList {
      get { return pointListCase_ == PointListOneofCase.TargetRoasPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetRoasPointList;
      }
    }

    /// <summary>Field number for the "target_impression_share_point_list" field.</summary>
    public const int TargetImpressionSharePointListFieldNumber = 10;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_IMPRESSION_SHARE.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList TargetImpressionSharePointList {
      get { return pointListCase_ == PointListOneofCase.TargetImpressionSharePointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetImpressionSharePointList;
      }
    }

    /// <summary>Field number for the "budget_point_list" field.</summary>
    public const int BudgetPointListFieldNumber = 11;
    /// <summary>
    /// Output only. Simulation points if the simulation type is BUDGET.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList BudgetPointList {
      get { return pointListCase_ == PointListOneofCase.BudgetPointList ? (global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.BudgetPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      CpcBidPointList = 7,
      TargetCpaPointList = 8,
      TargetRoasPointList = 9,
      TargetImpressionSharePointList = 10,
      BudgetPointList = 11,
    }
    private PointListOneofCase pointListCase_ = PointListOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PointListOneofCase PointListCase {
      get { return pointListCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearPointList() {
      pointListCase_ = PointListOneofCase.None;
      pointList_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignSimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignSimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (CampaignId != other.CampaignId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(CpcBidPointList, other.CpcBidPointList)) return false;
      if (!object.Equals(TargetCpaPointList, other.TargetCpaPointList)) return false;
      if (!object.Equals(TargetRoasPointList, other.TargetRoasPointList)) return false;
      if (!object.Equals(TargetImpressionSharePointList, other.TargetImpressionSharePointList)) return false;
      if (!object.Equals(BudgetPointList, other.BudgetPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (CampaignId != 0L) hash ^= CampaignId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
      if (StartDate.Length != 0) hash ^= StartDate.GetHashCode();
      if (EndDate.Length != 0) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) hash ^= CpcBidPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) hash ^= TargetCpaPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) hash ^= TargetRoasPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) hash ^= TargetImpressionSharePointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.BudgetPointList) hash ^= BudgetPointList.GetHashCode();
      hash ^= (int) pointListCase_;
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDate);
      }
      if (EndDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(BudgetPointList);
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
      if (CampaignId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(StartDate);
      }
      if (EndDate.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(74);
        output.WriteMessage(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        output.WriteRawTag(82);
        output.WriteMessage(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        output.WriteRawTag(90);
        output.WriteMessage(BudgetPointList);
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
      if (CampaignId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CampaignId);
      }
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (EndDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CpcBidPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetRoasPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetImpressionSharePointList);
      }
      if (pointListCase_ == PointListOneofCase.BudgetPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BudgetPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignSimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.CampaignId != 0L) {
        CampaignId = other.CampaignId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        Type = other.Type;
      }
      if (other.ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.StartDate.Length != 0) {
        StartDate = other.StartDate;
      }
      if (other.EndDate.Length != 0) {
        EndDate = other.EndDate;
      }
      switch (other.PointListCase) {
        case PointListOneofCase.CpcBidPointList:
          if (CpcBidPointList == null) {
            CpcBidPointList = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
          }
          CpcBidPointList.MergeFrom(other.CpcBidPointList);
          break;
        case PointListOneofCase.TargetCpaPointList:
          if (TargetCpaPointList == null) {
            TargetCpaPointList = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
          }
          TargetCpaPointList.MergeFrom(other.TargetCpaPointList);
          break;
        case PointListOneofCase.TargetRoasPointList:
          if (TargetRoasPointList == null) {
            TargetRoasPointList = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
          }
          TargetRoasPointList.MergeFrom(other.TargetRoasPointList);
          break;
        case PointListOneofCase.TargetImpressionSharePointList:
          if (TargetImpressionSharePointList == null) {
            TargetImpressionSharePointList = new global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList();
          }
          TargetImpressionSharePointList.MergeFrom(other.TargetImpressionSharePointList);
          break;
        case PointListOneofCase.BudgetPointList:
          if (BudgetPointList == null) {
            BudgetPointList = new global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList();
          }
          BudgetPointList.MergeFrom(other.BudgetPointList);
          break;
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
          case 16: {
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 42: {
            StartDate = input.ReadString();
            break;
          }
          case 50: {
            EndDate = input.ReadString();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
              subBuilder.MergeFrom(TargetImpressionSharePointList);
            }
            input.ReadMessage(subBuilder);
            TargetImpressionSharePointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList();
            if (pointListCase_ == PointListOneofCase.BudgetPointList) {
              subBuilder.MergeFrom(BudgetPointList);
            }
            input.ReadMessage(subBuilder);
            BudgetPointList = subBuilder;
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
            CampaignId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
            break;
          }
          case 42: {
            StartDate = input.ReadString();
            break;
          }
          case 50: {
            EndDate = input.ReadString();
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.CpcBidSimulationPointList();
            if (pointListCase_ == PointListOneofCase.CpcBidPointList) {
              subBuilder.MergeFrom(CpcBidPointList);
            }
            input.ReadMessage(subBuilder);
            CpcBidPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetImpressionShareSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetImpressionSharePointList) {
              subBuilder.MergeFrom(TargetImpressionSharePointList);
            }
            input.ReadMessage(subBuilder);
            TargetImpressionSharePointList = subBuilder;
            break;
          }
          case 90: {
            global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.BudgetSimulationPointList();
            if (pointListCase_ == PointListOneofCase.BudgetPointList) {
              subBuilder.MergeFrom(BudgetPointList);
            }
            input.ReadMessage(subBuilder);
            BudgetPointList = subBuilder;
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
