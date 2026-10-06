namespace System.Xml;

internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private enum ParsingFunction
	{
		Read = 0,
		Init = 1,
		ParseDtdFromContext = 2,
		ResolveEntityInternally = 3,
		InReadBinaryContent = 4,
		ReaderClosed = 5,
		Error = 6,
		None = 7,
	}

	public class ValidationEventHandling : IValidationEventHandling
	{
		private XmlValidatingReaderImpl reader; //Field offset: 0x10
		private ValidationEventHandler eventHandler; //Field offset: 0x18

		private override object System.Xml.IValidationEventHandling.EventHandler
		{
			private get { } //Length: 5
		}

		internal ValidationEventHandling(XmlValidatingReaderImpl reader) { }

		internal void AddHandler(ValidationEventHandler handler) { }

		private override object System.Xml.IValidationEventHandling.get_EventHandler() { }

		private override void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	}

	private static XmlResolver s_tempResolver; //Field offset: 0x0
	private XmlReader coreReader; //Field offset: 0x10
	private XmlTextReaderImpl coreReaderImpl; //Field offset: 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; //Field offset: 0x20
	private ValidationType validationType; //Field offset: 0x28
	private BaseValidator validator; //Field offset: 0x30
	private XmlSchemaCollection schemaCollection; //Field offset: 0x38
	private bool processIdentityConstraints; //Field offset: 0x40
	private ParsingFunction parsingFunction; //Field offset: 0x44
	private ValidationEventHandling eventHandling; //Field offset: 0x48
	private XmlParserContext parserContext; //Field offset: 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; //Field offset: 0x58
	private XmlReader outerReader; //Field offset: 0x60

	public virtual int AttributeCount
	{
		 get { } //Length: 42
	}

	public virtual string BaseURI
	{
		 get { } //Length: 42
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		 get { } //Length: 42
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 42
	}

	public virtual bool EOF
	{
		 get { } //Length: 42
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 42
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 42
	}

	public override int LineNumber
	{
		 get { } //Length: 152
	}

	public override int LinePosition
	{
		 get { } //Length: 152
	}

	public virtual string LocalName
	{
		 get { } //Length: 42
	}

	public virtual string Name
	{
		 get { } //Length: 42
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 42
	}

	internal bool Namespaces
	{
		internal get { } //Length: 30
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 42
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 42
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 42
	}

	public virtual string Prefix
	{
		 get { } //Length: 42
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 42
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 55
	}

	internal XmlSchemaCollection Schemas
	{
		internal get { } //Length: 5
	}

	internal object SchemaTypeObject
	{
		internal set { } //Length: 30
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 204
	}

	internal bool StandAlone
	{
		internal get { } //Length: 30
	}

	internal object TypedValueObject
	{
		internal get { } //Length: 29
		internal set { } //Length: 30
	}

	internal ValidationType ValidationType
	{
		internal get { } //Length: 4
	}

	internal BaseValidator Validator
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public virtual string Value
	{
		 get { } //Length: 42
	}

	public virtual string XmlLang
	{
		 get { } //Length: 42
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 42
	}

	internal XmlValidatingReaderImpl(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	public virtual void Close() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	public virtual bool get_EOF() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	internal bool get_Namespaces() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	internal XmlSchemaCollection get_Schemas() { }

	public virtual XmlReaderSettings get_Settings() { }

	internal bool get_StandAlone() { }

	internal object get_TypedValueObject() { }

	internal ValidationType get_ValidationType() { }

	internal BaseValidator get_Validator() { }

	public virtual string get_Value() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(string localName, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	public virtual string GetAttribute(int i) { }

	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	private XmlResolver GetResolver() { }

	public override bool HasLineInfo() { }

	public virtual string LookupNamespace(string prefix) { }

	internal string LookupPrefix(string namespaceName) { }

	internal void MoveOffEntityReference() { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private void ParseDtdFromParserContext() { }

	private void ProcessCoreReaderEvent() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	public virtual string ReadString() { }

	public virtual void ResolveEntity() { }

	private void ResolveEntityInternally() { }

	internal void set_SchemaTypeObject(object value) { }

	internal void set_TypedValueObject(object value) { }

	internal void set_Validator(BaseValidator value) { }

	private void SetupValidation(ValidationType valType) { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	private void ValidateDtd() { }

}

