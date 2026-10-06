namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute
{
	private string dataType; //Field offset: 0x10
	private string elementName; //Field offset: 0x18
	private XmlSchemaForm form; //Field offset: 0x20
	private string ns; //Field offset: 0x28
	private bool isNullable; //Field offset: 0x30
	private Type type; //Field offset: 0x38
	private int order; //Field offset: 0x40

	public string DataType
	{
		 get { } //Length: 77
	}

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

	public Type Type
	{
		 get { } //Length: 5
	}

	public XmlElementAttribute(string elementName) { }

	public XmlElementAttribute(string elementName, Type type) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	public string get_Namespace() { }

	public int get_Order() { }

	public Type get_Type() { }

}

