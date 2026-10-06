namespace UnityEngine.UIElements;

internal class StyleMatchingContext
{
	private List<StyleSheet> m_StyleSheetStack; //Field offset: 0x10
	public StyleVariableContext variableContext; //Field offset: 0x18
	public VisualElement currentElement; //Field offset: 0x20
	public Action<VisualElement, MatchResultInfo> processResult; //Field offset: 0x28
	public AncestorFilter ancestorFilter; //Field offset: 0x30

	public int styleSheetCount
	{
		 get { } //Length: 60
	}

	public StyleMatchingContext(Action<VisualElement, MatchResultInfo> processResult) { }

	public void AddStyleSheet(StyleSheet sheet) { }

	public int get_styleSheetCount() { }

	public StyleSheet GetStyleSheetAt(int index) { }

	public void RemoveStyleSheetRange(int index, int count) { }

}

