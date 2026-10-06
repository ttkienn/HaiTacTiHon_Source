namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute
{
	private string name; //Field offset: 0x10
	private int order; //Field offset: 0x18
	private bool isRequired; //Field offset: 0x1C
	private bool emitDefaultValue; //Field offset: 0x1D

	public bool EmitDefaultValue
	{
		 get { } //Length: 5
	}

	public bool IsRequired
	{
		 get { } //Length: 5
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public int Order
	{
		 get { } //Length: 4
	}

	public bool get_EmitDefaultValue() { }

	public bool get_IsRequired() { }

	public string get_Name() { }

	public int get_Order() { }

}

