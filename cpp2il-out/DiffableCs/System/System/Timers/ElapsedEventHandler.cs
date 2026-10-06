namespace System.Timers;

public sealed class ElapsedEventHandler : MulticastDelegate
{

	public ElapsedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, ElapsedEventArgs e) { }

}

