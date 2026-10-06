namespace System.ComponentModel;

public interface ISynchronizeInvoke
{

	public bool InvokeRequired
	{
		 get { } //Length: 0
	}

	public IAsyncResult BeginInvoke(Delegate method, Object[] args) { }

	public bool get_InvokeRequired() { }

}

