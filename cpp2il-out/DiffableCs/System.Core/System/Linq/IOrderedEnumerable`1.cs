namespace System.Linq;

public interface IOrderedEnumerable : IEnumerable<TElement>, IEnumerable
{

	public IOrderedEnumerable<TElement> CreateOrderedEnumerable(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending) { }

}

