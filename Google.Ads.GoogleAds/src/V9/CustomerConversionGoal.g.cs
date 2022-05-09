// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v9/resources/customer_conversion_goal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V9.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v9/resources/customer_conversion_goal.proto</summary>
  public static partial class CustomerConversionGoalReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v9/resources/customer_conversion_goal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerConversionGoalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "Y29udmVyc2lvbl9nb2FsLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "OS5yZXNvdXJjZXMaPmdvb2dsZS9hZHMvZ29vZ2xlYWRzL3Y5L2VudW1zL2Nv",
            "bnZlcnNpb25fYWN0aW9uX2NhdGVnb3J5LnByb3RvGjVnb29nbGUvYWRzL2dv",
            "b2dsZWFkcy92OS9lbnVtcy9jb252ZXJzaW9uX29yaWdpbi5wcm90bxofZ29v",
            "Z2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNv",
            "dXJjZS5wcm90byKzAwoWQ3VzdG9tZXJDb252ZXJzaW9uR29hbBJOCg1yZXNv",
            "dXJjZV9uYW1lGAEgASgJQjfgQQX6QTEKL2dvb2dsZWFkcy5nb29nbGVhcGlz",
            "LmNvbS9DdXN0b21lckNvbnZlcnNpb25Hb2FsEmYKCGNhdGVnb3J5GAIgASgO",
            "MlQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMuQ29udmVyc2lvbkFj",
            "dGlvbkNhdGVnb3J5RW51bS5Db252ZXJzaW9uQWN0aW9uQ2F0ZWdvcnkSVAoG",
            "b3JpZ2luGAMgASgOMkQuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjkuZW51bXMu",
            "Q29udmVyc2lvbk9yaWdpbkVudW0uQ29udmVyc2lvbk9yaWdpbhIQCghiaWRk",
            "YWJsZRgEIAEoCDp56kF2Ci9nb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3Vz",
            "dG9tZXJDb252ZXJzaW9uR29hbBJDY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "Y3VzdG9tZXJDb252ZXJzaW9uR29hbHMve2NhdGVnb3J5fX57c291cmNlfUKI",
            "AgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY5LnJlc291cmNlc0IbQ3Vz",
            "dG9tZXJDb252ZXJzaW9uR29hbFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3Jn",
            "L2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92OS9yZXNvdXJj",
            "ZXM7cmVzb3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjku",
            "UmVzb3VyY2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjlcUmVzb3VyY2Vz",
            "6gIlR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6Vjk6OlJlc291cmNlc2IGcHJv",
            "dG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryReflection.Descriptor, global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V9.Resources.CustomerConversionGoal), global::Google.Ads.GoogleAds.V9.Resources.CustomerConversionGoal.Parser, new[]{ "ResourceName", "Category", "Origin", "Biddable" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Biddability control for conversion actions with a matching category and
  /// origin.
  /// </summary>
  public sealed partial class CustomerConversionGoal : pb::IMessage<CustomerConversionGoal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerConversionGoal> _parser = new pb::MessageParser<CustomerConversionGoal>(() => new CustomerConversionGoal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerConversionGoal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V9.Resources.CustomerConversionGoalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerConversionGoal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerConversionGoal(CustomerConversionGoal other) : this() {
      resourceName_ = other.resourceName_;
      category_ = other.category_;
      origin_ = other.origin_;
      biddable_ = other.biddable_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerConversionGoal Clone() {
      return new CustomerConversionGoal(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer conversion goal.
    /// Customer conversion goal resource names have the form:
    ///
    /// `customers/{customer_id}/customerConversionGoals/{category}~{origin}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory category_ = global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified;
    /// <summary>
    /// The conversion category of this customer conversion goal. Only
    /// conversion actions that have this category will be included in this goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "origin" field.</summary>
    public const int OriginFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin origin_ = global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified;
    /// <summary>
    /// The conversion origin of this customer conversion goal. Only
    /// conversion actions that have this conversion origin will be included in
    /// this goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin Origin {
      get { return origin_; }
      set {
        origin_ = value;
      }
    }

    /// <summary>Field number for the "biddable" field.</summary>
    public const int BiddableFieldNumber = 4;
    private bool biddable_;
    /// <summary>
    /// The biddability of the customer conversion goal.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Biddable {
      get { return biddable_; }
      set {
        biddable_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerConversionGoal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerConversionGoal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Category != other.Category) return false;
      if (Origin != other.Origin) return false;
      if (Biddable != other.Biddable) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (Category != global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) hash ^= Category.GetHashCode();
      if (Origin != global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) hash ^= Origin.GetHashCode();
      if (Biddable != false) hash ^= Biddable.GetHashCode();
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
      if (Category != global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Origin);
      }
      if (Biddable != false) {
        output.WriteRawTag(32);
        output.WriteBool(Biddable);
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
      if (Category != global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Origin);
      }
      if (Biddable != false) {
        output.WriteRawTag(32);
        output.WriteBool(Biddable);
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
      if (Category != global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Category);
      }
      if (Origin != global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Origin);
      }
      if (Biddable != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerConversionGoal other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.Category != global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory.Unspecified) {
        Category = other.Category;
      }
      if (other.Origin != global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin.Unspecified) {
        Origin = other.Origin;
      }
      if (other.Biddable != false) {
        Biddable = other.Biddable;
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
          case 16: {
            Category = (global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) input.ReadEnum();
            break;
          }
          case 24: {
            Origin = (global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin) input.ReadEnum();
            break;
          }
          case 32: {
            Biddable = input.ReadBool();
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
          case 16: {
            Category = (global::Google.Ads.GoogleAds.V9.Enums.ConversionActionCategoryEnum.Types.ConversionActionCategory) input.ReadEnum();
            break;
          }
          case 24: {
            Origin = (global::Google.Ads.GoogleAds.V9.Enums.ConversionOriginEnum.Types.ConversionOrigin) input.ReadEnum();
            break;
          }
          case 32: {
            Biddable = input.ReadBool();
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
