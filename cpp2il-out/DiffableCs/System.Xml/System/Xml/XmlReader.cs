namespace System.Xml;

[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlReader : IDisposable
{
	private static uint IsTextualNodeBitmap; //Field offset: 0x0
	private static uint CanReadContentAsBitmap; //Field offset: 0x4
	private static uint HasValueBitmap; //Field offset: 0x8

	public abstract int AttributeCount
	{
		 get { } //Length: 0
	}

	public abstract string BaseURI
	{
		 get { } //Length: 0
	}

	public override bool CanReadValueChunk
	{
		 get { } //Length: 3
	}

	public override bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	public abstract int Depth
	{
		 get { } //Length: 0
	}

	internal override IDtdInfo DtdInfo
	{
		internal get { } //Length: 3
	}

	public abstract bool EOF
	{
		 get { } //Length: 0
	}

	public override bool HasAttributes
	{
		 get { } //Length: 33
	}

	public override bool IsDefault
	{
		 get { } //Length: 3
	}

	internal bool IsDefaultInternal
	{
		internal get { } //Length: 130
	}

	public abstract bool IsEmptyElement
	{
		 get { } //Length: 0
	}

	public abstract string LocalName
	{
		 get { } //Length: 0
	}

	public override string Name
	{
		 get { } //Length: 261
	}

	internal override XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 3
	}

	public abstract string NamespaceURI
	{
		 get { } //Length: 0
	}

	public abstract XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public abstract XmlNodeType NodeType
	{
		 get { } //Length: 0
	}

	public abstract string Prefix
	{
		 get { } //Length: 0
	}

	public override char QuoteChar
	{
		 get { } //Length: 6
	}

	public abstract ReadState ReadState
	{
		 get { } //Length: 0
	}

	public override IXmlSchemaInfo SchemaInfo
	{
		 get { } //Length: 57
	}

	public override XmlReaderSettings Settings
	{
		 get { } //Length: 3
	}

	public abstract string Value
	{
		 get { } //Length: 0
	}

	public override Type ValueType
	{
		 get { } //Length: 89
	}

	public override string XmlLang
	{
		 get { } //Length: 54
	}

	public override XmlSpace XmlSpace
	{
		 get { } //Length: 3
	}

	private static XmlReader() { }

	protected XmlReader() { }

	internal static int CalcBufferSize(Stream input) { }

	public override void Close() { }

	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract int get_AttributeCount() { }

	public abstract string get_BaseURI() { }

	public override bool get_CanReadValueChunk() { }

	public override bool get_CanResolveEntity() { }

	public abstract int get_Depth() { }

	internal override IDtdInfo get_DtdInfo() { }

	public abstract bool get_EOF() { }

	public override bool get_HasAttributes() { }

	public override bool get_IsDefault() { }

	internal bool get_IsDefaultInternal() { }

	public abstract bool get_IsEmptyElement() { }

	public abstract string get_LocalName() { }

	public override string get_Name() { }

	internal override XmlNamespaceManager get_NamespaceManager() { }

	public abstract string get_NamespaceURI() { }

	public abstract XmlNameTable get_NameTable() { }

	public abstract XmlNodeType get_NodeType() { }

	public abstract string get_Prefix() { }

	public override char get_QuoteChar() { }

	public abstract ReadState get_ReadState() { }

	public override IXmlSchemaInfo get_SchemaInfo() { }

	public override XmlReaderSettings get_Settings() { }

	public abstract string get_Value() { }

	public override Type get_ValueType() { }

	public override string get_XmlLang() { }

	public override XmlSpace get_XmlSpace() { }

	public abstract string GetAttribute(int i) { }

	public abstract string GetAttribute(string name, string namespaceURI) { }

	public abstract string GetAttribute(string name) { }

	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	public override bool IsStartElement(string localname, string ns) { }

	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	public abstract string LookupNamespace(string prefix) { }

	public abstract bool MoveToAttribute(string name) { }

	public override void MoveToAttribute(int i) { }

	public override XmlNodeType MoveToContent() { }

	public abstract bool MoveToElement() { }

	public abstract bool MoveToFirstAttribute() { }

	public abstract bool MoveToNextAttribute() { }

	public abstract bool Read() { }

	public abstract bool ReadAttributeValue() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadElementString() { }

	public override void ReadEndElement() { }

	public override string ReadInnerXml() { }

	public override void ReadStartElement() { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	public override string ReadString() { }

	public override int ReadValueChunk(Char[] buffer, int index, int count) { }

	public abstract void ResolveEntity() { }

	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	public override void Skip() { }

	private bool SkipSubtree() { }

	private void WriteAttributeValue(XmlWriter xtw) { }

	private void WriteNode(XmlWriter xtw, bool defattr) { }

}

