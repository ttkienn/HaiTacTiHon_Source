namespace System.Xml.Schema;

public class XmlSchemaSimpleContentRestriction : XmlSchemaContent
{
	private XmlQualifiedName baseTypeName; //Field offset: 0x50
	private XmlSchemaSimpleType baseType; //Field offset: 0x58
	private XmlSchemaObjectCollection facets; //Field offset: 0x60
	private XmlSchemaObjectCollection attributes; //Field offset: 0x68
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x70

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

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlAttribute("base")]
	public XmlQualifiedName BaseTypeName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	public XmlSchemaObjectCollection Facets
	{
		 get { } //Length: 5
	}

	public XmlSchemaSimpleContentRestriction() { }

	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	public XmlSchemaObjectCollection get_Attributes() { }

	public XmlSchemaSimpleType get_BaseType() { }

	public XmlQualifiedName get_BaseTypeName() { }

	public XmlSchemaObjectCollection get_Facets() { }

	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	public void set_BaseType(XmlSchemaSimpleType value) { }

	public void set_BaseTypeName(XmlQualifiedName value) { }

	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

}

