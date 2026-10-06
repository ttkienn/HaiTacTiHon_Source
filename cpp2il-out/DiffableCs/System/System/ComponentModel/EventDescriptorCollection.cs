namespace System.ComponentModel;

[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList
{
	private class ArraySubsetEnumerator : IEnumerator
	{
		private readonly Array _array; //Field offset: 0x10
		private readonly int _total; //Field offset: 0x18
		private int _current; //Field offset: 0x1C

		public override object Current
		{
			 get { } //Length: 108
		}

		public ArraySubsetEnumerator(Array array, int count) { }

		public override object get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public static readonly EventDescriptorCollection Empty; //Field offset: 0x0
	private EventDescriptor[] _events; //Field offset: 0x10
	private String[] _namedSort; //Field offset: 0x18
	private readonly IComparer _comparer; //Field offset: 0x20
	private bool _eventsOwned; //Field offset: 0x28
	private bool _needSort; //Field offset: 0x29
	private readonly bool _readOnly; //Field offset: 0x2A
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x2C

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override EventDescriptor Item
	{
		 get { } //Length: 126
	}

	public override EventDescriptor Item
	{
		 get { } //Length: 23
	}

	private override int System.Collections.ICollection.Count
	{
		private get { } //Length: 4
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.IList.IsFixedSize
	{
		private get { } //Length: 5
	}

	private override bool System.Collections.IList.IsReadOnly
	{
		private get { } //Length: 5
	}

	private override object System.Collections.IList.Item
	{
		private get { } //Length: 20
		private set { } //Length: 424
	}

	private static EventDescriptorCollection() { }

	public EventDescriptorCollection(EventDescriptor[] events) { }

	public EventDescriptorCollection(EventDescriptor[] events, bool readOnly) { }

	public int Add(EventDescriptor value) { }

	public void Clear() { }

	public bool Contains(EventDescriptor value) { }

	private void EnsureEventsOwned() { }

	private void EnsureSize(int sizeNeeded) { }

	public override EventDescriptor Find(string name, bool ignoreCase) { }

	[CompilerGenerated]
	public int get_Count() { }

	public override EventDescriptor get_Item(int index) { }

	public override EventDescriptor get_Item(string name) { }

	public IEnumerator GetEnumerator() { }

	public int IndexOf(EventDescriptor value) { }

	public void Insert(int index, EventDescriptor value) { }

	protected void InternalSort(IComparer sorter) { }

	protected void InternalSort(String[] names) { }

	public void Remove(EventDescriptor value) { }

	public void RemoveAt(int index) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override int System.Collections.IList.Add(object value) { }

	private override void System.Collections.IList.Clear() { }

	private override bool System.Collections.IList.Contains(object value) { }

	private override bool System.Collections.IList.get_IsFixedSize() { }

	private override bool System.Collections.IList.get_IsReadOnly() { }

	private override object System.Collections.IList.get_Item(int index) { }

	private override int System.Collections.IList.IndexOf(object value) { }

	private override void System.Collections.IList.Insert(int index, object value) { }

	private override void System.Collections.IList.Remove(object value) { }

	private override void System.Collections.IList.RemoveAt(int index) { }

	private override void System.Collections.IList.set_Item(int index, object value) { }

}

