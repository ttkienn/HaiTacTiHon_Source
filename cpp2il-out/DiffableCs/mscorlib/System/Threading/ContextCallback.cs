namespace System.Threading;

[ComVisible(True)]
public sealed class ContextCallback : MulticastDelegate
{

	public ContextCallback(object object, IntPtr method) { }

	public override void Invoke(object state) { }

}

