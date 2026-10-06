namespace UnityEngine.Purchasing.Interfaces;

[NullableContext(1)]
internal interface IGooglePurchase
{

	[Nullable(2)]
	public string obfuscatedAccountId
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	[Nullable(2)]
	public string obfuscatedProfileId
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public string orderId
	{
		 get { } //Length: 0
	}

	public string originalJson
	{
		 get { } //Length: 0
	}

	public IEnumerable<ProductDescription> productDescriptions
	{
		 get { } //Length: 0
	}

	public int purchaseState
	{
		 get { } //Length: 0
	}

	public string purchaseToken
	{
		 get { } //Length: 0
	}

	public string receipt
	{
		 get { } //Length: 0
	}

	public string signature
	{
		 get { } //Length: 0
	}

	[Nullable(2)]
	public string sku
	{
		[NullableContext(2)]
		 get { } //Length: 0
	}

	public List<String> skus
	{
		 get { } //Length: 0
	}

	[NullableContext(2)]
	public string get_obfuscatedAccountId() { }

	[NullableContext(2)]
	public string get_obfuscatedProfileId() { }

	public string get_orderId() { }

	public string get_originalJson() { }

	public IEnumerable<ProductDescription> get_productDescriptions() { }

	public int get_purchaseState() { }

	public string get_purchaseToken() { }

	public string get_receipt() { }

	public string get_signature() { }

	[NullableContext(2)]
	public string get_sku() { }

	public List<String> get_skus() { }

	public bool IsAcknowledged() { }

	public bool IsPending() { }

	public bool IsPurchased() { }

}

