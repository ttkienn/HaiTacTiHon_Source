namespace System.IO;

[Extension]
internal static class MonoLinqHelper
{

	[Extension]
	public static T[] ToArray(IEnumerable<T> source) { }

}

