// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/bidding_strategy_simulation.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/bidding_strategy_simulation.proto</summary>
  public static partial class BiddingStrategySimulationReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/bidding_strategy_simulation.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BiddingStrategySimulationReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvYmlkZGluZ19z",
            "dHJhdGVneV9zaW11bGF0aW9uLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Ny5yZXNvdXJjZXMaL2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L2NvbW1v",
            "bi9zaW11bGF0aW9uLnByb3RvGkJnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9l",
            "bnVtcy9zaW11bGF0aW9uX21vZGlmaWNhdGlvbl9tZXRob2QucHJvdG8aM2dv",
            "b2dsZS9hZHMvZ29vZ2xlYWRzL3Y3L2VudW1zL3NpbXVsYXRpb25fdHlwZS5w",
            "cm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xl",
            "L2FwaS9yZXNvdXJjZS5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5w",
            "cm90byKnBgoZQmlkZGluZ1N0cmF0ZWd5U2ltdWxhdGlvbhJRCg1yZXNvdXJj",
            "ZV9uYW1lGAEgASgJQjrgQQP6QTQKMmdvb2dsZWFkcy5nb29nbGVhcGlzLmNv",
            "bS9CaWRkaW5nU3RyYXRlZ3lTaW11bGF0aW9uEiAKE2JpZGRpbmdfc3RyYXRl",
            "Z3lfaWQYAiABKANCA+BBAxJTCgR0eXBlGAMgASgOMkAuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjcuZW51bXMuU2ltdWxhdGlvblR5cGVFbnVtLlNpbXVsYXRp",
            "b25UeXBlQgPgQQMSfgoTbW9kaWZpY2F0aW9uX21ldGhvZBgEIAEoDjJcLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmVudW1zLlNpbXVsYXRpb25Nb2RpZmlj",
            "YXRpb25NZXRob2RFbnVtLlNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2RC",
            "A+BBAxIXCgpzdGFydF9kYXRlGAUgASgJQgPgQQMSFQoIZW5kX2RhdGUYBiAB",
            "KAlCA+BBAxJiChV0YXJnZXRfY3BhX3BvaW50X2xpc3QYByABKAsyPC5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52Ny5jb21tb24uVGFyZ2V0Q3BhU2ltdWxhdGlv",
            "blBvaW50TGlzdEID4EEDSAASZAoWdGFyZ2V0X3JvYXNfcG9pbnRfbGlzdBgI",
            "IAEoCzI9Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LmNvbW1vbi5UYXJnZXRS",
            "b2FzU2ltdWxhdGlvblBvaW50TGlzdEID4EEDSAA6twHqQbMBCjJnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vQmlkZGluZ1N0cmF0ZWd5U2ltdWxhdGlvbhJ9",
            "Y3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vYmlkZGluZ1N0cmF0ZWd5U2ltdWxh",
            "dGlvbnMve2JpZGRpbmdfc3RyYXRlZ3lfaWR9fnt0eXBlfX57bW9kaWZpY2F0",
            "aW9uX21ldGhvZH1+e3N0YXJ0X2RhdGV9fntlbmRfZGF0ZX1CDAoKcG9pbnRf",
            "bGlzdEKLAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291cmNl",
            "c0IeQmlkZGluZ1N0cmF0ZWd5U2ltdWxhdGlvblByb3RvUAFaSmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "Ny9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29n",
            "bGVBZHMuVjcuUmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjdc",
            "UmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjc6OlJlc291",
            "cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Common.SimulationReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodReflection.Descriptor, global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.BiddingStrategySimulation), global::Google.Ads.GoogleAds.V7.Resources.BiddingStrategySimulation.Parser, new[]{ "ResourceName", "BiddingStrategyId", "Type", "ModificationMethod", "StartDate", "EndDate", "TargetCpaPointList", "TargetRoasPointList" }, new[]{ "PointList" }, null, null, null)
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
  public sealed partial class BiddingStrategySimulation : pb::IMessage<BiddingStrategySimulation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BiddingStrategySimulation> _parser = new pb::MessageParser<BiddingStrategySimulation>(() => new BiddingStrategySimulation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BiddingStrategySimulation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.BiddingStrategySimulationReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BiddingStrategySimulation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public long BiddingStrategyId {
      get { return biddingStrategyId_; }
      set {
        biddingStrategyId_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType type_ = global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified;
    /// <summary>
    /// Output only. The field that the simulation modifies.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList TargetCpaPointList {
      get { return pointListCase_ == PointListOneofCase.TargetCpaPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList) pointList_ : null; }
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
    public global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList TargetRoasPointList {
      get { return pointListCase_ == PointListOneofCase.TargetRoasPointList ? (global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList) pointList_ : null; }
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
      return Equals(other as BiddingStrategySimulation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (BiddingStrategyId != 0L) hash ^= BiddingStrategyId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V7.Enums.SimulationTypeEnum.Types.SimulationType.Unspecified) hash ^= Type.GetHashCode();
      if (ModificationMethod != global::Google.Ads.GoogleAds.V7.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod.Unspecified) hash ^= ModificationMethod.GetHashCode();
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
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (BiddingStrategyId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(BiddingStrategyId);
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
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (BiddingStrategyId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(BiddingStrategyId);
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
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
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
            global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetCpaSimulationPointList();
            if (pointListCase_ == PointListOneofCase.TargetCpaPointList) {
              subBuilder.MergeFrom(TargetCpaPointList);
            }
            input.ReadMessage(subBuilder);
            TargetCpaPointList = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList subBuilder = new global::Google.Ads.GoogleAds.V7.Common.TargetRoasSimulationPointList();
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
