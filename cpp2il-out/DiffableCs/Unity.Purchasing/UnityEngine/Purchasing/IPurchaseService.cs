namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IPurchaseService
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<Entitlement> OnCheckEntitlement
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<Order> OnPurchaseConfirmed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<DeferredOrder> OnPurchaseDeferred
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<FailedOrder> OnPurchaseFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<PendingOrder> OnPurchasePending
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<Orders> OnPurchasesFetched
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<PurchasesFetchFailureDescription> OnPurchasesFetchFailed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[Nullable(2)]
	public IAppleStoreExtendedPurchaseService Apple
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[Nullable(2)]
	public IGooglePlayStoreExtendedPurchaseService Google
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnCheckEntitlement(Action<Entitlement> value) { }

	[CompilerGenerated]
	public void add_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	public void add_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public void add_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public void add_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	public void add_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	public void add_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	public void CheckEntitlement(Product product) { }

	public void ConfirmPurchase(PendingOrder order) { }

	public void FetchPurchases() { }

	[NullableContext(2)]
	public IAppleStoreExtendedPurchaseService get_Apple() { }

	[NullableContext(2)]
	public IGooglePlayStoreExtendedPurchaseService get_Google() { }

	public ReadOnlyObservableCollection<Order> GetPurchases() { }

	public void ProcessPendingOrdersOnPurchasesFetched(bool shouldProcess) { }

	public void Purchase(ICart cart) { }

	public void PurchaseProduct(Product product) { }

	[CompilerGenerated]
	public void remove_OnCheckEntitlement(Action<Entitlement> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseConfirmed(Action<Order> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseDeferred(Action<DeferredOrder> value) { }

	[CompilerGenerated]
	public void remove_OnPurchaseFailed(Action<FailedOrder> value) { }

	[CompilerGenerated]
	public void remove_OnPurchasePending(Action<PendingOrder> value) { }

	[CompilerGenerated]
	public void remove_OnPurchasesFetched(Action<Orders> value) { }

	[CompilerGenerated]
	public void remove_OnPurchasesFetchFailed(Action<PurchasesFetchFailureDescription> value) { }

	[NullableContext(2)]
	public void RestoreTransactions(Action<Boolean, String> callback) { }

}

