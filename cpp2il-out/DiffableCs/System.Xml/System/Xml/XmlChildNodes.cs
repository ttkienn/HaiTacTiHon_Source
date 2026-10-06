namespace System.Xml;

internal class XmlChildNodes : XmlNodeList
{
	private XmlNode container; //Field offset: 0x10

	public virtual int Count
	{
		 get { } //Length: 91
	}

	public XmlChildNodes(XmlNode container) { }

	public virtual int get_Count() { }

	public virtual IEnumerator GetEnumerator() { }

	public virtual XmlNode Item(int i) { }

}

