namespace UnityEngine.Events;

internal class PersistentCallGroup
{
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	private List<PersistentCall> m_Calls; //Field offset: 0x10

	public PersistentCallGroup() { }

	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }

}

