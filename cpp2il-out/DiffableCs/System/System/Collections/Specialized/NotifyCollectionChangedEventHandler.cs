namespace System.Collections.Specialized;

public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate
{

	public NotifyCollectionChangedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

}

