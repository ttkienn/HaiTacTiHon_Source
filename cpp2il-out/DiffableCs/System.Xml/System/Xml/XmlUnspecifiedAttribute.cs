namespace System.Xml;

internal class XmlUnspecifiedAttribute : XmlAttribute
{
	private bool fSpecified; //Field offset: 0x28

	public virtual string InnerText
	{
		 set { } //Length: 27
	}

	public virtual bool Specified
	{
		 get { } //Length: 5
	}

	protected private XmlUnspecifiedAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	public virtual XmlNode AppendChild(XmlNode newChild) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual bool get_Specified() { }

	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	public virtual void set_InnerText(string value) { }

	internal void SetSpecified(bool f) { }

	public virtual void WriteTo(XmlWriter w) { }

}

