namespace System.Xml.Schema;

public class XmlSchemaRedefine : XmlSchemaExternal
{
	private XmlSchemaObjectCollection items; //Field offset: 0x68
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x70
	private XmlSchemaObjectTable types; //Field offset: 0x78
	private XmlSchemaObjectTable groups; //Field offset: 0x80

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		 get { } //Length: 8
	}

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		 get { } //Length: 5
	}

	public XmlSchemaRedefine() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	public XmlSchemaObjectTable get_AttributeGroups() { }

	public XmlSchemaObjectTable get_Groups() { }

	public XmlSchemaObjectCollection get_Items() { }

	public XmlSchemaObjectTable get_SchemaTypes() { }

}

