namespace UnityEngine.UIElements;

internal interface IEventDispatchingStrategy
{

	public bool CanDispatchEvent(EventBase evt) { }

	public void DispatchEvent(EventBase evt, IPanel panel) { }

}

