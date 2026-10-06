namespace System.Linq;

internal class EnumerableSorter : EnumerableSorter<TElement>
{
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	internal IComparer<TKey> comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0
	internal EnumerableSorter<TElement> next; //Field offset: 0x0
	internal TKey[] keys; //Field offset: 0x0

	internal EnumerableSorter`2(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next) { }

	internal virtual int CompareKeys(int index1, int index2) { }

	internal virtual void ComputeKeys(TElement[] elements, int count) { }

}

