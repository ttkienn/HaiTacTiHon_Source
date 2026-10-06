namespace System.Runtime.Serialization;

[IsReadOnly]
public struct SerializationEntry
{
	private readonly string _name; //Field offset: 0x0
	private readonly object _value; //Field offset: 0x8
	private readonly Type _type; //Field offset: 0x10

	public string Name
	{
		 get { } //Length: 4
	}

	public object Value
	{
		 get { } //Length: 5
	}

	internal SerializationEntry(string entryName, object entryValue, Type entryType) { }

	public string get_Name() { }

	public object get_Value() { }

}

