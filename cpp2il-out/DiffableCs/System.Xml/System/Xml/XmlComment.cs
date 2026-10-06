namespace System.Xml;

public class XmlComment : XmlCharacterData
{

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

	protected private XmlComment(string comment, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

