namespace MS.Internal.Xml.Cache;

internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
{
	private XPathNode[] _pageCurrent; //Field offset: 0x10
	private XPathNode[] _pageParent; //Field offset: 0x18
	private int _idxCurrent; //Field offset: 0x20
	private int _idxParent; //Field offset: 0x24

	public override int LineNumber
	{
		 get { } //Length: 121
	}

	public override int LinePosition
	{
		 get { } //Length: 154
	}

	public virtual string LocalName
	{
		 get { } //Length: 58
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 58
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 67
	}

	public virtual XPathNodeType NodeType
	{
		 get { } //Length: 49
	}

	public virtual string Prefix
	{
		 get { } //Length: 58
	}

	public virtual object UnderlyingObject
	{
		 get { } //Length: 20
	}

	public virtual string Value
	{
		 get { } //Length: 693
	}

	public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	public virtual XPathNavigator Clone() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XPathNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual object get_UnderlyingObject() { }

	public virtual string get_Value() { }

	public int GetPositionHashCode() { }

	public override bool HasLineInfo() { }

	public virtual bool IsSamePosition(XPathNavigator other) { }

	public virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	public virtual bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	public virtual bool MoveToParent() { }

}

