namespace UnityEngine.Purchasing.Interfaces;

internal interface IGoogleFinishTransactionUseCase
{

	public Task FinishTransaction(ProductDefinition product, string purchaseToken, Action<IGoogleBillingResult, IGooglePurchase> onTransactionFinished) { }

}

