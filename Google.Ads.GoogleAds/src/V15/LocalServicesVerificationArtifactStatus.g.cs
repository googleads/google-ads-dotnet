// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/enums/local_services_verification_artifact_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/enums/local_services_verification_artifact_status.proto</summary>
  public static partial class LocalServicesVerificationArtifactStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/enums/local_services_verification_artifact_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocalServicesVerificationArtifactStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ClBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZW51bXMvbG9jYWxfc2Vydmlj",
            "ZXNfdmVyaWZpY2F0aW9uX2FydGlmYWN0X3N0YXR1cy5wcm90bxIeZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE1LmVudW1zIr4BCitMb2NhbFNlcnZpY2VzVmVy",
            "aWZpY2F0aW9uQXJ0aWZhY3RTdGF0dXNFbnVtIo4BCidMb2NhbFNlcnZpY2Vz",
            "VmVyaWZpY2F0aW9uQXJ0aWZhY3RTdGF0dXMSDwoLVU5TUEVDSUZJRUQQABIL",
            "CgdVTktOT1dOEAESCgoGUEFTU0VEEAISCgoGRkFJTEVEEAMSCwoHUEVORElO",
            "RxAEEhEKDU5PX1NVQk1JU1NJT04QBRINCglDQU5DRUxMRUQQBkKGAgoiY29t",
            "Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5lbnVtc0IsTG9jYWxTZXJ2aWNl",
            "c1ZlcmlmaWNhdGlvbkFydGlmYWN0U3RhdHVzUHJvdG9QAVpDZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "NS9lbnVtcztlbnVtc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "NS5FbnVtc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNVxFbnVtc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxNTo6RW51bXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Enums.LocalServicesVerificationArtifactStatusEnum), global::Google.Ads.GoogleAds.V15.Enums.LocalServicesVerificationArtifactStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Enums.LocalServicesVerificationArtifactStatusEnum.Types.LocalServicesVerificationArtifactStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the status of local services verification
  /// artifact.
  /// </summary>
  public sealed partial class LocalServicesVerificationArtifactStatusEnum : pb::IMessage<LocalServicesVerificationArtifactStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<LocalServicesVerificationArtifactStatusEnum> _parser = new pb::MessageParser<LocalServicesVerificationArtifactStatusEnum>(() => new LocalServicesVerificationArtifactStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<LocalServicesVerificationArtifactStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Enums.LocalServicesVerificationArtifactStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesVerificationArtifactStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesVerificationArtifactStatusEnum(LocalServicesVerificationArtifactStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public LocalServicesVerificationArtifactStatusEnum Clone() {
      return new LocalServicesVerificationArtifactStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as LocalServicesVerificationArtifactStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(LocalServicesVerificationArtifactStatusEnum other) {
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
    public void MergeFrom(LocalServicesVerificationArtifactStatusEnum other) {
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
    /// <summary>Container for nested types declared in the LocalServicesVerificationArtifactStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enums describing statuses of a local services verification artifact.
      /// </summary>
      public enum LocalServicesVerificationArtifactStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Artifact has passed verification.
        /// </summary>
        [pbr::OriginalName("PASSED")] Passed = 2,
        /// <summary>
        /// Artifact has failed verification.
        /// </summary>
        [pbr::OriginalName("FAILED")] Failed = 3,
        /// <summary>
        /// Artifact is in the process of verification.
        /// </summary>
        [pbr::OriginalName("PENDING")] Pending = 4,
        /// <summary>
        /// Artifact needs user to upload information before it is verified.
        /// </summary>
        [pbr::OriginalName("NO_SUBMISSION")] NoSubmission = 5,
        /// <summary>
        /// Artifact has been cancelled by the user.
        /// </summary>
        [pbr::OriginalName("CANCELLED")] Cancelled = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
