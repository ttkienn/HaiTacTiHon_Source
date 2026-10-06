namespace Purchasing.Utilities;

internal interface IMonoBehaviourUtil
{

	public IEnumerator DelayedCoroutine(IEnumerator coroutine, int delay) { }

	public GameObject[] GetGameObjects() { }

	public Coroutine StartCoroutine(IEnumerator start) { }

}

