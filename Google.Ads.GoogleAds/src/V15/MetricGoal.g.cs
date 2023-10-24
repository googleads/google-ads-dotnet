// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/common/metric_goal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/common/metric_goal.proto</summary>
  public static partial class MetricGoalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/common/metric_goal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetricGoalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvY29tbW9uL21ldHJpY19nb2Fs",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUuY29tbW9uGjZnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvZXhwZXJpbWVudF9tZXRyaWMu",
            "cHJvdG8aQGdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxNS9lbnVtcy9leHBlcmlt",
            "ZW50X21ldHJpY19kaXJlY3Rpb24ucHJvdG8izwEKCk1ldHJpY0dvYWwSVQoG",
            "bWV0cmljGAEgASgOMkUuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LmVudW1z",
            "LkV4cGVyaW1lbnRNZXRyaWNFbnVtLkV4cGVyaW1lbnRNZXRyaWMSagoJZGly",
            "ZWN0aW9uGAIgASgOMlcuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjE1LmVudW1z",
            "LkV4cGVyaW1lbnRNZXRyaWNEaXJlY3Rpb25FbnVtLkV4cGVyaW1lbnRNZXRy",
            "aWNEaXJlY3Rpb25C7wEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTUu",
            "Y29tbW9uQg9NZXRyaWNHb2FsUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxNS9jb21tb247",
            "Y29tbW9uogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjE1LkNvbW1v",
            "bsoCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNVxDb21tb27qAiNHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWMTU6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricReflection.Descriptor, global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Common.MetricGoal), global::Google.Ads.GoogleAds.V15.Common.MetricGoal.Parser, new[]{ "Metric", "Direction" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A metric goal for an experiment.
  /// </summary>
  public sealed partial class MetricGoal : pb::IMessage<MetricGoal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MetricGoal> _parser = new pb::MessageParser<MetricGoal>(() => new MetricGoal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MetricGoal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Common.MetricGoalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetricGoal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetricGoal(MetricGoal other) : this() {
      metric_ = other.metric_;
      direction_ = other.direction_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MetricGoal Clone() {
      return new MetricGoal(this);
    }

    /// <summary>Field number for the "metric" field.</summary>
    public const int MetricFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric metric_ = global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified;
    /// <summary>
    /// The metric of the goal. For example, clicks, impressions, cost,
    /// conversions, etc.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric Metric {
      get { return metric_; }
      set {
        metric_ = value;
      }
    }

    /// <summary>Field number for the "direction" field.</summary>
    public const int DirectionFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection direction_ = global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified;
    /// <summary>
    /// The metric direction of the goal. For example, increase, decrease, no
    /// change.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection Direction {
      get { return direction_; }
      set {
        direction_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MetricGoal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MetricGoal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Metric != other.Metric) return false;
      if (Direction != other.Direction) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Metric != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified) hash ^= Metric.GetHashCode();
      if (Direction != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified) hash ^= Direction.GetHashCode();
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
      if (Metric != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Metric);
      }
      if (Direction != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Direction);
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
      if (Metric != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Metric);
      }
      if (Direction != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Direction);
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
      if (Metric != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Metric);
      }
      if (Direction != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Direction);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MetricGoal other) {
      if (other == null) {
        return;
      }
      if (other.Metric != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric.Unspecified) {
        Metric = other.Metric;
      }
      if (other.Direction != global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection.Unspecified) {
        Direction = other.Direction;
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
            Metric = (global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric) input.ReadEnum();
            break;
          }
          case 16: {
            Direction = (global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection) input.ReadEnum();
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
            Metric = (global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricEnum.Types.ExperimentMetric) input.ReadEnum();
            break;
          }
          case 16: {
            Direction = (global::Google.Ads.GoogleAds.V15.Enums.ExperimentMetricDirectionEnum.Types.ExperimentMetricDirection) input.ReadEnum();
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
