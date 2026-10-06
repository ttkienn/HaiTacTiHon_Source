namespace System.Xml.Serialization;

public class UnreferencedObjectEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private string id; //Field offset: 0x18

	public UnreferencedObjectEventArgs(object o, string id) { }

}

