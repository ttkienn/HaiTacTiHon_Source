namespace System.Threading.Tasks;

internal sealed class ContinuationResultTaskFromResultTask : Task<TResult>
{
	private Task<TAntecedentResult> m_antecedent; //Field offset: 0x0

	public ContinuationResultTaskFromResultTask`2(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	internal virtual void InnerInvoke() { }

}

