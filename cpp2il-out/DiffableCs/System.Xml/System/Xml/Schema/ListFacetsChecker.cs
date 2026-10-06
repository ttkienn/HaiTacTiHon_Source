namespace System.Xml.Schema;

internal class ListFacetsChecker : FacetsChecker
{

	public ListFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

