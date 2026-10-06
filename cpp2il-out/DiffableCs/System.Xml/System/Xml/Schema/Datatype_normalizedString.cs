namespace System.Xml.Schema;

internal class Datatype_normalizedString : Datatype_string
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 6
	}

	internal virtual bool HasValueFacets
	{
		internal get { } //Length: 3
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_normalizedString() { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	internal virtual bool get_HasValueFacets() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

