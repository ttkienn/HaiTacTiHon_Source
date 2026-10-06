namespace System.Data;

[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase
{
	private sealed class DataRowTree : RBTree<DataRow>
	{

		internal DataRowTree() { }

		protected virtual int CompareNode(DataRow record1, DataRow record2) { }

		protected virtual int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }

	}

	private readonly DataTable _table; //Field offset: 0x10
	private readonly DataRowTree _list; //Field offset: 0x18
	internal int _nullInList; //Field offset: 0x20

	public virtual int Count
	{
		 get { } //Length: 68
	}

	public DataRow Item
	{
		 get { } //Length: 81
	}

	internal DataRowCollection(DataTable table) { }

	public void Add(DataRow row) { }

	internal DataRow AddWithColumnEvents(Object[] values) { }

	internal void ArrayAdd(DataRow row) { }

	internal void ArrayClear() { }

	internal void ArrayInsert(DataRow row, int pos) { }

	internal void ArrayRemove(DataRow row) { }

	public virtual void CopyTo(Array ar, int index) { }

	public void CopyTo(DataRow[] array, int index) { }

	internal void DiffInsertAt(DataRow row, int pos) { }

	public virtual int get_Count() { }

	public DataRow get_Item(int index) { }

	public virtual IEnumerator GetEnumerator() { }

	public int IndexOf(DataRow row) { }

}

