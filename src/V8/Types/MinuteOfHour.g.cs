// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/minute_of_hour.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/minute_of_hour.proto</summary>
  public static partial class MinuteOfHourReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/minute_of_hour.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MinuteOfHourReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9taW51dGVfb2ZfaG91",
            "ci5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjguZW51bXMaHGdvb2ds",
            "ZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8icwoQTWludXRlT2ZIb3VyRW51bSJf",
            "CgxNaW51dGVPZkhvdXISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAES",
            "CAoEWkVSTxACEgsKB0ZJRlRFRU4QAxIKCgZUSElSVFkQBBIOCgpGT1JUWV9G",
            "SVZFEAVC5gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OC5lbnVtc0IR",
            "TWludXRlT2ZIb3VyUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y4L2VudW1zO2VudW1zogID",
            "R0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjguRW51bXPKAh1Hb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWOFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVB",
            "ZHM6OlY4OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.MinuteOfHourEnum), global::Google.Ads.GoogleAds.V8.Enums.MinuteOfHourEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.MinuteOfHourEnum.Types.MinuteOfHour) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of quarter-hours.
  /// </summary>
  public sealed partial class MinuteOfHourEnum : pb::IMessage<MinuteOfHourEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MinuteOfHourEnum> _parser = new pb::MessageParser<MinuteOfHourEnum>(() => new MinuteOfHourEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MinuteOfHourEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.MinuteOfHourReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MinuteOfHourEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MinuteOfHourEnum(MinuteOfHourEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MinuteOfHourEnum Clone() {
      return new MinuteOfHourEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MinuteOfHourEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MinuteOfHourEnum other) {
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
    public void MergeFrom(MinuteOfHourEnum other) {
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
    /// <summary>Container for nested types declared in the MinuteOfHourEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enumerates of quarter-hours. E.g. "FIFTEEN"
      /// </summary>
      public enum MinuteOfHour {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Zero minutes past the hour.
        /// </summary>
        [pbr::OriginalName("ZERO")] Zero = 2,
        /// <summary>
        /// Fifteen minutes past the hour.
        /// </summary>
        [pbr::OriginalName("FIFTEEN")] Fifteen = 3,
        /// <summary>
        /// Thirty minutes past the hour.
        /// </summary>
        [pbr::OriginalName("THIRTY")] Thirty = 4,
        /// <summary>
        /// Forty-five minutes past the hour.
        /// </summary>
        [pbr::OriginalName("FORTY_FIVE")] FortyFive = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
