namespace UnityEngine.Purchasing;

public class DeferredPaymentUntilRenewalDateOrder
{
	[CompilerGenerated]
	private readonly Order <CurrentOrder>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Product <SubscriptionOrdered>k__BackingField; //Field offset: 0x18

	public Order CurrentOrder
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Product SubscriptionOrdered
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public DeferredPaymentUntilRenewalDateOrder(Order currentOrder, Product subscriptionOrdered) { }

	[CompilerGenerated]
	public Order get_CurrentOrder() { }

	[CompilerGenerated]
	public Product get_SubscriptionOrdered() { }

}

