namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute
{
	private string value; //Field offset: 0x10

	public string Value
	{
		 get { } //Length: 5
	}

	public string get_Value() { }

}

