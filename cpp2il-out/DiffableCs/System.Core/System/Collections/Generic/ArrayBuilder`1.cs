namespace System.Collections.Generic;

[DefaultMember("Item")]
internal struct ArrayBuilder
{
	private T[] _array; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public ArrayBuilder`1(int capacity) { }

	public T[] ToArray() { }

	public void UncheckedAdd(T item) { }

}

