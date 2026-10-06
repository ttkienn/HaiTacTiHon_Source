namespace System.Linq.Expressions.Interpreter;

internal sealed class DebugInfo
{
	private class DebugInfoComparer : IComparer<DebugInfo>
	{

		public DebugInfoComparer() { }

		private override int System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(DebugInfo d1, DebugInfo d2) { }

	}

	private static readonly DebugInfoComparer s_debugComparer; //Field offset: 0x0
	public int StartLine; //Field offset: 0x10
	public int EndLine; //Field offset: 0x14
	public int Index; //Field offset: 0x18
	public string FileName; //Field offset: 0x20
	public bool IsClear; //Field offset: 0x28

	private static DebugInfo() { }

	public DebugInfo() { }

	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) { }

	public virtual string ToString() { }

}

