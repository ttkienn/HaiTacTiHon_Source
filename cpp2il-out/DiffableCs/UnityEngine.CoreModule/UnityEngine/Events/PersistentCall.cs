namespace UnityEngine.Events;

internal class PersistentCall : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("instance")]
	[SerializeField]
	private object m_Target; //Field offset: 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; //Field offset: 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; //Field offset: 0x20
	[FormerlySerializedAs("mode")]
	[SerializeField]
	private PersistentListenerMode m_Mode; //Field offset: 0x28
	[FormerlySerializedAs("arguments")]
	[SerializeField]
	private ArgumentCache m_Arguments; //Field offset: 0x30
	[FormerlySerializedAs("enabled")]
	[FormerlySerializedAs("m_Enabled")]
	[SerializeField]
	private UnityEventCallState m_CallState; //Field offset: 0x38

	public ArgumentCache arguments
	{
		 get { } //Length: 7
	}

	public string methodName
	{
		 get { } //Length: 7
	}

	public PersistentListenerMode mode
	{
		 get { } //Length: 1817
	}

	public object target
	{
		 get { } //Length: 7
	}

	public string targetAssemblyTypeName
	{
		 get { } //Length: 301
	}

	public PersistentCall() { }

	public ArgumentCache get_arguments() { }

	public string get_methodName() { }

	public PersistentListenerMode get_mode() { }

	public object get_target() { }

	public string get_targetAssemblyTypeName() { }

	private static BaseInvokableCall GetObjectCall(object target, MethodInfo method, ArgumentCache arguments) { }

	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	public bool IsValid() { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

}

