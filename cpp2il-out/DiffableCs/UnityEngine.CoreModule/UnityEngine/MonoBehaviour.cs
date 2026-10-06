namespace UnityEngine;

[ExtensionOfNativeClass]
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class MonoBehaviour : Behaviour
{
	private CancellationTokenSource m_CancellationTokenSource; //Field offset: 0x18

	public CancellationToken destroyCancellationToken
	{
		 get { } //Length: 388
	}

	public bool useGUILayout
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MonoBehaviour() { }

	[FreeFunction]
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	public void CancelInvoke(string methodName) { }

	public void CancelInvoke() { }

	public CancellationToken get_destroyCancellationToken() { }

	public bool get_useGUILayout() { }

	internal string GetScriptClassName() { }

	[FreeFunction("CancelInvoke")]
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	public void Invoke(string methodName, float time) { }

	[FreeFunction]
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	public bool IsInvoking() { }

	public bool IsInvoking(string methodName) { }

	[FreeFunction]
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	private static bool IsObjectMonoBehaviour(object obj) { }

	private void OnCancellationTokenCreated() { }

	public static void print(object message) { }

	[RequiredByNativeCode]
	private void RaiseCancellation() { }

	public void set_useGUILayout(bool value) { }

	public Coroutine StartCoroutine(IEnumerator routine) { }

	public Coroutine StartCoroutine(string methodName, object value) { }

	[ExcludeFromDocs]
	public Coroutine StartCoroutine(string methodName) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	public void StopAllCoroutines() { }

	public void StopCoroutine(string methodName) { }

	public void StopCoroutine(Coroutine routine) { }

	public void StopCoroutine(IEnumerator routine) { }

	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	private void StopCoroutineManaged(Coroutine routine) { }

}

