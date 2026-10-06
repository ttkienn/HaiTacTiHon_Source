namespace System;

public sealed class EventHandler : MulticastDelegate
{

	public EventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, EventArgs e) { }

}

