namespace UnityEngine.Events;

internal class CachedInvokableCall : InvokableCall<T>
{
	private readonly T m_Arg1; //Field offset: 0x0

	public CachedInvokableCall`1(object target, MethodInfo theFunction, T argument) { }

	public virtual void Invoke(Object[] args) { }

	public virtual void Invoke(T arg0) { }

}

