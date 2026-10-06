namespace System.Xml.Schema;

internal class Numeric2FacetsChecker : FacetsChecker
{

	public Numeric2FacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

}

