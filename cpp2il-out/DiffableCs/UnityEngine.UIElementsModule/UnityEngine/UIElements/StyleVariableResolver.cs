namespace UnityEngine.UIElements;

internal class StyleVariableResolver
{
	private struct ResolveContext
	{
		public StyleSheet sheet; //Field offset: 0x0
		public StyleValueHandle[] handles; //Field offset: 0x8

	}

	private enum Result
	{
		Valid = 0,
		Invalid = 1,
		NotFound = 2,
	}

	internal const int kMaxResolves = 100; //Field offset: 0x0
	private static StyleSyntaxParser s_SyntaxParser; //Field offset: 0x0
	private StylePropertyValueMatcher m_Matcher; //Field offset: 0x10
	private List<StylePropertyValue> m_ResolvedValues; //Field offset: 0x18
	private Stack<String> m_ResolvedVarStack; //Field offset: 0x20
	private StyleProperty m_Property; //Field offset: 0x28
	private Stack<ResolveContext> m_ContextStack; //Field offset: 0x30
	private ResolveContext m_CurrentContext; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private StyleVariableContext <variableContext>k__BackingField; //Field offset: 0x48

	private StyleValueHandle[] currentHandles
	{
		private get { } //Length: 5
	}

	private StyleSheet currentSheet
	{
		private get { } //Length: 5
	}

	public List<StylePropertyValue> resolvedValues
	{
		 get { } //Length: 5
	}

	public StyleVariableContext variableContext
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	private static StyleVariableResolver() { }

	public StyleVariableResolver() { }

	public void AddValue(StyleValueHandle handle) { }

	private StyleValueHandle[] get_currentHandles() { }

	private StyleSheet get_currentSheet() { }

	public List<StylePropertyValue> get_resolvedValues() { }

	[CompilerGenerated]
	public StyleVariableContext get_variableContext() { }

	public void Init(StyleProperty property, StyleSheet sheet, StyleValueHandle[] handles) { }

	private static void ParseVarFunction(StyleSheet sheet, StyleValueHandle[] handles, ref int index, out int argCount, out string variableName) { }

	private void PopContext() { }

	private void PushContext(StyleSheet sheet, StyleValueHandle[] handles) { }

	private Result ResolveFallback(ref int index) { }

	public bool ResolveVarFunction(ref int index) { }

	private Result ResolveVarFunction(ref int index, int argc, string varName) { }

	private Result ResolveVariable(string variableName) { }

	[CompilerGenerated]
	public void set_variableContext(StyleVariableContext value) { }

	public bool ValidateResolvedValues() { }

}

