// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/errors/image_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/errors/image_error.proto</summary>
  public static partial class ImageErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/errors/image_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZXJyb3JzL2ltYWdlX2Vycm9y",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZXJyb3JzIsIICg5J",
            "bWFnZUVycm9yRW51bSKvCAoKSW1hZ2VFcnJvchIPCgtVTlNQRUNJRklFRBAA",
            "EgsKB1VOS05PV04QARIRCg1JTlZBTElEX0lNQUdFEAISEQoNU1RPUkFHRV9F",
            "UlJPUhADEg8KC0JBRF9SRVFVRVNUEAQSEwoPVU5FWFBFQ1RFRF9TSVpFEAUS",
            "GAoUQU5JTUFURURfTk9UX0FMTE9XRUQQBhIWChJBTklNQVRJT05fVE9PX0xP",
            "TkcQBxIQCgxTRVJWRVJfRVJST1IQCBIZChVDTVlLX0pQRUdfTk9UX0FMTE9X",
            "RUQQCRIVChFGTEFTSF9OT1RfQUxMT1dFRBAKEhoKFkZMQVNIX1dJVEhPVVRf",
            "Q0xJQ0tUQUcQCxImCiJGTEFTSF9FUlJPUl9BRlRFUl9GSVhJTkdfQ0xJQ0tf",
            "VEFHEAwSGgoWQU5JTUFURURfVklTVUFMX0VGRkVDVBANEg8KC0ZMQVNIX0VS",
            "Uk9SEA4SEgoOTEFZT1VUX1BST0JMRU0QDxIeChpQUk9CTEVNX1JFQURJTkdf",
            "SU1BR0VfRklMRRAQEhcKE0VSUk9SX1NUT1JJTkdfSU1BR0UQERIcChhBU1BF",
            "Q1RfUkFUSU9fTk9UX0FMTE9XRUQQEhIdChlGTEFTSF9IQVNfTkVUV09SS19P",
            "QkpFQ1RTEBMSHQoZRkxBU0hfSEFTX05FVFdPUktfTUVUSE9EUxAUEhEKDUZM",
            "QVNIX0hBU19VUkwQFRIcChhGTEFTSF9IQVNfTU9VU0VfVFJBQ0tJTkcQFhIY",
            "ChRGTEFTSF9IQVNfUkFORE9NX05VTRAXEhYKEkZMQVNIX1NFTEZfVEFSR0VU",
            "UxAYEhsKF0ZMQVNIX0JBRF9HRVRVUkxfVEFSR0VUEBkSHwobRkxBU0hfVkVS",
            "U0lPTl9OT1RfU1VQUE9SVEVEEBoSJgoiRkxBU0hfV0lUSE9VVF9IQVJEX0NP",
            "REVEX0NMSUNLX1VSTBAbEhYKEklOVkFMSURfRkxBU0hfRklMRRAcEiQKIEZB",
            "SUxFRF9UT19GSVhfQ0xJQ0tfVEFHX0lOX0ZMQVNIEB0SJAogRkxBU0hfQUND",
            "RVNTRVNfTkVUV09SS19SRVNPVVJDRVMQHhIaChZGTEFTSF9FWFRFUk5BTF9K",
            "U19DQUxMEB8SGgoWRkxBU0hfRVhURVJOQUxfRlNfQ0FMTBAgEhIKDkZJTEVf",
            "VE9PX0xBUkdFECESGAoUSU1BR0VfREFUQV9UT09fTEFSR0UQIhIaChZJTUFH",
            "RV9QUk9DRVNTSU5HX0VSUk9SECMSEwoPSU1BR0VfVE9PX1NNQUxMECQSEQoN",
            "SU5WQUxJRF9JTlBVVBAlEhgKFFBST0JMRU1fUkVBRElOR19GSUxFECYSHgoa",
            "SU1BR0VfQ09OU1RSQUlOVFNfVklPTEFURUQQJxIWChJGT1JNQVRfTk9UX0FM",
            "TE9XRUQQKELvAQojY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMS5lcnJv",
            "cnNCD0ltYWdlRXJyb3JQcm90b1ABWkVnb29nbGUuZ29sYW5nLm9yZy9nZW5w",
            "cm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjExL2Vycm9ycztlcnJv",
            "cnOiAgNHQUGqAh9Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMTEuRXJyb3JzygIf",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjExXEVycm9yc+oCI0dvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYxMTo6RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Errors.ImageErrorEnum), global::Google.Ads.GoogleAds.V11.Errors.ImageErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Errors.ImageErrorEnum.Types.ImageError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible image errors.
  /// </summary>
  public sealed partial class ImageErrorEnum : pb::IMessage<ImageErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ImageErrorEnum> _parser = new pb::MessageParser<ImageErrorEnum>(() => new ImageErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ImageErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Errors.ImageErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageErrorEnum(ImageErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ImageErrorEnum Clone() {
      return new ImageErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ImageErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ImageErrorEnum other) {
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
    public void MergeFrom(ImageErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ImageErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible image errors.
      /// </summary>
      public enum ImageError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The image is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_IMAGE")] InvalidImage = 2,
        /// <summary>
        /// The image could not be stored.
        /// </summary>
        [pbr::OriginalName("STORAGE_ERROR")] StorageError = 3,
        /// <summary>
        /// There was a problem with the request.
        /// </summary>
        [pbr::OriginalName("BAD_REQUEST")] BadRequest = 4,
        /// <summary>
        /// The image is not of legal dimensions.
        /// </summary>
        [pbr::OriginalName("UNEXPECTED_SIZE")] UnexpectedSize = 5,
        /// <summary>
        /// Animated image are not permitted.
        /// </summary>
        [pbr::OriginalName("ANIMATED_NOT_ALLOWED")] AnimatedNotAllowed = 6,
        /// <summary>
        /// Animation is too long.
        /// </summary>
        [pbr::OriginalName("ANIMATION_TOO_LONG")] AnimationTooLong = 7,
        /// <summary>
        /// There was an error on the server.
        /// </summary>
        [pbr::OriginalName("SERVER_ERROR")] ServerError = 8,
        /// <summary>
        /// Image cannot be in CMYK color format.
        /// </summary>
        [pbr::OriginalName("CMYK_JPEG_NOT_ALLOWED")] CmykJpegNotAllowed = 9,
        /// <summary>
        /// Flash images are not permitted.
        /// </summary>
        [pbr::OriginalName("FLASH_NOT_ALLOWED")] FlashNotAllowed = 10,
        /// <summary>
        /// Flash images must support clickTag.
        /// </summary>
        [pbr::OriginalName("FLASH_WITHOUT_CLICKTAG")] FlashWithoutClicktag = 11,
        /// <summary>
        /// A flash error has occurred after fixing the click tag.
        /// </summary>
        [pbr::OriginalName("FLASH_ERROR_AFTER_FIXING_CLICK_TAG")] FlashErrorAfterFixingClickTag = 12,
        /// <summary>
        /// Unacceptable visual effects.
        /// </summary>
        [pbr::OriginalName("ANIMATED_VISUAL_EFFECT")] AnimatedVisualEffect = 13,
        /// <summary>
        /// There was a problem with the flash image.
        /// </summary>
        [pbr::OriginalName("FLASH_ERROR")] FlashError = 14,
        /// <summary>
        /// Incorrect image layout.
        /// </summary>
        [pbr::OriginalName("LAYOUT_PROBLEM")] LayoutProblem = 15,
        /// <summary>
        /// There was a problem reading the image file.
        /// </summary>
        [pbr::OriginalName("PROBLEM_READING_IMAGE_FILE")] ProblemReadingImageFile = 16,
        /// <summary>
        /// There was an error storing the image.
        /// </summary>
        [pbr::OriginalName("ERROR_STORING_IMAGE")] ErrorStoringImage = 17,
        /// <summary>
        /// The aspect ratio of the image is not allowed.
        /// </summary>
        [pbr::OriginalName("ASPECT_RATIO_NOT_ALLOWED")] AspectRatioNotAllowed = 18,
        /// <summary>
        /// Flash cannot have network objects.
        /// </summary>
        [pbr::OriginalName("FLASH_HAS_NETWORK_OBJECTS")] FlashHasNetworkObjects = 19,
        /// <summary>
        /// Flash cannot have network methods.
        /// </summary>
        [pbr::OriginalName("FLASH_HAS_NETWORK_METHODS")] FlashHasNetworkMethods = 20,
        /// <summary>
        /// Flash cannot have a Url.
        /// </summary>
        [pbr::OriginalName("FLASH_HAS_URL")] FlashHasUrl = 21,
        /// <summary>
        /// Flash cannot use mouse tracking.
        /// </summary>
        [pbr::OriginalName("FLASH_HAS_MOUSE_TRACKING")] FlashHasMouseTracking = 22,
        /// <summary>
        /// Flash cannot have a random number.
        /// </summary>
        [pbr::OriginalName("FLASH_HAS_RANDOM_NUM")] FlashHasRandomNum = 23,
        /// <summary>
        /// Ad click target cannot be '_self'.
        /// </summary>
        [pbr::OriginalName("FLASH_SELF_TARGETS")] FlashSelfTargets = 24,
        /// <summary>
        /// GetUrl method should only use '_blank'.
        /// </summary>
        [pbr::OriginalName("FLASH_BAD_GETURL_TARGET")] FlashBadGeturlTarget = 25,
        /// <summary>
        /// Flash version is not supported.
        /// </summary>
        [pbr::OriginalName("FLASH_VERSION_NOT_SUPPORTED")] FlashVersionNotSupported = 26,
        /// <summary>
        /// Flash movies need to have hard coded click URL or clickTAG
        /// </summary>
        [pbr::OriginalName("FLASH_WITHOUT_HARD_CODED_CLICK_URL")] FlashWithoutHardCodedClickUrl = 27,
        /// <summary>
        /// Uploaded flash file is corrupted.
        /// </summary>
        [pbr::OriginalName("INVALID_FLASH_FILE")] InvalidFlashFile = 28,
        /// <summary>
        /// Uploaded flash file can be parsed, but the click tag can not be fixed
        /// properly.
        /// </summary>
        [pbr::OriginalName("FAILED_TO_FIX_CLICK_TAG_IN_FLASH")] FailedToFixClickTagInFlash = 29,
        /// <summary>
        /// Flash movie accesses network resources
        /// </summary>
        [pbr::OriginalName("FLASH_ACCESSES_NETWORK_RESOURCES")] FlashAccessesNetworkResources = 30,
        /// <summary>
        /// Flash movie attempts to call external javascript code
        /// </summary>
        [pbr::OriginalName("FLASH_EXTERNAL_JS_CALL")] FlashExternalJsCall = 31,
        /// <summary>
        /// Flash movie attempts to call flash system commands
        /// </summary>
        [pbr::OriginalName("FLASH_EXTERNAL_FS_CALL")] FlashExternalFsCall = 32,
        /// <summary>
        /// Image file is too large.
        /// </summary>
        [pbr::OriginalName("FILE_TOO_LARGE")] FileTooLarge = 33,
        /// <summary>
        /// Image data is too large.
        /// </summary>
        [pbr::OriginalName("IMAGE_DATA_TOO_LARGE")] ImageDataTooLarge = 34,
        /// <summary>
        /// Error while processing the image.
        /// </summary>
        [pbr::OriginalName("IMAGE_PROCESSING_ERROR")] ImageProcessingError = 35,
        /// <summary>
        /// Image is too small.
        /// </summary>
        [pbr::OriginalName("IMAGE_TOO_SMALL")] ImageTooSmall = 36,
        /// <summary>
        /// Input was invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_INPUT")] InvalidInput = 37,
        /// <summary>
        /// There was a problem reading the image file.
        /// </summary>
        [pbr::OriginalName("PROBLEM_READING_FILE")] ProblemReadingFile = 38,
        /// <summary>
        /// Image constraints are violated, but details like ASPECT_RATIO_NOT_ALLOWED
        /// can't be provided. This happens when asset spec contains more than one
        /// constraint and different criteria of different constraints are violated.
        /// </summary>
        [pbr::OriginalName("IMAGE_CONSTRAINTS_VIOLATED")] ImageConstraintsViolated = 39,
        /// <summary>
        /// Image format is not allowed.
        /// </summary>
        [pbr::OriginalName("FORMAT_NOT_ALLOWED")] FormatNotAllowed = 40,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
