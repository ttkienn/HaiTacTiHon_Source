namespace UnityEngine.UIElements.StyleSheets;

internal static class StylePropertyCache
{
	internal static readonly Dictionary<String, String> s_PropertySyntaxCache; //Field offset: 0x0
	internal static readonly Dictionary<String, String> s_NonTerminalValues; //Field offset: 0x8

	private static StylePropertyCache() { }

	public static bool TryGetNonTerminalValue(string name, out string syntax) { }

	public static bool TryGetSyntax(string name, out string syntax) { }

}

