namespace UnityEngine.UIElements;

[EventCategory(EventCategory::Keyboard (5))]
public abstract class KeyboardEventBase : EventBase<T>, IKeyboardEvent
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private char <character>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private KeyCode <keyCode>k__BackingField; //Field offset: 0x0

	public override bool actionKey
	{
		 get { } //Length: 138
	}

	public override bool altKey
	{
		 get { } //Length: 13
	}

	public override char character
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override bool commandKey
	{
		 get { } //Length: 13
	}

	public override bool ctrlKey
	{
		 get { } //Length: 13
	}

	internal bool functionKey
	{
		internal get { } //Length: 13
	}

	public override KeyCode keyCode
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
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

	protected KeyboardEventBase`1() { }

	public override bool get_actionKey() { }

	public override bool get_altKey() { }

	[CompilerGenerated]
	public override char get_character() { }

	public override bool get_commandKey() { }

	public override bool get_ctrlKey() { }

	internal bool get_functionKey() { }

	[CompilerGenerated]
	public override KeyCode get_keyCode() { }

	[CompilerGenerated]
	public override EventModifiers get_modifiers() { }

	public override bool get_shiftKey() { }

	public static T GetPooled(Event systemEvent) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	protected void set_character(char value) { }

	[CompilerGenerated]
	protected void set_keyCode(KeyCode value) { }

	[CompilerGenerated]
	protected void set_modifiers(EventModifiers value) { }

}

