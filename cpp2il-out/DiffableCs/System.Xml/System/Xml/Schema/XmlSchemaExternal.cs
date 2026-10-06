namespace System.Xml.Schema;

public abstract class XmlSchemaExternal : XmlSchemaObject
{
	private string location; //Field offset: 0x38
	private Uri baseUri; //Field offset: 0x40
	private XmlSchema schema; //Field offset: 0x48
	private string id; //Field offset: 0x50
	private XmlAttribute[] moreAttributes; //Field offset: 0x58
	private Compositor compositor; //Field offset: 0x60

	[XmlIgnore]
	internal Uri BaseUri
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	internal Compositor Compositor
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlIgnore]
	public XmlSchema Schema
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlAttribute("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	protected XmlSchemaExternal() { }

	internal Uri get_BaseUri() { }

	internal Compositor get_Compositor() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	public XmlSchema get_Schema() { }

	public string get_SchemaLocation() { }

	internal void set_BaseUri(Uri value) { }

	internal void set_Compositor(Compositor value) { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	public void set_Schema(XmlSchema value) { }

	public void set_SchemaLocation(string value) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

