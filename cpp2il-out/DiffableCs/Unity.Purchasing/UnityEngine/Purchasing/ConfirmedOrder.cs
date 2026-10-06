namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class ConfirmedOrder : Order
{

	public ConfirmedOrder(ICart cart, IOrderInfo info) { }

	private List<IPurchasedProductInfo> FillPurchasedProductInfo() { }

}

