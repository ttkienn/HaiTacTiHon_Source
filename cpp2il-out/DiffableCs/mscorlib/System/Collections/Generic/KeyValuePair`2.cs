namespace System.Collections.Generic;

[IsReadOnly]
public struct KeyValuePair
{
	private readonly TKey key; //Field offset: 0x0
	private readonly TValue value; //Field offset: 0x0

	public TKey Key
	{
		 get { } //Length: 10
	}

	public TValue Value
	{
		 get { } //Length: 5
	}

	public KeyValuePair`2(TKey key, TValue value) { }

	public void Deconstruct(out TKey key, out TValue value) { }

	public TKey get_Key() { }

	public TValue get_Value() { }

	public virtual string ToString() { }

}

