namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x0

	[RequiredByNativeCode]
	public UnityEvent`1() { }

	public void AddListener(UnityAction<T0> call) { }

	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }

	public void Invoke(T0 arg0) { }

	public void RemoveListener(UnityAction<T0> call) { }

}

