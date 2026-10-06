namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class GooglePurchaseConverter : IGooglePurchaseConverter
{

	[Preserve]
	internal GooglePurchaseConverter(IProductDetailsConverter productDetailsConverter) { }

	public override ICart CreateCartFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

	public override Order CreateOrderFromPurchase(IGooglePurchase purchase, IProductCache productCache) { }

	private Product DefaultProduct(IGooglePurchase purchase) { }

}

