// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: artifact.proto

package org.tti.tokens.model.artifact;

/**
 * Protobuf type {@code taxonomy.model.artifact.MapReference}
 */
public  final class MapReference extends
    com.google.protobuf.GeneratedMessageV3 implements
    // @@protoc_insertion_point(message_implements:taxonomy.model.artifact.MapReference)
    MapReferenceOrBuilder {
private static final long serialVersionUID = 0L;
  // Use MapReference.newBuilder() to construct.
  private MapReference(com.google.protobuf.GeneratedMessageV3.Builder<?> builder) {
    super(builder);
  }
  private MapReference() {
    mappingType_ = 0;
    name_ = "";
    platform_ = 0;
    referencePath_ = "";
  }

  @java.lang.Override
  public final com.google.protobuf.UnknownFieldSet
  getUnknownFields() {
    return this.unknownFields;
  }
  private MapReference(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    this();
    if (extensionRegistry == null) {
      throw new java.lang.NullPointerException();
    }
    int mutable_bitField0_ = 0;
    com.google.protobuf.UnknownFieldSet.Builder unknownFields =
        com.google.protobuf.UnknownFieldSet.newBuilder();
    try {
      boolean done = false;
      while (!done) {
        int tag = input.readTag();
        switch (tag) {
          case 0:
            done = true;
            break;
          case 8: {
            int rawValue = input.readEnum();

            mappingType_ = rawValue;
            break;
          }
          case 18: {
            java.lang.String s = input.readStringRequireUtf8();

            name_ = s;
            break;
          }
          case 24: {
            int rawValue = input.readEnum();

            platform_ = rawValue;
            break;
          }
          case 34: {
            java.lang.String s = input.readStringRequireUtf8();

            referencePath_ = s;
            break;
          }
          case 42: {
            org.tti.tokens.model.artifact.Maps.Builder subBuilder = null;
            if (maps_ != null) {
              subBuilder = maps_.toBuilder();
            }
            maps_ = input.readMessage(org.tti.tokens.model.artifact.Maps.parser(), extensionRegistry);
            if (subBuilder != null) {
              subBuilder.mergeFrom(maps_);
              maps_ = subBuilder.buildPartial();
            }

            break;
          }
          default: {
            if (!parseUnknownFieldProto3(
                input, unknownFields, extensionRegistry, tag)) {
              done = true;
            }
            break;
          }
        }
      }
    } catch (com.google.protobuf.InvalidProtocolBufferException e) {
      throw e.setUnfinishedMessage(this);
    } catch (java.io.IOException e) {
      throw new com.google.protobuf.InvalidProtocolBufferException(
          e).setUnfinishedMessage(this);
    } finally {
      this.unknownFields = unknownFields.build();
      makeExtensionsImmutable();
    }
  }
  public static final com.google.protobuf.Descriptors.Descriptor
      getDescriptor() {
    return org.tti.tokens.model.artifact.ArtifactOuterClass.internal_static_taxonomy_model_artifact_MapReference_descriptor;
  }

  @java.lang.Override
  protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
      internalGetFieldAccessorTable() {
    return org.tti.tokens.model.artifact.ArtifactOuterClass.internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable
        .ensureFieldAccessorsInitialized(
            org.tti.tokens.model.artifact.MapReference.class, org.tti.tokens.model.artifact.MapReference.Builder.class);
  }

  public static final int MAPPING_TYPE_FIELD_NUMBER = 1;
  private int mappingType_;
  /**
   * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
   */
  public int getMappingTypeValue() {
    return mappingType_;
  }
  /**
   * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
   */
  public org.tti.tokens.model.artifact.MappingType getMappingType() {
    @SuppressWarnings("deprecation")
    org.tti.tokens.model.artifact.MappingType result = org.tti.tokens.model.artifact.MappingType.valueOf(mappingType_);
    return result == null ? org.tti.tokens.model.artifact.MappingType.UNRECOGNIZED : result;
  }

  public static final int NAME_FIELD_NUMBER = 2;
  private volatile java.lang.Object name_;
  /**
   * <code>string name = 2;</code>
   */
  public java.lang.String getName() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      name_ = s;
      return s;
    }
  }
  /**
   * <code>string name = 2;</code>
   */
  public com.google.protobuf.ByteString
      getNameBytes() {
    java.lang.Object ref = name_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      name_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int PLATFORM_FIELD_NUMBER = 3;
  private int platform_;
  /**
   * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
   */
  public int getPlatformValue() {
    return platform_;
  }
  /**
   * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
   */
  public org.tti.tokens.model.artifact.TargetPlatform getPlatform() {
    @SuppressWarnings("deprecation")
    org.tti.tokens.model.artifact.TargetPlatform result = org.tti.tokens.model.artifact.TargetPlatform.valueOf(platform_);
    return result == null ? org.tti.tokens.model.artifact.TargetPlatform.UNRECOGNIZED : result;
  }

  public static final int REFERENCE_PATH_FIELD_NUMBER = 4;
  private volatile java.lang.Object referencePath_;
  /**
   * <code>string reference_path = 4;</code>
   */
  public java.lang.String getReferencePath() {
    java.lang.Object ref = referencePath_;
    if (ref instanceof java.lang.String) {
      return (java.lang.String) ref;
    } else {
      com.google.protobuf.ByteString bs = 
          (com.google.protobuf.ByteString) ref;
      java.lang.String s = bs.toStringUtf8();
      referencePath_ = s;
      return s;
    }
  }
  /**
   * <code>string reference_path = 4;</code>
   */
  public com.google.protobuf.ByteString
      getReferencePathBytes() {
    java.lang.Object ref = referencePath_;
    if (ref instanceof java.lang.String) {
      com.google.protobuf.ByteString b = 
          com.google.protobuf.ByteString.copyFromUtf8(
              (java.lang.String) ref);
      referencePath_ = b;
      return b;
    } else {
      return (com.google.protobuf.ByteString) ref;
    }
  }

  public static final int MAPS_FIELD_NUMBER = 5;
  private org.tti.tokens.model.artifact.Maps maps_;
  /**
   * <pre>
   *navigation to parent
   * </pre>
   *
   * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
   */
  public boolean hasMaps() {
    return maps_ != null;
  }
  /**
   * <pre>
   *navigation to parent
   * </pre>
   *
   * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
   */
  public org.tti.tokens.model.artifact.Maps getMaps() {
    return maps_ == null ? org.tti.tokens.model.artifact.Maps.getDefaultInstance() : maps_;
  }
  /**
   * <pre>
   *navigation to parent
   * </pre>
   *
   * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
   */
  public org.tti.tokens.model.artifact.MapsOrBuilder getMapsOrBuilder() {
    return getMaps();
  }

  private byte memoizedIsInitialized = -1;
  @java.lang.Override
  public final boolean isInitialized() {
    byte isInitialized = memoizedIsInitialized;
    if (isInitialized == 1) return true;
    if (isInitialized == 0) return false;

    memoizedIsInitialized = 1;
    return true;
  }

  @java.lang.Override
  public void writeTo(com.google.protobuf.CodedOutputStream output)
                      throws java.io.IOException {
    if (mappingType_ != org.tti.tokens.model.artifact.MappingType.SOURCE_CODE.getNumber()) {
      output.writeEnum(1, mappingType_);
    }
    if (!getNameBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 2, name_);
    }
    if (platform_ != org.tti.tokens.model.artifact.TargetPlatform.ETHEREUM_SOLIDITY.getNumber()) {
      output.writeEnum(3, platform_);
    }
    if (!getReferencePathBytes().isEmpty()) {
      com.google.protobuf.GeneratedMessageV3.writeString(output, 4, referencePath_);
    }
    if (maps_ != null) {
      output.writeMessage(5, getMaps());
    }
    unknownFields.writeTo(output);
  }

  @java.lang.Override
  public int getSerializedSize() {
    int size = memoizedSize;
    if (size != -1) return size;

    size = 0;
    if (mappingType_ != org.tti.tokens.model.artifact.MappingType.SOURCE_CODE.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(1, mappingType_);
    }
    if (!getNameBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(2, name_);
    }
    if (platform_ != org.tti.tokens.model.artifact.TargetPlatform.ETHEREUM_SOLIDITY.getNumber()) {
      size += com.google.protobuf.CodedOutputStream
        .computeEnumSize(3, platform_);
    }
    if (!getReferencePathBytes().isEmpty()) {
      size += com.google.protobuf.GeneratedMessageV3.computeStringSize(4, referencePath_);
    }
    if (maps_ != null) {
      size += com.google.protobuf.CodedOutputStream
        .computeMessageSize(5, getMaps());
    }
    size += unknownFields.getSerializedSize();
    memoizedSize = size;
    return size;
  }

  @java.lang.Override
  public boolean equals(final java.lang.Object obj) {
    if (obj == this) {
     return true;
    }
    if (!(obj instanceof org.tti.tokens.model.artifact.MapReference)) {
      return super.equals(obj);
    }
    org.tti.tokens.model.artifact.MapReference other = (org.tti.tokens.model.artifact.MapReference) obj;

    boolean result = true;
    result = result && mappingType_ == other.mappingType_;
    result = result && getName()
        .equals(other.getName());
    result = result && platform_ == other.platform_;
    result = result && getReferencePath()
        .equals(other.getReferencePath());
    result = result && (hasMaps() == other.hasMaps());
    if (hasMaps()) {
      result = result && getMaps()
          .equals(other.getMaps());
    }
    result = result && unknownFields.equals(other.unknownFields);
    return result;
  }

  @java.lang.Override
  public int hashCode() {
    if (memoizedHashCode != 0) {
      return memoizedHashCode;
    }
    int hash = 41;
    hash = (19 * hash) + getDescriptor().hashCode();
    hash = (37 * hash) + MAPPING_TYPE_FIELD_NUMBER;
    hash = (53 * hash) + mappingType_;
    hash = (37 * hash) + NAME_FIELD_NUMBER;
    hash = (53 * hash) + getName().hashCode();
    hash = (37 * hash) + PLATFORM_FIELD_NUMBER;
    hash = (53 * hash) + platform_;
    hash = (37 * hash) + REFERENCE_PATH_FIELD_NUMBER;
    hash = (53 * hash) + getReferencePath().hashCode();
    if (hasMaps()) {
      hash = (37 * hash) + MAPS_FIELD_NUMBER;
      hash = (53 * hash) + getMaps().hashCode();
    }
    hash = (29 * hash) + unknownFields.hashCode();
    memoizedHashCode = hash;
    return hash;
  }

  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      java.nio.ByteBuffer data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      java.nio.ByteBuffer data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      com.google.protobuf.ByteString data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      com.google.protobuf.ByteString data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(byte[] data)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      byte[] data,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws com.google.protobuf.InvalidProtocolBufferException {
    return PARSER.parseFrom(data, extensionRegistry);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }
  public static org.tti.tokens.model.artifact.MapReference parseDelimitedFrom(java.io.InputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input);
  }
  public static org.tti.tokens.model.artifact.MapReference parseDelimitedFrom(
      java.io.InputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseDelimitedWithIOException(PARSER, input, extensionRegistry);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      com.google.protobuf.CodedInputStream input)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input);
  }
  public static org.tti.tokens.model.artifact.MapReference parseFrom(
      com.google.protobuf.CodedInputStream input,
      com.google.protobuf.ExtensionRegistryLite extensionRegistry)
      throws java.io.IOException {
    return com.google.protobuf.GeneratedMessageV3
        .parseWithIOException(PARSER, input, extensionRegistry);
  }

  @java.lang.Override
  public Builder newBuilderForType() { return newBuilder(); }
  public static Builder newBuilder() {
    return DEFAULT_INSTANCE.toBuilder();
  }
  public static Builder newBuilder(org.tti.tokens.model.artifact.MapReference prototype) {
    return DEFAULT_INSTANCE.toBuilder().mergeFrom(prototype);
  }
  @java.lang.Override
  public Builder toBuilder() {
    return this == DEFAULT_INSTANCE
        ? new Builder() : new Builder().mergeFrom(this);
  }

  @java.lang.Override
  protected Builder newBuilderForType(
      com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
    Builder builder = new Builder(parent);
    return builder;
  }
  /**
   * Protobuf type {@code taxonomy.model.artifact.MapReference}
   */
  public static final class Builder extends
      com.google.protobuf.GeneratedMessageV3.Builder<Builder> implements
      // @@protoc_insertion_point(builder_implements:taxonomy.model.artifact.MapReference)
      org.tti.tokens.model.artifact.MapReferenceOrBuilder {
    public static final com.google.protobuf.Descriptors.Descriptor
        getDescriptor() {
      return org.tti.tokens.model.artifact.ArtifactOuterClass.internal_static_taxonomy_model_artifact_MapReference_descriptor;
    }

    @java.lang.Override
    protected com.google.protobuf.GeneratedMessageV3.FieldAccessorTable
        internalGetFieldAccessorTable() {
      return org.tti.tokens.model.artifact.ArtifactOuterClass.internal_static_taxonomy_model_artifact_MapReference_fieldAccessorTable
          .ensureFieldAccessorsInitialized(
              org.tti.tokens.model.artifact.MapReference.class, org.tti.tokens.model.artifact.MapReference.Builder.class);
    }

    // Construct using org.tti.tokens.model.artifact.MapReference.newBuilder()
    private Builder() {
      maybeForceBuilderInitialization();
    }

    private Builder(
        com.google.protobuf.GeneratedMessageV3.BuilderParent parent) {
      super(parent);
      maybeForceBuilderInitialization();
    }
    private void maybeForceBuilderInitialization() {
      if (com.google.protobuf.GeneratedMessageV3
              .alwaysUseFieldBuilders) {
      }
    }
    @java.lang.Override
    public Builder clear() {
      super.clear();
      mappingType_ = 0;

      name_ = "";

      platform_ = 0;

      referencePath_ = "";

      if (mapsBuilder_ == null) {
        maps_ = null;
      } else {
        maps_ = null;
        mapsBuilder_ = null;
      }
      return this;
    }

    @java.lang.Override
    public com.google.protobuf.Descriptors.Descriptor
        getDescriptorForType() {
      return org.tti.tokens.model.artifact.ArtifactOuterClass.internal_static_taxonomy_model_artifact_MapReference_descriptor;
    }

    @java.lang.Override
    public org.tti.tokens.model.artifact.MapReference getDefaultInstanceForType() {
      return org.tti.tokens.model.artifact.MapReference.getDefaultInstance();
    }

    @java.lang.Override
    public org.tti.tokens.model.artifact.MapReference build() {
      org.tti.tokens.model.artifact.MapReference result = buildPartial();
      if (!result.isInitialized()) {
        throw newUninitializedMessageException(result);
      }
      return result;
    }

    @java.lang.Override
    public org.tti.tokens.model.artifact.MapReference buildPartial() {
      org.tti.tokens.model.artifact.MapReference result = new org.tti.tokens.model.artifact.MapReference(this);
      result.mappingType_ = mappingType_;
      result.name_ = name_;
      result.platform_ = platform_;
      result.referencePath_ = referencePath_;
      if (mapsBuilder_ == null) {
        result.maps_ = maps_;
      } else {
        result.maps_ = mapsBuilder_.build();
      }
      onBuilt();
      return result;
    }

    @java.lang.Override
    public Builder clone() {
      return (Builder) super.clone();
    }
    @java.lang.Override
    public Builder setField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return (Builder) super.setField(field, value);
    }
    @java.lang.Override
    public Builder clearField(
        com.google.protobuf.Descriptors.FieldDescriptor field) {
      return (Builder) super.clearField(field);
    }
    @java.lang.Override
    public Builder clearOneof(
        com.google.protobuf.Descriptors.OneofDescriptor oneof) {
      return (Builder) super.clearOneof(oneof);
    }
    @java.lang.Override
    public Builder setRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        int index, java.lang.Object value) {
      return (Builder) super.setRepeatedField(field, index, value);
    }
    @java.lang.Override
    public Builder addRepeatedField(
        com.google.protobuf.Descriptors.FieldDescriptor field,
        java.lang.Object value) {
      return (Builder) super.addRepeatedField(field, value);
    }
    @java.lang.Override
    public Builder mergeFrom(com.google.protobuf.Message other) {
      if (other instanceof org.tti.tokens.model.artifact.MapReference) {
        return mergeFrom((org.tti.tokens.model.artifact.MapReference)other);
      } else {
        super.mergeFrom(other);
        return this;
      }
    }

    public Builder mergeFrom(org.tti.tokens.model.artifact.MapReference other) {
      if (other == org.tti.tokens.model.artifact.MapReference.getDefaultInstance()) return this;
      if (other.mappingType_ != 0) {
        setMappingTypeValue(other.getMappingTypeValue());
      }
      if (!other.getName().isEmpty()) {
        name_ = other.name_;
        onChanged();
      }
      if (other.platform_ != 0) {
        setPlatformValue(other.getPlatformValue());
      }
      if (!other.getReferencePath().isEmpty()) {
        referencePath_ = other.referencePath_;
        onChanged();
      }
      if (other.hasMaps()) {
        mergeMaps(other.getMaps());
      }
      this.mergeUnknownFields(other.unknownFields);
      onChanged();
      return this;
    }

    @java.lang.Override
    public final boolean isInitialized() {
      return true;
    }

    @java.lang.Override
    public Builder mergeFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws java.io.IOException {
      org.tti.tokens.model.artifact.MapReference parsedMessage = null;
      try {
        parsedMessage = PARSER.parsePartialFrom(input, extensionRegistry);
      } catch (com.google.protobuf.InvalidProtocolBufferException e) {
        parsedMessage = (org.tti.tokens.model.artifact.MapReference) e.getUnfinishedMessage();
        throw e.unwrapIOException();
      } finally {
        if (parsedMessage != null) {
          mergeFrom(parsedMessage);
        }
      }
      return this;
    }

    private int mappingType_ = 0;
    /**
     * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
     */
    public int getMappingTypeValue() {
      return mappingType_;
    }
    /**
     * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
     */
    public Builder setMappingTypeValue(int value) {
      mappingType_ = value;
      onChanged();
      return this;
    }
    /**
     * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
     */
    public org.tti.tokens.model.artifact.MappingType getMappingType() {
      @SuppressWarnings("deprecation")
      org.tti.tokens.model.artifact.MappingType result = org.tti.tokens.model.artifact.MappingType.valueOf(mappingType_);
      return result == null ? org.tti.tokens.model.artifact.MappingType.UNRECOGNIZED : result;
    }
    /**
     * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
     */
    public Builder setMappingType(org.tti.tokens.model.artifact.MappingType value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      mappingType_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <code>.taxonomy.model.artifact.MappingType mapping_type = 1;</code>
     */
    public Builder clearMappingType() {
      
      mappingType_ = 0;
      onChanged();
      return this;
    }

    private java.lang.Object name_ = "";
    /**
     * <code>string name = 2;</code>
     */
    public java.lang.String getName() {
      java.lang.Object ref = name_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        name_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <code>string name = 2;</code>
     */
    public com.google.protobuf.ByteString
        getNameBytes() {
      java.lang.Object ref = name_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        name_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <code>string name = 2;</code>
     */
    public Builder setName(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      name_ = value;
      onChanged();
      return this;
    }
    /**
     * <code>string name = 2;</code>
     */
    public Builder clearName() {
      
      name_ = getDefaultInstance().getName();
      onChanged();
      return this;
    }
    /**
     * <code>string name = 2;</code>
     */
    public Builder setNameBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      name_ = value;
      onChanged();
      return this;
    }

    private int platform_ = 0;
    /**
     * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
     */
    public int getPlatformValue() {
      return platform_;
    }
    /**
     * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
     */
    public Builder setPlatformValue(int value) {
      platform_ = value;
      onChanged();
      return this;
    }
    /**
     * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
     */
    public org.tti.tokens.model.artifact.TargetPlatform getPlatform() {
      @SuppressWarnings("deprecation")
      org.tti.tokens.model.artifact.TargetPlatform result = org.tti.tokens.model.artifact.TargetPlatform.valueOf(platform_);
      return result == null ? org.tti.tokens.model.artifact.TargetPlatform.UNRECOGNIZED : result;
    }
    /**
     * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
     */
    public Builder setPlatform(org.tti.tokens.model.artifact.TargetPlatform value) {
      if (value == null) {
        throw new NullPointerException();
      }
      
      platform_ = value.getNumber();
      onChanged();
      return this;
    }
    /**
     * <code>.taxonomy.model.artifact.TargetPlatform platform = 3;</code>
     */
    public Builder clearPlatform() {
      
      platform_ = 0;
      onChanged();
      return this;
    }

    private java.lang.Object referencePath_ = "";
    /**
     * <code>string reference_path = 4;</code>
     */
    public java.lang.String getReferencePath() {
      java.lang.Object ref = referencePath_;
      if (!(ref instanceof java.lang.String)) {
        com.google.protobuf.ByteString bs =
            (com.google.protobuf.ByteString) ref;
        java.lang.String s = bs.toStringUtf8();
        referencePath_ = s;
        return s;
      } else {
        return (java.lang.String) ref;
      }
    }
    /**
     * <code>string reference_path = 4;</code>
     */
    public com.google.protobuf.ByteString
        getReferencePathBytes() {
      java.lang.Object ref = referencePath_;
      if (ref instanceof String) {
        com.google.protobuf.ByteString b = 
            com.google.protobuf.ByteString.copyFromUtf8(
                (java.lang.String) ref);
        referencePath_ = b;
        return b;
      } else {
        return (com.google.protobuf.ByteString) ref;
      }
    }
    /**
     * <code>string reference_path = 4;</code>
     */
    public Builder setReferencePath(
        java.lang.String value) {
      if (value == null) {
    throw new NullPointerException();
  }
  
      referencePath_ = value;
      onChanged();
      return this;
    }
    /**
     * <code>string reference_path = 4;</code>
     */
    public Builder clearReferencePath() {
      
      referencePath_ = getDefaultInstance().getReferencePath();
      onChanged();
      return this;
    }
    /**
     * <code>string reference_path = 4;</code>
     */
    public Builder setReferencePathBytes(
        com.google.protobuf.ByteString value) {
      if (value == null) {
    throw new NullPointerException();
  }
  checkByteStringIsUtf8(value);
      
      referencePath_ = value;
      onChanged();
      return this;
    }

    private org.tti.tokens.model.artifact.Maps maps_ = null;
    private com.google.protobuf.SingleFieldBuilderV3<
        org.tti.tokens.model.artifact.Maps, org.tti.tokens.model.artifact.Maps.Builder, org.tti.tokens.model.artifact.MapsOrBuilder> mapsBuilder_;
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public boolean hasMaps() {
      return mapsBuilder_ != null || maps_ != null;
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public org.tti.tokens.model.artifact.Maps getMaps() {
      if (mapsBuilder_ == null) {
        return maps_ == null ? org.tti.tokens.model.artifact.Maps.getDefaultInstance() : maps_;
      } else {
        return mapsBuilder_.getMessage();
      }
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public Builder setMaps(org.tti.tokens.model.artifact.Maps value) {
      if (mapsBuilder_ == null) {
        if (value == null) {
          throw new NullPointerException();
        }
        maps_ = value;
        onChanged();
      } else {
        mapsBuilder_.setMessage(value);
      }

      return this;
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public Builder setMaps(
        org.tti.tokens.model.artifact.Maps.Builder builderForValue) {
      if (mapsBuilder_ == null) {
        maps_ = builderForValue.build();
        onChanged();
      } else {
        mapsBuilder_.setMessage(builderForValue.build());
      }

      return this;
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public Builder mergeMaps(org.tti.tokens.model.artifact.Maps value) {
      if (mapsBuilder_ == null) {
        if (maps_ != null) {
          maps_ =
            org.tti.tokens.model.artifact.Maps.newBuilder(maps_).mergeFrom(value).buildPartial();
        } else {
          maps_ = value;
        }
        onChanged();
      } else {
        mapsBuilder_.mergeFrom(value);
      }

      return this;
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public Builder clearMaps() {
      if (mapsBuilder_ == null) {
        maps_ = null;
        onChanged();
      } else {
        maps_ = null;
        mapsBuilder_ = null;
      }

      return this;
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public org.tti.tokens.model.artifact.Maps.Builder getMapsBuilder() {
      
      onChanged();
      return getMapsFieldBuilder().getBuilder();
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    public org.tti.tokens.model.artifact.MapsOrBuilder getMapsOrBuilder() {
      if (mapsBuilder_ != null) {
        return mapsBuilder_.getMessageOrBuilder();
      } else {
        return maps_ == null ?
            org.tti.tokens.model.artifact.Maps.getDefaultInstance() : maps_;
      }
    }
    /**
     * <pre>
     *navigation to parent
     * </pre>
     *
     * <code>.taxonomy.model.artifact.Maps maps = 5;</code>
     */
    private com.google.protobuf.SingleFieldBuilderV3<
        org.tti.tokens.model.artifact.Maps, org.tti.tokens.model.artifact.Maps.Builder, org.tti.tokens.model.artifact.MapsOrBuilder> 
        getMapsFieldBuilder() {
      if (mapsBuilder_ == null) {
        mapsBuilder_ = new com.google.protobuf.SingleFieldBuilderV3<
            org.tti.tokens.model.artifact.Maps, org.tti.tokens.model.artifact.Maps.Builder, org.tti.tokens.model.artifact.MapsOrBuilder>(
                getMaps(),
                getParentForChildren(),
                isClean());
        maps_ = null;
      }
      return mapsBuilder_;
    }
    @java.lang.Override
    public final Builder setUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.setUnknownFieldsProto3(unknownFields);
    }

    @java.lang.Override
    public final Builder mergeUnknownFields(
        final com.google.protobuf.UnknownFieldSet unknownFields) {
      return super.mergeUnknownFields(unknownFields);
    }


    // @@protoc_insertion_point(builder_scope:taxonomy.model.artifact.MapReference)
  }

  // @@protoc_insertion_point(class_scope:taxonomy.model.artifact.MapReference)
  private static final org.tti.tokens.model.artifact.MapReference DEFAULT_INSTANCE;
  static {
    DEFAULT_INSTANCE = new org.tti.tokens.model.artifact.MapReference();
  }

  public static org.tti.tokens.model.artifact.MapReference getDefaultInstance() {
    return DEFAULT_INSTANCE;
  }

  private static final com.google.protobuf.Parser<MapReference>
      PARSER = new com.google.protobuf.AbstractParser<MapReference>() {
    @java.lang.Override
    public MapReference parsePartialFrom(
        com.google.protobuf.CodedInputStream input,
        com.google.protobuf.ExtensionRegistryLite extensionRegistry)
        throws com.google.protobuf.InvalidProtocolBufferException {
      return new MapReference(input, extensionRegistry);
    }
  };

  public static com.google.protobuf.Parser<MapReference> parser() {
    return PARSER;
  }

  @java.lang.Override
  public com.google.protobuf.Parser<MapReference> getParserForType() {
    return PARSER;
  }

  @java.lang.Override
  public org.tti.tokens.model.artifact.MapReference getDefaultInstanceForType() {
    return DEFAULT_INSTANCE;
  }

}

