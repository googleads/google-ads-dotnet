// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v15/errors/customer_sk_ad_network_conversion_value_schema_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V15.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v15/errors/customer_sk_ad_network_conversion_value_schema_error.proto</summary>
  public static partial class CustomerSkAdNetworkConversionValueSchemaErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v15/errors/customer_sk_ad_network_conversion_value_schema_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerSkAdNetworkConversionValueSchemaErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTUvZXJyb3JzL2N1c3RvbWVyX3Nr",
            "X2FkX25ldHdvcmtfY29udmVyc2lvbl92YWx1ZV9zY2hlbWFfZXJyb3IucHJv",
            "dG8SH2dvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxNS5lcnJvcnMi2QEKMUN1c3Rv",
            "bWVyU2tBZE5ldHdvcmtDb252ZXJzaW9uVmFsdWVTY2hlbWFFcnJvckVudW0i",
            "owEKLUN1c3RvbWVyU2tBZE5ldHdvcmtDb252ZXJzaW9uVmFsdWVTY2hlbWFF",
            "cnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARITCg9JTlZBTElE",
            "X0xJTktfSUQQAhISCg5JTlZBTElEX0FQUF9JRBADEhIKDklOVkFMSURfU0NI",
            "RU1BEAQSFwoTTElOS19DT0RFX05PVF9GT1VORBAFQpICCiNjb20uZ29vZ2xl",
            "LmFkcy5nb29nbGVhZHMudjE1LmVycm9yc0IyQ3VzdG9tZXJTa0FkTmV0d29y",
            "a0NvbnZlcnNpb25WYWx1ZVNjaGVtYUVycm9yUHJvdG9QAVpFZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "NS9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjE1LkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxNVxFcnJvcnPq",
            "AiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTU6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V15.Errors.CustomerSkAdNetworkConversionValueSchemaErrorEnum), global::Google.Ads.GoogleAds.V15.Errors.CustomerSkAdNetworkConversionValueSchemaErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V15.Errors.CustomerSkAdNetworkConversionValueSchemaErrorEnum.Types.CustomerSkAdNetworkConversionValueSchemaError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible
  /// CustomerSkAdNetworkConversionValueSchema errors.
  /// </summary>
  public sealed partial class CustomerSkAdNetworkConversionValueSchemaErrorEnum : pb::IMessage<CustomerSkAdNetworkConversionValueSchemaErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerSkAdNetworkConversionValueSchemaErrorEnum> _parser = new pb::MessageParser<CustomerSkAdNetworkConversionValueSchemaErrorEnum>(() => new CustomerSkAdNetworkConversionValueSchemaErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerSkAdNetworkConversionValueSchemaErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V15.Errors.CustomerSkAdNetworkConversionValueSchemaErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerSkAdNetworkConversionValueSchemaErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerSkAdNetworkConversionValueSchemaErrorEnum(CustomerSkAdNetworkConversionValueSchemaErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerSkAdNetworkConversionValueSchemaErrorEnum Clone() {
      return new CustomerSkAdNetworkConversionValueSchemaErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerSkAdNetworkConversionValueSchemaErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerSkAdNetworkConversionValueSchemaErrorEnum other) {
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
    public void MergeFrom(CustomerSkAdNetworkConversionValueSchemaErrorEnum other) {
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
    /// <summary>Container for nested types declared in the CustomerSkAdNetworkConversionValueSchemaErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible CustomerSkAdNetworkConversionValueSchema errors.
      /// </summary>
      public enum CustomerSkAdNetworkConversionValueSchemaError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The customer link ID provided is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_LINK_ID")] InvalidLinkId = 2,
        /// <summary>
        /// The app ID provided is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 3,
        /// <summary>
        /// The conversion value schema provided is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_SCHEMA")] InvalidSchema = 4,
        /// <summary>
        /// The customer link id provided could not be found.
        /// </summary>
        [pbr::OriginalName("LINK_CODE_NOT_FOUND")] LinkCodeNotFound = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
