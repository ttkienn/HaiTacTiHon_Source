namespace System.Xml.Schema;

internal class UnionFacetsChecker : FacetsChecker
{

	public UnionFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

