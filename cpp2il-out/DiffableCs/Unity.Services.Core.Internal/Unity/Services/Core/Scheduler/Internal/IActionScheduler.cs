namespace Unity.Services.Core.Scheduler.Internal;

public interface IActionScheduler : IServiceComponent
{

	public void CancelAction(long actionId) { }

	public long ScheduleAction(Action action, double delaySeconds = 0) { }

}

