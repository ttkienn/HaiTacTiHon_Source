namespace System.Xml.Schema;

internal class Numeric10FacetsChecker : FacetsChecker
{
	private static readonly Char[] signs; //Field offset: 0x0
	private decimal maxValue; //Field offset: 0x10
	private decimal minValue; //Field offset: 0x20

	private static Numeric10FacetsChecker() { }

	internal Numeric10FacetsChecker(decimal minVal, decimal maxVal) { }

	internal Exception CheckTotalAndFractionDigits(decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	internal bool MatchEnumeration(decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

}

