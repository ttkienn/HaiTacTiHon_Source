namespace UnityEngine.Events;

internal class InvokableCall : BaseInvokableCall
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private UnityAction<T1> Delegate; //Field offset: 0x0

	protected event UnityAction<T1> Delegate
	{
		[CompilerGenerated]
		 add { } //Length: 192
		[CompilerGenerated]
		 remove { } //Length: 192
	}

	public InvokableCall`1(object target, MethodInfo theFunction) { }

	public InvokableCall`1(UnityAction<T1> action) { }

	[CompilerGenerated]
	protected void add_Delegate(UnityAction<T1> value) { }

	public virtual bool Find(object targetObj, MethodInfo method) { }

	public virtual void Invoke(Object[] args) { }

	public override void Invoke(T1 args0) { }

	[CompilerGenerated]
	protected void remove_Delegate(UnityAction<T1> value) { }

}

