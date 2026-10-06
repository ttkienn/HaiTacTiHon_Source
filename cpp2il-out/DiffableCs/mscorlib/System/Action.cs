namespace System;

public sealed class Action : MulticastDelegate
{

	public Action(object object, IntPtr method) { }

	public override void Invoke() { }

}

