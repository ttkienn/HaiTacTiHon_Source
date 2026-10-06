namespace System.Data;

[DefaultMember("Item")]
internal sealed class RecordManager
{
	private readonly DataTable _table; //Field offset: 0x10
	private int _lastFreeRecord; //Field offset: 0x18
	private int _minimumCapacity; //Field offset: 0x1C
	private int _recordCapacity; //Field offset: 0x20
	private readonly List<Int32> _freeRecordList; //Field offset: 0x28
	private DataRow[] _rows; //Field offset: 0x30

	internal DataRow Item
	{
		internal get { } //Length: 43
		internal set { } //Length: 126
	}

	internal int LastFreeRecord
	{
		internal get { } //Length: 4
	}

	internal int MinimumCapacity
	{
		internal get { } //Length: 4
		internal set { } //Length: 64
	}

	internal int RecordCapacity
	{
		internal get { } //Length: 4
		internal set { } //Length: 170
	}

	internal RecordManager(DataTable table) { }

	internal void Clear(bool clearAll) { }

	internal int CopyRecord(DataTable src, int record, int copy) { }

	internal void FreeRecord(ref int record) { }

	internal DataRow get_Item(int record) { }

	internal int get_LastFreeRecord() { }

	internal int get_MinimumCapacity() { }

	internal int get_RecordCapacity() { }

	private void GrowRecordCapacity() { }

	internal int ImportRecord(DataTable src, int record) { }

	internal static int NewCapacity(int capacity) { }

	internal int NewRecordBase() { }

	private int NormalizedMinimumCapacity(int capacity) { }

	internal void set_Item(int record, DataRow value) { }

	internal void set_MinimumCapacity(int value) { }

	internal void set_RecordCapacity(int value) { }

	internal void SetRowCache(DataRow[] newRows) { }

}

