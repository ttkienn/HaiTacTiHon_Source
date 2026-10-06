namespace UnityEngine.Events;

[UsedByNativeCode]
public abstract class UnityEventBase : ISerializationCallbackReceiver
{
	private InvokableCallList m_Calls; //Field offset: 0x10
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	private PersistentCallGroup m_PersistentCalls; //Field offset: 0x18
	private bool m_CallsDirty; //Field offset: 0x20

	protected UnityEventBase() { }

	internal void AddCall(BaseInvokableCall call) { }

	private void DirtyPersistentCalls() { }

	internal MethodInfo FindMethod(PersistentCall call) { }

	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }

	internal List<BaseInvokableCall> PrepareInvoke() { }

	private void RebuildPersistentCallsIfNeeded() { }

	protected void RemoveListener(object targetObj, MethodInfo method) { }

	public virtual string ToString() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

