namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class JavaBridge : AndroidJavaProxy, IUnityCallback
{
	private readonly IUnityCallback forwardTo; //Field offset: 0x20

	public JavaBridge(IUnityCallback forwardTo) { }

	public JavaBridge(IUnityCallback forwardTo, string javaInterface) { }

	public override void OnProductsFetched(string json) { }

	public override void OnProductsFetchFailed(string jsonFailureDescription) { }

	public override void OnPurchaseDeferred(string json) { }

	public override void OnPurchaseFailed(string json) { }

	public override void OnPurchasesFetched(string json) { }

	public override void OnPurchasesRetrievalFailed(string jsonFailureDescription) { }

	public override void OnPurchaseSucceeded(string id, string receipt, string transactionID) { }

	public override void OnStoreConnectionFailed(string jsonFailureDescription) { }

	public override void OnStoreConnectionSucceeded() { }

}

