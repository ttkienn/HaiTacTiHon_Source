namespace System.Data;

[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting
{
	private DataViewManager _dataViewManager; //Field offset: 0x10
	private DataTable _table; //Field offset: 0x18
	private string _sort; //Field offset: 0x20
	private string _rowFilter; //Field offset: 0x28
	private DataViewRowState _rowStateFilter; //Field offset: 0x30
	private bool _applyDefaultSort; //Field offset: 0x34

	public bool ApplyDefaultSort
	{
		 get { } //Length: 5
	}

	public string RowFilter
	{
		 get { } //Length: 5
	}

	public DataViewRowState RowStateFilter
	{
		 get { } //Length: 4
	}

	public string Sort
	{
		 get { } //Length: 5
	}

	internal DataViewSetting() { }

	public bool get_ApplyDefaultSort() { }

	public string get_RowFilter() { }

	public DataViewRowState get_RowStateFilter() { }

	public string get_Sort() { }

	internal void SetDataTable(DataTable table) { }

	internal void SetDataViewManager(DataViewManager dataViewManager) { }

}

