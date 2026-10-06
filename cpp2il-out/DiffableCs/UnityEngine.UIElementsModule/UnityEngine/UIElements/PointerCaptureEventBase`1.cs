namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Pointer (1))]
public abstract class PointerCaptureEventBase : EventBase<T>, IPointerCaptureEventInternal
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IEventHandler <relatedTarget>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <pointerId>k__BackingField; //Field offset: 0x0

	public private override int pointerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private IEventHandler relatedTarget
	{
		[CompilerGenerated]
		private set { } //Length: 19
	}

	protected PointerCaptureEventBase`1() { }

	[CompilerGenerated]
	public override int get_pointerId() { }

	public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_pointerId(int value) { }

	[CompilerGenerated]
	private void set_relatedTarget(IEventHandler value) { }

}

