namespace System.Threading;

public sealed class ParameterizedThreadStart : MulticastDelegate
{

	public ParameterizedThreadStart(object object, IntPtr method) { }

	public override void Invoke(object obj) { }

}

