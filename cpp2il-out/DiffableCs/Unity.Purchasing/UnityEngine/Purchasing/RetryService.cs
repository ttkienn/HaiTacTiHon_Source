namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class RetryService : IRetryService
{
	private readonly IUtil m_Util; //Field offset: 0x10

	internal RetryService(IUtil util) { }

	public override IRetryRequest CreateRequest(Action request, IRetryPolicy retryPolicy) { }

}

