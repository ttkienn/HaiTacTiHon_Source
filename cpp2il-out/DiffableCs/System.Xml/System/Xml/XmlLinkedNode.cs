namespace System.Xml;

public abstract class XmlLinkedNode : XmlNode
{
	internal XmlLinkedNode next; //Field offset: 0x18

	public virtual XmlNode NextSibling
	{
		 get { } //Length: 93
	}

	public virtual XmlNode PreviousSibling
	{
		 get { } //Length: 130
	}

	internal XmlLinkedNode(XmlDocument doc) { }

	public virtual XmlNode get_NextSibling() { }

	public virtual XmlNode get_PreviousSibling() { }

}

