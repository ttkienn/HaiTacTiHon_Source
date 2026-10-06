namespace System.Xml.Linq;

public class XDocument : XContainer
{
	private XDeclaration _declaration; //Field offset: 0x30

	public XDeclaration Declaration
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public XElement Root
	{
		 get { } //Length: 57
	}

	public XDocument() { }

	public XDocument(XDocument other) { }

	internal virtual void AddAttribute(XAttribute a) { }

	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	internal virtual XNode CloneNode() { }

	public XDeclaration get_Declaration() { }

	public virtual XmlNodeType get_NodeType() { }

	public XElement get_Root() { }

	private T GetFirstNode() { }

	internal static bool IsWhitespace(string s) { }

	public void set_Declaration(XDeclaration value) { }

	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	internal virtual void ValidateNode(XNode node, XNode previous) { }

	internal virtual void ValidateString(string s) { }

	public virtual void WriteTo(XmlWriter writer) { }

}

