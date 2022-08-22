// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/lead_form_call_to_action_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/lead_form_call_to_action_type.proto</summary>
  public static partial class LeadFormCallToActionTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/lead_form_call_to_action_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LeadFormCallToActionTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvbGVhZF9mb3JtX2Nh",
            "bGxfdG9fYWN0aW9uX3R5cGUucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYxMC5lbnVtcyKrAgocTGVhZEZvcm1DYWxsVG9BY3Rpb25UeXBlRW51bSKK",
            "AgoYTGVhZEZvcm1DYWxsVG9BY3Rpb25UeXBlEg8KC1VOU1BFQ0lGSUVEEAAS",
            "CwoHVU5LTk9XThABEg4KCkxFQVJOX01PUkUQAhINCglHRVRfUVVPVEUQAxIN",
            "CglBUFBMWV9OT1cQBBILCgdTSUdOX1VQEAUSDgoKQ09OVEFDVF9VUxAGEg0K",
            "CVNVQlNDUklCRRAHEgwKCERPV05MT0FEEAgSDAoIQk9PS19OT1cQCRINCglH",
            "RVRfT0ZGRVIQChIMCghSRUdJU1RFUhALEgwKCEdFVF9JTkZPEAwSEAoMUkVR",
            "VUVTVF9ERU1PEA0SDAoISk9JTl9OT1cQDhIPCgtHRVRfU1RBUlRFRBAPQvcB",
            "CiJjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEwLmVudW1zQh1MZWFkRm9y",
            "bUNhbGxUb0FjdGlvblR5cGVQcm90b1ABWkNnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEwL2VudW1zO2Vu",
            "dW1zogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEwLkVudW1zygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjEwXEVudW1z6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjEwOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.LeadFormCallToActionTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.LeadFormCallToActionTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.LeadFormCallToActionTypeEnum.Types.LeadFormCallToActionType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Describes the type of call-to-action phrases in a lead form.
  /// </summary>
  public sealed partial class LeadFormCallToActionTypeEnum : pb::IMessage<LeadFormCallToActionTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LeadFormCallToActionTypeEnum> _parser = new pb::MessageParser<LeadFormCallToActionTypeEnum>(() => new LeadFormCallToActionTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LeadFormCallToActionTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.LeadFormCallToActionTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum(LeadFormCallToActionTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LeadFormCallToActionTypeEnum Clone() {
      return new LeadFormCallToActionTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LeadFormCallToActionTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LeadFormCallToActionTypeEnum other) {
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
    public void MergeFrom(LeadFormCallToActionTypeEnum other) {
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
    /// <summary>Container for nested types declared in the LeadFormCallToActionTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the type of call-to-action phrases in a lead form.
      /// </summary>
      public enum LeadFormCallToActionType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Learn more.
        /// </summary>
        [pbr::OriginalName("LEARN_MORE")] LearnMore = 2,
        /// <summary>
        /// Get quote.
        /// </summary>
        [pbr::OriginalName("GET_QUOTE")] GetQuote = 3,
        /// <summary>
        /// Apply now.
        /// </summary>
        [pbr::OriginalName("APPLY_NOW")] ApplyNow = 4,
        /// <summary>
        /// Sign Up.
        /// </summary>
        [pbr::OriginalName("SIGN_UP")] SignUp = 5,
        /// <summary>
        /// Contact us.
        /// </summary>
        [pbr::OriginalName("CONTACT_US")] ContactUs = 6,
        /// <summary>
        /// Subscribe.
        /// </summary>
        [pbr::OriginalName("SUBSCRIBE")] Subscribe = 7,
        /// <summary>
        /// Download.
        /// </summary>
        [pbr::OriginalName("DOWNLOAD")] Download = 8,
        /// <summary>
        /// Book now.
        /// </summary>
        [pbr::OriginalName("BOOK_NOW")] BookNow = 9,
        /// <summary>
        /// Get offer.
        /// </summary>
        [pbr::OriginalName("GET_OFFER")] GetOffer = 10,
        /// <summary>
        /// Register.
        /// </summary>
        [pbr::OriginalName("REGISTER")] Register = 11,
        /// <summary>
        /// Get info.
        /// </summary>
        [pbr::OriginalName("GET_INFO")] GetInfo = 12,
        /// <summary>
        /// Request a demo.
        /// </summary>
        [pbr::OriginalName("REQUEST_DEMO")] RequestDemo = 13,
        /// <summary>
        /// Join now.
        /// </summary>
        [pbr::OriginalName("JOIN_NOW")] JoinNow = 14,
        /// <summary>
        /// Get started.
        /// </summary>
        [pbr::OriginalName("GET_STARTED")] GetStarted = 15,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
