namespace System.Xml;

internal class DtdParser : IDtdParser
{
	private enum LiteralType
	{
		AttributeValue = 0,
		EntityReplText = 1,
		SystemOrPublicID = 2,
	}

	private class ParseElementOnlyContent_LocalFrame
	{
		public int startParenEntityId; //Field offset: 0x10
		public Token parsingSchema; //Field offset: 0x14

		public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam) { }

	}

	private enum ScanningFunction
	{
		SubsetContent = 0,
		Name = 1,
		QName = 2,
		Nmtoken = 3,
		Doctype1 = 4,
		Doctype2 = 5,
		Element1 = 6,
		Element2 = 7,
		Element3 = 8,
		Element4 = 9,
		Element5 = 10,
		Element6 = 11,
		Element7 = 12,
		Attlist1 = 13,
		Attlist2 = 14,
		Attlist3 = 15,
		Attlist4 = 16,
		Attlist5 = 17,
		Attlist6 = 18,
		Attlist7 = 19,
		Entity1 = 20,
		Entity2 = 21,
		Entity3 = 22,
		Notation1 = 23,
		CondSection1 = 24,
		CondSection2 = 25,
		CondSection3 = 26,
		Literal = 27,
		SystemId = 28,
		PublicId1 = 29,
		PublicId2 = 30,
		ClosingTag = 31,
		ParamEntitySpace = 32,
		None = 33,
	}

	private enum Token
	{
		CDATA = 0,
		ID = 1,
		IDREF = 2,
		IDREFS = 3,
		ENTITY = 4,
		ENTITIES = 5,
		NMTOKEN = 6,
		NMTOKENS = 7,
		NOTATION = 8,
		None = 9,
		PERef = 10,
		AttlistDecl = 11,
		ElementDecl = 12,
		EntityDecl = 13,
		NotationDecl = 14,
		Comment = 15,
		PI = 16,
		CondSectionStart = 17,
		CondSectionEnd = 18,
		Eof = 19,
		REQUIRED = 20,
		IMPLIED = 21,
		FIXED = 22,
		QName = 23,
		Name = 24,
		Nmtoken = 25,
		Quote = 26,
		LeftParen = 27,
		RightParen = 28,
		GreaterThan = 29,
		Or = 30,
		LeftBracket = 31,
		RightBracket = 32,
		PUBLIC = 33,
		SYSTEM = 34,
		Literal = 35,
		DOCTYPE = 36,
		NData = 37,
		Percent = 38,
		Star = 39,
		QMark = 40,
		Plus = 41,
		PCDATA = 42,
		Comma = 43,
		ANY = 44,
		EMPTY = 45,
		IGNORE = 46,
		INCLUDE = 47,
	}

	private class UndeclaredNotation
	{
		internal string name; //Field offset: 0x10
		internal int lineNo; //Field offset: 0x18
		internal int linePos; //Field offset: 0x1C
		internal UndeclaredNotation next; //Field offset: 0x20

		internal UndeclaredNotation(string name, int lineNo, int linePos) { }

	}

	private IDtdParserAdapter readerAdapter; //Field offset: 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; //Field offset: 0x18
	private XmlNameTable nameTable; //Field offset: 0x20
	private SchemaInfo schemaInfo; //Field offset: 0x28
	private XmlCharType xmlCharType; //Field offset: 0x30
	private string systemId; //Field offset: 0x38
	private string publicId; //Field offset: 0x40
	private bool normalize; //Field offset: 0x48
	private bool validate; //Field offset: 0x49
	private bool supportNamespaces; //Field offset: 0x4A
	private bool v1Compat; //Field offset: 0x4B
	private Char[] chars; //Field offset: 0x50
	private int charsUsed; //Field offset: 0x58
	private int curPos; //Field offset: 0x5C
	private ScanningFunction scanningFunction; //Field offset: 0x60
	private ScanningFunction nextScaningFunction; //Field offset: 0x64
	private ScanningFunction savedScanningFunction; //Field offset: 0x68
	private bool whitespaceSeen; //Field offset: 0x6C
	private int tokenStartPos; //Field offset: 0x70
	private int colonPos; //Field offset: 0x74
	private StringBuilder internalSubsetValueSb; //Field offset: 0x78
	private int externalEntitiesDepth; //Field offset: 0x80
	private int currentEntityId; //Field offset: 0x84
	private bool freeFloatingDtd; //Field offset: 0x88
	private bool hasFreeFloatingInternalSubset; //Field offset: 0x89
	private StringBuilder stringBuilder; //Field offset: 0x90
	private int condSectionDepth; //Field offset: 0x98
	private LineInfo literalLineInfo; //Field offset: 0x9C
	private char literalQuoteChar; //Field offset: 0xA4
	private string documentBaseUri; //Field offset: 0xA8
	private string externalDtdBaseUri; //Field offset: 0xB0
	private Dictionary<String, UndeclaredNotation> undeclaredNotations; //Field offset: 0xB8
	private Int32[] condSectionEntityIds; //Field offset: 0xC0

	private string BaseUriStr
	{
		private get { } //Length: 189
	}

	private bool IgnoreEntityReferences
	{
		private get { } //Length: 8
	}

	private int LineNo
	{
		private get { } //Length: 73
	}

	private int LinePos
	{
		private get { } //Length: 90
	}

	private bool Normalize
	{
		private get { } //Length: 5
	}

	private bool ParsingInternalSubset
	{
		private get { } //Length: 11
	}

	private bool ParsingTopLevelMarkup
	{
		private get { } //Length: 26
	}

	private bool SaveInternalSubsetValue
	{
		private get { } //Length: 94
	}

	private bool SupportNamespaces
	{
		private get { } //Length: 5
	}

	private DtdParser() { }

	private void AddUndeclaredNotation(string notationName) { }

	internal static IDtdParser Create() { }

	private bool EatPublicKeyword() { }

	private bool EatSystemKeyword() { }

	private string get_BaseUriStr() { }

	private bool get_IgnoreEntityReferences() { }

	private int get_LineNo() { }

	private int get_LinePos() { }

	private bool get_Normalize() { }

	private bool get_ParsingInternalSubset() { }

	private bool get_ParsingTopLevelMarkup() { }

	private bool get_SaveInternalSubsetValue() { }

	private bool get_SupportNamespaces() { }

	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	private string GetNameString() { }

	private string GetNmtokenString() { }

	private Token GetToken(bool needWhiteSpace) { }

	private string GetValue() { }

	private string GetValueWithStrippedSpaces() { }

	private bool HandleEntityEnd(bool inLiteral) { }

	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	private void Initialize(IDtdParserAdapter readerAdapter) { }

	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	private bool IsAttributeValueType(Token token) { }

	private void LoadParsingBuffer() { }

	private void OnUnexpectedError() { }

	private void Parse(bool saveInternalSubset) { }

	private void ParseAttlistDecl() { }

	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	private void ParseComment() { }

	private void ParseCondSection() { }

	private void ParseElementDecl() { }

	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	private void ParseEntityDecl() { }

	private void ParseExternalId(Token idTokenType, Token declType, out string publicId, out string systemId) { }

	private void ParseExternalSubset() { }

	private void ParseFreeFloatingDtd() { }

	private void ParseHowMany(ParticleContentValidator pcv) { }

	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	private void ParseInternalSubset() { }

	private void ParseNotationDecl() { }

	private void ParsePI() { }

	private void ParseSubset() { }

	private string ParseUnexpectedToken(int startPos) { }

	private int ReadData() { }

	private bool ReadDataInName() { }

	private void SaveParsingBuffer() { }

	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	private Token ScanAttlist1() { }

	private Token ScanAttlist2() { }

	private Token ScanAttlist3() { }

	private Token ScanAttlist4() { }

	private Token ScanAttlist5() { }

	private Token ScanAttlist6() { }

	private Token ScanAttlist7() { }

	private Token ScanClosingTag() { }

	private Token ScanCondSection1() { }

	private Token ScanCondSection2() { }

	private Token ScanCondSection3() { }

	private Token ScanDoctype1() { }

	private Token ScanDoctype2() { }

	private Token ScanElement1() { }

	private Token ScanElement2() { }

	private Token ScanElement3() { }

	private Token ScanElement4() { }

	private Token ScanElement5() { }

	private Token ScanElement6() { }

	private Token ScanElement7() { }

	private Token ScanEntity1() { }

	private Token ScanEntity2() { }

	private Token ScanEntity3() { }

	private XmlQualifiedName ScanEntityName() { }

	private Token ScanLiteral(LiteralType literalType) { }

	private void ScanName() { }

	private Token ScanNameExpected() { }

	private void ScanNmtoken() { }

	private Token ScanNmtokenExpected() { }

	private Token ScanNotation1() { }

	private Token ScanPublicId1() { }

	private Token ScanPublicId2() { }

	private void ScanQName(bool isQName) { }

	private void ScanQName() { }

	private Token ScanQNameExpected() { }

	private Token ScanSubsetContent() { }

	private Token ScanSystemId() { }

	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	internal static string StripSpaces(string value) { }

	private override IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	private override IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	private void Throw(int curPos, string res) { }

	private void Throw(int curPos, string res, string arg) { }

	private void Throw(int curPos, string res, String[] args) { }

	private void Throw(string res, string arg, int lineNo, int linePos) { }

	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	private void ThrowInvalidChar(Char[] data, int length, int invCharPos) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

}

