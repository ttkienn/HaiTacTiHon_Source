namespace System.Threading.Tasks;

internal interface ITaskCompletionAction
{

	public bool InvokeMayRunArbitraryCode
	{
		 get { } //Length: 0
	}

	public bool get_InvokeMayRunArbitraryCode() { }

	public void Invoke(Task completingTask) { }

}

