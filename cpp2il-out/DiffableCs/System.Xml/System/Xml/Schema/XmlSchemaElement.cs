namespace System.Xml.Schema;

public class XmlSchemaElement : XmlSchemaParticle
{
	private bool isAbstract; //Field offset: 0x78
	private bool hasAbstractAttribute; //Field offset: 0x79
	private bool isNillable; //Field offset: 0x7A
	private bool hasNillableAttribute; //Field offset: 0x7B
	private bool isLocalTypeDerivationChecked; //Field offset: 0x7C
	private XmlSchemaDerivationMethod block; //Field offset: 0x80
	private XmlSchemaDerivationMethod final; //Field offset: 0x84
	private XmlSchemaForm form; //Field offset: 0x88
	private string defaultValue; //Field offset: 0x90
	private string fixedValue; //Field offset: 0x98
	private string name; //Field offset: 0xA0
	private XmlQualifiedName refName; //Field offset: 0xA8
	private XmlQualifiedName substitutionGroup; //Field offset: 0xB0
	private XmlQualifiedName typeName; //Field offset: 0xB8
	private XmlSchemaType type; //Field offset: 0xC0
	private XmlQualifiedName qualifiedName; //Field offset: 0xC8
	private XmlSchemaType elementType; //Field offset: 0xD0
	private XmlSchemaDerivationMethod blockResolved; //Field offset: 0xD8
	private XmlSchemaDerivationMethod finalResolved; //Field offset: 0xDC
	private XmlSchemaObjectCollection constraints; //Field offset: 0xE0
	private SchemaElementDecl elementDecl; //Field offset: 0xE8

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("block")]
	public XmlSchemaDerivationMethod Block
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved
	{
		 get { } //Length: 7
	}

	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	[XmlElement("key", typeof(XmlSchemaKey))]
	public XmlSchemaObjectCollection Constraints
	{
		 get { } //Length: 117
	}

	[DefaultValue(null)]
	[XmlAttribute("default")]
	public string DefaultValue
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	internal SchemaElementDecl ElementDecl
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[XmlIgnore]
	public XmlSchemaType ElementSchemaType
	{
		 get { } //Length: 8
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("final")]
	public XmlSchemaDerivationMethod Final
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved
	{
		 get { } //Length: 7
	}

	[DefaultValue(null)]
	[XmlAttribute("fixed")]
	public string FixedValue
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("form")]
	public XmlSchemaForm Form
	{
		 get { } //Length: 7
		 set { } //Length: 155
	}

	[XmlIgnore]
	internal bool HasAbstractAttribute
	{
		internal get { } //Length: 5
	}

	internal bool HasConstraints
	{
		internal get { } //Length: 45
	}

	[XmlIgnore]
	internal bool HasNillableAttribute
	{
		internal get { } //Length: 5
	}

	[DefaultValue(False)]
	[XmlAttribute("abstract")]
	public bool IsAbstract
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	internal bool IsLocalTypeDerivationChecked
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	[DefaultValue(False)]
	[XmlAttribute("nillable")]
	public bool IsNillable
	{
		 get { } //Length: 5
		 set { } //Length: 8
	}

	[DefaultValue(null)]
	[XmlAttribute("name")]
	public string Name
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlIgnore]
	internal virtual string NameAttribute
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[XmlIgnore]
	internal virtual string NameString
	{
		internal get { } //Length: 45
	}

	[XmlIgnore]
	public XmlQualifiedName QualifiedName
	{
		 get { } //Length: 8
	}

	[XmlAttribute("ref")]
	public XmlQualifiedName RefName
	{
		 get { } //Length: 8
		 set { } //Length: 166
	}

	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType
	{
		 get { } //Length: 8
		 set { } //Length: 19
	}

	[XmlAttribute("type")]
	public XmlQualifiedName SchemaTypeName
	{
		 get { } //Length: 8
		 set { } //Length: 166
	}

	[XmlAttribute("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup
	{
		 get { } //Length: 8
		 set { } //Length: 166
	}

	public XmlSchemaElement() { }

	internal virtual XmlSchemaObject Clone() { }

	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	public XmlSchemaDerivationMethod get_Block() { }

	public XmlSchemaDerivationMethod get_BlockResolved() { }

	public XmlSchemaObjectCollection get_Constraints() { }

	public string get_DefaultValue() { }

	internal SchemaElementDecl get_ElementDecl() { }

	public XmlSchemaType get_ElementSchemaType() { }

	public XmlSchemaDerivationMethod get_Final() { }

	public XmlSchemaDerivationMethod get_FinalResolved() { }

	public string get_FixedValue() { }

	public XmlSchemaForm get_Form() { }

	internal bool get_HasAbstractAttribute() { }

	internal bool get_HasConstraints() { }

	internal bool get_HasNillableAttribute() { }

	public bool get_IsAbstract() { }

	internal bool get_IsLocalTypeDerivationChecked() { }

	public bool get_IsNillable() { }

	public string get_Name() { }

	internal virtual string get_NameAttribute() { }

	internal virtual string get_NameString() { }

	public XmlQualifiedName get_QualifiedName() { }

	public XmlQualifiedName get_RefName() { }

	public XmlSchemaType get_SchemaType() { }

	public XmlQualifiedName get_SchemaTypeName() { }

	public XmlQualifiedName get_SubstitutionGroup() { }

	public void set_Block(XmlSchemaDerivationMethod value) { }

	public void set_DefaultValue(string value) { }

	internal void set_ElementDecl(SchemaElementDecl value) { }

	public void set_Final(XmlSchemaDerivationMethod value) { }

	public void set_FixedValue(string value) { }

	public void set_Form(XmlSchemaForm value) { }

	public void set_IsAbstract(bool value) { }

	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	public void set_IsNillable(bool value) { }

	public void set_Name(string value) { }

	internal virtual void set_NameAttribute(string value) { }

	public void set_RefName(XmlQualifiedName value) { }

	public void set_SchemaType(XmlSchemaType value) { }

	public void set_SchemaTypeName(XmlQualifiedName value) { }

	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	internal void SetElementType(XmlSchemaType value) { }

	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	internal void SetQualifiedName(XmlQualifiedName value) { }

}

