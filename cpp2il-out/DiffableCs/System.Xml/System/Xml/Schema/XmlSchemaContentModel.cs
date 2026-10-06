namespace System.Xml.Schema;

public abstract class XmlSchemaContentModel : XmlSchemaAnnotated
{

	[XmlIgnore]
	public abstract XmlSchemaContent Content
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	protected XmlSchemaContentModel() { }

	public abstract XmlSchemaContent get_Content() { }

	public abstract void set_Content(XmlSchemaContent value) { }

}

