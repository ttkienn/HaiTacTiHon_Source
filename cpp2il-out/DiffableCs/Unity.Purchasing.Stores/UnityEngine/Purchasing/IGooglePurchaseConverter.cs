namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IGooglePurchaseConverter
{

	public ICart CreateCartFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

	public Order CreateOrderFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

}

