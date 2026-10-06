namespace UnityEngine.Purchasing;

internal interface IConfirmOrderUseCase
{

	public void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> action) { }

}

