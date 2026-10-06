namespace System.Xml;

public class XmlNodeChangedEventArgs : EventArgs
{
	private XmlNodeChangedAction action; //Field offset: 0x10
	private XmlNode node; //Field offset: 0x18
	private XmlNode oldParent; //Field offset: 0x20
	private XmlNode newParent; //Field offset: 0x28
	private string oldValue; //Field offset: 0x30
	private string newValue; //Field offset: 0x38

	public XmlNodeChangedAction Action
	{
		 get { } //Length: 191
	}

	public XmlNodeChangedEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	public XmlNodeChangedAction get_Action() { }

}

