namespace UnityEngine.Purchasing;

public class MaximumNumberOfAttemptsRetryPolicy : IRetryPolicy
{
	private readonly int m_MaximumNumberOfAttempts; //Field offset: 0x10

	public MaximumNumberOfAttemptsRetryPolicy(int maximumNumberOfAttempts) { }

	[NullableContext(1)]
	public override Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

}

