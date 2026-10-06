namespace System.Xml.Schema;

internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo
{
	internal static readonly SchemaElementDecl Empty; //Field offset: 0x0
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; //Field offset: 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; //Field offset: 0x68
	private bool isIdDeclared; //Field offset: 0x70
	private bool hasNonCDataAttribute; //Field offset: 0x71
	private bool isAbstract; //Field offset: 0x72
	private bool isNillable; //Field offset: 0x73
	private bool hasRequiredAttribute; //Field offset: 0x74
	private bool isNotationDeclared; //Field offset: 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; //Field offset: 0x78
	private ContentValidator contentValidator; //Field offset: 0x80
	private XmlSchemaAnyAttribute anyAttribute; //Field offset: 0x88
	private XmlSchemaDerivationMethod block; //Field offset: 0x90
	private CompiledIdentityConstraint[] constraints; //Field offset: 0x98
	private XmlSchemaElement schemaElement; //Field offset: 0xA0

	internal XmlSchemaAnyAttribute AnyAttribute
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
	{
		internal get { } //Length: 5
	}

	internal XmlSchemaDerivationMethod Block
	{
		internal get { } //Length: 7
		internal set { } //Length: 7
	}

	internal CompiledIdentityConstraint[] Constraints
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	internal ContentValidator ContentValidator
	{
		internal get { } //Length: 8
		internal set { } //Length: 16
	}

	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs
	{
		internal get { } //Length: 5
	}

	internal bool HasDefaultAttribute
	{
		internal get { } //Length: 9
	}

	internal bool HasNonCDataAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool HasRequiredAttribute
	{
		internal get { } //Length: 5
	}

	internal bool IsAbstract
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool IsIdDeclared
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool IsNillable
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal bool IsNotationDeclared
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
	{
		internal get { } //Length: 5
	}

	internal XmlSchemaElement SchemaElement
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	private override bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
	{
		private get { } //Length: 5
	}

	private static SchemaElementDecl() { }

	internal SchemaElementDecl(XmlQualifiedName name, string prefix) { }

	internal SchemaElementDecl() { }

	internal SchemaElementDecl(XmlSchemaDatatype dtype) { }

	internal void AddAttDef(SchemaAttDef attdef) { }

	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	internal SchemaElementDecl Clone() { }

	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	internal XmlSchemaDerivationMethod get_Block() { }

	internal CompiledIdentityConstraint[] get_Constraints() { }

	internal ContentValidator get_ContentValidator() { }

	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	internal bool get_HasDefaultAttribute() { }

	internal bool get_HasNonCDataAttribute() { }

	internal bool get_HasRequiredAttribute() { }

	internal bool get_IsAbstract() { }

	internal bool get_IsIdDeclared() { }

	internal bool get_IsNillable() { }

	internal bool get_IsNotationDeclared() { }

	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	internal XmlSchemaElement get_SchemaElement() { }

	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	internal void set_Block(XmlSchemaDerivationMethod value) { }

	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	internal void set_ContentValidator(ContentValidator value) { }

	internal void set_HasNonCDataAttribute(bool value) { }

	internal void set_IsAbstract(bool value) { }

	internal void set_IsIdDeclared(bool value) { }

	internal void set_IsNillable(bool value) { }

	internal void set_IsNotationDeclared(bool value) { }

	internal void set_SchemaElement(XmlSchemaElement value) { }

	private override bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	private override IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	private override IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

}

