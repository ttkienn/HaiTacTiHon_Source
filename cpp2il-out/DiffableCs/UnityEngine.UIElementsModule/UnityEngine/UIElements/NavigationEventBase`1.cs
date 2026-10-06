namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Navigation (13))]
public abstract class NavigationEventBase : EventBase<T>, INavigationEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private NavigationDeviceType <deviceType>k__BackingField; //Field offset: 0x0

	public override bool altKey
	{
		 get { } //Length: 13
	}

	internal NavigationDeviceType deviceType
	{
		[CompilerGenerated]
		internal get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override EventModifiers modifiers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 155
	}

	public override bool shiftKey
	{
		 get { } //Length: 13
	}

	protected NavigationEventBase`1() { }

	public override bool get_altKey() { }

	[CompilerGenerated]
	internal NavigationDeviceType get_deviceType() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	public override bool get_shiftKey() { }

	public static T GetPooled(EventModifiers modifiers = 0) { }

	internal static T GetPooled(NavigationDeviceType deviceType, EventModifiers modifiers = 0) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	private void set_deviceType(NavigationDeviceType value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

}

