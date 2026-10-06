namespace System.Xml.Serialization;

public sealed class UnreferencedObjectEventHandler : MulticastDelegate
{

	public UnreferencedObjectEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, UnreferencedObjectEventArgs e) { }

}

