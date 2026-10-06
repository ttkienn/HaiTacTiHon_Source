namespace System.Xml.Schema;

internal sealed class SchemaNames
{
	internal enum Token
	{
		Empty = 0,
		SchemaName = 1,
		SchemaType = 2,
		SchemaMaxOccurs = 3,
		SchemaMinOccurs = 4,
		SchemaInfinite = 5,
		SchemaModel = 6,
		SchemaOpen = 7,
		SchemaClosed = 8,
		SchemaContent = 9,
		SchemaMixed = 10,
		SchemaEmpty = 11,
		SchemaElementOnly = 12,
		SchemaTextOnly = 13,
		SchemaOrder = 14,
		SchemaSeq = 15,
		SchemaOne = 16,
		SchemaMany = 17,
		SchemaRequired = 18,
		SchemaYes = 19,
		SchemaNo = 20,
		SchemaString = 21,
		SchemaId = 22,
		SchemaIdref = 23,
		SchemaIdrefs = 24,
		SchemaEntity = 25,
		SchemaEntities = 26,
		SchemaNmtoken = 27,
		SchemaNmtokens = 28,
		SchemaEnumeration = 29,
		SchemaDefault = 30,
		XdrRoot = 31,
		XdrElementType = 32,
		XdrElement = 33,
		XdrGroup = 34,
		XdrAttributeType = 35,
		XdrAttribute = 36,
		XdrDatatype = 37,
		XdrDescription = 38,
		XdrExtends = 39,
		SchemaXdrRootAlias = 40,
		SchemaDtType = 41,
		SchemaDtValues = 42,
		SchemaDtMaxLength = 43,
		SchemaDtMinLength = 44,
		SchemaDtMax = 45,
		SchemaDtMin = 46,
		SchemaDtMinExclusive = 47,
		SchemaDtMaxExclusive = 48,
		SchemaTargetNamespace = 49,
		SchemaVersion = 50,
		SchemaFinalDefault = 51,
		SchemaBlockDefault = 52,
		SchemaFixed = 53,
		SchemaAbstract = 54,
		SchemaBlock = 55,
		SchemaSubstitutionGroup = 56,
		SchemaFinal = 57,
		SchemaNillable = 58,
		SchemaRef = 59,
		SchemaBase = 60,
		SchemaDerivedBy = 61,
		SchemaNamespace = 62,
		SchemaProcessContents = 63,
		SchemaRefer = 64,
		SchemaPublic = 65,
		SchemaSystem = 66,
		SchemaSchemaLocation = 67,
		SchemaValue = 68,
		SchemaSource = 69,
		SchemaAttributeFormDefault = 70,
		SchemaElementFormDefault = 71,
		SchemaUse = 72,
		SchemaForm = 73,
		XsdSchema = 74,
		XsdAnnotation = 75,
		XsdInclude = 76,
		XsdImport = 77,
		XsdElement = 78,
		XsdAttribute = 79,
		xsdAttributeGroup = 80,
		XsdAnyAttribute = 81,
		XsdGroup = 82,
		XsdAll = 83,
		XsdChoice = 84,
		XsdSequence = 85,
		XsdAny = 86,
		XsdNotation = 87,
		XsdSimpleType = 88,
		XsdComplexType = 89,
		XsdUnique = 90,
		XsdKey = 91,
		XsdKeyref = 92,
		XsdSelector = 93,
		XsdField = 94,
		XsdMinExclusive = 95,
		XsdMinInclusive = 96,
		XsdMaxExclusive = 97,
		XsdMaxInclusive = 98,
		XsdTotalDigits = 99,
		XsdFractionDigits = 100,
		XsdLength = 101,
		XsdMinLength = 102,
		XsdMaxLength = 103,
		XsdEnumeration = 104,
		XsdPattern = 105,
		XsdDocumentation = 106,
		XsdAppInfo = 107,
		XsdComplexContent = 108,
		XsdComplexContentExtension = 109,
		XsdComplexContentRestriction = 110,
		XsdSimpleContent = 111,
		XsdSimpleContentExtension = 112,
		XsdSimpleContentRestriction = 113,
		XsdSimpleTypeList = 114,
		XsdSimpleTypeRestriction = 115,
		XsdSimpleTypeUnion = 116,
		XsdWhitespace = 117,
		XsdRedefine = 118,
		SchemaItemType = 119,
		SchemaMemberTypes = 120,
		SchemaXPath = 121,
		XmlLang = 122,
	}

	private XmlNameTable nameTable; //Field offset: 0x10
	public string NsDataType; //Field offset: 0x18
	public string NsDataTypeAlias; //Field offset: 0x20
	public string NsDataTypeOld; //Field offset: 0x28
	public string NsXml; //Field offset: 0x30
	public string NsXmlNs; //Field offset: 0x38
	public string NsXdr; //Field offset: 0x40
	public string NsXdrAlias; //Field offset: 0x48
	public string NsXs; //Field offset: 0x50
	public string NsXsi; //Field offset: 0x58
	public string XsiType; //Field offset: 0x60
	public string XsiNil; //Field offset: 0x68
	public string XsiSchemaLocation; //Field offset: 0x70
	public string XsiNoNamespaceSchemaLocation; //Field offset: 0x78
	public string XsdSchema; //Field offset: 0x80
	public string XdrSchema; //Field offset: 0x88
	public XmlQualifiedName QnPCData; //Field offset: 0x90
	public XmlQualifiedName QnXml; //Field offset: 0x98
	public XmlQualifiedName QnXmlNs; //Field offset: 0xA0
	public XmlQualifiedName QnDtDt; //Field offset: 0xA8
	public XmlQualifiedName QnXmlLang; //Field offset: 0xB0
	public XmlQualifiedName QnName; //Field offset: 0xB8
	public XmlQualifiedName QnType; //Field offset: 0xC0
	public XmlQualifiedName QnMaxOccurs; //Field offset: 0xC8
	public XmlQualifiedName QnMinOccurs; //Field offset: 0xD0
	public XmlQualifiedName QnInfinite; //Field offset: 0xD8
	public XmlQualifiedName QnModel; //Field offset: 0xE0
	public XmlQualifiedName QnOpen; //Field offset: 0xE8
	public XmlQualifiedName QnClosed; //Field offset: 0xF0
	public XmlQualifiedName QnContent; //Field offset: 0xF8
	public XmlQualifiedName QnMixed; //Field offset: 0x100
	public XmlQualifiedName QnEmpty; //Field offset: 0x108
	public XmlQualifiedName QnEltOnly; //Field offset: 0x110
	public XmlQualifiedName QnTextOnly; //Field offset: 0x118
	public XmlQualifiedName QnOrder; //Field offset: 0x120
	public XmlQualifiedName QnSeq; //Field offset: 0x128
	public XmlQualifiedName QnOne; //Field offset: 0x130
	public XmlQualifiedName QnMany; //Field offset: 0x138
	public XmlQualifiedName QnRequired; //Field offset: 0x140
	public XmlQualifiedName QnYes; //Field offset: 0x148
	public XmlQualifiedName QnNo; //Field offset: 0x150
	public XmlQualifiedName QnString; //Field offset: 0x158
	public XmlQualifiedName QnID; //Field offset: 0x160
	public XmlQualifiedName QnIDRef; //Field offset: 0x168
	public XmlQualifiedName QnIDRefs; //Field offset: 0x170
	public XmlQualifiedName QnEntity; //Field offset: 0x178
	public XmlQualifiedName QnEntities; //Field offset: 0x180
	public XmlQualifiedName QnNmToken; //Field offset: 0x188
	public XmlQualifiedName QnNmTokens; //Field offset: 0x190
	public XmlQualifiedName QnEnumeration; //Field offset: 0x198
	public XmlQualifiedName QnDefault; //Field offset: 0x1A0
	public XmlQualifiedName QnXdrSchema; //Field offset: 0x1A8
	public XmlQualifiedName QnXdrElementType; //Field offset: 0x1B0
	public XmlQualifiedName QnXdrElement; //Field offset: 0x1B8
	public XmlQualifiedName QnXdrGroup; //Field offset: 0x1C0
	public XmlQualifiedName QnXdrAttributeType; //Field offset: 0x1C8
	public XmlQualifiedName QnXdrAttribute; //Field offset: 0x1D0
	public XmlQualifiedName QnXdrDataType; //Field offset: 0x1D8
	public XmlQualifiedName QnXdrDescription; //Field offset: 0x1E0
	public XmlQualifiedName QnXdrExtends; //Field offset: 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; //Field offset: 0x1F0
	public XmlQualifiedName QnDtType; //Field offset: 0x1F8
	public XmlQualifiedName QnDtValues; //Field offset: 0x200
	public XmlQualifiedName QnDtMaxLength; //Field offset: 0x208
	public XmlQualifiedName QnDtMinLength; //Field offset: 0x210
	public XmlQualifiedName QnDtMax; //Field offset: 0x218
	public XmlQualifiedName QnDtMin; //Field offset: 0x220
	public XmlQualifiedName QnDtMinExclusive; //Field offset: 0x228
	public XmlQualifiedName QnDtMaxExclusive; //Field offset: 0x230
	public XmlQualifiedName QnTargetNamespace; //Field offset: 0x238
	public XmlQualifiedName QnVersion; //Field offset: 0x240
	public XmlQualifiedName QnFinalDefault; //Field offset: 0x248
	public XmlQualifiedName QnBlockDefault; //Field offset: 0x250
	public XmlQualifiedName QnFixed; //Field offset: 0x258
	public XmlQualifiedName QnAbstract; //Field offset: 0x260
	public XmlQualifiedName QnBlock; //Field offset: 0x268
	public XmlQualifiedName QnSubstitutionGroup; //Field offset: 0x270
	public XmlQualifiedName QnFinal; //Field offset: 0x278
	public XmlQualifiedName QnNillable; //Field offset: 0x280
	public XmlQualifiedName QnRef; //Field offset: 0x288
	public XmlQualifiedName QnBase; //Field offset: 0x290
	public XmlQualifiedName QnDerivedBy; //Field offset: 0x298
	public XmlQualifiedName QnNamespace; //Field offset: 0x2A0
	public XmlQualifiedName QnProcessContents; //Field offset: 0x2A8
	public XmlQualifiedName QnRefer; //Field offset: 0x2B0
	public XmlQualifiedName QnPublic; //Field offset: 0x2B8
	public XmlQualifiedName QnSystem; //Field offset: 0x2C0
	public XmlQualifiedName QnSchemaLocation; //Field offset: 0x2C8
	public XmlQualifiedName QnValue; //Field offset: 0x2D0
	public XmlQualifiedName QnUse; //Field offset: 0x2D8
	public XmlQualifiedName QnForm; //Field offset: 0x2E0
	public XmlQualifiedName QnElementFormDefault; //Field offset: 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; //Field offset: 0x2F0
	public XmlQualifiedName QnItemType; //Field offset: 0x2F8
	public XmlQualifiedName QnMemberTypes; //Field offset: 0x300
	public XmlQualifiedName QnXPath; //Field offset: 0x308
	public XmlQualifiedName QnXsdSchema; //Field offset: 0x310
	public XmlQualifiedName QnXsdAnnotation; //Field offset: 0x318
	public XmlQualifiedName QnXsdInclude; //Field offset: 0x320
	public XmlQualifiedName QnXsdImport; //Field offset: 0x328
	public XmlQualifiedName QnXsdElement; //Field offset: 0x330
	public XmlQualifiedName QnXsdAttribute; //Field offset: 0x338
	public XmlQualifiedName QnXsdAttributeGroup; //Field offset: 0x340
	public XmlQualifiedName QnXsdAnyAttribute; //Field offset: 0x348
	public XmlQualifiedName QnXsdGroup; //Field offset: 0x350
	public XmlQualifiedName QnXsdAll; //Field offset: 0x358
	public XmlQualifiedName QnXsdChoice; //Field offset: 0x360
	public XmlQualifiedName QnXsdSequence; //Field offset: 0x368
	public XmlQualifiedName QnXsdAny; //Field offset: 0x370
	public XmlQualifiedName QnXsdNotation; //Field offset: 0x378
	public XmlQualifiedName QnXsdSimpleType; //Field offset: 0x380
	public XmlQualifiedName QnXsdComplexType; //Field offset: 0x388
	public XmlQualifiedName QnXsdUnique; //Field offset: 0x390
	public XmlQualifiedName QnXsdKey; //Field offset: 0x398
	public XmlQualifiedName QnXsdKeyRef; //Field offset: 0x3A0
	public XmlQualifiedName QnXsdSelector; //Field offset: 0x3A8
	public XmlQualifiedName QnXsdField; //Field offset: 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; //Field offset: 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; //Field offset: 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; //Field offset: 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; //Field offset: 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; //Field offset: 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; //Field offset: 0x3E0
	public XmlQualifiedName QnXsdLength; //Field offset: 0x3E8
	public XmlQualifiedName QnXsdMinLength; //Field offset: 0x3F0
	public XmlQualifiedName QnXsdMaxLength; //Field offset: 0x3F8
	public XmlQualifiedName QnXsdEnumeration; //Field offset: 0x400
	public XmlQualifiedName QnXsdPattern; //Field offset: 0x408
	public XmlQualifiedName QnXsdDocumentation; //Field offset: 0x410
	public XmlQualifiedName QnXsdAppinfo; //Field offset: 0x418
	public XmlQualifiedName QnSource; //Field offset: 0x420
	public XmlQualifiedName QnXsdComplexContent; //Field offset: 0x428
	public XmlQualifiedName QnXsdSimpleContent; //Field offset: 0x430
	public XmlQualifiedName QnXsdRestriction; //Field offset: 0x438
	public XmlQualifiedName QnXsdExtension; //Field offset: 0x440
	public XmlQualifiedName QnXsdUnion; //Field offset: 0x448
	public XmlQualifiedName QnXsdList; //Field offset: 0x450
	public XmlQualifiedName QnXsdWhiteSpace; //Field offset: 0x458
	public XmlQualifiedName QnXsdRedefine; //Field offset: 0x460
	public XmlQualifiedName QnXsdAnyType; //Field offset: 0x468
	internal XmlQualifiedName[] TokenToQName; //Field offset: 0x470

	public SchemaNames(XmlNameTable nameTable) { }

	public void CreateTokenToQNameTable() { }

	public bool IsXDRRoot(string localName, string ns) { }

	public bool IsXSDRoot(string localName, string ns) { }

	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

}

