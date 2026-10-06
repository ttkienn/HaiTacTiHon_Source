namespace System.Xml.Schema;

public class XmlSchemaAttribute : XmlSchemaAnnotated
{
	private string defaultValue; //Field offset: 0x50
	private string fixedValue; //Field offset: 0x58
	private string name; //Field offset: 0x60
	private XmlSchemaForm form; //Field offset: 0x68
	private XmlSchemaUse use; //Field offset: 0x6C
	private XmlQualifiedName refName; //Field offset: 0x70
	private XmlQualifiedName typeName; //Field offset: 0x78
	private XmlQualifiedName qualifiedName; //Field offset: 0x80
	private XmlSchemaSimpleType type; //Field offset: 0x88
	private XmlSchemaSimpleType attributeType; //Field offset: 0x90
	private SchemaAttDef attDef; //Field offset: 0x98

	internal SchemaAttDef AttDef
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType
	{
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal XmlSchemaDatatype Datatype
	{
		internal get { } //Length: 25
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		 get { } //Length: 4
		 set { } //Length: 4
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
		 get { } //Length: 8
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		 get { } //Length: 5
		 set { } //Length: 160
	}

	[DefaultValue(XmlSchemaUse::None (0))]
	[XmlAttribute("use")]
	public XmlSchemaUse Use
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public XmlSchemaAttribute() { }

	internal virtual XmlSchemaObject Clone() { }

	internal SchemaAttDef get_AttDef() { }

	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	internal XmlSchemaDatatype get_Datatype() { }

	public string get_DefaultValue() { }

	public string get_FixedValue() { }

	public XmlSchemaForm get_Form() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	public XmlQualifiedName get_QualifiedName() { }

	public XmlQualifiedName get_RefName() { }

	public XmlSchemaSimpleType get_SchemaType() { }

	public XmlQualifiedName get_SchemaTypeName() { }

	public XmlSchemaUse get_Use() { }

	internal void set_AttDef(SchemaAttDef value) { }

	public void set_DefaultValue(string value) { }

	public void set_FixedValue(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_RefName(XmlQualifiedName value) { }

	public void set_SchemaType(XmlSchemaSimpleType value) { }

	public void set_SchemaTypeName(XmlQualifiedName value) { }

	public void set_Use(XmlSchemaUse value) { }

	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

