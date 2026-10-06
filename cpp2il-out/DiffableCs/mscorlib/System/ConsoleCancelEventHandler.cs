namespace System;

public sealed class ConsoleCancelEventHandler : MulticastDelegate
{

	public ConsoleCancelEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, ConsoleCancelEventArgs e) { }

}

