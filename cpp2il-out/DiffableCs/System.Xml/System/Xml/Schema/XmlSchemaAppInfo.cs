namespace System.Xml.Schema;

public class XmlSchemaAppInfo : XmlSchemaObject
{
	private string source; //Field offset: 0x38
	private XmlNode[] markup; //Field offset: 0x40

	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlAttribute("source", DataType = "anyURI")]
	public string Source
	{
		 set { } //Length: 13
	}

	public XmlSchemaAppInfo() { }

	public XmlNode[] get_Markup() { }

	public void set_Markup(XmlNode[] value) { }

	public void set_Source(string value) { }

}

