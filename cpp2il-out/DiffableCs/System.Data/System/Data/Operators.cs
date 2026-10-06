namespace System.Data;

internal sealed class Operators
{
	private static readonly Int32[] s_priority; //Field offset: 0x0
	private static readonly String[] s_looks; //Field offset: 0x8

	private static Operators() { }

	internal static bool IsArithmetical(int op) { }

	internal static bool IsLogical(int op) { }

	internal static bool IsRelational(int op) { }

	internal static int Priority(int op) { }

	internal static string ToString(int op) { }

}

