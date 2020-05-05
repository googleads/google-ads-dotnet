// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/detail_placement_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/detail_placement_view.proto</summary>
  public static partial class DetailPlacementViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/detail_placement_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DetailPlacementViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvZGV0YWlsX3Bs",
            "YWNlbWVudF92aWV3LnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52My5y",
            "ZXNvdXJjZXMaMmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL2VudW1zL3BsYWNl",
            "bWVudF90eXBlLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnBy",
            "b3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGh5nb29nbGUvcHJvdG9i",
            "dWYvd3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8iogQKE0RldGFpbFBsYWNlbWVudFZpZXcSSwoNcmVzb3VyY2VfbmFtZRgB",
            "IAEoCUI04EED+kEuCixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vRGV0YWls",
            "UGxhY2VtZW50VmlldxI0CglwbGFjZW1lbnQYAiABKAsyHC5nb29nbGUucHJv",
            "dG9idWYuU3RyaW5nVmFsdWVCA+BBAxI3CgxkaXNwbGF5X25hbWUYAyABKAsy",
            "HC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxJFChpncm91cF9w",
            "bGFjZW1lbnRfdGFyZ2V0X3VybBgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5T",
            "dHJpbmdWYWx1ZUID4EEDEjUKCnRhcmdldF91cmwYBSABKAsyHC5nb29nbGUu",
            "cHJvdG9idWYuU3RyaW5nVmFsdWVCA+BBAxJbCg5wbGFjZW1lbnRfdHlwZRgG",
            "IAEoDjI+Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVudW1zLlBsYWNlbWVu",
            "dFR5cGVFbnVtLlBsYWNlbWVudFR5cGVCA+BBAzp06kFxCixnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vRGV0YWlsUGxhY2VtZW50VmlldxJBY3VzdG9tZXJz",
            "L3tjdXN0b21lcn0vZGV0YWlsUGxhY2VtZW50Vmlld3Mve2RldGFpbF9wbGFj",
            "ZW1lbnRfdmlld31ChQIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5y",
            "ZXNvdXJjZXNCGERldGFpbFBsYWNlbWVudFZpZXdQcm90b1ABWkpnb29nbGUu",
            "Z29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMv",
            "djMvcmVzb3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29v",
            "Z2xlQWRzLlYzLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYz",
            "XFJlc291cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpSZXNv",
            "dXJjZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.DetailPlacementView), global::Google.Ads.GoogleAds.V3.Resources.DetailPlacementView.Parser, new[]{ "ResourceName", "Placement", "DisplayName", "GroupPlacementTargetUrl", "TargetUrl", "PlacementType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A view with metrics aggregated by ad group and URL or YouTube video.
  /// </summary>
  public sealed partial class DetailPlacementView : pb::IMessage<DetailPlacementView> {
    private static readonly pb::MessageParser<DetailPlacementView> _parser = new pb::MessageParser<DetailPlacementView>(() => new DetailPlacementView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DetailPlacementView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.DetailPlacementViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetailPlacementView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetailPlacementView(DetailPlacementView other) : this() {
      resourceName_ = other.resourceName_;
      Placement = other.Placement;
      DisplayName = other.DisplayName;
      GroupPlacementTargetUrl = other.GroupPlacementTargetUrl;
      TargetUrl = other.TargetUrl;
      placementType_ = other.placementType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DetailPlacementView Clone() {
      return new DetailPlacementView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the detail placement view.
    /// Detail placement view resource names have the form:
    ///
    /// `customers/{customer_id}/detailPlacementViews/{ad_group_id}~{base64_placement}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_placement_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string placement_;
    /// <summary>
    /// Output only. The automatic placement string at detail level, e. g. website URL, mobile
    /// application ID, or a YouTube video ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Placement {
      get { return placement_; }
      set {
        placement_ = value;
      }
    }


    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_displayName_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string displayName_;
    /// <summary>
    /// Output only. The display name is URL name for websites, YouTube video name for YouTube
    /// videos, and translated mobile app name for mobile apps.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = value;
      }
    }


    /// <summary>Field number for the "group_placement_target_url" field.</summary>
    public const int GroupPlacementTargetUrlFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_groupPlacementTargetUrl_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string groupPlacementTargetUrl_;
    /// <summary>
    /// Output only. URL of the group placement, e.g. domain, link to the mobile application in
    /// app store, or a YouTube channel URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GroupPlacementTargetUrl {
      get { return groupPlacementTargetUrl_; }
      set {
        groupPlacementTargetUrl_ = value;
      }
    }


    /// <summary>Field number for the "target_url" field.</summary>
    public const int TargetUrlFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_targetUrl_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string targetUrl_;
    /// <summary>
    /// Output only. URL of the placement, e.g. website, link to the mobile application in app
    /// store, or a YouTube video URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TargetUrl {
      get { return targetUrl_; }
      set {
        targetUrl_ = value;
      }
    }


    /// <summary>Field number for the "placement_type" field.</summary>
    public const int PlacementTypeFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType placementType_ = global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified;
    /// <summary>
    /// Output only. Type of the placement, e.g. Website, YouTube Video, and Mobile Application.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType PlacementType {
      get { return placementType_; }
      set {
        placementType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DetailPlacementView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DetailPlacementView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Placement != other.Placement) return false;
      if (DisplayName != other.DisplayName) return false;
      if (GroupPlacementTargetUrl != other.GroupPlacementTargetUrl) return false;
      if (TargetUrl != other.TargetUrl) return false;
      if (PlacementType != other.PlacementType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (placement_ != null) hash ^= Placement.GetHashCode();
      if (displayName_ != null) hash ^= DisplayName.GetHashCode();
      if (groupPlacementTargetUrl_ != null) hash ^= GroupPlacementTargetUrl.GetHashCode();
      if (targetUrl_ != null) hash ^= TargetUrl.GetHashCode();
      if (PlacementType != global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) hash ^= PlacementType.GetHashCode();
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
      if (placement_ != null) {
        _single_placement_codec.WriteTagAndValue(output, Placement);
      }
      if (displayName_ != null) {
        _single_displayName_codec.WriteTagAndValue(output, DisplayName);
      }
      if (groupPlacementTargetUrl_ != null) {
        _single_groupPlacementTargetUrl_codec.WriteTagAndValue(output, GroupPlacementTargetUrl);
      }
      if (targetUrl_ != null) {
        _single_targetUrl_codec.WriteTagAndValue(output, TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) PlacementType);
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
      if (placement_ != null) {
        size += _single_placement_codec.CalculateSizeWithTag(Placement);
      }
      if (displayName_ != null) {
        size += _single_displayName_codec.CalculateSizeWithTag(DisplayName);
      }
      if (groupPlacementTargetUrl_ != null) {
        size += _single_groupPlacementTargetUrl_codec.CalculateSizeWithTag(GroupPlacementTargetUrl);
      }
      if (targetUrl_ != null) {
        size += _single_targetUrl_codec.CalculateSizeWithTag(TargetUrl);
      }
      if (PlacementType != global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PlacementType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DetailPlacementView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.placement_ != null) {
        if (placement_ == null || other.Placement != "") {
          Placement = other.Placement;
        }
      }
      if (other.displayName_ != null) {
        if (displayName_ == null || other.DisplayName != "") {
          DisplayName = other.DisplayName;
        }
      }
      if (other.groupPlacementTargetUrl_ != null) {
        if (groupPlacementTargetUrl_ == null || other.GroupPlacementTargetUrl != "") {
          GroupPlacementTargetUrl = other.GroupPlacementTargetUrl;
        }
      }
      if (other.targetUrl_ != null) {
        if (targetUrl_ == null || other.TargetUrl != "") {
          TargetUrl = other.TargetUrl;
        }
      }
      if (other.PlacementType != global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType.Unspecified) {
        PlacementType = other.PlacementType;
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
            string value = _single_placement_codec.Read(input);
            if (placement_ == null || value != "") {
              Placement = value;
            }
            break;
          }
          case 26: {
            string value = _single_displayName_codec.Read(input);
            if (displayName_ == null || value != "") {
              DisplayName = value;
            }
            break;
          }
          case 34: {
            string value = _single_groupPlacementTargetUrl_codec.Read(input);
            if (groupPlacementTargetUrl_ == null || value != "") {
              GroupPlacementTargetUrl = value;
            }
            break;
          }
          case 42: {
            string value = _single_targetUrl_codec.Read(input);
            if (targetUrl_ == null || value != "") {
              TargetUrl = value;
            }
            break;
          }
          case 48: {
            PlacementType = (global::Google.Ads.GoogleAds.V3.Enums.PlacementTypeEnum.Types.PlacementType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
