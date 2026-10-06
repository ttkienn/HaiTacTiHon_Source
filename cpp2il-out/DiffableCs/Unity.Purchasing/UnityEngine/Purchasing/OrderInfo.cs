namespace UnityEngine.Purchasing;

[Nullable(0)]
[NullableContext(1)]
internal class OrderInfo : IOrderInfo
{
	[CompilerGenerated]
	private List<IPurchasedProductInfo> <PurchasedProductInfo>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <TransactionID>k__BackingField; //Field offset: 0x18
	private string m_Receipt; //Field offset: 0x20

	[Nullable(2)]
	public override IAppleOrderInfo Apple
	{
		[NullableContext(2)]
		 get { } //Length: 57
	}

	[Nullable(2)]
	public override IGoogleOrderInfo Google
	{
		[NullableContext(2)]
		 get { } //Length: 57
	}

	public override List<IPurchasedProductInfo> PurchasedProductInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 13
	}

	public private override string Receipt
	{
		 get { } //Length: 319
		private set { } //Length: 91
	}

	public override string TransactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public OrderInfo(string receipt, string transactionID, string storeName) { }

	private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName) { }

	[NullableContext(2)]
	public override IAppleOrderInfo get_Apple() { }

	[NullableContext(2)]
	public override IGoogleOrderInfo get_Google() { }

	[CompilerGenerated]
	public override List<IPurchasedProductInfo> get_PurchasedProductInfo() { }

	public override string get_Receipt() { }

	[CompilerGenerated]
	public override string get_TransactionID() { }

	private string GetReceipt() { }

	[CompilerGenerated]
	public override void set_PurchasedProductInfo(List<IPurchasedProductInfo> value) { }

	private void set_Receipt(string value) { }

	private void SetReceipt(string receipt) { }

}

