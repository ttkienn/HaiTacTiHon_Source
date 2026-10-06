namespace MS.Internal.Xml.Cache;

internal struct XPathNode
{
	private XPathNodeInfoAtom _info; //Field offset: 0x0
	private ushort _idxSibling; //Field offset: 0x8
	private ushort _idxParent; //Field offset: 0xA
	private ushort _idxSimilar; //Field offset: 0xC
	private ushort _posOffset; //Field offset: 0xE
	private uint _props; //Field offset: 0x10
	private string _value; //Field offset: 0x18

	public int CollapsedLinePosition
	{
		 get { } //Length: 35
	}

	public XPathDocument Document
	{
		 get { } //Length: 26
	}

	public bool HasCollapsedText
	{
		 get { } //Length: 11
	}

	public bool HasNamespaceDecls
	{
		 get { } //Length: 11
	}

	public bool HasSibling
	{
		 get { } //Length: 9
	}

	public bool IsText
	{
		 get { } //Length: 78
	}

	public bool IsXmlNamespaceNode
	{
		 get { } //Length: 103
	}

	public int LineNumber
	{
		 get { } //Length: 36
	}

	public int LinePosition
	{
		 get { } //Length: 29
	}

	public string LocalName
	{
		 get { } //Length: 26
	}

	public string NamespaceUri
	{
		 get { } //Length: 26
	}

	public XPathNodeType NodeType
	{
		 get { } //Length: 7
	}

	public XPathNodePageInfo PageInfo
	{
		 get { } //Length: 26
	}

	public string Prefix
	{
		 get { } //Length: 26
	}

	public string Value
	{
		 get { } //Length: 5
	}

	public int get_CollapsedLinePosition() { }

	public XPathDocument get_Document() { }

	public bool get_HasCollapsedText() { }

	public bool get_HasNamespaceDecls() { }

	public bool get_HasSibling() { }

	public bool get_IsText() { }

	public bool get_IsXmlNamespaceNode() { }

	public int get_LineNumber() { }

	public int get_LinePosition() { }

	public string get_LocalName() { }

	public string get_NamespaceUri() { }

	public XPathNodeType get_NodeType() { }

	public XPathNodePageInfo get_PageInfo() { }

	public string get_Prefix() { }

	public string get_Value() { }

	public int GetParent(out XPathNode[] pageNode) { }

	public int GetSibling(out XPathNode[] pageNode) { }

}

