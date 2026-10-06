namespace System.Xml.Schema;

internal sealed class ValidationState
{
	public bool IsNill; //Field offset: 0x10
	public bool IsDefault; //Field offset: 0x11
	public bool NeedValidateChildren; //Field offset: 0x12
	public bool CheckRequiredAttribute; //Field offset: 0x13
	public bool ValidationSkipped; //Field offset: 0x14
	public XmlSchemaContentProcessing ProcessContents; //Field offset: 0x18
	public XmlSchemaValidity Validity; //Field offset: 0x1C
	public SchemaElementDecl ElementDecl; //Field offset: 0x20
	public SchemaElementDecl ElementDeclBeforeXsi; //Field offset: 0x28
	public string LocalName; //Field offset: 0x30
	public string Namespace; //Field offset: 0x38
	public ConstraintStruct[] Constr; //Field offset: 0x40
	public StateUnion CurrentState; //Field offset: 0x48
	public bool HasMatched; //Field offset: 0x4C
	public BitSet[] CurPos; //Field offset: 0x50
	public BitSet AllElementsSet; //Field offset: 0x58
	public List<RangePositionInfo> RunningPositions; //Field offset: 0x60
	public bool TooComplex; //Field offset: 0x68

	public ValidationState() { }

}

