namespace System.Xml.Schema;

internal class Datatype_token : Datatype_normalizedString
{

	internal virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
	{
		internal get { } //Length: 6
	}

	public virtual XmlTypeCode TypeCode
	{
		 get { } //Length: 6
	}

	public Datatype_token() { }

	internal virtual XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	public virtual XmlTypeCode get_TypeCode() { }

}

