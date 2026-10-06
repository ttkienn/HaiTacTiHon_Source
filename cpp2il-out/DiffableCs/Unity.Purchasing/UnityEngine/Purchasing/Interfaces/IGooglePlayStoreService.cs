namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IGooglePlayStoreService
{

	public void CheckEntitlement(ProductDefinition product, Action<ProductDefinition, EntitlementStatus> onEntitlementChecked) { }

	public void FetchProducts(IReadOnlyCollection<ProductDefinition> products, Action<List`1<ProductDescription>> onProductsReceived, Action<GoogleFetchProductException> onFetchProductsFailed) { }

	public void FetchPurchases(Action<List`1<IGooglePurchase>> onQueryPurchaseSucceed, Action<String> onQueryPurchaseFailed) { }

	public Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

	public bool IsConnectionReady() { }

	public void Purchase(ProductDefinition product) { }

	public void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public void SetObfuscatedAccountId(string obfuscatedAccountId) { }

	public void SetObfuscatedProfileId(string obfuscatedProfileId) { }

}

