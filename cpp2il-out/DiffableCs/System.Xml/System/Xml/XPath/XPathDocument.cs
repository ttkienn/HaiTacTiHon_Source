namespace System.Xml.XPath;

public class XPathDocument
{
	private XPathNode[] pageXmlNmsp; //Field offset: 0x10
	private int idxXmlNmsp; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private bool hasLineInfo; //Field offset: 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; //Field offset: 0x30

	internal bool HasLineInfo
	{
		internal get { } //Length: 5
	}

	internal XmlNameTable NameTable
	{
		internal get { } //Length: 5
	}

	internal bool get_HasLineInfo() { }

	internal XmlNameTable get_NameTable() { }

	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

}

