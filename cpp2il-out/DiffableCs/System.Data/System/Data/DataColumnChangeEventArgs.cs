namespace System.Data;

public class DataColumnChangeEventArgs : EventArgs
{
	private DataColumn _column; //Field offset: 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; //Field offset: 0x20

	public object ProposedValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	internal DataColumnChangeEventArgs(DataRow row) { }

	public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	public object get_ProposedValue() { }

	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }

	[CompilerGenerated]
	public void set_ProposedValue(object value) { }

}

