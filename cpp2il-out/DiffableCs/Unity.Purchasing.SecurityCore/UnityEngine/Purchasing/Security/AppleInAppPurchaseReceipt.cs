namespace UnityEngine.Purchasing.Security;

public class AppleInAppPurchaseReceipt : IPurchaseReceipt
{
	[CompilerGenerated]
	private int <quantity>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <productID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <transactionID>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <originalTransactionIdentifier>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DateTime <purchaseDate>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private DateTime <originalPurchaseDate>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private DateTime <subscriptionExpirationDate>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private DateTime <cancellationDate>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <isFreeTrial>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private int <productType>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <isIntroductoryPricePeriod>k__BackingField; //Field offset: 0x58

	public internal DateTime cancellationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal int isFreeTrial
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal int isIntroductoryPricePeriod
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal DateTime originalPurchaseDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal string originalTransactionIdentifier
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal override string productID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public internal int productType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal override DateTime purchaseDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal int quantity
	{
		[CompilerGenerated]
		 get { } //Length: 191
		[CompilerGenerated]
		internal set { } //Length: 4
	}

	public internal DateTime subscriptionExpirationDate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	public internal override string transactionID
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 13
	}

	public AppleInAppPurchaseReceipt() { }

	[CompilerGenerated]
	public DateTime get_cancellationDate() { }

	[CompilerGenerated]
	public int get_isFreeTrial() { }

	[CompilerGenerated]
	public int get_isIntroductoryPricePeriod() { }

	[CompilerGenerated]
	public DateTime get_originalPurchaseDate() { }

	[CompilerGenerated]
	public string get_originalTransactionIdentifier() { }

	[CompilerGenerated]
	public override string get_productID() { }

	[CompilerGenerated]
	public int get_productType() { }

	[CompilerGenerated]
	public override DateTime get_purchaseDate() { }

	[CompilerGenerated]
	public int get_quantity() { }

	[CompilerGenerated]
	public DateTime get_subscriptionExpirationDate() { }

	[CompilerGenerated]
	public override string get_transactionID() { }

	[CompilerGenerated]
	internal void set_cancellationDate(DateTime value) { }

	[CompilerGenerated]
	internal void set_isFreeTrial(int value) { }

	[CompilerGenerated]
	internal void set_isIntroductoryPricePeriod(int value) { }

	[CompilerGenerated]
	internal void set_originalPurchaseDate(DateTime value) { }

	[CompilerGenerated]
	internal void set_originalTransactionIdentifier(string value) { }

	[CompilerGenerated]
	internal void set_productID(string value) { }

	[CompilerGenerated]
	internal void set_productType(int value) { }

	[CompilerGenerated]
	internal void set_purchaseDate(DateTime value) { }

	[CompilerGenerated]
	internal void set_quantity(int value) { }

	[CompilerGenerated]
	internal void set_subscriptionExpirationDate(DateTime value) { }

	[CompilerGenerated]
	internal void set_transactionID(string value) { }

}

