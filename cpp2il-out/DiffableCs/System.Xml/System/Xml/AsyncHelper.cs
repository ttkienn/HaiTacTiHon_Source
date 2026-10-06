namespace System.Xml;

[Extension]
internal static class AsyncHelper
{
	public static readonly Task DoneTask; //Field offset: 0x0
	public static readonly Task<Boolean> DoneTaskTrue; //Field offset: 0x8
	public static readonly Task<Boolean> DoneTaskFalse; //Field offset: 0x10
	public static readonly Task<Int32> DoneTaskZero; //Field offset: 0x18

	private static AsyncHelper() { }

}

