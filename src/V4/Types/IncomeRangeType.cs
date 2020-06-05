// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/income_range_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/income_range_type.proto</summary>
  public static partial class IncomeRangeTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/income_range_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IncomeRangeTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9pbmNvbWVfcmFuZ2Vf",
            "dHlwZS5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZW51bXMaHGdv",
            "b2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8igwIKE0luY29tZVJhbmdlVHlw",
            "ZUVudW0i6wEKD0luY29tZVJhbmdlVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIXChFJTkNPTUVfUkFOR0VfMF81MBCxkB8SGAoSSU5DT01F",
            "X1JBTkdFXzUwXzYwELKQHxIYChJJTkNPTUVfUkFOR0VfNjBfNzAQs5AfEhgK",
            "EklOQ09NRV9SQU5HRV83MF84MBC0kB8SGAoSSU5DT01FX1JBTkdFXzgwXzkw",
            "ELWQHxIYChJJTkNPTUVfUkFOR0VfOTBfVVAQtpAfEh8KGUlOQ09NRV9SQU5H",
            "RV9VTkRFVEVSTUlORUQQsJAfQukBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjQuZW51bXNCFEluY29tZVJhbmdlVHlwZVByb3RvUAFaQmdvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "NC9lbnVtcztlbnVtc6ICA0dBQaoCHUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY0",
            "LkVudW1zygIdR29vZ2xlXEFkc1xHb29nbGVBZHNcVjRcRW51bXPqAiFHb29n",
            "bGU6OkFkczo6R29vZ2xlQWRzOjpWNDo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.IncomeRangeTypeEnum), global::Google.Ads.GoogleAds.V4.Enums.IncomeRangeTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.IncomeRangeTypeEnum.Types.IncomeRangeType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the type of demographic income ranges.
  /// </summary>
  public sealed partial class IncomeRangeTypeEnum : pb::IMessage<IncomeRangeTypeEnum> {
    private static readonly pb::MessageParser<IncomeRangeTypeEnum> _parser = new pb::MessageParser<IncomeRangeTypeEnum>(() => new IncomeRangeTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IncomeRangeTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.IncomeRangeTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncomeRangeTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncomeRangeTypeEnum(IncomeRangeTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IncomeRangeTypeEnum Clone() {
      return new IncomeRangeTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IncomeRangeTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IncomeRangeTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IncomeRangeTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the IncomeRangeTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The type of demographic income ranges (e.g. between 0% to 50%).
      /// </summary>
      public enum IncomeRangeType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// 0%-50%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_0_50")] IncomeRange050 = 510001,
        /// <summary>
        /// 50% to 60%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_50_60")] IncomeRange5060 = 510002,
        /// <summary>
        /// 60% to 70%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_60_70")] IncomeRange6070 = 510003,
        /// <summary>
        /// 70% to 80%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_70_80")] IncomeRange7080 = 510004,
        /// <summary>
        /// 80% to 90%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_80_90")] IncomeRange8090 = 510005,
        /// <summary>
        /// Greater than 90%.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_90_UP")] IncomeRange90Up = 510006,
        /// <summary>
        /// Undetermined income range.
        /// </summary>
        [pbr::OriginalName("INCOME_RANGE_UNDETERMINED")] IncomeRangeUndetermined = 510000,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
