namespace System.Data;

[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[ListBindable(False)]
public sealed class DataTableCollection : InternalDataCollectionBase
{
	private static int s_objectTypeCount; //Field offset: 0x0
	private readonly DataSet _dataSet; //Field offset: 0x10
	private readonly ArrayList _list; //Field offset: 0x18
	private int _defaultNameIndex; //Field offset: 0x20
	private DataTable[] _delayedAddRangeTables; //Field offset: 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; //Field offset: 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; //Field offset: 0x38
	private readonly int _objectID; //Field offset: 0x40

	public DataTable Item
	{
		 get { } //Length: 216
	}

	public DataTable Item
	{
		 get { } //Length: 261
	}

	public DataTable Item
	{
		 get { } //Length: 297
	}

	protected virtual ArrayList List
	{
		 get { } //Length: 5
	}

	internal int ObjectID
	{
		internal get { } //Length: 4
	}

	internal DataTableCollection(DataSet dataSet) { }

	public void Add(DataTable table) { }

	private void ArrayAdd(DataTable table) { }

	internal string AssignName() { }

	private void BaseAdd(DataTable table) { }

	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	private void BaseRemove(DataTable table) { }

	internal bool CanRemove(DataTable table, bool fThrowException) { }

	public void Clear() { }

	public bool Contains(string name) { }

	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	internal bool Contains(string name, bool caseSensitive) { }

	public DataTable get_Item(string name, string tableNamespace) { }

	public DataTable get_Item(string name) { }

	public DataTable get_Item(int index) { }

	protected virtual ArrayList get_List() { }

	internal int get_ObjectID() { }

	internal DataTable GetTable(string name, string ns) { }

	internal DataTable GetTableSmart(string name, string ns) { }

	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	public int IndexOf(DataTable table) { }

	public int IndexOf(string tableName) { }

	internal int InternalIndexOf(string tableName) { }

	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	private string MakeName(int index) { }

	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	internal void RegisterName(string name, string tbNamespace) { }

	public void Remove(DataTable table) { }

	internal void ReplaceFromInference(List<DataTable> tableList) { }

	internal void UnregisterName(string name) { }

}

