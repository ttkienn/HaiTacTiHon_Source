namespace UnityEngine.Purchasing;

[NullableContext(1)]
public interface IOrderInfo
{

	[Nullable(2)]
	public IAppleOrderInfo Apple
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[Nullable(2)]
	public IGoogleOrderInfo Google
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public List<IPurchasedProductInfo> PurchasedProductInfo
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string Receipt
	{
		 get { } //Length: 0
	}

	public string TransactionID
	{
		 get { } //Length: 0
	}

	[NullableContext(2)]
	public IAppleOrderInfo get_Apple() { }

	[NullableContext(2)]
	public IGoogleOrderInfo get_Google() { }

	public List<IPurchasedProductInfo> get_PurchasedProductInfo() { }

	public string get_Receipt() { }

	public string get_TransactionID() { }

	public void set_PurchasedProductInfo(List<IPurchasedProductInfo> value) { }

}

