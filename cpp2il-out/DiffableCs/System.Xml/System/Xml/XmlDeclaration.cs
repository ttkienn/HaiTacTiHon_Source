namespace System.Xml;

public class XmlDeclaration : XmlLinkedNode
{
	private string version; //Field offset: 0x20
	private string encoding; //Field offset: 0x28
	private string standalone; //Field offset: 0x30

	public string Encoding
	{
		 get { } //Length: 5
		 set { } //Length: 102
	}

	public virtual string InnerText
	{
		 get { } //Length: 345
		 set { } //Length: 806
	}

	public virtual string LocalName
	{
		 get { } //Length: 20
	}

	public virtual string Name
	{
		 get { } //Length: 44
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Standalone
	{
		 get { } //Length: 5
		 set { } //Length: 321
	}

	public virtual string Value
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public internal string Version
	{
		 get { } //Length: 5
		internal set { } //Length: 13
	}

	protected private XmlDeclaration(string version, string encoding, string standalone, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public string get_Encoding() { }

	public virtual string get_InnerText() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Standalone() { }

	public virtual string get_Value() { }

	public string get_Version() { }

	private bool IsValidXmlVersion(string ver) { }

	public void set_Encoding(string value) { }

	public virtual void set_InnerText(string value) { }

	public void set_Standalone(string value) { }

	public virtual void set_Value(string value) { }

	internal void set_Version(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

