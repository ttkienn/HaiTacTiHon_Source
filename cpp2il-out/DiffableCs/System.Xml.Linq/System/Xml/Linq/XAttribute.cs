namespace System.Xml.Linq;

public class XAttribute : XObject
{
	internal XAttribute next; //Field offset: 0x20
	internal XName name; //Field offset: 0x28
	internal string value; //Field offset: 0x30

	public bool IsNamespaceDeclaration
	{
		 get { } //Length: 131
	}

	public XName Name
	{
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 5
		 set { } //Length: 297
	}

	public XAttribute(XName name, object value) { }

	public XAttribute(XAttribute other) { }

	public bool get_IsNamespaceDeclaration() { }

	public XName get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Value() { }

	internal string GetPrefixOfNamespace(XNamespace ns) { }

	public void set_Value(string value) { }

	public virtual string ToString() { }

	private static void ValidateAttribute(XName name, string value) { }

}

