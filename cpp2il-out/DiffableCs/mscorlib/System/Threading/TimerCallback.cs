namespace System.Threading;

[ComVisible(True)]
public sealed class TimerCallback : MulticastDelegate
{

	public TimerCallback(object object, IntPtr method) { }

	public override void Invoke(object state) { }

}

