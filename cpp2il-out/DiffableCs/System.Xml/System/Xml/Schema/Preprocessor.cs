namespace System.Xml.Schema;

internal sealed class Preprocessor : BaseProcessor
{
	private static XmlSchema builtInSchemaForXmlNS; //Field offset: 0x0
	private string Xmlns; //Field offset: 0x40
	private string NsXsi; //Field offset: 0x48
	private string targetNamespace; //Field offset: 0x50
	private XmlSchema rootSchema; //Field offset: 0x58
	private XmlSchema currentSchema; //Field offset: 0x60
	private XmlSchemaForm elementFormDefault; //Field offset: 0x68
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x6C
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x70
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x74
	private Hashtable schemaLocations; //Field offset: 0x78
	private Hashtable chameleonSchemas; //Field offset: 0x80
	private Hashtable referenceNamespaces; //Field offset: 0x88
	private Hashtable processedExternals; //Field offset: 0x90
	private SortedList lockList; //Field offset: 0x98
	private XmlReaderSettings readerSettings; //Field offset: 0xA0
	private XmlSchema rootSchemaForRedefine; //Field offset: 0xA8
	private ArrayList redefinedList; //Field offset: 0xB0
	private XmlResolver xmlResolver; //Field offset: 0xB8

	internal Hashtable ChameleonSchemas
	{
		internal set { } //Length: 16
	}

	internal XmlReaderSettings ReaderSettings
	{
		internal set { } //Length: 19
	}

	internal XmlSchema RootSchema
	{
		internal get { } //Length: 5
	}

	internal Hashtable SchemaLocations
	{
		internal set { } //Length: 13
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 19
	}

	public Preprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	private void BuildRefNamespaces(XmlSchema schema) { }

	private void BuildSchemaList(XmlSchema schema) { }

	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	private void Cleanup(XmlSchema schema) { }

	private void CleanupRedefine(XmlSchemaExternal include) { }

	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	internal XmlSchema get_RootSchema() { }

	internal static XmlSchema GetBuildInSchema() { }

	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	private object GetSchemaEntity(Uri ruri) { }

	private void LoadExternals(XmlSchema schema) { }

	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }

	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	private void PreprocessElement(XmlSchemaElement element) { }

	private void PreprocessElementContent(XmlSchemaElement element) { }

	private void PreprocessGroup(XmlSchemaGroup group) { }

	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	private void PreprocessLocalElement(XmlSchemaElement element) { }

	private void PreprocessNotation(XmlSchemaNotation notation) { }

	private void PreprocessParticle(XmlSchemaParticle particle) { }

	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	internal void set_ChameleonSchemas(Hashtable value) { }

	internal void set_ReaderSettings(XmlReaderSettings value) { }

	internal void set_SchemaLocations(Hashtable value) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	private void SetSchemaDefaults(XmlSchema schema) { }

	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

