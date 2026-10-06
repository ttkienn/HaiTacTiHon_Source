namespace System.Collections.Generic;

internal class ArraySortHelper
{
	private static readonly ArraySortHelper<T> s_defaultArraySortHelper; //Field offset: 0x0

	public static ArraySortHelper<T> Default
	{
		 get { } //Length: 153
	}

	private static ArraySortHelper`1() { }

	public ArraySortHelper`1() { }

	public int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	private static void DownHeap(T[] keys, int i, int n, int lo, Comparison<T> comparer) { }

	public static ArraySortHelper<T> get_Default() { }

	private static void Heapsort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	private static void InsertionSort(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	internal static int InternalBinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	private static void IntroSort(T[] keys, int lo, int hi, int depthLimit, Comparison<T> comparer) { }

	internal static void IntrospectiveSort(T[] keys, int left, int length, Comparison<T> comparer) { }

	private static int PickPivotAndPartition(T[] keys, int lo, int hi, Comparison<T> comparer) { }

	public void Sort(T[] keys, int index, int length, IComparer<T> comparer) { }

	internal static void Sort(T[] keys, int index, int length, Comparison<T> comparer) { }

	private static void Swap(T[] a, int i, int j) { }

	private static void SwapIfGreater(T[] keys, Comparison<T> comparer, int a, int b) { }

}

