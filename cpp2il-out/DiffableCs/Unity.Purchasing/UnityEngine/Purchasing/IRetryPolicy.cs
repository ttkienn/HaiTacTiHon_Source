namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IRetryPolicy
{

	public Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

}

