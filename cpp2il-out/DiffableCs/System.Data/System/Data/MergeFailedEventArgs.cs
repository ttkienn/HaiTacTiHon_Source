namespace System.Data;

public class MergeFailedEventArgs : EventArgs
{
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; //Field offset: 0x18

	public string Conflict
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public MergeFailedEventArgs(DataTable table, string conflict) { }

	[CompilerGenerated]
	public string get_Conflict() { }

}

