// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/common/dates.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/common/dates.proto</summary>
  public static partial class DatesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/common/dates.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DatesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cipnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vZGF0ZXMucHJvdG8S",
            "Hmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbhoxZ29vZ2xlL2Fkcy9n",
            "b29nbGVhZHMvdjkvZW51bXMvbW9udGhfb2ZfeWVhci5wcm90byJXCglEYXRl",
            "UmFuZ2USFwoKc3RhcnRfZGF0ZRgDIAEoCUgAiAEBEhUKCGVuZF9kYXRlGAQg",
            "ASgJSAGIAQFCDQoLX3N0YXJ0X2RhdGVCCwoJX2VuZF9kYXRlIoIBCg5ZZWFy",
            "TW9udGhSYW5nZRI4CgVzdGFydBgBIAEoCzIpLmdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnY5LmNvbW1vbi5ZZWFyTW9udGgSNgoDZW5kGAIgASgLMikuZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjkuY29tbW9uLlllYXJNb250aCJkCglZZWFyTW9u",
            "dGgSDAoEeWVhchgBIAEoAxJJCgVtb250aBgCIAEoDjI6Lmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY5LmVudW1zLk1vbnRoT2ZZZWFyRW51bS5Nb250aE9mWWVh",
            "ckLlAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbkIKRGF0",
            "ZXNQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjkvY29tbW9uO2NvbW1vbqICA0dBQaoCHkdv",
            "b2dsZS5BZHMuR29vZ2xlQWRzLlY5LkNvbW1vbsoCHkdvb2dsZVxBZHNcR29v",
            "Z2xlQWRzXFY5XENvbW1vbuoCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5",
            "OjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.DateRange), global::Google.Ads.GoogleAds.V9.Common.DateRange.Parser, new[]{ "StartDate", "EndDate" }, new[]{ "StartDate", "EndDate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.YearMonthRange), global::Google.Ads.GoogleAds.V9.Common.YearMonthRange.Parser, new[]{ "Start", "End" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Common.YearMonth), global::Google.Ads.GoogleAds.V9.Common.YearMonth.Parser, new[]{ "Year", "Month" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A date range.
  /// </summary>
  public sealed partial class DateRange : pb::IMessage<DateRange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DateRange> _parser = new pb::MessageParser<DateRange>(() => new DateRange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DateRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.DatesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateRange(DateRange other) : this() {
      startDate_ = other.startDate_;
      endDate_ = other.endDate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DateRange Clone() {
      return new DateRange(this);
    }

    /// <summary>Field number for the "start_date" field.</summary>
    public const int StartDateFieldNumber = 3;
    private string startDate_;
    /// <summary>
    /// The start date, in yyyy-mm-dd format. This date is inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string StartDate {
      get { return startDate_ ?? ""; }
      set {
        startDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "start_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStartDate {
      get { return startDate_ != null; }
    }
    /// <summary>Clears the value of the "start_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStartDate() {
      startDate_ = null;
    }

    /// <summary>Field number for the "end_date" field.</summary>
    public const int EndDateFieldNumber = 4;
    private string endDate_;
    /// <summary>
    /// The end date, in yyyy-mm-dd format. This date is inclusive.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EndDate {
      get { return endDate_ ?? ""; }
      set {
        endDate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "end_date" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasEndDate {
      get { return endDate_ != null; }
    }
    /// <summary>Clears the value of the "end_date" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearEndDate() {
      endDate_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DateRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DateRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartDate != other.StartDate) return false;
      if (EndDate != other.EndDate) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasStartDate) hash ^= StartDate.GetHashCode();
      if (HasEndDate) hash ^= EndDate.GetHashCode();
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
      if (HasStartDate) {
        output.WriteRawTag(26);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(34);
        output.WriteString(EndDate);
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
      if (HasStartDate) {
        output.WriteRawTag(26);
        output.WriteString(StartDate);
      }
      if (HasEndDate) {
        output.WriteRawTag(34);
        output.WriteString(EndDate);
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
      if (HasStartDate) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StartDate);
      }
      if (HasEndDate) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EndDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DateRange other) {
      if (other == null) {
        return;
      }
      if (other.HasStartDate) {
        StartDate = other.StartDate;
      }
      if (other.HasEndDate) {
        EndDate = other.EndDate;
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
            StartDate = input.ReadString();
            break;
          }
          case 34: {
            EndDate = input.ReadString();
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
            StartDate = input.ReadString();
            break;
          }
          case 34: {
            EndDate = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The year month range inclusive of the start and end months.
  /// Eg: A year month range to represent Jan 2020 would be: (Jan 2020, Jan 2020).
  /// </summary>
  public sealed partial class YearMonthRange : pb::IMessage<YearMonthRange>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<YearMonthRange> _parser = new pb::MessageParser<YearMonthRange>(() => new YearMonthRange());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<YearMonthRange> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.DatesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonthRange() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonthRange(YearMonthRange other) : this() {
      start_ = other.start_ != null ? other.start_.Clone() : null;
      end_ = other.end_ != null ? other.end_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonthRange Clone() {
      return new YearMonthRange(this);
    }

    /// <summary>Field number for the "start" field.</summary>
    public const int StartFieldNumber = 1;
    private global::Google.Ads.GoogleAds.V9.Common.YearMonth start_;
    /// <summary>
    /// The inclusive start year month.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.YearMonth Start {
      get { return start_; }
      set {
        start_ = value;
      }
    }

    /// <summary>Field number for the "end" field.</summary>
    public const int EndFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Common.YearMonth end_;
    /// <summary>
    /// The inclusive end year month.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.YearMonth End {
      get { return end_; }
      set {
        end_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as YearMonthRange);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(YearMonthRange other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Start, other.Start)) return false;
      if (!object.Equals(End, other.End)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (start_ != null) hash ^= Start.GetHashCode();
      if (end_ != null) hash ^= End.GetHashCode();
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
      if (start_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Start);
      }
      if (end_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(End);
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
      if (start_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Start);
      }
      if (end_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(End);
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
      if (start_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Start);
      }
      if (end_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(End);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(YearMonthRange other) {
      if (other == null) {
        return;
      }
      if (other.start_ != null) {
        if (start_ == null) {
          Start = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
        }
        Start.MergeFrom(other.Start);
      }
      if (other.end_ != null) {
        if (end_ == null) {
          End = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
        }
        End.MergeFrom(other.End);
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
            if (start_ == null) {
              Start = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
            }
            input.ReadMessage(Start);
            break;
          }
          case 18: {
            if (end_ == null) {
              End = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
            }
            input.ReadMessage(End);
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
            if (start_ == null) {
              Start = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
            }
            input.ReadMessage(Start);
            break;
          }
          case 18: {
            if (end_ == null) {
              End = new global::Google.Ads.GoogleAds.V9.Common.YearMonth();
            }
            input.ReadMessage(End);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Year month.
  /// </summary>
  public sealed partial class YearMonth : pb::IMessage<YearMonth>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<YearMonth> _parser = new pb::MessageParser<YearMonth>(() => new YearMonth());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<YearMonth> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Common.DatesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonth() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonth(YearMonth other) : this() {
      year_ = other.year_;
      month_ = other.month_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public YearMonth Clone() {
      return new YearMonth(this);
    }

    /// <summary>Field number for the "year" field.</summary>
    public const int YearFieldNumber = 1;
    private long year_;
    /// <summary>
    /// The year (e.g. 2020).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Year {
      get { return year_; }
      set {
        year_ = value;
      }
    }

    /// <summary>Field number for the "month" field.</summary>
    public const int MonthFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear month_ = global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified;
    /// <summary>
    /// The month of the year. (e.g. FEBRUARY).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear Month {
      get { return month_; }
      set {
        month_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as YearMonth);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(YearMonth other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Year != other.Year) return false;
      if (Month != other.Month) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Year != 0L) hash ^= Year.GetHashCode();
      if (Month != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) hash ^= Month.GetHashCode();
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
      if (Year != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Year);
      }
      if (Month != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Month);
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
      if (Year != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Year);
      }
      if (Month != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Month);
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
      if (Year != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Year);
      }
      if (Month != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Month);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(YearMonth other) {
      if (other == null) {
        return;
      }
      if (other.Year != 0L) {
        Year = other.Year;
      }
      if (other.Month != global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear.Unspecified) {
        Month = other.Month;
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
            Year = input.ReadInt64();
            break;
          }
          case 16: {
            Month = (global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear) input.ReadEnum();
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
            Year = input.ReadInt64();
            break;
          }
          case 16: {
            Month = (global::Google.Ads.GoogleAds.V9.Enums.MonthOfYearEnum.Types.MonthOfYear) input.ReadEnum();
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
