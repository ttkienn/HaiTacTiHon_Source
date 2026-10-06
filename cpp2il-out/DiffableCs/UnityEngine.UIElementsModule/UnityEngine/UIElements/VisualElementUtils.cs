namespace UnityEngine.UIElements;

[Extension]
internal static class VisualElementUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<VisualElement> <>9__5_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <AssignInspectorStyleIfNecessary>b__5_0(VisualElement i) { }

	}

	private static readonly HashSet<String> s_usedNames; //Field offset: 0x0
	private static readonly Type s_FoldoutType; //Field offset: 0x8
	private static readonly string s_InspectorElementUssClassName; //Field offset: 0x10

	private static VisualElementUtils() { }

	[Extension]
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	[Extension]
	internal static int GetFoldoutDepth(VisualElement element) { }

	public static string GetUniqueName(string nameBase) { }

}

