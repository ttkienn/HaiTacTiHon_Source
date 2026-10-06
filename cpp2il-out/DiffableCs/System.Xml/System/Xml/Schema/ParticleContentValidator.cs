namespace System.Xml.Schema;

internal sealed class ParticleContentValidator : ContentValidator
{
	private SymbolsDictionary symbols; //Field offset: 0x18
	private Positions positions; //Field offset: 0x20
	private Stack stack; //Field offset: 0x28
	private SyntaxTreeNode contentNode; //Field offset: 0x30
	private bool isPartial; //Field offset: 0x38
	private int minMaxNodesCount; //Field offset: 0x3C
	private bool enableUpaCheck; //Field offset: 0x40

	public ParticleContentValidator(XmlSchemaContentType contentType) { }

	public ParticleContentValidator(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	public void AddChoice() { }

	private void AddLeafNode(SyntaxTreeNode node) { }

	public void AddLeafRange(decimal min, decimal max) { }

	public void AddName(XmlQualifiedName name, object particle) { }

	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	public void AddPlus() { }

	public void AddQMark() { }

	public void AddSequence() { }

	public void AddStar() { }

	private Int32[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }

	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	public void CloseGroup() { }

	private void Closure(InteriorNode node) { }

	public virtual bool CompleteValidation(ValidationState context) { }

	public bool Exists(XmlQualifiedName name) { }

	public ContentValidator Finish(bool useDFA) { }

	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	public virtual void InitValidation(ValidationState context) { }

	public void OpenGroup() { }

	public void Start() { }

	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

