namespace System.Collections.Generic;

internal class ArraySortHelper
{
	private static readonly ArraySortHelper<TKey, TValue> s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper<TKey, TValue> Default
	{
		 get { } //Length: 153
	}

	private static ArraySortHelper`2() { }

	public ArraySortHelper`2() { }

	private static void DownHeap(TKey[] keys, TValue[] values, int i, int n, int lo, IComparer<TKey> comparer) { }

	public static ArraySortHelper<TKey, TValue> get_Default() { }

	private static void Heapsort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	private static void InsertionSort(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	private static void IntroSort(TKey[] keys, TValue[] values, int lo, int hi, int depthLimit, IComparer<TKey> comparer) { }

	internal static void IntrospectiveSort(TKey[] keys, TValue[] values, int left, int length, IComparer<TKey> comparer) { }

	private static int PickPivotAndPartition(TKey[] keys, TValue[] values, int lo, int hi, IComparer<TKey> comparer) { }

	public void Sort(TKey[] keys, TValue[] values, int index, int length, IComparer<TKey> comparer) { }

	private static void Swap(TKey[] keys, TValue[] values, int i, int j) { }

	private static void SwapIfGreaterWithItems(TKey[] keys, TValue[] values, IComparer<TKey> comparer, int a, int b) { }

}

