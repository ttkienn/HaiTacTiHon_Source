namespace UnityEngine.UIElements;

internal class VisualTreeStyleUpdaterTraversal : HierarchyTraversal
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<SelectorMatchRecord> <>9__24_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ProcessMatchedRules>b__24_0(SelectorMatchRecord a, SelectorMatchRecord b) { }

	}

	private StyleVariableContext m_ProcessVarContext; //Field offset: 0x10
	private HashSet<VisualElement> m_UpdateList; //Field offset: 0x18
	private HashSet<VisualElement> m_ParentList; //Field offset: 0x20
	private List<SelectorMatchRecord> m_TempMatchResults; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <currentPixelsPerPoint>k__BackingField; //Field offset: 0x30
	private StyleMatchingContext m_StyleMatchingContext; //Field offset: 0x38
	private StylePropertyReader m_StylePropertyReader; //Field offset: 0x40
	private readonly List<StylePropertyId> m_AnimatedProperties; //Field offset: 0x48

	private float currentPixelsPerPoint
	{
		[CompilerGenerated]
		private get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public VisualTreeStyleUpdaterTraversal() { }

	public void AddChangedElement(VisualElement ve, VersionChangeType versionChangeType) { }

	internal void CancelAnimationsWithNoTransitionProperty(VisualElement element, ref ComputedStyle newStyle) { }

	public void Clear() { }

	private void ForceUpdateTransitions(VisualElement element) { }

	[CompilerGenerated]
	private float get_currentPixelsPerPoint() { }

	private static void OnProcessMatchResult(VisualElement current, MatchResultInfo info) { }

	public void PrepareTraversal(float pixelsPerPoint) { }

	private ComputedStyle ProcessMatchedRules(VisualElement element, List<SelectorMatchRecord> matchingSelectors) { }

	private void ProcessMatchedVariables(StyleSheet sheet, StyleRule rule) { }

	private void ProcessTransitions(VisualElement element, ref ComputedStyle oldStyle, ref ComputedStyle newStyle) { }

	private void PropagateToChildren(VisualElement ve) { }

	private void PropagateToParents(VisualElement ve) { }

	[CompilerGenerated]
	private void set_currentPixelsPerPoint(float value) { }

	protected bool ShouldSkipElement(VisualElement element) { }

	public virtual void TraverseRecursive(VisualElement element, int depth) { }

}

