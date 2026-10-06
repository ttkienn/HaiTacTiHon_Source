namespace System.Threading;

[ComVisible(True)]
public sealed class WaitOrTimerCallback : MulticastDelegate
{

	public WaitOrTimerCallback(object object, IntPtr method) { }

	public override void Invoke(object state, bool timedOut) { }

}

