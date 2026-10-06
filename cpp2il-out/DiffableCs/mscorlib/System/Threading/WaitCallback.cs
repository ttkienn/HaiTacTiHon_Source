namespace System.Threading;

[ComVisible(True)]
public sealed class WaitCallback : MulticastDelegate
{

	public WaitCallback(object object, IntPtr method) { }

	public override void Invoke(object state) { }

}

