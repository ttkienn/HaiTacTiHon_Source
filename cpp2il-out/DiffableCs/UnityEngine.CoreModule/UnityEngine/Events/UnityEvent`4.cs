namespace UnityEngine.Events;

public class UnityEvent : UnityEventBase
{
	private Object[] m_InvokeArray; //Field offset: 0x0

	[RequiredByNativeCode]
	public UnityEvent`4() { }

	protected virtual MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal virtual BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

}

