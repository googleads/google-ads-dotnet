// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/customer_negative_criterion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/customer_negative_criterion.proto</summary>
  public static partial class CustomerNegativeCriterionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/customer_negative_criterion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerNegativeCriterionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "bmVnYXRpdmVfY3JpdGVyaW9uLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52OS5yZXNvdXJjZXMaLWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y5L2NvbW1v",
            "bi9jcml0ZXJpYS5wcm90bxoyZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjkvZW51",
            "bXMvY3JpdGVyaW9uX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVo",
            "YXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8i1wYKGUN1",
            "c3RvbWVyTmVnYXRpdmVDcml0ZXJpb24SUQoNcmVzb3VyY2VfbmFtZRgBIAEo",
            "CUI64EEF+kE0CjJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJO",
            "ZWdhdGl2ZUNyaXRlcmlvbhIUCgJpZBgKIAEoA0ID4EEDSAGIAQESUQoEdHlw",
            "ZRgDIAEoDjI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmVudW1zLkNyaXRl",
            "cmlvblR5cGVFbnVtLkNyaXRlcmlvblR5cGVCA+BBAxJOCg1jb250ZW50X2xh",
            "YmVsGAQgASgLMjAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuY29tbW9uLkNv",
            "bnRlbnRMYWJlbEluZm9CA+BBBUgAElgKEm1vYmlsZV9hcHBsaWNhdGlvbhgF",
            "IAEoCzI1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LmNvbW1vbi5Nb2JpbGVB",
            "cHBsaWNhdGlvbkluZm9CA+BBBUgAElkKE21vYmlsZV9hcHBfY2F0ZWdvcnkY",
            "BiABKAsyNS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5jb21tb24uTW9iaWxl",
            "QXBwQ2F0ZWdvcnlJbmZvQgPgQQVIABJHCglwbGFjZW1lbnQYByABKAsyLS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52OS5jb21tb24uUGxhY2VtZW50SW5mb0ID",
            "4EEFSAASTgoNeW91dHViZV92aWRlbxgIIAEoCzIwLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnY5LmNvbW1vbi5Zb3VUdWJlVmlkZW9JbmZvQgPgQQVIABJSCg95",
            "b3V0dWJlX2NoYW5uZWwYCSABKAsyMi5nb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "OS5jb21tb24uWW91VHViZUNoYW5uZWxJbmZvQgPgQQVIADp46kF1CjJnb29n",
            "bGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJOZWdhdGl2ZUNyaXRlcmlv",
            "bhI/Y3VzdG9tZXJzL3tjdXN0b21lcl9pZH0vY3VzdG9tZXJOZWdhdGl2ZUNy",
            "aXRlcmlhL3tjcml0ZXJpb25faWR9QgsKCWNyaXRlcmlvbkIFCgNfaWRCiwIK",
            "JWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52OS5yZXNvdXJjZXNCHkN1c3Rv",
            "bWVyTmVnYXRpdmVDcml0ZXJpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjkvcmVzb3Vy",
            "Y2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRzLlY5",
            "LlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFY5XFJlc291cmNl",
            "c+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlY5OjpSZXNvdXJjZXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CustomerNegativeCriterion), global::Google.Ads.GoogleAds.V9.Resources.CustomerNegativeCriterion.Parser, new[]{ "ResourceName", "Id", "Type", "ContentLabel", "MobileApplication", "MobileAppCategory", "Placement", "YoutubeVideo", "YoutubeChannel" }, new[]{ "Criterion", "Id" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A negative criterion for exclusions at the customer level.
  /// </summary>
  public sealed partial class CustomerNegativeCriterion : pb::IMessage<CustomerNegativeCriterion>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerNegativeCriterion> _parser = new pb::MessageParser<CustomerNegativeCriterion>(() => new CustomerNegativeCriterion());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerNegativeCriterion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CustomerNegativeCriterionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerNegativeCriterion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerNegativeCriterion(CustomerNegativeCriterion other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      type_ = other.type_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.ContentLabel:
          ContentLabel = other.ContentLabel.Clone();
          break;
        case CriterionOneofCase.MobileApplication:
          MobileApplication = other.MobileApplication.Clone();
          break;
        case CriterionOneofCase.MobileAppCategory:
          MobileAppCategory = other.MobileAppCategory.Clone();
          break;
        case CriterionOneofCase.Placement:
          Placement = other.Placement.Clone();
          break;
        case CriterionOneofCase.YoutubeVideo:
          YoutubeVideo = other.YoutubeVideo.Clone();
          break;
        case CriterionOneofCase.YoutubeChannel:
          YoutubeChannel = other.YoutubeChannel.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerNegativeCriterion Clone() {
      return new CustomerNegativeCriterion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer negative criterion.
    /// Customer negative criterion resource names have the form:
    ///
    /// `customers/{customer_id}/customerNegativeCriteria/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 10;
    private long id_;
    /// <summary>
    /// Output only. The ID of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType type_ = global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified;
    /// <summary>
    /// Output only. The type of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "content_label" field.</summary>
    public const int ContentLabelFieldNumber = 4;
    /// <summary>
    /// Immutable. ContentLabel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo ContentLabel {
      get { return criterionCase_ == CriterionOneofCase.ContentLabel ? (global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.ContentLabel;
      }
    }

    /// <summary>Field number for the "mobile_application" field.</summary>
    public const int MobileApplicationFieldNumber = 5;
    /// <summary>
    /// Immutable. MobileApplication.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo MobileApplication {
      get { return criterionCase_ == CriterionOneofCase.MobileApplication ? (global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileApplication;
      }
    }

    /// <summary>Field number for the "mobile_app_category" field.</summary>
    public const int MobileAppCategoryFieldNumber = 6;
    /// <summary>
    /// Immutable. MobileAppCategory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo MobileAppCategory {
      get { return criterionCase_ == CriterionOneofCase.MobileAppCategory ? (global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileAppCategory;
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 7;
    /// <summary>
    /// Immutable. Placement.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.PlacementInfo Placement {
      get { return criterionCase_ == CriterionOneofCase.Placement ? (global::Google.Ads.GoogleAds.V9.Common.PlacementInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Placement;
      }
    }

    /// <summary>Field number for the "youtube_video" field.</summary>
    public const int YoutubeVideoFieldNumber = 8;
    /// <summary>
    /// Immutable. YouTube Video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo YoutubeVideo {
      get { return criterionCase_ == CriterionOneofCase.YoutubeVideo ? (global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeVideo;
      }
    }

    /// <summary>Field number for the "youtube_channel" field.</summary>
    public const int YoutubeChannelFieldNumber = 9;
    /// <summary>
    /// Immutable. YouTube Channel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo YoutubeChannel {
      get { return criterionCase_ == CriterionOneofCase.YoutubeChannel ? (global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeChannel;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      ContentLabel = 4,
      MobileApplication = 5,
      MobileAppCategory = 6,
      Placement = 7,
      YoutubeVideo = 8,
      YoutubeChannel = 9,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerNegativeCriterion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerNegativeCriterion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(ContentLabel, other.ContentLabel)) return false;
      if (!object.Equals(MobileApplication, other.MobileApplication)) return false;
      if (!object.Equals(MobileAppCategory, other.MobileAppCategory)) return false;
      if (!object.Equals(Placement, other.Placement)) return false;
      if (!object.Equals(YoutubeVideo, other.YoutubeVideo)) return false;
      if (!object.Equals(YoutubeChannel, other.YoutubeChannel)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) hash ^= Type.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.ContentLabel) hash ^= ContentLabel.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileApplication) hash ^= MobileApplication.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) hash ^= MobileAppCategory.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Placement) hash ^= Placement.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) hash ^= YoutubeVideo.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) hash ^= YoutubeChannel.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.ContentLabel) {
        output.WriteRawTag(34);
        output.WriteMessage(ContentLabel);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(42);
        output.WriteMessage(MobileApplication);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(50);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(66);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(74);
        output.WriteMessage(YoutubeChannel);
      }
      if (HasId) {
        output.WriteRawTag(80);
        output.WriteInt64(Id);
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
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.ContentLabel) {
        output.WriteRawTag(34);
        output.WriteMessage(ContentLabel);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(42);
        output.WriteMessage(MobileApplication);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(50);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(66);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(74);
        output.WriteMessage(YoutubeChannel);
      }
      if (HasId) {
        output.WriteRawTag(80);
        output.WriteInt64(Id);
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
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (Type != global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.ContentLabel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContentLabel);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileApplication);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeChannel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerNegativeCriterion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.Type != global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        Type = other.Type;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.ContentLabel:
          if (ContentLabel == null) {
            ContentLabel = new global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo();
          }
          ContentLabel.MergeFrom(other.ContentLabel);
          break;
        case CriterionOneofCase.MobileApplication:
          if (MobileApplication == null) {
            MobileApplication = new global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo();
          }
          MobileApplication.MergeFrom(other.MobileApplication);
          break;
        case CriterionOneofCase.MobileAppCategory:
          if (MobileAppCategory == null) {
            MobileAppCategory = new global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo();
          }
          MobileAppCategory.MergeFrom(other.MobileAppCategory);
          break;
        case CriterionOneofCase.Placement:
          if (Placement == null) {
            Placement = new global::Google.Ads.GoogleAds.V9.Common.PlacementInfo();
          }
          Placement.MergeFrom(other.Placement);
          break;
        case CriterionOneofCase.YoutubeVideo:
          if (YoutubeVideo == null) {
            YoutubeVideo = new global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo();
          }
          YoutubeVideo.MergeFrom(other.YoutubeVideo);
          break;
        case CriterionOneofCase.YoutubeChannel:
          if (YoutubeChannel == null) {
            YoutubeChannel = new global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo();
          }
          YoutubeChannel.MergeFrom(other.YoutubeChannel);
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 34: {
            global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo();
            if (criterionCase_ == CriterionOneofCase.ContentLabel) {
              subBuilder.MergeFrom(ContentLabel);
            }
            input.ReadMessage(subBuilder);
            ContentLabel = subBuilder;
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V9.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
          case 80: {
            Id = input.ReadInt64();
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
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 34: {
            global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.ContentLabelInfo();
            if (criterionCase_ == CriterionOneofCase.ContentLabel) {
              subBuilder.MergeFrom(ContentLabel);
            }
            input.ReadMessage(subBuilder);
            ContentLabel = subBuilder;
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V9.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V9.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
          case 80: {
            Id = input.ReadInt64();
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
