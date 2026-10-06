namespace UnityEngine.UIElements;

internal class MouseCaptureDispatchingStrategy : IEventDispatchingStrategy
{
	[Flags]
	private enum EventBehavior
	{
		None = 0,
		IsCapturable = 1,
		IsSentExclusivelyToCapturingElement = 2,
	}


	public MouseCaptureDispatchingStrategy() { }

	public override bool CanDispatchEvent(EventBase evt) { }

	public override void DispatchEvent(EventBase evt, IPanel panel) { }

}

