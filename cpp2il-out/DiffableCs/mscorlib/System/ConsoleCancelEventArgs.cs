namespace System;

public sealed class ConsoleCancelEventArgs : EventArgs
{
	private readonly ConsoleSpecialKey _type; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Cancel>k__BackingField; //Field offset: 0x14

	public bool Cancel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ConsoleCancelEventArgs(ConsoleSpecialKey type) { }

	internal ConsoleCancelEventArgs() { }

	[CompilerGenerated]
	public bool get_Cancel() { }

}

