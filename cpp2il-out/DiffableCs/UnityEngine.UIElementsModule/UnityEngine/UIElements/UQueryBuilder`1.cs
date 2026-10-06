namespace UnityEngine.UIElements;

public struct UQueryBuilder : IEquatable<UQueryBuilder`1<T>>
{
	private List<StyleSelector> m_StyleSelectors; //Field offset: 0x0
	private List<StyleSelectorPart> m_Parts; //Field offset: 0x0
	private VisualElement m_Element; //Field offset: 0x0
	private List<RuleMatcher> m_Matchers; //Field offset: 0x0
	private StyleSelectorRelationship m_Relationship; //Field offset: 0x0
	private int pseudoStatesMask; //Field offset: 0x0
	private int negatedPseudoStatesMask; //Field offset: 0x0

	private List<StyleSelectorPart> parts
	{
		private get { } //Length: 123
	}

	private List<StyleSelector> styleSelectors
	{
		private get { } //Length: 120
	}

	public UQueryBuilder`1(VisualElement visualElement) { }

	private void AddClass(string c) { }

	private void AddName(string id) { }

	private void AddPseudoStatesRuleIfNecessasy() { }

	public UQueryState<T> Build() { }

	public UQueryBuilder<T> Class(string classname) { }

	private bool CurrentSelectorEmpty() { }

	public override bool Equals(UQueryBuilder<T> other) { }

	public virtual bool Equals(object obj) { }

	private void FinishCurrentSelector() { }

	private void FinishSelector() { }

	private List<StyleSelectorPart> get_parts() { }

	private List<StyleSelector> get_styleSelectors() { }

	public virtual int GetHashCode() { }

	public UQueryBuilder<T> Name(string id) { }

	internal UQueryBuilder<T> SingleBaseType() { }

}

