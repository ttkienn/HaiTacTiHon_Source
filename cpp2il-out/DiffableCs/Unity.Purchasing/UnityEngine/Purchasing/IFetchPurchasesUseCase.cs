namespace UnityEngine.Purchasing;

internal interface IFetchPurchasesUseCase
{

	public void FetchPurchases(Action<Orders> fetchSuccessAction, Action<PurchasesFetchFailureDescription> fetchFailureAction) { }

}

