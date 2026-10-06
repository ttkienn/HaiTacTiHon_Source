namespace Unity.Properties;

public class ReflectedMemberProperty : Property<TContainer, TValue>
{
	private sealed class GetClassValueAction : MulticastDelegate
	{

		public GetClassValueAction(object object, IntPtr method) { }

		public override TValue Invoke(TContainer container) { }

	}

	private sealed class GetStructValueAction : MulticastDelegate
	{

		public GetStructValueAction(object object, IntPtr method) { }

		public override TValue Invoke(ref TContainer container) { }

	}

	private sealed class SetClassValueAction : MulticastDelegate
	{

		public SetClassValueAction(object object, IntPtr method) { }

		public override void Invoke(TContainer container, TValue value) { }

	}

	private sealed class SetStructValueAction : MulticastDelegate
	{

		public SetStructValueAction(object object, IntPtr method) { }

		public override void Invoke(ref TContainer container, TValue value) { }

	}

	private readonly IMemberInfo m_Info; //Field offset: 0x0
	private readonly bool m_IsStructContainerType; //Field offset: 0x0
	private GetStructValueAction<TContainer, TValue> m_GetStructValueAction; //Field offset: 0x0
	private SetStructValueAction<TContainer, TValue> m_SetStructValueAction; //Field offset: 0x0
	private GetClassValueAction<TContainer, TValue> m_GetClassValueAction; //Field offset: 0x0
	private SetClassValueAction<TContainer, TValue> m_SetClassValueAction; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly string <Name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly bool <IsReadOnly>k__BackingField; //Field offset: 0x0

	public virtual string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal ReflectedMemberProperty`2(IMemberInfo info, string name) { }

	[CompilerGenerated]
	public virtual string get_Name() { }

}

