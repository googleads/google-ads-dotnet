// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/bidding_strategy_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/bidding_strategy_simulation.proto</summary>
  public static partial class BiddingStrategySimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/bidding_strategy_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingStrategySimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL2JpZGRpbmdf",
            "c3RyYXRlZ3lfc2ltdWxhdGlvbi5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjIwLnJlc291cmNlcxowZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjIwL2Nv",
            "bW1vbi9zaW11bGF0aW9uLnByb3RvGkNnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "MjAvZW51bXMvc2ltdWxhdGlvbl9tb2RpZmljYXRpb25fbWV0aG9kLnByb3Rv",
            "GjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvc2ltdWxhdGlvbl90",
            "eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhln",
            "b29nbGUvYXBpL3Jlc291cmNlLnByb3RvIqsGChlCaWRkaW5nU3RyYXRlZ3lT",
            "aW11bGF0aW9uElEKDXJlc291cmNlX25hbWUYASABKAlCOuBBA/pBNAoyZ29v",
            "Z2xlYWRzLmdvb2dsZWFwaXMuY29tL0JpZGRpbmdTdHJhdGVneVNpbXVsYXRp",
            "b24SIAoTYmlkZGluZ19zdHJhdGVneV9pZBgCIAEoA0ID4EEDElQKBHR5cGUY",
            "AyABKA4yQS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MjAuZW51bXMuU2ltdWxh",
            "dGlvblR5cGVFbnVtLlNpbXVsYXRpb25UeXBlQgPgQQMSfwoTbW9kaWZpY2F0",
            "aW9uX21ldGhvZBgEIAEoDjJdLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyMC5l",
            "bnVtcy5TaW11bGF0aW9uTW9kaWZpY2F0aW9uTWV0aG9kRW51bS5TaW11bGF0",
            "aW9uTW9kaWZpY2F0aW9uTWV0aG9kQgPgQQMSFwoKc3RhcnRfZGF0ZRgFIAEo",
            "CUID4EEDEhUKCGVuZF9kYXRlGAYgASgJQgPgQQMSYwoVdGFyZ2V0X2NwYV9w",
            "b2ludF9saXN0GAcgASgLMj0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmNv",
            "bW1vbi5UYXJnZXRDcGFTaW11bGF0aW9uUG9pbnRMaXN0QgPgQQNIABJlChZ0",
            "YXJnZXRfcm9hc19wb2ludF9saXN0GAggASgLMj4uZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjIwLmNvbW1vbi5UYXJnZXRSb2FzU2ltdWxhdGlvblBvaW50TGlz",
            "dEID4EEDSAA6twHqQbMBCjJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQmlk",
            "ZGluZ1N0cmF0ZWd5U2ltdWxhdGlvbhJ9Y3VzdG9tZXJzL3tjdXN0b21lcl9p",
            "ZH0vYmlkZGluZ1N0cmF0ZWd5U2ltdWxhdGlvbnMve2JpZGRpbmdfc3RyYXRl",
            "Z3lfaWR9fnt0eXBlfX57bW9kaWZpY2F0aW9uX21ldGhvZH1+e3N0YXJ0X2Rh",
            "dGV9fntlbmRfZGF0ZX1CDAoKcG9pbnRfbGlzdEKQAgomY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYyMC5yZXNvdXJjZXNCHkJpZGRpbmdTdHJhdGVneVNp",
            "bXVsYXRpb25Qcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIwL3Jlc291cmNlcztyZXNvdXJj",
            "ZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMjAuUmVzb3VyY2Vz",
            "ygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjIwXFJlc291cmNlc+oCJkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.BiddingStrategySimulation), global::Google.Ads.GoogleAds.V20.Resources.BiddingStrategySimulation.Parser, new[]{ "ResourceName", "BiddingStrategyId", "Type", "ModificationMethod", "StartDate", "EndDate", "TargetCpaPointList", "TargetRoasPointList" }, new[]{ "PointList" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A bidding strategy simulation. Supported combinations of simulation type
  /// and simulation modification method are detailed below respectively.
  ///
  /// 1. TARGET_CPA - UNIFORM
  /// 2. TARGET_ROAS - UNIFORM
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BiddingStrategySimulation : pb::IMessage<BiddingStrategySimulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingStrategySimulation> _parser = new pb::MessageParser<BiddingStrategySimulation>(() => new BiddingStrategySimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BiddingStrategySimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.BiddingStrategySimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySimulation(BiddingStrategySimulation other) : this() {
      resourceName_ = other.resourceName_;
      biddingStrategyId_ = other.biddingStrategyId_;
      type_ = other.type_;
      modificationMethod_ = other.modificationMethod_;
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      switch (other.PointListCase) {
        case PointListOneofCase.TargetCpaPointList:
          TargetCpaPointList = other.TargetCpaPointList.Clone();
          break;
        case PointListOneofCase.TargetRoasPointList:
          TargetRoasPointList = other.TargetRoasPointList.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BiddingStrategySimulation Clone() {
      return new BiddingStrategySimulation(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the bidding strategy simulation.
    /// Bidding strategy simulation resource names have the form:
    ///
    /// `customers/{customer_id}/biddingStrategySimulations/{bidding_strategy_id}~{type}~{modification_method}~{start_date}~{end_date}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "bidding_strategy_id" field.</summary>
    public const int BiddingStrategyIdFieldNumber = 2;
    private long biddingStrategyId_;
    /// <summary>
    /// Output only. Bidding strategy shared set id of the simulation.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long BiddingStrategyId {
      get { return biddingStrategyId_; }
      set {
        biddingStrategyId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "modification_method" field.</summary>
    public const int ModificationMethodFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod modificationMethod_ = global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified;
    /// <summary>
    /// Output only. How the simulation modifies the field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod ModificationMethod {
      get { return modificationMethod_; }
      set {
        modificationMethod_ = value;
      }
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 5;
    private string startDate_ = "";
    /// <summary>
    /// Output only. First day on which the simulation is based, in YYYY-MM-DD
    /// format.
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
    /// Output only. Last day on which the simulation is based, in YYYY-MM-DD
    /// format
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "target_cpa_point_list" field.</summary>
    public const int TargetCpaPointListFieldNumber = 7;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_CPA.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetCpaPointList;
      }
    }

    /// <summary>Field number for the "target_roas_point_list" field.</summary>
    public const int TargetRoasPointListFieldNumber = 8;
    /// <summary>
    /// Output only. Simulation points if the simulation type is TARGET_ROAS.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList TargetRoasPointList {
      get { return pointListCase_ == PointListOneofCase.TargetRoasPointList ? (global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList) pointList_ : null; }
      set {
        pointList_ = value;
        pointListCase_ = value == null ? PointListOneofCase.None : PointListOneofCase.TargetRoasPointList;
      }
    }

    private object pointList_;
    /// <summary>Enum of possible cases for the "point_list" oneof.</summary>
    public enum PointListOneofCase {
      None = 0,
      TargetCpaPointList = 7,
      TargetRoasPointList = 8,
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
      return Equals(other as BiddingStrategySimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BiddingStrategySimulation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (BiddingStrategyId != other.BiddingStrategyId) return false;
      if (Type != other.Type) return false;
      if (ModificationMethod != other.ModificationMethod) return false;
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      if (!object.Equals(TargetCpaPointList, other.TargetCpaPointList)) return false;
      if (!object.Equals(TargetRoasPointList, other.TargetRoasPointList)) return false;
      if (PointListCase != other.PointListCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (BiddingStrategyId != 0L) hash ^= BiddingStrategyId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
      if (StartDate.Length != 0) hash ^= StartDate.GetHashCode();
      if (EndDate.Length != 0) hash ^= EndDate.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) hash ^= TargetCpaPointList.GetHashCode();
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) hash ^= TargetRoasPointList.GetHashCode();
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
      if (BiddingStrategyId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BiddingStrategyId);
      }
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
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
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetRoasPointList);
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
      if (BiddingStrategyId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BiddingStrategyId);
      }
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
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
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        output.WriteRawTag(58);
        output.WriteMessage(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        output.WriteRawTag(66);
        output.WriteMessage(TargetRoasPointList);
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
      if (BiddingStrategyId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BiddingStrategyId);
      }
      if (Type != global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (ModificationMethod != global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModificationMethod);
      }
      if (StartDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (EndDate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetCpaPointList);
      }
      if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetRoasPointList);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(BiddingStrategySimulation other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.BiddingStrategyId != 0L) {
        BiddingStrategyId = other.BiddingStrategyId;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) {
        Type = other.Type;
      }
      if (other.ModificationMethod != global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) {
        ModificationMethod = other.ModificationMethod;
      }
      if (other.StartDate.Length != 0) {
        StartDate = other.StartDate;
      }
      if (other.EndDate.Length != 0) {
        EndDate = other.EndDate;
      }
      switch (other.PointListCase) {
        case PointListOneofCase.TargetCpaPointList:
          if (TargetCpaPointList == null) {
            TargetCpaPointList = new global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList();
          }
          TargetCpaPointList.MergeFrom(other.TargetCpaPointList);
          break;
        case PointListOneofCase.TargetRoasPointList:
          if (TargetRoasPointList == null) {
            TargetRoasPointList = new global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList();
          }
          TargetRoasPointList.MergeFrom(other.TargetRoasPointList);
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
            BiddingStrategyId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
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
            global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
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
            BiddingStrategyId = input.ReadInt64();
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V20.Enums.SimulationTypeEnum.Types.SimulationType) input.ReadEnum();
            break;
          }
          case 32: {
            ModificationMethod = (global::Google.Ads.GoogleAds.V20.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) input.ReadEnum();
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
            global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V20.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V20.Common.TargetRoasSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetRoasPointList) {
              subBuilder.MergeFrom(TargetRoasPointList);
            }
            input.ReadMessage(subBuilder);
            TargetRoasPointList = subBuilder;
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
