// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/conversion_tracking_status_enum.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/conversion_tracking_status_enum.proto</summary>
  public static partial class ConversionTrackingStatusEnumReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/conversion_tracking_status_enum.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ConversionTrackingStatusEnumReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkRnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvY29udmVyc2lvbl90",
            "cmFja2luZ19zdGF0dXNfZW51bS5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjExLmVudW1zIoMCChxDb252ZXJzaW9uVHJhY2tpbmdTdGF0dXNFbnVt",
            "IuIBChhDb252ZXJzaW9uVHJhY2tpbmdTdGF0dXMSDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESGgoWTk9UX0NPTlZFUlNJT05fVFJBQ0tFRBACEicK",
            "I0NPTlZFUlNJT05fVFJBQ0tJTkdfTUFOQUdFRF9CWV9TRUxGEAMSLworQ09O",
            "VkVSU0lPTl9UUkFDS0lOR19NQU5BR0VEX0JZX1RISVNfTUFOQUdFUhAEEjIK",
            "LkNPTlZFUlNJT05fVFJBQ0tJTkdfTUFOQUdFRF9CWV9BTk9USEVSX01BTkFH",
            "RVIQBUL7AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5lbnVtc0Ih",
            "Q29udmVyc2lvblRyYWNraW5nU3RhdHVzRW51bVByb3RvUAFaQ2dvb2dsZS5n",
            "b2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92",
            "MTEvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "MTEuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcRW51bXPqAiJH",
            "b29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTE6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.ConversionTrackingStatusEnum), global::Google.Ads.GoogleAds.V11.Enums.ConversionTrackingStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.ConversionTrackingStatusEnum.Types.ConversionTrackingStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum representing the conversion tracking status of the
  /// customer.
  /// </summary>
  public sealed partial class ConversionTrackingStatusEnum : pb::IMessage<ConversionTrackingStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConversionTrackingStatusEnum> _parser = new pb::MessageParser<ConversionTrackingStatusEnum>(() => new ConversionTrackingStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConversionTrackingStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.ConversionTrackingStatusEnumReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionTrackingStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionTrackingStatusEnum(ConversionTrackingStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConversionTrackingStatusEnum Clone() {
      return new ConversionTrackingStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConversionTrackingStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConversionTrackingStatusEnum other) {
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
    public void MergeFrom(ConversionTrackingStatusEnum other) {
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
    /// <summary>Container for nested types declared in the ConversionTrackingStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Conversion Tracking status of the customer.
      /// </summary>
      public enum ConversionTrackingStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Customer does not use any conversion tracking.
        /// </summary>
        [pbr::OriginalName("NOT_CONVERSION_TRACKED")] NotConversionTracked = 2,
        /// <summary>
        /// The conversion actions are created and managed by this customer.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_MANAGED_BY_SELF")] ConversionTrackingManagedBySelf = 3,
        /// <summary>
        /// The conversion actions are created and managed by the manager specified
        /// in the request's `login-customer-id`.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_MANAGED_BY_THIS_MANAGER")] ConversionTrackingManagedByThisManager = 4,
        /// <summary>
        /// The conversion actions are created and managed by a manager different
        /// from the customer or manager specified in the request's
        /// `login-customer-id`.
        /// </summary>
        [pbr::OriginalName("CONVERSION_TRACKING_MANAGED_BY_ANOTHER_MANAGER")] ConversionTrackingManagedByAnotherManager = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
