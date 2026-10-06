namespace System.Threading;

[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment
{
	internal readonly T[] _elements; //Field offset: 0x0
	internal int _freeCount; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> _next; //Field offset: 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; //Field offset: 0x0

	internal T Item
	{
		internal get { } //Length: 53
	}

	internal int Length
	{
		internal get { } //Length: 26
	}

	internal SparselyPopulatedArrayFragment<T> Prev
	{
		internal get { } //Length: 24
	}

	internal SparselyPopulatedArrayFragment`1(int size) { }

	internal SparselyPopulatedArrayFragment`1(int size, SparselyPopulatedArrayFragment<T> prev) { }

	internal T get_Item(int index) { }

	internal int get_Length() { }

	internal SparselyPopulatedArrayFragment<T> get_Prev() { }

	internal T SafeAtomicRemove(int index, T expectedElement) { }

}

