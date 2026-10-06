namespace System.Xml.Schema;

public class XmlSchemaImport : XmlSchemaExternal
{
	private string ns; //Field offset: 0x68
	private XmlSchemaAnnotation annotation; //Field offset: 0x70

	[XmlAttribute("namespace", DataType = "anyURI")]
	public string Namespace
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlSchemaImport() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	public string get_Namespace() { }

	public void set_Namespace(string value) { }

}

