namespace UnityEngine.UIElements;

internal class StyleVariableContext
{
	[CompilerGenerated]
	private struct <>c__DisplayClass7_0
	{
		public int hash; //Field offset: 0x0

	}

	public static readonly StyleVariableContext none; //Field offset: 0x0
	private int m_VariableHash; //Field offset: 0x10
	private List<StyleVariable> m_Variables; //Field offset: 0x18
	private List<Int32> m_SortedHash; //Field offset: 0x20
	private List<Int32> m_UnsortedHash; //Field offset: 0x28

	private static StyleVariableContext() { }

	public StyleVariableContext() { }

	public StyleVariableContext(StyleVariableContext other) { }

	[CompilerGenerated]
	internal static int <Add>g__ComputeOrderSensitiveHash|7_0(int index, ref <>c__DisplayClass7_0 unnamed_param_1) { }

	public void Add(StyleVariable sv) { }

	public void AddInitialRange(StyleVariableContext other) { }

	public void Clear() { }

	public int GetVariableHash() { }

	public bool TryFindVariable(string name, out StyleVariable v) { }

}

