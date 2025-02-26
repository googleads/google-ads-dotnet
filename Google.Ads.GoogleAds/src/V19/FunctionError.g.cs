// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/errors/function_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/errors/function_error.proto</summary>
  public static partial class FunctionErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/errors/function_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FunctionErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZXJyb3JzL2Z1bmN0aW9uX2Vy",
            "cm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTkuZXJyb3JzIsEE",
            "ChFGdW5jdGlvbkVycm9yRW51bSKrBAoNRnVuY3Rpb25FcnJvchIPCgtVTlNQ",
            "RUNJRklFRBAAEgsKB1VOS05PV04QARIbChdJTlZBTElEX0ZVTkNUSU9OX0ZP",
            "Uk1BVBACEhYKEkRBVEFfVFlQRV9NSVNNQVRDSBADEiAKHElOVkFMSURfQ09O",
            "SlVOQ1RJT05fT1BFUkFORFMQBBIeChpJTlZBTElEX05VTUJFUl9PRl9PUEVS",
            "QU5EUxAFEhgKFElOVkFMSURfT1BFUkFORF9UWVBFEAYSFAoQSU5WQUxJRF9P",
            "UEVSQVRPUhAHEiAKHElOVkFMSURfUkVRVUVTVF9DT05URVhUX1RZUEUQCBIp",
            "CiVJTlZBTElEX0ZVTkNUSU9OX0ZPUl9DQUxMX1BMQUNFSE9MREVSEAkSJAog",
            "SU5WQUxJRF9GVU5DVElPTl9GT1JfUExBQ0VIT0xERVIQChITCg9JTlZBTElE",
            "X09QRVJBTkQQCxIiCh5NSVNTSU5HX0NPTlNUQU5UX09QRVJBTkRfVkFMVUUQ",
            "DBIiCh5JTlZBTElEX0NPTlNUQU5UX09QRVJBTkRfVkFMVUUQDRITCg9JTlZB",
            "TElEX05FU1RJTkcQDhIjCh9NVUxUSVBMRV9GRUVEX0lEU19OT1RfU1VQUE9S",
            "VEVEEA8SLworSU5WQUxJRF9GVU5DVElPTl9GT1JfRkVFRF9XSVRIX0ZJWEVE",
            "X1NDSEVNQRAQEhoKFklOVkFMSURfQVRUUklCVVRFX05BTUUQEULyAQojY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxOS5lcnJvcnNCEkZ1bmN0aW9uRXJy",
            "b3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjE5L2Vycm9ycztlcnJvcnOiAgNHQUGqAh9H",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMTkuRXJyb3JzygIfR29vZ2xlXEFkc1xH",
            "b29nbGVBZHNcVjE5XEVycm9yc+oCI0dvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxOTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Errors.FunctionErrorEnum), global::Google.Ads.GoogleAds.V19.Errors.FunctionErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Errors.FunctionErrorEnum.Types.FunctionError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible function errors.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class FunctionErrorEnum : pb::IMessage<FunctionErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FunctionErrorEnum> _parser = new pb::MessageParser<FunctionErrorEnum>(() => new FunctionErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FunctionErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Errors.FunctionErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionErrorEnum(FunctionErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionErrorEnum Clone() {
      return new FunctionErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FunctionErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FunctionErrorEnum other) {
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
    public void MergeFrom(FunctionErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FunctionErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible function errors.
      /// </summary>
      public enum FunctionError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The format of the function is not recognized as a supported function
        /// format.
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FORMAT")] InvalidFunctionFormat = 2,
        /// <summary>
        /// Operand data types do not match.
        /// </summary>
        [pbr::OriginalName("DATA_TYPE_MISMATCH")] DataTypeMismatch = 3,
        /// <summary>
        /// The operands cannot be used together in a conjunction.
        /// </summary>
        [pbr::OriginalName("INVALID_CONJUNCTION_OPERANDS")] InvalidConjunctionOperands = 4,
        /// <summary>
        /// Invalid numer of Operands.
        /// </summary>
        [pbr::OriginalName("INVALID_NUMBER_OF_OPERANDS")] InvalidNumberOfOperands = 5,
        /// <summary>
        /// Operand Type not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERAND_TYPE")] InvalidOperandType = 6,
        /// <summary>
        /// Operator not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATOR")] InvalidOperator = 7,
        /// <summary>
        /// Request context type not supported.
        /// </summary>
        [pbr::OriginalName("INVALID_REQUEST_CONTEXT_TYPE")] InvalidRequestContextType = 8,
        /// <summary>
        /// The matching function is not allowed for call placeholders
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_CALL_PLACEHOLDER")] InvalidFunctionForCallPlaceholder = 9,
        /// <summary>
        /// The matching function is not allowed for the specified placeholder
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_PLACEHOLDER")] InvalidFunctionForPlaceholder = 10,
        /// <summary>
        /// Invalid operand.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERAND")] InvalidOperand = 11,
        /// <summary>
        /// Missing value for the constant operand.
        /// </summary>
        [pbr::OriginalName("MISSING_CONSTANT_OPERAND_VALUE")] MissingConstantOperandValue = 12,
        /// <summary>
        /// The value of the constant operand is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_CONSTANT_OPERAND_VALUE")] InvalidConstantOperandValue = 13,
        /// <summary>
        /// Invalid function nesting.
        /// </summary>
        [pbr::OriginalName("INVALID_NESTING")] InvalidNesting = 14,
        /// <summary>
        /// The Feed ID was different from another Feed ID in the same function.
        /// </summary>
        [pbr::OriginalName("MULTIPLE_FEED_IDS_NOT_SUPPORTED")] MultipleFeedIdsNotSupported = 15,
        /// <summary>
        /// The matching function is invalid for use with a feed with a fixed schema.
        /// </summary>
        [pbr::OriginalName("INVALID_FUNCTION_FOR_FEED_WITH_FIXED_SCHEMA")] InvalidFunctionForFeedWithFixedSchema = 16,
        /// <summary>
        /// Invalid attribute name.
        /// </summary>
        [pbr::OriginalName("INVALID_ATTRIBUTE_NAME")] InvalidAttributeName = 17,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
