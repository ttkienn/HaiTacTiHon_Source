namespace System.Xml.Schema;

internal sealed class RangeContentValidator : ContentValidator
{
	private BitSet firstpos; //Field offset: 0x18
	private BitSet[] followpos; //Field offset: 0x20
	private BitSet positionsWithRangeTerminals; //Field offset: 0x28
	private SymbolsDictionary symbols; //Field offset: 0x30
	private Positions positions; //Field offset: 0x38
	private int minMaxNodesCount; //Field offset: 0x40
	private int endMarkerPos; //Field offset: 0x44

	internal RangeContentValidator(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	public virtual bool CompleteValidation(ValidationState context) { }

	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	public virtual void InitValidation(ValidationState context) { }

	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

