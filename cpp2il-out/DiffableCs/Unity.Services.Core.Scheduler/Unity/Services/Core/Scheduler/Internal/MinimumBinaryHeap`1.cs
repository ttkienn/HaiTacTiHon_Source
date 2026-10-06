namespace Unity.Services.Core.Scheduler.Internal;

internal class MinimumBinaryHeap : MinimumBinaryHeap
{
	[CompilerGenerated]
	private struct <>c__DisplayClass21_0
	{
		public int smallest; //Field offset: 0x0
		public int currentIndex; //Field offset: 0x0
		public MinimumBinaryHeap<T> <>4__this; //Field offset: 0x0

	}

	private readonly object m_Lock; //Field offset: 0x0
	private readonly IComparer<T> m_Comparer; //Field offset: 0x0
	private readonly int m_MinimumCapacity; //Field offset: 0x0
	private T[] m_HeapArray; //Field offset: 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public T Min
	{
		 get { } //Length: 39
	}

	public MinimumBinaryHeap`1(IComparer<T> comparer, int minimumCapacity = 10) { }

	internal MinimumBinaryHeap`1(ICollection<T> collection, IComparer<T> comparer, int minimumCapacity = 10) { }

	[CompilerGenerated]
	private void <MinHeapify>g__UpdateSmallestIfCandidateIsSmaller|21_1(int candidate, ref <>c__DisplayClass21_0<T> unnamed_param_1) { }

	[CompilerGenerated]
	private void <MinHeapify>g__UpdateSmallestIndex|21_0(ref <>c__DisplayClass21_0<T> unnamed_param_0) { }

	private void DecreaseHeapCapacityWhenSpare() { }

	public T ExtractMin() { }

	[CompilerGenerated]
	public int get_Count() { }

	public T get_Min() { }

	private static int GetLeftChildIndex(int index) { }

	private static int GetParentIndex(int index) { }

	private static int GetRightChildIndex(int index) { }

	private void IncreaseHeapCapacityWhenFull() { }

	private int IndexOf(T item) { }

	public void Insert(T item) { }

	private void MinHeapify() { }

	public void Remove(T item) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	private static void Swap(ref T lhs, ref T rhs) { }

}

