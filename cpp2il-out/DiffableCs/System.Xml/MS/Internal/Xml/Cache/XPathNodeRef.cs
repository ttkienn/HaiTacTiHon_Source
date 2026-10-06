namespace MS.Internal.Xml.Cache;

internal struct XPathNodeRef
{
	private XPathNode[] _page; //Field offset: 0x0
	private int _idx; //Field offset: 0x8

	public int Index
	{
		 get { } //Length: 4
	}

	public XPathNode[] Page
	{
		 get { } //Length: 4
	}

	public XPathNodeRef(XPathNode[] page, int idx) { }

	public int get_Index() { }

	public XPathNode[] get_Page() { }

	public virtual int GetHashCode() { }

}

