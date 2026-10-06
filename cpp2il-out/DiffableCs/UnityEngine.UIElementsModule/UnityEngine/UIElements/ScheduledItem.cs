namespace UnityEngine.UIElements;

internal abstract class ScheduledItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <.cctor>b__25_0() { }

		internal bool <.cctor>b__25_1() { }

	}

	public static readonly Func<Boolean> OnceCondition; //Field offset: 0x0
	public static readonly Func<Boolean> ForeverCondition; //Field offset: 0x8
	public Func<Boolean> timerUpdateStopCondition; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <startMs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <delayMs>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <intervalMs>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private long <endTimeMs>k__BackingField; //Field offset: 0x30

	public long delayMs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public long endTimeMs
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public long intervalMs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public long startMs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static ScheduledItem() { }

	public ScheduledItem() { }

	[CompilerGenerated]
	public long get_delayMs() { }

	[CompilerGenerated]
	public long get_endTimeMs() { }

	[CompilerGenerated]
	public long get_intervalMs() { }

	[CompilerGenerated]
	public long get_startMs() { }

	internal override void OnItemUnscheduled() { }

	public abstract void PerformTimerUpdate(TimerState state) { }

	protected void ResetStartTime() { }

	[CompilerGenerated]
	public void set_delayMs(long value) { }

	[CompilerGenerated]
	public void set_intervalMs(long value) { }

	[CompilerGenerated]
	public void set_startMs(long value) { }

	public override bool ShouldUnschedule() { }

}

