namespace System.Xml.Schema;

internal abstract class DatatypeImplementation : XmlSchemaDatatype
{
	private class SchemaDatatypeMap : IComparable
	{
		private string name; //Field offset: 0x10
		private DatatypeImplementation type; //Field offset: 0x18
		private int parentIndex; //Field offset: 0x20

		public string Name
		{
			 get { } //Length: 5
		}

		public int ParentIndex
		{
			 get { } //Length: 4
		}

		internal SchemaDatatypeMap(string name, DatatypeImplementation type) { }

		internal SchemaDatatypeMap(string name, DatatypeImplementation type, int parentIndex) { }

		public override int CompareTo(object obj) { }

		public string get_Name() { }

		public int get_ParentIndex() { }

		public static DatatypeImplementation op_Explicit(SchemaDatatypeMap sdm) { }

	}

	private static Hashtable builtinTypes; //Field offset: 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; //Field offset: 0x8
	private static XmlSchemaSimpleType anySimpleType; //Field offset: 0x10
	private static XmlSchemaSimpleType anyAtomicType; //Field offset: 0x18
	private static XmlSchemaSimpleType untypedAtomicType; //Field offset: 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; //Field offset: 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; //Field offset: 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; //Field offset: 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; //Field offset: 0x40
	internal static XmlQualifiedName QnAnySimpleType; //Field offset: 0x48
	internal static XmlQualifiedName QnAnyType; //Field offset: 0x50
	internal static FacetsChecker stringFacetsChecker; //Field offset: 0x58
	internal static FacetsChecker miscFacetsChecker; //Field offset: 0x60
	internal static FacetsChecker numeric2FacetsChecker; //Field offset: 0x68
	internal static FacetsChecker binaryFacetsChecker; //Field offset: 0x70
	internal static FacetsChecker dateTimeFacetsChecker; //Field offset: 0x78
	internal static FacetsChecker durationFacetsChecker; //Field offset: 0x80
	internal static FacetsChecker listFacetsChecker; //Field offset: 0x88
	internal static FacetsChecker qnameFacetsChecker; //Field offset: 0x90
	internal static FacetsChecker unionFacetsChecker; //Field offset: 0x98
	private static readonly DatatypeImplementation c_anySimpleType; //Field offset: 0xA0
	private static readonly DatatypeImplementation c_anyURI; //Field offset: 0xA8
	private static readonly DatatypeImplementation c_base64Binary; //Field offset: 0xB0
	private static readonly DatatypeImplementation c_boolean; //Field offset: 0xB8
	private static readonly DatatypeImplementation c_byte; //Field offset: 0xC0
	private static readonly DatatypeImplementation c_char; //Field offset: 0xC8
	private static readonly DatatypeImplementation c_date; //Field offset: 0xD0
	private static readonly DatatypeImplementation c_dateTime; //Field offset: 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; //Field offset: 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; //Field offset: 0xE8
	private static readonly DatatypeImplementation c_day; //Field offset: 0xF0
	private static readonly DatatypeImplementation c_decimal; //Field offset: 0xF8
	private static readonly DatatypeImplementation c_double; //Field offset: 0x100
	private static readonly DatatypeImplementation c_doubleXdr; //Field offset: 0x108
	private static readonly DatatypeImplementation c_duration; //Field offset: 0x110
	private static readonly DatatypeImplementation c_ENTITY; //Field offset: 0x118
	private static readonly DatatypeImplementation c_ENTITIES; //Field offset: 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; //Field offset: 0x128
	private static readonly DatatypeImplementation c_fixed; //Field offset: 0x130
	private static readonly DatatypeImplementation c_float; //Field offset: 0x138
	private static readonly DatatypeImplementation c_floatXdr; //Field offset: 0x140
	private static readonly DatatypeImplementation c_hexBinary; //Field offset: 0x148
	private static readonly DatatypeImplementation c_ID; //Field offset: 0x150
	private static readonly DatatypeImplementation c_IDREF; //Field offset: 0x158
	private static readonly DatatypeImplementation c_IDREFS; //Field offset: 0x160
	private static readonly DatatypeImplementation c_int; //Field offset: 0x168
	private static readonly DatatypeImplementation c_integer; //Field offset: 0x170
	private static readonly DatatypeImplementation c_language; //Field offset: 0x178
	private static readonly DatatypeImplementation c_long; //Field offset: 0x180
	private static readonly DatatypeImplementation c_month; //Field offset: 0x188
	private static readonly DatatypeImplementation c_monthDay; //Field offset: 0x190
	private static readonly DatatypeImplementation c_Name; //Field offset: 0x198
	private static readonly DatatypeImplementation c_NCName; //Field offset: 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; //Field offset: 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; //Field offset: 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; //Field offset: 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; //Field offset: 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; //Field offset: 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; //Field offset: 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; //Field offset: 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; //Field offset: 0x1E0
	private static readonly DatatypeImplementation c_QName; //Field offset: 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; //Field offset: 0x1F0
	private static readonly DatatypeImplementation c_short; //Field offset: 0x1F8
	private static readonly DatatypeImplementation c_string; //Field offset: 0x200
	private static readonly DatatypeImplementation c_time; //Field offset: 0x208
	private static readonly DatatypeImplementation c_timeNoTz; //Field offset: 0x210
	private static readonly DatatypeImplementation c_timeTz; //Field offset: 0x218
	private static readonly DatatypeImplementation c_token; //Field offset: 0x220
	private static readonly DatatypeImplementation c_unsignedByte; //Field offset: 0x228
	private static readonly DatatypeImplementation c_unsignedInt; //Field offset: 0x230
	private static readonly DatatypeImplementation c_unsignedLong; //Field offset: 0x238
	private static readonly DatatypeImplementation c_unsignedShort; //Field offset: 0x240
	private static readonly DatatypeImplementation c_uuid; //Field offset: 0x248
	private static readonly DatatypeImplementation c_year; //Field offset: 0x250
	private static readonly DatatypeImplementation c_yearMonth; //Field offset: 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; //Field offset: 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; //Field offset: 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; //Field offset: 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; //Field offset: 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; //Field offset: 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; //Field offset: 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; //Field offset: 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; //Field offset: 0x298
	private static readonly SchemaDatatypeMap[] c_XdrTypes; //Field offset: 0x2A0
	private static readonly SchemaDatatypeMap[] c_XsdTypes; //Field offset: 0x2A8
	private XmlSchemaDatatypeVariety variety; //Field offset: 0x10
	private RestrictionFacets restriction; //Field offset: 0x18
	private DatatypeImplementation baseType; //Field offset: 0x20
	private XmlValueConverter valueConverter; //Field offset: 0x28
	private XmlSchemaType parentSchemaType; //Field offset: 0x30

	internal static XmlSchemaSimpleType AnySimpleType
	{
		internal get { } //Length: 79
	}

	protected DatatypeImplementation Base
	{
		 get { } //Length: 5
	}

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 3
	}

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 79
	}

	internal virtual bool HasLexicalFacets
	{
		internal get { } //Length: 31
	}

	internal virtual bool HasValueFacets
	{
		internal get { } //Length: 31
	}

	internal abstract Type ListValueType
	{
		internal get { } //Length: 0
	}

	internal virtual RestrictionFacets Restriction
	{
		internal get { } //Length: 5
	}

	public virtual XmlTokenizedType TokenizedType
	{
		 get { } //Length: 6
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 3
	}

	internal static XmlSchemaSimpleType UntypedAtomicType
	{
		internal get { } //Length: 79
	}

	internal abstract RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 0
	}

	internal virtual XmlValueConverter ValueConverter
	{
		internal get { } //Length: 75
	}

	public virtual Type ValueType
	{
		 get { } //Length: 89
	}

	public virtual XmlSchemaDatatypeVariety Variety
	{
		 get { } //Length: 191
	}

	private static DatatypeImplementation() { }

	protected DatatypeImplementation() { }

	protected int Compare(Byte[] value1, Byte[] value2) { }

	internal static void CreateBuiltinTypes() { }

	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	internal virtual XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	private static DatatypeImplementation FromTypeName(string name) { }

	internal static DatatypeImplementation FromXdrName(string name) { }

	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	protected DatatypeImplementation get_Base() { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual bool get_HasLexicalFacets() { }

	internal virtual bool get_HasValueFacets() { }

	internal abstract Type get_ListValueType() { }

	internal virtual RestrictionFacets get_Restriction() { }

	public virtual XmlTokenizedType get_TokenizedType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	internal abstract RestrictionFlags get_ValidRestrictionFlags() { }

	internal virtual XmlValueConverter get_ValueConverter() { }

	public virtual Type get_ValueType() { }

	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	internal string GetTypeName() { }

	internal virtual bool IsComparable(XmlSchemaDatatype dtype) { }

	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	internal virtual bool IsEqual(object o1, object o2) { }

	public virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal virtual object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	internal virtual Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal virtual void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

}

