namespace System.Xml;

internal class XmlTextWriterBase64Encoder : Base64Encoder
{
	private XmlTextEncoder xmlTextEncoder; //Field offset: 0x28

	internal XmlTextWriterBase64Encoder(XmlTextEncoder xmlTextEncoder) { }

	internal virtual void WriteChars(Char[] chars, int index, int count) { }

}

