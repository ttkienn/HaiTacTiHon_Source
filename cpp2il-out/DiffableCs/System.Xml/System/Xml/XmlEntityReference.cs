namespace System.Xml;

public class XmlEntityReference : XmlLinkedNode
{
	private string name; //Field offset: 0x20
	private XmlLinkedNode lastChild; //Field offset: 0x28

	public virtual string BaseURI
	{
		 get { } //Length: 60
	}

	internal string ChildBaseURI
	{
		internal get { } //Length: 572
	}

	internal virtual bool IsContainer
	{
		internal get { } //Length: 3
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual string Value
	{
		 get { } //Length: 3
		 set { } //Length: 95
	}

	protected private XmlEntityReference(string name, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	private string ConstructBaseURI(string baseURI, string systemId) { }

	public virtual string get_BaseURI() { }

	internal string get_ChildBaseURI() { }

	internal virtual bool get_IsContainer() { }

	public virtual bool get_IsReadOnly() { }

	internal virtual XmlLinkedNode get_LastNode() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Value() { }

	internal virtual bool IsValidChildType(XmlNodeType type) { }

	internal virtual void set_LastNode(XmlLinkedNode value) { }

	public virtual void set_Value(string value) { }

	internal virtual void SetParent(XmlNode node) { }

	internal virtual void SetParentForLoad(XmlNode node) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

