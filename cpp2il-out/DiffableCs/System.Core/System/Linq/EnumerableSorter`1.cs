namespace System.Linq;

internal abstract class EnumerableSorter
{

	protected EnumerableSorter`1() { }

	internal abstract int CompareKeys(int index1, int index2) { }

	internal abstract void ComputeKeys(TElement[] elements, int count) { }

	private void QuickSort(Int32[] map, int left, int right) { }

	internal Int32[] Sort(TElement[] elements, int count) { }

}

