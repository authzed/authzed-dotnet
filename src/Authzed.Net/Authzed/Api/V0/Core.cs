// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: authzed/api/v0/core.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Authzed.Api.V0 {

  /// <summary>Holder for reflection information generated from authzed/api/v0/core.proto</summary>
  public static partial class CoreReflection {

    #region Descriptor
    /// <summary>File descriptor for authzed/api/v0/core.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlhdXRoemVkL2FwaS92MC9jb3JlLnByb3RvEg5hdXRoemVkLmFwaS52MBoX",
            "dmFsaWRhdGUvdmFsaWRhdGUucHJvdG8ioAEKDVJlbGF0aW9uVHVwbGUSWwoT",
            "b2JqZWN0X2FuZF9yZWxhdGlvbhgBIAEoCzIhLmF1dGh6ZWQuYXBpLnYwLk9i",
            "amVjdEFuZFJlbGF0aW9uQgj6QgWKAQIQAVIRb2JqZWN0QW5kUmVsYXRpb24S",
            "MgoEdXNlchgCIAEoCzIULmF1dGh6ZWQuYXBpLnYwLlVzZXJCCPpCBYoBAhAB",
            "UgR1c2VyIp0CChFPYmplY3RBbmRSZWxhdGlvbhJmCgluYW1lc3BhY2UYASAB",
            "KAlCSPpCRXJDKIABMj5eKFthLXpdW2EtejAtOV9dezEsNjF9W2EtejAtOV0v",
            "KT9bYS16XVthLXowLTlfXXsxLDYyfVthLXowLTldJFIJbmFtZXNwYWNlElIK",
            "CW9iamVjdF9pZBgCIAEoCUI1+kIycjAogAEyK14oKFthLXpBLVowLTlfXVth",
            "LXpBLVowLTkvX3wtXXswLDEyN30pfFwqKSRSCG9iamVjdElkEkwKCHJlbGF0",
            "aW9uGAMgASgJQjD6Qi1yKyhAMideKFwuXC5cLnxbYS16XVthLXowLTlfXXsx",
            "LDYyfVthLXowLTldKSRSCHJlbGF0aW9uIskBChFSZWxhdGlvblJlZmVyZW5j",
            "ZRJmCgluYW1lc3BhY2UYASABKAlCSPpCRXJDKIABMj5eKFthLXpdW2EtejAt",
            "OV9dezEsNjF9W2EtejAtOV0vKT9bYS16XVthLXowLTlfXXsxLDYyfVthLXow",
            "LTldJFIJbmFtZXNwYWNlEkwKCHJlbGF0aW9uGAMgASgJQjD6Qi1yKyhAMide",
            "KFwuXC5cLnxbYS16XVthLXowLTlfXXsxLDYyfVthLXowLTldKSRSCHJlbGF0",
            "aW9uImIKBFVzZXISRwoHdXNlcnNldBgCIAEoCzIhLmF1dGh6ZWQuYXBpLnYw",
            "Lk9iamVjdEFuZFJlbGF0aW9uQgj6QgWKAQIQAUgAUgd1c2Vyc2V0QhEKCnVz",
            "ZXJfb25lb2YSA/hCAUJIChJjb20uYXV0aHplZC5hcGkudjBaMmdpdGh1Yi5j",
            "b20vYXV0aHplZC9hdXRoemVkLWdvL3Byb3RvL2F1dGh6ZWQvYXBpL3YwYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Validate.ValidateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V0.RelationTuple), global::Authzed.Api.V0.RelationTuple.Parser, new[]{ "ObjectAndRelation", "User" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V0.ObjectAndRelation), global::Authzed.Api.V0.ObjectAndRelation.Parser, new[]{ "Namespace", "ObjectId", "Relation" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V0.RelationReference), global::Authzed.Api.V0.RelationReference.Parser, new[]{ "Namespace", "Relation" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Authzed.Api.V0.User), global::Authzed.Api.V0.User.Parser, new[]{ "Userset" }, new[]{ "UserOneof" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RelationTuple : pb::IMessage<RelationTuple>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RelationTuple> _parser = new pb::MessageParser<RelationTuple>(() => new RelationTuple());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RelationTuple> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V0.CoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationTuple() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationTuple(RelationTuple other) : this() {
      objectAndRelation_ = other.objectAndRelation_ != null ? other.objectAndRelation_.Clone() : null;
      user_ = other.user_ != null ? other.user_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationTuple Clone() {
      return new RelationTuple(this);
    }

    /// <summary>Field number for the "object_and_relation" field.</summary>
    public const int ObjectAndRelationFieldNumber = 1;
    private global::Authzed.Api.V0.ObjectAndRelation objectAndRelation_;
    /// <summary>
    /// Each tupleset specifies keys of a set of relation tuples. The set can
    /// include a single tuple key, or all tuples with a given object ID or
    /// userset in a namespace, optionally constrained by a relation name.
    ///
    /// examples:
    /// doc:readme#viewer@group:eng#member (fully specified)
    /// doc:*#*#group:eng#member (all tuples that this userset relates to)
    /// doc:12345#*#* (all tuples with a direct relationship to a document)
    /// doc:12345#writer#* (all tuples with direct write relationship with the
    /// document) doc:#writer#group:eng#member (all tuples that eng group has write
    /// relationship)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V0.ObjectAndRelation ObjectAndRelation {
      get { return objectAndRelation_; }
      set {
        objectAndRelation_ = value;
      }
    }

    /// <summary>Field number for the "user" field.</summary>
    public const int UserFieldNumber = 2;
    private global::Authzed.Api.V0.User user_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V0.User User {
      get { return user_; }
      set {
        user_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RelationTuple);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RelationTuple other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ObjectAndRelation, other.ObjectAndRelation)) return false;
      if (!object.Equals(User, other.User)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (objectAndRelation_ != null) hash ^= ObjectAndRelation.GetHashCode();
      if (user_ != null) hash ^= User.GetHashCode();
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
      if (objectAndRelation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ObjectAndRelation);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
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
      if (objectAndRelation_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ObjectAndRelation);
      }
      if (user_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(User);
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
      if (objectAndRelation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjectAndRelation);
      }
      if (user_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(User);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RelationTuple other) {
      if (other == null) {
        return;
      }
      if (other.objectAndRelation_ != null) {
        if (objectAndRelation_ == null) {
          ObjectAndRelation = new global::Authzed.Api.V0.ObjectAndRelation();
        }
        ObjectAndRelation.MergeFrom(other.ObjectAndRelation);
      }
      if (other.user_ != null) {
        if (user_ == null) {
          User = new global::Authzed.Api.V0.User();
        }
        User.MergeFrom(other.User);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (objectAndRelation_ == null) {
              ObjectAndRelation = new global::Authzed.Api.V0.ObjectAndRelation();
            }
            input.ReadMessage(ObjectAndRelation);
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new global::Authzed.Api.V0.User();
            }
            input.ReadMessage(User);
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (objectAndRelation_ == null) {
              ObjectAndRelation = new global::Authzed.Api.V0.ObjectAndRelation();
            }
            input.ReadMessage(ObjectAndRelation);
            break;
          }
          case 18: {
            if (user_ == null) {
              User = new global::Authzed.Api.V0.User();
            }
            input.ReadMessage(User);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ObjectAndRelation : pb::IMessage<ObjectAndRelation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ObjectAndRelation> _parser = new pb::MessageParser<ObjectAndRelation>(() => new ObjectAndRelation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ObjectAndRelation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V0.CoreReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectAndRelation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectAndRelation(ObjectAndRelation other) : this() {
      namespace_ = other.namespace_;
      objectId_ = other.objectId_;
      relation_ = other.relation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ObjectAndRelation Clone() {
      return new ObjectAndRelation(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 1;
    private string namespace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Namespace {
      get { return namespace_; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "object_id" field.</summary>
    public const int ObjectIdFieldNumber = 2;
    private string objectId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ObjectId {
      get { return objectId_; }
      set {
        objectId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "relation" field.</summary>
    public const int RelationFieldNumber = 3;
    private string relation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Relation {
      get { return relation_; }
      set {
        relation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ObjectAndRelation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ObjectAndRelation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (ObjectId != other.ObjectId) return false;
      if (Relation != other.Relation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Namespace.Length != 0) hash ^= Namespace.GetHashCode();
      if (ObjectId.Length != 0) hash ^= ObjectId.GetHashCode();
      if (Relation.Length != 0) hash ^= Relation.GetHashCode();
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (ObjectId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ObjectId);
      }
      if (Relation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Relation);
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (ObjectId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ObjectId);
      }
      if (Relation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Relation);
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
      if (Namespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (ObjectId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ObjectId);
      }
      if (Relation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Relation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ObjectAndRelation other) {
      if (other == null) {
        return;
      }
      if (other.Namespace.Length != 0) {
        Namespace = other.Namespace;
      }
      if (other.ObjectId.Length != 0) {
        ObjectId = other.ObjectId;
      }
      if (other.Relation.Length != 0) {
        Relation = other.Relation;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Namespace = input.ReadString();
            break;
          }
          case 18: {
            ObjectId = input.ReadString();
            break;
          }
          case 26: {
            Relation = input.ReadString();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Namespace = input.ReadString();
            break;
          }
          case 18: {
            ObjectId = input.ReadString();
            break;
          }
          case 26: {
            Relation = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class RelationReference : pb::IMessage<RelationReference>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<RelationReference> _parser = new pb::MessageParser<RelationReference>(() => new RelationReference());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<RelationReference> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V0.CoreReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationReference() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationReference(RelationReference other) : this() {
      namespace_ = other.namespace_;
      relation_ = other.relation_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public RelationReference Clone() {
      return new RelationReference(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 1;
    private string namespace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Namespace {
      get { return namespace_; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "relation" field.</summary>
    public const int RelationFieldNumber = 3;
    private string relation_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Relation {
      get { return relation_; }
      set {
        relation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as RelationReference);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(RelationReference other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (Relation != other.Relation) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Namespace.Length != 0) hash ^= Namespace.GetHashCode();
      if (Relation.Length != 0) hash ^= Relation.GetHashCode();
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (Relation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Relation);
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
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (Relation.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Relation);
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
      if (Namespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (Relation.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Relation);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(RelationReference other) {
      if (other == null) {
        return;
      }
      if (other.Namespace.Length != 0) {
        Namespace = other.Namespace;
      }
      if (other.Relation.Length != 0) {
        Relation = other.Relation;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Namespace = input.ReadString();
            break;
          }
          case 26: {
            Relation = input.ReadString();
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Namespace = input.ReadString();
            break;
          }
          case 26: {
            Relation = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class User : pb::IMessage<User>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<User> _parser = new pb::MessageParser<User>(() => new User());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<User> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Authzed.Api.V0.CoreReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User(User other) : this() {
      switch (other.UserOneofCase) {
        case UserOneofOneofCase.Userset:
          Userset = other.Userset.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public User Clone() {
      return new User(this);
    }

    /// <summary>Field number for the "userset" field.</summary>
    public const int UsersetFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Authzed.Api.V0.ObjectAndRelation Userset {
      get { return userOneofCase_ == UserOneofOneofCase.Userset ? (global::Authzed.Api.V0.ObjectAndRelation) userOneof_ : null; }
      set {
        userOneof_ = value;
        userOneofCase_ = value == null ? UserOneofOneofCase.None : UserOneofOneofCase.Userset;
      }
    }

    private object userOneof_;
    /// <summary>Enum of possible cases for the "user_oneof" oneof.</summary>
    public enum UserOneofOneofCase {
      None = 0,
      Userset = 2,
    }
    private UserOneofOneofCase userOneofCase_ = UserOneofOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserOneofOneofCase UserOneofCase {
      get { return userOneofCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearUserOneof() {
      userOneofCase_ = UserOneofOneofCase.None;
      userOneof_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as User);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(User other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Userset, other.Userset)) return false;
      if (UserOneofCase != other.UserOneofCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (userOneofCase_ == UserOneofOneofCase.Userset) hash ^= Userset.GetHashCode();
      hash ^= (int) userOneofCase_;
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
      if (userOneofCase_ == UserOneofOneofCase.Userset) {
        output.WriteRawTag(18);
        output.WriteMessage(Userset);
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
      if (userOneofCase_ == UserOneofOneofCase.Userset) {
        output.WriteRawTag(18);
        output.WriteMessage(Userset);
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
      if (userOneofCase_ == UserOneofOneofCase.Userset) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Userset);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(User other) {
      if (other == null) {
        return;
      }
      switch (other.UserOneofCase) {
        case UserOneofOneofCase.Userset:
          if (Userset == null) {
            Userset = new global::Authzed.Api.V0.ObjectAndRelation();
          }
          Userset.MergeFrom(other.Userset);
          break;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            global::Authzed.Api.V0.ObjectAndRelation subBuilder = new global::Authzed.Api.V0.ObjectAndRelation();
            if (userOneofCase_ == UserOneofOneofCase.Userset) {
              subBuilder.MergeFrom(Userset);
            }
            input.ReadMessage(subBuilder);
            Userset = subBuilder;
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            global::Authzed.Api.V0.ObjectAndRelation subBuilder = new global::Authzed.Api.V0.ObjectAndRelation();
            if (userOneofCase_ == UserOneofOneofCase.Userset) {
              subBuilder.MergeFrom(Userset);
            }
            input.ReadMessage(subBuilder);
            Userset = subBuilder;
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
