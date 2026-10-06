namespace System.Xml.Schema;

internal class StringFacetsChecker : FacetsChecker
{
	private static Regex languagePattern; //Field offset: 0x0

	private static Regex LanguagePattern
	{
		private get { } //Length: 169
	}

	public StringFacetsChecker() { }

	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	private static Regex get_LanguagePattern() { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

}

