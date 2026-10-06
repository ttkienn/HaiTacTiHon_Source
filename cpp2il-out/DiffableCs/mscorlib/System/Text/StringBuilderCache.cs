namespace System.Text;

internal static class StringBuilderCache
{
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; //Field offset: 0x80000000

	public static StringBuilder Acquire(int capacity = 16) { }

	public static string GetStringAndRelease(StringBuilder sb) { }

	public static void Release(StringBuilder sb) { }

}

