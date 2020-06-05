// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/errors/media_file_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V4.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v4/errors/media_file_error.proto</summary>
  public static partial class MediaFileErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v4/errors/media_file_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MediaFileErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92NC9lcnJvcnMvbWVkaWFfZmlsZV9l",
            "cnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjQuZXJyb3JzGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIpcGChJNZWRpYUZpbGVFcnJv",
            "ckVudW0igAYKDk1lZGlhRmlsZUVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEh8KG0NBTk5PVF9DUkVBVEVfU1RBTkRBUkRfSUNPThACEjAK",
            "LENBTk5PVF9TRUxFQ1RfU1RBTkRBUkRfSUNPTl9XSVRIX09USEVSX1RZUEVT",
            "EAMSKQolQ0FOTk9UX1NQRUNJRllfTUVESUFfRklMRV9JRF9BTkRfREFUQRAE",
            "EhMKD0RVUExJQ0FURV9NRURJQRAFEg8KC0VNUFRZX0ZJRUxEEAYSJwojUkVT",
            "T1VSQ0VfUkVGRVJFTkNFRF9JTl9NVUxUSVBMRV9PUFMQBxIqCiZGSUVMRF9O",
            "T1RfU1VQUE9SVEVEX0ZPUl9NRURJQV9TVUJfVFlQRRAIEhkKFUlOVkFMSURf",
            "TUVESUFfRklMRV9JRBAJEhoKFklOVkFMSURfTUVESUFfU1VCX1RZUEUQChIb",
            "ChdJTlZBTElEX01FRElBX0ZJTEVfVFlQRRALEhUKEUlOVkFMSURfTUlNRV9U",
            "WVBFEAwSGAoUSU5WQUxJRF9SRUZFUkVOQ0VfSUQQDRIXChNJTlZBTElEX1lP",
            "VV9UVUJFX0lEEA4SIQodTUVESUFfRklMRV9GQUlMRURfVFJBTlNDT0RJTkcQ",
            "DxIYChRNRURJQV9OT1RfVFJBTlNDT0RFRBAQEi0KKU1FRElBX1RZUEVfRE9F",
            "U19OT1RfTUFUQ0hfTUVESUFfRklMRV9UWVBFEBESFwoTTk9fRklFTERTX1NQ",
            "RUNJRklFRBASEiIKHk5VTExfUkVGRVJFTkNFX0lEX0FORF9NRURJQV9JRBAT",
            "EgwKCFRPT19MT05HEBQSFAoQVU5TVVBQT1JURURfVFlQRRAVEiAKHFlPVV9U",
            "VUJFX1NFUlZJQ0VfVU5BVkFJTEFCTEUQFhIsCihZT1VfVFVCRV9WSURFT19I",
            "QVNfTk9OX1BPU0lUSVZFX0RVUkFUSU9OEBcSHAoYWU9VX1RVQkVfVklERU9f",
            "Tk9UX0ZPVU5EEBhC7gEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52NC5l",
            "cnJvcnNCE01lZGlhRmlsZUVycm9yUHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y0L2Vycm9y",
            "cztlcnJvcnOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2dsZUFkcy5WNC5FcnJv",
            "cnPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWNFxFcnJvcnPqAiJHb29nbGU6",
            "OkFkczo6R29vZ2xlQWRzOjpWNDo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V4.Errors.MediaFileErrorEnum), global::Google.Ads.GoogleAds.V4.Errors.MediaFileErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V4.Errors.MediaFileErrorEnum.Types.MediaFileError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible media file errors.
  /// </summary>
  public sealed partial class MediaFileErrorEnum : pb::IMessage<MediaFileErrorEnum> {
    private static readonly pb::MessageParser<MediaFileErrorEnum> _parser = new pb::MessageParser<MediaFileErrorEnum>(() => new MediaFileErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MediaFileErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V4.Errors.MediaFileErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileErrorEnum(MediaFileErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MediaFileErrorEnum Clone() {
      return new MediaFileErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MediaFileErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MediaFileErrorEnum other) {
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
    public void MergeFrom(MediaFileErrorEnum other) {
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
    /// <summary>Container for nested types declared in the MediaFileErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible media file errors.
      /// </summary>
      public enum MediaFileError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Cannot create a standard icon type.
        /// </summary>
        [pbr::OriginalName("CANNOT_CREATE_STANDARD_ICON")] CannotCreateStandardIcon = 2,
        /// <summary>
        /// May only select Standard Icons alone.
        /// </summary>
        [pbr::OriginalName("CANNOT_SELECT_STANDARD_ICON_WITH_OTHER_TYPES")] CannotSelectStandardIconWithOtherTypes = 3,
        /// <summary>
        /// Image contains both a media file ID and data.
        /// </summary>
        [pbr::OriginalName("CANNOT_SPECIFY_MEDIA_FILE_ID_AND_DATA")] CannotSpecifyMediaFileIdAndData = 4,
        /// <summary>
        /// A media file with given type and reference ID already exists.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_MEDIA")] DuplicateMedia = 5,
        /// <summary>
        /// A required field was not specified or is an empty string.
        /// </summary>
        [pbr::OriginalName("EMPTY_FIELD")] EmptyField = 6,
        /// <summary>
        /// A media file may only be modified once per call.
        /// </summary>
        [pbr::OriginalName("RESOURCE_REFERENCED_IN_MULTIPLE_OPS")] ResourceReferencedInMultipleOps = 7,
        /// <summary>
        /// Field is not supported for the media sub type.
        /// </summary>
        [pbr::OriginalName("FIELD_NOT_SUPPORTED_FOR_MEDIA_SUB_TYPE")] FieldNotSupportedForMediaSubType = 8,
        /// <summary>
        /// The media file ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_FILE_ID")] InvalidMediaFileId = 9,
        /// <summary>
        /// The media subtype is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_SUB_TYPE")] InvalidMediaSubType = 10,
        /// <summary>
        /// The media file type is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MEDIA_FILE_TYPE")] InvalidMediaFileType = 11,
        /// <summary>
        /// The mimetype is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_MIME_TYPE")] InvalidMimeType = 12,
        /// <summary>
        /// The media reference ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_REFERENCE_ID")] InvalidReferenceId = 13,
        /// <summary>
        /// The YouTube video ID is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_YOU_TUBE_ID")] InvalidYouTubeId = 14,
        /// <summary>
        /// Media file has failed transcoding
        /// </summary>
        [pbr::OriginalName("MEDIA_FILE_FAILED_TRANSCODING")] MediaFileFailedTranscoding = 15,
        /// <summary>
        /// Media file has not been transcoded.
        /// </summary>
        [pbr::OriginalName("MEDIA_NOT_TRANSCODED")] MediaNotTranscoded = 16,
        /// <summary>
        /// The media type does not match the actual media file's type.
        /// </summary>
        [pbr::OriginalName("MEDIA_TYPE_DOES_NOT_MATCH_MEDIA_FILE_TYPE")] MediaTypeDoesNotMatchMediaFileType = 17,
        /// <summary>
        /// None of the fields have been specified.
        /// </summary>
        [pbr::OriginalName("NO_FIELDS_SPECIFIED")] NoFieldsSpecified = 18,
        /// <summary>
        /// One of reference ID or media file ID must be specified.
        /// </summary>
        [pbr::OriginalName("NULL_REFERENCE_ID_AND_MEDIA_ID")] NullReferenceIdAndMediaId = 19,
        /// <summary>
        /// The string has too many characters.
        /// </summary>
        [pbr::OriginalName("TOO_LONG")] TooLong = 20,
        /// <summary>
        /// The specified type is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_TYPE")] UnsupportedType = 21,
        /// <summary>
        /// YouTube is unavailable for requesting video data.
        /// </summary>
        [pbr::OriginalName("YOU_TUBE_SERVICE_UNAVAILABLE")] YouTubeServiceUnavailable = 22,
        /// <summary>
        /// The YouTube video has a non positive duration.
        /// </summary>
        [pbr::OriginalName("YOU_TUBE_VIDEO_HAS_NON_POSITIVE_DURATION")] YouTubeVideoHasNonPositiveDuration = 23,
        /// <summary>
        /// The YouTube video ID is syntactically valid but the video was not found.
        /// </summary>
        [pbr::OriginalName("YOU_TUBE_VIDEO_NOT_FOUND")] YouTubeVideoNotFound = 24,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
