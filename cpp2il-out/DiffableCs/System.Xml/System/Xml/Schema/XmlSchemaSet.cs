namespace System.Xml.Schema;

public class XmlSchemaSet
{
	private XmlNameTable nameTable; //Field offset: 0x10
	private SchemaNames schemaNames; //Field offset: 0x18
	private SortedList schemas; //Field offset: 0x20
	private ValidationEventHandler internalEventHandler; //Field offset: 0x28
	private ValidationEventHandler eventHandler; //Field offset: 0x30
	private bool isCompiled; //Field offset: 0x38
	private Hashtable schemaLocations; //Field offset: 0x40
	private Hashtable chameleonSchemas; //Field offset: 0x48
	private Hashtable targetNamespaces; //Field offset: 0x50
	private bool compileAll; //Field offset: 0x58
	private SchemaInfo cachedCompiledInfo; //Field offset: 0x60
	private XmlReaderSettings readerSettings; //Field offset: 0x68
	private XmlSchema schemaForSchema; //Field offset: 0x70
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x78
	internal XmlSchemaObjectTable elements; //Field offset: 0x80
	internal XmlSchemaObjectTable attributes; //Field offset: 0x88
	internal XmlSchemaObjectTable schemaTypes; //Field offset: 0x90
	internal XmlSchemaObjectTable substitutionGroups; //Field offset: 0x98
	private XmlSchemaObjectTable typeExtensions; //Field offset: 0xA0
	private object internalSyncObject; //Field offset: 0xA8

	public event ValidationEventHandler ValidationEventHandler
	{
		 add { } //Length: 306
		 remove { } //Length: 184
	}

	public XmlSchemaCompilationSettings CompilationSettings
	{
		 get { } //Length: 5
		 set { } //Length: 13
	}

	internal SchemaInfo CompiledInfo
	{
		internal get { } //Length: 5
	}

	public int Count
	{
		 get { } //Length: 42
	}

	public XmlSchemaObjectTable GlobalAttributes
	{
		 get { } //Length: 117
	}

	public XmlSchemaObjectTable GlobalElements
	{
		 get { } //Length: 117
	}

	public XmlSchemaObjectTable GlobalTypes
	{
		 get { } //Length: 117
	}

	internal object InternalSyncObject
	{
		internal get { } //Length: 113
	}

	public bool IsCompiled
	{
		 get { } //Length: 5
	}

	internal XmlReaderSettings ReaderSettings
	{
		internal get { } //Length: 5
	}

	internal Hashtable SchemaLocations
	{
		internal get { } //Length: 5
	}

	internal SortedList SortedSchemas
	{
		internal get { } //Length: 5
	}

	internal XmlSchemaObjectTable SubstitutionGroups
	{
		internal get { } //Length: 117
	}

	internal XmlSchemaObjectTable TypeExtensions
	{
		internal get { } //Length: 117
	}

	public XmlResolver XmlResolver
	{
		 set { } //Length: 30
	}

	public XmlSchemaSet() { }

	public XmlSchemaSet(XmlNameTable nameTable) { }

	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	public XmlSchema Add(XmlSchema schema) { }

	public void Add(XmlSchemaSet schemas) { }

	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	private void AddSchemaToSet(XmlSchema schema) { }

	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	private void ClearTables() { }

	public void Compile() { }

	public bool Contains(string targetNamespace) { }

	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	public void CopyTo(XmlSchema[] schemas, int index) { }

	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	internal SchemaInfo get_CompiledInfo() { }

	public int get_Count() { }

	public XmlSchemaObjectTable get_GlobalAttributes() { }

	public XmlSchemaObjectTable get_GlobalElements() { }

	public XmlSchemaObjectTable get_GlobalTypes() { }

	internal object get_InternalSyncObject() { }

	public bool get_IsCompiled() { }

	internal XmlReaderSettings get_ReaderSettings() { }

	internal Hashtable get_SchemaLocations() { }

	internal SortedList get_SortedSchemas() { }

	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	internal XmlSchemaObjectTable get_TypeExtensions() { }

	internal ValidationEventHandler GetEventHandler() { }

	internal XmlResolver GetResolver() { }

	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	internal string GetTargetNamespace(XmlSchema schema) { }

	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	public XmlSchema Reprocess(XmlSchema schema) { }

	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	public ICollection Schemas(string targetNamespace) { }

	public ICollection Schemas() { }

	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	public void set_XmlResolver(XmlResolver value) { }

	private void VerifyTables() { }

}

