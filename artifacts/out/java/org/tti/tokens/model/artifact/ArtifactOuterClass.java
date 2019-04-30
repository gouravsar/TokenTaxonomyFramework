// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: artifact.proto

package org.tti.tokens.model.artifact;

public final class ArtifactOuterClass {
  private ArtifactOuterClass() {}
  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistryLite registry) {
  }

  public static void registerAllExtensions(
      com.google.protobuf.ExtensionRegistry registry) {
    registerAllExtensions(
        (com.google.protobuf.ExtensionRegistryLite) registry);
  }
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_Artifact_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_Artifact_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactSymbol_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactDefinition_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactAnalogy_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_ArtifactFile_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_ArtifactFile_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_Maps_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_Maps_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_MapReference_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_MapResourceEntry_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_NewArtifactRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_NewArtifactResponse_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_UpdateArtifactRequest_fieldAccessorTable;
  static final com.google.protobuf.Descriptors.Descriptor
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor;
  static final 
    com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internal_static_taxonomy_model_artifact_UpdateArtifactResponse_fieldAccessorTable;

  public static com.google.protobuf.Descriptors.FileDescriptor
      getDescriptor() {
    return descriptor;
  }
  private static  com.google.protobuf.Descriptors.FileDescriptor
      descriptor;
  static {
    java.lang.String[] descriptorData = {
      "\n\016artifact.proto\022\027taxonomy.model.artifac" +
      "t\032\031google/protobuf/any.proto\"\267\003\n\010Artifac" +
      "t\0223\n\004type\030\001 \001(\0162%.taxonomy.model.artifac" +
      "t.ArtifactType\022\014\n\004name\030\002 \001(\t\022\017\n\007aliases\030" +
      "\003 \003(\t\022@\n\017artifact_symbol\030\004 \001(\0132\'.taxonom" +
      "y.model.artifact.ArtifactSymbol\022\023\n\013contr" +
      "ol_uri\030\005 \001(\t\022H\n\023artifact_definition\030\006 \001(" +
      "\0132+.taxonomy.model.artifact.ArtifactDefi" +
      "nition\022J\n\031incompatible_with_symbols\030\007 \003(" +
      "\0132\'.taxonomy.model.artifact.ArtifactSymb" +
      "ol\022=\n\016artifact_files\030\010 \003(\0132%.taxonomy.mo" +
      "del.artifact.ArtifactFile\022+\n\004maps\030\t \001(\0132" +
      "\035.taxonomy.model.artifact.Maps\"?\n\016Artifa" +
      "ctSymbol\022\025\n\rvisual_symbol\030\004 \001(\t\022\026\n\016tooli" +
      "ng_symbol\030\005 \001(\t\"\320\001\n\022ArtifactDefinition\022\034" +
      "\n\024business_description\030\001 \001(\t\022\030\n\020business" +
      "_example\030\002 \001(\t\022;\n\tanalogies\030\003 \003(\0132(.taxo" +
      "nomy.model.artifact.ArtifactAnalogy\022\020\n\010c" +
      "omments\030\004 \001(\t\0223\n\010artifact\030\005 \001(\0132!.taxono" +
      "my.model.artifact.Artifact\"~\n\017ArtifactAn" +
      "alogy\022\014\n\004name\030\001 \001(\t\022\023\n\013description\030\002 \001(\t" +
      "\022H\n\023artifact_definition\030\003 \001(\0132+.taxonomy" +
      ".model.artifact.ArtifactDefinition\"\244\001\n\014A" +
      "rtifactFile\0229\n\007content\030\001 \001(\0162(.taxonomy." +
      "model.artifact.ArtifactContent\022\021\n\tfile_n" +
      "ame\030\002 \001(\t\022\021\n\tfile_data\030\003 \001(\014\0223\n\010artifact" +
      "\030\004 \001(\0132!.taxonomy.model.artifact.Artifac" +
      "t\"\203\002\n\004Maps\022>\n\017code_references\030\001 \003(\0132%.ta" +
      "xonomy.model.artifact.MapReference\022H\n\031im" +
      "plementation_references\030\002 \003(\0132%.taxonomy" +
      ".model.artifact.MapReference\022<\n\tresource" +
      "s\030\003 \003(\0132).taxonomy.model.artifact.MapRes" +
      "ourceEntry\0223\n\010artifact\030\004 \001(\0132!.taxonomy." +
      "model.artifact.Artifact\"\330\001\n\014MapReference" +
      "\022:\n\014mapping_type\030\001 \001(\0162$.taxonomy.model." +
      "artifact.MappingType\022\014\n\004name\030\002 \001(\t\0229\n\010pl" +
      "atform\030\003 \001(\0162\'.taxonomy.model.artifact.T" +
      "argetPlatform\022\026\n\016reference_path\030\004 \001(\t\022+\n" +
      "\004maps\030\005 \001(\0132\035.taxonomy.model.artifact.Ma" +
      "ps\"\265\001\n\020MapResourceEntry\022:\n\014mapping_type\030" +
      "\001 \001(\0162$.taxonomy.model.artifact.MappingT" +
      "ype\022\014\n\004name\030\002 \001(\t\022\023\n\013description\030\003 \001(\t\022\025" +
      "\n\rresource_path\030\004 \001(\t\022+\n\004maps\030\005 \001(\0132\035.ta" +
      "xonomy.model.artifact.Maps\"W\n\022NewArtifac" +
      "tRequest\0223\n\004type\030\001 \001(\0162%.taxonomy.model." +
      "artifact.ArtifactType\022\014\n\004name\030\002 \001(\t\"~\n\023N" +
      "ewArtifactResponse\0223\n\004type\030\001 \001(\0162%.taxon" +
      "omy.model.artifact.ArtifactType\0222\n\024artif" +
      "act_type_object\030\002 \001(\0132\024.google.protobuf." +
      "Any\"\200\001\n\025UpdateArtifactRequest\0223\n\004type\030\001 " +
      "\001(\0162%.taxonomy.model.artifact.ArtifactTy" +
      "pe\0222\n\024artifact_type_object\030\002 \001(\0132\024.googl" +
      "e.protobuf.Any\"\201\001\n\026UpdateArtifactRespons" +
      "e\0223\n\004type\030\001 \001(\0162%.taxonomy.model.artifac" +
      "t.ArtifactType\0222\n\024artifact_type_object\030\002" +
      " \001(\0132\024.google.protobuf.Any*`\n\014ArtifactTy" +
      "pe\022\010\n\004BASE\020\000\022\014\n\010BEHAVIOR\020\001\022\022\n\016BEHAVIOR_G" +
      "ROUP\020\002\022\020\n\014PROPERTY_SET\020\003\022\022\n\016TOKEN_TEMPLA" +
      "TE\020\004*B\n\017ArtifactContent\022\016\n\nDEFINITION\020\000\022" +
      "\013\n\007CONTROL\020\001\022\007\n\003UML\020\002\022\t\n\005OTHER\020\003*@\n\013Mapp" +
      "ingType\022\017\n\013SOURCE_CODE\020\000\022\022\n\016IMPLEMENTATI" +
      "ON\020\001\022\014\n\010RESOURCE\020\002*v\n\016TargetPlatform\022\025\n\021" +
      "ETHEREUM_SOLIDITY\020\000\022\020\n\014CHAINCODE_GO\020\001\022\022\n" +
      "\016CHAINCODE_JAVA\020\002\022\022\n\016CHAINCODE_NODE\020\003\022\t\n" +
      "\005CORDA\020\004\022\010\n\004DAML\020\005B=\n\035org.tti.tokens.mod" +
      "el.artifactP\001\252\002\031TTF.Tokens.Model.Artifac" +
      "tb\006proto3"
    };
    com.google.protobuf.Descriptors.FileDescriptor.InternalDescriptorAssigner assigner =
        new com.google.protobuf.Descriptors.FileDescriptor.    InternalDescriptorAssigner() {
          public com.google.protobuf.ExtensionRegistry assignDescriptors(
              com.google.protobuf.Descriptors.FileDescriptor root) {
            descriptor = root;
            return null;
          }
        };
    com.google.protobuf.Descriptors.FileDescriptor
      .internalBuildGeneratedFileFrom(descriptorData,
        new com.google.protobuf.Descriptors.FileDescriptor[] {
          com.google.protobuf.AnyProto.getDescriptor(),
        }, assigner);
    internal_static_taxonomy_model_artifact_Artifact_descriptor =
      getDescriptor().getMessageTypes().get(0);
    internal_static_taxonomy_model_artifact_Artifact_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_Artifact_descriptor,
        new java.lang.String[] { "Type", "Name", "Aliases", "ArtifactSymbol", "ControlUri", "ArtifactDefinition", "IncompatibleWithSymbols", "ArtifactFiles", "Maps", });
    internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor =
      getDescriptor().getMessageTypes().get(1);
    internal_static_taxonomy_model_artifact_ArtifactSymbol_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactSymbol_descriptor,
        new java.lang.String[] { "VisualSymbol", "ToolingSymbol", });
    internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor =
      getDescriptor().getMessageTypes().get(2);
    internal_static_taxonomy_model_artifact_ArtifactDefinition_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactDefinition_descriptor,
        new java.lang.String[] { "BusinessDescription", "BusinessExample", "Analogies", "Comments", "Artifact", });
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor =
      getDescriptor().getMessageTypes().get(3);
    internal_static_taxonomy_model_artifact_ArtifactAnalogy_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactAnalogy_descriptor,
        new java.lang.String[] { "Name", "Description", "ArtifactDefinition", });
    internal_static_taxonomy_model_artifact_ArtifactFile_descriptor =
      getDescriptor().getMessageTypes().get(4);
    internal_static_taxonomy_model_artifact_ArtifactFile_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_ArtifactFile_descriptor,
        new java.lang.String[] { "Content", "FileName", "FileData", "Artifact", });
    internal_static_taxonomy_model_artifact_Maps_descriptor =
      getDescriptor().getMessageTypes().get(5);
    internal_static_taxonomy_model_artifact_Maps_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_Maps_descriptor,
        new java.lang.String[] { "CodeReferences", "ImplementationReferences", "Resources", "Artifact", });
    internal_static_taxonomy_model_artifact_MapReference_descriptor =
      getDescriptor().getMessageTypes().get(6);
    internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_MapReference_descriptor,
        new java.lang.String[] { "MappingType", "Name", "Platform", "ReferencePath", "Maps", });
    internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor =
      getDescriptor().getMessageTypes().get(7);
    internal_static_taxonomy_model_artifact_MapResourceEntry_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_MapResourceEntry_descriptor,
        new java.lang.String[] { "MappingType", "Name", "Description", "ResourcePath", "Maps", });
    internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor =
      getDescriptor().getMessageTypes().get(8);
    internal_static_taxonomy_model_artifact_NewArtifactRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_NewArtifactRequest_descriptor,
        new java.lang.String[] { "Type", "Name", });
    internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor =
      getDescriptor().getMessageTypes().get(9);
    internal_static_taxonomy_model_artifact_NewArtifactResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_NewArtifactResponse_descriptor,
        new java.lang.String[] { "Type", "ArtifactTypeObject", });
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor =
      getDescriptor().getMessageTypes().get(10);
    internal_static_taxonomy_model_artifact_UpdateArtifactRequest_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_UpdateArtifactRequest_descriptor,
        new java.lang.String[] { "Type", "ArtifactTypeObject", });
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor =
      getDescriptor().getMessageTypes().get(11);
    internal_static_taxonomy_model_artifact_UpdateArtifactResponse_fieldAccessorTable = new
      com.google.protobuf.GeneratedMessageV3.FieldAccessorTable(
        internal_static_taxonomy_model_artifact_UpdateArtifactResponse_descriptor,
        new java.lang.String[] { "Type", "ArtifactTypeObject", });
    com.google.protobuf.AnyProto.getDescriptor();
  }

  // @@protoc_insertion_point(outer_class_scope)
}
