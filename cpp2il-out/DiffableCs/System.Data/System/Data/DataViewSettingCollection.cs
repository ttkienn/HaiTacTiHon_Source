namespace System.Data;

[DefaultMember("Item")]
public class DataViewSettingCollection
{
	private readonly DataViewManager _dataViewManager; //Field offset: 0x10
	private readonly Hashtable _list; //Field offset: 0x18

	public override DataViewSetting Item
	{
		 get { } //Length: 384
		 set { } //Length: 187
	}

	public override DataViewSetting get_Item(DataTable table) { }

	internal void Remove(DataTable table) { }

	public override void set_Item(DataTable table, DataViewSetting value) { }

}

