namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromTask : Task
{
	private Task m_antecedent; //Field offset: 0x50

	public ContinuationTaskFromTask(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

