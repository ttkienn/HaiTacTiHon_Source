namespace System;

public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
{
	private sealed class ArrayEnumerator : IEnumerator, ICloneable
	{
		private Array _array; //Field offset: 0x10
		private int _index; //Field offset: 0x18
		private int _endIndex; //Field offset: 0x1C

		public override object Current
		{
			 get { } //Length: 361
		}

		internal ArrayEnumerator(Array array) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public class EmptyInternalEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		public static readonly EmptyInternalEnumerator<T> Value; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 73
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 46
		}

		private static EmptyInternalEnumerator`1() { }

		public EmptyInternalEnumerator`1() { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	public struct InternalEnumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Array array; //Field offset: 0x0
		private int idx; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 297
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 122
		}

		internal InternalEnumerator`1(Array array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

	}

	private class RawData
	{
		public IntPtr Bounds; //Field offset: 0x10
		public IntPtr Count; //Field offset: 0x18
		public byte Data; //Field offset: 0x20

	}

	private struct SorterGenericArray
	{
		private Array keys; //Field offset: 0x0
		private Array items; //Field offset: 0x8
		private IComparer comparer; //Field offset: 0x10

		internal SorterGenericArray(Array keys, Array items, IComparer comparer) { }

		private void DownHeap(int i, int n, int lo) { }

		private void Heapsort(int lo, int hi) { }

		private void InsertionSort(int lo, int hi) { }

		private void IntroSort(int lo, int hi, int depthLimit) { }

		private void IntrospectiveSort(int left, int length) { }

		private int PickPivotAndPartition(int lo, int hi) { }

		internal void Sort(int left, int length) { }

		private void Swap(int i, int j) { }

		internal void SwapIfGreaterWithItems(int a, int b) { }

	}

	private struct SorterObjectArray
	{
		private Object[] keys; //Field offset: 0x0
		private Object[] items; //Field offset: 0x8
		private IComparer comparer; //Field offset: 0x10

		internal SorterObjectArray(Object[] keys, Object[] items, IComparer comparer) { }

		private void DownHeap(int i, int n, int lo) { }

		private void Heapsort(int lo, int hi) { }

		private void InsertionSort(int lo, int hi) { }

		private void IntroSort(int lo, int hi, int depthLimit) { }

		private void IntrospectiveSort(int left, int length) { }

		private int PickPivotAndPartition(int lo, int hi) { }

		internal void Sort(int left, int length) { }

		private void Swap(int i, int j) { }

		internal void SwapIfGreaterWithItems(int a, int b) { }

	}


	public override bool IsFixedSize
	{
		 get { } //Length: 3
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 3
	}

	public override bool IsSynchronized
	{
		 get { } //Length: 3
	}

	public int Length
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 93
	}

	public long LongLength
	{
		 get { } //Length: 98
	}

	public int Rank
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 5
	}

	public override object SyncRoot
	{
		 get { } //Length: 4
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 93
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 8
		private set { } //Length: 17
	}

	private Array() { }

	public static ReadOnlyCollection<T> AsReadOnly(T[] array) { }

	public static int BinarySearch(Array array, object value, IComparer comparer) { }

	public static int BinarySearch(T[] array, int index, int length, T value) { }

	public static int BinarySearch(T[] array, T value, IComparer<T> comparer) { }

	public static int BinarySearch(T[] array, T value) { }

	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer) { }

	public static int BinarySearch(Array array, int index, int length, object value) { }

	public static int BinarySearch(Array array, object value) { }

	public static int BinarySearch(T[] array, int index, int length, T value, IComparer<T> comparer) { }

	private static bool CanAssignArrayElement(Type source, Type target) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void Clear(Array array, int index, int length) { }

	private static void ClearInternal(Array a, int index, int count) { }

	public override object Clone() { }

	internal static int CombineHashCodes(int h1, int h2) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	public static TOutput[] ConvertAll(TInput[] array, Converter<TInput, TOutput> converter) { }

	public static void Copy(Array sourceArray, Array destinationArray, long length) { }

	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static void Copy(Array sourceArray, Array destinationArray, int length) { }

	[ReliabilityContract(Consistency::MayCorruptInstance (2), Cer::MayFail (1))]
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length) { }

	public override void CopyTo(Array array, int index) { }

	public void CopyTo(Array array, long index) { }

	private static ArrayTypeMismatchException CreateArrayTypeMismatchException() { }

	public static Array CreateInstance(Type elementType, int length) { }

	public static Array CreateInstance(Type elementType, Int64[] lengths) { }

	public static Array CreateInstance(Type elementType, int length1, int length2, int length3) { }

	public static Array CreateInstance(Type elementType, Int32[] lengths, Int32[] lowerBounds) { }

	public static Array CreateInstance(Type elementType, Int32[] lengths) { }

	public static Array CreateInstance(Type elementType, int length1, int length2) { }

	internal static Array CreateInstanceImpl(Type elementType, Int32[] lengths, Int32[] bounds) { }

	public static T[] Empty() { }

	public static bool Exists(T[] array, Predicate<T> match) { }

	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length) { }

	public static void Fill(T[] array, T value, int startIndex, int count) { }

	public static void Fill(T[] array, T value) { }

	public static T Find(T[] array, Predicate<T> match) { }

	public static T[] FindAll(T[] array, Predicate<T> match) { }

	public static int FindIndex(T[] array, Predicate<T> match) { }

	public static int FindIndex(T[] array, int startIndex, Predicate<T> match) { }

	public static int FindIndex(T[] array, int startIndex, int count, Predicate<T> match) { }

	public static T FindLast(T[] array, Predicate<T> match) { }

	public static int FindLastIndex(T[] array, Predicate<T> match) { }

	public static int FindLastIndex(T[] array, int startIndex, Predicate<T> match) { }

	public static int FindLastIndex(T[] array, int startIndex, int count, Predicate<T> match) { }

	public static void ForEach(T[] array, Action<T> action) { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int get_Length() { }

	public long get_LongLength() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int get_Rank() { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	internal void GetGenericValueImpl(int pos, out T value) { }

	public int GetLength(int dimension) { }

	public long GetLongLength(int dimension) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int GetLowerBound(int dimension) { }

	private static int GetMedian(int low, int hi) { }

	private int GetRank() { }

	internal byte GetRawSzArrayData() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public int GetUpperBound(int dimension) { }

	public object GetValue(long index) { }

	public object GetValue(long index1, long index2) { }

	public object GetValue(long index1, long index2, long index3) { }

	public object GetValue(Int64[] indices) { }

	public object GetValue(Int32[] indices) { }

	public object GetValue(int index) { }

	public object GetValue(int index1, int index2) { }

	public object GetValue(int index1, int index2, int index3) { }

	internal object GetValueImpl(int pos) { }

	public static int IndexOf(Array array, object value) { }

	public static int IndexOf(T[] array, T value) { }

	public static int IndexOf(Array array, object value, int startIndex, int count) { }

	public static int IndexOf(T[] array, T value, int startIndex, int count) { }

	public static int IndexOf(T[] array, T value, int startIndex) { }

	public static int IndexOf(Array array, object value, int startIndex) { }

	private static int IndexOfImpl(T[] array, T value, int startIndex, int count) { }

	public void Initialize() { }

	internal T InternalArray__get_Item(int index) { }

	internal void InternalArray__ICollection_Add(T item) { }

	internal void InternalArray__ICollection_Clear() { }

	internal bool InternalArray__ICollection_Contains(T item) { }

	internal void InternalArray__ICollection_CopyTo(T[] array, int arrayIndex) { }

	internal int InternalArray__ICollection_get_Count() { }

	internal bool InternalArray__ICollection_get_IsReadOnly() { }

	internal bool InternalArray__ICollection_Remove(T item) { }

	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator() { }

	internal int InternalArray__IndexOf(T item) { }

	internal void InternalArray__Insert(int index, T item) { }

	internal int InternalArray__IReadOnlyCollection_get_Count() { }

	internal T InternalArray__IReadOnlyList_get_Item(int index) { }

	internal void InternalArray__RemoveAt(int index) { }

	internal void InternalArray__set_Item(int index, T item) { }

	public static int LastIndexOf(Array array, object value, int startIndex, int count) { }

	public static int LastIndexOf(Array array, object value, int startIndex) { }

	public static int LastIndexOf(T[] array, T value) { }

	public static int LastIndexOf(T[] array, T value, int startIndex) { }

	public static int LastIndexOf(T[] array, T value, int startIndex, int count) { }

	public static int LastIndexOf(Array array, object value) { }

	private static int LastIndexOfImpl(T[] array, T value, int startIndex, int count) { }

	public static void Resize(ref T[] array, int newSize) { }

	public static void Reverse(Array array) { }

	public static void Reverse(T[] array) { }

	public static void Reverse(T[] array, int index, int length) { }

	public static void Reverse(Array array, int index, int length) { }

	internal void SetGenericValueImpl(int pos, ref T value) { }

	public void SetValue(object value, long index1, long index2, long index3) { }

	public void SetValue(object value, Int64[] indices) { }

	public void SetValue(object value, int index1, int index2, int index3) { }

	public void SetValue(object value, int index1, int index2) { }

	public void SetValue(object value, int index) { }

	public void SetValue(object value, Int32[] indices) { }

	public void SetValue(object value, long index1, long index2) { }

	public void SetValue(object value, long index) { }

	internal void SetValueImpl(object value, int pos) { }

	public static void Sort(TKey[] keys, TValue[] items) { }

	public static void Sort(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer) { }

	public static void Sort(Array array) { }

	public static void Sort(Array array, IComparer comparer) { }

	public static void Sort(Array array, int index, int length, IComparer comparer) { }

	public static void Sort(Array keys, Array items) { }

	public static void Sort(Array keys, Array items, IComparer comparer) { }

	public static void Sort(Array keys, Array items, int index, int length) { }

	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer) { }

	public static void Sort(Array array, int index, int length) { }

	public static void Sort(T[] array, int index, int length) { }

	public static void Sort(T[] array, IComparer<T> comparer) { }

	public static void Sort(T[] array, int index, int length, IComparer<T> comparer) { }

	public static void Sort(T[] array, Comparison<T> comparison) { }

	public static void Sort(TKey[] keys, TValue[] items, int index, int length) { }

	public static void Sort(T[] array) { }

	public static void Sort(TKey[] keys, TValue[] items, IComparer<TKey> comparer) { }

	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

	private override int System.Collections.IStructuralComparable.CompareTo(object other, IComparer comparer) { }

	private override bool System.Collections.IStructuralEquatable.Equals(object other, IEqualityComparer comparer) { }

	private override int System.Collections.IStructuralEquatable.GetHashCode(IEqualityComparer comparer) { }

	public static bool TrueForAll(T[] array, Predicate<T> match) { }

	internal static Array UnsafeCreateInstance(Type elementType, Int32[] lengths) { }

	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2) { }

	internal static Array UnsafeCreateInstance(Type elementType, Int32[] lengths, Int32[] lowerBounds) { }

	internal static T UnsafeLoad(T[] array, int index) { }

	internal static R UnsafeMov(S instance) { }

	internal static void UnsafeStore(T[] array, int index, T value) { }

}

