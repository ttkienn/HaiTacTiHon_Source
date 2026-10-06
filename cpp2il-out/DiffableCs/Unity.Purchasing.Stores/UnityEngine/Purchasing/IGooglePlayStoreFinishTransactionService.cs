namespace UnityEngine.Purchasing;

internal interface IGooglePlayStoreFinishTransactionService
{

	public void FinishTransaction(ProductDefinition product, string purchaseToken) { }

	public void SetConfirmCallback(IStorePurchaseConfirmCallback confirmCallback) { }

	public void SetProductCache(IProductCache productCache) { }

}

