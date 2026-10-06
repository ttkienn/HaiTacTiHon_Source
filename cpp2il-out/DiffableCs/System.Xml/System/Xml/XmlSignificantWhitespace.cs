namespace System.Xml;

public class XmlSignificantWhitespace : XmlCharacterData
{

	internal virtual bool IsText
	{
		internal get { } //Length: 3
	}

	public virtual string LocalName
	{
		 get { } //Length: 45
	}

	public virtual string Name
	{
		 get { } //Length: 45
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	public virtual XmlNode ParentNode
	{
		 get { } //Length: 163
	}

	public virtual string Value
	{
		 get { } //Length: 20
		 set { } //Length: 149
	}

	protected private XmlSignificantWhitespace(string strData, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	internal virtual bool get_IsText() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual XmlNode get_ParentNode() { }

	public virtual string get_Value() { }

	public virtual void set_Value(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

