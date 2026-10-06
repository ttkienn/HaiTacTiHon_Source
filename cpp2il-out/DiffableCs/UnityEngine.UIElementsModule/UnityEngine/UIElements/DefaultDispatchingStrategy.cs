namespace UnityEngine.UIElements;

internal class DefaultDispatchingStrategy : IEventDispatchingStrategy
{

	public DefaultDispatchingStrategy() { }

	public override bool CanDispatchEvent(EventBase evt) { }

	public override void DispatchEvent(EventBase evt, IPanel panel) { }

}

