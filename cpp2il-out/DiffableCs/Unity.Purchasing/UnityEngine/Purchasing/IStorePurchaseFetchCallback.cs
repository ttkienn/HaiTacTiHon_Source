namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IStorePurchaseFetchCallback
{

	public void OnAllPurchasesRetrieved(IReadOnlyList<Order> orders) { }

	public void OnPurchasesRetrievalFailed(PurchasesFetchFailureDescription failureReason) { }

}

