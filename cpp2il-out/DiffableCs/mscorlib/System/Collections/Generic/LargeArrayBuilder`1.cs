namespace System.Collections.Generic;

internal struct LargeArrayBuilder
{
	private readonly int _maxCapacity; //Field offset: 0x0
	private T[] _first; //Field offset: 0x0
	private ArrayBuilder<T[]> _buffers; //Field offset: 0x0
	private T[] _current; //Field offset: 0x0
	private int _index; //Field offset: 0x0
	private int _count; //Field offset: 0x0

	public LargeArrayBuilder`1(bool initialize) { }

	public LargeArrayBuilder`1(int maxCapacity) { }

	public void AddRange(IEnumerable<T> items) { }

	private void AddWithBufferAllocation(T item, ref T[] destination, ref int index) { }

	private void AllocateBuffer() { }

	public void CopyTo(T[] array, int arrayIndex, int count) { }

	public T[] GetBuffer(int index) { }

	public T[] ToArray() { }

	public bool TryMove(out T[] array) { }

}

