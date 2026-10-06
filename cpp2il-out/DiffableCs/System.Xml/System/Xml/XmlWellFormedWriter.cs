namespace System.Xml;

internal class XmlWellFormedWriter : XmlWriter
{
	private class AttributeValueCache
	{
		private class BufferChunk
		{
			internal Char[] buffer; //Field offset: 0x10
			internal int index; //Field offset: 0x18
			internal int count; //Field offset: 0x1C

			internal BufferChunk(Char[] buffer, int index, int count) { }

		}

		private class Item
		{
			internal ItemType type; //Field offset: 0x10
			internal object data; //Field offset: 0x18

			internal Item() { }

			internal void Set(ItemType type, object data) { }

		}

		private enum ItemType
		{
			EntityRef = 0,
			CharEntity = 1,
			SurrogateCharEntity = 2,
			Whitespace = 3,
			String = 4,
			StringChars = 5,
			Raw = 6,
			RawChars = 7,
			ValueString = 8,
		}

		private StringBuilder stringValue; //Field offset: 0x10
		private string singleStringValue; //Field offset: 0x18
		private Item[] items; //Field offset: 0x20
		private int firstItem; //Field offset: 0x28
		private int lastItem; //Field offset: 0x2C

		internal string StringValue
		{
			internal get { } //Length: 58
		}

		public AttributeValueCache() { }

		private void AddItem(ItemType type, object data) { }

		internal void Clear() { }

		internal string get_StringValue() { }

		internal void Replay(XmlWriter writer) { }

		private void StartComplexValue() { }

		internal void Trim() { }

		internal void WriteCharEntity(char ch) { }

		internal void WriteChars(Char[] buffer, int index, int count) { }

		internal void WriteEntityRef(string name) { }

		internal void WriteRaw(Char[] buffer, int index, int count) { }

		internal void WriteRaw(string data) { }

		internal void WriteString(string text) { }

		internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

		internal void WriteValue(string value) { }

		internal void WriteWhitespace(string ws) { }

	}

	private struct AttrName
	{
		internal string prefix; //Field offset: 0x0
		internal string namespaceUri; //Field offset: 0x8
		internal string localName; //Field offset: 0x10
		internal int prev; //Field offset: 0x18

		internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }

		internal void Set(string prefix, string localName, string namespaceUri) { }

	}

	private struct ElementScope
	{
		internal int prevNSTop; //Field offset: 0x0
		internal string prefix; //Field offset: 0x8
		internal string localName; //Field offset: 0x10
		internal string namespaceUri; //Field offset: 0x18
		internal XmlSpace xmlSpace; //Field offset: 0x20
		internal string xmlLang; //Field offset: 0x28

		internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

		internal void WriteEndElement(XmlRawWriter rawWriter) { }

		internal void WriteFullEndElement(XmlRawWriter rawWriter) { }

	}

	private struct Namespace
	{
		internal string prefix; //Field offset: 0x0
		internal string namespaceUri; //Field offset: 0x8
		internal NamespaceKind kind; //Field offset: 0x10
		internal int prevNsIndex; //Field offset: 0x14

		internal void Set(string prefix, string namespaceUri, NamespaceKind kind) { }

		internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }

	}

	private enum NamespaceKind
	{
		Written = 0,
		NeedToWrite = 1,
		Implied = 2,
		Special = 3,
	}

	private class NamespaceResolverProxy : IXmlNamespaceResolver
	{
		private XmlWellFormedWriter wfWriter; //Field offset: 0x10

		internal NamespaceResolverProxy(XmlWellFormedWriter wfWriter) { }

		private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

		private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

		private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	}

	private enum SpecialAttribute
	{
		No = 0,
		DefaultXmlns = 1,
		PrefixedXmlns = 2,
		XmlSpace = 3,
		XmlLang = 4,
	}

	private enum State
	{
		Start = 0,
		TopLevel = 1,
		Document = 2,
		Element = 3,
		Content = 4,
		B64Content = 5,
		B64Attribute = 6,
		AfterRootEle = 7,
		Attribute = 8,
		SpecialAttr = 9,
		EndDocument = 10,
		RootLevelAttr = 11,
		RootLevelSpecAttr = 12,
		RootLevelB64Attr = 13,
		AfterRootLevelAttr = 14,
		Closed = 15,
		Error = 16,
		StartContent = 101,
		StartContentEle = 102,
		StartContentB64 = 103,
		StartDoc = 104,
		StartDocEle = 106,
		EndAttrSEle = 107,
		EndAttrEEle = 108,
		EndAttrSCont = 109,
		EndAttrSAttr = 111,
		PostB64Cont = 112,
		PostB64Attr = 113,
		PostB64RootAttr = 114,
		StartFragEle = 115,
		StartFragCont = 116,
		StartFragB64 = 117,
		StartRootLevelAttr = 118,
	}

	private enum Token
	{
		StartDocument = 0,
		EndDocument = 1,
		PI = 2,
		Comment = 3,
		Dtd = 4,
		StartElement = 5,
		EndElement = 6,
		StartAttribute = 7,
		EndAttribute = 8,
		Text = 9,
		CData = 10,
		AtomicValue = 11,
		Base64 = 12,
		RawData = 13,
		Whitespace = 14,
	}

	internal static readonly String[] stateName; //Field offset: 0x0
	internal static readonly String[] tokenName; //Field offset: 0x8
	private static WriteState[] state2WriteState; //Field offset: 0x10
	private static readonly State[] StateTableDocument; //Field offset: 0x18
	private static readonly State[] StateTableAuto; //Field offset: 0x20
	private XmlWriter writer; //Field offset: 0x18
	private XmlRawWriter rawWriter; //Field offset: 0x20
	private IXmlNamespaceResolver predefinedNamespaces; //Field offset: 0x28
	private Namespace[] nsStack; //Field offset: 0x30
	private int nsTop; //Field offset: 0x38
	private Dictionary<String, Int32> nsHashtable; //Field offset: 0x40
	private bool useNsHashtable; //Field offset: 0x48
	private ElementScope[] elemScopeStack; //Field offset: 0x50
	private int elemTop; //Field offset: 0x58
	private AttrName[] attrStack; //Field offset: 0x60
	private int attrCount; //Field offset: 0x68
	private Dictionary<String, Int32> attrHashTable; //Field offset: 0x70
	private SpecialAttribute specAttr; //Field offset: 0x78
	private AttributeValueCache attrValueCache; //Field offset: 0x80
	private string curDeclPrefix; //Field offset: 0x88
	private State[] stateTable; //Field offset: 0x90
	private State currentState; //Field offset: 0x98
	private bool checkCharacters; //Field offset: 0x9C
	private bool omitDuplNamespaces; //Field offset: 0x9D
	private bool writeEndDocumentOnClose; //Field offset: 0x9E
	private ConformanceLevel conformanceLevel; //Field offset: 0xA0
	private bool dtdWritten; //Field offset: 0xA4
	private bool xmlDeclFollows; //Field offset: 0xA5
	private XmlCharType xmlCharType; //Field offset: 0xA8
	private SecureStringHasher hasher; //Field offset: 0xB0

	private bool InBase64
	{
		private get { } //Length: 32
	}

	private bool IsClosedOrErrorState
	{
		private get { } //Length: 11
	}

	internal XmlRawWriter RawWriter
	{
		internal get { } //Length: 5
	}

	private bool SaveAttrValue
	{
		private get { } //Length: 8
	}

	public virtual WriteState WriteState
	{
		 get { } //Length: 137
	}

	private static XmlWellFormedWriter() { }

	internal XmlWellFormedWriter(XmlWriter writer, XmlWriterSettings settings) { }

	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	private void AddNamespace(string prefix, string ns, NamespaceKind kind) { }

	private void AddToAttrHashTable(int attributeIndex) { }

	private void AddToNamespaceHashtable(int namespaceIndex) { }

	private void AdvanceState(Token token) { }

	private void CheckNCName(string ncname) { }

	public virtual void Close() { }

	private static XmlException DupAttrException(string prefix, string localName) { }

	public virtual void Flush() { }

	private string GeneratePrefix() { }

	private bool get_InBase64() { }

	private bool get_IsClosedOrErrorState() { }

	internal XmlRawWriter get_RawWriter() { }

	private bool get_SaveAttrValue() { }

	public virtual WriteState get_WriteState() { }

	private static string GetStateName(State state) { }

	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	private string LookupLocalNamespace(string prefix) { }

	internal string LookupNamespace(string prefix) { }

	private int LookupNamespaceIndex(string prefix) { }

	public virtual string LookupPrefix(string ns) { }

	private void PopNamespaces(int indexFrom, int indexTo) { }

	private bool PushNamespaceExplicit(string prefix, string ns) { }

	private void PushNamespaceImplicit(string prefix, string ns) { }

	private void SetSpecialAttribute(SpecialAttribute special) { }

	private void StartElementContent() { }

	private void StartFragment() { }

	private void ThrowInvalidStateTransition(Token token, State currentState) { }

	public virtual void WriteBase64(Byte[] buffer, int index, int count) { }

	public virtual void WriteBinHex(Byte[] buffer, int index, int count) { }

	public virtual void WriteCData(string text) { }

	public virtual void WriteCharEntity(char ch) { }

	public virtual void WriteChars(Char[] buffer, int index, int count) { }

	public virtual void WriteComment(string text) { }

	public virtual void WriteDocType(string name, string pubid, string sysid, string subset) { }

	public virtual void WriteEndAttribute() { }

	public virtual void WriteEndDocument() { }

	public virtual void WriteEndElement() { }

	public virtual void WriteEntityRef(string name) { }

	public virtual void WriteFullEndElement() { }

	public virtual void WriteProcessingInstruction(string name, string text) { }

	public virtual void WriteRaw(string data) { }

	public virtual void WriteRaw(Char[] buffer, int index, int count) { }

	public virtual void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	public virtual void WriteStartDocument() { }

	public virtual void WriteStartDocument(bool standalone) { }

	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	public virtual void WriteStartElement(string prefix, string localName, string ns) { }

	public virtual void WriteString(string text) { }

	public virtual void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	public virtual void WriteValue(string value) { }

	public virtual void WriteWhitespace(string ws) { }

}

