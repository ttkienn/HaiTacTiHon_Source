namespace System.Xml.Schema;

internal class Datatype_untypedAtomicType : Datatype_anyAtomicType
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_untypedAtomicType() { }

	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

