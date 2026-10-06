namespace System.Xml.Linq;

public class XCData : XText
{

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public XCData(string value) { }

	public XCData(XCData other) { }

	internal virtual XNode CloneNode() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual void WriteTo(XmlWriter writer) { }

}

