// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/feed_item_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/feed_item_set.proto</summary>
  public static partial class FeedItemSetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/feed_item_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvZmVlZF9pdGVt",
            "X3NldC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkucmVzb3VyY2Vz",
            "GkRnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9jb21tb24vZmVlZF9pdGVtX3Nl",
            "dF9maWx0ZXJfdHlwZV9pbmZvcy5wcm90bxo4Z29vZ2xlL2Fkcy9nb29nbGVh",
            "ZHMvdjkvZW51bXMvZmVlZF9pdGVtX3NldF9zdGF0dXMucHJvdG8aH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8i8gQKC0ZlZWRJdGVtU2V0EkMKDXJlc291cmNlX25hbWUYASAB",
            "KAlCLOBBBfpBJgokZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL0ZlZWRJdGVt",
            "U2V0EjMKBGZlZWQYAiABKAlCJeBBBfpBHwodZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0ZlZWQSHQoQZmVlZF9pdGVtX3NldF9pZBgDIAEoA0ID4EEDEhQK",
            "DGRpc3BsYXlfbmFtZRgEIAEoCRJbCgZzdGF0dXMYCCABKA4yRi5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52OS5lbnVtcy5GZWVkSXRlbVNldFN0YXR1c0VudW0u",
            "RmVlZEl0ZW1TZXRTdGF0dXNCA+BBAxJfChtkeW5hbWljX2xvY2F0aW9uX3Nl",
            "dF9maWx0ZXIYBSABKAsyOC5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5jb21t",
            "b24uRHluYW1pY0xvY2F0aW9uU2V0RmlsdGVySAAScgolZHluYW1pY19hZmZp",
            "bGlhdGVfbG9jYXRpb25fc2V0X2ZpbHRlchgGIAEoCzJBLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY5LmNvbW1vbi5EeW5hbWljQWZmaWxpYXRlTG9jYXRpb25T",
            "ZXRGaWx0ZXJIADps6kFpCiRnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRmVl",
            "ZEl0ZW1TZXQSQWN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L2ZlZWRJdGVtU2V0",
            "cy97ZmVlZF9pZH1+e2ZlZWRfaXRlbV9zZXRfaWR9QhQKEmR5bmFtaWNfc2V0",
            "X2ZpbHRlckL9AQolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291",
            "cmNlc0IQRmVlZEl0ZW1TZXRQcm90b1ABWkpnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvcmVzb3VyY2Vz",
            "O3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5LlJl",
            "c291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XFJlc291cmNlc+oC",
            "JUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpSZXNvdXJjZXNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Common.FeedItemSetFilterTypeInfosReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.FeedItemSet), global::Google.Ads.GoogleAds.V9.Resources.FeedItemSet.Parser, new[]{ "ResourceName", "Feed", "FeedItemSetId", "DisplayName", "Status", "DynamicLocationSetFilter", "DynamicAffiliateLocationSetFilter" }, new[]{ "DynamicSetFilter" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a set of feed items. The set can be used and shared among certain
  /// feed item features. For instance, the set can be referenced within the
  /// matching functions of CustomerFeed, CampaignFeed, and AdGroupFeed.
  /// </summary>
  public sealed partial class FeedItemSet : pb::IMessage<FeedItemSet>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<FeedItemSet> _parser = new pb::MessageParser<FeedItemSet>(() => new FeedItemSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<FeedItemSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.FeedItemSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSet(FeedItemSet other) : this() {
      resourceName_ = other.resourceName_;
      feed_ = other.feed_;
      feedItemSetId_ = other.feedItemSetId_;
      displayName_ = other.displayName_;
      status_ = other.status_;
      switch (other.DynamicSetFilterCase) {
        case DynamicSetFilterOneofCase.DynamicLocationSetFilter:
          DynamicLocationSetFilter = other.DynamicLocationSetFilter.Clone();
          break;
        case DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter:
          DynamicAffiliateLocationSetFilter = other.DynamicAffiliateLocationSetFilter.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public FeedItemSet Clone() {
      return new FeedItemSet(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the feed item set.
    /// Feed item set resource names have the form:
    /// `customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 2;
    private string feed_ = "";
    /// <summary>
    /// Immutable. The resource name of the feed containing the feed items in the set.
    /// Immutable. Required.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Feed {
      get { return feed_; }
      set {
        feed_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed_item_set_id" field.</summary>
    public const int FeedItemSetIdFieldNumber = 3;
    private long feedItemSetId_;
    /// <summary>
    /// Output only. ID of the set.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long FeedItemSetId {
      get { return feedItemSetId_; }
      set {
        feedItemSetId_ = value;
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 4;
    private string displayName_ = "";
    /// <summary>
    /// Name of the set. Must be unique within the account.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 8;
    private global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus status_ = global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified;
    /// <summary>
    /// Output only. Status of the feed item set.
    /// This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "dynamic_location_set_filter" field.</summary>
    public const int DynamicLocationSetFilterFieldNumber = 5;
    /// <summary>
    /// Filter for dynamic location set.
    /// It is only used for sets of locations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter DynamicLocationSetFilter {
      get { return dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter ? (global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter) dynamicSetFilter_ : null; }
      set {
        dynamicSetFilter_ = value;
        dynamicSetFilterCase_ = value == null ? DynamicSetFilterOneofCase.None : DynamicSetFilterOneofCase.DynamicLocationSetFilter;
      }
    }

    /// <summary>Field number for the "dynamic_affiliate_location_set_filter" field.</summary>
    public const int DynamicAffiliateLocationSetFilterFieldNumber = 6;
    /// <summary>
    /// Filter for dynamic affiliate location set.
    /// This field doesn't apply generally to feed item sets. It is only used for
    /// sets of affiliate locations.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter DynamicAffiliateLocationSetFilter {
      get { return dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter ? (global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter) dynamicSetFilter_ : null; }
      set {
        dynamicSetFilter_ = value;
        dynamicSetFilterCase_ = value == null ? DynamicSetFilterOneofCase.None : DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter;
      }
    }

    private object dynamicSetFilter_;
    /// <summary>Enum of possible cases for the "dynamic_set_filter" oneof.</summary>
    public enum DynamicSetFilterOneofCase {
      None = 0,
      DynamicLocationSetFilter = 5,
      DynamicAffiliateLocationSetFilter = 6,
    }
    private DynamicSetFilterOneofCase dynamicSetFilterCase_ = DynamicSetFilterOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DynamicSetFilterOneofCase DynamicSetFilterCase {
      get { return dynamicSetFilterCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDynamicSetFilter() {
      dynamicSetFilterCase_ = DynamicSetFilterOneofCase.None;
      dynamicSetFilter_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as FeedItemSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(FeedItemSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Feed != other.Feed) return false;
      if (FeedItemSetId != other.FeedItemSetId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Status != other.Status) return false;
      if (!object.Equals(DynamicLocationSetFilter, other.DynamicLocationSetFilter)) return false;
      if (!object.Equals(DynamicAffiliateLocationSetFilter, other.DynamicAffiliateLocationSetFilter)) return false;
      if (DynamicSetFilterCase != other.DynamicSetFilterCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Feed.Length != 0) hash ^= Feed.GetHashCode();
      if (FeedItemSetId != 0L) hash ^= FeedItemSetId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified) hash ^= Status.GetHashCode();
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) hash ^= DynamicLocationSetFilter.GetHashCode();
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) hash ^= DynamicAffiliateLocationSetFilter.GetHashCode();
      hash ^= (int) dynamicSetFilterCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Feed.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Feed);
      }
      if (FeedItemSetId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(FeedItemSetId);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) {
        output.WriteRawTag(42);
        output.WriteMessage(DynamicLocationSetFilter);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) {
        output.WriteRawTag(50);
        output.WriteMessage(DynamicAffiliateLocationSetFilter);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Feed.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Feed);
      }
      if (FeedItemSetId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(FeedItemSetId);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DisplayName);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) {
        output.WriteRawTag(42);
        output.WriteMessage(DynamicLocationSetFilter);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) {
        output.WriteRawTag(50);
        output.WriteMessage(DynamicAffiliateLocationSetFilter);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (Feed.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Feed);
      }
      if (FeedItemSetId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(FeedItemSetId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (Status != global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DynamicLocationSetFilter);
      }
      if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(DynamicAffiliateLocationSetFilter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(FeedItemSet other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Feed.Length != 0) {
        Feed = other.Feed;
      }
      if (other.FeedItemSetId != 0L) {
        FeedItemSetId = other.FeedItemSetId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus.Unspecified) {
        Status = other.Status;
      }
      switch (other.DynamicSetFilterCase) {
        case DynamicSetFilterOneofCase.DynamicLocationSetFilter:
          if (DynamicLocationSetFilter == null) {
            DynamicLocationSetFilter = new global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter();
          }
          DynamicLocationSetFilter.MergeFrom(other.DynamicLocationSetFilter);
          break;
        case DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter:
          if (DynamicAffiliateLocationSetFilter == null) {
            DynamicAffiliateLocationSetFilter = new global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter();
          }
          DynamicAffiliateLocationSetFilter.MergeFrom(other.DynamicAffiliateLocationSetFilter);
          break;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Feed = input.ReadString();
            break;
          }
          case 24: {
            FeedItemSetId = input.ReadInt64();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter subBuilder = new global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter();
            if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) {
              subBuilder.MergeFrom(DynamicLocationSetFilter);
            }
            input.ReadMessage(subBuilder);
            DynamicLocationSetFilter = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter subBuilder = new global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter();
            if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) {
              subBuilder.MergeFrom(DynamicAffiliateLocationSetFilter);
            }
            input.ReadMessage(subBuilder);
            DynamicAffiliateLocationSetFilter = subBuilder;
            break;
          }
          case 64: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus) input.ReadEnum();
            break;
          }
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            Feed = input.ReadString();
            break;
          }
          case 24: {
            FeedItemSetId = input.ReadInt64();
            break;
          }
          case 34: {
            DisplayName = input.ReadString();
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter subBuilder = new global::Google.Ads.GoogleAds.V9.Common.DynamicLocationSetFilter();
            if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicLocationSetFilter) {
              subBuilder.MergeFrom(DynamicLocationSetFilter);
            }
            input.ReadMessage(subBuilder);
            DynamicLocationSetFilter = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter subBuilder = new global::Google.Ads.GoogleAds.V9.Common.DynamicAffiliateLocationSetFilter();
            if (dynamicSetFilterCase_ == DynamicSetFilterOneofCase.DynamicAffiliateLocationSetFilter) {
              subBuilder.MergeFrom(DynamicAffiliateLocationSetFilter);
            }
            input.ReadMessage(subBuilder);
            DynamicAffiliateLocationSetFilter = subBuilder;
            break;
          }
          case 64: {
            Status = (global::Google.Ads.GoogleAds.V9.Enums.FeedItemSetStatusEnum.Types.FeedItemSetStatus) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
