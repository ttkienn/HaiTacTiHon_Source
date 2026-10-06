namespace System.Xml.Serialization;

public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode
{
	private class WriteCallbackInfo
	{
		public Type Type; //Field offset: 0x10
		public string TypeName; //Field offset: 0x18
		public string TypeNs; //Field offset: 0x20
		public XmlSerializationWriteCallback Callback; //Field offset: 0x28

		public WriteCallbackInfo() { }

	}

	private ObjectIDGenerator idGenerator; //Field offset: 0x10
	private int qnameCount; //Field offset: 0x18
	private bool topLevelElement; //Field offset: 0x1C
	private ArrayList namespaces; //Field offset: 0x20
	private XmlWriter writer; //Field offset: 0x28
	private Queue referencedElements; //Field offset: 0x30
	private Hashtable callbacks; //Field offset: 0x38
	private Hashtable serializedObjects; //Field offset: 0x40

	protected XmlWriter Writer
	{
		 get { } //Length: 5
	}

	protected XmlSerializationWriter() { }

	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	private bool AlreadyQueued(object ob) { }

	private void CheckReferenceQueue() { }

	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	protected Exception CreateUnknownTypeException(object o) { }

	protected Exception CreateUnknownTypeException(Type type) { }

	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	protected XmlWriter get_Writer() { }

	private string GetId(object o, bool addToReferencesList) { }

	private string GetNamespacePrefix(string ns) { }

	private string GetQualifiedName(string name, string ns) { }

	protected abstract void InitCallbacks() { }

	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	private bool IsPrimitiveArray(TypeData td) { }

	protected void TopLevelElement() { }

	private void WriteArray(object o, TypeData td) { }

	protected void WriteAttribute(string localName, string ns, string value) { }

	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	protected void WriteElementString(string localName, string ns, string value) { }

	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	protected void WriteEndElement(object o) { }

	protected void WriteEndElement() { }

	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	protected void WriteNullTagEncoded(string name, string ns) { }

	protected void WriteNullTagLiteral(string name, string ns) { }

	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	protected void WriteReferencedElements() { }

	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	protected void WriteStartDocument() { }

	protected void WriteStartElement(string name, string ns) { }

	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	protected void WriteStartElement(string name, string ns, object o) { }

	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	protected void WriteValue(string value) { }

	protected void WriteXmlAttribute(XmlNode node, object container) { }

	private void WriteXmlNode(XmlNode node) { }

	protected void WriteXsiType(string name, string ns) { }

}

