// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/errors/function_parsing_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/errors/function_parsing_error.proto</summary>
  public static partial class FunctionParsingErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/errors/function_parsing_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FunctionParsingErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9lcnJvcnMvZnVuY3Rpb25fcGFy",
            "c2luZ19lcnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjcuZXJy",
            "b3JzGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIoIDChhGdW5jdGlv",
            "blBhcnNpbmdFcnJvckVudW0i5QIKFEZ1bmN0aW9uUGFyc2luZ0Vycm9yEg8K",
            "C1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEhEKDU5PX01PUkVfSU5QVVQQ",
            "AhIWChJFWFBFQ1RFRF9DSEFSQUNURVIQAxIYChRVTkVYUEVDVEVEX1NFUEFS",
            "QVRPUhAEEhoKFlVOTUFUQ0hFRF9MRUZUX0JSQUNLRVQQBRIbChdVTk1BVENI",
            "RURfUklHSFRfQlJBQ0tFVBAGEh0KGVRPT19NQU5ZX05FU1RFRF9GVU5DVElP",
            "TlMQBxIeChpNSVNTSU5HX1JJR0hUX0hBTkRfT1BFUkFORBAIEhkKFUlOVkFM",
            "SURfT1BFUkFUT1JfTkFNRRAJEi8KK0ZFRURfQVRUUklCVVRFX09QRVJBTkRf",
            "QVJHVU1FTlRfTk9UX0lOVEVHRVIQChIPCgtOT19PUEVSQU5EUxALEhUKEVRP",
            "T19NQU5ZX09QRVJBTkRTEAxC9AEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52Ny5lcnJvcnNCGUZ1bmN0aW9uUGFyc2luZ0Vycm9yUHJvdG9QAVpEZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3Y3L2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WNy5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWN1xFcnJv",
            "cnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNzo6RXJyb3JzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Errors.FunctionParsingErrorEnum), global::Google.Ads.GoogleAds.V7.Errors.FunctionParsingErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V7.Errors.FunctionParsingErrorEnum.Types.FunctionParsingError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible function parsing errors.
  /// </summary>
  public sealed partial class FunctionParsingErrorEnum : pb::IMessage<FunctionParsingErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FunctionParsingErrorEnum> _parser = new pb::MessageParser<FunctionParsingErrorEnum>(() => new FunctionParsingErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FunctionParsingErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Errors.FunctionParsingErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionParsingErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionParsingErrorEnum(FunctionParsingErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FunctionParsingErrorEnum Clone() {
      return new FunctionParsingErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FunctionParsingErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FunctionParsingErrorEnum other) {
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
    public void MergeFrom(FunctionParsingErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FunctionParsingErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible function parsing errors.
      /// </summary>
      public enum FunctionParsingError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Unexpected end of function string.
        /// </summary>
        [pbr::OriginalName("NO_MORE_INPUT")] NoMoreInput = 2,
        /// <summary>
        /// Could not find an expected character.
        /// </summary>
        [pbr::OriginalName("EXPECTED_CHARACTER")] ExpectedCharacter = 3,
        /// <summary>
        /// Unexpected separator character.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_SEPARATOR")] UnexpectedSeparator = 4,
        /// <summary>
        /// Unmatched left bracket or parenthesis.
        /// </summary>
        [pbr::OriginalName("UNMATCHED_LEFT_BRACKET")] UnmatchedLeftBracket = 5,
        /// <summary>
        /// Unmatched right bracket or parenthesis.
        /// </summary>
        [pbr::OriginalName("UNMATCHED_RIGHT_BRACKET")] UnmatchedRightBracket = 6,
        /// <summary>
        /// Functions are nested too deeply.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_NESTED_FUNCTIONS")] TooManyNestedFunctions = 7,
        /// <summary>
        /// Missing right-hand-side operand.
        /// </summary>
        [pbr::OriginalName("MISSING_RIGHT_HAND_OPERAND")] MissingRightHandOperand = 8,
        /// <summary>
        /// Invalid operator/function name.
        /// </summary>
        [pbr::OriginalName("INVALID_OPERATOR_NAME")] InvalidOperatorName = 9,
        /// <summary>
        /// Feed attribute operand's argument is not an integer.
        /// </summary>
        [pbr::OriginalName("FEED_ATTRIBUTE_OPERAND_ARGUMENT_NOT_INTEGER")] FeedAttributeOperandArgumentNotInteger = 10,
        /// <summary>
        /// Missing function operands.
        /// </summary>
        [pbr::OriginalName("NO_OPERANDS")] NoOperands = 11,
        /// <summary>
        /// Function had too many operands.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_OPERANDS")] TooManyOperands = 12,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
