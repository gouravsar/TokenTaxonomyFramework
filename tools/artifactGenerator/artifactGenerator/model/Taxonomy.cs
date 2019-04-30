// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: taxonomy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TTF.Tokens.Model.Taxonomy {

  /// <summary>Holder for reflection information generated from taxonomy.proto</summary>
  public static partial class TaxonomyReflection {

    #region Descriptor
    /// <summary>File descriptor for taxonomy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaxonomyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg50YXhvbm9teS5wcm90bxIOdGF4b25vbXkubW9kZWwaCmNvcmUucHJvdG8i",
            "oAYKCFRheG9ub215Eg8KB3ZlcnNpb24YASABKAkSRgoQYmFzZV90b2tlbl90",
            "eXBlcxgCIAMoCzIsLnRheG9ub215Lm1vZGVsLlRheG9ub215LkJhc2VUb2tl",
            "blR5cGVzRW50cnkSOgoJYmVoYXZpb3JzGAMgAygLMicudGF4b25vbXkubW9k",
            "ZWwuVGF4b25vbXkuQmVoYXZpb3JzRW50cnkSRQoPYmVoYXZpb3JfZ3JvdXBz",
            "GAQgAygLMiwudGF4b25vbXkubW9kZWwuVGF4b25vbXkuQmVoYXZpb3JHcm91",
            "cHNFbnRyeRJBCg1wcm9wZXJ0eV9zZXRzGAUgAygLMioudGF4b25vbXkubW9k",
            "ZWwuVGF4b25vbXkuUHJvcGVydHlTZXRzRW50cnkSRQoPdG9rZW5fdGVtcGxh",
            "dGVzGAYgAygLMiwudGF4b25vbXkubW9kZWwuVGF4b25vbXkuVG9rZW5UZW1w",
            "bGF0ZXNFbnRyeRpQChNCYXNlVG9rZW5UeXBlc0VudHJ5EgsKA2tleRgBIAEo",
            "CRIoCgV2YWx1ZRgCIAEoCzIZLnRheG9ub215Lm1vZGVsLmNvcmUuQmFzZToC",
            "OAEaTwoOQmVoYXZpb3JzRW50cnkSCwoDa2V5GAEgASgJEiwKBXZhbHVlGAIg",
            "ASgLMh0udGF4b25vbXkubW9kZWwuY29yZS5CZWhhdmlvcjoCOAEaWQoTQmVo",
            "YXZpb3JHcm91cHNFbnRyeRILCgNrZXkYASABKAkSMQoFdmFsdWUYAiABKAsy",
            "Ii50YXhvbm9teS5tb2RlbC5jb3JlLkJlaGF2aW9yR3JvdXA6AjgBGlUKEVBy",
            "b3BlcnR5U2V0c0VudHJ5EgsKA2tleRgBIAEoCRIvCgV2YWx1ZRgCIAEoCzIg",
            "LnRheG9ub215Lm1vZGVsLmNvcmUuUHJvcGVydHlTZXQ6AjgBGlkKE1Rva2Vu",
            "VGVtcGxhdGVzRW50cnkSCwoDa2V5GAEgASgJEjEKBXZhbHVlGAIgASgLMiIu",
            "dGF4b25vbXkubW9kZWwuY29yZS5Ub2tlblRlbXBsYXRlOgI4AUJRCjFvcmcu",
            "dG9rZW50YXhvbm9teWluaXRpYXRpdmUudG9rZW5zLm1vZGVsLnRheG9ub215",
            "UAGqAhlUVEYuVG9rZW5zLk1vZGVsLlRheG9ub215YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TTF.Tokens.Model.Core.CoreReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TTF.Tokens.Model.Taxonomy.Taxonomy), global::TTF.Tokens.Model.Taxonomy.Taxonomy.Parser, new[]{ "Version", "BaseTokenTypes", "Behaviors", "BehaviorGroups", "PropertySets", "TokenTemplates" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///each collection defined in a map with the index being the symbol of the artifact for the collection.
  /// </summary>
  public sealed partial class Taxonomy : pb::IMessage<Taxonomy> {
    private static readonly pb::MessageParser<Taxonomy> _parser = new pb::MessageParser<Taxonomy>(() => new Taxonomy());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Taxonomy> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTF.Tokens.Model.Taxonomy.TaxonomyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy(Taxonomy other) : this() {
      version_ = other.version_;
      baseTokenTypes_ = other.baseTokenTypes_.Clone();
      behaviors_ = other.behaviors_.Clone();
      behaviorGroups_ = other.behaviorGroups_.Clone();
      propertySets_ = other.propertySets_.Clone();
      tokenTemplates_ = other.tokenTemplates_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Taxonomy Clone() {
      return new Taxonomy(this);
    }

    /// <summary>Field number for the "version" field.</summary>
    public const int VersionFieldNumber = 1;
    private string version_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Version {
      get { return version_; }
      set {
        version_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "base_token_types" field.</summary>
    public const int BaseTokenTypesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.Base>.Codec _map_baseTokenTypes_codec
        = new pbc::MapField<string, global::TTF.Tokens.Model.Core.Base>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTF.Tokens.Model.Core.Base.Parser), 18);
    private readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.Base> baseTokenTypes_ = new pbc::MapField<string, global::TTF.Tokens.Model.Core.Base>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTF.Tokens.Model.Core.Base> BaseTokenTypes {
      get { return baseTokenTypes_; }
    }

    /// <summary>Field number for the "behaviors" field.</summary>
    public const int BehaviorsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.Behavior>.Codec _map_behaviors_codec
        = new pbc::MapField<string, global::TTF.Tokens.Model.Core.Behavior>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTF.Tokens.Model.Core.Behavior.Parser), 26);
    private readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.Behavior> behaviors_ = new pbc::MapField<string, global::TTF.Tokens.Model.Core.Behavior>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTF.Tokens.Model.Core.Behavior> Behaviors {
      get { return behaviors_; }
    }

    /// <summary>Field number for the "behavior_groups" field.</summary>
    public const int BehaviorGroupsFieldNumber = 4;
    private static readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.BehaviorGroup>.Codec _map_behaviorGroups_codec
        = new pbc::MapField<string, global::TTF.Tokens.Model.Core.BehaviorGroup>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTF.Tokens.Model.Core.BehaviorGroup.Parser), 34);
    private readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.BehaviorGroup> behaviorGroups_ = new pbc::MapField<string, global::TTF.Tokens.Model.Core.BehaviorGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTF.Tokens.Model.Core.BehaviorGroup> BehaviorGroups {
      get { return behaviorGroups_; }
    }

    /// <summary>Field number for the "property_sets" field.</summary>
    public const int PropertySetsFieldNumber = 5;
    private static readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.PropertySet>.Codec _map_propertySets_codec
        = new pbc::MapField<string, global::TTF.Tokens.Model.Core.PropertySet>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTF.Tokens.Model.Core.PropertySet.Parser), 42);
    private readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.PropertySet> propertySets_ = new pbc::MapField<string, global::TTF.Tokens.Model.Core.PropertySet>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTF.Tokens.Model.Core.PropertySet> PropertySets {
      get { return propertySets_; }
    }

    /// <summary>Field number for the "token_templates" field.</summary>
    public const int TokenTemplatesFieldNumber = 6;
    private static readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.TokenTemplate>.Codec _map_tokenTemplates_codec
        = new pbc::MapField<string, global::TTF.Tokens.Model.Core.TokenTemplate>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTF.Tokens.Model.Core.TokenTemplate.Parser), 50);
    private readonly pbc::MapField<string, global::TTF.Tokens.Model.Core.TokenTemplate> tokenTemplates_ = new pbc::MapField<string, global::TTF.Tokens.Model.Core.TokenTemplate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTF.Tokens.Model.Core.TokenTemplate> TokenTemplates {
      get { return tokenTemplates_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Taxonomy);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Taxonomy other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Version != other.Version) return false;
      if (!BaseTokenTypes.Equals(other.BaseTokenTypes)) return false;
      if (!Behaviors.Equals(other.Behaviors)) return false;
      if (!BehaviorGroups.Equals(other.BehaviorGroups)) return false;
      if (!PropertySets.Equals(other.PropertySets)) return false;
      if (!TokenTemplates.Equals(other.TokenTemplates)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Version.Length != 0) hash ^= Version.GetHashCode();
      hash ^= BaseTokenTypes.GetHashCode();
      hash ^= Behaviors.GetHashCode();
      hash ^= BehaviorGroups.GetHashCode();
      hash ^= PropertySets.GetHashCode();
      hash ^= TokenTemplates.GetHashCode();
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
      if (Version.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Version);
      }
      baseTokenTypes_.WriteTo(output, _map_baseTokenTypes_codec);
      behaviors_.WriteTo(output, _map_behaviors_codec);
      behaviorGroups_.WriteTo(output, _map_behaviorGroups_codec);
      propertySets_.WriteTo(output, _map_propertySets_codec);
      tokenTemplates_.WriteTo(output, _map_tokenTemplates_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Version.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Version);
      }
      size += baseTokenTypes_.CalculateSize(_map_baseTokenTypes_codec);
      size += behaviors_.CalculateSize(_map_behaviors_codec);
      size += behaviorGroups_.CalculateSize(_map_behaviorGroups_codec);
      size += propertySets_.CalculateSize(_map_propertySets_codec);
      size += tokenTemplates_.CalculateSize(_map_tokenTemplates_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Taxonomy other) {
      if (other == null) {
        return;
      }
      if (other.Version.Length != 0) {
        Version = other.Version;
      }
      baseTokenTypes_.Add(other.baseTokenTypes_);
      behaviors_.Add(other.behaviors_);
      behaviorGroups_.Add(other.behaviorGroups_);
      propertySets_.Add(other.propertySets_);
      tokenTemplates_.Add(other.tokenTemplates_);
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
            Version = input.ReadString();
            break;
          }
          case 18: {
            baseTokenTypes_.AddEntriesFrom(input, _map_baseTokenTypes_codec);
            break;
          }
          case 26: {
            behaviors_.AddEntriesFrom(input, _map_behaviors_codec);
            break;
          }
          case 34: {
            behaviorGroups_.AddEntriesFrom(input, _map_behaviorGroups_codec);
            break;
          }
          case 42: {
            propertySets_.AddEntriesFrom(input, _map_propertySets_codec);
            break;
          }
          case 50: {
            tokenTemplates_.AddEntriesFrom(input, _map_tokenTemplates_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
