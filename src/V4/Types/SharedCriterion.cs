// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/resources/shared_criterion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/resources/shared_criterion.proto</summary>
  public static partial class SharedCriterionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/resources/shared_criterion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedCriterionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9yZXNvdXJjZXMvc2hhcmVkX2Ny",
            "aXRlcmlvbi5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQucmVzb3Vy",
            "Y2VzGi1nb29nbGUvYWRzL2dvb2dsZWFkcy92NC9jb21tb24vY3JpdGVyaWEu",
            "cHJvdG8aMmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y0L2VudW1zL2NyaXRlcmlv",
            "bl90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3Rv",
            "Ghlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29nbGUvcHJvdG9idWYv",
            "d3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "ngcKD1NoYXJlZENyaXRlcmlvbhJHCg1yZXNvdXJjZV9uYW1lGAEgASgJQjDg",
            "QQX6QSoKKGdvb2dsZWFkcy5nb29nbGVhcGlzLmNvbS9TaGFyZWRDcml0ZXJp",
            "b24SXAoKc2hhcmVkX3NldBgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJp",
            "bmdWYWx1ZUIq4EEF+kEkCiJnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vU2hh",
            "cmVkU2V0EjYKDGNyaXRlcmlvbl9pZBgaIAEoCzIbLmdvb2dsZS5wcm90b2J1",
            "Zi5JbnQ2NFZhbHVlQgPgQQMSUQoEdHlwZRgEIAEoDjI+Lmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnY0LmVudW1zLkNyaXRlcmlvblR5cGVFbnVtLkNyaXRlcmlv",
            "blR5cGVCA+BBAxJDCgdrZXl3b3JkGAMgASgLMisuZ29vZ2xlLmFkcy5nb29n",
            "bGVhZHMudjQuY29tbW9uLktleXdvcmRJbmZvQgPgQQVIABJOCg15b3V0dWJl",
            "X3ZpZGVvGAUgASgLMjAuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuY29tbW9u",
            "LllvdVR1YmVWaWRlb0luZm9CA+BBBUgAElIKD3lvdXR1YmVfY2hhbm5lbBgG",
            "IAEoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmNvbW1vbi5Zb3VUdWJl",
            "Q2hhbm5lbEluZm9CA+BBBUgAEkcKCXBsYWNlbWVudBgHIAEoCzItLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnY0LmNvbW1vbi5QbGFjZW1lbnRJbmZvQgPgQQVI",
            "ABJZChNtb2JpbGVfYXBwX2NhdGVnb3J5GAggASgLMjUuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjQuY29tbW9uLk1vYmlsZUFwcENhdGVnb3J5SW5mb0ID4EEF",
            "SAASWAoSbW9iaWxlX2FwcGxpY2F0aW9uGAkgASgLMjUuZ29vZ2xlLmFkcy5n",
            "b29nbGVhZHMudjQuY29tbW9uLk1vYmlsZUFwcGxpY2F0aW9uSW5mb0ID4EEF",
            "SAA6ZepBYgooZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tL1NoYXJlZENyaXRl",
            "cmlvbhI2Y3VzdG9tZXJzL3tjdXN0b21lcn0vc2hhcmVkQ3JpdGVyaWEve3No",
            "YXJlZF9jcml0ZXJpb259QgsKCWNyaXRlcmlvbkKBAgolY29tLmdvb2dsZS5h",
            "ZHMuZ29vZ2xlYWRzLnY0LnJlc291cmNlc0IUU2hhcmVkQ3JpdGVyaW9uUHJv",
            "dG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9h",
            "ZHMvZ29vZ2xlYWRzL3Y0L3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WNC5SZXNvdXJjZXPKAiFHb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWNFxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xl",
            "QWRzOjpWNDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V4.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Resources.SharedCriterion), global::Google.Ads.GoogleAds.V4.Resources.SharedCriterion.Parser, new[]{ "ResourceName", "SharedSet", "CriterionId", "Type", "Keyword", "YoutubeVideo", "YoutubeChannel", "Placement", "MobileAppCategory", "MobileApplication" }, new[]{ "Criterion" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A criterion belonging to a shared set.
  /// </summary>
  public sealed partial class SharedCriterion : pb::IMessage<SharedCriterion> {
    private static readonly pb::MessageParser<SharedCriterion> _parser = new pb::MessageParser<SharedCriterion>(() => new SharedCriterion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SharedCriterion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Resources.SharedCriterionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterion(SharedCriterion other) : this() {
      resourceName_ = other.resourceName_;
      SharedSet = other.SharedSet;
      CriterionId = other.CriterionId;
      type_ = other.type_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          Keyword = other.Keyword.Clone();
          break;
        case CriterionOneofCase.YoutubeVideo:
          YoutubeVideo = other.YoutubeVideo.Clone();
          break;
        case CriterionOneofCase.YoutubeChannel:
          YoutubeChannel = other.YoutubeChannel.Clone();
          break;
        case CriterionOneofCase.Placement:
          Placement = other.Placement.Clone();
          break;
        case CriterionOneofCase.MobileAppCategory:
          MobileAppCategory = other.MobileAppCategory.Clone();
          break;
        case CriterionOneofCase.MobileApplication:
          MobileApplication = other.MobileApplication.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SharedCriterion Clone() {
      return new SharedCriterion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the shared criterion.
    /// Shared set resource names have the form:
    ///
    /// `customers/{customer_id}/sharedCriteria/{shared_set_id}~{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shared_set" field.</summary>
    public const int SharedSetFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_sharedSet_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string sharedSet_;
    /// <summary>
    /// Immutable. The shared set to which the shared criterion belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SharedSet {
      get { return sharedSet_; }
      set {
        sharedSet_ = value;
      }
    }


    /// <summary>Field number for the "criterion_id" field.</summary>
    public const int CriterionIdFieldNumber = 26;
    private static readonly pb::FieldCodec<long?> _single_criterionId_codec = pb::FieldCodec.ForStructWrapper<long>(210);
    private long? criterionId_;
    /// <summary>
    /// Output only. The ID of the criterion.
    ///
    /// This field is ignored for mutates.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? CriterionId {
      get { return criterionId_; }
      set {
        criterionId_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType type_ = global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified;
    /// <summary>
    /// Output only. The type of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "keyword" field.</summary>
    public const int KeywordFieldNumber = 3;
    /// <summary>
    /// Immutable. Keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.KeywordInfo Keyword {
      get { return criterionCase_ == CriterionOneofCase.Keyword ? (global::Google.Ads.GoogleAds.V4.Common.KeywordInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Keyword;
      }
    }

    /// <summary>Field number for the "youtube_video" field.</summary>
    public const int YoutubeVideoFieldNumber = 5;
    /// <summary>
    /// Immutable. YouTube Video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.YouTubeVideoInfo YoutubeVideo {
      get { return criterionCase_ == CriterionOneofCase.YoutubeVideo ? (global::Google.Ads.GoogleAds.V4.Common.YouTubeVideoInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeVideo;
      }
    }

    /// <summary>Field number for the "youtube_channel" field.</summary>
    public const int YoutubeChannelFieldNumber = 6;
    /// <summary>
    /// Immutable. YouTube Channel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.YouTubeChannelInfo YoutubeChannel {
      get { return criterionCase_ == CriterionOneofCase.YoutubeChannel ? (global::Google.Ads.GoogleAds.V4.Common.YouTubeChannelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeChannel;
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 7;
    /// <summary>
    /// Immutable. Placement.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.PlacementInfo Placement {
      get { return criterionCase_ == CriterionOneofCase.Placement ? (global::Google.Ads.GoogleAds.V4.Common.PlacementInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Placement;
      }
    }

    /// <summary>Field number for the "mobile_app_category" field.</summary>
    public const int MobileAppCategoryFieldNumber = 8;
    /// <summary>
    /// Immutable. Mobile App Category.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.MobileAppCategoryInfo MobileAppCategory {
      get { return criterionCase_ == CriterionOneofCase.MobileAppCategory ? (global::Google.Ads.GoogleAds.V4.Common.MobileAppCategoryInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileAppCategory;
      }
    }

    /// <summary>Field number for the "mobile_application" field.</summary>
    public const int MobileApplicationFieldNumber = 9;
    /// <summary>
    /// Immutable. Mobile application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V4.Common.MobileApplicationInfo MobileApplication {
      get { return criterionCase_ == CriterionOneofCase.MobileApplication ? (global::Google.Ads.GoogleAds.V4.Common.MobileApplicationInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileApplication;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      Keyword = 3,
      YoutubeVideo = 5,
      YoutubeChannel = 6,
      Placement = 7,
      MobileAppCategory = 8,
      MobileApplication = 9,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SharedCriterion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SharedCriterion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (SharedSet != other.SharedSet) return false;
      if (CriterionId != other.CriterionId) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(Keyword, other.Keyword)) return false;
      if (!object.Equals(YoutubeVideo, other.YoutubeVideo)) return false;
      if (!object.Equals(YoutubeChannel, other.YoutubeChannel)) return false;
      if (!object.Equals(Placement, other.Placement)) return false;
      if (!object.Equals(MobileAppCategory, other.MobileAppCategory)) return false;
      if (!object.Equals(MobileApplication, other.MobileApplication)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (sharedSet_ != null) hash ^= SharedSet.GetHashCode();
      if (criterionId_ != null) hash ^= CriterionId.GetHashCode();
      if (Type != global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) hash ^= Type.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Keyword) hash ^= Keyword.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) hash ^= YoutubeVideo.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) hash ^= YoutubeChannel.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Placement) hash ^= Placement.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) hash ^= MobileAppCategory.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileApplication) hash ^= MobileApplication.GetHashCode();
      hash ^= (int) criterionCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (sharedSet_ != null) {
        _single_sharedSet_codec.WriteTagAndValue(output, SharedSet);
      }
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        output.WriteRawTag(26);
        output.WriteMessage(Keyword);
      }
      if (Type != global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(42);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(50);
        output.WriteMessage(YoutubeChannel);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(66);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(74);
        output.WriteMessage(MobileApplication);
      }
      if (criterionId_ != null) {
        _single_criterionId_codec.WriteTagAndValue(output, CriterionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (sharedSet_ != null) {
        size += _single_sharedSet_codec.CalculateSizeWithTag(SharedSet);
      }
      if (criterionId_ != null) {
        size += _single_criterionId_codec.CalculateSizeWithTag(CriterionId);
      }
      if (Type != global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.Keyword) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Keyword);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeChannel);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileApplication);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SharedCriterion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.sharedSet_ != null) {
        if (sharedSet_ == null || other.SharedSet != "") {
          SharedSet = other.SharedSet;
        }
      }
      if (other.criterionId_ != null) {
        if (criterionId_ == null || other.CriterionId != 0L) {
          CriterionId = other.CriterionId;
        }
      }
      if (other.Type != global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType.Unspecified) {
        Type = other.Type;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.Keyword:
          if (Keyword == null) {
            Keyword = new global::Google.Ads.GoogleAds.V4.Common.KeywordInfo();
          }
          Keyword.MergeFrom(other.Keyword);
          break;
        case CriterionOneofCase.YoutubeVideo:
          if (YoutubeVideo == null) {
            YoutubeVideo = new global::Google.Ads.GoogleAds.V4.Common.YouTubeVideoInfo();
          }
          YoutubeVideo.MergeFrom(other.YoutubeVideo);
          break;
        case CriterionOneofCase.YoutubeChannel:
          if (YoutubeChannel == null) {
            YoutubeChannel = new global::Google.Ads.GoogleAds.V4.Common.YouTubeChannelInfo();
          }
          YoutubeChannel.MergeFrom(other.YoutubeChannel);
          break;
        case CriterionOneofCase.Placement:
          if (Placement == null) {
            Placement = new global::Google.Ads.GoogleAds.V4.Common.PlacementInfo();
          }
          Placement.MergeFrom(other.Placement);
          break;
        case CriterionOneofCase.MobileAppCategory:
          if (MobileAppCategory == null) {
            MobileAppCategory = new global::Google.Ads.GoogleAds.V4.Common.MobileAppCategoryInfo();
          }
          MobileAppCategory.MergeFrom(other.MobileAppCategory);
          break;
        case CriterionOneofCase.MobileApplication:
          if (MobileApplication == null) {
            MobileApplication = new global::Google.Ads.GoogleAds.V4.Common.MobileApplicationInfo();
          }
          MobileApplication.MergeFrom(other.MobileApplication);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
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
            string value = _single_sharedSet_codec.Read(input);
            if (sharedSet_ == null || value != "") {
              SharedSet = value;
            }
            break;
          }
          case 26: {
            global::Google.Ads.GoogleAds.V4.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.KeywordInfo();
            if (criterionCase_ == CriterionOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 32: {
            Type = (global::Google.Ads.GoogleAds.V4.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V4.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V4.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V4.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V4.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V4.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V4.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 210: {
            long? value = _single_criterionId_codec.Read(input);
            if (criterionId_ == null || value != 0L) {
              CriterionId = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
