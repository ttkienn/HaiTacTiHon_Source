namespace System.Data;

internal sealed class DataRowCreatedEventHandler : MulticastDelegate
{

	public DataRowCreatedEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, DataRow r) { }

}

