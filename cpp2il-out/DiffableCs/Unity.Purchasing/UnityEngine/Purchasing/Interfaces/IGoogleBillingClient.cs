namespace UnityEngine.Purchasing.Interfaces;

internal interface IGoogleBillingClient
{

	public void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge) { }

	public void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume) { }

	public void EndConnection() { }

	public GoogleBillingConnectionState GetConnectionState() { }

	public bool IsReady() { }

	public AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode) { }

	public void QueryProductDetailsAsync(List<String> skus, string type, Action<IGoogleBillingResult, List`1<AndroidJavaObject>> onProductDetailsResponseAction) { }

	public void QueryPurchasesAsync(string skuType, Action<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> onQueryPurchasesResponse) { }

	public void SetObfuscationAccountId(string obfuscationAccountId) { }

	public void SetObfuscationProfileId(string obfuscationProfileId) { }

	public void StartConnection(IBillingClientStateListener billingClientStateListener) { }

}

