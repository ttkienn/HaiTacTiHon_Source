namespace System.Xml.Serialization;

[AttributeUsage(AttributeTargets::Field (256))]
public class XmlEnumAttribute : Attribute
{
	private string name; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 5
	}

	public XmlEnumAttribute(string name) { }

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_Name() { }

}

