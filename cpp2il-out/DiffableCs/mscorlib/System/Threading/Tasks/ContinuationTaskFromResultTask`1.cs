namespace System.Threading.Tasks;

internal sealed class ContinuationTaskFromResultTask : Task
{
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	public ContinuationTaskFromResultTask`1(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

