// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v19/enums/product_link_invitation_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V19.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v19/enums/product_link_invitation_status.proto</summary>
  public static partial class ProductLinkInvitationStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v19/enums/product_link_invitation_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductLinkInvitationStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92MTkvZW51bXMvcHJvZHVjdF9saW5r",
            "X2ludml0YXRpb25fc3RhdHVzLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52MTkuZW51bXMiugEKH1Byb2R1Y3RMaW5rSW52aXRhdGlvblN0YXR1c0Vu",
            "dW0ilgEKG1Byb2R1Y3RMaW5rSW52aXRhdGlvblN0YXR1cxIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIMCghBQ0NFUFRFRBACEg0KCVJFUVVFU1RF",
            "RBADEhQKEFBFTkRJTkdfQVBQUk9WQUwQBBILCgdSRVZPS0VEEAUSDAoIUkVK",
            "RUNURUQQBhILCgdFWFBJUkVEEAdC+gEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MTkuZW51bXNCIFByb2R1Y3RMaW5rSW52aXRhdGlvblN0YXR1c1By",
            "b3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92MTkvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTkuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWMTlcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTk6OkVu",
            "dW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V19.Enums.ProductLinkInvitationStatusEnum), global::Google.Ads.GoogleAds.V19.Enums.ProductLinkInvitationStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V19.Enums.ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of a product link
  /// invitation.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ProductLinkInvitationStatusEnum : pb::IMessage<ProductLinkInvitationStatusEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductLinkInvitationStatusEnum> _parser = new pb::MessageParser<ProductLinkInvitationStatusEnum>(() => new ProductLinkInvitationStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProductLinkInvitationStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V19.Enums.ProductLinkInvitationStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductLinkInvitationStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductLinkInvitationStatusEnum(ProductLinkInvitationStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProductLinkInvitationStatusEnum Clone() {
      return new ProductLinkInvitationStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProductLinkInvitationStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProductLinkInvitationStatusEnum other) {
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
    public void MergeFrom(ProductLinkInvitationStatusEnum other) {
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
    /// <summary>Container for nested types declared in the ProductLinkInvitationStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Describes the possible statuses for an invitation between a Google Ads
      /// customer and another account.
      /// </summary>
      public enum ProductLinkInvitationStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The invitation is accepted.
        /// </summary>
        [pbr::OriginalName("ACCEPTED")] Accepted = 2,
        /// <summary>
        /// An invitation has been sent to the other account. A user on the other
        /// account may now accept the invitation by setting the status to ACCEPTED.
        /// </summary>
        [pbr::OriginalName("REQUESTED")] Requested = 3,
        /// <summary>
        /// This invitation has been sent by a user on the other account. It may be
        /// accepted by a user on this account by setting the status to ACCEPTED.
        /// </summary>
        [pbr::OriginalName("PENDING_APPROVAL")] PendingApproval = 4,
        /// <summary>
        /// The invitation is revoked by the user who sent the invitation.
        /// </summary>
        [pbr::OriginalName("REVOKED")] Revoked = 5,
        /// <summary>
        /// The invitation has been rejected by the invitee.
        /// </summary>
        [pbr::OriginalName("REJECTED")] Rejected = 6,
        /// <summary>
        /// The invitation has timed out before being accepted by the
        /// invitee.
        /// </summary>
        [pbr::OriginalName("EXPIRED")] Expired = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
