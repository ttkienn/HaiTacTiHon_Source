namespace System.Xml.Schema;

internal class SchemaInfo : IDtdInfo
{
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; //Field offset: 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; //Field offset: 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; //Field offset: 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; //Field offset: 0x28
	private XmlQualifiedName docTypeName; //Field offset: 0x30
	private string internalDtdSubset; //Field offset: 0x38
	private bool hasNonCDataAttributes; //Field offset: 0x40
	private bool hasDefaultAttributes; //Field offset: 0x41
	private Dictionary<String, Boolean> targetNamespaces; //Field offset: 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; //Field offset: 0x50
	private int errorCount; //Field offset: 0x58
	private SchemaType schemaType; //Field offset: 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; //Field offset: 0x60
	private Dictionary<String, SchemaNotation> notations; //Field offset: 0x68

	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
	{
		internal get { } //Length: 5
	}

	public XmlQualifiedName DocTypeName
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
	{
		internal get { } //Length: 5
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
	{
		internal get { } //Length: 5
	}

	internal int ErrorCount
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
	{
		internal get { } //Length: 122
	}

	internal string InternalDtdSubset
	{
		internal set { } //Length: 13
	}

	internal Dictionary<String, SchemaNotation> Notations
	{
		internal get { } //Length: 122
	}

	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
	{
		internal get { } //Length: 122
	}

	internal SchemaType SchemaType
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	private override bool System.Xml.IDtdInfo.HasDefaultAttributes
	{
		private get { } //Length: 5
	}

	private override bool System.Xml.IDtdInfo.HasNonCDataAttributes
	{
		private get { } //Length: 5
	}

	private override string System.Xml.IDtdInfo.InternalDtdSubset
	{
		private get { } //Length: 5
	}

	private override XmlQualifiedName System.Xml.IDtdInfo.Name
	{
		private get { } //Length: 5
	}

	internal Dictionary<String, Boolean> TargetNamespaces
	{
		internal get { } //Length: 5
	}

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
	{
		internal get { } //Length: 5
	}

	internal SchemaInfo() { }

	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	internal bool Contains(string ns) { }

	internal void Finish() { }

	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	public XmlQualifiedName get_DocTypeName() { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	internal int get_ErrorCount() { }

	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	internal Dictionary<String, SchemaNotation> get_Notations() { }

	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	internal SchemaType get_SchemaType() { }

	internal Dictionary<String, Boolean> get_TargetNamespaces() { }

	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	internal bool HasSchema(string ns) { }

	public void set_DocTypeName(XmlQualifiedName value) { }

	internal void set_ErrorCount(int value) { }

	internal void set_InternalDtdSubset(string value) { }

	internal void set_SchemaType(SchemaType value) { }

	private override bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	private override bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	private override string System.Xml.IDtdInfo.get_InternalDtdSubset() { }

	private override XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	private override IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	private override IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

}

