namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePlayPurchaseUseCase : PurchaseUseCase, IGooglePlayChangeSubscriptionUseCase, IGooglePlayChangeSubscriptionCallback, IStorePurchaseCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		[Nullable(0)]
		public string productId; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		[NullableContext(0)]
		internal bool <GetMatchingRequest>b__0(SubscriptionChangeRequest request) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		[Nullable(0)]
		public Product productToCheckFor; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <FindExistingPurchaseRequest>b__0(SubscriptionChangeRequest request) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		[Nullable(0)]
		public Order currentOrder; //Field offset: 0x10
		[Nullable(0)]
		public Product newSubscription; //Field offset: 0x18

		public <>c__DisplayClass9_0() { }

		internal bool <ConflictingSubscriptionChangeRequestExists>b__0(SubscriptionChangeRequest request) { }

	}

	private readonly List<SubscriptionChangeRequest> m_PendingRequests; //Field offset: 0x30
	private IProductCache m_ProductCache; //Field offset: 0x38
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate; //Field offset: 0x40

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate
	{
		[CompilerGenerated]
		 add { } //Length: 172
		[CompilerGenerated]
		 remove { } //Length: 172
	}

	internal GooglePlayPurchaseUseCase(IGooglePlayStore storeResponsible, IProductCache productCache) { }

	[CompilerGenerated]
	public override void add_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	private void AddAndSendSubscriptionChangeRequest(SubscriptionChangeRequest subscriptionChangeRequest) { }

	public override void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode) { }

	private bool ConflictingSubscriptionChangeRequestExists(Order currentOrder, Product newSubscription) { }

	private bool FindExistingPurchaseRequest(Product productToCheckFor) { }

	private SubscriptionChangeRequest GetMatchingRequest(string productId) { }

	[NullableContext(2)]
	private IGooglePlayStore GooglePlayStore() { }

	internal void InvokeOnDeferredPaymentUntilRenewalDate(DeferredPaymentUntilRenewalDateOrder pendingPurchase) { }

	private bool IsSubscriptionChangeValid(Order currentOrder, Product newSubscription) { }

	[NullableContext(2)]
	private static bool IsSubscriptionProductValid(Product subscription) { }

	public override void OnSubscriptionChange(string storeSpecificId) { }

	public override void OnSubscriptionChangeDeferredUntilRenewal(string storeSpecificId) { }

	private void OnSubscriptionChangeFailed(FailedOrder order) { }

	private void RejectPurchaseDueToPendingDuplicate(Product product) { }

	[CompilerGenerated]
	public override void remove_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

}

