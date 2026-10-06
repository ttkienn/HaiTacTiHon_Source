namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IRetryService
{

	public IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy) { }

}

