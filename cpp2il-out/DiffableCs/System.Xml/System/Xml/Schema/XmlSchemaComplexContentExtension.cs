namespace System.Xml.Schema;

public class XmlSchemaComplexContentExtension : XmlSchemaContent
{
	private XmlSchemaParticle particle; //Field offset: 0x50
	private XmlSchemaObjectCollection attributes; //Field offset: 0x58
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x60
	private XmlQualifiedName baseTypeName; //Field offset: 0x68

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

	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	public XmlSchemaComplexContentExtension() { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlQualifiedName get_BaseTypeName() { }

	public XmlSchemaParticle get_Particle() { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_BaseTypeName(XmlQualifiedName value) { }

	public void set_Particle(XmlSchemaParticle value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

