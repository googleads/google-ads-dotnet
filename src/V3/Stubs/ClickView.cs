// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/click_view.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/click_view.proto</summary>
  public static partial class ClickViewReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/click_view.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClickViewReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY2xpY2tfdmll",
            "dy5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMucmVzb3VyY2VzGjNn",
            "b29nbGUvYWRzL2dvb2dsZWFkcy92My9jb21tb24vY2xpY2tfbG9jYXRpb24u",
            "cHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2ds",
            "ZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVy",
            "cy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byKNBAoJQ2xp",
            "Y2tWaWV3EkEKDXJlc291cmNlX25hbWUYASABKAlCKuBBA/pBJAoiZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0NsaWNrVmlldxIwCgVnY2xpZBgCIAEoCzIc",
            "Lmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZUID4EEDEkwKEGFyZWFfb2Zf",
            "aW50ZXJlc3QYAyABKAsyLS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5jb21t",
            "b24uQ2xpY2tMb2NhdGlvbkID4EEDElAKFGxvY2F0aW9uX29mX3ByZXNlbmNl",
            "GAQgASgLMi0uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuY29tbW9uLkNsaWNr",
            "TG9jYXRpb25CA+BBAxI1CgtwYWdlX251bWJlchgFIAEoCzIbLmdvb2dsZS5w",
            "cm90b2J1Zi5JbnQ2NFZhbHVlQgPgQQMSXQoLYWRfZ3JvdXBfYWQYByABKAsy",
            "HC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWVCKuBBA/pBJAoiZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0FkR3JvdXBBZDpV6kFSCiJnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vQ2xpY2tWaWV3EixjdXN0b21lcnMve2N1c3RvbWVy",
            "fS9jbGlja1ZpZXdzL3tjbGlja192aWV3fUL7AQolY29tLmdvb2dsZS5hZHMu",
            "Z29vZ2xlYWRzLnYzLnJlc291cmNlc0IOQ2xpY2tWaWV3UHJvdG9QAVpKZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YzL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRz",
            "Lkdvb2dsZUFkcy5WMy5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFk",
            "c1xWM1xSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6",
            "UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Common.ClickLocationReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.ClickView), global::Google.Ads.GoogleAds.V3.Resources.ClickView.Parser, new[]{ "ResourceName", "Gclid", "AreaOfInterest", "LocationOfPresence", "PageNumber", "AdGroupAd" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A click view with metrics aggregated at each click level, including both
  /// valid and invalid clicks. For non-Search campaigns, metrics.clicks
  /// represents the number of valid and invalid interactions.
  /// Queries including ClickView must have a filter limiting the results to one
  /// day and can be requested for dates back to 90 days before the time of the
  /// request.
  /// </summary>
  public sealed partial class ClickView : pb::IMessage<ClickView> {
    private static readonly pb::MessageParser<ClickView> _parser = new pb::MessageParser<ClickView>(() => new ClickView());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClickView> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.ClickViewReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickView() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickView(ClickView other) : this() {
      resourceName_ = other.resourceName_;
      Gclid = other.Gclid;
      areaOfInterest_ = other.areaOfInterest_ != null ? other.areaOfInterest_.Clone() : null;
      locationOfPresence_ = other.locationOfPresence_ != null ? other.locationOfPresence_.Clone() : null;
      PageNumber = other.PageNumber;
      AdGroupAd = other.AdGroupAd;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClickView Clone() {
      return new ClickView(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the click view.
    /// Click view resource names have the form:
    ///
    /// `customers/{customer_id}/clickViews/{date (yyyy-MM-dd)}~{gclid}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "gclid" field.</summary>
    public const int GclidFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_gclid_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string gclid_;
    /// <summary>
    /// Output only. The Google Click ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Gclid {
      get { return gclid_; }
      set {
        gclid_ = value;
      }
    }


    /// <summary>Field number for the "area_of_interest" field.</summary>
    public const int AreaOfInterestFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V3.Common.ClickLocation areaOfInterest_;
    /// <summary>
    /// Output only. The location criteria matching the area of interest associated with the
    /// impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.ClickLocation AreaOfInterest {
      get { return areaOfInterest_; }
      set {
        areaOfInterest_ = value;
      }
    }

    /// <summary>Field number for the "location_of_presence" field.</summary>
    public const int LocationOfPresenceFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V3.Common.ClickLocation locationOfPresence_;
    /// <summary>
    /// Output only. The location criteria matching the location of presence associated with the
    /// impression.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.ClickLocation LocationOfPresence {
      get { return locationOfPresence_; }
      set {
        locationOfPresence_ = value;
      }
    }

    /// <summary>Field number for the "page_number" field.</summary>
    public const int PageNumberFieldNumber = 5;
    private static readonly pb::FieldCodec<long?> _single_pageNumber_codec = pb::FieldCodec.ForStructWrapper<long>(42);
    private long? pageNumber_;
    /// <summary>
    /// Output only. Page number in search results where the ad was shown.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? PageNumber {
      get { return pageNumber_; }
      set {
        pageNumber_ = value;
      }
    }


    /// <summary>Field number for the "ad_group_ad" field.</summary>
    public const int AdGroupAdFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _single_adGroupAd_codec = pb::FieldCodec.ForClassWrapper<string>(58);
    private string adGroupAd_;
    /// <summary>
    /// Output only. The associated ad.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroupAd {
      get { return adGroupAd_; }
      set {
        adGroupAd_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClickView);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClickView other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Gclid != other.Gclid) return false;
      if (!object.Equals(AreaOfInterest, other.AreaOfInterest)) return false;
      if (!object.Equals(LocationOfPresence, other.LocationOfPresence)) return false;
      if (PageNumber != other.PageNumber) return false;
      if (AdGroupAd != other.AdGroupAd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (gclid_ != null) hash ^= Gclid.GetHashCode();
      if (areaOfInterest_ != null) hash ^= AreaOfInterest.GetHashCode();
      if (locationOfPresence_ != null) hash ^= LocationOfPresence.GetHashCode();
      if (pageNumber_ != null) hash ^= PageNumber.GetHashCode();
      if (adGroupAd_ != null) hash ^= AdGroupAd.GetHashCode();
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
      if (gclid_ != null) {
        _single_gclid_codec.WriteTagAndValue(output, Gclid);
      }
      if (areaOfInterest_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(AreaOfInterest);
      }
      if (locationOfPresence_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(LocationOfPresence);
      }
      if (pageNumber_ != null) {
        _single_pageNumber_codec.WriteTagAndValue(output, PageNumber);
      }
      if (adGroupAd_ != null) {
        _single_adGroupAd_codec.WriteTagAndValue(output, AdGroupAd);
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
      if (gclid_ != null) {
        size += _single_gclid_codec.CalculateSizeWithTag(Gclid);
      }
      if (areaOfInterest_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AreaOfInterest);
      }
      if (locationOfPresence_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LocationOfPresence);
      }
      if (pageNumber_ != null) {
        size += _single_pageNumber_codec.CalculateSizeWithTag(PageNumber);
      }
      if (adGroupAd_ != null) {
        size += _single_adGroupAd_codec.CalculateSizeWithTag(AdGroupAd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClickView other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.gclid_ != null) {
        if (gclid_ == null || other.Gclid != "") {
          Gclid = other.Gclid;
        }
      }
      if (other.areaOfInterest_ != null) {
        if (areaOfInterest_ == null) {
          AreaOfInterest = new global::Google.Ads.GoogleAds.V3.Common.ClickLocation();
        }
        AreaOfInterest.MergeFrom(other.AreaOfInterest);
      }
      if (other.locationOfPresence_ != null) {
        if (locationOfPresence_ == null) {
          LocationOfPresence = new global::Google.Ads.GoogleAds.V3.Common.ClickLocation();
        }
        LocationOfPresence.MergeFrom(other.LocationOfPresence);
      }
      if (other.pageNumber_ != null) {
        if (pageNumber_ == null || other.PageNumber != 0L) {
          PageNumber = other.PageNumber;
        }
      }
      if (other.adGroupAd_ != null) {
        if (adGroupAd_ == null || other.AdGroupAd != "") {
          AdGroupAd = other.AdGroupAd;
        }
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
            string value = _single_gclid_codec.Read(input);
            if (gclid_ == null || value != "") {
              Gclid = value;
            }
            break;
          }
          case 26: {
            if (areaOfInterest_ == null) {
              AreaOfInterest = new global::Google.Ads.GoogleAds.V3.Common.ClickLocation();
            }
            input.ReadMessage(AreaOfInterest);
            break;
          }
          case 34: {
            if (locationOfPresence_ == null) {
              LocationOfPresence = new global::Google.Ads.GoogleAds.V3.Common.ClickLocation();
            }
            input.ReadMessage(LocationOfPresence);
            break;
          }
          case 42: {
            long? value = _single_pageNumber_codec.Read(input);
            if (pageNumber_ == null || value != 0L) {
              PageNumber = value;
            }
            break;
          }
          case 58: {
            string value = _single_adGroupAd_codec.Read(input);
            if (adGroupAd_ == null || value != "") {
              AdGroupAd = value;
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
