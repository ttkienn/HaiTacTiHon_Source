namespace UnityEngine.Purchasing;

internal class SubscriptionChangeRequest
{
	private readonly Action<DeferredPaymentUntilRenewalDateOrder> m_OnPurchaseDeferredUntilRenewalDate; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Order <CurrentOrder>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly Product <NewSubscription>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly GooglePlayReplacementMode <ReplacementMode>k__BackingField; //Field offset: 0x28

	internal Order CurrentOrder
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal Product NewSubscription
	{
		[CompilerGenerated]
		internal get { } //Length: 5
	}

	internal GooglePlayReplacementMode ReplacementMode
	{
		[CompilerGenerated]
		internal get { } //Length: 4
	}

	internal SubscriptionChangeRequest(Order currentOrder, Product newSubscription, GooglePlayReplacementMode replacementMode) { }

	[CompilerGenerated]
	internal Order get_CurrentOrder() { }

	[CompilerGenerated]
	internal Product get_NewSubscription() { }

	[CompilerGenerated]
	internal GooglePlayReplacementMode get_ReplacementMode() { }

}

