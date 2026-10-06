namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePurchaseService : IGooglePurchaseService
{
	[CompilerGenerated]
	private struct <Purchase>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public GooglePurchaseService <>4__this; //Field offset: 0x28
		[Nullable(0)]
		public ProductDefinition product; //Field offset: 0x30
		[Nullable(0)]
		public Order currentOrder; //Field offset: 0x38
		public Nullable<GooglePlayReplacementMode> desiredReplacementMode; //Field offset: 0x40
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 1}])]
		private TaskAwaiter<List`1<AndroidJavaObject>> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IGoogleBillingClient m_BillingClient; //Field offset: 0x10
	private readonly IGooglePurchaseCallback m_GooglePurchaseCallback; //Field offset: 0x18
	private readonly IQueryProductDetailsService m_QueryProductDetailsService; //Field offset: 0x20
	private readonly ILogger m_Logger; //Field offset: 0x28
	[Nullable(2)]
	private IProductCache m_ProductCache; //Field offset: 0x30

	[Preserve]
	internal GooglePurchaseService(IGoogleBillingClient billingClient, IGooglePurchaseCallback googlePurchaseCallback, IQueryProductDetailsService queryProductDetailsService, ILogger logger) { }

	private void HandleBillingFlowResult(IGoogleBillingResult billingResult, AndroidJavaObject sku) { }

	private void LaunchGoogleBillingFlow(AndroidJavaObject productToPurchase, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	private void OnQueryProductDetailsResponse(List<AndroidJavaObject> productDetailsList, ProductDefinition productToBuy, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	[AsyncStateMachine(typeof(<Purchase>d__6))]
	public override void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	private void PurchaseFailedInvalidOldProduct(ProductDefinition productToBuy, Order currentOrder) { }

	private void PurchaseFailedSkuNotFound(ProductDefinition productToBuy) { }

	[NullableContext(2)]
	public override void SetProductCache(IProductCache productCache) { }

	[NullableContext(2)]
	private static bool ValidateCurrentOrder(Order currentOrder) { }

	private bool ValidateQueryProductDetailsResponseParams(List<AndroidJavaObject> skus, ProductDefinition productToBuy, Order currentOrder) { }

	private bool ValidateSkus(List<AndroidJavaObject> skus) { }

	private void VerifyAndWarnIfMoreThanOneSku(List<AndroidJavaObject> skus) { }

}

