namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class AggregateRetryPolicy : IRetryPolicy
{
	[CompilerGenerated]
	private struct <ShouldRetry>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[Nullable(0)]
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		[Nullable(0)]
		public AggregateRetryPolicy <>4__this; //Field offset: 0x20
		[Nullable(0)]
		public IRetryPolicyInformation info; //Field offset: 0x28
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1}])]
		private Enumerator<IRetryPolicy> <>7__wrap1; //Field offset: 0x30
		[Nullable(0)]
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly List<IRetryPolicy> m_RetryPolicies; //Field offset: 0x10

	public AggregateRetryPolicy(List<IRetryPolicy> retryPolicies) { }

	public AggregateRetryPolicy(IRetryPolicy[] retryPolicies) { }

	[AsyncStateMachine(typeof(<ShouldRetry>d__3))]
	public override Task<Boolean> ShouldRetry(IRetryPolicyInformation info) { }

}

