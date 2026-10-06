namespace System.Threading;

public sealed class SendOrPostCallback : MulticastDelegate
{

	public SendOrPostCallback(object object, IntPtr method) { }

	public override void Invoke(object state) { }

}

