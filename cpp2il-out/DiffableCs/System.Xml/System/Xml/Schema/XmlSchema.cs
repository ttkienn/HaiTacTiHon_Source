namespace System.Xml.Schema;

[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject
{
	private static int globalIdCounter; //Field offset: 0x0
	private XmlSchemaForm attributeFormDefault; //Field offset: 0x38
	private XmlSchemaForm elementFormDefault; //Field offset: 0x3C
	private XmlSchemaDerivationMethod blockDefault; //Field offset: 0x40
	private XmlSchemaDerivationMethod finalDefault; //Field offset: 0x44
	private string targetNs; //Field offset: 0x48
	private string version; //Field offset: 0x50
	private XmlSchemaObjectCollection includes; //Field offset: 0x58
	private XmlSchemaObjectCollection items; //Field offset: 0x60
	private string id; //Field offset: 0x68
	private XmlAttribute[] moreAttributes; //Field offset: 0x70
	private bool isCompiled; //Field offset: 0x78
	private bool isCompiledBySet; //Field offset: 0x79
	private bool isPreprocessed; //Field offset: 0x7A
	private bool isRedefined; //Field offset: 0x7B
	private int errorCount; //Field offset: 0x7C
	private XmlSchemaObjectTable attributes; //Field offset: 0x80
	private XmlSchemaObjectTable attributeGroups; //Field offset: 0x88
	private XmlSchemaObjectTable elements; //Field offset: 0x90
	private XmlSchemaObjectTable types; //Field offset: 0x98
	private XmlSchemaObjectTable groups; //Field offset: 0xA0
	private XmlSchemaObjectTable notations; //Field offset: 0xA8
	private XmlSchemaObjectTable identityConstraints; //Field offset: 0xB0
	private ArrayList importedSchemas; //Field offset: 0xB8
	private ArrayList importedNamespaces; //Field offset: 0xC0
	private int schemaId; //Field offset: 0xC8
	private Uri baseUri; //Field offset: 0xD0
	private bool isChameleon; //Field offset: 0xD8
	private Hashtable ids; //Field offset: 0xE0
	private XmlDocument document; //Field offset: 0xE8

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("attributeFormDefault")]
	public XmlSchemaForm AttributeFormDefault
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups
	{
		 get { } //Length: 117
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Attributes
	{
		 get { } //Length: 117
	}

	[XmlIgnore]
	internal Uri BaseUri
	{
		internal get { } //Length: 8
		internal set { } //Length: 19
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	internal XmlDocument Document
	{
		internal get { } //Length: 117
	}

	[DefaultValue(XmlSchemaForm::None (0))]
	[XmlAttribute("elementFormDefault")]
	public XmlSchemaForm ElementFormDefault
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Elements
	{
		 get { } //Length: 117
	}

	[XmlIgnore]
	internal int ErrorCount
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	[DefaultValue(XmlSchemaDerivationMethod::None (256))]
	[XmlAttribute("finalDefault")]
	public XmlSchemaDerivationMethod FinalDefault
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Groups
	{
		 get { } //Length: 8
	}

	[XmlAttribute("id", DataType = "ID")]
	public string Id
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlIgnore]
	internal virtual string IdAttribute
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints
	{
		internal get { } //Length: 8
	}

	[XmlIgnore]
	internal Hashtable Ids
	{
		internal get { } //Length: 8
	}

	internal ArrayList ImportedNamespaces
	{
		internal get { } //Length: 117
	}

	internal ArrayList ImportedSchemas
	{
		internal get { } //Length: 117
	}

	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	internal bool IsChameleon
	{
		internal get { } //Length: 8
		internal set { } //Length: 7
	}

	[XmlIgnore]
	internal bool IsCompiledBySet
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	[XmlIgnore]
	internal bool IsPreprocessed
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	[XmlIgnore]
	internal bool IsRedefined
	{
		internal get { } //Length: 5
		internal set { } //Length: 511
	}

	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	public XmlSchemaObjectCollection Items
	{
		 get { } //Length: 5
	}

	[XmlIgnore]
	public XmlSchemaObjectTable Notations
	{
		 get { } //Length: 8
	}

	[XmlIgnore]
	internal int SchemaId
	{
		internal get { } //Length: 106
	}

	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes
	{
		 get { } //Length: 117
	}

	[XmlAttribute("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	[XmlAttribute("version", DataType = "token")]
	public string Version
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	private static XmlSchema() { }

	public XmlSchema() { }

	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	internal XmlSchema Clone() { }

	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	internal XmlSchema DeepClone() { }

	public XmlSchemaForm get_AttributeFormDefault() { }

	public XmlSchemaObjectTable get_AttributeGroups() { }

	public XmlSchemaObjectTable get_Attributes() { }

	internal Uri get_BaseUri() { }

	public XmlSchemaDerivationMethod get_BlockDefault() { }

	internal XmlDocument get_Document() { }

	public XmlSchemaForm get_ElementFormDefault() { }

	public XmlSchemaObjectTable get_Elements() { }

	internal int get_ErrorCount() { }

	public XmlSchemaDerivationMethod get_FinalDefault() { }

	public XmlSchemaObjectTable get_Groups() { }

	public string get_Id() { }

	internal virtual string get_IdAttribute() { }

	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	internal Hashtable get_Ids() { }

	internal ArrayList get_ImportedNamespaces() { }

	internal ArrayList get_ImportedSchemas() { }

	public XmlSchemaObjectCollection get_Includes() { }

	internal bool get_IsChameleon() { }

	internal bool get_IsCompiledBySet() { }

	internal bool get_IsPreprocessed() { }

	internal bool get_IsRedefined() { }

	public XmlSchemaObjectCollection get_Items() { }

	public XmlSchemaObjectTable get_Notations() { }

	internal int get_SchemaId() { }

	public XmlSchemaObjectTable get_SchemaTypes() { }

	public string get_TargetNamespace() { }

	public string get_Version() { }

	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	internal void set_BaseUri(Uri value) { }

	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	public void set_ElementFormDefault(XmlSchemaForm value) { }

	internal void set_ErrorCount(int value) { }

	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	public void set_Id(string value) { }

	internal virtual void set_IdAttribute(string value) { }

	internal void set_IsChameleon(bool value) { }

	internal void set_IsCompiledBySet(bool value) { }

	internal void set_IsPreprocessed(bool value) { }

	internal void set_IsRedefined(bool value) { }

	public void set_TargetNamespace(string value) { }

	public void set_Version(string value) { }

	internal void SetIsCompiled(bool isCompiled) { }

	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

}

