// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/errors/image_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/errors/image_error.proto</summary>
  public static partial class ImageErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/errors/image_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ImageErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lcnJvcnMvaW1hZ2VfZXJyb3Iu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmVycm9ycxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byKqCAoOSW1hZ2VFcnJvckVudW0ilwgK",
            "CkltYWdlRXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESEQoN",
            "SU5WQUxJRF9JTUFHRRACEhEKDVNUT1JBR0VfRVJST1IQAxIPCgtCQURfUkVR",
            "VUVTVBAEEhMKD1VORVhQRUNURURfU0laRRAFEhgKFEFOSU1BVEVEX05PVF9B",
            "TExPV0VEEAYSFgoSQU5JTUFUSU9OX1RPT19MT05HEAcSEAoMU0VSVkVSX0VS",
            "Uk9SEAgSGQoVQ01ZS19KUEVHX05PVF9BTExPV0VEEAkSFQoRRkxBU0hfTk9U",
            "X0FMTE9XRUQQChIaChZGTEFTSF9XSVRIT1VUX0NMSUNLVEFHEAsSJgoiRkxB",
            "U0hfRVJST1JfQUZURVJfRklYSU5HX0NMSUNLX1RBRxAMEhoKFkFOSU1BVEVE",
            "X1ZJU1VBTF9FRkZFQ1QQDRIPCgtGTEFTSF9FUlJPUhAOEhIKDkxBWU9VVF9Q",
            "Uk9CTEVNEA8SHgoaUFJPQkxFTV9SRUFESU5HX0lNQUdFX0ZJTEUQEBIXChNF",
            "UlJPUl9TVE9SSU5HX0lNQUdFEBESHAoYQVNQRUNUX1JBVElPX05PVF9BTExP",
            "V0VEEBISHQoZRkxBU0hfSEFTX05FVFdPUktfT0JKRUNUUxATEh0KGUZMQVNI",
            "X0hBU19ORVRXT1JLX01FVEhPRFMQFBIRCg1GTEFTSF9IQVNfVVJMEBUSHAoY",
            "RkxBU0hfSEFTX01PVVNFX1RSQUNLSU5HEBYSGAoURkxBU0hfSEFTX1JBTkRP",
            "TV9OVU0QFxIWChJGTEFTSF9TRUxGX1RBUkdFVFMQGBIbChdGTEFTSF9CQURf",
            "R0VUVVJMX1RBUkdFVBAZEh8KG0ZMQVNIX1ZFUlNJT05fTk9UX1NVUFBPUlRF",
            "RBAaEiYKIkZMQVNIX1dJVEhPVVRfSEFSRF9DT0RFRF9DTElDS19VUkwQGxIW",
            "ChJJTlZBTElEX0ZMQVNIX0ZJTEUQHBIkCiBGQUlMRURfVE9fRklYX0NMSUNL",
            "X1RBR19JTl9GTEFTSBAdEiQKIEZMQVNIX0FDQ0VTU0VTX05FVFdPUktfUkVT",
            "T1VSQ0VTEB4SGgoWRkxBU0hfRVhURVJOQUxfSlNfQ0FMTBAfEhoKFkZMQVNI",
            "X0VYVEVSTkFMX0ZTX0NBTEwQIBISCg5GSUxFX1RPT19MQVJHRRAhEhgKFElN",
            "QUdFX0RBVEFfVE9PX0xBUkdFECISGgoWSU1BR0VfUFJPQ0VTU0lOR19FUlJP",
            "UhAjEhMKD0lNQUdFX1RPT19TTUFMTBAkEhEKDUlOVkFMSURfSU5QVVQQJRIY",
            "ChRQUk9CTEVNX1JFQURJTkdfRklMRRAmEh4KGklNQUdFX0NPTlNUUkFJTlRT",
            "X1ZJT0xBVEVEECdC6gEKImNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5l",
            "cnJvcnNCD0ltYWdlRXJyb3JQcm90b1ABWkRnb29nbGUuZ29sYW5nLm9yZy9n",
            "ZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZXJyb3JzO2Vy",
            "cm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLkVycm9yc8oC",
            "Hkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVycm9yc+oCIkdvb2dsZTo6QWRz",
            "OjpHb29nbGVBZHM6OlYzOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Errors.ImageErrorEnum), global::Google.Ads.GoogleAds.V3.Errors.ImageErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Errors.ImageErrorEnum.Types.ImageError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible image errors.
  /// </summary>
  public sealed partial class ImageErrorEnum : pb::IMessage<ImageErrorEnum> {
    private static readonly pb::MessageParser<ImageErrorEnum> _parser = new pb::MessageParser<ImageErrorEnum>(() => new ImageErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ImageErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Errors.ImageErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageErrorEnum(ImageErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ImageErrorEnum Clone() {
      return new ImageErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ImageErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
    public void MergeFrom(ImageErrorEnum other) {
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
    /// <summary>Container for nested types declared in the ImageErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
