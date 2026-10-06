namespace System.Threading;

internal class SparselyPopulatedArray
{
	private readonly SparselyPopulatedArrayFragment<T> _head; //Field offset: 0x0
	private SparselyPopulatedArrayFragment<T> _tail; //Field offset: 0x0

	internal SparselyPopulatedArrayFragment<T> Tail
	{
		internal get { } //Length: 24
	}

	internal SparselyPopulatedArray`1(int initialSize) { }

	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }

	internal SparselyPopulatedArrayFragment<T> get_Tail() { }

}

