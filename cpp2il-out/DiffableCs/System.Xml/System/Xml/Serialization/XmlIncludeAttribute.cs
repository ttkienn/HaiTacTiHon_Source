namespace System.Xml.Serialization;

[AttributeUsage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute
{
	private Type type; //Field offset: 0x10

	public Type Type
	{
		 get { } //Length: 5
	}

	public Type get_Type() { }

}

