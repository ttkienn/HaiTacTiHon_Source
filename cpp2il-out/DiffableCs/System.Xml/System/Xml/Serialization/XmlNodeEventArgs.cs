namespace System.Xml.Serialization;

public class XmlNodeEventArgs : EventArgs
{
	private object o; //Field offset: 0x10
	private XmlNode xmlNode; //Field offset: 0x18
	private int lineNumber; //Field offset: 0x20
	private int linePosition; //Field offset: 0x24

	internal XmlNodeEventArgs(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }

}

