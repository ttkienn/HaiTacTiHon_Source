namespace System.Xml.Serialization;

[AttributeUsage(10624)]
public class XmlAttributeAttribute : Attribute
{
	private string attributeName; //Field offset: 0x10
	private string dataType; //Field offset: 0x18
	private Type type; //Field offset: 0x20
	private XmlSchemaForm form; //Field offset: 0x28
	private string ns; //Field offset: 0x30

	public string AttributeName
	{
		 get { } //Length: 77
	}

	public string DataType
	{
		 get { } //Length: 77
		 set { } //Length: 13
	}

	public XmlSchemaForm Form
	{
		 get { } //Length: 4
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public XmlAttributeAttribute(string attributeName) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_AttributeName() { }

	public string get_DataType() { }

	public XmlSchemaForm get_Form() { }

	public string get_Namespace() { }

	public void set_DataType(string value) { }

}

