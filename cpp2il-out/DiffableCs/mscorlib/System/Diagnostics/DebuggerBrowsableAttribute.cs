namespace System.Diagnostics;

[AttributeUsage(384, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggerBrowsableAttribute : Attribute
{
	private DebuggerBrowsableState state; //Field offset: 0x10

	public DebuggerBrowsableAttribute(DebuggerBrowsableState state) { }

}

