// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/feed_item_target_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/feed_item_target_error.proto</summary>
  public static partial class FeedItemTargetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/feed_item_target_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemTargetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2ZlZWRfaXRlbV90",
            "YXJnZXRfZXJyb3IucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMC5l",
            "cnJvcnMi/AIKF0ZlZWRJdGVtVGFyZ2V0RXJyb3JFbnVtIuACChNGZWVkSXRl",
            "bVRhcmdldEVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEiMK",
            "H01VU1RfU0VUX1RBUkdFVF9PTkVPRl9PTl9DUkVBVEUQAhIjCh9GRUVEX0lU",
            "RU1fVEFSR0VUX0FMUkVBRFlfRVhJU1RTEAMSJgoiRkVFRF9JVEVNX1NDSEVE",
            "VUxFU19DQU5OT1RfT1ZFUkxBUBAEEigKJFRBUkdFVF9MSU1JVF9FWENFRURF",
            "RF9GT1JfR0lWRU5fVFlQRRAFEh4KGlRPT19NQU5ZX1NDSEVEVUxFU19QRVJf",
            "REFZEAYSPQo5Q0FOTk9UX0hBVkVfRU5BQkxFRF9DQU1QQUlHTl9BTkRfRU5B",
            "QkxFRF9BRF9HUk9VUF9UQVJHRVRTEAcSGQoVRFVQTElDQVRFX0FEX1NDSEVE",
            "VUxFEAgSFQoRRFVQTElDQVRFX0tFWVdPUkQQCUL4AQojY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnYxMC5lcnJvcnNCGEZlZWRJdGVtVGFyZ2V0RXJyb3JQ",
            "cm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlz",
            "L2Fkcy9nb29nbGVhZHMvdjEwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMTAuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjEwXEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYx",
            "MDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.FeedItemTargetErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.FeedItemTargetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.FeedItemTargetErrorEnum.Types.FeedItemTargetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible feed item target errors.
  /// </summary>
  public sealed partial class FeedItemTargetErrorEnum : pb::IMessage<FeedItemTargetErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemTargetErrorEnum> _parser = new pb::MessageParser<FeedItemTargetErrorEnum>(() => new FeedItemTargetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedItemTargetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.FeedItemTargetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTargetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTargetErrorEnum(FeedItemTargetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemTargetErrorEnum Clone() {
      return new FeedItemTargetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedItemTargetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedItemTargetErrorEnum other) {
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
    public void MergeFrom(FeedItemTargetErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemTargetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible feed item target errors.
      /// </summary>
      public enum FeedItemTargetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// On CREATE, the FeedItemTarget must have a populated field in the oneof
        /// target.
        /// </summary>
        [pbr::OriginalName("MUST_SET_TARGET_ONEOF_ON_CREATE")] MustSetTargetOneofOnCreate = 2,
        /// <summary>
        /// The specified feed item target already exists, so it cannot be added.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_TARGET_ALREADY_EXISTS")] FeedItemTargetAlreadyExists = 3,
        /// <summary>
        /// The schedules for a given feed item cannot overlap.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_SCHEDULES_CANNOT_OVERLAP")] FeedItemSchedulesCannotOverlap = 4,
        /// <summary>
        /// Too many targets of a given type were added for a single feed item.
        /// </summary>
        [pbr::OriginalName("TARGET_LIMIT_EXCEEDED_FOR_GIVEN_TYPE")] TargetLimitExceededForGivenType = 5,
        /// <summary>
        /// Too many AdSchedules are enabled for the feed item for the given day.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_SCHEDULES_PER_DAY")] TooManySchedulesPerDay = 6,
        /// <summary>
        /// A feed item may either have an enabled campaign target or an enabled ad
        /// group target.
        /// </summary>
        [pbr::OriginalName("CANNOT_HAVE_ENABLED_CAMPAIGN_AND_ENABLED_AD_GROUP_TARGETS")] CannotHaveEnabledCampaignAndEnabledAdGroupTargets = 7,
        /// <summary>
        /// Duplicate ad schedules aren't allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_AD_SCHEDULE")] DuplicateAdSchedule = 8,
        /// <summary>
        /// Duplicate keywords aren't allowed.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_KEYWORD")] DuplicateKeyword = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
