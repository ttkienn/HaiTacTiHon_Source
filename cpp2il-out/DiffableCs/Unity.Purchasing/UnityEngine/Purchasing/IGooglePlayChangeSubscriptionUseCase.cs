namespace UnityEngine.Purchasing;

[NullableContext(1)]
internal interface IGooglePlayChangeSubscriptionUseCase
{

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public event Action<DeferredPaymentUntilRenewalDateOrder> OnDeferredPaymentUntilRenewalDate
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

	public void ChangeSubscription(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode) { }

	[CompilerGenerated]
	public void remove_OnDeferredPaymentUntilRenewalDate(Action<DeferredPaymentUntilRenewalDateOrder> value) { }

}

