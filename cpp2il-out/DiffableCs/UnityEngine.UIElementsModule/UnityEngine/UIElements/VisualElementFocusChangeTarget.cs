namespace UnityEngine.UIElements;

internal class VisualElementFocusChangeTarget : FocusChangeDirection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal VisualElementFocusChangeTarget <.cctor>b__9_0() { }

	}

	private static readonly ObjectPool<VisualElementFocusChangeTarget> Pool; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Focusable <target>k__BackingField; //Field offset: 0x18

	public private Focusable target
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	private static VisualElementFocusChangeTarget() { }

	public VisualElementFocusChangeTarget() { }

	internal virtual void ApplyTo(FocusController focusController, Focusable f) { }

	protected virtual void Dispose() { }

	[CompilerGenerated]
	public Focusable get_target() { }

	public static VisualElementFocusChangeTarget GetPooled(Focusable target) { }

	[CompilerGenerated]
	private void set_target(Focusable value) { }

}

