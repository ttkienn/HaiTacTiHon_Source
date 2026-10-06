namespace System.Runtime.Serialization;

[AttributeUsage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute
{
	private bool isReference; //Field offset: 0x10

	public bool IsReference
	{
		 get { } //Length: 5
	}

	public bool get_IsReference() { }

}

