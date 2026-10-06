namespace UnityEngine.UIElements;

public class InputEvent : EventBase<InputEvent>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal InputEvent <.cctor>b__0_0() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <previousData>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <newData>k__BackingField; //Field offset: 0x90

	protected string newData
	{
		[CompilerGenerated]
		 set { } //Length: 19
	}

	protected string previousData
	{
		[CompilerGenerated]
		 set { } //Length: 19
	}

	private static InputEvent() { }

	public InputEvent() { }

	public static InputEvent GetPooled(string previousData, string newData) { }

	protected virtual void Init() { }

	private void LocalInit() { }

	[CompilerGenerated]
	protected void set_newData(string value) { }

	[CompilerGenerated]
	protected void set_previousData(string value) { }

}

