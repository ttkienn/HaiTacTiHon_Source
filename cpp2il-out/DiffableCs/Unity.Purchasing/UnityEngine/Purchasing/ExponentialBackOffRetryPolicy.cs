namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class ExponentialBackOffRetryPolicy : IRetryPolicy
{
	[CompilerGenerated]
	private struct <ShouldRetry>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public ExponentialBackOffRetryPolicy <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public IRetryPolicyInformation info; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly int m_BaseRetryDelay; //Field offset: 0x10
	private readonly int m_MaxRetryDelay; //Field offset: 0x14
	private readonly float m_ExponentialFactor; //Field offset: 0x18
	private readonly int m_MaxNumberOfRetriesBeforeCeiling; //Field offset: 0x1C
	private readonly IAsyncDelayer m_Delayer; //Field offset: 0x20

	public ExponentialBackOffRetryPolicy(int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2) { }

	internal ExponentialBackOffRetryPolicy(IAsyncDelayer delayer, int baseRetryDelay = 1000, int maxRetryDelay = 30000, float exponentialFactor = 2) { }

	private int AdjustDelay(int numberOfRetries) { }

	private int CalculateMaxNumberOfRetriesBeforeCeiling(int baseRetryDelay, int maxRetryDelay, float exponentialFactor) { }

	private bool HasHitMaxRetryDelay(int numberOfRetries) { }

	[AsyncStateMachine(typeof(<ShouldRetry>d__9))]
	public override Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

	private static void ValidateArguments(int baseRetryDelay, int maxRetryDelay, float exponentialFactor) { }

}

