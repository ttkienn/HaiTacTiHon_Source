namespace UnityEngine.Purchasing;

public class Product
{
	[CompilerGenerated]
	private ProductDefinition <definition>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ProductMetadata <metadata>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <availableToPurchase>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <transactionID>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <appleOriginalTransactionID>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <appleProductIsRestored>k__BackingField; //Field offset: 0x38
	private string m_Receipt; //Field offset: 0x40

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public internal string appleOriginalTransactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public internal bool appleProductIsRestored
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal bool availableToPurchase
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public private ProductDefinition definition
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 13
	}

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public bool hasReceipt
	{
		 get { } //Length: 60
	}

	public internal ProductMetadata metadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public internal string receipt
	{
		 get { } //Length: 408
		internal set { } //Length: 107
	}

	[Obsolete("This API is deprecated. Please upgrade to the new APIs introduced in IAP v5. For more information, visit the IAP manual: https://docs.unity.com/ugs/en-us/manual/iap/manual/upgrade-to-iap-v5", False)]
	public internal string transactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	[Obsolete("This constructor is obsolete and should not be used. Use the Product(ProductDefinition, ProductMetadata) constructor and assign the receipt separately if needed.")]
	internal Product(ProductDefinition definition, ProductMetadata metadata, string receipt) { }

	internal Product(ProductDefinition definition, ProductMetadata metadata) { }

	private static string CreateUnifiedReceipt(string rawReceipt, string transactionId, string storeName) { }

	internal static Product CreateUnknownProduct(string productId) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public string get_appleOriginalTransactionID() { }

	[CompilerGenerated]
	public bool get_appleProductIsRestored() { }

	[CompilerGenerated]
	public bool get_availableToPurchase() { }

	[CompilerGenerated]
	public ProductDefinition get_definition() { }

	public bool get_hasReceipt() { }

	[CompilerGenerated]
	public ProductMetadata get_metadata() { }

	public string get_receipt() { }

	[CompilerGenerated]
	public string get_transactionID() { }

	public virtual int GetHashCode() { }

	private string GetReceipt() { }

	[CompilerGenerated]
	internal void set_appleOriginalTransactionID(string value) { }

	[CompilerGenerated]
	internal void set_appleProductIsRestored(bool value) { }

	[CompilerGenerated]
	internal void set_availableToPurchase(bool value) { }

	[CompilerGenerated]
	private void set_definition(ProductDefinition value) { }

	[CompilerGenerated]
	internal void set_metadata(ProductMetadata value) { }

	internal void set_receipt(string value) { }

	[CompilerGenerated]
	internal void set_transactionID(string value) { }

	private void SetReceipt(string curReceipt) { }

	public virtual string ToString() { }

}

