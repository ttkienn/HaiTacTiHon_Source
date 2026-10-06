namespace System.Xml.Schema;

internal class BaseProcessor
{
	private XmlNameTable nameTable; //Field offset: 0x10
	private SchemaNames schemaNames; //Field offset: 0x18
	private ValidationEventHandler eventHandler; //Field offset: 0x20
	private XmlSchemaCompilationSettings compilationSettings; //Field offset: 0x28
	private int errorCount; //Field offset: 0x30
	private string NsXml; //Field offset: 0x38

	protected XmlSchemaCompilationSettings CompilationSettings
	{
		 get { } //Length: 5
	}

	protected ValidationEventHandler EventHandler
	{
		 get { } //Length: 5
	}

	protected bool HasErrors
	{
		 get { } //Length: 8
	}

	protected XmlNameTable NameTable
	{
		 get { } //Length: 5
	}

	protected SchemaNames SchemaNames
	{
		 get { } //Length: 123
	}

	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	public BaseProcessor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	protected ValidationEventHandler get_EventHandler() { }

	protected bool get_HasErrors() { }

	protected XmlNameTable get_NameTable() { }

	protected SchemaNames get_SchemaNames() { }

	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	protected void SendValidationEvent(string code, String[] args, Exception innerException, XmlSchemaObject source) { }

	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	protected void SendValidationEvent(XmlSchemaException e) { }

	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }

}

