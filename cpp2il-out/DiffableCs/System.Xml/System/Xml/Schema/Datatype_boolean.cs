namespace System.Xml.Schema;

internal class Datatype_boolean : Datatype_anySimpleType
{
	private static readonly Type atomicValueType; //Field offset: 0x0
	private static readonly Type listValueType; //Field offset: 0x8

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 6
	}

	internal virtual FacetsChecker FacetsChecker
	{
		internal get { } //Length: 79
	}

	internal virtual Type ListValueType
	{
		internal get { } //Length: 79
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	internal virtual RestrictionFlags ValidRestrictionFlags
	{
		internal get { } //Length: 6
	}

	public virtual Type ValueType
	{
		 get { } //Length: 78
	}

	private static Datatype_boolean() { }

	public Datatype_boolean() { }

	internal virtual int Compare(object value1, object value2) { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal virtual FacetsChecker get_FacetsChecker() { }

	internal virtual Type get_ListValueType() { }

	public virtual XmlTypeCode get_TypeCode() { }

	internal virtual RestrictionFlags get_ValidRestrictionFlags() { }

	public virtual Type get_ValueType() { }

	internal virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

}

