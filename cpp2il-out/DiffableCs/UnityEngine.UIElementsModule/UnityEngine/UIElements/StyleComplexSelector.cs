namespace UnityEngine.UIElements;

internal class StyleComplexSelector : ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StyleSelector, String> <>9__24_0; //Field offset: 0x8
		public static Predicate<StyleSelectorPart> <>9__27_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <CalculateHashes>b__27_0(StyleSelectorPart p) { }

		internal string <ToString>b__24_0(StyleSelector x) { }

	}

	private struct PseudoStateData
	{
		public readonly PseudoStates state; //Field offset: 0x0
		public readonly bool negate; //Field offset: 0x4

		public PseudoStateData(PseudoStates state, bool negate) { }

	}

	private static Dictionary<String, PseudoStateData> s_PseudoStates; //Field offset: 0x0
	private static List<StyleSelectorPart> m_HashList; //Field offset: 0x8
	public Hashes ancestorHashes; //Field offset: 0x10
	[SerializeField]
	private int m_Specificity; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleRule <rule>k__BackingField; //Field offset: 0x28
	private bool m_isSimple; //Field offset: 0x30
	[SerializeField]
	private StyleSelector[] m_Selectors; //Field offset: 0x38
	[SerializeField]
	internal int ruleIndex; //Field offset: 0x40
	internal StyleComplexSelector nextInTable; //Field offset: 0x48
	internal int orderInStyleSheet; //Field offset: 0x50

	public bool isSimple
	{
		 get { } //Length: 7
	}

	public internal StyleRule rule
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal StyleSelector[] selectors
	{
		 get { } //Length: 7
		internal set { } //Length: 52
	}

	public int specificity
	{
		 get { } //Length: 6
	}

	private static StyleComplexSelector() { }

	public StyleComplexSelector() { }

	internal void CachePseudoStateMasks() { }

	internal void CalculateHashes() { }

	public bool get_isSimple() { }

	[CompilerGenerated]
	public StyleRule get_rule() { }

	public StyleSelector[] get_selectors() { }

	public int get_specificity() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	[CompilerGenerated]
	internal void set_rule(StyleRule value) { }

	internal void set_selectors(StyleSelector[] value) { }

	private static int StyleSelectorPartCompare(StyleSelectorPart x, StyleSelectorPart y) { }

	public virtual string ToString() { }

}

