namespace UnityEngine.Playables;

[RequiredByNativeCode]
public interface INotificationReceiver
{

	[RequiredByNativeCode]
	public void OnNotify(Playable origin, INotification notification, object context) { }

}

