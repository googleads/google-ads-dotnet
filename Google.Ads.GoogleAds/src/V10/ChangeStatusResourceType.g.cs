// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v10/enums/change_status_resource_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V10.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v10/enums/change_status_resource_type.proto</summary>
  public static partial class ChangeStatusResourceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v10/enums/change_status_resource_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ChangeStatusResourceTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MTAvZW51bXMvY2hhbmdlX3N0YXR1",
            "c19yZXNvdXJjZV90eXBlLnByb3RvEh5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MTAuZW51bXMigAMKHENoYW5nZVN0YXR1c1Jlc291cmNlVHlwZUVudW0i3wIK",
            "GENoYW5nZVN0YXR1c1Jlc291cmNlVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsK",
            "B1VOS05PV04QARIMCghBRF9HUk9VUBADEg8KC0FEX0dST1VQX0FEEAQSFgoS",
            "QURfR1JPVVBfQ1JJVEVSSU9OEAUSDAoIQ0FNUEFJR04QBhIWChJDQU1QQUlH",
            "Tl9DUklURVJJT04QBxIICgRGRUVEEAkSDQoJRkVFRF9JVEVNEAoSEQoNQURf",
            "R1JPVVBfRkVFRBALEhEKDUNBTVBBSUdOX0ZFRUQQDBIZChVBRF9HUk9VUF9C",
            "SURfTU9ESUZJRVIQDRIOCgpTSEFSRURfU0VUEA4SFwoTQ0FNUEFJR05fU0hB",
            "UkVEX1NFVBAPEgkKBUFTU0VUEBASEgoOQ1VTVE9NRVJfQVNTRVQQERISCg5D",
            "QU1QQUlHTl9BU1NFVBASEhIKDkFEX0dST1VQX0FTU0VUEBNC9wEKImNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTAuZW51bXNCHUNoYW5nZVN0YXR1c1Jl",
            "c291cmNlVHlwZVByb3RvUAFaQ2dvb2dsZS5nb2xhbmcub3JnL2dlbnByb3Rv",
            "L2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTAvZW51bXM7ZW51bXOiAgNH",
            "QUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTAuRW51bXPKAh5Hb29nbGVc",
            "QWRzXEdvb2dsZUFkc1xWMTBcRW51bXPqAiJHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWMTA6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V10.Enums.ChangeStatusResourceTypeEnum), global::Google.Ads.GoogleAds.V10.Enums.ChangeStatusResourceTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V10.Enums.ChangeStatusResourceTypeEnum.Types.ChangeStatusResourceType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing supported resource types for the ChangeStatus
  /// resource.
  /// </summary>
  public sealed partial class ChangeStatusResourceTypeEnum : pb::IMessage<ChangeStatusResourceTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeStatusResourceTypeEnum> _parser = new pb::MessageParser<ChangeStatusResourceTypeEnum>(() => new ChangeStatusResourceTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeStatusResourceTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V10.Enums.ChangeStatusResourceTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusResourceTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusResourceTypeEnum(ChangeStatusResourceTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeStatusResourceTypeEnum Clone() {
      return new ChangeStatusResourceTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeStatusResourceTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeStatusResourceTypeEnum other) {
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
    public void MergeFrom(ChangeStatusResourceTypeEnum other) {
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
    /// <summary>Container for nested types declared in the ChangeStatusResourceTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum listing the resource types support by the ChangeStatus resource.
      /// </summary>
      public enum ChangeStatusResourceType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents an unclassified resource unknown
        /// in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// An AdGroup resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP")] AdGroup = 3,
        /// <summary>
        /// An AdGroupAd resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_AD")] AdGroupAd = 4,
        /// <summary>
        /// An AdGroupCriterion resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_CRITERION")] AdGroupCriterion = 5,
        /// <summary>
        /// A Campaign resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN")] Campaign = 6,
        /// <summary>
        /// A CampaignCriterion resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CRITERION")] CampaignCriterion = 7,
        /// <summary>
        /// A Feed resource change.
        /// </summary>
        [pbr::OriginalName("FEED")] Feed = 9,
        /// <summary>
        /// A FeedItem resource change.
        /// </summary>
        [pbr::OriginalName("FEED_ITEM")] FeedItem = 10,
        /// <summary>
        /// An AdGroupFeed resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_FEED")] AdGroupFeed = 11,
        /// <summary>
        /// A CampaignFeed resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_FEED")] CampaignFeed = 12,
        /// <summary>
        /// An AdGroupBidModifier resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_BID_MODIFIER")] AdGroupBidModifier = 13,
        /// <summary>
        /// A SharedSet resource change.
        /// </summary>
        [pbr::OriginalName("SHARED_SET")] SharedSet = 14,
        /// <summary>
        /// A CampaignSharedSet resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_SHARED_SET")] CampaignSharedSet = 15,
        /// <summary>
        /// An Asset resource change.
        /// </summary>
        [pbr::OriginalName("ASSET")] Asset = 16,
        /// <summary>
        /// A CustomerAsset resource change.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_ASSET")] CustomerAsset = 17,
        /// <summary>
        /// A CampaignAsset resource change.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_ASSET")] CampaignAsset = 18,
        /// <summary>
        /// An AdGroupAsset resource change.
        /// </summary>
        [pbr::OriginalName("AD_GROUP_ASSET")] AdGroupAsset = 19,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
