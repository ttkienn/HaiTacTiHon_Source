namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IGoogleQueryPurchasesUseCase
{

	[NullableContext(2)]
	public Task<IGooglePurchase> GetPurchaseByToken(string purchaseToken) { }

	public Task<List`1<IGooglePurchase>> QueryPurchases() { }

}

