namespace Unity.Collections;

[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeSliceDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
[NativeContainerSupportsMinMaxWriteRestriction]
public struct NativeSlice : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice`1<T>>
{
	[ExcludeFromDocs]
	internal struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeSlice<T> m_Array; //Field offset: 0x0
		private int m_Index; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 208
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 235
		}

		public Enumerator(ref NativeSlice<T>& array) { }

		public override void Dispose() { }

		public override T get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal Byte* m_Buffer; //Field offset: 0x0
	internal int m_Stride; //Field offset: 0x0
	internal int m_Length; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 234
		[WriteAccessRequired]
		 set { } //Length: 181
	}

	public int Length
	{
		 get { } //Length: 6
	}

	public int Stride
	{
		 get { } //Length: 4
	}

	public NativeSlice`1(NativeSlice<T> slice, int start, int length) { }

	public NativeSlice`1(NativeArray<T> array) { }

	public NativeSlice`1(NativeArray<T> array, int start, int length) { }

	[WriteAccessRequired]
	public void CopyFrom(NativeSlice<T> slice) { }

	[WriteAccessRequired]
	public void CopyFrom(T[] array) { }

	public override bool Equals(NativeSlice<T> other) { }

	public virtual bool Equals(object obj) { }

	public T get_Item(int index) { }

	public int get_Length() { }

	public int get_Stride() { }

	public Enumerator<T> GetEnumerator() { }

	public virtual int GetHashCode() { }

	public static NativeSlice<T> op_Implicit(NativeArray<T> array) { }

	[WriteAccessRequired]
	public void set_Item(int index, T value) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

