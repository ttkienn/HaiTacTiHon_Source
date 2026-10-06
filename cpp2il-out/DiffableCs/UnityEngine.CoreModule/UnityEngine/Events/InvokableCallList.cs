namespace UnityEngine.Events;

internal class InvokableCallList
{
	private readonly List<BaseInvokableCall> m_PersistentCalls; //Field offset: 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; //Field offset: 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; //Field offset: 0x20
	private bool m_NeedsUpdate; //Field offset: 0x28

	public InvokableCallList() { }

	public void AddListener(BaseInvokableCall call) { }

	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	public void ClearPersistent() { }

	public List<BaseInvokableCall> PrepareInvoke() { }

	public void RemoveListener(object targetObj, MethodInfo method) { }

}

