namespace System.Xml;

public class XmlDocumentFragment : XmlNode
{
	private XmlLinkedNode lastChild; //Field offset: 0x18

	public virtual string InnerXml
	{
		 set { } //Length: 151
	}

	internal virtual bool IsContainer
	{
		internal get { } //Length: 3
	}

	internal virtual XmlLinkedNode LastNode
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public virtual string LocalName
	{
		 get { } //Length: 45
	}

	public virtual string Name
	{
		 get { } //Length: 45
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual XmlDocument OwnerDocument
	{
		 get { } //Length: 107
	}

	public virtual XmlNode ParentNode
	{
		 get { } //Length: 3
	}

	protected private XmlDocumentFragment(XmlDocument ownerDocument) { }

	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	public virtual XmlNode CloneNode(bool deep) { }

	internal virtual bool get_IsContainer() { }

	internal virtual XmlLinkedNode get_LastNode() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual XmlDocument get_OwnerDocument() { }

	public virtual XmlNode get_ParentNode() { }

	internal virtual bool IsValidChildType(XmlNodeType type) { }

	public virtual void set_InnerXml(string value) { }

	internal virtual void set_LastNode(XmlLinkedNode value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

