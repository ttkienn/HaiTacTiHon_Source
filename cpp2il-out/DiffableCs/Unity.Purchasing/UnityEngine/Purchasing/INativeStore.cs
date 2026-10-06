namespace UnityEngine.Purchasing;

public interface INativeStore
{

	public bool CheckEntitlement(string productJSON) { }

	public void Connect() { }

	public void FetchExistingPurchases() { }

	public void FetchProducts(string json) { }

	public void FinishTransaction(string productJSON, string transactionID) { }

	public void Purchase(string productJson, string optionsJson) { }

}

