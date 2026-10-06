namespace System.Xml.Schema;

internal class Datatype_string : Datatype_anySimpleType
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 3
	}

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 79
	}

	public virtual XmlTokenizedType TokenizedType
	{
		 get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 6
	}

	public Datatype_string() { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	public virtual XmlTokenizedType get_TokenizedType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

