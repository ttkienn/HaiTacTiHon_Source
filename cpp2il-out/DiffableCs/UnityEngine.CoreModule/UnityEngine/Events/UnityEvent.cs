namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x28

	[RequiredByNativeCode]
	public UnityEvent() { }

	public void AddListener(UnityAction call) { }

	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	public void Invoke() { }

}

