namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public abstract class ExtensiblePurchaseService : IPurchaseService
{
	private IPurchaseService m_BaseInternalPurchaseService; //Field offset: 0x10

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Entitlement> OnCheckEntitlement
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Order> OnPurchaseConfirmed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<DeferredOrder> OnPurchaseDeferred
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<FailedOrder> OnPurchaseFailed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PendingOrder> OnPurchasePending
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<Orders> OnPurchasesFetched
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public override event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
	{
		 add { } //Length: 88
		 remove { } //Length: 88
	}

	[Nullable(2)]
	public override IAppleStoreExtendedPurchaseService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 70
	}

	[Nullable(2)]
	public override IGooglePlayStoreExtendedPurchaseService Google
	{
		[NullableContext(2)]
		 get { } //Length: 73
	}

	protected ExtensiblePurchaseService(IPurchaseService basePurchaseService) { }

	public override void add_OnCheckEntitlement(Action<Entitlement> value) { }

	public override void add_OnPurchaseConfirmed(Action<Order> value) { }

	public override void add_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	public override void add_OnPurchaseFailed(Action<FailedOrder> value) { }

	public override void add_OnPurchasePending(Action<PendingOrder> value) { }

	public override void add_OnPurchasesFetched(Action<Orders> value) { }

	public override void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	public override void CheckEntitlement(Product product) { }

	public override void ConfirmPurchase(PendingOrder order) { }

	public override void FetchPurchases() { }

	[NullableContext(2)]
	public override IAppleStoreExtendedPurchaseService get_Apple() { }

	[NullableContext(2)]
	public override IGooglePlayStoreExtendedPurchaseService get_Google() { }

	public override ReadOnlyObservableCollection<Order> GetPurchases() { }

	public override void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess) { }

	public override void Purchase(ICart cart) { }

	public override void PurchaseProduct(Product product) { }

	public override void remove_OnCheckEntitlement(Action<Entitlement> value) { }

	public override void remove_OnPurchaseConfirmed(Action<Order> value) { }

	public override void remove_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	public override void remove_OnPurchaseFailed(Action<FailedOrder> value) { }

	public override void remove_OnPurchasePending(Action<PendingOrder> value) { }

	public override void remove_OnPurchasesFetched(Action<Orders> value) { }

	public override void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	[NullableContext(2)]
	public override void RestoreTransactions(Action<Boolean, String> callback) { }

}

