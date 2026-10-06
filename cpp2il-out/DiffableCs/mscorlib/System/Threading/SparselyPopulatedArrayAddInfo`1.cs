namespace System.Threading;

internal struct SparselyPopulatedArrayAddInfo
{
	private SparselyPopulatedArrayFragment<T> _source; //Field offset: 0x0
	private int _index; //Field offset: 0x0

	internal int Index
	{
		internal get { } //Length: 4
	}

	internal SparselyPopulatedArrayFragment<T> Source
	{
		internal get { } //Length: 4
	}

	internal SparselyPopulatedArrayAddInfo`1(SparselyPopulatedArrayFragment<T> source, int index) { }

	internal int get_Index() { }

	internal SparselyPopulatedArrayFragment<T> get_Source() { }

}

