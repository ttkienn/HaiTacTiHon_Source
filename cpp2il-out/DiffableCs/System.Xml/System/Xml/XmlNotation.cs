namespace System.Xml;

public class XmlNotation : XmlNode
{
	private string publicId; //Field offset: 0x18
	private string systemId; //Field offset: 0x20
	private string name; //Field offset: 0x28

	public virtual string InnerXml
	{
		 set { } //Length: 95
	}

	public virtual bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public virtual string LocalName
	{
		 get { } //Length: 5
	}

	public virtual string Name
	{
		 get { } //Length: 5
	}

	public virtual XmlNodeType NodeType
	{
		 get { } //Length: 6
	}

	internal XmlNotation(string name, string publicId, string systemId, XmlDocument doc) { }

	public virtual XmlNode CloneNode(bool deep) { }

	public virtual bool get_IsReadOnly() { }

	public virtual string get_LocalName() { }

	public virtual string get_Name() { }

	public virtual XmlNodeType get_NodeType() { }

	public virtual void set_InnerXml(string value) { }

	public virtual void WriteContentTo(XmlWriter w) { }

	public virtual void WriteTo(XmlWriter w) { }

}

