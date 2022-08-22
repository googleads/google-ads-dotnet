// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/simulation_modification_method.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/simulation_modification_method.proto</summary>
  public static partial class SimulationModificationMethodReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/simulation_modification_method.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SimulationModificationMethodReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvc2ltdWxhdGlvbl9t",
            "b2RpZmljYXRpb25fbWV0aG9kLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTAuZW51bXMihwEKIFNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2RF",
            "bnVtImMKHFNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2QSDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESCwoHVU5JRk9STRACEgsKB0RFRkFVTFQQ",
            "AxILCgdTQ0FMSU5HEARC+wEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTAuZW51bXNCIVNpbXVsYXRpb25Nb2RpZmljYXRpb25NZXRob2RQcm90b1AB",
            "WkNnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjEwL2VudW1zO2VudW1zogIDR0FBqgIeR29vZ2xlLkFkcy5H",
            "b29nbGVBZHMuVjEwLkVudW1zygIeR29vZ2xlXEFkc1xHb29nbGVBZHNcVjEw",
            "XEVudW1z6gIiR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEwOjpFbnVtc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.SimulationModificationMethodEnum), global::Google.Ads.GoogleAds.V10.Enums.SimulationModificationMethodEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.SimulationModificationMethodEnum.Types.SimulationModificationMethod) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the method by which a simulation modifies
  /// a field.
  /// </summary>
  public sealed partial class SimulationModificationMethodEnum : pb::IMessage<SimulationModificationMethodEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SimulationModificationMethodEnum> _parser = new pb::MessageParser<SimulationModificationMethodEnum>(() => new SimulationModificationMethodEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SimulationModificationMethodEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.SimulationModificationMethodReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SimulationModificationMethodEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SimulationModificationMethodEnum(SimulationModificationMethodEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SimulationModificationMethodEnum Clone() {
      return new SimulationModificationMethodEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SimulationModificationMethodEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SimulationModificationMethodEnum other) {
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
    public void MergeFrom(SimulationModificationMethodEnum other) {
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
    /// <summary>Container for nested types declared in the SimulationModificationMethodEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing the method by which a simulation modifies a field.
      /// </summary>
      public enum SimulationModificationMethod {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The values in a simulation were applied to all children of a given
        /// resource uniformly. Overrides on child resources were not respected.
        /// </summary>
        [pbr::OriginalName("UNIFORM")] Uniform = 2,
        /// <summary>
        /// The values in a simulation were applied to the given resource.
        /// Overrides on child resources were respected, and traffic estimates
        /// do not include these resources.
        /// </summary>
        [pbr::OriginalName("DEFAULT")] Default = 3,
        /// <summary>
        /// The values in a simulation were all scaled by the same factor.
        /// For example, in a simulated TargetCpa campaign, the campaign target and
        /// all ad group targets were scaled by a factor of X.
        /// </summary>
        [pbr::OriginalName("SCALING")] Scaling = 4,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
