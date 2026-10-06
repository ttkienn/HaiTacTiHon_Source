namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute
{
	private string elementName; //Field offset: 0x10
	private string ns; //Field offset: 0x18
	private int order; //Field offset: 0x20

	public string Name
	{
		 get { } //Length: 77
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public int Order
	{
		 get { } //Length: 4
	}

	public XmlAnyElementAttribute() { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_Name() { }

	public string get_Namespace() { }

	public int get_Order() { }

}

