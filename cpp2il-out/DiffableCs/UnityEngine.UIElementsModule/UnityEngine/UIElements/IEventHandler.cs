namespace UnityEngine.UIElements;

public interface IEventHandler
{

	public void HandleEvent(EventBase evt) { }

	public void SendEvent(EventBase e) { }

}

