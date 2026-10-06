namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IRetryRequest
{

	public Task<Boolean> Invoke() { }

	public Task<Boolean> Retry(IRetryableRequestFailureDescription requestFailureDescription) { }

}

