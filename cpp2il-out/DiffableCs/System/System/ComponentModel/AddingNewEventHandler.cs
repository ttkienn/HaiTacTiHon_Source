namespace System.ComponentModel;

public sealed class AddingNewEventHandler : MulticastDelegate
{

	public AddingNewEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, AddingNewEventArgs e) { }

}

