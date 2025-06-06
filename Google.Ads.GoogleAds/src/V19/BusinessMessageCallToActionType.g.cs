// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/business_message_call_to_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/business_message_call_to_action_type.proto</summary>
  public static partial class BusinessMessageCallToActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/business_message_call_to_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BusinessMessageCallToActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cklnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvYnVzaW5lc3NfbWVz",
            "c2FnZV9jYWxsX3RvX2FjdGlvbl90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTkuZW51bXMi4QEKI0J1c2luZXNzTWVzc2FnZUNhbGxUb0Fj",
            "dGlvblR5cGVFbnVtIrkBCh9CdXNpbmVzc01lc3NhZ2VDYWxsVG9BY3Rpb25U",
            "eXBlEg8KC1VOU1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEg0KCUFQUExZX05P",
            "VxACEgwKCEJPT0tfTk9XEAMSDgoKQ09OVEFDVF9VUxAEEgwKCEdFVF9JTkZP",
            "EAUSDQoJR0VUX09GRkVSEAYSDQoJR0VUX1FVT1RFEAcSDwoLR0VUX1NUQVJU",
            "RUQQCBIOCgpMRUFSTl9NT1JFEAlC/gEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTkuZW51bXNCJEJ1c2luZXNzTWVzc2FnZUNhbGxUb0FjdGlvblR5",
            "cGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVh",
            "cGlzL2Fkcy9nb29nbGVhZHMvdjE5L2VudW1zO2VudW1zogIDR0FBqgIeR29v",
            "Z2xlLkFkcy5Hb29nbGVBZHMuVjE5LkVudW1zygIeR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjE5XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjE5",
            "OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.BusinessMessageCallToActionTypeEnum), global::Google.Ads.GoogleAds.V19.Enums.BusinessMessageCallToActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.BusinessMessageCallToActionTypeEnum.Types.BusinessMessageCallToActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the type of call-to-action phrases in a business message.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class BusinessMessageCallToActionTypeEnum : pb::IMessage<BusinessMessageCallToActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<BusinessMessageCallToActionTypeEnum> _parser = new pb::MessageParser<BusinessMessageCallToActionTypeEnum>(() => new BusinessMessageCallToActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<BusinessMessageCallToActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.BusinessMessageCallToActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BusinessMessageCallToActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BusinessMessageCallToActionTypeEnum(BusinessMessageCallToActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public BusinessMessageCallToActionTypeEnum Clone() {
      return new BusinessMessageCallToActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as BusinessMessageCallToActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(BusinessMessageCallToActionTypeEnum other) {
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
    public void MergeFrom(BusinessMessageCallToActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the BusinessMessageCallToActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the type of call-to-action phrases in a business message.
      /// </summary>
      public enum BusinessMessageCallToActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Apply now.
        /// </summary>
        [pbr::OriginalName("APPLY_NOW")] ApplyNow = 2,
        /// <summary>
        /// Book now.
        /// </summary>
        [pbr::OriginalName("BOOK_NOW")] BookNow = 3,
        /// <summary>
        /// Contact us.
        /// </summary>
        [pbr::OriginalName("CONTACT_US")] ContactUs = 4,
        /// <summary>
        /// Get info.
        /// </summary>
        [pbr::OriginalName("GET_INFO")] GetInfo = 5,
        /// <summary>
        /// Get offer.
        /// </summary>
        [pbr::OriginalName("GET_OFFER")] GetOffer = 6,
        /// <summary>
        /// Get quote.
        /// </summary>
        [pbr::OriginalName("GET_QUOTE")] GetQuote = 7,
        /// <summary>
        /// Get started.
        /// </summary>
        [pbr::OriginalName("GET_STARTED")] GetStarted = 8,
        /// <summary>
        /// Learn more.
        /// </summary>
        [pbr::OriginalName("LEARN_MORE")] LearnMore = 9,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
