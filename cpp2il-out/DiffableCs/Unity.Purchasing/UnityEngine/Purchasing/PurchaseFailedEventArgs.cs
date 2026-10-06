namespace UnityEngine.Purchasing;

[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
public class PurchaseFailedEventArgs
{
	[CompilerGenerated]
	private Product <purchasedProduct>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private PurchaseFailureReason <reason>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <message>k__BackingField; //Field offset: 0x20

	public private string message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private Product purchasedProduct
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private PurchaseFailureReason reason
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	internal PurchaseFailedEventArgs(Product purchasedProduct, PurchaseFailureReason reason, string message) { }

	[CompilerGenerated]
	public string get_message() { }

	[CompilerGenerated]
	public Product get_purchasedProduct() { }

	[CompilerGenerated]
	public PurchaseFailureReason get_reason() { }

	[CompilerGenerated]
	private void set_message(string value) { }

	[CompilerGenerated]
	private void set_purchasedProduct(Product value) { }

	[CompilerGenerated]
	private void set_reason(PurchaseFailureReason value) { }

}

