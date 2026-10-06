namespace System.Xml.Linq;

public class XText : XNode
{
	internal string text; //Field offset: 0x28

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public string Value
	{
		 get { } //Length: 5
		 set { } //Length: 282
	}

	public XText(string value) { }

	public XText(XText other) { }

	internal virtual void AppendText(StringBuilder sb) { }

	internal virtual XNode CloneNode() { }

	public virtual XmlNodeType get_NodeType() { }

	public string get_Value() { }

	public void set_Value(string value) { }

	public virtual void WriteTo(XmlWriter writer) { }

}

