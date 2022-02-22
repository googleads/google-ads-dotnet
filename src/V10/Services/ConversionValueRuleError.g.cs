// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/errors/conversion_value_rule_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/errors/conversion_value_rule_error.proto</summary>
  public static partial class ConversionValueRuleErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/errors/conversion_value_rule_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionValueRuleErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZXJyb3JzL2NvbnZlcnNpb25f",
            "dmFsdWVfcnVsZV9lcnJvci5wcm90bxIfZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djEwLmVycm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKFBAoc",
            "Q29udmVyc2lvblZhbHVlUnVsZUVycm9yRW51bSLkAwoYQ29udmVyc2lvblZh",
            "bHVlUnVsZUVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEh8K",
            "G0lOVkFMSURfR0VPX1RBUkdFVF9DT05TVEFOVBACEjAKLENPTkZMSUNUSU5H",
            "X0lOQ0xVREVEX0FORF9FWENMVURFRF9HRU9fVEFSR0VUEAMSGgoWQ09ORkxJ",
            "Q1RJTkdfQ09ORElUSU9OUxAEEi8KK0NBTk5PVF9SRU1PVkVfSUZfSU5DTFVE",
            "RURfSU5fVkFMVUVfUlVMRV9TRVQQBRIZChVDT05ESVRJT05fTk9UX0FMTE9X",
            "RUQQBhIXChNGSUVMRF9NVVNUX0JFX1VOU0VUEAcSMAosQ0FOTk9UX1BBVVNF",
            "X1VOTEVTU19WQUxVRV9SVUxFX1NFVF9JU19QQVVTRUQQCBIbChdVTlRBUkdF",
            "VEFCTEVfR0VPX1RBUkdFVBAJEh4KGklOVkFMSURfQVVESUVOQ0VfVVNFUl9M",
            "SVNUEAoSGgoWSU5BQ0NFU1NJQkxFX1VTRVJfTElTVBALEiIKHklOVkFMSURf",
            "QVVESUVOQ0VfVVNFUl9JTlRFUkVTVBAMEicKI0NBTk5PVF9BRERfUlVMRV9X",
            "SVRIX1NUQVRVU19SRU1PVkVEEA1C/QEKI2NvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTAuZXJyb3JzQh1Db252ZXJzaW9uVmFsdWVSdWxlRXJyb3JQcm90",
            "b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjEwL2Vycm9ycztlcnJvcnOiAgNHQUGqAh9Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTAuRXJyb3JzygIfR29vZ2xlXEFkc1xHb29nbGVB",
            "ZHNcVjEwXEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxMDo6",
            "RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleErrorEnum), global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleErrorEnum.Types.ConversionValueRuleError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible conversion value rule errors.
  /// </summary>
  public sealed partial class ConversionValueRuleErrorEnum : pb::IMessage<ConversionValueRuleErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionValueRuleErrorEnum> _parser = new pb::MessageParser<ConversionValueRuleErrorEnum>(() => new ConversionValueRuleErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionValueRuleErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Errors.ConversionValueRuleErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleErrorEnum(ConversionValueRuleErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionValueRuleErrorEnum Clone() {
      return new ConversionValueRuleErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionValueRuleErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionValueRuleErrorEnum other) {
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
    public void MergeFrom(ConversionValueRuleErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionValueRuleErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible conversion value rule errors.
      /// </summary>
      public enum ConversionValueRuleError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The value rule's geo location condition contains invalid geo target
        /// constant(s), i.e. there's no matching geo target.
        /// </summary>
        [pbr::OriginalName("INVALID_GEO_TARGET_CONSTANT")] InvalidGeoTargetConstant = 2,
        /// <summary>
        /// The value rule's geo location condition contains conflicting included and
        /// excluded geo targets. Specifically, some of the excluded geo target(s)
        /// are the same as or contain some of the included geo target(s). For
        /// example, the geo location condition includes California but excludes U.S.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_INCLUDED_AND_EXCLUDED_GEO_TARGET")] ConflictingIncludedAndExcludedGeoTarget = 3,
        /// <summary>
        /// User specified conflicting conditions for two value rules in the same
        /// value rule set.
        /// </summary>
        [pbr::OriginalName("CONFLICTING_CONDITIONS")] ConflictingConditions = 4,
        /// <summary>
        /// The value rule cannot be removed because it's still included in some
        /// value rule set.
        /// </summary>
        [pbr::OriginalName("CANNOT_REMOVE_IF_INCLUDED_IN_VALUE_RULE_SET")] CannotRemoveIfIncludedInValueRuleSet = 5,
        /// <summary>
        /// The value rule contains a condition that's not allowed by the value rule
        /// set including this value rule.
        /// </summary>
        [pbr::OriginalName("CONDITION_NOT_ALLOWED")] ConditionNotAllowed = 6,
        /// <summary>
        /// The value rule contains a field that should be unset.
        /// </summary>
        [pbr::OriginalName("FIELD_MUST_BE_UNSET")] FieldMustBeUnset = 7,
        /// <summary>
        /// Pausing the value rule requires pausing the value rule set because the
        /// value rule is (one of) the last enabled in the value rule set.
        /// </summary>
        [pbr::OriginalName("CANNOT_PAUSE_UNLESS_VALUE_RULE_SET_IS_PAUSED")] CannotPauseUnlessValueRuleSetIsPaused = 8,
        /// <summary>
        /// The value rule's geo location condition contains untargetable geo target
        /// constant(s).
        /// </summary>
        [pbr::OriginalName("UNTARGETABLE_GEO_TARGET")] UntargetableGeoTarget = 9,
        /// <summary>
        /// The value rule's audience condition contains invalid user list(s). In
        /// another word, there's no matching user list.
        /// </summary>
        [pbr::OriginalName("INVALID_AUDIENCE_USER_LIST")] InvalidAudienceUserList = 10,
        /// <summary>
        /// The value rule's audience condition contains inaccessible user list(s).
        /// </summary>
        [pbr::OriginalName("INACCESSIBLE_USER_LIST")] InaccessibleUserList = 11,
        /// <summary>
        /// The value rule's audience condition contains invalid user_interest(s).
        /// This might be because there is no matching user interest, or the user
        /// interest is not visible.
        /// </summary>
        [pbr::OriginalName("INVALID_AUDIENCE_USER_INTEREST")] InvalidAudienceUserInterest = 12,
        /// <summary>
        /// When a value rule is created, it shouldn't have REMOVED status.
        /// </summary>
        [pbr::OriginalName("CANNOT_ADD_RULE_WITH_STATUS_REMOVED")] CannotAddRuleWithStatusRemoved = 13,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
