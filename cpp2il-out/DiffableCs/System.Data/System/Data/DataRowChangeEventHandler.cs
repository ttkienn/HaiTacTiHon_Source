namespace System.Data;

public sealed class DataRowChangeEventHandler : MulticastDelegate
{

	public DataRowChangeEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, DataRowChangeEventArgs e) { }

}

