namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class PurchasedProductInfo : IPurchasedProductInfo
{
	[CompilerGenerated]
	private readonly string <productId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private SubscriptionInfo <subscriptionInfo>k__BackingField; //Field offset: 0x18

	public override string productId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[Nullable(2)]
	public private override SubscriptionInfo subscriptionInfo
	{
		[CompilerGenerated]
		[NullableContext(2)]
		 get { } //Length: 5
		[CompilerGenerated]
		[NullableContext(2)]
		private set { } //Length: 13
	}

	public PurchasedProductInfo(string productId, string receipt, ProductType productType) { }

	[CompilerGenerated]
	public override string get_productId() { }

	[CompilerGenerated]
	[NullableContext(2)]
	public override SubscriptionInfo get_subscriptionInfo() { }

	[CompilerGenerated]
	[NullableContext(2)]
	private void set_subscriptionInfo(SubscriptionInfo value) { }

	private void TryInitSubscriptionInfo(SubscriptionInfoHelper subscriptionInfoHelper) { }

}

