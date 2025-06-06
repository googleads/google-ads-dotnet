// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/enums/month_of_year.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/enums/month_of_year.proto</summary>
  public static partial class MonthOfYearReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/enums/month_of_year.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MonthOfYearReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMvbW9udGhfb2ZfeWVh",
            "ci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIwLmVudW1zItEBCg9N",
            "b250aE9mWWVhckVudW0ivQEKC01vbnRoT2ZZZWFyEg8KC1VOU1BFQ0lGSUVE",
            "EAASCwoHVU5LTk9XThABEgsKB0pBTlVBUlkQAhIMCghGRUJSVUFSWRADEgkK",
            "BU1BUkNIEAQSCQoFQVBSSUwQBRIHCgNNQVkQBhIICgRKVU5FEAcSCAoESlVM",
            "WRAIEgoKBkFVR1VTVBAJEg0KCVNFUFRFTUJFUhAKEgsKB09DVE9CRVIQCxIM",
            "CghOT1ZFTUJFUhAMEgwKCERFQ0VNQkVSEA1C6gEKImNvbS5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52MjAuZW51bXNCEE1vbnRoT2ZZZWFyUHJvdG9QAVpDZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YyMC9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xl",
            "QWRzLlYyMC5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYyMFxFbnVt",
            "c+oCIkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6RW51bXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Enums.MonthOfYearEnum), global::Google.Ads.GoogleAds.V20.Enums.MonthOfYearEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V20.Enums.MonthOfYearEnum.Types.MonthOfYear) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of months of the year, for example, "January".
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MonthOfYearEnum : pb::IMessage<MonthOfYearEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MonthOfYearEnum> _parser = new pb::MessageParser<MonthOfYearEnum>(() => new MonthOfYearEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MonthOfYearEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Enums.MonthOfYearReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonthOfYearEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonthOfYearEnum(MonthOfYearEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MonthOfYearEnum Clone() {
      return new MonthOfYearEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MonthOfYearEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MonthOfYearEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MonthOfYearEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the MonthOfYearEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates months of the year, for example, "January".
      /// </summary>
      public enum MonthOfYear {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// January.
        /// </summary>
        [pbr::OriginalName("JANUARY")] January = 2,
        /// <summary>
        /// February.
        /// </summary>
        [pbr::OriginalName("FEBRUARY")] February = 3,
        /// <summary>
        /// March.
        /// </summary>
        [pbr::OriginalName("MARCH")] March = 4,
        /// <summary>
        /// April.
        /// </summary>
        [pbr::OriginalName("APRIL")] April = 5,
        /// <summary>
        /// May.
        /// </summary>
        [pbr::OriginalName("MAY")] May = 6,
        /// <summary>
        /// June.
        /// </summary>
        [pbr::OriginalName("JUNE")] June = 7,
        /// <summary>
        /// July.
        /// </summary>
        [pbr::OriginalName("JULY")] July = 8,
        /// <summary>
        /// August.
        /// </summary>
        [pbr::OriginalName("AUGUST")] August = 9,
        /// <summary>
        /// September.
        /// </summary>
        [pbr::OriginalName("SEPTEMBER")] September = 10,
        /// <summary>
        /// October.
        /// </summary>
        [pbr::OriginalName("OCTOBER")] October = 11,
        /// <summary>
        /// November.
        /// </summary>
        [pbr::OriginalName("NOVEMBER")] November = 12,
        /// <summary>
        /// December.
        /// </summary>
        [pbr::OriginalName("DECEMBER")] December = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
