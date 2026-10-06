namespace System.Data;

public sealed class DataColumnChangeEventHandler : MulticastDelegate
{

	public DataColumnChangeEventHandler(object object, IntPtr method) { }

	public override void Invoke(object sender, DataColumnChangeEventArgs e) { }

}

