namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IGooglePurchaseService
{

	public void Purchase(ProductDefinition product, Order currentOrder, Nullable<GooglePlayReplacementMode> desiredReplacementMode) { }

	public void SetProductCache(IProductCache productCache) { }

}

