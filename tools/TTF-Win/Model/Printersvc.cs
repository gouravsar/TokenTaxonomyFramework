// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: printersvc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TTI.TTF.Taxonomy {

  /// <summary>Holder for reflection information generated from printersvc.proto</summary>
  public static partial class PrintersvcReflection {

    #region Descriptor
    /// <summary>File descriptor for printersvc.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PrintersvcReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChBwcmludGVyc3ZjLnByb3RvEhN0YXhvbm9teS50dGZwcmludGVyGg5hcnRp",
            "ZmFjdC5wcm90byJhCg9BcnRpZmFjdFRvUHJpbnQSMwoEdHlwZRgBIAEoDjIl",
            "LnRheG9ub215Lm1vZGVsLmFydGlmYWN0LkFydGlmYWN0VHlwZRIKCgJpZBgC",
            "IAEoCRINCgVkcmFmdBgDIAEoCCIuCg9QcmludFRURk9wdGlvbnMSDAoEYm9v",
            "axgBIAEoCBINCgVkcmFmdBgCIAEoCCIoCgtQcmludFJlc3VsdBIZChFvcGVu",
            "X3htbF9kb2N1bWVudBgBIAEoCTLEAQoOUHJpbnRlclNlcnZpY2USXAoQUHJp",
            "bnRUVEZBcnRpZmFjdBIkLnRheG9ub215LnR0ZnByaW50ZXIuQXJ0aWZhY3RU",
            "b1ByaW50GiAudGF4b25vbXkudHRmcHJpbnRlci5QcmludFJlc3VsdCIAElQK",
            "CFByaW50VFRGEiQudGF4b25vbXkudHRmcHJpbnRlci5QcmludFRURk9wdGlv",
            "bnMaIC50YXhvbm9teS50dGZwcmludGVyLlByaW50UmVzdWx0IgBCKwoUb3Jn",
            "LnR0aS50dGYudGF4b25vbXlQAaoCEFRUSS5UVEYuVGF4b25vbXliBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.ArtifactToPrint), global::TTI.TTF.Taxonomy.ArtifactToPrint.Parser, new[]{ "Type", "Id", "Draft" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.PrintTTFOptions), global::TTI.TTF.Taxonomy.PrintTTFOptions.Parser, new[]{ "Book", "Draft" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TTI.TTF.Taxonomy.PrintResult), global::TTI.TTF.Taxonomy.PrintResult.Parser, new[]{ "OpenXmlDocument" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ArtifactToPrint : pb::IMessage<ArtifactToPrint> {
    private static readonly pb::MessageParser<ArtifactToPrint> _parser = new pb::MessageParser<ArtifactToPrint>(() => new ArtifactToPrint());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ArtifactToPrint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.PrintersvcReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArtifactToPrint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArtifactToPrint(ArtifactToPrint other) : this() {
      type_ = other.type_;
      id_ = other.id_;
      draft_ = other.draft_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ArtifactToPrint Clone() {
      return new ArtifactToPrint(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType type_ = global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType.Base;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "draft" field.</summary>
    public const int DraftFieldNumber = 3;
    private bool draft_;
    /// <summary>
    ///should it include the Draft watermark?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Draft {
      get { return draft_; }
      set {
        draft_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ArtifactToPrint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ArtifactToPrint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Id != other.Id) return false;
      if (Draft != other.Draft) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType.Base) hash ^= Type.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Draft != false) hash ^= Draft.GetHashCode();
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
      if (Type != global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType.Base) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
      if (Draft != false) {
        output.WriteRawTag(24);
        output.WriteBool(Draft);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Type != global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType.Base) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Draft != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ArtifactToPrint other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType.Base) {
        Type = other.Type;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Draft != false) {
        Draft = other.Draft;
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
          case 8: {
            Type = (global::TTI.TTF.Taxonomy.Model.Artifact.ArtifactType) input.ReadEnum();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
          case 24: {
            Draft = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///If Book, the all artifacts will print to a single file or book.  If not, each artifact will print into their respective folder.
  /// </summary>
  public sealed partial class PrintTTFOptions : pb::IMessage<PrintTTFOptions> {
    private static readonly pb::MessageParser<PrintTTFOptions> _parser = new pb::MessageParser<PrintTTFOptions>(() => new PrintTTFOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrintTTFOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.PrintersvcReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintTTFOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintTTFOptions(PrintTTFOptions other) : this() {
      book_ = other.book_;
      draft_ = other.draft_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintTTFOptions Clone() {
      return new PrintTTFOptions(this);
    }

    /// <summary>Field number for the "book" field.</summary>
    public const int BookFieldNumber = 1;
    private bool book_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Book {
      get { return book_; }
      set {
        book_ = value;
      }
    }

    /// <summary>Field number for the "draft" field.</summary>
    public const int DraftFieldNumber = 2;
    private bool draft_;
    /// <summary>
    ///should it include the Draft watermark?
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Draft {
      get { return draft_; }
      set {
        draft_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrintTTFOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrintTTFOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Book != other.Book) return false;
      if (Draft != other.Draft) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Book != false) hash ^= Book.GetHashCode();
      if (Draft != false) hash ^= Draft.GetHashCode();
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
      if (Book != false) {
        output.WriteRawTag(8);
        output.WriteBool(Book);
      }
      if (Draft != false) {
        output.WriteRawTag(16);
        output.WriteBool(Draft);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Book != false) {
        size += 1 + 1;
      }
      if (Draft != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrintTTFOptions other) {
      if (other == null) {
        return;
      }
      if (other.Book != false) {
        Book = other.Book;
      }
      if (other.Draft != false) {
        Draft = other.Draft;
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
          case 8: {
            Book = input.ReadBool();
            break;
          }
          case 16: {
            Draft = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PrintResult : pb::IMessage<PrintResult> {
    private static readonly pb::MessageParser<PrintResult> _parser = new pb::MessageParser<PrintResult>(() => new PrintResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PrintResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TTI.TTF.Taxonomy.PrintersvcReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintResult(PrintResult other) : this() {
      openXmlDocument_ = other.openXmlDocument_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PrintResult Clone() {
      return new PrintResult(this);
    }

    /// <summary>Field number for the "open_xml_document" field.</summary>
    public const int OpenXmlDocumentFieldNumber = 1;
    private string openXmlDocument_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string OpenXmlDocument {
      get { return openXmlDocument_; }
      set {
        openXmlDocument_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PrintResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PrintResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpenXmlDocument != other.OpenXmlDocument) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpenXmlDocument.Length != 0) hash ^= OpenXmlDocument.GetHashCode();
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
      if (OpenXmlDocument.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(OpenXmlDocument);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpenXmlDocument.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OpenXmlDocument);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PrintResult other) {
      if (other == null) {
        return;
      }
      if (other.OpenXmlDocument.Length != 0) {
        OpenXmlDocument = other.OpenXmlDocument;
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
            OpenXmlDocument = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code