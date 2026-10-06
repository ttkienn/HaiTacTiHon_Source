namespace System.Xml.Schema;

internal class DateTimeFacetsChecker : FacetsChecker
{

	public DateTimeFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

