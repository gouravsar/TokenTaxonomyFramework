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
namespace TTI.TTF.Taxonomy.Model {

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
            "Cg50YXhvbm9teS5wcm90bxIOdGF4b25vbXkubW9kZWwaCmNvcmUucHJvdG8a",
            "DWdyYW1tYXIucHJvdG8i4QYKCFRheG9ub215Eg8KB3ZlcnNpb24YASABKAkS",
            "RgoQYmFzZV90b2tlbl90eXBlcxgCIAMoCzIsLnRheG9ub215Lm1vZGVsLlRh",
            "eG9ub215LkJhc2VUb2tlblR5cGVzRW50cnkSOgoJYmVoYXZpb3JzGAMgAygL",
            "MicudGF4b25vbXkubW9kZWwuVGF4b25vbXkuQmVoYXZpb3JzRW50cnkSRQoP",
            "YmVoYXZpb3JfZ3JvdXBzGAQgAygLMiwudGF4b25vbXkubW9kZWwuVGF4b25v",
            "bXkuQmVoYXZpb3JHcm91cHNFbnRyeRJBCg1wcm9wZXJ0eV9zZXRzGAUgAygL",
            "MioudGF4b25vbXkubW9kZWwuVGF4b25vbXkuUHJvcGVydHlTZXRzRW50cnkS",
            "RQoPdG9rZW5fdGVtcGxhdGVzGAYgAygLMiwudGF4b25vbXkubW9kZWwuVGF4",
            "b25vbXkuVG9rZW5UZW1wbGF0ZXNFbnRyeRI/Cg9mb3JtdWxhX2dyYW1tYXIY",
            "ByABKAsyJi50YXhvbm9teS5tb2RlbC5ncmFtbWFyLkZvcm11bGFHcmFtbWFy",
            "GlAKE0Jhc2VUb2tlblR5cGVzRW50cnkSCwoDa2V5GAEgASgJEigKBXZhbHVl",
            "GAIgASgLMhkudGF4b25vbXkubW9kZWwuY29yZS5CYXNlOgI4ARpPCg5CZWhh",
            "dmlvcnNFbnRyeRILCgNrZXkYASABKAkSLAoFdmFsdWUYAiABKAsyHS50YXhv",
            "bm9teS5tb2RlbC5jb3JlLkJlaGF2aW9yOgI4ARpZChNCZWhhdmlvckdyb3Vw",
            "c0VudHJ5EgsKA2tleRgBIAEoCRIxCgV2YWx1ZRgCIAEoCzIiLnRheG9ub215",
            "Lm1vZGVsLmNvcmUuQmVoYXZpb3JHcm91cDoCOAEaVQoRUHJvcGVydHlTZXRz",
            "RW50cnkSCwoDa2V5GAEgASgJEi8KBXZhbHVlGAIgASgLMiAudGF4b25vbXku",
            "bW9kZWwuY29yZS5Qcm9wZXJ0eVNldDoCOAEaWQoTVG9rZW5UZW1wbGF0ZXNF",
            "bnRyeRILCgNrZXkYASABKAkSMQoFdmFsdWUYAiABKAsyIi50YXhvbm9teS5t",
            "b2RlbC5jb3JlLlRva2VuVGVtcGxhdGU6AjgBQjcKGm9yZy50dGkudHRmLnRh",
            "eG9ub215Lm1vZGVsUAGqAhZUVEkuVFRGLlRheG9ub215Lk1vZGVsYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TTI.TTF.Model.Core.CoreReflection.Descriptor, global::TTI.TTF.Model.Grammar.GrammarReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.Model.Taxonomy), global::TTI.TTF.Taxonomy.Model.Taxonomy.Parser, new[]{ "Version", "BaseTokenTypes", "Behaviors", "BehaviorGroups", "PropertySets", "TokenTemplates", "FormulaGrammar" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, null, })
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
      get { return global::TTI.TTF.Taxonomy.Model.TaxonomyReflection.Descriptor.MessageTypes[0]; }
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
      formulaGrammar_ = other.formulaGrammar_ != null ? other.formulaGrammar_.Clone() : null;
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
    private static readonly pbc::MapField<string, global::TTI.TTF.Model.Core.Base>.Codec _map_baseTokenTypes_codec
        = new pbc::MapField<string, global::TTI.TTF.Model.Core.Base>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Model.Core.Base.Parser), 18);
    private readonly pbc::MapField<string, global::TTI.TTF.Model.Core.Base> baseTokenTypes_ = new pbc::MapField<string, global::TTI.TTF.Model.Core.Base>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Model.Core.Base> BaseTokenTypes {
      get { return baseTokenTypes_; }
    }

    /// <summary>Field number for the "behaviors" field.</summary>
    public const int BehaviorsFieldNumber = 3;
    private static readonly pbc::MapField<string, global::TTI.TTF.Model.Core.Behavior>.Codec _map_behaviors_codec
        = new pbc::MapField<string, global::TTI.TTF.Model.Core.Behavior>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Model.Core.Behavior.Parser), 26);
    private readonly pbc::MapField<string, global::TTI.TTF.Model.Core.Behavior> behaviors_ = new pbc::MapField<string, global::TTI.TTF.Model.Core.Behavior>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Model.Core.Behavior> Behaviors {
      get { return behaviors_; }
    }

    /// <summary>Field number for the "behavior_groups" field.</summary>
    public const int BehaviorGroupsFieldNumber = 4;
    private static readonly pbc::MapField<string, global::TTI.TTF.Model.Core.BehaviorGroup>.Codec _map_behaviorGroups_codec
        = new pbc::MapField<string, global::TTI.TTF.Model.Core.BehaviorGroup>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Model.Core.BehaviorGroup.Parser), 34);
    private readonly pbc::MapField<string, global::TTI.TTF.Model.Core.BehaviorGroup> behaviorGroups_ = new pbc::MapField<string, global::TTI.TTF.Model.Core.BehaviorGroup>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Model.Core.BehaviorGroup> BehaviorGroups {
      get { return behaviorGroups_; }
    }

    /// <summary>Field number for the "property_sets" field.</summary>
    public const int PropertySetsFieldNumber = 5;
    private static readonly pbc::MapField<string, global::TTI.TTF.Model.Core.PropertySet>.Codec _map_propertySets_codec
        = new pbc::MapField<string, global::TTI.TTF.Model.Core.PropertySet>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Model.Core.PropertySet.Parser), 42);
    private readonly pbc::MapField<string, global::TTI.TTF.Model.Core.PropertySet> propertySets_ = new pbc::MapField<string, global::TTI.TTF.Model.Core.PropertySet>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Model.Core.PropertySet> PropertySets {
      get { return propertySets_; }
    }

    /// <summary>Field number for the "token_templates" field.</summary>
    public const int TokenTemplatesFieldNumber = 6;
    private static readonly pbc::MapField<string, global::TTI.TTF.Model.Core.TokenTemplate>.Codec _map_tokenTemplates_codec
        = new pbc::MapField<string, global::TTI.TTF.Model.Core.TokenTemplate>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForMessage(18, global::TTI.TTF.Model.Core.TokenTemplate.Parser), 50);
    private readonly pbc::MapField<string, global::TTI.TTF.Model.Core.TokenTemplate> tokenTemplates_ = new pbc::MapField<string, global::TTI.TTF.Model.Core.TokenTemplate>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::TTI.TTF.Model.Core.TokenTemplate> TokenTemplates {
      get { return tokenTemplates_; }
    }

    /// <summary>Field number for the "formula_grammar" field.</summary>
    public const int FormulaGrammarFieldNumber = 7;
    private global::TTI.TTF.Model.Grammar.FormulaGrammar formulaGrammar_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Model.Grammar.FormulaGrammar FormulaGrammar {
      get { return formulaGrammar_; }
      set {
        formulaGrammar_ = value;
      }
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
      if (!object.Equals(FormulaGrammar, other.FormulaGrammar)) return false;
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
      if (formulaGrammar_ != null) hash ^= FormulaGrammar.GetHashCode();
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
      if (formulaGrammar_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(FormulaGrammar);
      }
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
      if (formulaGrammar_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(FormulaGrammar);
      }
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
      if (other.formulaGrammar_ != null) {
        if (formulaGrammar_ == null) {
          FormulaGrammar = new global::TTI.TTF.Model.Grammar.FormulaGrammar();
        }
        FormulaGrammar.MergeFrom(other.FormulaGrammar);
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
          case 58: {
            if (formulaGrammar_ == null) {
              FormulaGrammar = new global::TTI.TTF.Model.Grammar.FormulaGrammar();
            }
            input.ReadMessage(FormulaGrammar);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
