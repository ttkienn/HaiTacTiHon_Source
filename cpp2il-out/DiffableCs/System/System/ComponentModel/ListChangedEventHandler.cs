namespace System.ComponentModel;

public sealed class ListChangedEventHandler : MulticastDelegate
{

	public ListChangedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, ListChangedEventArgs e) { }

}

