namespace System.Diagnostics;

[AttributeUsage(3, AllowMultiple = False)]
[ComVisible(True)]
public sealed class DebuggableAttribute : Attribute
{
	[ComVisible(True)]
	[Flags]
	internal enum DebuggingModes
	{
		None = 0,
		Default = 1,
		DisableOptimizations = 256,
		IgnoreSymbolStoreSequencePoints = 2,
		EnableEditAndContinue = 4,
	}

	private DebuggingModes m_debuggingModes; //Field offset: 0x10

	public DebuggableAttribute(DebuggingModes modes) { }

}

