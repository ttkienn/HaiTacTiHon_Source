namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class PurchaseEventArgs
{
	[CompilerGenerated]
	private Product <purchasedProduct>k__BackingField; //Field offset: 0x10

	public private Product purchasedProduct
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	internal PurchaseEventArgs(Product purchasedProduct) { }

	[CompilerGenerated]
	public Product get_purchasedProduct() { }

	[CompilerGenerated]
	private void set_purchasedProduct(Product value) { }

}

