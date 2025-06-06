// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v20/resources/user_list_customer_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V20.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v20/resources/user_list_customer_type.proto</summary>
  public static partial class UserListCustomerTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v20/resources/user_list_customer_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserListCustomerTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkBnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvcmVzb3VyY2VzL3VzZXJfbGlz",
            "dF9jdXN0b21lcl90eXBlLnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52",
            "MjAucmVzb3VyY2VzGkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MjAvZW51bXMv",
            "dXNlcl9saXN0X2N1c3RvbWVyX3R5cGVfY2F0ZWdvcnkucHJvdG8aH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8iqwMKFFVzZXJMaXN0Q3VzdG9tZXJUeXBlEkwKDXJlc291cmNl",
            "X25hbWUYASABKAlCNeBBBfpBLwotZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29t",
            "L1VzZXJMaXN0Q3VzdG9tZXJUeXBlEjwKCXVzZXJfbGlzdBgCIAEoCUIp4EEF",
            "+kEjCiFnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vVXNlckxpc3QSggEKFmN1",
            "c3RvbWVyX3R5cGVfY2F0ZWdvcnkYAyABKA4yXS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MjAuZW51bXMuVXNlckxpc3RDdXN0b21lclR5cGVDYXRlZ29yeUVu",
            "dW0uVXNlckxpc3RDdXN0b21lclR5cGVDYXRlZ29yeUID4EEFOoEB6kF+Ci1n",
            "b29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vVXNlckxpc3RDdXN0b21lclR5cGUS",
            "TWN1c3RvbWVycy97Y3VzdG9tZXJfaWR9L3VzZXJMaXN0Q3VzdG9tZXJUeXBl",
            "cy97dXNlcl9saXN0X2lkfX57c2VtYW50aWNfbGFiZWx9QosCCiZjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjIwLnJlc291cmNlc0IZVXNlckxpc3RDdXN0",
            "b21lclR5cGVQcm90b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9n",
            "b29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjIwL3Jlc291cmNlcztyZXNvdXJj",
            "ZXOiAgNHQUGqAiJHb29nbGUuQWRzLkdvb2dsZUFkcy5WMjAuUmVzb3VyY2Vz",
            "ygIiR29vZ2xlXEFkc1xHb29nbGVBZHNcVjIwXFJlc291cmNlc+oCJkdvb2ds",
            "ZTo6QWRzOjpHb29nbGVBZHM6OlYyMDo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V20.Resources.UserListCustomerType), global::Google.Ads.GoogleAds.V20.Resources.UserListCustomerType.Parser, new[]{ "ResourceName", "UserList", "CustomerTypeCategory" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A user list customer type
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserListCustomerType : pb::IMessage<UserListCustomerType>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserListCustomerType> _parser = new pb::MessageParser<UserListCustomerType>(() => new UserListCustomerType());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserListCustomerType> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V20.Resources.UserListCustomerTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerType() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerType(UserListCustomerType other) : this() {
      resourceName_ = other.resourceName_;
      userList_ = other.userList_;
      customerTypeCategory_ = other.customerTypeCategory_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserListCustomerType Clone() {
      return new UserListCustomerType(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the user list customer type
    /// User list customer type resource names have the form:
    /// `customers/{customer_id}/userListCustomerTypes/{user_list_id}~{customer_type_category}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_list" field.</summary>
    public const int UserListFieldNumber = 2;
    private string userList_ = "";
    /// <summary>
    /// Immutable. The resource name for the user list this user list customer type
    /// is associated with
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserList {
      get { return userList_; }
      set {
        userList_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "customer_type_category" field.</summary>
    public const int CustomerTypeCategoryFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory customerTypeCategory_ = global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified;
    /// <summary>
    /// Immutable. The user list customer type category
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory CustomerTypeCategory {
      get { return customerTypeCategory_; }
      set {
        customerTypeCategory_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserListCustomerType);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserListCustomerType other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (UserList != other.UserList) return false;
      if (CustomerTypeCategory != other.CustomerTypeCategory) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (UserList.Length != 0) hash ^= UserList.GetHashCode();
      if (CustomerTypeCategory != global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified) hash ^= CustomerTypeCategory.GetHashCode();
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
      if (UserList.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserList);
      }
      if (CustomerTypeCategory != global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CustomerTypeCategory);
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
      if (UserList.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(UserList);
      }
      if (CustomerTypeCategory != global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CustomerTypeCategory);
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
      if (UserList.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserList);
      }
      if (CustomerTypeCategory != global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CustomerTypeCategory);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserListCustomerType other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.UserList.Length != 0) {
        UserList = other.UserList;
      }
      if (other.CustomerTypeCategory != global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory.Unspecified) {
        CustomerTypeCategory = other.CustomerTypeCategory;
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
          case 18: {
            UserList = input.ReadString();
            break;
          }
          case 24: {
            CustomerTypeCategory = (global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory) input.ReadEnum();
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
          case 18: {
            UserList = input.ReadString();
            break;
          }
          case 24: {
            CustomerTypeCategory = (global::Google.Ads.GoogleAds.V20.Enums.UserListCustomerTypeCategoryEnum.Types.UserListCustomerTypeCategory) input.ReadEnum();
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
