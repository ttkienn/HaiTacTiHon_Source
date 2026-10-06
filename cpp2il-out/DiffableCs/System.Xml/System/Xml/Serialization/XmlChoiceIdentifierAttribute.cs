namespace System.Xml.Serialization;

[AttributeUsage(10624, AllowMultiple = False)]
public class XmlChoiceIdentifierAttribute : Attribute
{
	private string memberName; //Field offset: 0x10

	public string MemberName
	{
		 get { } //Length: 77
	}

	internal void AddKeyHash(StringBuilder sb) { }

	public string get_MemberName() { }

}

