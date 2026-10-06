namespace System.Linq;

internal class GroupedEnumerable : IEnumerable<IGrouping`2<TKey, TElement>>, IEnumerable
{
	private IEnumerable<TSource> source; //Field offset: 0x0
	private Func<TSource, TKey> keySelector; //Field offset: 0x0
	private Func<TSource, TElement> elementSelector; //Field offset: 0x0
	private IEqualityComparer<TKey> comparer; //Field offset: 0x0

	public GroupedEnumerable`3(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }

	public override IEnumerator<IGrouping`2<TKey, TElement>> GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

