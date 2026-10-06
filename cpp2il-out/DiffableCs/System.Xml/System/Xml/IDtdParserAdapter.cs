namespace System.Xml;

internal interface IDtdParserAdapter
{

	public Uri BaseUri
	{
		 get { } //Length: 0
	}

	public int CurrentPosition
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int EntityStackLength
	{
		 get { } //Length: 0
	}

	public bool IsEntityEolNormalized
	{
		 get { } //Length: 0
	}

	public bool IsEof
	{
		 get { } //Length: 0
	}

	public int LineNo
	{
		 get { } //Length: 0
	}

	public int LineStartPosition
	{
		 get { } //Length: 0
	}

	public IXmlNamespaceResolver NamespaceResolver
	{
		 get { } //Length: 0
	}

	public XmlNameTable NameTable
	{
		 get { } //Length: 0
	}

	public Char[] ParsingBuffer
	{
		 get { } //Length: 0
	}

	public int ParsingBufferLength
	{
		 get { } //Length: 0
	}

	public Uri get_BaseUri() { }

	public int get_CurrentPosition() { }

	public int get_EntityStackLength() { }

	public bool get_IsEntityEolNormalized() { }

	public bool get_IsEof() { }

	public int get_LineNo() { }

	public int get_LineStartPosition() { }

	public IXmlNamespaceResolver get_NamespaceResolver() { }

	public XmlNameTable get_NameTable() { }

	public Char[] get_ParsingBuffer() { }

	public int get_ParsingBufferLength() { }

	public void OnNewLine(int pos) { }

	public void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	public void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	public void ParseComment(StringBuilder sb) { }

	public int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	public int ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	public void ParsePI(StringBuilder sb) { }

	public bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	public bool PushEntity(IDtdEntityInfo entity, out int entityId) { }

	public bool PushExternalSubset(string systemId, string publicId) { }

	public void PushInternalDtd(string baseUri, string internalDtd) { }

	public int ReadData() { }

	public void set_CurrentPosition(int value) { }

	public void Throw(Exception e) { }

}

