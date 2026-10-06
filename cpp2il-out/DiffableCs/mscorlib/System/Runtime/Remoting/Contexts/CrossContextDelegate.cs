namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public sealed class CrossContextDelegate : MulticastDelegate
{

	public CrossContextDelegate(object object, IntPtr method) { }

	public override void Invoke() { }

}

