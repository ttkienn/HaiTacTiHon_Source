namespace UnityEngine.UIElements;

internal class TimerEventScheduler : IScheduler
{
	private readonly List<ScheduledItem> m_ScheduledItems; //Field offset: 0x10
	private bool m_TransactionMode; //Field offset: 0x18
	private readonly List<ScheduledItem> m_ScheduleTransactions; //Field offset: 0x20
	private readonly HashSet<ScheduledItem> m_UnscheduleTransactions; //Field offset: 0x28
	internal bool disableThrottling; //Field offset: 0x30
	private int m_LastUpdatedIndex; //Field offset: 0x34

	public TimerEventScheduler() { }

	private bool PrivateUnSchedule(ScheduledItem sItem) { }

	private bool RemovedScheduledItemAt(int index) { }

	public override void Schedule(ScheduledItem item) { }

	public override void Unschedule(ScheduledItem item) { }

	public override void UpdateScheduledEvents() { }

}

