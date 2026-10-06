namespace System.Xml.Schema;

internal class Datatype_anyAtomicType : Datatype_anySimpleType
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_anyAtomicType() { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

