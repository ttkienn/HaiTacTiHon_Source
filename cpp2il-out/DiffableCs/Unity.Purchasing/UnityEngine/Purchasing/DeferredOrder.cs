namespace UnityEngine.Purchasing;

public class DeferredOrder : Order
{

	[NullableContext(1)]
	public DeferredOrder(ICart cart, IOrderInfo info) { }

}

