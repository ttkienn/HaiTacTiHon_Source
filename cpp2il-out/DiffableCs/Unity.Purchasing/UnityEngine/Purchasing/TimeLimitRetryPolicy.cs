namespace UnityEngine.Purchasing;

public class TimeLimitRetryPolicy : IRetryPolicy
{
	private readonly float m_TimeLimit; //Field offset: 0x10

	public TimeLimitRetryPolicy(float timeLimit) { }

	[NullableContext(1)]
	public override Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

}

