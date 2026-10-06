namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IPurchasedProductInfo
{

	public string productId
	{
		 get { } //Length: 0
	}

	[Nullable(2)]
	public SubscriptionInfo subscriptionInfo
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public string get_productId() { }

	[NullableContext(2)]
	public SubscriptionInfo get_subscriptionInfo() { }

}

