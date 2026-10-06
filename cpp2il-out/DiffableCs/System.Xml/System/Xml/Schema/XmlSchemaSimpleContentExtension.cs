namespace System.Xml.Schema;

public class XmlSchemaSimpleContentExtension : XmlSchemaContent
{
	private XmlSchemaObjectCollection attributes; //Field offset: 0x50
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x58
	private XmlQualifiedName baseTypeName; //Field offset: 0x60

	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes
	{
		 get { } //Length: 5
	}

	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	public XmlSchemaSimpleContentExtension() { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlQualifiedName get_BaseTypeName() { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_BaseTypeName(XmlQualifiedName value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

