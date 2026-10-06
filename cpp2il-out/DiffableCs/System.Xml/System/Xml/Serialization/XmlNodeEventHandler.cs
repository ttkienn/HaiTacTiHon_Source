namespace System.Xml.Serialization;

public sealed class XmlNodeEventHandler : MulticastDelegate
{

	public XmlNodeEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, XmlNodeEventArgs e) { }

}

