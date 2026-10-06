namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
public class PurchaseFailureDescription
{
	[CompilerGenerated]
	private CartItem <item>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private PurchaseFailureReason <reason>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <message>k__BackingField; //Field offset: 0x20

	public private CartItem item
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	public private string message
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	[Obsolete("Use item.Product instead")]
	public Product product
	{
		 get { } //Length: 27
	}

	public private PurchaseFailureReason reason
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PurchaseFailureDescription(CartItem item, PurchaseFailureReason reason, string message) { }

	internal FailedOrder ConvertToFailedOrder(string transactionId = "") { }

	[CompilerGenerated]
	public CartItem get_item() { }

	[CompilerGenerated]
	public string get_message() { }

	public Product get_product() { }

	[CompilerGenerated]
	public PurchaseFailureReason get_reason() { }

	[CompilerGenerated]
	private void set_item(CartItem value) { }

	[CompilerGenerated]
	private void set_message(string value) { }

	[CompilerGenerated]
	private void set_reason(PurchaseFailureReason value) { }

}

