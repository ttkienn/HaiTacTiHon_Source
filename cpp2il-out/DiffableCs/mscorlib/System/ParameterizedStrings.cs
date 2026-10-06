namespace System;

internal static class ParameterizedStrings
{
	internal struct FormatParam
	{
		private readonly int _int32; //Field offset: 0x0
		private readonly string _string; //Field offset: 0x8

		public int Int32
		{
			 get { } //Length: 3
		}

		public object Object
		{
			 get { } //Length: 75
		}

		public string String
		{
			 get { } //Length: 69
		}

		public FormatParam(int value) { }

		private FormatParam(int intValue, string stringValue) { }

		public int get_Int32() { }

		public object get_Object() { }

		public string get_String() { }

		public static FormatParam op_Implicit(int value) { }

	}

	private sealed class LowLevelStack
	{
		private FormatParam[] _arr; //Field offset: 0x10
		private int _count; //Field offset: 0x18

		public LowLevelStack() { }

		public void Clear() { }

		public FormatParam Pop() { }

		public void Push(FormatParam item) { }

	}

	[ThreadStatic]
	private static LowLevelStack _cachedStack; //Field offset: 0x80000000

	private static bool AsBool(int i) { }

	private static int AsInt(bool b) { }

	public static string Evaluate(string format, FormatParam[] args) { }

	private static string EvaluateInternal(string format, ref int pos, FormatParam[] args, LowLevelStack stack, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars) { }

	private static string FormatPrintF(string format, object arg) { }

	private static FormatParam[] GetDynamicOrStaticVariables(char c, ref FormatParam[] dynamicVars, ref FormatParam[] staticVars, out int index) { }

	private static int snprintf(Byte* str, IntPtr size, string format, string arg1) { }

	private static int snprintf(Byte* str, IntPtr size, string format, int arg1) { }

	private static string StringFromAsciiBytes(Byte[] buffer, int offset, int length) { }

}

