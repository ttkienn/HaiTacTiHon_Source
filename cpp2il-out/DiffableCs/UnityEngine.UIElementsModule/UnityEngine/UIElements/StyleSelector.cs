namespace UnityEngine.UIElements;

internal class StyleSelector
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<StyleSelectorPart, String> <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToString>b__10_0(StyleSelectorPart p) { }

	}

	[SerializeField]
	private StyleSelectorPart[] m_Parts; //Field offset: 0x10
	[SerializeField]
	private StyleSelectorRelationship m_PreviousRelationship; //Field offset: 0x18
	internal int pseudoStateMask; //Field offset: 0x1C
	internal int negatedPseudoStateMask; //Field offset: 0x20

	public internal StyleSelectorPart[] parts
	{
		 get { } //Length: 7
		internal set { } //Length: 13
	}

	public internal StyleSelectorRelationship previousRelationship
	{
		 get { } //Length: 6
		internal set { } //Length: 4
	}

	public StyleSelector() { }

	public StyleSelectorPart[] get_parts() { }

	public StyleSelectorRelationship get_previousRelationship() { }

	internal void set_parts(StyleSelectorPart[] value) { }

	internal void set_previousRelationship(StyleSelectorRelationship value) { }

	public virtual string ToString() { }

}

