namespace System.Xml.Schema;

internal abstract class FacetsChecker
{
	private struct FacetsCompiler
	{
		private struct Map
		{
			internal char match; //Field offset: 0x0
			internal string replacement; //Field offset: 0x8

			internal Map(char m, string r) { }

		}

		private static readonly Map[] c_map; //Field offset: 0x0
		private DatatypeImplementation datatype; //Field offset: 0x0
		private RestrictionFacets derivedRestriction; //Field offset: 0x8
		private RestrictionFlags baseFlags; //Field offset: 0x10
		private RestrictionFlags baseFixedFlags; //Field offset: 0x14
		private RestrictionFlags validRestrictionFlags; //Field offset: 0x18
		private XmlSchemaDatatype nonNegativeInt; //Field offset: 0x20
		private XmlSchemaDatatype builtInType; //Field offset: 0x28
		private XmlTypeCode builtInEnum; //Field offset: 0x30
		private bool firstPattern; //Field offset: 0x34
		private StringBuilder regStr; //Field offset: 0x38
		private XmlSchemaPatternFacet pattern_facet; //Field offset: 0x40

		private static FacetsCompiler() { }

		public FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

		private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

		private void CheckValue(object value, XmlSchemaFacet facet) { }

		internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		internal void CompileFacetCombinations() { }

		internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

		internal void CompileLengthFacet(XmlSchemaFacet facet) { }

		internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

		internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

		internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

		internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

		internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

		internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

		internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

		internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

		internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

		private void CopyFacetsFromBaseType() { }

		internal void FinishFacetCompile() { }

		private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

		private static string Preprocess(string pattern) { }

		private void SetFlag(RestrictionFlags flag) { }

		private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	}


	protected FacetsChecker() { }

	internal override Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	internal override Exception CheckValueFacets(decimal value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(Byte[] value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	internal override RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	internal static decimal Power(int x, int y) { }

}

