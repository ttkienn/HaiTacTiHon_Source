namespace System.Xml.Schema;

public abstract class XmlSchemaDatatype
{

	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 0
	}

	internal abstract FacetsChecker FacetsChecker
	{
		internal get { } //Length: 0
	}

	internal abstract bool HasLexicalFacets
	{
		internal get { } //Length: 0
	}

	internal abstract bool HasValueFacets
	{
		internal get { } //Length: 0
	}

	internal abstract RestrictionFacets Restriction
	{
		internal get { } //Length: 0
	}

	public abstract XmlTokenizedType TokenizedType
	{
		 get { } //Length: 0
	}

	public override XmlTypeCode TypeCode
	{
		 get { } //Length: 3
	}

	internal string TypeCodeString
	{
		internal get { } //Length: 345
	}

	internal abstract XmlValueConverter ValueConverter
	{
		internal get { } //Length: 0
	}

	public abstract Type ValueType
	{
		 get { } //Length: 0
	}

	public override XmlSchemaDatatypeVariety Variety
	{
		 get { } //Length: 3
	}

	protected XmlSchemaDatatype() { }

	internal abstract int Compare(object value1, object value2) { }

	internal static string ConcatenatedToString(object value) { }

	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	internal static XmlSchemaDatatype FromXdrName(string name) { }

	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal abstract FacetsChecker get_FacetsChecker() { }

	internal abstract bool get_HasLexicalFacets() { }

	internal abstract bool get_HasValueFacets() { }

	internal abstract RestrictionFacets get_Restriction() { }

	public abstract XmlTokenizedType get_TokenizedType() { }

	public override XmlTypeCode get_TypeCode() { }

	internal string get_TypeCodeString() { }

	internal abstract XmlValueConverter get_ValueConverter() { }

	public abstract Type get_ValueType() { }

	public override XmlSchemaDatatypeVariety get_Variety() { }

	internal abstract bool IsComparable(XmlSchemaDatatype dtype) { }

	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	internal abstract bool IsEqual(object o1, object o2) { }

	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

}

