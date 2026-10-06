namespace System.Xml;

internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
{
	private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<Object>
	{
		private static IComparer<Object> s_instance; //Field offset: 0x0

		internal static IComparer<Object> Instance
		{
			internal get { } //Length: 78
		}

		private static DtdDefaultAttributeInfoToNodeDataComparer() { }

		public DtdDefaultAttributeInfoToNodeDataComparer() { }

		public override int Compare(object x, object y) { }

		internal static IComparer<Object> get_Instance() { }

	}

	public class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		private XmlTextReaderImpl reader; //Field offset: 0x10

		private override Uri System.Xml.IDtdParserAdapter.BaseUri
		{
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.CurrentPosition
		{
			private get { } //Length: 29
			private set { } //Length: 30
		}

		private override int System.Xml.IDtdParserAdapter.EntityStackLength
		{
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
		{
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapter.IsEof
		{
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.LineNo
		{
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.LineStartPosition
		{
			private get { } //Length: 29
		}

		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
		{
			private get { } //Length: 30
		}

		private override XmlNameTable System.Xml.IDtdParserAdapter.NameTable
		{
			private get { } //Length: 30
		}

		private override Char[] System.Xml.IDtdParserAdapter.ParsingBuffer
		{
			private get { } //Length: 29
		}

		private override int System.Xml.IDtdParserAdapter.ParsingBufferLength
		{
			private get { } //Length: 29
		}

		private override bool System.Xml.IDtdParserAdapterV1.Namespaces
		{
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterV1.Normalization
		{
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
		{
			private get { } //Length: 30
		}

		private override bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
		{
			private get { } //Length: 29
		}

		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
		{
			private get { } //Length: 30
		}

		internal DtdParserProxy(XmlTextReaderImpl reader) { }

		private override Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

		private override int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

		private override int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

		private override bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

		private override bool System.Xml.IDtdParserAdapter.get_IsEof() { }

		private override int System.Xml.IDtdParserAdapter.get_LineNo() { }

		private override int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

		private override IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

		private override XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

		private override Char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

		private override int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

		private override void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

		private override void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

		private override void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

		private override void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

		private override int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

		private override int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

		private override void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

		private override bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

		private override bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

		private override bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

		private override void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

		private override int System.Xml.IDtdParserAdapter.ReadData() { }

		private override void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

		private override void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

		private override bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

		private override bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

		private override bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }

		private override bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

		private override IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	}

	private enum EntityExpandType
	{
		All = 0,
		OnlyGeneral = 1,
		OnlyCharacter = 2,
	}

	private enum EntityType
	{
		CharacterDec = 0,
		CharacterHex = 1,
		CharacterNamed = 2,
		Expanded = 3,
		Skipped = 4,
		FakeExpanded = 5,
		Unexpanded = 6,
		ExpandedInAttribute = 7,
	}

	private enum IncrementalReadState
	{
		Text = 0,
		StartTag = 1,
		PI = 2,
		CDATA = 3,
		Comment = 4,
		Attributes = 5,
		AttributeValue = 6,
		ReadData = 7,
		EndElement = 8,
		End = 9,
		ReadValueChunk_OnCachedValue = 10,
		ReadValueChunk_OnPartialValue = 11,
		ReadContentAsBinary_OnCachedValue = 12,
		ReadContentAsBinary_OnPartialValue = 13,
		ReadContentAsBinary_End = 14,
	}

	private enum InitInputType
	{
		UriString = 0,
		Stream = 1,
		TextReader = 2,
		Invalid = 3,
	}

	private class LaterInitParam
	{
		public bool useAsync; //Field offset: 0x10
		public Stream inputStream; //Field offset: 0x18
		public Byte[] inputBytes; //Field offset: 0x20
		public int inputByteCount; //Field offset: 0x28
		public Uri inputbaseUri; //Field offset: 0x30
		public string inputUriStr; //Field offset: 0x38
		public XmlResolver inputUriResolver; //Field offset: 0x40
		public XmlParserContext inputContext; //Field offset: 0x48
		public TextReader inputTextReader; //Field offset: 0x50
		public InitInputType initType; //Field offset: 0x58

		public LaterInitParam() { }

	}

	private class NodeData : IComparable
	{
		private static NodeData s_None; //Field offset: 0x0
		internal XmlNodeType type; //Field offset: 0x10
		internal string localName; //Field offset: 0x18
		internal string prefix; //Field offset: 0x20
		internal string ns; //Field offset: 0x28
		internal string nameWPrefix; //Field offset: 0x30
		private string value; //Field offset: 0x38
		private Char[] chars; //Field offset: 0x40
		private int valueStartPos; //Field offset: 0x48
		private int valueLength; //Field offset: 0x4C
		internal LineInfo lineInfo; //Field offset: 0x50
		internal LineInfo lineInfo2; //Field offset: 0x58
		internal char quoteChar; //Field offset: 0x60
		internal int depth; //Field offset: 0x64
		private bool isEmptyOrDefault; //Field offset: 0x68
		internal int entityId; //Field offset: 0x6C
		internal bool xmlContextPushed; //Field offset: 0x70
		internal NodeData nextAttrValueChunk; //Field offset: 0x78
		internal object schemaType; //Field offset: 0x80
		internal object typedValue; //Field offset: 0x88

		internal bool IsDefaultAttribute
		{
			internal get { } //Length: 14
			internal set { } //Length: 4
		}

		internal bool IsEmptyElement
		{
			internal get { } //Length: 14
			internal set { } //Length: 4
		}

		internal int LineNo
		{
			internal get { } //Length: 4
		}

		internal int LinePos
		{
			internal get { } //Length: 4
		}

		internal static NodeData None
		{
			internal get { } //Length: 331
		}

		internal string StringValue
		{
			internal get { } //Length: 80
		}

		internal bool ValueBuffered
		{
			internal get { } //Length: 9
		}

		internal NodeData() { }

		internal void Clear(XmlNodeType type) { }

		internal void ClearName() { }

		internal int CopyTo(int valueOffset, Char[] buffer, int offset, int length) { }

		internal void CopyTo(int valueOffset, StringBuilder sb) { }

		internal string CreateNameWPrefix(XmlNameTable nt) { }

		internal bool get_IsDefaultAttribute() { }

		internal bool get_IsEmptyElement() { }

		internal int get_LineNo() { }

		internal int get_LinePos() { }

		internal static NodeData get_None() { }

		internal string get_StringValue() { }

		internal bool get_ValueBuffered() { }

		internal string GetNameWPrefix(XmlNameTable nt) { }

		internal void OnBufferInvalidated() { }

		internal void set_IsDefaultAttribute(bool value) { }

		internal void set_IsEmptyElement(bool value) { }

		internal void SetLineInfo(int lineNo, int linePos) { }

		internal void SetLineInfo2(int lineNo, int linePos) { }

		internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

		internal void SetNamedNode(XmlNodeType type, string localName) { }

		internal void SetValue(string value) { }

		internal void SetValue(Char[] chars, int startPos, int len) { }

		internal void SetValueNode(XmlNodeType type, Char[] chars, int startPos, int len) { }

		internal void SetValueNode(XmlNodeType type, string value) { }

		private override int System.IComparable.CompareTo(object obj) { }

		internal void TrimSpacesInValue() { }

	}

	private class NoNamespaceManager : XmlNamespaceManager
	{

		public virtual string DefaultNamespace
		{
			 get { } //Length: 54
		}

		public NoNamespaceManager() { }

		public virtual void AddNamespace(string prefix, string uri) { }

		public virtual string get_DefaultNamespace() { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

		public virtual string LookupNamespace(string prefix) { }

		public virtual string LookupPrefix(string uri) { }

		public virtual bool PopScope() { }

		public virtual void PushScope() { }

		public virtual void RemoveNamespace(string prefix, string uri) { }

	}

	public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
	{

		public OnDefaultAttributeUseDelegate(object object, IntPtr method) { }

		public override void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }

	}

	private enum ParsingFunction
	{
		ElementContent = 0,
		NoData = 1,
		OpenUrl = 2,
		SwitchToInteractive = 3,
		SwitchToInteractiveXmlDecl = 4,
		DocumentContent = 5,
		MoveToElementContent = 6,
		PopElementContext = 7,
		PopEmptyElementContext = 8,
		ResetAttributesRootLevel = 9,
		Error = 10,
		Eof = 11,
		ReaderClosed = 12,
		EntityReference = 13,
		InIncrementalRead = 14,
		FragmentAttribute = 15,
		ReportEndEntity = 16,
		AfterResolveEntityInContent = 17,
		AfterResolveEmptyEntityInContent = 18,
		XmlDeclarationFragment = 19,
		GoToEof = 20,
		PartialTextValue = 21,
		InReadAttributeValue = 22,
		InReadValueChunk = 23,
		InReadContentAsBinary = 24,
		InReadElementContentAsBinary = 25,
	}

	private enum ParsingMode
	{
		Full = 0,
		SkipNode = 1,
		SkipContent = 2,
	}

	private struct ParsingState
	{
		internal Char[] chars; //Field offset: 0x0
		internal int charPos; //Field offset: 0x8
		internal int charsUsed; //Field offset: 0xC
		internal Encoding encoding; //Field offset: 0x10
		internal bool appendMode; //Field offset: 0x18
		internal Stream stream; //Field offset: 0x20
		internal Decoder decoder; //Field offset: 0x28
		internal Byte[] bytes; //Field offset: 0x30
		internal int bytePos; //Field offset: 0x38
		internal int bytesUsed; //Field offset: 0x3C
		internal TextReader textReader; //Field offset: 0x40
		internal int lineNo; //Field offset: 0x48
		internal int lineStartPos; //Field offset: 0x4C
		internal string baseUriStr; //Field offset: 0x50
		internal Uri baseUri; //Field offset: 0x58
		internal bool isEof; //Field offset: 0x60
		internal bool isStreamEof; //Field offset: 0x61
		internal IDtdEntityInfo entity; //Field offset: 0x68
		internal int entityId; //Field offset: 0x70
		internal bool eolNormalized; //Field offset: 0x74
		internal bool entityResolvedManually; //Field offset: 0x75

		internal int LineNo
		{
			internal get { } //Length: 4
		}

		internal int LinePos
		{
			internal get { } //Length: 7
		}

		internal void Clear() { }

		internal void Close(bool closeInput) { }

		internal int get_LineNo() { }

		internal int get_LinePos() { }

	}

	private class XmlContext
	{
		internal XmlSpace xmlSpace; //Field offset: 0x10
		internal string xmlLang; //Field offset: 0x18
		internal string defaultNamespace; //Field offset: 0x20
		internal XmlContext previousContext; //Field offset: 0x28

		internal XmlContext() { }

		internal XmlContext(XmlContext previousContext) { }

	}

	private readonly bool useAsync; //Field offset: 0x10
	private LaterInitParam laterInitParam; //Field offset: 0x18
	private XmlCharType xmlCharType; //Field offset: 0x20
	private ParsingState ps; //Field offset: 0x28
	private ParsingFunction parsingFunction; //Field offset: 0xA0
	private ParsingFunction nextParsingFunction; //Field offset: 0xA4
	private ParsingFunction nextNextParsingFunction; //Field offset: 0xA8
	private NodeData[] nodes; //Field offset: 0xB0
	private NodeData curNode; //Field offset: 0xB8
	private int index; //Field offset: 0xC0
	private int curAttrIndex; //Field offset: 0xC4
	private int attrCount; //Field offset: 0xC8
	private int attrHashtable; //Field offset: 0xCC
	private int attrDuplWalkCount; //Field offset: 0xD0
	private bool attrNeedNamespaceLookup; //Field offset: 0xD4
	private bool fullAttrCleanup; //Field offset: 0xD5
	private NodeData[] attrDuplSortingArray; //Field offset: 0xD8
	private XmlNameTable nameTable; //Field offset: 0xE0
	private bool nameTableFromSettings; //Field offset: 0xE8
	private XmlResolver xmlResolver; //Field offset: 0xF0
	private string url; //Field offset: 0xF8
	private bool normalize; //Field offset: 0x100
	private bool supportNamespaces; //Field offset: 0x101
	private WhitespaceHandling whitespaceHandling; //Field offset: 0x104
	private DtdProcessing dtdProcessing; //Field offset: 0x108
	private EntityHandling entityHandling; //Field offset: 0x10C
	private bool ignorePIs; //Field offset: 0x110
	private bool ignoreComments; //Field offset: 0x111
	private bool checkCharacters; //Field offset: 0x112
	private int lineNumberOffset; //Field offset: 0x114
	private int linePositionOffset; //Field offset: 0x118
	private bool closeInput; //Field offset: 0x11C
	private long maxCharactersInDocument; //Field offset: 0x120
	private long maxCharactersFromEntities; //Field offset: 0x128
	private bool v1Compat; //Field offset: 0x130
	private XmlNamespaceManager namespaceManager; //Field offset: 0x138
	private string lastPrefix; //Field offset: 0x140
	private XmlContext xmlContext; //Field offset: 0x148
	private ParsingState[] parsingStatesStack; //Field offset: 0x150
	private int parsingStatesStackTop; //Field offset: 0x158
	private string reportedBaseUri; //Field offset: 0x160
	private Encoding reportedEncoding; //Field offset: 0x168
	private IDtdInfo dtdInfo; //Field offset: 0x170
	private XmlNodeType fragmentType; //Field offset: 0x178
	private XmlParserContext fragmentParserContext; //Field offset: 0x180
	private bool fragment; //Field offset: 0x188
	private IncrementalReadDecoder incReadDecoder; //Field offset: 0x190
	private IncrementalReadState incReadState; //Field offset: 0x198
	private LineInfo incReadLineInfo; //Field offset: 0x19C
	private int incReadDepth; //Field offset: 0x1A4
	private int incReadLeftStartPos; //Field offset: 0x1A8
	private int incReadLeftEndPos; //Field offset: 0x1AC
	private int attributeValueBaseEntityId; //Field offset: 0x1B0
	private bool emptyEntityInAttributeResolved; //Field offset: 0x1B4
	private IValidationEventHandling validationEventHandling; //Field offset: 0x1B8
	private OnDefaultAttributeUseDelegate onDefaultAttributeUse; //Field offset: 0x1C0
	private bool validatingReaderCompatFlag; //Field offset: 0x1C8
	private bool addDefaultAttributesAndNormalize; //Field offset: 0x1C9
	private StringBuilder stringBuilder; //Field offset: 0x1D0
	private bool rootElementParsed; //Field offset: 0x1D8
	private bool standalone; //Field offset: 0x1D9
	private int nextEntityId; //Field offset: 0x1DC
	private ParsingMode parsingMode; //Field offset: 0x1E0
	private ReadState readState; //Field offset: 0x1E4
	private IDtdEntityInfo lastEntity; //Field offset: 0x1E8
	private bool afterResetState; //Field offset: 0x1F0
	private int documentStartBytePos; //Field offset: 0x1F4
	private int readValueOffset; //Field offset: 0x1F8
	private long charactersInDocument; //Field offset: 0x200
	private long charactersFromEntities; //Field offset: 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; //Field offset: 0x210
	private bool disableUndeclaredEntityCheck; //Field offset: 0x218
	private XmlReader outerReader; //Field offset: 0x220
	private bool xmlResolverIsSet; //Field offset: 0x228
	private string Xml; //Field offset: 0x230
	private string XmlNs; //Field offset: 0x238
	private Task<Tuple`4<Int32, Int32, Int32, Boolean>> parseText_dummyTask; //Field offset: 0x240

	public virtual int AttributeCount
	{
		 get { } //Length: 7
	}

	public virtual string BaseURI
	{
		 get { } //Length: 8
	}

	public virtual bool CanReadValueChunk
	{
		 get { } //Length: 3
	}

	public virtual bool CanResolveEntity
	{
		 get { } //Length: 3
	}

	public virtual int Depth
	{
		 get { } //Length: 29
	}

	internal bool DisableUndeclaredEntityCheck
	{
		internal set { } //Length: 7
	}

	internal virtual IDtdInfo DtdInfo
	{
		internal get { } //Length: 8
	}

	internal Uri DtdParserProxy_BaseUri
	{
		internal get { } //Length: 193
	}

	internal int DtdParserProxy_CurrentPosition
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal bool DtdParserProxy_DtdValidation
	{
		internal get { } //Length: 12
	}

	internal int DtdParserProxy_EntityStackLength
	{
		internal get { } //Length: 9
	}

	internal bool DtdParserProxy_IsEntityEolNormalized
	{
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_IsEof
	{
		internal get { } //Length: 8
	}

	internal int DtdParserProxy_LineNo
	{
		internal get { } //Length: 4
	}

	internal int DtdParserProxy_LineStartPosition
	{
		internal get { } //Length: 4
	}

	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
	{
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_Namespaces
	{
		internal get { } //Length: 8
	}

	internal XmlNameTable DtdParserProxy_NameTable
	{
		internal get { } //Length: 8
	}

	internal bool DtdParserProxy_Normalization
	{
		internal get { } //Length: 8
	}

	internal Char[] DtdParserProxy_ParsingBuffer
	{
		internal get { } //Length: 5
	}

	internal int DtdParserProxy_ParsingBufferLength
	{
		internal get { } //Length: 4
	}

	internal bool DtdParserProxy_V1CompatibilityMode
	{
		internal get { } //Length: 8
	}

	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
	{
		internal get { } //Length: 8
	}

	private bool DtdValidation
	{
		private get { } //Length: 12
	}

	internal EntityHandling EntityHandling
	{
		internal set { } //Length: 141
	}

	public virtual bool EOF
	{
		 get { } //Length: 11
	}

	internal XmlNodeType FragmentType
	{
		internal get { } //Length: 7
	}

	private bool InAttributeValueIterator
	{
		private get { } //Length: 23
	}

	private bool InEntity
	{
		private get { } //Length: 12
	}

	internal object InternalSchemaType
	{
		internal set { } //Length: 41
	}

	internal object InternalTypedValue
	{
		internal get { } //Length: 33
		internal set { } //Length: 44
	}

	public virtual bool IsDefault
	{
		 get { } //Length: 32
	}

	public virtual bool IsEmptyElement
	{
		 get { } //Length: 32
	}

	private bool IsResolverNull
	{
		private get { } //Length: 60
	}

	internal bool IsResolverSet
	{
		internal get { } //Length: 8
	}

	public override int LineNumber
	{
		 get { } //Length: 32
	}

	public override int LinePosition
	{
		 get { } //Length: 32
	}

	public virtual string LocalName
	{
		 get { } //Length: 30
	}

	public virtual string Name
	{
		 get { } //Length: 43
	}

	internal virtual XmlNamespaceManager NamespaceManager
	{
		internal get { } //Length: 8
	}

	internal bool Namespaces
	{
		internal get { } //Length: 8
		internal set { } //Length: 596
	}

	public virtual string NamespaceURI
	{
		 get { } //Length: 30
	}

	public virtual XmlNameTable NameTable
	{
		 get { } //Length: 8
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 29
	}

	internal bool Normalization
	{
		internal get { } //Length: 8
		internal set { } //Length: 205
	}

	internal OnDefaultAttributeUseDelegate OnDefaultAttributeUse
	{
		internal set { } //Length: 19
	}

	internal XmlReader OuterReader
	{
		internal set { } //Length: 19
	}

	public virtual string Prefix
	{
		 get { } //Length: 30
	}

	public virtual char QuoteChar
	{
		 get { } //Length: 46
	}

	public virtual ReadState ReadState
	{
		 get { } //Length: 7
	}

	public virtual XmlReaderSettings Settings
	{
		 get { } //Length: 387
	}

	internal bool StandAlone
	{
		internal get { } //Length: 8
	}

	internal bool V1Compat
	{
		internal get { } //Length: 8
	}

	internal IValidationEventHandling ValidationEventHandling
	{
		internal set { } //Length: 19
	}

	public virtual string Value
	{
		 get { } //Length: 353
	}

	internal WhitespaceHandling WhitespaceHandling
	{
		internal set { } //Length: 225
	}

	public virtual string XmlLang
	{
		 get { } //Length: 30
	}

	internal XmlResolver XmlResolver
	{
		internal set { } //Length: 173
	}

	public virtual XmlSpace XmlSpace
	{
		 get { } //Length: 29
	}

	internal bool XmlValidatingReaderCompatibilityMode
	{
		internal set { } //Length: 670
	}

	internal XmlTextReaderImpl(XmlNameTable nt) { }

	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	internal XmlTextReaderImpl(Stream stream, Byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context) { }

	internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt) { }

	internal XmlTextReaderImpl(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	internal XmlTextReaderImpl(TextReader input) { }

	internal XmlTextReaderImpl(string url, Stream input, XmlNameTable nt) { }

	internal XmlTextReaderImpl(Stream input) { }

	private XmlTextReaderImpl(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	internal XmlTextReaderImpl(TextReader input, XmlNameTable nt) { }

	private NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	private NodeData AddAttribute(int endNamePos, int colonPos) { }

	private void AddAttributeChunkToList(NodeData attr, NodeData chunk, ref NodeData lastChunk) { }

	private NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, NodeData[] nameSortedNodeData) { }

	private NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	private void AddDefaultAttributesAndNormalize() { }

	private void AddNamespace(string prefix, string uri, NodeData attr) { }

	private NodeData AddNode(int nodeIndex, int nodeDepth) { }

	private NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	private void AttributeDuplCheck() { }

	private void AttributeNamespaceLookup() { }

	internal static void BlockCopy(Byte[] src, int srcOffset, Byte[] dst, int dstOffset, int count) { }

	internal static void BlockCopyChars(Char[] src, int srcOffset, Char[] dst, int dstOffset, int count) { }

	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	private Encoding CheckEncoding(string newEncodingName) { }

	internal void Close(bool closeInput) { }

	public virtual void Close() { }

	private Encoding DetectEncoding() { }

	internal void DtdParserProxy_OnNewLine(int pos) { }

	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	internal int DtdParserProxy_ReadData() { }

	internal void DtdParserProxy_Throw(Exception e) { }

	private int EatWhitespaces(StringBuilder sb) { }

	private void ElementNamespaceLookup() { }

	private void FinishAttributeValueIterator() { }

	private void FinishIncrementalRead() { }

	private void FinishInit() { }

	private void FinishInitStream() { }

	private void FinishInitTextReader() { }

	private void FinishInitUriString() { }

	private void FinishOtherValueIterator() { }

	private void FinishPartialValue() { }

	private void FinishReadContentAsBinary() { }

	private void FinishReadElementContentAsBinary() { }

	private void FinishReadValueChunk() { }

	private void FullAttributeCleanup() { }

	public virtual int get_AttributeCount() { }

	public virtual string get_BaseURI() { }

	public virtual bool get_CanReadValueChunk() { }

	public virtual bool get_CanResolveEntity() { }

	public virtual int get_Depth() { }

	internal virtual IDtdInfo get_DtdInfo() { }

	internal Uri get_DtdParserProxy_BaseUri() { }

	internal int get_DtdParserProxy_CurrentPosition() { }

	internal bool get_DtdParserProxy_DtdValidation() { }

	internal int get_DtdParserProxy_EntityStackLength() { }

	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	internal bool get_DtdParserProxy_IsEof() { }

	internal int get_DtdParserProxy_LineNo() { }

	internal int get_DtdParserProxy_LineStartPosition() { }

	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	internal bool get_DtdParserProxy_Namespaces() { }

	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	internal bool get_DtdParserProxy_Normalization() { }

	internal Char[] get_DtdParserProxy_ParsingBuffer() { }

	internal int get_DtdParserProxy_ParsingBufferLength() { }

	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	private bool get_DtdValidation() { }

	public virtual bool get_EOF() { }

	internal XmlNodeType get_FragmentType() { }

	private bool get_InAttributeValueIterator() { }

	private bool get_InEntity() { }

	internal object get_InternalTypedValue() { }

	public virtual bool get_IsDefault() { }

	public virtual bool get_IsEmptyElement() { }

	private bool get_IsResolverNull() { }

	internal bool get_IsResolverSet() { }

	public override int get_LineNumber() { }

	public override int get_LinePosition() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	internal bool get_Namespaces() { }

	public virtual string get_NamespaceURI() { }

	public virtual XmlNameTable get_NameTable() { }

	public virtual XmlNodeType get_NodeType() { }

	internal bool get_Normalization() { }

	public virtual string get_Prefix() { }

	public virtual char get_QuoteChar() { }

	public virtual ReadState get_ReadState() { }

	public virtual XmlReaderSettings get_Settings() { }

	internal bool get_StandAlone() { }

	internal bool get_V1Compat() { }

	public virtual string get_Value() { }

	public virtual string get_XmlLang() { }

	public virtual XmlSpace get_XmlSpace() { }

	public virtual string GetAttribute(int i) { }

	public virtual string GetAttribute(string localName, string namespaceURI) { }

	public virtual string GetAttribute(string name) { }

	private int GetChars(int maxCharsCount) { }

	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	private int GetIndexOfAttributeWithPrefix(string name) { }

	internal IDictionary<String, String> GetNamespacesInScope(XmlNamespaceScope scope) { }

	internal XmlResolver GetResolver() { }

	private XmlResolver GetTempResolver() { }

	private XmlNodeType GetTextNodeType(int orChars) { }

	private XmlNodeType GetWhitespaceType() { }

	private bool HandleEntityEnd(bool checkEntityNesting) { }

	private EntityType HandleEntityReference(bool isInAttributeValue, EntityExpandType expandType, out int charRefEndPos) { }

	private EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	public override bool HasLineInfo() { }

	private int IncrementalRead() { }

	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Byte[] bytes, int byteCount, Encoding encoding) { }

	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	private void InitStreamInput(Stream stream, Encoding encoding) { }

	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	private string LookupNamespace(NodeData node) { }

	public virtual string LookupNamespace(string prefix) { }

	internal string LookupPrefix(string namespaceName) { }

	internal void MoveOffEntityReference() { }

	public virtual void MoveToAttribute(int i) { }

	public virtual bool MoveToAttribute(string name) { }

	public virtual bool MoveToElement() { }

	public virtual bool MoveToFirstAttribute() { }

	public virtual bool MoveToNextAttribute() { }

	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	private void OnDefaultNamespaceDecl(NodeData attr) { }

	private void OnEof() { }

	private void OnNamespaceDecl(NodeData attr) { }

	private void OnNewLine(int pos) { }

	private void OnXmlReservedAttribute(NodeData attr) { }

	private bool OpenAndPush(Uri uri) { }

	private void OpenUrl() { }

	private void OpenUrlDelegate(object xmlResolver) { }

	private void ParseAttributes() { }

	private bool ParseAttributeValueChunk() { }

	private void ParseAttributeValueSlow(int curPos, char quoteChar, NodeData attr) { }

	private void ParseCData() { }

	private void ParseCDataOrComment(XmlNodeType type) { }

	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	private int ParseCharRefInline(int startPos, out int charCount, out EntityType entityType) { }

	private bool ParseComment() { }

	private bool ParseDoctypeDecl() { }

	private bool ParseDocumentContent() { }

	private void ParseDtd() { }

	private void ParseDtdFromParserContext() { }

	private void ParseElement() { }

	private bool ParseElementContent() { }

	private void ParseEndElement() { }

	private string ParseEntityName() { }

	private void ParseEntityReference() { }

	private bool ParseFragmentAttribute() { }

	private int ParseName() { }

	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out EntityType entityType) { }

	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out EntityType entityType) { }

	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	private bool ParsePI() { }

	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	private int ParseQName(out int colonPos) { }

	private bool ParseRootLevelWhitespace() { }

	private bool ParseText() { }

	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	private string ParseUnexpectedToken(int pos) { }

	private string ParseUnexpectedToken() { }

	private bool ParseXmlDeclaration(bool isTextDecl) { }

	private void ParseXmlDeclarationFragment() { }

	private void PopElementContext() { }

	private void PopEntity() { }

	private void PopParsingState() { }

	private void PopXmlContext() { }

	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	private void PushInternalEntity(IDtdEntityInfo entity) { }

	private void PushParsingState() { }

	private void PushXmlContext() { }

	public virtual bool Read() { }

	public virtual bool ReadAttributeValue() { }

	private int ReadData() { }

	private bool ReadDataInName(ref int pos) { }

	public virtual string ReadString() { }

	public virtual int ReadValueChunk(Char[] buffer, int index, int count) { }

	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	private void RegisterEntity(IDtdEntityInfo entity) { }

	private void ResetAttributes() { }

	public virtual void ResolveEntity() { }

	private void ReThrow(Exception e, int lineNo, int linePos) { }

	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	internal void set_EntityHandling(EntityHandling value) { }

	internal void set_InternalSchemaType(object value) { }

	internal void set_InternalTypedValue(object value) { }

	internal void set_Namespaces(bool value) { }

	internal void set_Normalization(bool value) { }

	internal void set_OnDefaultAttributeUse(OnDefaultAttributeUseDelegate value) { }

	internal void set_OuterReader(XmlReader value) { }

	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	internal void set_XmlResolver(XmlResolver value) { }

	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	private void SetErrorState() { }

	private void SetupEncoding(Encoding encoding) { }

	private void SetupEndEntityNodeInAttribute() { }

	private void SetupEndEntityNodeInContent() { }

	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	public virtual void Skip() { }

	private void SkipDtd() { }

	private void SkipPartialTextValue() { }

	private void SkipPublicOrSystemIdLiteral() { }

	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	internal static void StripSpaces(Char[] value, int index, ref int len) { }

	internal static string StripSpaces(string value) { }

	private void SwitchEncoding(Encoding newEncoding) { }

	private void SwitchEncodingToUTF8() { }

	private override IDictionary<String, String> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	private override string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	private void Throw(string res, String[] args, Exception innerException) { }

	private void Throw(Exception e) { }

	private void Throw(string res, String[] args) { }

	private void Throw(string res, string arg, Exception innerException) { }

	private void Throw(string res, string arg) { }

	private void Throw(int pos, string res, string arg) { }

	private void Throw(string res, int lineNo, int linePos) { }

	private void Throw(int pos, string res, String[] args) { }

	private void Throw(string res, string arg, int lineNo, int linePos) { }

	private void Throw(string res) { }

	private void Throw(int pos, string res) { }

	private void ThrowExpectingWhitespace(int pos) { }

	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	private void ThrowTagMismatch(NodeData startTag) { }

	private void ThrowUnclosedElements() { }

	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	private void ThrowUnexpectedToken(string expectedToken1) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	private void ThrowWithoutLineInfo(string res, String[] args, Exception innerException) { }

	private void ThrowWithoutLineInfo(string res, string arg) { }

	private void ThrowWithoutLineInfo(string res) { }

	private void UnDecodeChars() { }

	private void UnregisterEntity() { }

	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	private bool ZeroEndingStream(int pos) { }

}

