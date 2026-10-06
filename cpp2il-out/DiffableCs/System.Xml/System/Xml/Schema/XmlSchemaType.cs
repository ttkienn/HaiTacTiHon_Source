namespace System.Xml.Schema;

public class XmlSchemaType : XmlSchemaAnnotated
{
	private string name; //Field offset: 0x50
	private XmlSchemaDerivationMethod final; //Field offset: 0x58
	private XmlSchemaDerivationMethod derivedBy; //Field offset: 0x5C
	private XmlSchemaType baseSchemaType; //Field offset: 0x60
	private XmlSchemaDatatype datatype; //Field offset: 0x68
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0x70
	private SchemaElementDecl elementDecl; //Field offset: 0x78
	private XmlQualifiedName qname; //Field offset: 0x80
	private XmlSchemaType redefined; //Field offset: 0x88
	private XmlSchemaContentType contentType; //Field offset: 0x90

	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaDatatype Datatype
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy
	{
		 get { } //Length: 4
	}

	internal SchemaElementDecl ElementDecl
	{
		internal get { } //Length: 24
		internal set { } //Length: 47
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		 get { } //Length: 4
	}

	[XmlIgnore]
	public override bool IsMixed
	{
		 get { } //Length: 3
		 set { } //Length: 3
	}

	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 27
	}

	[XmlIgnore]
	internal XmlSchemaType Redefined
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	internal XmlSchemaContentType SchemaContentType
	{
		internal get { } //Length: 7
	}

	[XmlIgnore]
	public XmlTypeCode TypeCode
	{
		 get { } //Length: 181
	}

	[XmlIgnore]
	internal XmlValueConverter ValueConverter
	{
		internal get { } //Length: 120
	}

	public XmlSchemaType() { }

	public XmlSchemaType get_BaseXmlSchemaType() { }

	public XmlSchemaDatatype get_Datatype() { }

	public XmlSchemaDerivationMethod get_DerivedBy() { }

	internal SchemaElementDecl get_ElementDecl() { }

	public XmlSchemaDerivationMethod get_Final() { }

	public XmlSchemaDerivationMethod get_FinalResolved() { }

	public override bool get_IsMixed() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	internal XmlSchemaType get_Redefined() { }

	internal XmlSchemaContentType get_SchemaContentType() { }

	public XmlTypeCode get_TypeCode() { }

	internal XmlValueConverter get_ValueConverter() { }

	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	internal void set_ElementDecl(SchemaElementDecl value) { }

	public void set_Final(XmlSchemaDerivationMethod value) { }

	public override void set_IsMixed(bool value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	internal void set_Redefined(XmlSchemaType value) { }

	internal void SetBaseSchemaType(XmlSchemaType value) { }

	internal void SetContentType(XmlSchemaContentType value) { }

	internal void SetDatatype(XmlSchemaDatatype value) { }

	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

