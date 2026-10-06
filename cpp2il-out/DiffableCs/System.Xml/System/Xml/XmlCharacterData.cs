namespace System.Xml;

public abstract class XmlCharacterData : XmlLinkedNode
{
	private string data; //Field offset: 0x20

	public override string Data
	{
		 get { } //Length: 77
		 set { } //Length: 218
	}

	public virtual string InnerText
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	public virtual string Value
	{
		 get { } //Length: 20
		 set { } //Length: 20
	}

	protected private XmlCharacterData(string data, XmlDocument doc) { }

	internal bool CheckOnData(string data) { }

	public override string get_Data() { }

	public virtual string get_InnerText() { }

	public virtual string get_Value() { }

	public override void set_Data(string value) { }

	public virtual void set_InnerText(string value) { }

	public virtual void set_Value(string value) { }

}

