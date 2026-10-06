namespace Unity.Services.Core.Scheduler.Internal;

internal class ActionScheduler : IActionScheduler, IServiceComponent
{
	internal readonly PlayerLoopSystem SchedulerLoopSystem; //Field offset: 0x10
	private readonly ITimeProvider m_TimeProvider; //Field offset: 0x38
	private readonly object m_Lock; //Field offset: 0x40
	private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions; //Field offset: 0x48
	private readonly Dictionary<Int64, ScheduledInvocation> m_IdScheduledInvocationMap; //Field offset: 0x50
	private readonly List<ScheduledInvocation> m_ExpiredActions; //Field offset: 0x58
	private long m_NextId; //Field offset: 0x60

	public ActionScheduler() { }

	public ActionScheduler(ITimeProvider timeProvider) { }

	public override void CancelAction(long actionId) { }

	internal void ExecuteExpiredActions() { }

	public void JoinPlayerLoopSystem() { }

	public override long ScheduleAction(Action action, double delaySeconds = 0) { }

	internal static void UpdateCurrentPlayerLoopWith(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop) { }

}

