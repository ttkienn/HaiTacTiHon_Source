namespace UnityEngine.UIElements;

internal class RepaintData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Matrix4x4 <currentOffset>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Vector2 <mousePosition>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Rect <currentWorldClip>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Event <repaintEvent>k__BackingField; //Field offset: 0x68

	public Matrix4x4 currentOffset
	{
		[CompilerGenerated]
		 get { } //Length: 35
	}

	public Rect currentWorldClip
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public Event repaintEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public RepaintData() { }

	[CompilerGenerated]
	public Matrix4x4 get_currentOffset() { }

	[CompilerGenerated]
	public Rect get_currentWorldClip() { }

	[CompilerGenerated]
	public Event get_repaintEvent() { }

	[CompilerGenerated]
	public void set_repaintEvent(Event value) { }

}

