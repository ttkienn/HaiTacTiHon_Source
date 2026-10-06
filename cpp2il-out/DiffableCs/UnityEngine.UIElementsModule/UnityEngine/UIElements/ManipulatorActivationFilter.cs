namespace UnityEngine.UIElements;

public struct ManipulatorActivationFilter : IEquatable<ManipulatorActivationFilter>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private MouseButton <button>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventModifiers <modifiers>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <clickCount>k__BackingField; //Field offset: 0x8

	public MouseButton button
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 3
		[CompilerGenerated]
		 set { } //Length: 3
	}

	public int clickCount
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
	}

	public EventModifiers modifiers
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(ManipulatorActivationFilter other) { }

	[CompilerGenerated]
	[IsReadOnly]
	public MouseButton get_button() { }

	[CompilerGenerated]
	[IsReadOnly]
	public int get_clickCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	public EventModifiers get_modifiers() { }

	public virtual int GetHashCode() { }

	private bool HasModifiers(IMouseEvent e) { }

	private bool HasModifiers(IPointerEvent e) { }

	public bool Matches(IMouseEvent e) { }

	public bool Matches(IPointerEvent e) { }

	private bool MatchModifiers(bool alt, bool ctrl, bool shift, bool command) { }

	[CompilerGenerated]
	public void set_button(MouseButton value) { }

	[CompilerGenerated]
	public void set_modifiers(EventModifiers value) { }

}

