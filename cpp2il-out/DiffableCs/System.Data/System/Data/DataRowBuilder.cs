namespace System.Data;

public sealed class DataRowBuilder
{
	internal readonly DataTable _table; //Field offset: 0x10
	internal int _record; //Field offset: 0x18

	internal DataRowBuilder(DataTable table, int record) { }

}

