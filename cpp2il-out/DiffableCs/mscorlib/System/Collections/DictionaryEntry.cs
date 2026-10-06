namespace System.Collections;

public struct DictionaryEntry
{
	private object _key; //Field offset: 0x0
	private object _value; //Field offset: 0x8

	public object Key
	{
		 get { } //Length: 4
	}

	public object Value
	{
		 get { } //Length: 5
	}

	public DictionaryEntry(object key, object value) { }

	public object get_Key() { }

	public object get_Value() { }

}

