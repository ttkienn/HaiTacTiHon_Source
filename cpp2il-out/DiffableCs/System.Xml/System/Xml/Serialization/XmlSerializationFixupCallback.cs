namespace System.Xml.Serialization;

public sealed class XmlSerializationFixupCallback : MulticastDelegate
{

	public XmlSerializationFixupCallback(object object, IntPtr method) { }

	public override void Invoke(object fixup) { }

}

