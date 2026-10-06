namespace System.Threading.Tasks;

internal sealed class CompletionActionInvoker : IThreadPoolWorkItem
{
	private readonly ITaskCompletionAction m_action; //Field offset: 0x10
	private readonly Task m_completingTask; //Field offset: 0x18

	internal CompletionActionInvoker(ITaskCompletionAction action, Task completingTask) { }

	public override void MarkAborted(ThreadAbortException e) { }

	private override void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

}

