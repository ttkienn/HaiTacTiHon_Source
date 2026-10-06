namespace System.Runtime.Serialization;

internal class LongList
{
	private Int64[] m_values; //Field offset: 0x10
	private int m_count; //Field offset: 0x18
	private int m_totalItems; //Field offset: 0x1C
	private int m_currentItem; //Field offset: 0x20

	internal int Count
	{
		internal get { } //Length: 4
	}

	internal long Current
	{
		internal get { } //Length: 43
	}

	internal LongList() { }

	internal LongList(int startingSize) { }

	internal void Add(long value) { }

	private void EnlargeArray() { }

	internal int get_Count() { }

	internal long get_Current() { }

	internal bool MoveNext() { }

	internal bool RemoveElement(long value) { }

	internal void StartEnumeration() { }

}

