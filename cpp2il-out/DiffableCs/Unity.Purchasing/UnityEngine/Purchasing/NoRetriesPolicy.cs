namespace UnityEngine.Purchasing;

public class NoRetriesPolicy : IRetryPolicy
{

	public NoRetriesPolicy() { }

	public override Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

}

