namespace System.Linq;

internal class Set
{
	public struct Slot
	{
		internal int hashCode; //Field offset: 0x0
		internal TElement value; //Field offset: 0x0
		internal int next; //Field offset: 0x0

	}

	private Int32[] buckets; //Field offset: 0x0
	private Slot<TElement>[] slots; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private int freeList; //Field offset: 0x0
	private IEqualityComparer<TElement> comparer; //Field offset: 0x0

	public Set`1(IEqualityComparer<TElement> comparer) { }

	public bool Add(TElement value) { }

	private bool Find(TElement value, bool add) { }

	internal int InternalGetHashCode(TElement value) { }

	private void Resize() { }

}

