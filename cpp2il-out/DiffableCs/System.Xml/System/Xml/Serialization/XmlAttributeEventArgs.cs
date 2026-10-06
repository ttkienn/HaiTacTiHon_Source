namespace System.Xml.Serialization;

public class XmlAttributeEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private XmlAttribute attr; //Field offset: 0x18
	private string qnames; //Field offset: 0x20
	private int lineNumber; //Field offset: 0x28
	private int linePosition; //Field offset: 0x2C

	internal XmlAttributeEventArgs(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }

}

