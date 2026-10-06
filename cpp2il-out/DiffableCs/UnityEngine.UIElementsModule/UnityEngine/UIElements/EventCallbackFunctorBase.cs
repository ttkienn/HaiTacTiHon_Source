namespace UnityEngine.UIElements;

internal abstract class EventCallbackFunctorBase
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly CallbackPhase <phase>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly InvokePolicy <invokePolicy>k__BackingField; //Field offset: 0x14

	public InvokePolicy invokePolicy
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public CallbackPhase phase
	{
		[CompilerGenerated]
		 get { } //Length: 191
	}

	protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy) { }

	[CompilerGenerated]
	public InvokePolicy get_invokePolicy() { }

	[CompilerGenerated]
	public CallbackPhase get_phase() { }

	public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase) { }

	public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase) { }

	protected bool PhaseMatches(PropagationPhase propagationPhase) { }

}

