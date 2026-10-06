namespace System.Threading;

internal interface IThreadPoolWorkItem
{

	public void ExecuteWorkItem() { }

	public void MarkAborted(ThreadAbortException tae) { }

}

