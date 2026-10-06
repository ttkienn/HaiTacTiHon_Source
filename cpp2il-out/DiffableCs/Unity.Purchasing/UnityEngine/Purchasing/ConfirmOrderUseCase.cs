namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class ConfirmOrderUseCase : IConfirmOrderUseCase, IStorePurchaseConfirmCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		[Nullable(0)]
		public PendingOrder orderToCheckFor; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal bool <FindExistingConfirmationRequest>b__0(ConfirmOrderRequest request) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		[Nullable(0)]
		public string transactionIdentifier; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		[NullableContext(0)]
		internal bool <GetMatchingRequest>b__0(ConfirmOrderRequest request) { }

	}

	private readonly IStore m_Store; //Field offset: 0x10
	private readonly List<ConfirmOrderRequest> m_ConfirmationRequests; //Field offset: 0x18

	[Preserve]
	internal ConfirmOrderUseCase(IStore storeResponsible) { }

	private void AddAndSendFinishTransactionRequest(PendingOrder order, Action<PendingOrder, Order> confirmationAction) { }

	public override void ConfirmOrder(PendingOrder order, Action<PendingOrder, Order> confirmationAction) { }

	private bool FindExistingConfirmationRequest(PendingOrder orderToCheckFor) { }

	private ConfirmOrderRequest GetMatchingRequest(string transactionIdentifier) { }

	public override void OnConfirmOrderFailed(FailedOrder failedOrder) { }

	public override void OnConfirmOrderSucceeded(string transactionId) { }

}

