namespace UnityEngine.Purchasing.Interfaces;

internal interface IProductDetailsQueryResponse
{

	public void AddResponse(IGoogleBillingResult billingResult, IEnumerable<AndroidJavaObject> productDetails) { }

	public GoogleBillingResponseCode GetRecoverableBillingResponseCode() { }

	public bool IsRecoverable() { }

	public List<AndroidJavaObject> ProductDetails() { }

}

