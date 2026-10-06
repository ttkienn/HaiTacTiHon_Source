namespace System.Xml.Serialization;

public class XmlReflectionMember
{
	private bool isReturnValue; //Field offset: 0x10
	private string memberName; //Field offset: 0x18
	private Type memberType; //Field offset: 0x20
	private XmlAttributes xmlAttributes; //Field offset: 0x28
	private Type declaringType; //Field offset: 0x30

	internal Type DeclaringType
	{
		internal get { } //Length: 5
		internal set { } //Length: 13
	}

	public bool IsReturnValue
	{
		 get { } //Length: 5
	}

	public string MemberName
	{
		 get { } //Length: 5
	}

	public Type MemberType
	{
		 get { } //Length: 5
	}

	public XmlAttributes XmlAttributes
	{
		 get { } //Length: 105
	}

	internal XmlReflectionMember(string name, Type type, XmlAttributes attributes) { }

	internal Type get_DeclaringType() { }

	public bool get_IsReturnValue() { }

	public string get_MemberName() { }

	public Type get_MemberType() { }

	public XmlAttributes get_XmlAttributes() { }

	internal void set_DeclaringType(Type value) { }

}

