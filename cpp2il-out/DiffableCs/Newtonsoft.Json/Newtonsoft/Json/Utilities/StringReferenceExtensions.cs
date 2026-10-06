namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
internal static class StringReferenceExtensions
{

	[Extension]
	public static bool EndsWith(StringReference s, string text) { }

	[Extension]
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[Extension]
	public static bool StartsWith(StringReference s, string text) { }

}

