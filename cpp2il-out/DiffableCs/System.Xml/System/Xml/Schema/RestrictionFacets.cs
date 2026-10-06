namespace System.Xml.Schema;

internal class RestrictionFacets
{
	internal int Length; //Field offset: 0x10
	internal int MinLength; //Field offset: 0x14
	internal int MaxLength; //Field offset: 0x18
	internal ArrayList Patterns; //Field offset: 0x20
	internal ArrayList Enumeration; //Field offset: 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; //Field offset: 0x30
	internal object MaxInclusive; //Field offset: 0x38
	internal object MaxExclusive; //Field offset: 0x40
	internal object MinInclusive; //Field offset: 0x48
	internal object MinExclusive; //Field offset: 0x50
	internal int TotalDigits; //Field offset: 0x58
	internal int FractionDigits; //Field offset: 0x5C
	internal RestrictionFlags Flags; //Field offset: 0x60
	internal RestrictionFlags FixedFlags; //Field offset: 0x64

	public RestrictionFacets() { }

}

