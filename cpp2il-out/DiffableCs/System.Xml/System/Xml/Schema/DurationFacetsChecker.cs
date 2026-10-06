namespace System.Xml.Schema;

internal class DurationFacetsChecker : FacetsChecker
{

	public DurationFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

}

