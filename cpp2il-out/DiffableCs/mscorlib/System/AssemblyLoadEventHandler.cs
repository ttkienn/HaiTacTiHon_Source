namespace System;

public sealed class AssemblyLoadEventHandler : MulticastDelegate
{

	public AssemblyLoadEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, AssemblyLoadEventArgs args) { }

}

