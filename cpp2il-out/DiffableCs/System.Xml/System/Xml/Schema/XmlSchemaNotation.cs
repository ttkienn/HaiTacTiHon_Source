namespace System.Xml.Schema;

public class XmlSchemaNotation : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private string publicId; //Field offset: 0x58
	private string systemId; //Field offset: 0x60
	private XmlQualifiedName qname; //Field offset: 0x68

	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlAttribute("public")]
	public string Public
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal XmlQualifiedName QualifiedName
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlAttribute("system")]
	public string System
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlSchemaNotation() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public string get_Public() { }

	internal XmlQualifiedName get_QualifiedName() { }

	public string get_System() { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_Public(string value) { }

	internal void set_QualifiedName(XmlQualifiedName value) { }

	public void set_System(string value) { }

}

