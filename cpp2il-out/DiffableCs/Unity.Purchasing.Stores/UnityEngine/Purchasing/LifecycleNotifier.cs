namespace UnityEngine.Purchasing;

internal class LifecycleNotifier : MonoBehaviour
{
	public Action OnDestroyCallback; //Field offset: 0x20

	public LifecycleNotifier() { }

	private void OnDestroy() { }

}

