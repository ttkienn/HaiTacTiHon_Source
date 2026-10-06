namespace System.Xml.Schema;

internal class QNameFacetsChecker : FacetsChecker
{

	public QNameFacetsChecker() { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

}

