namespace UnityEngine.EventSystems;

public interface ICancelHandler : IEventSystemHandler
{

	public void OnCancel(BaseEventData eventData) { }

}

