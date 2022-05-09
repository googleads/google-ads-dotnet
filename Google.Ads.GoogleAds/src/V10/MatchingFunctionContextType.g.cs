// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/matching_function_context_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/matching_function_context_type.proto</summary>
  public static partial class MatchingFunctionContextTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/matching_function_context_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchingFunctionContextTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvbWF0Y2hpbmdfZnVu",
            "Y3Rpb25fY29udGV4dF90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTAuZW51bXMilwEKH01hdGNoaW5nRnVuY3Rpb25Db250ZXh0VHlwZUVu",
            "dW0idAobTWF0Y2hpbmdGdW5jdGlvbkNvbnRleHRUeXBlEg8KC1VOU1BFQ0lG",
            "SUVEEAASCwoHVU5LTk9XThABEhAKDEZFRURfSVRFTV9JRBACEg8KC0RFVklD",
            "RV9OQU1FEAMSFAoQRkVFRF9JVEVNX1NFVF9JRBAEQvoBCiJjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjEwLmVudW1zQiBNYXRjaGluZ0Z1bmN0aW9uQ29u",
            "dGV4dFR5cGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2VudW1zogIDR0FB",
            "qgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIeR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFk",
            "czo6VjEwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.MatchingFunctionContextTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.MatchingFunctionContextTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.MatchingFunctionContextTypeEnum.Types.MatchingFunctionContextType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for context types for an operand in a matching function.
  /// </summary>
  public sealed partial class MatchingFunctionContextTypeEnum : pb::IMessage<MatchingFunctionContextTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MatchingFunctionContextTypeEnum> _parser = new pb::MessageParser<MatchingFunctionContextTypeEnum>(() => new MatchingFunctionContextTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MatchingFunctionContextTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.MatchingFunctionContextTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchingFunctionContextTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchingFunctionContextTypeEnum(MatchingFunctionContextTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchingFunctionContextTypeEnum Clone() {
      return new MatchingFunctionContextTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MatchingFunctionContextTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MatchingFunctionContextTypeEnum other) {
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
    public void MergeFrom(MatchingFunctionContextTypeEnum other) {
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
    /// <summary>Container for nested types declared in the MatchingFunctionContextTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Possible context types for an operand in a matching function.
      /// </summary>
      public enum MatchingFunctionContextType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Feed item id in the request context.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_ID")] FeedItemId = 2,
        /// <summary>
        /// The device being used (possible values are 'Desktop' or 'Mobile').
        /// </summary>
        [pbr::OriginalName("DEVICE_NAME")] DeviceName = 3,
        /// <summary>
        /// Feed item set id in the request context.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM_SET_ID")] FeedItemSetId = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
