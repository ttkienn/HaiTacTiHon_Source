namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute
{
	private string dataType; //Field offset: 0x10
	private string elementName; //Field offset: 0x18
	private XmlSchemaForm form; //Field offset: 0x20
	private string ns; //Field offset: 0x28
	private bool isNullable; //Field offset: 0x30
	private bool isNullableSpecified; //Field offset: 0x31
	private int nestingLevel; //Field offset: 0x34
	private Type type; //Field offset: 0x38

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

	internal bool IsNullableSpecified
	{
		internal get { } //Length: 5
	}

	public string Namespace
	{
		 get { } //Length: 5
	}

	public int NestingLevel
	{
		 get { } //Length: 4
	}

	public Type Type
	{
		 get { } //Length: 5
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_DataType() { }

	public string get_ElementName() { }

	public XmlSchemaForm get_Form() { }

	public bool get_IsNullable() { }

	internal bool get_IsNullableSpecified() { }

	public string get_Namespace() { }

	public int get_NestingLevel() { }

	public Type get_Type() { }

}

