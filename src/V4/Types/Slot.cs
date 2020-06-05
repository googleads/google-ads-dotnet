// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/enums/slot.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/enums/slot.proto</summary>
  public static partial class SlotReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/enums/slot.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SlotReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lbnVtcy9zbG90LnByb3RvEh1n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52NC5lbnVtcxocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90byKuAQoIU2xvdEVudW0ioQEKBFNsb3QSDwoLVU5TUEVD",
            "SUZJRUQQABILCgdVTktOT1dOEAESDwoLU0VBUkNIX1NJREUQAhIOCgpTRUFS",
            "Q0hfVE9QEAMSEAoMU0VBUkNIX09USEVSEAQSCwoHQ09OVEVOVBAFEhYKElNF",
            "QVJDSF9QQVJUTkVSX1RPUBAGEhgKFFNFQVJDSF9QQVJUTkVSX09USEVSEAcS",
            "CQoFTUlYRUQQCELeAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY0LmVu",
            "dW1zQglTbG90UHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjQuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWNFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlY0OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Enums.SlotEnum), global::Google.Ads.GoogleAds.V4.Enums.SlotEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Enums.SlotEnum.Types.Slot) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of possible positions of the Ad.
  /// </summary>
  public sealed partial class SlotEnum : pb::IMessage<SlotEnum> {
    private static readonly pb::MessageParser<SlotEnum> _parser = new pb::MessageParser<SlotEnum>(() => new SlotEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SlotEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Enums.SlotReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum(SlotEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SlotEnum Clone() {
      return new SlotEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SlotEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SlotEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SlotEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SlotEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates possible positions of the Ad.
      /// </summary>
      public enum Slot {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google search: Side.
        /// </summary>
        [pbr::OriginalName("SEARCH_SIDE")] SearchSide = 2,
        /// <summary>
        /// Google search: Top.
        /// </summary>
        [pbr::OriginalName("SEARCH_TOP")] SearchTop = 3,
        /// <summary>
        /// Google search: Other.
        /// </summary>
        [pbr::OriginalName("SEARCH_OTHER")] SearchOther = 4,
        /// <summary>
        /// Google Display Network.
        /// </summary>
        [pbr::OriginalName("CONTENT")] Content = 5,
        /// <summary>
        /// Search partners: Top.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNER_TOP")] SearchPartnerTop = 6,
        /// <summary>
        /// Search partners: Other.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNER_OTHER")] SearchPartnerOther = 7,
        /// <summary>
        /// Cross-network.
        /// </summary>
        [pbr::OriginalName("MIXED")] Mixed = 8,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
