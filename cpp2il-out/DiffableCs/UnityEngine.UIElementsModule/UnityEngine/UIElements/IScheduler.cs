namespace UnityEngine.UIElements;

internal interface IScheduler
{

	public void Schedule(ScheduledItem item) { }

	public void Unschedule(ScheduledItem item) { }

	public void UpdateScheduledEvents() { }

}

