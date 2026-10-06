namespace System.Xml.Schema;

public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent
{
	private XmlQualifiedName baseTypeName; //Field offset: 0x50
	private XmlSchemaSimpleType baseType; //Field offset: 0x58
	private XmlSchemaObjectCollection facets; //Field offset: 0x60

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

	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets
	{
		 get { } //Length: 5
	}

	public XmlSchemaSimpleTypeRestriction() { }

	internal virtual XmlSchemaObject Clone() { }

	public XmlSchemaSimpleType get_BaseType() { }

	public XmlQualifiedName get_BaseTypeName() { }

	public XmlSchemaObjectCollection get_Facets() { }

	public void set_BaseType(XmlSchemaSimpleType value) { }

	public void set_BaseTypeName(XmlQualifiedName value) { }

}

