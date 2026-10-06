namespace UnityEngine.Purchasing.Models;

internal class GoogleBillingClient : IGoogleBillingClient
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public string type; //Field offset: 0x10

		public <>c__DisplayClass47_0() { }

		internal AndroidJavaObject <QueryProductDetailsParamsProductList>b__0(string product) { }

	}

	private const string k_AndroidProductClassName = "com.android.billingclient.api.QueryProductDetailsParams$Product"; //Field offset: 0x0
	private const string k_AndroidQueryPurchasesParamsClassName = "com.android.billingclient.api.QueryPurchasesParams"; //Field offset: 0x0
	private const string k_AndroidPendingPurchasesParamsClassName = "com.android.billingclient.api.PendingPurchasesParams"; //Field offset: 0x0
	private const string k_AndroidBillingClientClassName = "com.android.billingclient.api.BillingClient"; //Field offset: 0x0
	private const string k_AndroidConsumeParamsClassName = "com.android.billingclient.api.ConsumeParams"; //Field offset: 0x0
	private const string k_AndroidSubscriptionUpdateParamClassName = "com.android.billingclient.api.BillingFlowParams$SubscriptionUpdateParams"; //Field offset: 0x0
	private const string k_AndroidAcknowledgePurchaseParamsClassName = "com.android.billingclient.api.AcknowledgePurchaseParams"; //Field offset: 0x0
	private const string k_AndroidBillingFlowParamClassName = "com.android.billingclient.api.BillingFlowParams"; //Field offset: 0x0
	private static AndroidJavaClass s_AndroidProductClassName; //Field offset: 0x0
	private const string k_AndroidProductDetailsParamsClassName = "com.android.billingclient.api.BillingFlowParams$ProductDetailsParams"; //Field offset: 0x0
	private const string k_AndroidQueryProductDetailsParamsClassName = "com.android.billingclient.api.QueryProductDetailsParams"; //Field offset: 0x0
	private static AndroidJavaClass s_AndroidQueryProductDetailsParamsClassName; //Field offset: 0x8
	private static AndroidJavaClass s_BillingFlowParamsClass; //Field offset: 0x10
	private static AndroidJavaClass s_ProductDetailsParamsClass; //Field offset: 0x18
	private static AndroidJavaClass s_SubscriptionUpdateParamsClass; //Field offset: 0x20
	private static AndroidJavaClass s_ConsumeParamsClass; //Field offset: 0x28
	private static AndroidJavaClass s_AcknowledgePurchaseParamsClass; //Field offset: 0x30
	private static AndroidJavaClass s_BillingClientClass; //Field offset: 0x38
	private static AndroidJavaClass s_PendingPurchasesParamsClass; //Field offset: 0x40
	private static AndroidJavaClass s_QueryPurchasesParamsClass; //Field offset: 0x48
	private readonly AndroidJavaObject m_BillingClient; //Field offset: 0x10
	private string m_ObfuscatedAccountId; //Field offset: 0x18
	private string m_ObfuscatedProfileId; //Field offset: 0x20
	private readonly IUtil m_Util; //Field offset: 0x28
	private readonly ITelemetryDiagnostics m_TelemetryDiagnostics; //Field offset: 0x30

	[Preserve]
	internal GoogleBillingClient(IGooglePurchasesUpdatedListener googlePurchasesUpdatedListener, IUtil util, ITelemetryDiagnostics telemetryDiagnostics) { }

	public override void AcknowledgePurchase(string purchaseToken, Action<IGoogleBillingResult> onAcknowledge) { }

	private static AndroidJavaObject BuildSubscriptionUpdateParams(string oldPurchaseToken, GooglePlayReplacementMode replacementMode) { }

	public override void ConsumeAsync(string purchaseToken, Action<IGoogleBillingResult> onConsume) { }

	public override void EndConnection() { }

	private static AndroidJavaClass GetAcknowledgePurchaseParamsClass() { }

	private static AndroidJavaClass GetBillingClientClass() { }

	private static AndroidJavaClass GetBillingFlowParamClass() { }

	public override GoogleBillingConnectionState GetConnectionState() { }

	private static AndroidJavaClass GetConsumeParamsClass() { }

	private static AndroidJavaClass GetPendingPurchasesParamsClass() { }

	private static AndroidJavaClass GetProductDetailsParamsClass() { }

	private static AndroidJavaClass GetProductParamsClass() { }

	private static AndroidJavaClass GetQueryProductDetailsParamsParamsClass() { }

	private static AndroidJavaClass GetQueryPurchasesParamsClass() { }

	private static AndroidJavaClass GetSubscriptionUpdateParamClass() { }

	public override bool IsReady() { }

	public override AndroidJavaObject LaunchBillingFlow(AndroidJavaObject productDetails, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode) { }

	private AndroidJavaObject MakeBillingFlowParams(AndroidJavaObject productDetailsParamsList, string oldPurchaseToken, Nullable<GooglePlayReplacementMode> replacementMode) { }

	private static AndroidJavaObject PendingPurchasesParams() { }

	public override void QueryProductDetailsAsync(List<String> products, string type, Action<IGoogleBillingResult, List`1<AndroidJavaObject>> onProductDetailsResponseAction) { }

	private static AndroidJavaObject QueryProductDetailsParams(List<String> products, string type) { }

	private static AndroidJavaObject QueryProductDetailsParamsProduct(string type, string product) { }

	private static AndroidJavaObject QueryProductDetailsParamsProductList(List<String> products, string type) { }

	public override void QueryPurchasesAsync(string productType, Action<IGoogleBillingResult, IEnumerable`1<AndroidJavaObject>> onQueryPurchasesResponse) { }

	private static AndroidJavaObject QueryPurchasesParams(string productType) { }

	private AndroidJavaObject SetObfuscatedAccountIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	private AndroidJavaObject SetObfuscatedProfileIdIfNeeded(AndroidJavaObject billingFlowParams) { }

	public override void SetObfuscationAccountId(string obfuscationAccountId) { }

	public override void SetObfuscationProfileId(string obfuscationProfileId) { }

	public override void StartConnection(IBillingClientStateListener billingClientStateListener) { }

}

