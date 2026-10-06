namespace System.Xml.Schema;

internal sealed class SchemaCollectionPreprocessor : BaseProcessor
{
	private enum Compositor
	{
		Root = 0,
		Include = 1,
		Import = 2,
	}

	private XmlSchema schema; //Field offset: 0x40
	private string targetNamespace; //Field offset: 0x48
	private bool buildinIncluded; //Field offset: 0x50
	private XmlSchemaForm elementFormDefault; //Field offset: 0x54
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x58
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x5C
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x60
	private Hashtable schemaLocations; //Field offset: 0x68
	private Hashtable referenceNamespaces; //Field offset: 0x70
	private string Xmlns; //Field offset: 0x78
	private XmlResolver xmlResolver; //Field offset: 0x80

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 16
	}

	public SchemaCollectionPreprocessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	private void BuildRefNamespaces(XmlSchema schema) { }

	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	private void Cleanup(XmlSchema schema) { }

	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	private Stream GetSchemaEntity(Uri ruri) { }

	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	private void Preprocess(XmlSchema schema, string targetNamespace, Compositor compositor) { }

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

	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	internal void set_XmlResolver(XmlResolver value) { }

	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

}

