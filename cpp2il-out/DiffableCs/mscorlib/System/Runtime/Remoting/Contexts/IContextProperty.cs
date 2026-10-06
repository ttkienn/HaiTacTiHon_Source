namespace System.Runtime.Remoting.Contexts;

[ComVisible(True)]
public interface IContextProperty
{

	public string Name
	{
		 get { } //Length: 0
	}

	public void Freeze(Context newContext) { }

	public string get_Name() { }

	public bool IsNewContextOK(Context newCtx) { }

}

