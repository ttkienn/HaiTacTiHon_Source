namespace System.Xml.Serialization;

internal class XmlTypeMapMemberAttribute : XmlTypeMapMember
{
	private string _attributeName; //Field offset: 0x58
	private string _namespace; //Field offset: 0x60
	private XmlSchemaForm _form; //Field offset: 0x68
	private XmlTypeMapping _mappedType; //Field offset: 0x70

	public string AttributeName
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlSchemaForm Form
	{
		 set { } //Length: 4
	}

	public XmlTypeMapping MappedType
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public string Namespace
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlTypeMapMemberAttribute() { }

	public string get_AttributeName() { }

	public XmlTypeMapping get_MappedType() { }

	public string get_Namespace() { }

	public void set_AttributeName(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_MappedType(XmlTypeMapping value) { }

	public void set_Namespace(string value) { }

}

