namespace System.ComponentModel;

[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary
{
	private class PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator
	{
		private PropertyDescriptorCollection _owner; //Field offset: 0x10
		private int _index; //Field offset: 0x18

		public override object Current
		{
			 get { } //Length: 165
		}

		public override DictionaryEntry Entry
		{
			 get { } //Length: 117
		}

		public override object Key
		{
			 get { } //Length: 75
		}

		public override object Value
		{
			 get { } //Length: 75
		}

		public PropertyDescriptorEnumerator(PropertyDescriptorCollection owner) { }

		public override object get_Current() { }

		public override DictionaryEntry get_Entry() { }

		public override object get_Key() { }

		public override object get_Value() { }

		public override bool MoveNext() { }

		public override void Reset() { }

	}

	public static readonly PropertyDescriptorCollection Empty; //Field offset: 0x0
	private IDictionary _cachedFoundProperties; //Field offset: 0x10
	private bool _cachedIgnoreCase; //Field offset: 0x18
	private PropertyDescriptor[] _properties; //Field offset: 0x20
	private readonly String[] _namedSort; //Field offset: 0x28
	private readonly IComparer _comparer; //Field offset: 0x30
	private bool _propsOwned; //Field offset: 0x38
	private bool _needSort; //Field offset: 0x39
	private bool _readOnly; //Field offset: 0x3A
	private readonly object _internalSyncObject; //Field offset: 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x48

	public private int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override PropertyDescriptor Item
	{
		 get { } //Length: 126
	}

	public override PropertyDescriptor Item
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

	private override bool System.Collections.IDictionary.IsFixedSize
	{
		private get { } //Length: 5
	}

	private override bool System.Collections.IDictionary.IsReadOnly
	{
		private get { } //Length: 5
	}

	private override object System.Collections.IDictionary.Item
	{
		private get { } //Length: 141
		private set { } //Length: 1104
	}

	private override ICollection System.Collections.IDictionary.Keys
	{
		private get { } //Length: 188
	}

	private override ICollection System.Collections.IDictionary.Values
	{
		private get { } //Length: 201
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
		private set { } //Length: 561
	}

	private static PropertyDescriptorCollection() { }

	private PropertyDescriptorCollection(PropertyDescriptor[] properties, int propCount, String[] namedSort, IComparer comparer) { }

	public PropertyDescriptorCollection(PropertyDescriptor[] properties) { }

	public PropertyDescriptorCollection(PropertyDescriptor[] properties, bool readOnly) { }

	public int Add(PropertyDescriptor value) { }

	public void Clear() { }

	public bool Contains(PropertyDescriptor value) { }

	public override void CopyTo(Array array, int index) { }

	private void EnsurePropsOwned() { }

	private void EnsureSize(int sizeNeeded) { }

	public override PropertyDescriptor Find(string name, bool ignoreCase) { }

	[CompilerGenerated]
	public int get_Count() { }

	public override PropertyDescriptor get_Item(int index) { }

	public override PropertyDescriptor get_Item(string name) { }

	public override IEnumerator GetEnumerator() { }

	public int IndexOf(PropertyDescriptor value) { }

	public void Insert(int index, PropertyDescriptor value) { }

	protected void InternalSort(String[] names) { }

	protected void InternalSort(IComparer sorter) { }

	public void Remove(PropertyDescriptor value) { }

	public void RemoveAt(int index) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	public override PropertyDescriptorCollection Sort(String[] names) { }

	private override int System.Collections.ICollection.get_Count() { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override void System.Collections.IDictionary.Add(object key, object value) { }

	private override void System.Collections.IDictionary.Clear() { }

	private override bool System.Collections.IDictionary.Contains(object key) { }

	private override bool System.Collections.IDictionary.get_IsFixedSize() { }

	private override bool System.Collections.IDictionary.get_IsReadOnly() { }

	private override object System.Collections.IDictionary.get_Item(object key) { }

	private override ICollection System.Collections.IDictionary.get_Keys() { }

	private override ICollection System.Collections.IDictionary.get_Values() { }

	private override IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	private override void System.Collections.IDictionary.Remove(object key) { }

	private override void System.Collections.IDictionary.set_Item(object key, object value) { }

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

