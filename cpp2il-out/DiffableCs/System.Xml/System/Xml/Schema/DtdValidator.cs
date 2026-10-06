namespace System.Xml.Schema;

internal sealed class DtdValidator : BaseValidator
{
	private class NamespaceManager : XmlNamespaceManager
	{

		public NamespaceManager() { }

		public virtual string LookupNamespace(string prefix) { }

	}

	private static NamespaceManager namespaceManager; //Field offset: 0x0
	private HWStack validationStack; //Field offset: 0x80
	private Hashtable attPresence; //Field offset: 0x88
	private XmlQualifiedName name; //Field offset: 0x90
	private Hashtable IDs; //Field offset: 0x98
	private IdRefNode idRefListHead; //Field offset: 0xA0
	private bool processIdentityConstraints; //Field offset: 0xA8

	public virtual bool PreserveWhitespace
	{
		 get { } //Length: 59
	}

	private static DtdValidator() { }

	internal DtdValidator(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	internal void AddID(string name, object node) { }

	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	private void CheckForwardRefs() { }

	private void CheckValue(string value, SchemaAttDef attdef) { }

	public virtual void CompleteValidation() { }

	public virtual object FindId(string name) { }

	private bool GenEntity(XmlQualifiedName qname) { }

	public virtual bool get_PreserveWhitespace() { }

	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	private void Init() { }

	private bool MeetsStandAloneConstraint() { }

	private bool Pop() { }

	private void ProcessElement() { }

	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	private void Push(XmlQualifiedName elementName) { }

	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	public virtual void Validate() { }

	private void ValidateChildElement() { }

	private void ValidateElement() { }

	private void ValidateEndElement() { }

	private void ValidateEndStartElement() { }

	private void ValidatePIComment() { }

	private void ValidateStartElement() { }

}

