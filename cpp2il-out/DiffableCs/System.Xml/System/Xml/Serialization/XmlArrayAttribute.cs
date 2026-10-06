namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute
{
	private string elementName; //Field offset: 0x10
	private XmlSchemaForm form; //Field offset: 0x18
	private bool isNullable; //Field offset: 0x1C
	private string ns; //Field offset: 0x20
	private int order; //Field offset: 0x28

	public string ElementName
	{
		 get { } //Length: 77
	}

	public XmlSchemaForm Form
	{
		 get { } //Length: 4
	}

	public bool IsNullable
	{
		 get { } //Length: 5
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public int Order
	{
		 get { } //Length: 4
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	public string get_Namespace() { }

	public int get_Order() { }

}

