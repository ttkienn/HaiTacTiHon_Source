namespace System.ComponentModel;

public sealed class CollectionChangeEventHandler : MulticastDelegate
{

	public CollectionChangeEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, CollectionChangeEventArgs e) { }

}

