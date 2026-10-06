namespace UnityEngine.UIElements;

[Extension]
internal static class StyleValueExtensions
{

	[Extension]
	internal static void CopyFrom(List<T> list, List<T> other) { }

	[Extension]
	internal static string DebugString(IStyleValue<T> styleValue) { }

	[Extension]
	internal static Length ToLength(StyleKeyword keyword) { }

	[Extension]
	internal static Length ToLength(StyleLength styleLength) { }

	[Extension]
	internal static Rotate ToRotate(StyleKeyword keyword) { }

	[Extension]
	internal static Scale ToScale(StyleKeyword keyword) { }

	[Extension]
	internal static Translate ToTranslate(StyleKeyword keyword) { }

	[Extension]
	internal static YogaValue ToYogaValue(Length length) { }

}

