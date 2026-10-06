namespace UnityEngine.Purchasing;

public class PendingOrder : Order
{

	[NullableContext(1)]
	public PendingOrder(ICart cart, IOrderInfo info) { }

}

