namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction<T1, T2, T3, T4> Delegate; //Field offset: 0x0

	public InvokableCall`4(object target, MethodInfo theFunction) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(Object[] args) { }

}

