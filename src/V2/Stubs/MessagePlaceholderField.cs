// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/message_placeholder_field.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/message_placeholder_field.proto</summary>
  public static partial class MessagePlaceholderFieldReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/message_placeholder_field.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MessagePlaceholderFieldReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj1nb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9tZXNzYWdlX3BsYWNl",
            "aG9sZGVyX2ZpZWxkLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5l",
            "bnVtcxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byK8AQobTWVzc2Fn",
            "ZVBsYWNlaG9sZGVyRmllbGRFbnVtIpwBChdNZXNzYWdlUGxhY2Vob2xkZXJG",
            "aWVsZBIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIRCg1CVVNJTkVT",
            "U19OQU1FEAISEAoMQ09VTlRSWV9DT0RFEAMSEAoMUEhPTkVfTlVNQkVSEAQS",
            "GgoWTUVTU0FHRV9FWFRFTlNJT05fVEVYVBAFEhAKDE1FU1NBR0VfVEVYVBAG",
            "QvEBCiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCHE1lc3Nh",
            "Z2VQbGFjZWhvbGRlckZpZWxkUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2Vu",
            "dW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.MessagePlaceholderFieldEnum), global::Google.Ads.GoogleAds.V2.Enums.MessagePlaceholderFieldEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.MessagePlaceholderFieldEnum.Types.MessagePlaceholderField) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Values for Message placeholder fields.
  /// </summary>
  public sealed partial class MessagePlaceholderFieldEnum : pb::IMessage<MessagePlaceholderFieldEnum> {
    private static readonly pb::MessageParser<MessagePlaceholderFieldEnum> _parser = new pb::MessageParser<MessagePlaceholderFieldEnum>(() => new MessagePlaceholderFieldEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MessagePlaceholderFieldEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.MessagePlaceholderFieldReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePlaceholderFieldEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePlaceholderFieldEnum(MessagePlaceholderFieldEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MessagePlaceholderFieldEnum Clone() {
      return new MessagePlaceholderFieldEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MessagePlaceholderFieldEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MessagePlaceholderFieldEnum other) {
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
    public void MergeFrom(MessagePlaceholderFieldEnum other) {
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
    /// <summary>Container for nested types declared in the MessagePlaceholderFieldEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible values for Message placeholder fields.
      /// </summary>
      public enum MessagePlaceholderField {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Data Type: STRING. The name of your business.
        /// </summary>
        [pbr::OriginalName("BUSINESS_NAME")] BusinessName = 2,
        /// <summary>
        /// Data Type: STRING. Country code of phone number.
        /// </summary>
        [pbr::OriginalName("COUNTRY_CODE")] CountryCode = 3,
        /// <summary>
        /// Data Type: STRING. A phone number that's capable of sending and receiving
        /// text messages.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER")] PhoneNumber = 4,
        /// <summary>
        /// Data Type: STRING. The text that will go in your click-to-message ad.
        /// </summary>
        [pbr::OriginalName("MESSAGE_EXTENSION_TEXT")] MessageExtensionText = 5,
        /// <summary>
        /// Data Type: STRING. The message text automatically shows in people's
        /// messaging apps when they tap to send you a message.
        /// </summary>
        [pbr::OriginalName("MESSAGE_TEXT")] MessageText = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
