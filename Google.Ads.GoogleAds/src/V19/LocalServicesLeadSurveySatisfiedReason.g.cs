// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/local_services_lead_survey_satisfied_reason.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/local_services_lead_survey_satisfied_reason.proto</summary>
  public static partial class LocalServicesLeadSurveySatisfiedReasonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/local_services_lead_survey_satisfied_reason.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalServicesLeadSurveySatisfiedReasonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvbG9jYWxfc2Vydmlj",
            "ZXNfbGVhZF9zdXJ2ZXlfc2F0aXNmaWVkX3JlYXNvbi5wcm90bxIeZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE5LmVudW1zIt4BCipMb2NhbFNlcnZpY2VzTGVh",
            "ZFN1cnZleVNhdGlzZmllZFJlYXNvbkVudW0irwEKFVN1cnZleVNhdGlzZmll",
            "ZFJlYXNvbhIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIaChZPVEhF",
            "Ul9TQVRJU0ZJRURfUkVBU09OEAISEwoPQk9PS0VEX0NVU1RPTUVSEAMSGgoW",
            "TElLRUxZX0JPT0tFRF9DVVNUT01FUhAEEhMKD1NFUlZJQ0VfUkVMQVRFRBAF",
            "EhYKEkhJR0hfVkFMVUVfU0VSVklDRRAGQoUCCiJjb20uZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjE5LmVudW1zQitMb2NhbFNlcnZpY2VzTGVhZFN1cnZleVNh",
            "dGlzZmllZFJlYXNvblByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTkvZW51bXM7ZW51bXOi",
            "AgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTkuRW51bXPKAh5Hb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMTlcRW51bXPqAiJHb29nbGU6OkFkczo6R29v",
            "Z2xlQWRzOjpWMTk6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.LocalServicesLeadSurveySatisfiedReasonEnum), global::Google.Ads.GoogleAds.V19.Enums.LocalServicesLeadSurveySatisfiedReasonEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.LocalServicesLeadSurveySatisfiedReasonEnum.Types.SurveySatisfiedReason) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible survey satisfied reasons for a lead.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class LocalServicesLeadSurveySatisfiedReasonEnum : pb::IMessage<LocalServicesLeadSurveySatisfiedReasonEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalServicesLeadSurveySatisfiedReasonEnum> _parser = new pb::MessageParser<LocalServicesLeadSurveySatisfiedReasonEnum>(() => new LocalServicesLeadSurveySatisfiedReasonEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalServicesLeadSurveySatisfiedReasonEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.LocalServicesLeadSurveySatisfiedReasonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadSurveySatisfiedReasonEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadSurveySatisfiedReasonEnum(LocalServicesLeadSurveySatisfiedReasonEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesLeadSurveySatisfiedReasonEnum Clone() {
      return new LocalServicesLeadSurveySatisfiedReasonEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalServicesLeadSurveySatisfiedReasonEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalServicesLeadSurveySatisfiedReasonEnum other) {
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
    public void MergeFrom(LocalServicesLeadSurveySatisfiedReasonEnum other) {
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
    /// <summary>Container for nested types declared in the LocalServicesLeadSurveySatisfiedReasonEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Provider's reason for being satisfied with the lead.
      /// </summary>
      public enum SurveySatisfiedReason {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Other reasons.
        /// </summary>
        [pbr::OriginalName("OTHER_SATISFIED_REASON")] OtherSatisfiedReason = 2,
        /// <summary>
        /// Lead converted into a booked customer or client.
        /// </summary>
        [pbr::OriginalName("BOOKED_CUSTOMER")] BookedCustomer = 3,
        /// <summary>
        /// Lead could convert into a booked customer or client soon.
        /// </summary>
        [pbr::OriginalName("LIKELY_BOOKED_CUSTOMER")] LikelyBookedCustomer = 4,
        /// <summary>
        /// Lead was related to the services the business offers.
        /// </summary>
        [pbr::OriginalName("SERVICE_RELATED")] ServiceRelated = 5,
        /// <summary>
        /// Lead was for a service that generates high value for the business.
        /// </summary>
        [pbr::OriginalName("HIGH_VALUE_SERVICE")] HighValueService = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
