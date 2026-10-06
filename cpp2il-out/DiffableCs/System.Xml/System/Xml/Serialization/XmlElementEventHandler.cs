namespace System.Xml.Serialization;

public sealed class XmlElementEventHandler : MulticastDelegate
{

	public XmlElementEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, XmlElementEventArgs e) { }

}

