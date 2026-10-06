namespace System.Linq;

internal class OrderedEnumerable : OrderedEnumerable<TElement>
{
	internal OrderedEnumerable<TElement> parent; //Field offset: 0x0
	internal Func<TElement, TKey> keySelector; //Field offset: 0x0
	internal IComparer<TKey> comparer; //Field offset: 0x0
	internal bool descending; //Field offset: 0x0

	internal OrderedEnumerable`2(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

	internal virtual EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next) { }

}

