namespace System.Collections;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ArrayListDebugView))]
[DefaultMember("Item")]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	public class ArrayListDebugView
	{

	}

	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		private static object s_dummyObject; //Field offset: 0x0
		private ArrayList _list; //Field offset: 0x10
		private int _index; //Field offset: 0x18
		private int _version; //Field offset: 0x1C
		private object _currentElement; //Field offset: 0x20
		private bool _isArrayList; //Field offset: 0x28

		public override object Current
		{
			 get { } //Length: 243
		}

		private static ArrayListEnumeratorSimple() { }

		internal ArrayListEnumeratorSimple(ArrayList list) { }

		public override object Clone() { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	[DefaultMember("Item")]
	private class IListWrapper : ArrayList
	{
		private IList _list; //Field offset: 0x28

		public virtual int Capacity
		{
			 set { } //Length: 137
		}

		public virtual int Count
		{
			 get { } //Length: 73
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 73
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 73
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 73
		}

		public virtual object Item
		{
			 get { } //Length: 84
			 set { } //Length: 109
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 73
		}

		internal IListWrapper(IList list) { }

		public virtual int Add(object obj) { }

		public virtual void AddRange(ICollection c) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object obj) { }

		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		public virtual void CopyTo(Array array, int index) { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(int index) { }

		public virtual object get_SyncRoot() { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual int IndexOf(object value) { }

		public virtual void Insert(int index, object obj) { }

		public virtual void InsertRange(int index, ICollection c) { }

		public virtual void Remove(object value) { }

		public virtual void RemoveAt(int index) { }

		public virtual void RemoveRange(int index, int count) { }

		public virtual void set_Capacity(int value) { }

		public virtual void set_Item(int index, object value) { }

		public virtual void Sort(int index, int count, IComparer comparer) { }

		public virtual Object[] ToArray() { }

		public virtual Array ToArray(Type type) { }

	}

	[DefaultMember("Item")]
	private class ReadOnlyArrayList : ArrayList
	{
		private ArrayList _list; //Field offset: 0x28

		public virtual int Capacity
		{
			 set { } //Length: 78
		}

		public virtual int Count
		{
			 get { } //Length: 42
		}

		public virtual bool IsFixedSize
		{
			 get { } //Length: 3
		}

		public virtual bool IsReadOnly
		{
			 get { } //Length: 3
		}

		public virtual bool IsSynchronized
		{
			 get { } //Length: 42
		}

		public virtual object Item
		{
			 get { } //Length: 42
			 set { } //Length: 78
		}

		public virtual object SyncRoot
		{
			 get { } //Length: 42
		}

		internal ReadOnlyArrayList(ArrayList l) { }

		public virtual int Add(object obj) { }

		public virtual void AddRange(ICollection c) { }

		public virtual void Clear() { }

		public virtual object Clone() { }

		public virtual bool Contains(object obj) { }

		public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

		public virtual void CopyTo(Array array, int index) { }

		public virtual int get_Count() { }

		public virtual bool get_IsFixedSize() { }

		public virtual bool get_IsReadOnly() { }

		public virtual bool get_IsSynchronized() { }

		public virtual object get_Item(int index) { }

		public virtual object get_SyncRoot() { }

		public virtual IEnumerator GetEnumerator() { }

		public virtual int IndexOf(object value) { }

		public virtual void Insert(int index, object obj) { }

		public virtual void InsertRange(int index, ICollection c) { }

		public virtual void Remove(object value) { }

		public virtual void RemoveAt(int index) { }

		public virtual void RemoveRange(int index, int count) { }

		public virtual void set_Capacity(int value) { }

		public virtual void set_Item(int index, object value) { }

		public virtual void Sort(int index, int count, IComparer comparer) { }

		public virtual Object[] ToArray() { }

		public virtual Array ToArray(Type type) { }

	}

	private const int _defaultCapacity = 4; //Field offset: 0x0
	internal const int MaxArrayLength = 2146435071; //Field offset: 0x0
	private Object[] _items; //Field offset: 0x10
	private int _size; //Field offset: 0x18
	private int _version; //Field offset: 0x1C
	private object _syncRoot; //Field offset: 0x20

	public override int Capacity
	{
		 set { } //Length: 289
	}

	public override int Count
	{
		 get { } //Length: 4
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

	public override object Item
	{
		 get { } //Length: 165
		 set { } //Length: 255
	}

	public override object SyncRoot
	{
		 get { } //Length: 104
	}

	public ArrayList() { }

	public ArrayList(int capacity) { }

	public ArrayList(ICollection c) { }

	public static ArrayList Adapter(IList list) { }

	public override int Add(object value) { }

	public override void AddRange(ICollection c) { }

	public override void Clear() { }

	public override object Clone() { }

	public override bool Contains(object item) { }

	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	public override void CopyTo(Array array, int arrayIndex) { }

	public override void CopyTo(Array array) { }

	private void EnsureCapacity(int min) { }

	public override int get_Count() { }

	public override bool get_IsFixedSize() { }

	public override bool get_IsReadOnly() { }

	public override bool get_IsSynchronized() { }

	public override object get_Item(int index) { }

	public override object get_SyncRoot() { }

	public override IEnumerator GetEnumerator() { }

	public override int IndexOf(object value) { }

	public override void Insert(int index, object value) { }

	public override void InsertRange(int index, ICollection c) { }

	public static ArrayList ReadOnly(ArrayList list) { }

	public override void Remove(object obj) { }

	public override void RemoveAt(int index) { }

	public override void RemoveRange(int index, int count) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, object value) { }

	public override void Sort(IComparer comparer) { }

	public override void Sort(int index, int count, IComparer comparer) { }

	public override Object[] ToArray() { }

	public override Array ToArray(Type type) { }

}

