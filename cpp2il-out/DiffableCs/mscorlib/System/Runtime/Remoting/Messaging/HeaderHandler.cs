namespace System.Runtime.Remoting.Messaging;

[ComVisible(True)]
public sealed class HeaderHandler : MulticastDelegate
{

	public HeaderHandler(object object, IntPtr method) { }

	public override object Invoke(Header[] headers) { }

}

