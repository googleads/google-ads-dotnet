// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/budget_delivery_method.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/budget_delivery_method.proto</summary>
  public static partial class BudgetDeliveryMethodReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/budget_delivery_method.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BudgetDeliveryMethodReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9idWRnZXRfZGVsaXZl",
            "cnlfbWV0aG9kLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVt",
            "cxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJvChhCdWRnZXREZWxp",
            "dmVyeU1ldGhvZEVudW0iUwoUQnVkZ2V0RGVsaXZlcnlNZXRob2QSDwoLVU5T",
            "UEVDSUZJRUQQABILCgdVTktOT1dOEAESDAoIU1RBTkRBUkQQAhIPCgtBQ0NF",
            "TEVSQVRFRBADQu4BCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51",
            "bXNCGUJ1ZGdldERlbGl2ZXJ5TWV0aG9kUHJvdG9QAVpCZ29vZ2xlLmdvbGFu",
            "Zy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2Vu",
            "dW1zO2VudW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51",
            "bXPKAh1Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6",
            "QWRzOjpHb29nbGVBZHM6OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.BudgetDeliveryMethodEnum), global::Google.Ads.GoogleAds.V2.Enums.BudgetDeliveryMethodEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.BudgetDeliveryMethodEnum.Types.BudgetDeliveryMethod) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Message describing Budget delivery methods. A delivery method determines the
  /// rate at which the Budget is spent.
  /// </summary>
  public sealed partial class BudgetDeliveryMethodEnum : pb::IMessage<BudgetDeliveryMethodEnum> {
    private static readonly pb::MessageParser<BudgetDeliveryMethodEnum> _parser = new pb::MessageParser<BudgetDeliveryMethodEnum>(() => new BudgetDeliveryMethodEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BudgetDeliveryMethodEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.BudgetDeliveryMethodReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetDeliveryMethodEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetDeliveryMethodEnum(BudgetDeliveryMethodEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BudgetDeliveryMethodEnum Clone() {
      return new BudgetDeliveryMethodEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BudgetDeliveryMethodEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BudgetDeliveryMethodEnum other) {
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
    public void MergeFrom(BudgetDeliveryMethodEnum other) {
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
    /// <summary>Container for nested types declared in the BudgetDeliveryMethodEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible delivery methods of a Budget.
      /// </summary>
      public enum BudgetDeliveryMethod {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The budget server will throttle serving evenly across
        /// the entire time period.
        /// </summary>
        [pbr::OriginalName("STANDARD")] Standard = 2,
        /// <summary>
        /// The budget server will not throttle serving,
        /// and ads will serve as fast as possible.
        /// </summary>
        [pbr::OriginalName("ACCELERATED")] Accelerated = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
