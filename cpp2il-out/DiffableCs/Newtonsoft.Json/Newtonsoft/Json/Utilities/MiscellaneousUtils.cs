namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
internal static class MiscellaneousUtils
{

	[Conditional("DEBUG")]
	[NullableContext(2)]
	public static void Assert(bool condition, string message = null) { }

	public static int ByteArrayCompare(Byte[] a1, Byte[] a2) { }

	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	public static string GetLocalName(string qualifiedName) { }

	public static string GetPrefix(string qualifiedName) { }

	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	internal static RegexOptions GetRegexOptions(string optionsText) { }

	public static string ToString(object value) { }

	[NullableContext(2)]
	public static bool ValueEquals(object objA, object objB) { }

}

